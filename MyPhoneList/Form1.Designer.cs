namespace MyPhoneList
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnLocalPhoneNumbers = new System.Windows.Forms.Button();
            this.BtnImportedPhoneNumbers = new System.Windows.Forms.Button();
            this.BtnOnlinePhoneNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnClose.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(353, 315);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 52);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLocalPhoneNumbers
            // 
            this.BtnLocalPhoneNumbers.Location = new System.Drawing.Point(119, 122);
            this.BtnLocalPhoneNumbers.Name = "BtnLocalPhoneNumbers";
            this.BtnLocalPhoneNumbers.Size = new System.Drawing.Size(137, 88);
            this.BtnLocalPhoneNumbers.TabIndex = 1;
            this.BtnLocalPhoneNumbers.Text = "Local Phone Numbers";
            this.BtnLocalPhoneNumbers.UseVisualStyleBackColor = true;
            this.BtnLocalPhoneNumbers.Click += new System.EventHandler(this.BtnLocalPhoneNumbers_Click);
            // 
            // BtnImportedPhoneNumbers
            // 
            this.BtnImportedPhoneNumbers.Location = new System.Drawing.Point(333, 124);
            this.BtnImportedPhoneNumbers.Name = "BtnImportedPhoneNumbers";
            this.BtnImportedPhoneNumbers.Size = new System.Drawing.Size(137, 86);
            this.BtnImportedPhoneNumbers.TabIndex = 2;
            this.BtnImportedPhoneNumbers.Text = "Imported Phone Numbers";
            this.BtnImportedPhoneNumbers.UseVisualStyleBackColor = true;
            this.BtnImportedPhoneNumbers.Click += new System.EventHandler(this.BtnImportedPhoneNumbers_Click);
            // 
            // BtnOnlinePhoneNumbers
            // 
            this.BtnOnlinePhoneNumbers.Location = new System.Drawing.Point(549, 124);
            this.BtnOnlinePhoneNumbers.Name = "BtnOnlinePhoneNumbers";
            this.BtnOnlinePhoneNumbers.Size = new System.Drawing.Size(137, 86);
            this.BtnOnlinePhoneNumbers.TabIndex = 4;
            this.BtnOnlinePhoneNumbers.Text = "Online Phone Numbers";
            this.BtnOnlinePhoneNumbers.UseVisualStyleBackColor = true;
            this.BtnOnlinePhoneNumbers.Click += new System.EventHandler(this.BtnOnlinePhoneNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOnlinePhoneNumbers);
            this.Controls.Add(this.BtnImportedPhoneNumbers);
            this.Controls.Add(this.BtnLocalPhoneNumbers);
            this.Controls.Add(this.BtnClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnLocalPhoneNumbers;
        private System.Windows.Forms.Button BtnImportedPhoneNumbers;
        private System.Windows.Forms.Button BtnOnlinePhoneNumbers;
    }
}

