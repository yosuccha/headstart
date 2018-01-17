namespace PageOneTwentyNine
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
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.bankToJoeButton = new System.Windows.Forms.Button();
            this.bobToBankButton = new System.Windows.Forms.Button();
            this.joeToBobButton = new System.Windows.Forms.Button();
            this.bobToJoeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(84, 62);
            this.joesCashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(58, 17);
            this.joesCashLabel.TabIndex = 0;
            this.joesCashLabel.Text = "Joe has";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(84, 94);
            this.bobsCashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(60, 17);
            this.bobsCashLabel.TabIndex = 1;
            this.bobsCashLabel.Text = "Bob has";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(84, 132);
            this.bankCashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(95, 17);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "The bank has";
            // 
            // bankToJoeButton
            // 
            this.bankToJoeButton.Location = new System.Drawing.Point(19, 166);
            this.bankToJoeButton.Margin = new System.Windows.Forms.Padding(4);
            this.bankToJoeButton.Name = "bankToJoeButton";
            this.bankToJoeButton.Size = new System.Drawing.Size(100, 50);
            this.bankToJoeButton.TabIndex = 3;
            this.bankToJoeButton.Text = "Give $10 to Joe";
            this.bankToJoeButton.UseVisualStyleBackColor = true;
            this.bankToJoeButton.Click += new System.EventHandler(this.bankToJoeButton_Click);
            // 
            // bobToBankButton
            // 
            this.bobToBankButton.Location = new System.Drawing.Point(136, 166);
            this.bobToBankButton.Margin = new System.Windows.Forms.Padding(4);
            this.bobToBankButton.Name = "bobToBankButton";
            this.bobToBankButton.Size = new System.Drawing.Size(100, 52);
            this.bobToBankButton.TabIndex = 4;
            this.bobToBankButton.Text = "Receive $5 from Bob";
            this.bobToBankButton.UseVisualStyleBackColor = true;
            this.bobToBankButton.Click += new System.EventHandler(this.bobToBankButton_Click);
            // 
            // joeToBobButton
            // 
            this.joeToBobButton.Location = new System.Drawing.Point(19, 235);
            this.joeToBobButton.Name = "joeToBobButton";
            this.joeToBobButton.Size = new System.Drawing.Size(100, 49);
            this.joeToBobButton.TabIndex = 5;
            this.joeToBobButton.Text = "Joe gives $10 to Bob";
            this.joeToBobButton.UseVisualStyleBackColor = true;
            this.joeToBobButton.Click += new System.EventHandler(this.joeToBobButton_Click);
            // 
            // bobToJoeButton
            // 
            this.bobToJoeButton.Location = new System.Drawing.Point(136, 235);
            this.bobToJoeButton.Name = "bobToJoeButton";
            this.bobToJoeButton.Size = new System.Drawing.Size(100, 49);
            this.bobToJoeButton.TabIndex = 6;
            this.bobToJoeButton.Text = "Bob gives $5 to Joe";
            this.bobToJoeButton.UseVisualStyleBackColor = true;
            this.bobToJoeButton.Click += new System.EventHandler(this.bobToJoeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 321);
            this.Controls.Add(this.bobToJoeButton);
            this.Controls.Add(this.joeToBobButton);
            this.Controls.Add(this.bobToBankButton);
            this.Controls.Add(this.bankToJoeButton);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button bankToJoeButton;
        private System.Windows.Forms.Button bobToBankButton;
        private System.Windows.Forms.Button joeToBobButton;
        private System.Windows.Forms.Button bobToJoeButton;
    }
}

