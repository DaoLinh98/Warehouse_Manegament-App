﻿
namespace Warehouse_Management.Module.Controllers
{
    partial class StatusController
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
            this.components = new System.ComponentModel.Container();
            this.importStatus = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // importStatus
            // 
            this.importStatus.Caption = "import Status";
            this.importStatus.ConfirmationMessage = null;
            this.importStatus.Id = "importStatus";
            this.importStatus.ToolTip = null;
            this.importStatus.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.importStatus_Execute);
            // 
            // StatusController
            // 
            this.Actions.Add(this.importStatus);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction importStatus;
    }
}
