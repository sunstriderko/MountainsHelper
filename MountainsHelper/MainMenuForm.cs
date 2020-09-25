using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MountainHelperLibrary.Models;
using MountainHelperLibrary;

namespace MountainsHelper
{
    public partial class MainMenuForm : Form
    {
        internal static MainMenuForm mmf;
        internal static InsertMountainForm imf;
        internal static CreateCountryForm ccf;

        public List<MountainModel> availibleMountains = new List<MountainModel>();
        List<CountryModel> availibleCountries = new List<CountryModel>();
        List<MountainChainModel> availibleMountainChains = new List<MountainChainModel>();
        List<MountainDifficultyModel> availibleDifficulties = new List<MountainDifficultyModel>();

        public void MountainInserted(MountainModel myMountain)
        {
            availibleMountains.Add(myMountain);

            DifficultySorter(availibleMountains, availibleDifficulties);

            CountrySorter(availibleMountains, availibleCountries);
            
            WireUpLists();

        }

        public void CountryInserted(CountryModel myCountry)
        {
            availibleCountries.Add(myCountry);

            WireUpLists();
        }

        public MainMenuForm()
        {
            InitializeComponent();

            mmf = this;

            DataGetter();

            DifficultyListCreator();

            DifficultySorter(availibleMountains, availibleDifficulties);

            CountrySorter(availibleMountains, availibleCountries);

            WireUpLists();

        }

        public void WireUpLists()
        {
            selectMountainComboBox.DataSource = null;
            selectMountainComboBox.DataSource = availibleMountains;
            selectMountainComboBox.DisplayMember = "MountainName";

            selectCountryComboBox.DataSource = null;
            selectCountryComboBox.DataSource = availibleCountries;
            selectCountryComboBox.DisplayMember = "CountryName";

            selectDifficultyComboBox.DataSource = null;
            selectDifficultyComboBox.DataSource = availibleDifficulties;
            selectDifficultyComboBox.DisplayMember = "DifficultyNumber";

        }


        private void insertMountainMenuButton_Click(object sender, EventArgs e)
        {
            imf = new InsertMountainForm();
            imf.Show();

        }

        public void CountrySorter(List<MountainModel> mountains, List<CountryModel> countries)
        {
            foreach (CountryModel country in countries)
            {
                foreach (MountainModel mountain in mountains)
                {
                    if (country.CountryName == mountain.MountainCountryName)
                    {
                        country.MountainsInCountry.Add(mountain);
                    }
                }
            }
        }

        public void DifficultySorter(List<MountainModel> mountains, List<MountainDifficultyModel> difficulties)
        {
            foreach (MountainDifficultyModel difficulty in difficulties)
            {
                foreach (MountainModel mountain in mountains)
                {
                    if (mountain.MountainDifficulty == difficulty.DifficultyNumber)
                    {
                        difficulty.ListOfMountains.Add(mountain);
                    }
                }
            }
        }

        public void DifficultyListCreator()
        {
            MountainDifficultyModel One = new MountainDifficultyModel();
            One.DifficultyNumber = 1;
            MountainDifficultyModel Two = new MountainDifficultyModel();
            Two.DifficultyNumber = 2;
            MountainDifficultyModel Three = new MountainDifficultyModel();
            Three.DifficultyNumber = 3;
            MountainDifficultyModel Four = new MountainDifficultyModel();
            Four.DifficultyNumber = 4;
            MountainDifficultyModel Five = new MountainDifficultyModel();
            Five.DifficultyNumber = 5;

            availibleDifficulties.Add(One);
            availibleDifficulties.Add(Two);
            availibleDifficulties.Add(Three);
            availibleDifficulties.Add(Four);
            availibleDifficulties.Add(Five);
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            StatisticsForm frm = new StatisticsForm();
            frm.Show();
        }

        private void createCountryButton_Click(object sender, EventArgs e)
        {
            ccf = new CreateCountryForm();
            ccf.Show();
        }

        public void DataGetter()
        {
            DataAccess db = new DataAccess();

            availibleMountains = db.GetMountains();

            availibleCountries = db.GetCountries();
        }

        private void removeMountainMenuButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            MountainModel selectedMountain = new MountainModel();
            selectedMountain = (MountainModel)selectMountainComboBox.SelectedItem;

            db.RemoveMountain(selectedMountain);

            DataGetter();

            WireUpLists();
        }

        private void deleteCountryButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            CountryModel selectedCountry = new CountryModel();
            selectedCountry = (CountryModel)selectCountryComboBox.SelectedItem;

            db.RemoveCountry(selectedCountry);

            DataGetter();

            WireUpLists();

        }
    }
}
