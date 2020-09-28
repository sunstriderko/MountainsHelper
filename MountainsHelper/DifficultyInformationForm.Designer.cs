namespace MountainsHelper
{
    partial class DifficultyInformationForm
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
            this.difDifficultyInformationsLabel = new System.Windows.Forms.Label();
            this.difMountainDifficultyLabel = new System.Windows.Forms.Label();
            this.difMountainsListbox = new System.Windows.Forms.ListBox();
            this.difLoadMountainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // difDifficultyInformationsLabel
            // 
            this.difDifficultyInformationsLabel.AutoSize = true;
            this.difDifficultyInformationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.difDifficultyInformationsLabel.Location = new System.Drawing.Point(12, 9);
            this.difDifficultyInformationsLabel.Name = "difDifficultyInformationsLabel";
            this.difDifficultyInformationsLabel.Size = new System.Drawing.Size(425, 46);
            this.difDifficultyInformationsLabel.TabIndex = 0;
            this.difDifficultyInformationsLabel.Text = "Difficulty Informations";
            // 
            // difMountainDifficultyLabel
            // 
            this.difMountainDifficultyLabel.AutoSize = true;
            this.difMountainDifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.difMountainDifficultyLabel.Location = new System.Drawing.Point(14, 93);
            this.difMountainDifficultyLabel.Name = "difMountainDifficultyLabel";
            this.difMountainDifficultyLabel.Size = new System.Drawing.Size(193, 32);
            this.difMountainDifficultyLabel.TabIndex = 2;
            this.difMountainDifficultyLabel.Text = "DifficultyText";
            // 
            // difMountainsListbox
            // 
            this.difMountainsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.difMountainsListbox.FormattingEnabled = true;
            this.difMountainsListbox.ItemHeight = 31;
            this.difMountainsListbox.Location = new System.Drawing.Point(20, 128);
            this.difMountainsListbox.Name = "difMountainsListbox";
            this.difMountainsListbox.Size = new System.Drawing.Size(675, 252);
            this.difMountainsListbox.TabIndex = 3;
            // 
            // difLoadMountainButton
            // 
            this.difLoadMountainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.difLoadMountainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.difLoadMountainButton.Location = new System.Drawing.Point(270, 386);
            this.difLoadMountainButton.Name = "difLoadMountainButton";
            this.difLoadMountainButton.Size = new System.Drawing.Size(192, 83);
            this.difLoadMountainButton.TabIndex = 4;
            this.difLoadMountainButton.Text = "Load Mountain Informations";
            this.difLoadMountainButton.UseVisualStyleBackColor = false;
            this.difLoadMountainButton.Click += new System.EventHandler(this.difLoadMountainButton_Click);
            // 
            // DifficultyInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 485);
            this.Controls.Add(this.difLoadMountainButton);
            this.Controls.Add(this.difMountainsListbox);
            this.Controls.Add(this.difMountainDifficultyLabel);
            this.Controls.Add(this.difDifficultyInformationsLabel);
            this.Name = "DifficultyInformationForm";
            this.Text = "Difficulty Informations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label difDifficultyInformationsLabel;
        private System.Windows.Forms.Label difMountainDifficultyLabel;
        private System.Windows.Forms.ListBox difMountainsListbox;
        private System.Windows.Forms.Button difLoadMountainButton;
    }
}