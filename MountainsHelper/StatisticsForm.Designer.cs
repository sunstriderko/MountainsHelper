namespace MountainsHelper
{
    partial class StatisticsForm
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
            this.notFinishedToursListbox = new System.Windows.Forms.ListBox();
            this.finishedToursListbox = new System.Windows.Forms.ListBox();
            this.notFinishedToursLabel = new System.Windows.Forms.Label();
            this.finishedToursLabel = new System.Windows.Forms.Label();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.addToFinishedButton = new System.Windows.Forms.Button();
            this.removeFromFinishedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notFinishedToursListbox
            // 
            this.notFinishedToursListbox.FormattingEnabled = true;
            this.notFinishedToursListbox.ItemHeight = 22;
            this.notFinishedToursListbox.Location = new System.Drawing.Point(12, 95);
            this.notFinishedToursListbox.Name = "notFinishedToursListbox";
            this.notFinishedToursListbox.Size = new System.Drawing.Size(283, 356);
            this.notFinishedToursListbox.TabIndex = 0;
            // 
            // finishedToursListbox
            // 
            this.finishedToursListbox.FormattingEnabled = true;
            this.finishedToursListbox.ItemHeight = 22;
            this.finishedToursListbox.Location = new System.Drawing.Point(475, 95);
            this.finishedToursListbox.Name = "finishedToursListbox";
            this.finishedToursListbox.Size = new System.Drawing.Size(283, 356);
            this.finishedToursListbox.TabIndex = 1;
            // 
            // notFinishedToursLabel
            // 
            this.notFinishedToursLabel.AutoSize = true;
            this.notFinishedToursLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFinishedToursLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.notFinishedToursLabel.Location = new System.Drawing.Point(6, 61);
            this.notFinishedToursLabel.Name = "notFinishedToursLabel";
            this.notFinishedToursLabel.Size = new System.Drawing.Size(158, 31);
            this.notFinishedToursLabel.TabIndex = 2;
            this.notFinishedToursLabel.Text = "Not Finished Tours:";
            // 
            // finishedToursLabel
            // 
            this.finishedToursLabel.AutoSize = true;
            this.finishedToursLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishedToursLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.finishedToursLabel.Location = new System.Drawing.Point(469, 61);
            this.finishedToursLabel.Name = "finishedToursLabel";
            this.finishedToursLabel.Size = new System.Drawing.Size(128, 31);
            this.finishedToursLabel.TabIndex = 3;
            this.finishedToursLabel.Text = "Finished Tours:";
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.AutoSize = true;
            this.statisticsLabel.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.statisticsLabel.Location = new System.Drawing.Point(297, 9);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.Size = new System.Drawing.Size(176, 59);
            this.statisticsLabel.TabIndex = 4;
            this.statisticsLabel.Text = "Statistics";
            // 
            // addToFinishedButton
            // 
            this.addToFinishedButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addToFinishedButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToFinishedButton.ForeColor = System.Drawing.Color.Coral;
            this.addToFinishedButton.Location = new System.Drawing.Point(339, 147);
            this.addToFinishedButton.Name = "addToFinishedButton";
            this.addToFinishedButton.Size = new System.Drawing.Size(99, 106);
            this.addToFinishedButton.TabIndex = 5;
            this.addToFinishedButton.Text = "Add To Finished";
            this.addToFinishedButton.UseVisualStyleBackColor = false;
            this.addToFinishedButton.Click += new System.EventHandler(this.addToFinishedButton_Click);
            // 
            // removeFromFinishedButton
            // 
            this.removeFromFinishedButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.removeFromFinishedButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFromFinishedButton.ForeColor = System.Drawing.Color.Coral;
            this.removeFromFinishedButton.Location = new System.Drawing.Point(339, 292);
            this.removeFromFinishedButton.Name = "removeFromFinishedButton";
            this.removeFromFinishedButton.Size = new System.Drawing.Size(99, 107);
            this.removeFromFinishedButton.TabIndex = 6;
            this.removeFromFinishedButton.Text = "Remove From Frinished";
            this.removeFromFinishedButton.UseVisualStyleBackColor = false;
            this.removeFromFinishedButton.Click += new System.EventHandler(this.removeFromFinishedButton_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 456);
            this.Controls.Add(this.removeFromFinishedButton);
            this.Controls.Add(this.addToFinishedButton);
            this.Controls.Add(this.statisticsLabel);
            this.Controls.Add(this.finishedToursLabel);
            this.Controls.Add(this.notFinishedToursLabel);
            this.Controls.Add(this.finishedToursListbox);
            this.Controls.Add(this.notFinishedToursListbox);
            this.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox notFinishedToursListbox;
        private System.Windows.Forms.ListBox finishedToursListbox;
        private System.Windows.Forms.Label notFinishedToursLabel;
        private System.Windows.Forms.Label finishedToursLabel;
        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.Button addToFinishedButton;
        private System.Windows.Forms.Button removeFromFinishedButton;
    }
}