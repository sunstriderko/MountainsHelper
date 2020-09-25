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
        List<MountainModel> imfAllMountains = new List<MountainModel>();
        MountainModel mountain = new MountainModel();

        public InsertMountainForm()
        {
            InitializeComponent();

            InsertMountainDataGetter();

        }

        private void insertMountainButton_Click(object sender, EventArgs e)
        {
            int[] placeholder = new int[imfAllMountains.Count];

            mountain.MountainName = mountainNameTextBox.Text;
            mountain.MountainHeight = int.Parse(mountainHeightTextBox.Text);
            mountain.MountainDifficulty = int.Parse(mountainDifficultyTextBox.Text);
            mountain.MountainTourStart = mountainTourStartPointTextBox.Text;
            mountain.MountainTimeOfTour = mountainTimeOfTourTextBox.Text;
            mountain.MountainCountryName = countryNameTextbox.Text;

            for (int i = 0; i < imfAllMountains.Count; i++)
            {
                if (mountain.MountainName == imfAllMountains[i].MountainName)
                {
                    placeholder[i]++;

                }
            }

            if (placeholder.Sum() > 0)
            {
                MessageBox.Show("This country already exists!");

            }

            else
            { 
                DataAccess db = new DataAccess();
                db.CreateMountain(mountain);

                MainMenuForm.mmf.MountainInserted(mountain);
            }

            this.Close();
        }

        public void InsertMountainDataGetter()
        {
            DataAccess db = new DataAccess();
            imfAllMountains = db.GetMountains();

        }
    }
}
