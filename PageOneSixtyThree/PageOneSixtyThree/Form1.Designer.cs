namespace PageOneSixtyThree
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
            this.lloydButton = new System.Windows.Forms.Button();
            this.lucindaButton = new System.Windows.Forms.Button();
            this.swapButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lloydButton
            // 
            this.lloydButton.Location = new System.Drawing.Point(12, 12);
            this.lloydButton.Name = "lloydButton";
            this.lloydButton.Size = new System.Drawing.Size(88, 35);
            this.lloydButton.TabIndex = 0;
            this.lloydButton.Text = "Lloyd";
            this.lloydButton.UseVisualStyleBackColor = true;
            this.lloydButton.Click += new System.EventHandler(this.lloydButton_Click);
            // 
            // lucindaButton
            // 
            this.lucindaButton.Location = new System.Drawing.Point(12, 53);
            this.lucindaButton.Name = "lucindaButton";
            this.lucindaButton.Size = new System.Drawing.Size(88, 39);
            this.lucindaButton.TabIndex = 1;
            this.lucindaButton.Text = "Lucinda";
            this.lucindaButton.UseVisualStyleBackColor = true;
            this.lucindaButton.Click += new System.EventHandler(this.lucindaButton_Click_1);
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(12, 98);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(88, 38);
            this.swapButton.TabIndex = 2;
            this.swapButton.Text = "Swap!";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.lucindaButton);
            this.Controls.Add(this.lloydButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lloydButton;
        private System.Windows.Forms.Button lucindaButton;
        private System.Windows.Forms.Button swapButton;
        private System.Windows.Forms.Button button1;
    }
}

