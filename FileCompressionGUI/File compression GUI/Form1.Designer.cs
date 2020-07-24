namespace File_compression_GUI
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
            this.Compress = new System.Windows.Forms.Button();
            this.DeCompress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Compress
            // 
            this.Compress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compress.Location = new System.Drawing.Point(230, 196);
            this.Compress.Margin = new System.Windows.Forms.Padding(4);
            this.Compress.Name = "Compress";
            this.Compress.Size = new System.Drawing.Size(207, 65);
            this.Compress.TabIndex = 0;
            this.Compress.Text = "Compress";
            this.Compress.UseVisualStyleBackColor = true;
            this.Compress.Click += new System.EventHandler(this.Compress_Click);
            // 
            // DeCompress
            // 
            this.DeCompress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeCompress.Location = new System.Drawing.Point(230, 299);
            this.DeCompress.Margin = new System.Windows.Forms.Padding(4);
            this.DeCompress.Name = "DeCompress";
            this.DeCompress.Size = new System.Drawing.Size(207, 65);
            this.DeCompress.TabIndex = 1;
            this.DeCompress.Text = "DeCompress";
            this.DeCompress.UseMnemonic = false;
            this.DeCompress.UseVisualStyleBackColor = true;
            this.DeCompress.Click += new System.EventHandler(this.DeCompress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 509);
            this.Controls.Add(this.DeCompress);
            this.Controls.Add(this.Compress);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Compress;
        private System.Windows.Forms.Button DeCompress;
    }
}

