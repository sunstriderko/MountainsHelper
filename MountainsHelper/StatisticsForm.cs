using MountainHelperLibrary;
using MountainHelperLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MountainsHelper
{
    public partial class StatisticsForm : Form
    {
        List<MountainModel> notFinishedTours = new List<MountainModel>();
        List<MountainModel> finishedTours = new List<MountainModel>();

        public StatisticsForm()
        {
            InitializeComponent();

            GetStats();

            WireUpStatistics();

        }

        public void WireUpStatistics()
        {
            notFinishedToursListbox.DataSource = null;
            notFinishedToursListbox.DataSource = notFinishedTours;
            notFinishedToursListbox.DisplayMember = "MountainName";

            finishedToursListbox.DataSource = null;
            finishedToursListbox.DataSource = finishedTours;
            finishedToursListbox.DisplayMember = "MountainName";

        }

        private void addToFinishedButton_Click(object sender, EventArgs e)
        {
            MountainModel m = (MountainModel)notFinishedToursListbox.SelectedItem;

            //finishedTours.Add((MountainModel)notFinishedToursListbox.SelectedItem);
            //hore druha moznost ?? vyskusat( ale asi najprv pridat a potom zmazat, naopak by neslo)

            m.MountainFinished = true;

            UpdateStats(m);

            notFinishedTours.Remove(m);

            finishedTours.Add(m);

            WireUpStatistics();

        }

        private void removeFromFinishedButton_Click(object sender, EventArgs e)
        {
            MountainModel m = (MountainModel)finishedToursListbox.SelectedItem;

            if (!(m == null))
            {
                m.MountainFinished = false;

                UpdateStats(m);

                finishedTours.Remove(m);

                notFinishedTours.Add(m);

                WireUpStatistics();
            }
        }

        public void GetStats()
        {
            DataAccess db = new DataAccess();
            finishedTours = db.GetMountainsFinished();
            notFinishedTours = db.GetMountainsUnfinished();

        }

        public void UpdateStats(MountainModel model)
        {
            DataAccess db = new DataAccess();
            db.UpdateStatus(model);
        }
    }
}
