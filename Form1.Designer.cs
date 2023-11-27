namespace FileEncryptor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.encryptButton = new System.Windows.Forms.Button();
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.keyLbl = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.inputFileButton = new System.Windows.Forms.Button();
            this.outputFileButton = new System.Windows.Forms.Button();
            this.AlgBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.encryptButton.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.encryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptButton.Location = new System.Drawing.Point(28, 185);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(293, 23);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputFileTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.inputFileTextBox.Location = new System.Drawing.Point(69, 94);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.Size = new System.Drawing.Size(213, 20);
            this.inputFileTextBox.TabIndex = 1;
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.outputFileTextBox.Location = new System.Drawing.Point(69, 149);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(213, 20);
            this.outputFileTextBox.TabIndex = 2;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(126, 25);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyTextBox.TabIndex = 3;
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.decryptButton.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.decryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptButton.Location = new System.Drawing.Point(28, 227);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(293, 23);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // keyLbl
            // 
            this.keyLbl.AutoSize = true;
            this.keyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.keyLbl.Location = new System.Drawing.Point(161, 7);
            this.keyLbl.Name = "keyLbl";
            this.keyLbl.Size = new System.Drawing.Size(30, 15);
            this.keyLbl.TabIndex = 7;
            this.keyLbl.Text = "Key";
            // 
            // inputFileButton
            // 
            this.inputFileButton.BackColor = System.Drawing.Color.LightBlue;
            this.inputFileButton.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.inputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputFileButton.Location = new System.Drawing.Point(145, 65);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(61, 23);
            this.inputFileButton.TabIndex = 10;
            this.inputFileButton.Text = "Input";
            this.inputFileButton.UseVisualStyleBackColor = false;
            this.inputFileButton.Click += new System.EventHandler(this.inputFileButton_Click);
            // 
            // outputFileButton
            // 
            this.outputFileButton.BackColor = System.Drawing.Color.LightBlue;
            this.outputFileButton.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.outputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputFileButton.Location = new System.Drawing.Point(145, 120);
            this.outputFileButton.Name = "outputFileButton";
            this.outputFileButton.Size = new System.Drawing.Size(61, 23);
            this.outputFileButton.TabIndex = 11;
            this.outputFileButton.Text = "Output";
            this.outputFileButton.UseVisualStyleBackColor = false;
            this.outputFileButton.Click += new System.EventHandler(this.outputFileButton_Click_1);
            // 
            // AlgBox
            // 
            this.AlgBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AlgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgBox.ForeColor = System.Drawing.SystemColors.Window;
            this.AlgBox.FormattingEnabled = true;
            this.AlgBox.Items.AddRange(new object[] {
            "AES",
            "Rijndael"});
            this.AlgBox.Location = new System.Drawing.Point(12, 7);
            this.AlgBox.Name = "AlgBox";
            this.AlgBox.Size = new System.Drawing.Size(67, 82);
            this.AlgBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(344, 265);
            this.Controls.Add(this.AlgBox);
            this.Controls.Add(this.outputFileButton);
            this.Controls.Add(this.inputFileButton);
            this.Controls.Add(this.keyLbl);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.inputFileTextBox);
            this.Controls.Add(this.encryptButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "File Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label keyLbl;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button inputFileButton;
        private System.Windows.Forms.Button outputFileButton;
        private System.Windows.Forms.ListBox AlgBox;
    }
}

