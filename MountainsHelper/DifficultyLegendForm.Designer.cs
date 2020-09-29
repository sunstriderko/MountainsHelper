namespace MountainsHelper
{
    partial class DifficultyLegendForm
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
            this.dlfDifficultyOneLabel = new System.Windows.Forms.Label();
            this.dlfDifficultyTwoLabel = new System.Windows.Forms.Label();
            this.dlfDifficultyThreeLabel = new System.Windows.Forms.Label();
            this.dlfDifficultyFourLabel = new System.Windows.Forms.Label();
            this.dlfDifficultyFiveLabel = new System.Windows.Forms.Label();
            this.dlfHeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dlfDifficultyOneLabel
            // 
            this.dlfDifficultyOneLabel.AutoSize = true;
            this.dlfDifficultyOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlfDifficultyOneLabel.Location = new System.Drawing.Point(12, 80);
            this.dlfDifficultyOneLabel.Name = "dlfDifficultyOneLabel";
            this.dlfDifficultyOneLabel.Size = new System.Drawing.Size(95, 25);
            this.dlfDifficultyOneLabel.TabIndex = 0;
            this.dlfDifficultyOneLabel.Text = "Difficulty1";
            // 
            // dlfDifficultyTwoLabel
            // 
            this.dlfDifficultyTwoLabel.AutoSize = true;
            this.dlfDifficultyTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlfDifficultyTwoLabel.Location = new System.Drawing.Point(12, 133);
            this.dlfDifficultyTwoLabel.Name = "dlfDifficultyTwoLabel";
            this.dlfDifficultyTwoLabel.Size = new System.Drawing.Size(95, 25);
            this.dlfDifficultyTwoLabel.TabIndex = 1;
            this.dlfDifficultyTwoLabel.Text = "Difficulty2";
            // 
            // dlfDifficultyThreeLabel
            // 
            this.dlfDifficultyThreeLabel.AutoSize = true;
            this.dlfDifficultyThreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlfDifficultyThreeLabel.Location = new System.Drawing.Point(12, 186);
            this.dlfDifficultyThreeLabel.Name = "dlfDifficultyThreeLabel";
            this.dlfDifficultyThreeLabel.Size = new System.Drawing.Size(100, 25);
            this.dlfDifficultyThreeLabel.TabIndex = 2;
            this.dlfDifficultyThreeLabel.Text = "Difficulty 3";
            // 
            // dlfDifficultyFourLabel
            // 
            this.dlfDifficultyFourLabel.AutoSize = true;
            this.dlfDifficultyFourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlfDifficultyFourLabel.Location = new System.Drawing.Point(12, 242);
            this.dlfDifficultyFourLabel.Name = "dlfDifficultyFourLabel";
            this.dlfDifficultyFourLabel.Size = new System.Drawing.Size(95, 25);
            this.dlfDifficultyFourLabel.TabIndex = 3;
            this.dlfDifficultyFourLabel.Text = "Difficulty4";
            // 
            // dlfDifficultyFiveLabel
            // 
            this.dlfDifficultyFiveLabel.AutoSize = true;
            this.dlfDifficultyFiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlfDifficultyFiveLabel.Location = new System.Drawing.Point(12, 294);
            this.dlfDifficultyFiveLabel.Name = "dlfDifficultyFiveLabel";
            this.dlfDifficultyFiveLabel.Size = new System.Drawing.Size(95, 25);
            this.dlfDifficultyFiveLabel.TabIndex = 4;
            this.dlfDifficultyFiveLabel.Text = "Difficulty5";
            // 
            // dlfHeaderLabel
            // 
            this.dlfHeaderLabel.AutoSize = true;
            this.dlfHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlfHeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.dlfHeaderLabel.Name = "dlfHeaderLabel";
            this.dlfHeaderLabel.Size = new System.Drawing.Size(359, 29);
            this.dlfHeaderLabel.TabIndex = 5;
            this.dlfHeaderLabel.Text = "Select your difficulty carefully!";
            // 
            // DifficultyLegendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 357);
            this.Controls.Add(this.dlfHeaderLabel);
            this.Controls.Add(this.dlfDifficultyFiveLabel);
            this.Controls.Add(this.dlfDifficultyFourLabel);
            this.Controls.Add(this.dlfDifficultyThreeLabel);
            this.Controls.Add(this.dlfDifficultyTwoLabel);
            this.Controls.Add(this.dlfDifficultyOneLabel);
            this.Name = "DifficultyLegendForm";
            this.Text = "Difficulty Legend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dlfDifficultyOneLabel;
        private System.Windows.Forms.Label dlfDifficultyTwoLabel;
        private System.Windows.Forms.Label dlfDifficultyThreeLabel;
        private System.Windows.Forms.Label dlfDifficultyFourLabel;
        private System.Windows.Forms.Label dlfDifficultyFiveLabel;
        private System.Windows.Forms.Label dlfHeaderLabel;
    }
}