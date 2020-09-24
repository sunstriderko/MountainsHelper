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
        CountryModel country = new CountryModel();
        
        public CreateCountryForm()
        {
            InitializeComponent();

        }

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            country.CountryName = createCountryCountryNameTextbox.Text;

            DataAccess db = new DataAccess();
            db.CreateCountry(country);

            MainMenuForm.frm1.CountryInserted(country);

            this.Close();
        }
    }
}
