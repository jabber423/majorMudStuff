﻿namespace MMudTerm.Terminal
{
    partial class TerminalWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(this.heartbeat != null) {
                this.heartbeat.Elapsed -= ticker;
                this.heartbeat.Enabled = false;
                this.heartbeat.Stop(); }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TerminalWindow
            // 
            this.Name = "TerminalWindow";
            this.Size = new System.Drawing.Size(714, 574);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TerminalWindow_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
