namespace MountainsHelper
{
    partial class CreateCountryForm
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
            this.createCountryCountryNameLabel = new System.Windows.Forms.Label();
            this.createCountryCountryNameTextbox = new System.Windows.Forms.TextBox();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createCountryCountryNameLabel
            // 
            this.createCountryCountryNameLabel.AutoSize = true;
            this.createCountryCountryNameLabel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.createCountryCountryNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.createCountryCountryNameLabel.Location = new System.Drawing.Point(12, 21);
            this.createCountryCountryNameLabel.Name = "createCountryCountryNameLabel";
            this.createCountryCountryNameLabel.Size = new System.Drawing.Size(128, 31);
            this.createCountryCountryNameLabel.TabIndex = 0;
            this.createCountryCountryNameLabel.Text = "Country Name:";
            // 
            // createCountryCountryNameTextbox
            // 
            this.createCountryCountryNameTextbox.Location = new System.Drawing.Point(18, 69);
            this.createCountryCountryNameTextbox.Name = "createCountryCountryNameTextbox";
            this.createCountryCountryNameTextbox.Size = new System.Drawing.Size(153, 26);
            this.createCountryCountryNameTextbox.TabIndex = 1;
            // 
            // addCountryButton
            // 
            this.addCountryButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addCountryButton.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCountryButton.ForeColor = System.Drawing.Color.Coral;
            this.addCountryButton.Location = new System.Drawing.Point(241, 49);
            this.addCountryButton.Name = "addCountryButton";
            this.addCountryButton.Size = new System.Drawing.Size(109, 62);
            this.addCountryButton.TabIndex = 2;
            this.addCountryButton.Text = "Add Country";
            this.addCountryButton.UseVisualStyleBackColor = false;
            this.addCountryButton.Click += new System.EventHandler(this.addCountryButton_Click);
            // 
            // CreateCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 137);
            this.Controls.Add(this.addCountryButton);
            this.Controls.Add(this.createCountryCountryNameTextbox);
            this.Controls.Add(this.createCountryCountryNameLabel);
            this.Name = "CreateCountryForm";
            this.Text = "Create Country";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createCountryCountryNameLabel;
        private System.Windows.Forms.TextBox createCountryCountryNameTextbox;
        private System.Windows.Forms.Button addCountryButton;
    }
}