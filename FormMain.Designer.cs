namespace FileInformation
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxFilename = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxFilePath = new TextBox();
            label4 = new Label();
            textBoxFileHash = new TextBox();
            label5 = new Label();
            textBoxVersion = new TextBox();
            label6 = new Label();
            textBoxDescription = new TextBox();
            label7 = new Label();
            textBoxProductName = new TextBox();
            label8 = new Label();
            textBoxInternalName = new TextBox();
            SuspendLayout();
            // 
            // textBoxFilename
            // 
            textBoxFilename.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilename.Location = new Point(12, 203);
            textBoxFilename.Name = "textBoxFilename";
            textBoxFilename.Size = new Size(913, 23);
            textBoxFilename.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 185);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Filename";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.White;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(913, 156);
            label2.TabIndex = 2;
            label2.Text = "Drop file here";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.DragDrop += label2_DragDrop;
            label2.DragEnter += label2_DragEnter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 229);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "File path";
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilePath.Location = new Point(12, 247);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(913, 23);
            textBoxFilePath.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 273);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 6;
            label4.Text = "File hash";
            // 
            // textBoxFileHash
            // 
            textBoxFileHash.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFileHash.Location = new Point(12, 291);
            textBoxFileHash.Name = "textBoxFileHash";
            textBoxFileHash.Size = new Size(913, 23);
            textBoxFileHash.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 317);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 8;
            label5.Text = "Minimum version";
            // 
            // textBoxVersion
            // 
            textBoxVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxVersion.Location = new Point(12, 335);
            textBoxVersion.Name = "textBoxVersion";
            textBoxVersion.Size = new Size(913, 23);
            textBoxVersion.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 361);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 10;
            label6.Text = "File description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescription.Location = new Point(12, 379);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(913, 23);
            textBoxDescription.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 405);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 12;
            label7.Text = "Product name";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProductName.Location = new Point(12, 423);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(913, 23);
            textBoxProductName.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 449);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 14;
            label8.Text = "Internal name";
            // 
            // textBoxInternalName
            // 
            textBoxInternalName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInternalName.Location = new Point(12, 467);
            textBoxInternalName.Name = "textBoxInternalName";
            textBoxInternalName.Size = new Size(913, 23);
            textBoxInternalName.TabIndex = 13;
            // 
            // FormMain
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 505);
            Controls.Add(label8);
            Controls.Add(textBoxInternalName);
            Controls.Add(label7);
            Controls.Add(textBoxProductName);
            Controls.Add(label6);
            Controls.Add(textBoxDescription);
            Controls.Add(label5);
            Controls.Add(textBoxVersion);
            Controls.Add(label4);
            Controls.Add(textBoxFileHash);
            Controls.Add(label3);
            Controls.Add(textBoxFilePath);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxFilename);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "File Information";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFilename;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxFilePath;
        private Label label4;
        private TextBox textBoxFileHash;
        private Label label5;
        private TextBox textBoxVersion;
        private Label label6;
        private TextBox textBoxDescription;
        private Label label7;
        private TextBox textBoxProductName;
        private Label label8;
        private TextBox textBoxInternalName;
    }
}