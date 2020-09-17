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
        List<MountainModel> availibleMountains = new List<MountainModel>();
        List<CountryModel> availibleCountries = new List<CountryModel>();
        List<MountainChainModel> availibleMountainChains = new List<MountainChainModel>();

        public void MountainInserted(MountainModel myMountain)
        {
            availibleMountains.Add(myMountain);

            WireUpLists();

        }

        public MainMenuForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        public void WireUpLists()
        {
            selectMountainComboBox.DataSource = null;
            selectMountainComboBox.DataSource = availibleMountains;
            selectMountainComboBox.DisplayMember = "MountainName";
        }


        private void insertMountainMenuButton_Click(object sender, EventArgs e)
        {
            InsertMountainForm frm = new InsertMountainForm();
            frm.Show();
            
        }

        private void mainMenuRefreshButton_Click(object sender, EventArgs e)
        {
            WireUpLists();

        }

        //TODO - List of done tours and not done - new form with button in main menu.
    }
}
