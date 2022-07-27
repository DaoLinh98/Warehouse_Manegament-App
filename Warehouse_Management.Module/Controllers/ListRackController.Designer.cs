
namespace Warehouse_Management.Module.Controllers
{
    partial class ListRackController
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
            this.ImportListRack = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ImportListRack
            // 
            this.ImportListRack.Caption = "Import List Rack";
            this.ImportListRack.ConfirmationMessage = null;
            this.ImportListRack.Id = "ImportListRack";
            this.ImportListRack.ToolTip = null;
            this.ImportListRack.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction1_Execute);
            // 
            // ListRackController
            // 
            this.Actions.Add(this.ImportListRack);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ImportListRack;
    }
}
