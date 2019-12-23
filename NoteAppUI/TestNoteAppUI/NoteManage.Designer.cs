namespace TestNoteAppUI
{
    partial class NoteManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteManage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleTBox = new System.Windows.Forms.TextBox();
            this.ComboBoxCategory1 = new System.Windows.Forms.ComboBox();
            this.createdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.modifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.TextTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created:";
            // 
            // titleTBox
            // 
            this.titleTBox.Location = new System.Drawing.Point(65, 12);
            this.titleTBox.Name = "titleTBox";
            this.titleTBox.Size = new System.Drawing.Size(350, 20);
            this.titleTBox.TabIndex = 3;
            this.titleTBox.Text = "Без имени";
            this.titleTBox.TextChanged += new System.EventHandler(this.titleTBox_TextChanged);
            // 
            // ComboBoxCategory1
            // 
            this.ComboBoxCategory1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCategory1.FormattingEnabled = true;
            this.ComboBoxCategory1.Location = new System.Drawing.Point(65, 38);
            this.ComboBoxCategory1.Name = "ComboBoxCategory1";
            this.ComboBoxCategory1.Size = new System.Drawing.Size(133, 21);
            this.ComboBoxCategory1.TabIndex = 4;
            // 
            // createdDateTimePicker
            // 
            this.createdDateTimePicker.Enabled = false;
            this.createdDateTimePicker.Location = new System.Drawing.Point(65, 68);
            this.createdDateTimePicker.Name = "createdDateTimePicker";
            this.createdDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.createdDateTimePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modified:";
            // 
            // modifiedDateTimePicker
            // 
            this.modifiedDateTimePicker.Enabled = false;
            this.modifiedDateTimePicker.Location = new System.Drawing.Point(265, 68);
            this.modifiedDateTimePicker.Name = "modifiedDateTimePicker";
            this.modifiedDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.modifiedDateTimePicker.TabIndex = 7;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancelbutton.Location = new System.Drawing.Point(345, 308);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 9;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Location = new System.Drawing.Point(264, 308);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 10;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // TextTBox
            // 
            this.TextTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTBox.Location = new System.Drawing.Point(4, 101);
            this.TextTBox.Multiline = true;
            this.TextTBox.Name = "TextTBox";
            this.TextTBox.Size = new System.Drawing.Size(423, 201);
            this.TextTBox.TabIndex = 11;
            // 
            // NoteManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 343);
            this.Controls.Add(this.TextTBox);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.modifiedDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createdDateTimePicker);
            this.Controls.Add(this.ComboBoxCategory1);
            this.Controls.Add(this.titleTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(410, 310);
            this.Name = "NoteManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private поменял на public
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleTBox;
        private System.Windows.Forms.ComboBox ComboBoxCategory1;
        private System.Windows.Forms.DateTimePicker createdDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker modifiedDateTimePicker;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.TextBox TextTBox;
    }
}