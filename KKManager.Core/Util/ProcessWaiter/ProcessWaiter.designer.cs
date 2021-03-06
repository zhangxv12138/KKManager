﻿using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using KKManager.Functions;

namespace KKManager.Util.ProcessWaiter
{
    partial class ProcessWaiter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            processWaiterControl1 = new ProcessWaiterControl();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ProcessWaiter));
            this.SuspendLayout();
            // 
            // processWaiterControl1
            // 
            resources.ApplyResources(this.processWaiterControl1, "processWaiterControl1");
            this.processWaiterControl1.Name = "processWaiterControl1";
            this.processWaiterControl1.ShowIgnoreAndCancel = true;
            // 
            // ProcessWaiter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.processWaiterControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessWaiter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.Shown += new EventHandler(this.ProcessWaiter_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private ProcessWaiterControl processWaiterControl1;

        public static Task<bool?> CheckForProcessesBlockingKoiDir()
        {
            return ProcessWaiter.CheckForRunningProcesses(new[] { InstallDirectoryHelper.KoikatuDirectory.FullName }, new[] { @"^Koikatsu HF Patch v[\d\.]+$", "^KKManager$", "^StandaloneUpdater$" });
        }
    }
}