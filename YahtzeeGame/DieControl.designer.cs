namespace Chapter_11_InClass
//namespace YahtzeeGame
{
    partial class DieControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DieControl));
            this.pictureBoxFace = new System.Windows.Forms.PictureBox();
            this.pictureBoxHold = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHold)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFace
            // 
            this.pictureBoxFace.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxFace.Name = "pictureBoxFace";
            this.pictureBoxFace.Size = new System.Drawing.Size(131, 111);
            this.pictureBoxFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFace.TabIndex = 0;
            this.pictureBoxFace.TabStop = false;
            this.pictureBoxFace.Click += new System.EventHandler(this.DieControl_Click);
            // 
            // pictureBoxHold
            // 
            this.pictureBoxHold.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHold.Image")));
            this.pictureBoxHold.Location = new System.Drawing.Point(118, 227);
            this.pictureBoxHold.Name = "pictureBoxHold";
            this.pictureBoxHold.Size = new System.Drawing.Size(221, 222);
            this.pictureBoxHold.TabIndex = 1;
            this.pictureBoxHold.TabStop = false;
            this.pictureBoxHold.Visible = false;
            // 
            // DieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxHold);
            this.Controls.Add(this.pictureBoxFace);
            this.Name = "DieControl";
            this.Size = new System.Drawing.Size(65, 62);
            this.Load += new System.EventHandler(this.DieControl_Load);
            this.Resize += new System.EventHandler(this.DieControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFace;
        private System.Windows.Forms.PictureBox pictureBoxHold;
    }
}
