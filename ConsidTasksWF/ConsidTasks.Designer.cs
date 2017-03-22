namespace ConsidTasksWF
{
    partial class ConsidTasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_Search_Results = new System.Windows.Forms.Label();
            this.label_unaccesibleDirectories = new System.Windows.Forms.Label();
            this.label_accesibleFiles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Begin_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Selected_Directory = new System.Windows.Forms.TextBox();
            this.button_Select_Directory = new System.Windows.Forms.Button();
            this.label_desc = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_Conversion_Result = new System.Windows.Forms.Label();
            this.button_convert_Xml = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Selected_Xml_File = new System.Windows.Forms.TextBox();
            this.button_select_Xml_File = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(382, 348);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_Search_Results);
            this.tabPage1.Controls.Add(this.label_unaccesibleDirectories);
            this.tabPage1.Controls.Add(this.label_accesibleFiles);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button_Begin_Search);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_Selected_Directory);
            this.tabPage1.Controls.Add(this.button_Select_Directory);
            this.tabPage1.Controls.Add(this.label_desc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(374, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_Search_Results
            // 
            this.label_Search_Results.AutoSize = true;
            this.label_Search_Results.Location = new System.Drawing.Point(6, 167);
            this.label_Search_Results.Name = "label_Search_Results";
            this.label_Search_Results.Size = new System.Drawing.Size(0, 13);
            this.label_Search_Results.TabIndex = 11;
            // 
            // label_unaccesibleDirectories
            // 
            this.label_unaccesibleDirectories.AutoSize = true;
            this.label_unaccesibleDirectories.Location = new System.Drawing.Point(176, 244);
            this.label_unaccesibleDirectories.Name = "label_unaccesibleDirectories";
            this.label_unaccesibleDirectories.Size = new System.Drawing.Size(0, 13);
            this.label_unaccesibleDirectories.TabIndex = 10;
            // 
            // label_accesibleFiles
            // 
            this.label_accesibleFiles.AutoSize = true;
            this.label_accesibleFiles.Location = new System.Drawing.Point(235, 210);
            this.label_accesibleFiles.Name = "label_accesibleFiles";
            this.label_accesibleFiles.Size = new System.Drawing.Size(0, 13);
            this.label_accesibleFiles.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of unaccesible directories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of accesible xml files in given directory:";
            // 
            // button_Begin_Search
            // 
            this.button_Begin_Search.Location = new System.Drawing.Point(6, 112);
            this.button_Begin_Search.Name = "button_Begin_Search";
            this.button_Begin_Search.Size = new System.Drawing.Size(145, 23);
            this.button_Begin_Search.TabIndex = 5;
            this.button_Begin_Search.Text = "Begin search";
            this.button_Begin_Search.UseVisualStyleBackColor = true;
            this.button_Begin_Search.Click += new System.EventHandler(this.begin_Search_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chosen directory:";
            // 
            // textBox_Selected_Directory
            // 
            this.textBox_Selected_Directory.Location = new System.Drawing.Point(6, 77);
            this.textBox_Selected_Directory.Name = "textBox_Selected_Directory";
            this.textBox_Selected_Directory.ReadOnly = true;
            this.textBox_Selected_Directory.Size = new System.Drawing.Size(145, 20);
            this.textBox_Selected_Directory.TabIndex = 3;
            // 
            // button_Select_Directory
            // 
            this.button_Select_Directory.Location = new System.Drawing.Point(6, 25);
            this.button_Select_Directory.Name = "button_Select_Directory";
            this.button_Select_Directory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Select_Directory.Size = new System.Drawing.Size(145, 23);
            this.button_Select_Directory.TabIndex = 2;
            this.button_Select_Directory.Text = "Select directory";
            this.button_Select_Directory.UseVisualStyleBackColor = true;
            this.button_Select_Directory.Click += new System.EventHandler(this.select_Directory_Btn_Click);
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Location = new System.Drawing.Point(3, 3);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(245, 13);
            this.label_desc.TabIndex = 1;
            this.label_desc.Text = "Please select which directory to begin search with:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_Conversion_Result);
            this.tabPage2.Controls.Add(this.button_convert_Xml);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox_Selected_Xml_File);
            this.tabPage2.Controls.Add(this.button_select_Xml_File);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(374, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_Conversion_Result
            // 
            this.label_Conversion_Result.AutoSize = true;
            this.label_Conversion_Result.Location = new System.Drawing.Point(6, 159);
            this.label_Conversion_Result.Name = "label_Conversion_Result";
            this.label_Conversion_Result.Size = new System.Drawing.Size(0, 13);
            this.label_Conversion_Result.TabIndex = 5;
            // 
            // button_convert_Xml
            // 
            this.button_convert_Xml.Location = new System.Drawing.Point(6, 113);
            this.button_convert_Xml.Name = "button_convert_Xml";
            this.button_convert_Xml.Size = new System.Drawing.Size(156, 23);
            this.button_convert_Xml.TabIndex = 4;
            this.button_convert_Xml.Text = "Convert and Save File  ";
            this.button_convert_Xml.UseVisualStyleBackColor = true;
            this.button_convert_Xml.Click += new System.EventHandler(this.button_convert_Xml_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Chosen File:";
            // 
            // textBox_Selected_Xml_File
            // 
            this.textBox_Selected_Xml_File.Location = new System.Drawing.Point(6, 78);
            this.textBox_Selected_Xml_File.Name = "textBox_Selected_Xml_File";
            this.textBox_Selected_Xml_File.ReadOnly = true;
            this.textBox_Selected_Xml_File.Size = new System.Drawing.Size(156, 20);
            this.textBox_Selected_Xml_File.TabIndex = 2;
            // 
            // button_select_Xml_File
            // 
            this.button_select_Xml_File.Location = new System.Drawing.Point(6, 25);
            this.button_select_Xml_File.Name = "button_select_Xml_File";
            this.button_select_Xml_File.Size = new System.Drawing.Size(156, 23);
            this.button_select_Xml_File.TabIndex = 1;
            this.button_select_Xml_File.Text = "Select File";
            this.button_select_Xml_File.UseVisualStyleBackColor = true;
            this.button_select_Xml_File.Click += new System.EventHandler(this.button_select_Xml_File_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Select XML file to convert:";
            // 
            // ConsidTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 367);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConsidTasks";
            this.Text = "ConsidTasksWF - Per Jansson";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_Select_Directory;
        private System.Windows.Forms.TextBox textBox_Selected_Directory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Begin_Search;
        private System.Windows.Forms.Label label_unaccesibleDirectories;
        private System.Windows.Forms.Label label_accesibleFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Search_Results;
        private System.Windows.Forms.Button button_select_Xml_File;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_convert_Xml;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Selected_Xml_File;
        private System.Windows.Forms.Label label_Conversion_Result;
    }
}

