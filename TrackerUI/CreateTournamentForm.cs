﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
    {
        private List<TeamModel> availableTeams = GlobalConfig.Connections.First().GetTeam_All();

        public CreateTournamentForm()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";
        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {
        }

        private void teamOneScoreLabel_Click(object sender, EventArgs e)
        {
        }

        private void teamOneScoreValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void entryFeeValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
        }

        private void selectTeamLabel_Click(object sender, EventArgs e)
        {
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void selectTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
        }
    }
}