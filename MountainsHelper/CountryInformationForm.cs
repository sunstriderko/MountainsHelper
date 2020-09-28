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
    public partial class CountryInformationForm : Form
    {
        private CountryModel country;
        public CountryInformationForm( CountryModel countryModel )
        {
            InitializeComponent();

            country = countryModel;

            CountryDataWiring();

        }

        public void CountryDataWiring()
        {
            cifCountriesListbox.DataSource = null;
            cifCountriesListbox.DataSource = country.MountainsInCountry;
            cifCountriesListbox.DisplayMember = "MountainName";

            cifCountryNameLabel.Text = "Mountains you can visit in " + country.CountryName + " :";
        }

        private void cifLoadMountainButton_Click(object sender, EventArgs e)
        {
            MountainModel mm = new MountainModel();
            mm = (MountainModel)cifCountriesListbox.SelectedItem;

            MountainInformationForm frm = new MountainInformationForm(mm);
            frm.Show();
        }
    }
}
