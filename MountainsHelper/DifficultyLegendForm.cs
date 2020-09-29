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
    public partial class DifficultyLegendForm : Form
    {
        private List<MountainDifficultyModel> difficulties;
        public DifficultyLegendForm(List<MountainDifficultyModel> model)
        {
            InitializeComponent();

            difficulties = model;

            LegendDataWiring();

        }

        public void LegendDataWiring()
        {
            dlfDifficultyOneLabel.Text = difficulties[0].DifficultyNumber.ToString() + " - " + "Represents a very easy tour which can be done with babies";
            dlfDifficultyTwoLabel.Text = difficulties[1].DifficultyNumber.ToString() + " - " + "Represents na easy tour which includes higher levels and takes few hours";
            dlfDifficultyThreeLabel.Text = difficulties[2].DifficultyNumber.ToString() + " - " + "Represents a medium tour which takes you to higher levels, but still doesnt require any equipment";
            dlfDifficultyFourLabel.Text = difficulties[3].DifficultyNumber.ToString() + " - " + "Represents a hard tour which inclutes climbing with chains, don't bring unexperienced people";
            dlfDifficultyFiveLabel.Text = difficulties[4].DifficultyNumber.ToString() + " - " + "Represents a very hard tour which requires a tour guide and mountain climber equipment";

        }

    }
}
