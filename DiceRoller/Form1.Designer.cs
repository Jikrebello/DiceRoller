
namespace DiceRoller
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
            this.Btn_Roll_Dice = new System.Windows.Forms.Button();
            this.Lbl_Roll_Sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Roll_Dice
            // 
            this.Btn_Roll_Dice.Location = new System.Drawing.Point(64, 248);
            this.Btn_Roll_Dice.Name = "Btn_Roll_Dice";
            this.Btn_Roll_Dice.Size = new System.Drawing.Size(118, 30);
            this.Btn_Roll_Dice.TabIndex = 0;
            this.Btn_Roll_Dice.Text = "Roll Dice";
            this.Btn_Roll_Dice.UseVisualStyleBackColor = true;
            this.Btn_Roll_Dice.Click += new System.EventHandler(this.Btn_Roll_Dice_Click);
            // 
            // Lbl_Roll_Sum
            // 
            this.Lbl_Roll_Sum.AutoSize = true;
            this.Lbl_Roll_Sum.Location = new System.Drawing.Point(61, 228);
            this.Lbl_Roll_Sum.Name = "Lbl_Roll_Sum";
            this.Lbl_Roll_Sum.Size = new System.Drawing.Size(0, 17);
            this.Lbl_Roll_Sum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 288);
            this.Controls.Add(this.Lbl_Roll_Sum);
            this.Controls.Add(this.Btn_Roll_Dice);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(265, 335);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(265, 335);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Roll_Dice;
        private System.Windows.Forms.Label Lbl_Roll_Sum;
    }
}

