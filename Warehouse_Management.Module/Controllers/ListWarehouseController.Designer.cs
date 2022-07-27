
namespace Warehouse_Management.Module.Controllers
{
    partial class ListWarehouseController
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
            this.ImportListWarehouse = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ImportListWarehouse
            // 
            this.ImportListWarehouse.Caption = "Import List Warehouse";
            this.ImportListWarehouse.ConfirmationMessage = null;
            this.ImportListWarehouse.Id = "ImportListWarehouse";
            this.ImportListWarehouse.ToolTip = null;
            this.ImportListWarehouse.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ImportListWarehouse_Execute);
            // 
            // ListWarehouseController
            // 
            this.Actions.Add(this.ImportListWarehouse);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ImportListWarehouse;
    }
}
