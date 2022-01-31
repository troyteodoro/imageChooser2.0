namespace openimage
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
            this.Load_Image = new System.Windows.Forms.Button();
            this.OpenImageDisplay = new System.Windows.Forms.PictureBox();
            this.Gray_Scale = new System.Windows.Forms.Button();
            this.Red_Scale = new System.Windows.Forms.Button();
            this.Green_Scale = new System.Windows.Forms.Button();
            this.Blue_Scale = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OpenImageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_Image
            // 
            this.Load_Image.Location = new System.Drawing.Point(12, 1);
            this.Load_Image.Name = "Load_Image";
            this.Load_Image.Size = new System.Drawing.Size(75, 23);
            this.Load_Image.TabIndex = 0;
            this.Load_Image.Text = "Load_Image";
            this.Load_Image.UseVisualStyleBackColor = true;
            this.Load_Image.Click += new System.EventHandler(this.Load_Image_Click);
            // 
            // OpenImageDisplay
            // 
            this.OpenImageDisplay.Location = new System.Drawing.Point(-1, 43);
            this.OpenImageDisplay.Name = "OpenImageDisplay";
            this.OpenImageDisplay.Size = new System.Drawing.Size(501, 235);
            this.OpenImageDisplay.TabIndex = 1;
            this.OpenImageDisplay.TabStop = false;
            // 
            // Gray_Scale
            // 
            this.Gray_Scale.Location = new System.Drawing.Point(92, 1);
            this.Gray_Scale.Name = "Gray_Scale";
            this.Gray_Scale.Size = new System.Drawing.Size(78, 23);
            this.Gray_Scale.TabIndex = 2;
            this.Gray_Scale.Text = "Gray Scale";
            this.Gray_Scale.UseVisualStyleBackColor = true;
            this.Gray_Scale.Click += new System.EventHandler(this.Gray_Scale_Click);
            // 
            // Red_Scale
            // 
            this.Red_Scale.Location = new System.Drawing.Point(176, 1);
            this.Red_Scale.Name = "Red_Scale";
            this.Red_Scale.Size = new System.Drawing.Size(75, 23);
            this.Red_Scale.TabIndex = 3;
            this.Red_Scale.Text = "Red_Scale";
            this.Red_Scale.UseVisualStyleBackColor = true;
            this.Red_Scale.Click += new System.EventHandler(this.Red_Scale_Click);
            // 
            // Green_Scale
            // 
            this.Green_Scale.Location = new System.Drawing.Point(257, 1);
            this.Green_Scale.Name = "Green_Scale";
            this.Green_Scale.Size = new System.Drawing.Size(81, 23);
            this.Green_Scale.TabIndex = 4;
            this.Green_Scale.Text = "Green_Scale";
            this.Green_Scale.UseVisualStyleBackColor = true;
            this.Green_Scale.Click += new System.EventHandler(this.Green_Scale_Click);
            // 
            // Blue_Scale
            // 
            this.Blue_Scale.Location = new System.Drawing.Point(344, 1);
            this.Blue_Scale.Name = "Blue_Scale";
            this.Blue_Scale.Size = new System.Drawing.Size(75, 23);
            this.Blue_Scale.TabIndex = 5;
            this.Blue_Scale.Text = "Blue_Scale";
            this.Blue_Scale.UseVisualStyleBackColor = true;
            this.Blue_Scale.Click += new System.EventHandler(this.Blue_Scale_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(425, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 496);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Blue_Scale);
            this.Controls.Add(this.Green_Scale);
            this.Controls.Add(this.Red_Scale);
            this.Controls.Add(this.Gray_Scale);
            this.Controls.Add(this.OpenImageDisplay);
            this.Controls.Add(this.Load_Image);
            this.Name = "Form1";
            this.Text = "Teodoro Imager Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OpenImageDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load_Image;
        private System.Windows.Forms.PictureBox OpenImageDisplay;
        private System.Windows.Forms.Button Gray_Scale;
        private System.Windows.Forms.Button Red_Scale;
        private System.Windows.Forms.Button Green_Scale;
        private System.Windows.Forms.Button Blue_Scale;
        private System.Windows.Forms.Button Exit;
    }
}

