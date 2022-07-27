
namespace Warehouse_Management.Module.Controllers
{
    partial class ListSectionController
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
            this.ImportListSection = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ImportListSection
            // 
            this.ImportListSection.Caption = "Import List Section";
            this.ImportListSection.ConfirmationMessage = null;
            this.ImportListSection.Id = "ImportListSection";
            this.ImportListSection.ToolTip = null;
            this.ImportListSection.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ImportListSection_Execute);
            // 
            // ListSectionController
            // 
            this.Actions.Add(this.ImportListSection);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ImportListSection;
    }
}
