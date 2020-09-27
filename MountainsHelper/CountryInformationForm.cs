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

        }
    }
}
