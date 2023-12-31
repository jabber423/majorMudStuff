﻿using MMudTerm.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMudTerm.Session
{
    public partial class CombatSessionControl : UserControl
    {
        private CombatSession session;

        public CombatSessionControl()
        {
            InitializeComponent();
        }

        public CombatSessionControl(CombatSession session)
        {
            this.session = session;
            InitializeComponent();
            this.SuspendLayout();
            this.label_ongoing_value.Text = session.IsBeingAttackByThisEntity.ToString();
            this.label_rcvr_damage_from_player_value.Text = session.damage_taken.ToString();
            this.label_rcv_dmg_value.Text = session.damage_taken.ToString();
            this.label_taken_damage_from_player_value.Text = session.damage_done.ToString();
            this.label_taken_damage_value.Text = session.damage_done.ToString();
            this.label_target_name.Text = session.target.Name;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}