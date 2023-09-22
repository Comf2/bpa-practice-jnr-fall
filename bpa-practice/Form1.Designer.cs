namespace bpa_practice
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
            this.ReadFiles = new System.Windows.Forms.Button();
            this.ArrayManiplulation = new System.Windows.Forms.Button();
            this.ListManiplulation = new System.Windows.Forms.Button();
            this.StringManiplulation = new System.Windows.Forms.Button();
            this.ErrorHandling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadFiles
            // 
            this.ReadFiles.Location = new System.Drawing.Point(99, 152);
            this.ReadFiles.Name = "ReadFiles";
            this.ReadFiles.Size = new System.Drawing.Size(75, 23);
            this.ReadFiles.TabIndex = 0;
            this.ReadFiles.Text = "ReadFiles";
            this.ReadFiles.UseVisualStyleBackColor = true;
            this.ReadFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArrayManiplulation
            // 
            this.ArrayManiplulation.Location = new System.Drawing.Point(202, 152);
            this.ArrayManiplulation.Name = "ArrayManiplulation";
            this.ArrayManiplulation.Size = new System.Drawing.Size(109, 23);
            this.ArrayManiplulation.TabIndex = 1;
            this.ArrayManiplulation.Text = "ArrayManiplulation";
            this.ArrayManiplulation.UseVisualStyleBackColor = true;
            this.ArrayManiplulation.Click += new System.EventHandler(this.ArrayManiplulation_Click);
            // 
            // ListManiplulation
            // 
            this.ListManiplulation.Location = new System.Drawing.Point(336, 152);
            this.ListManiplulation.Name = "ListManiplulation";
            this.ListManiplulation.Size = new System.Drawing.Size(97, 23);
            this.ListManiplulation.TabIndex = 2;
            this.ListManiplulation.Text = "ListManiplulation";
            this.ListManiplulation.UseVisualStyleBackColor = true;
            this.ListManiplulation.Click += new System.EventHandler(this.ListManiplulation_Click);
            // 
            // StringManiplulation
            // 
            this.StringManiplulation.Location = new System.Drawing.Point(457, 152);
            this.StringManiplulation.Name = "StringManiplulation";
            this.StringManiplulation.Size = new System.Drawing.Size(113, 23);
            this.StringManiplulation.TabIndex = 3;
            this.StringManiplulation.Text = "StringManiplulation";
            this.StringManiplulation.UseVisualStyleBackColor = true;
            // 
            // ErrorHandling
            // 
            this.ErrorHandling.Location = new System.Drawing.Point(590, 152);
            this.ErrorHandling.Name = "ErrorHandling";
            this.ErrorHandling.Size = new System.Drawing.Size(93, 23);
            this.ErrorHandling.TabIndex = 4;
            this.ErrorHandling.Text = "ErrorHandling";
            this.ErrorHandling.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorHandling);
            this.Controls.Add(this.StringManiplulation);
            this.Controls.Add(this.ListManiplulation);
            this.Controls.Add(this.ArrayManiplulation);
            this.Controls.Add(this.ReadFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadFiles;
        private System.Windows.Forms.Button ArrayManiplulation;
        private System.Windows.Forms.Button ListManiplulation;
        private System.Windows.Forms.Button StringManiplulation;
        private System.Windows.Forms.Button ErrorHandling;
    }
}

