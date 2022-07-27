
namespace Warehouse_Management.Module.Controllers
{
    partial class EmployeeController
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
            this.ImportEmployee = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ImportEmployee
            // 
            this.ImportEmployee.Caption = "Import Employee";
            this.ImportEmployee.ConfirmationMessage = null;
            this.ImportEmployee.Id = "ImportEmployee";
            this.ImportEmployee.ToolTip = null;
            this.ImportEmployee.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ImportEmployee_Execute);
            // 
            // EmployeeController
            // 
            this.Actions.Add(this.ImportEmployee);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ImportEmployee;
    }
}
