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
            this.selectMountainChainLabel = new System.Windows.Forms.Label();
            this.mainMenuPicturebox = new System.Windows.Forms.PictureBox();
            this.selectMountainComboBox = new System.Windows.Forms.ComboBox();
            this.selectMountaingChainComboBox = new System.Windows.Forms.ComboBox();
            this.insertMountainMenuButton = new System.Windows.Forms.Button();
            this.selectCountryLabel = new System.Windows.Forms.Label();
            this.selectCountryComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenuRefreshButton = new System.Windows.Forms.Button();
            this.createCountryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mountainHelperLabel
            // 
            this.mountainHelperLabel.AutoSize = true;
            this.mountainHelperLabel.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mountainHelperLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mountainHelperLabel.Location = new System.Drawing.Point(202, 20);
            this.mountainHelperLabel.Name = "mountainHelperLabel";
            this.mountainHelperLabel.Size = new System.Drawing.Size(440, 45);
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
            this.selectMountainLabel.Size = new System.Drawing.Size(170, 36);
            this.selectMountainLabel.TabIndex = 1;
            this.selectMountainLabel.Text = "Select Mountain :";
            // 
            // selectMountainChainLabel
            // 
            this.selectMountainChainLabel.AutoSize = true;
            this.selectMountainChainLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMountainChainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.selectMountainChainLabel.Location = new System.Drawing.Point(487, 291);
            this.selectMountainChainLabel.Name = "selectMountainChainLabel";
            this.selectMountainChainLabel.Size = new System.Drawing.Size(227, 36);
            this.selectMountainChainLabel.TabIndex = 2;
            this.selectMountainChainLabel.Text = "Select Mountain Chain :";
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
            this.selectMountainComboBox.Size = new System.Drawing.Size(235, 32);
            this.selectMountainComboBox.TabIndex = 6;
            // 
            // selectMountaingChainComboBox
            // 
            this.selectMountaingChainComboBox.FormattingEnabled = true;
            this.selectMountaingChainComboBox.Location = new System.Drawing.Point(493, 330);
            this.selectMountaingChainComboBox.Name = "selectMountaingChainComboBox";
            this.selectMountaingChainComboBox.Size = new System.Drawing.Size(232, 32);
            this.selectMountaingChainComboBox.TabIndex = 7;
            // 
            // insertMountainMenuButton
            // 
            this.insertMountainMenuButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.insertMountainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertMountainMenuButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertMountainMenuButton.ForeColor = System.Drawing.Color.Coral;
            this.insertMountainMenuButton.Location = new System.Drawing.Point(20, 391);
            this.insertMountainMenuButton.Name = "insertMountainMenuButton";
            this.insertMountainMenuButton.Size = new System.Drawing.Size(203, 57);
            this.insertMountainMenuButton.TabIndex = 9;
            this.insertMountainMenuButton.Text = "Insert Mountain";
            this.insertMountainMenuButton.UseVisualStyleBackColor = false;
            this.insertMountainMenuButton.Click += new System.EventHandler(this.insertMountainMenuButton_Click);
            // 
            // selectCountryLabel
            // 
            this.selectCountryLabel.AutoSize = true;
            this.selectCountryLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCountryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.selectCountryLabel.Location = new System.Drawing.Point(266, 291);
            this.selectCountryLabel.Name = "selectCountryLabel";
            this.selectCountryLabel.Size = new System.Drawing.Size(162, 36);
            this.selectCountryLabel.TabIndex = 10;
            this.selectCountryLabel.Text = "Select Country :";
            // 
            // selectCountryComboBox
            // 
            this.selectCountryComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectCountryComboBox.FormattingEnabled = true;
            this.selectCountryComboBox.Location = new System.Drawing.Point(272, 330);
            this.selectCountryComboBox.Name = "selectCountryComboBox";
            this.selectCountryComboBox.Size = new System.Drawing.Size(203, 32);
            this.selectCountryComboBox.TabIndex = 11;
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
            // mainMenuRefreshButton
            // 
            this.mainMenuRefreshButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainMenuRefreshButton.ForeColor = System.Drawing.Color.Red;
            this.mainMenuRefreshButton.Location = new System.Drawing.Point(628, 401);
            this.mainMenuRefreshButton.Name = "mainMenuRefreshButton";
            this.mainMenuRefreshButton.Size = new System.Drawing.Size(97, 44);
            this.mainMenuRefreshButton.TabIndex = 13;
            this.mainMenuRefreshButton.Text = "Refresh";
            this.mainMenuRefreshButton.UseVisualStyleBackColor = false;
            this.mainMenuRefreshButton.Click += new System.EventHandler(this.mainMenuRefreshButton_Click);
            // 
            // createCountryButton
            // 
            this.createCountryButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createCountryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCountryButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCountryButton.ForeColor = System.Drawing.Color.Coral;
            this.createCountryButton.Location = new System.Drawing.Point(272, 388);
            this.createCountryButton.Name = "createCountryButton";
            this.createCountryButton.Size = new System.Drawing.Size(203, 57);
            this.createCountryButton.TabIndex = 14;
            this.createCountryButton.Text = "Create Country";
            this.createCountryButton.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 460);
            this.Controls.Add(this.createCountryButton);
            this.Controls.Add(this.mainMenuRefreshButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selectCountryComboBox);
            this.Controls.Add(this.selectCountryLabel);
            this.Controls.Add(this.insertMountainMenuButton);
            this.Controls.Add(this.selectMountaingChainComboBox);
            this.Controls.Add(this.selectMountainComboBox);
            this.Controls.Add(this.mainMenuPicturebox);
            this.Controls.Add(this.selectMountainChainLabel);
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
        private System.Windows.Forms.Label selectMountainChainLabel;
        private System.Windows.Forms.PictureBox mainMenuPicturebox;
        private System.Windows.Forms.ComboBox selectMountainComboBox;
        private System.Windows.Forms.ComboBox selectMountaingChainComboBox;
        private System.Windows.Forms.Button insertMountainMenuButton;
        private System.Windows.Forms.Label selectCountryLabel;
        private System.Windows.Forms.ComboBox selectCountryComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mainMenuRefreshButton;
        private System.Windows.Forms.Button createCountryButton;
    }
}