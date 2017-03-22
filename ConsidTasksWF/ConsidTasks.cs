using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ConsidTasksWF
{
    public partial class ConsidTasks : Form
    {
        public ConsidTasks()
        {
            InitializeComponent();
        }

        ///-------------------------------------------------------------------------
        ///                           TASK 1 
        ///-------------------------------------------------------------------------

        /// <summary>
        /// THIS BUTTON PROMTS YOU TO SELECT A FOLDER.
        /// </summary>
               
        private void select_Directory_Btn_Click(object sender, EventArgs e)
        {   
            //Saves the selected folder into a string in the textbox when the user presses "OK".
            FolderBrowserDialog fBD = new FolderBrowserDialog();
            if (fBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox_Selected_Directory.Text = fBD.SelectedPath;
            }
        }

        /// <summary>
        /// THIS BUTTON BEGINS THE SEARCH OF XML FILES IN THE GIVEN DIRECTORY AND ALL SUBDIRECTORIES.
        /// </summary>

        private void begin_Search_Btn_Click(object sender, EventArgs e)
        {
            //First we clear all lables from previous searches.
            label_accesibleFiles.Text = "";
            label_unaccesibleDirectories.Text = "";
            label_Search_Results.Text = "";

            //Checks if the user has selected a folder, otherwise promts user to do so.
            if (textBox_Selected_Directory.Text == "")
            {
                textBox_Selected_Directory.Text = "Please select directorty first";
            }
            else
            {
                //Shows the user that the program is processing.
                Cursor.Current = Cursors.WaitCursor;
               
                //Create our counters that will be referenced.
                int accessCount = 0;
                int deniedCount = 0;

                //We call on the method that will count the XML files.
                GetAllXmlFiles(textBox_Selected_Directory.Text, ref accessCount, ref deniedCount); 
                
                //We present the result into our labels and tell the user that the search has finished.
                label_accesibleFiles.Text = accessCount.ToString();
                label_unaccesibleDirectories.Text = deniedCount.ToString();
                label_Search_Results.Text = "Search finished!";

            }
        }

        /// <summary>
        /// THIS METHOD SEARCHES TO FIND XML FILES IN THE GIVEN DIRECTORY AND ALL SUBDIRECTORIES.
        /// </summary>
        /// <param name="pathDir">The name of the directory we're currently in</param>
        /// <param name="accessCount">Int which will count the number of found XML-files</param>
        /// <param name="deniedCount">Int which will count the number of failed directory entries because of denied permission to access them</param>

        public static void GetAllXmlFiles(string pathDir, ref int accessCount, ref int deniedCount)
        {
            try
            {
                //We search the directory we're currently in for files with the XML extension.
                foreach (string file in Directory.GetFiles(pathDir, "*.xml"))
                {
                    //Increase int by one for each file found.
                    accessCount++;
                }
            }
            
            catch (Exception Error)
            {
                //Any exception is caught and printed in console.
                Console.WriteLine(Error.Message);                
            }
            //We search the directory we're currently in for any subdirectories.
            foreach (string dir in Directory.GetDirectories(pathDir))
            {
                try
                {   
                    //For each subdirectory found, we will recursively call on the same method we're currently in to search each one for XML files.
                    GetAllXmlFiles(dir, ref accessCount, ref deniedCount);
                }
                catch (Exception Error)
                {
                    //Any exception is caught and printed in console. Increase int by one for each entry denied.
                    Console.WriteLine(Error.Message);
                    deniedCount++;
                }
            }

                      
        }

        ///-------------------------------------------------------------------------
        ///                           TASK 2 
        ///-------------------------------------------------------------------------

        /// <summary>
        /// THIS BUTTON PROMTS YOU TO SELECT A FILE FOR CONVERSION.
        /// </summary>    

        private void button_select_Xml_File_Click(object sender, EventArgs e)
        {
            //Clear result from previous searches.
            label_Conversion_Result.Text = "";

            OpenFileDialog oFD = new OpenFileDialog();
            if (oFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Saves the selected file into a string in the textbox when the user presses "OK".
                textBox_Selected_Xml_File.Text = oFD.FileName;
            }

        }

        /// <summary>
        /// THIS BUTTON BEGINS THE CONVERSION OF THE SELECTED XML FILE.
        /// </summary>

        private void button_convert_Xml_Click(object sender, EventArgs e)
        {
            //Checks if the user has selected a file, otherwise promts user to do so.
            if (textBox_Selected_Xml_File.Text == "")
            {
                textBox_Selected_Xml_File.Text = "Please select file first";
            }
            //Checks if the user has selected a file the program is able to convert, otherwise promts user to do so.
            else if (!textBox_Selected_Xml_File.Text.Contains("CustomerOrders.xml"))
            {
                textBox_Selected_Xml_File.Text = "Please select correct xml file";
            }
            else
            {
                //Create a XML document for us to work with and load the selected document into our variable.
                XmlDocument xmlTest = new XmlDocument();
                xmlTest.Load(textBox_Selected_Xml_File.Text);

                //Replaces the node "Orders" with "OrdersByDate" instead.
                var x = xmlTest.DocumentElement;
                var newNode = xmlTest.CreateElement("OrdersByDate");
                newNode.InnerXml = x.LastChild.InnerXml;
                x.ReplaceChild(newNode, x.LastChild);

                //Save all our nodes in the document in a nodelist.
                XmlNodeList dataNodes = xmlTest.SelectNodes("/Root");

                //We call on our method to begin conversion.
                TraverseNodes(dataNodes, ref xmlTest);

                //We save our newly converted XML document to be sorted.
                xmlTest.Save("tobesorted.xml");

                //We create an LINQ-version of our XML document (this was the only way I was able to do the sorting)
                XDocument xdoc = XDocument.Load("tobesorted.xml");

                //We call on our sort method, pass on the LINQ-version and prompt the user to select a location for sorted XML file to be saved.                
                SaveFileDialog sFD = new SaveFileDialog();
                if (sFD.ShowDialog() == DialogResult.OK)
                {
                    SortXmlDocument(xdoc).Save(sFD.FileName);
                }

                //We communicate to the user that the conversion was successful.
                label_Conversion_Result.Text = "Conversion successful!";
            }
        }

        /// <summary>
        /// THIS METHOD RECURSIVELY GOES THROUGH ALL NODES AND CREATES AN ATTRIBUTE CALLED "DATE" FOR EACH NODE CONTAINING THE CHILDNODE "ORDERDATE".
        /// </summary>
        /// <param name="nodes">List of nodes for method to go through</param>
        /// <param name="xmlTest">Our XML document we loaded in to be referenced</param>
        
        public static void TraverseNodes(XmlNodeList nodes, ref XmlDocument xmlTest)
        {
            //We loop through every node in the node list.
            foreach (XmlNode node in nodes)
            {
                //When we find the OrderDate node. 
                if (node.Name.Equals("OrderDate"))
                {
                    //We create a new attribute called "date".
                    XmlAttribute attr = xmlTest.CreateAttribute("date");
                    //Copies the content of the node and place it in our new attribute.
                    attr.Value = node.InnerText;
                    //We select the parent node (Order) for the node we're currently in (OrderDate), and gives it a new 
                    ((XmlElement)node.ParentNode).SetAttribute("date", node.InnerText);
                }
                //We recursively call on the same method we're in to go through all nodes.
                TraverseNodes(node.ChildNodes, ref xmlTest);
            }

        }

        /// <summary>
        /// THIS METHOD LOOPS THROUGH ALL THE ORDER ELEMENTS AND SORTS THEM BY THEIR ATTRIBUTE "DATE".
        /// </summary>
        /// <param name="xdoc">LINQ version of our XML document</param>       

        public static XDocument SortXmlDocument(XDocument xdoc)
        {
            //Get the order nodes and place them in a node list called users.
            var users = xdoc.Elements().Elements("OrdersByDate");
            foreach (var user in users)
            {
                //Recieve the elements called Order, order them by their attribute date and place in an array.
                var elements = user.Elements("Order").OrderBy(a => a.Attribute("date").Value).ToArray();
                //We remove the old unsorted nodes from the xml document.
                user.Elements().Remove();
                //We add the new sorted nodes to the xml document.
                user.Add(elements);
            }

            //Save the new version and return the xml document.
            xdoc.Save("OrdersByDate.xml");
            return xdoc;
        }
    }
}
