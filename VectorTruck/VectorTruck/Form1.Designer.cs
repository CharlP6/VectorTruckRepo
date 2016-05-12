namespace VectorTruck
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblMagnitude = new System.Windows.Forms.Label();
            this.lblUX = new System.Windows.Forms.Label();
            this.lblUY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(120, 14);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(73, 20);
            this.txtX.TabIndex = 1;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(199, 14);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(73, 20);
            this.txtY.TabIndex = 2;
            // 
            // lblMagnitude
            // 
            this.lblMagnitude.AutoSize = true;
            this.lblMagnitude.Location = new System.Drawing.Point(117, 37);
            this.lblMagnitude.Name = "lblMagnitude";
            this.lblMagnitude.Size = new System.Drawing.Size(19, 13);
            this.lblMagnitude.TabIndex = 3;
            this.lblMagnitude.Text = "M:";
            // 
            // lblUX
            // 
            this.lblUX.AutoSize = true;
            this.lblUX.Location = new System.Drawing.Point(117, 60);
            this.lblUX.Name = "lblUX";
            this.lblUX.Size = new System.Drawing.Size(23, 13);
            this.lblUX.TabIndex = 4;
            this.lblUX.Text = "uX:";
            // 
            // lblUY
            // 
            this.lblUY.AutoSize = true;
            this.lblUY.Location = new System.Drawing.Point(117, 82);
            this.lblUY.Name = "lblUY";
            this.lblUY.Size = new System.Drawing.Size(20, 13);
            this.lblUY.TabIndex = 5;
            this.lblUY.Text = "uY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblUY);
            this.Controls.Add(this.lblUX);
            this.Controls.Add(this.lblMagnitude);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblMagnitude;
        private System.Windows.Forms.Label lblUX;
        private System.Windows.Forms.Label lblUY;
    }
}

