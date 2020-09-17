using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MountainHelperLibrary;
using MountainHelperLibrary.Models;

namespace MountainsHelper
{
    public partial class InsertMountainForm : Form
    {
        MountainModel mountain = new MountainModel();

        public InsertMountainForm()
        {
            InitializeComponent();

        }

        private void insertMountainButton_Click(object sender, EventArgs e)
        {
            mountain.MountainName = mountainNameTextBox.Text;
            mountain.MountainHeight = int.Parse(mountainHeightTextBox.Text);
            mountain.MountainDifficulty = int.Parse(mountainDifficultyTextBox.Text);
            mountain.MountainTourStart = mountainTourStartPointTextBox.Text;
            mountain.MountainTimeOfTour = mountainTimeOfTourTextBox.Text;

            //mountain.MountainName = "Kopec";
            //mountain.MountainHeight = 2090;
            //mountain.MountainDifficulty = 2;
            //mountain.MountainTourStart = "";
            //mountain.MountainTimeOfTour = "";

            MainMenuForm frm = new MainMenuForm();
            frm.MountainInserted(mountain);

            this.Close();
        }
    }
}
