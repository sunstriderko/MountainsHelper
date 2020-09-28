using MountainHelperLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MountainsHelper
{
    public partial class DifficultyInformationForm : Form
    {
        private MountainDifficultyModel difficulty;
        public DifficultyInformationForm(MountainDifficultyModel model)
        {
            InitializeComponent();

            difficulty = model;

            DifficultyDataWiring();

        }

        public void DifficultyDataWiring()
        {
            difMountainsListbox.DataSource = null;
            difMountainsListbox.DataSource = difficulty.ListOfMountains;
            difMountainsListbox.DisplayMember = "MountainName";

            difMountainDifficultyLabel.Text = "Difficulty number " + difficulty.DifficultyNumber + " involves these mountains :";
        }

        private void difLoadMountainButton_Click(object sender, EventArgs e)
        {
            MountainModel mm = new MountainModel();
            mm = (MountainModel)difMountainsListbox.SelectedItem;

            MountainInformationForm frm = new MountainInformationForm(mm);
            frm.Show();

        }
    }
}
