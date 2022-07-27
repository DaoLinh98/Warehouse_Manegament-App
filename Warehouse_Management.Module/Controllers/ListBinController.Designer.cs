
namespace Warehouse_Management.Module.Controllers
{
    partial class ListBinController
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
            this.ImportListBin = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ImportListBin
            // 
            this.ImportListBin.Caption = "Import List Bin";
            this.ImportListBin.ConfirmationMessage = null;
            this.ImportListBin.Id = "ImportListBin";
            this.ImportListBin.ToolTip = null;
            this.ImportListBin.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ImportListBin_Execute);
            // 
            // ListBinController
            // 
            this.Actions.Add(this.ImportListBin);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ImportListBin;
    }
}
