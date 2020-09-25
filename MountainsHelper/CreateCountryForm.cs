using MountainHelperLibrary;
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
    public partial class CreateCountryForm : Form
    {
        List<CountryModel> ccfAllCountries = new List<CountryModel>();
        CountryModel country = new CountryModel();
        
        public CreateCountryForm()
        {
            InitializeComponent();

            CreateCountryFormDataGetter();

        }

        public void CreateCountryFormDataGetter()
        {
            DataAccess db = new DataAccess();
            ccfAllCountries = db.GetCountries();

        }

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            int[] placeholder = new int[ccfAllCountries.Count];

            country.CountryName = createCountryCountryNameTextbox.Text;

            for (int i= 0; i < ccfAllCountries.Count; i++)
            {
                if (country.CountryName == ccfAllCountries[i].CountryName)
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
                db.CreateCountry(country);

                MainMenuForm.mmf.CountryInserted(country);
            }

            this.Close();
        }
    }
}
