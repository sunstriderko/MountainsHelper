namespace MountainsHelper
{
    partial class MainMenuForm
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
            this.mountainHelperLabel = new System.Windows.Forms.Label();
            this.selectMountainLabel = new System.Windows.Forms.Label();
            this.selectDifficultyLabel = new System.Windows.Forms.Label();
            this.mainMenuPicturebox = new System.Windows.Forms.PictureBox();
            this.selectMountainComboBox = new System.Windows.Forms.ComboBox();
            this.selectDifficultyComboBox = new System.Windows.Forms.ComboBox();
            this.insertMountainMenuButton = new System.Windows.Forms.Button();
            this.selectCountryLabel = new System.Windows.Forms.Label();
            this.selectCountryComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createCountryButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.deleteCountryButton = new System.Windows.Forms.Button();
            this.removeMountainMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mountainHelperLabel
            // 
            this.mountainHelperLabel.AutoSize = true;
            this.mountainHelperLabel.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mountainHelperLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mountainHelperLabel.Location = new System.Drawing.Point(176, 20);
            this.mountainHelperLabel.Name = "mountainHelperLabel";
            this.mountainHelperLabel.Size = new System.Drawing.Size(415, 44);
            this.mountainHelperLabel.TabIndex = 0;
            this.mountainHelperLabel.Text = "Welcome to Mountain Tour Helper";
            // 
            // selectMountainLabel
            // 
            this.selectMountainLabel.AutoSize = true;
            this.selectMountainLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMountainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.selectMountainLabel.Location = new System.Drawing.Point(14, 291);
            this.selectMountainLabel.Name = "selectMountainLabel";
            this.selectMountainLabel.Size = new System.Drawing.Size(143, 31);
            this.selectMountainLabel.TabIndex = 1;
            this.selectMountainLabel.Text = "Select Mountain :";
            // 
            // selectDifficultyLabel
            // 
            this.selectDifficultyLabel.AutoSize = true;
            this.selectDifficultyLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDifficultyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.selectDifficultyLabel.Location = new System.Drawing.Point(516, 291);
            this.selectDifficultyLabel.Name = "selectDifficultyLabel";
            this.selectDifficultyLabel.Size = new System.Drawing.Size(142, 31);
            this.selectDifficultyLabel.TabIndex = 2;
            this.selectDifficultyLabel.Text = "Select Difficulty :";
            // 
            // mainMenuPicturebox
            // 
            this.mainMenuPicturebox.ImageLocation = "C:\\Users\\adamc\\Desktop\\Kodenie\\MountainsHelper\\Pictures\\mountain.jpg";
            this.mainMenuPicturebox.Location = new System.Drawing.Point(20, 80);
            this.mainMenuPicturebox.Name = "mainMenuPicturebox";
            this.mainMenuPicturebox.Size = new System.Drawing.Size(343, 195);
            this.mainMenuPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainMenuPicturebox.TabIndex = 5;
            this.mainMenuPicturebox.TabStop = false;
            // 
            // selectMountainComboBox
            // 
            this.selectMountainComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectMountainComboBox.FormattingEnabled = true;
            this.selectMountainComboBox.Location = new System.Drawing.Point(20, 330);
            this.selectMountainComboBox.Name = "selectMountainComboBox";
            this.selectMountainComboBox.Size = new System.Drawing.Size(220, 28);
            this.selectMountainComboBox.TabIndex = 6;
            this.selectMountainComboBox.SelectionChangeCommitted += new System.EventHandler(this.selectMountainComboBox_SelectionChangeCommitted);
            // 
            // selectDifficultyComboBox
            // 
            this.selectDifficultyComboBox.FormattingEnabled = true;
            this.selectDifficultyComboBox.Location = new System.Drawing.Point(522, 330);
            this.selectDifficultyComboBox.Name = "selectDifficultyComboBox";
            this.selectDifficultyComboBox.Size = new System.Drawing.Size(203, 28);
            this.selectDifficultyComboBox.TabIndex = 7;
            // 
            // insertMountainMenuButton
            // 
            this.insertMountainMenuButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.insertMountainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertMountainMenuButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertMountainMenuButton.ForeColor = System.Drawing.Color.Coral;
            this.insertMountainMenuButton.Location = new System.Drawing.Point(20, 391);
            this.insertMountainMenuButton.Name = "insertMountainMenuButton";
            this.insertMountainMenuButton.Size = new System.Drawing.Size(107, 57);
            this.insertMountainMenuButton.TabIndex = 9;
            this.insertMountainMenuButton.Text = "Insert ";
            this.insertMountainMenuButton.UseVisualStyleBackColor = false;
            this.insertMountainMenuButton.Click += new System.EventHandler(this.insertMountainMenuButton_Click);
            // 
            // selectCountryLabel
            // 
            this.selectCountryLabel.AutoSize = true;
            this.selectCountryLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCountryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.selectCountryLabel.Location = new System.Drawing.Point(269, 291);
            this.selectCountryLabel.Name = "selectCountryLabel";
            this.selectCountryLabel.Size = new System.Drawing.Size(137, 31);
            this.selectCountryLabel.TabIndex = 10;
            this.selectCountryLabel.Text = "Select Country :";
            // 
            // selectCountryComboBox
            // 
            this.selectCountryComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectCountryComboBox.FormattingEnabled = true;
            this.selectCountryComboBox.Location = new System.Drawing.Point(275, 330);
            this.selectCountryComboBox.Name = "selectCountryComboBox";
            this.selectCountryComboBox.Size = new System.Drawing.Size(217, 28);
            this.selectCountryComboBox.TabIndex = 11;
            this.selectCountryComboBox.SelectionChangeCommitted += new System.EventHandler(this.selectCountryComboBox_SelectionChangeCommitted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\adamc\\Desktop\\Kodenie\\MountainsHelper\\Pictures\\tatry.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(382, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // createCountryButton
            // 
            this.createCountryButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createCountryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCountryButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCountryButton.ForeColor = System.Drawing.Color.Coral;
            this.createCountryButton.Location = new System.Drawing.Point(275, 391);
            this.createCountryButton.Name = "createCountryButton";
            this.createCountryButton.Size = new System.Drawing.Size(107, 57);
            this.createCountryButton.TabIndex = 14;
            this.createCountryButton.Text = "Create";
            this.createCountryButton.UseVisualStyleBackColor = false;
            this.createCountryButton.Click += new System.EventHandler(this.createCountryButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statisticsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statisticsButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsButton.ForeColor = System.Drawing.Color.Coral;
            this.statisticsButton.Location = new System.Drawing.Point(522, 391);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(203, 57);
            this.statisticsButton.TabIndex = 15;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // deleteCountryButton
            // 
            this.deleteCountryButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteCountryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCountryButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCountryButton.ForeColor = System.Drawing.Color.Coral;
            this.deleteCountryButton.Location = new System.Drawing.Point(385, 391);
            this.deleteCountryButton.Name = "deleteCountryButton";
            this.deleteCountryButton.Size = new System.Drawing.Size(107, 57);
            this.deleteCountryButton.TabIndex = 16;
            this.deleteCountryButton.Text = "Delete";
            this.deleteCountryButton.UseVisualStyleBackColor = false;
            this.deleteCountryButton.Click += new System.EventHandler(this.deleteCountryButton_Click);
            // 
            // removeMountainMenuButton
            // 
            this.removeMountainMenuButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.removeMountainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeMountainMenuButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMountainMenuButton.ForeColor = System.Drawing.Color.Coral;
            this.removeMountainMenuButton.Location = new System.Drawing.Point(133, 391);
            this.removeMountainMenuButton.Name = "removeMountainMenuButton";
            this.removeMountainMenuButton.Size = new System.Drawing.Size(107, 57);
            this.removeMountainMenuButton.TabIndex = 17;
            this.removeMountainMenuButton.Text = "Remove";
            this.removeMountainMenuButton.UseVisualStyleBackColor = false;
            this.removeMountainMenuButton.Click += new System.EventHandler(this.removeMountainMenuButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 460);
            this.Controls.Add(this.removeMountainMenuButton);
            this.Controls.Add(this.deleteCountryButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.createCountryButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selectCountryComboBox);
            this.Controls.Add(this.selectCountryLabel);
            this.Controls.Add(this.insertMountainMenuButton);
            this.Controls.Add(this.selectDifficultyComboBox);
            this.Controls.Add(this.selectMountainComboBox);
            this.Controls.Add(this.mainMenuPicturebox);
            this.Controls.Add(this.selectDifficultyLabel);
            this.Controls.Add(this.selectMountainLabel);
            this.Controls.Add(this.mountainHelperLabel);
            this.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenuForm";
            this.Text = "Mountain Helper";
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mountainHelperLabel;
        private System.Windows.Forms.Label selectMountainLabel;
        private System.Windows.Forms.Label selectDifficultyLabel;
        private System.Windows.Forms.PictureBox mainMenuPicturebox;
        private System.Windows.Forms.ComboBox selectMountainComboBox;
        private System.Windows.Forms.ComboBox selectDifficultyComboBox;
        private System.Windows.Forms.Button insertMountainMenuButton;
        private System.Windows.Forms.Label selectCountryLabel;
        private System.Windows.Forms.ComboBox selectCountryComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createCountryButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button deleteCountryButton;
        private System.Windows.Forms.Button removeMountainMenuButton;
    }
}