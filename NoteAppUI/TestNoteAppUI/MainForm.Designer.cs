namespace TestNoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitleListbox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Captionlabel = new System.Windows.Forms.Label();
            this.ComoBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.modifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleListbox
            // 
            this.TitleListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleListbox.FormattingEnabled = true;
            this.TitleListbox.Location = new System.Drawing.Point(12, 95);
            this.TitleListbox.Name = "TitleListbox";
            this.TitleListbox.Size = new System.Drawing.Size(237, 277);
            this.TitleListbox.TabIndex = 1;
            this.TitleListbox.SelectedIndexChanged += new System.EventHandler(this.TitleLb_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ShowCategory:";
            // 
            // Captionlabel
            // 
            this.Captionlabel.AutoSize = true;
            this.Captionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Captionlabel.Location = new System.Drawing.Point(301, 33);
            this.Captionlabel.Name = "Captionlabel";
            this.Captionlabel.Size = new System.Drawing.Size(103, 25);
            this.Captionlabel.TabIndex = 4;
            this.Captionlabel.Text = "Заметка:";
            // 
            // ComoBoxCategory
            // 
            this.ComoBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComoBoxCategory.FormattingEnabled = true;
            this.ComoBoxCategory.Location = new System.Drawing.Point(98, 33);
            this.ComoBoxCategory.Name = "ComoBoxCategory";
            this.ComoBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.ComoBoxCategory.TabIndex = 5;
            this.ComoBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(364, 75);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(35, 13);
            this.CategoryLabel.TabIndex = 7;
            this.CategoryLabel.Text = "label4";
            this.CategoryLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Created:";
            // 
            // createdDateTimePicker
            // 
            this.createdDateTimePicker.Checked = false;
            this.createdDateTimePicker.Enabled = false;
            this.createdDateTimePicker.Location = new System.Drawing.Point(359, 104);
            this.createdDateTimePicker.Name = "createdDateTimePicker";
            this.createdDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.createdDateTimePicker.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Modified:";
            // 
            // modifiedDateTimePicker
            // 
            this.modifiedDateTimePicker.Checked = false;
            this.modifiedDateTimePicker.Enabled = false;
            this.modifiedDateTimePicker.Location = new System.Drawing.Point(560, 104);
            this.modifiedDateTimePicker.Name = "modifiedDateTimePicker";
            this.modifiedDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.modifiedDateTimePicker.TabIndex = 14;
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlelabel.Location = new System.Drawing.Point(410, 33);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(86, 31);
            this.Titlelabel.TabIndex = 16;
            this.Titlelabel.Text = "label2";
            this.Titlelabel.Visible = false;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(292, 147);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(410, 261);
            this.textBox.TabIndex = 17;
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.BackgroundImage")));
            this.AddNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNoteButton.Location = new System.Drawing.Point(12, 378);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(30, 30);
            this.AddNoteButton.TabIndex = 18;
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.BackgroundImage")));
            this.EditNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNoteButton.Location = new System.Drawing.Point(48, 378);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(30, 30);
            this.EditNoteButton.TabIndex = 19;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveNoteButton.BackgroundImage")));
            this.RemoveNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveNoteButton.Location = new System.Drawing.Point(84, 378);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(27, 30);
            this.RemoveNoteButton.TabIndex = 20;
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Заметки:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveNoteButton);
            this.Controls.Add(this.EditNoteButton);
            this.Controls.Add(this.AddNoteButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.modifiedDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createdDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComoBoxCategory);
            this.Controls.Add(this.Captionlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleListbox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox TitleListbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Captionlabel;
        private System.Windows.Forms.ComboBox ComoBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker createdDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker modifiedDateTimePicker;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Label label2;
    }
}

