namespace Module_3_Assignment
{
    partial class PickAnyCurtain
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
            this.prize = new System.Windows.Forms.Label();
            this.curtain9 = new System.Windows.Forms.PictureBox();
            this.curtain7 = new System.Windows.Forms.PictureBox();
            this.curtain5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.curtain9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curtain7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curtain5)).BeginInit();
            this.SuspendLayout();
            // 
            // prize
            // 
            this.prize.AutoSize = true;
            this.prize.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.prize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.prize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prize.Location = new System.Drawing.Point(439, 42);
            this.prize.Name = "prize";
            this.prize.Size = new System.Drawing.Size(188, 31);
            this.prize.TabIndex = 3;
            this.prize.Text = "Pick Any Curtain";
            // 
            // curtain9
            // 
            this.curtain9.Image = global::Module_3_Assignment.Properties.Resources.curtain9;
            this.curtain9.Location = new System.Drawing.Point(737, 106);
            this.curtain9.Name = "curtain9";
            this.curtain9.Size = new System.Drawing.Size(305, 374);
            this.curtain9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.curtain9.TabIndex = 2;
            this.curtain9.TabStop = false;
            this.curtain9.Click += new System.EventHandler(this.curtain9_Click);
            // 
            // curtain7
            // 
            this.curtain7.Image = global::Module_3_Assignment.Properties.Resources.curtain7;
            this.curtain7.Location = new System.Drawing.Point(385, 106);
            this.curtain7.Name = "curtain7";
            this.curtain7.Size = new System.Drawing.Size(305, 374);
            this.curtain7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.curtain7.TabIndex = 1;
            this.curtain7.TabStop = false;
            this.curtain7.Click += new System.EventHandler(this.curtain7_Click);
            // 
            // curtain5
            // 
            this.curtain5.BackColor = System.Drawing.SystemColors.Control;
            this.curtain5.Image = global::Module_3_Assignment.Properties.Resources.curtain5;
            this.curtain5.Location = new System.Drawing.Point(34, 106);
            this.curtain5.Name = "curtain5";
            this.curtain5.Size = new System.Drawing.Size(305, 374);
            this.curtain5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.curtain5.TabIndex = 0;
            this.curtain5.TabStop = false;
            this.curtain5.Click += new System.EventHandler(this.curtain5_Click);
            // 
            // PickAnyCurtain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 602);
            this.Controls.Add(this.prize);
            this.Controls.Add(this.curtain9);
            this.Controls.Add(this.curtain7);
            this.Controls.Add(this.curtain5);
            this.Name = "PickAnyCurtain";
            this.Text = "Pick any Curtain";
            ((System.ComponentModel.ISupportInitialize)(this.curtain9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curtain7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curtain5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox curtain5;
        private System.Windows.Forms.PictureBox curtain7;
        private System.Windows.Forms.PictureBox curtain9;
        private System.Windows.Forms.Label prize;
    }
}

