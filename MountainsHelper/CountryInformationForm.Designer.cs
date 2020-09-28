namespace MountainsHelper
{
    partial class CountryInformationForm
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
            this.cifCountriesListbox = new System.Windows.Forms.ListBox();
            this.cifCountryNameLabel = new System.Windows.Forms.Label();
            this.cifCountryInformationsLabel = new System.Windows.Forms.Label();
            this.cifLoadMountainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cifCountriesListbox
            // 
            this.cifCountriesListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cifCountriesListbox.FormattingEnabled = true;
            this.cifCountriesListbox.ItemHeight = 31;
            this.cifCountriesListbox.Location = new System.Drawing.Point(18, 112);
            this.cifCountriesListbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cifCountriesListbox.Name = "cifCountriesListbox";
            this.cifCountriesListbox.Size = new System.Drawing.Size(580, 221);
            this.cifCountriesListbox.TabIndex = 0;
            // 
            // cifCountryNameLabel
            // 
            this.cifCountryNameLabel.AutoSize = true;
            this.cifCountryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cifCountryNameLabel.Location = new System.Drawing.Point(12, 77);
            this.cifCountryNameLabel.Name = "cifCountryNameLabel";
            this.cifCountryNameLabel.Size = new System.Drawing.Size(200, 32);
            this.cifCountryNameLabel.TabIndex = 1;
            this.cifCountryNameLabel.Text = "CountryName";
            // 
            // cifCountryInformationsLabel
            // 
            this.cifCountryInformationsLabel.AutoSize = true;
            this.cifCountryInformationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cifCountryInformationsLabel.Location = new System.Drawing.Point(11, 7);
            this.cifCountryInformationsLabel.Name = "cifCountryInformationsLabel";
            this.cifCountryInformationsLabel.Size = new System.Drawing.Size(422, 46);
            this.cifCountryInformationsLabel.TabIndex = 2;
            this.cifCountryInformationsLabel.Text = "Country Informations ";
            // 
            // cifLoadMountainButton
            // 
            this.cifLoadMountainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cifLoadMountainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cifLoadMountainButton.Location = new System.Drawing.Point(226, 350);
            this.cifLoadMountainButton.Name = "cifLoadMountainButton";
            this.cifLoadMountainButton.Size = new System.Drawing.Size(183, 70);
            this.cifLoadMountainButton.TabIndex = 3;
            this.cifLoadMountainButton.Text = "Load Mountain Informations";
            this.cifLoadMountainButton.UseVisualStyleBackColor = false;
            this.cifLoadMountainButton.Click += new System.EventHandler(this.cifLoadMountainButton_Click);
            // 
            // CountryInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 432);
            this.Controls.Add(this.cifLoadMountainButton);
            this.Controls.Add(this.cifCountryInformationsLabel);
            this.Controls.Add(this.cifCountryNameLabel);
            this.Controls.Add(this.cifCountriesListbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CountryInformationForm";
            this.Text = "Country Informations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cifCountriesListbox;
        private System.Windows.Forms.Label cifCountryNameLabel;
        private System.Windows.Forms.Label cifCountryInformationsLabel;
        private System.Windows.Forms.Button cifLoadMountainButton;
    }
}