namespace Chooseyourownadventure
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.choice2 = new System.Windows.Forms.Label();
            this.choice1 = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.choice3 = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(0, 20);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(461, 30);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "You\'re on your way to visit your mum when you realize that you\'re lost, you come " +
    "to an\r\n intersection in the middle of nowhere, you see a convenience store and a" +
    " house.";
            // 
            // choice2
            // 
            this.choice2.AutoSize = true;
            this.choice2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice2.ForeColor = System.Drawing.Color.White;
            this.choice2.Location = new System.Drawing.Point(216, 145);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(129, 15);
            this.choice2.TabIndex = 1;
            this.choice2.Text = "Do you go to the store?";
            // 
            // choice1
            // 
            this.choice1.AutoSize = true;
            this.choice1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1.ForeColor = System.Drawing.Color.White;
            this.choice1.Location = new System.Drawing.Point(214, 108);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(135, 15);
            this.choice1.TabIndex = 2;
            this.choice1.Text = "Do you go to the house?";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.ForeColor = System.Drawing.Color.White;
            this.labelB.Location = new System.Drawing.Point(142, 145);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(47, 15);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "Press B:";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.ForeColor = System.Drawing.Color.White;
            this.labelM.Location = new System.Drawing.Point(139, 108);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(50, 15);
            this.labelM.TabIndex = 4;
            this.labelM.Text = "Press M:";
            // 
            // choice3
            // 
            this.choice3.AutoSize = true;
            this.choice3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice3.ForeColor = System.Drawing.Color.White;
            this.choice3.Location = new System.Drawing.Point(216, 179);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(50, 15);
            this.choice3.TabIndex = 5;
            this.choice3.Text = "Option3";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.ForeColor = System.Drawing.Color.White;
            this.labelN.Location = new System.Drawing.Point(142, 179);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(48, 15);
            this.labelN.TabIndex = 6;
            this.labelN.Text = "Press N:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(465, 243);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.choice3);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Where Are You";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label choice2;
        private System.Windows.Forms.Label choice1;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label choice3;
        private System.Windows.Forms.Label labelN;
    }
}

