﻿using MountainHelperLibrary.Models;
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
    public partial class MountainInformationForm : Form
    {
        private MountainModel mountain;
        public MountainInformationForm(MountainModel model)
        {
            InitializeComponent();

            mountain = model;

            InformationsDataGetter();

        }

        public void InformationsDataGetter()
        {
                mifMountainNameTextbox.Text = mountain.MountainName;
                mifMountainHeightTextbox.Text = mountain.MountainHeight.ToString();
                mifMountainDifficultyTextbox.Text = mountain.MountainDifficulty.ToString();
                mifMountainStartPointTextbox.Text = mountain.MountainTourStart;
                mifMountainTimeOfTourTextbox.Text = mountain.MountainTimeOfTour;

        }
    }
}
