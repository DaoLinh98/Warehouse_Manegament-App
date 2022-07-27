
namespace Warehouse_Management.Module.Controllers
{
    partial class ListPartNumberController
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
            this.ImportListPartNumber = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ImportListPartNumber
            // 
            this.ImportListPartNumber.Caption = "Import List Part Number";
            this.ImportListPartNumber.ConfirmationMessage = null;
            this.ImportListPartNumber.Id = "ImportListPartNumber";
            this.ImportListPartNumber.ToolTip = null;
            this.ImportListPartNumber.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ImportListPartNumber_Execute);
            // 
            // ListPartNumberController
            // 
            this.Actions.Add(this.ImportListPartNumber);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ImportListPartNumber;
    }
}
