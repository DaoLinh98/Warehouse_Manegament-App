using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using NewMasterDatabase.DEV_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Warehouse_Management.Module.BusinessObjects;
namespace Warehouse_Management.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class EmployeeController : ViewController
    {
        public EmployeeController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            this.TargetObjectType = typeof(Employee);
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void ImportEmployee_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            ConnectionInfo connect_String = new ConnectionInfo();
            connect_String.ConnectionString = AppConfig.connectStr;
            connect_String.QueryString = @"SELECT * FROM [Employees]";
            //
            List<ExcelImportObject> excelImportObjects = new List<ExcelImportObject>();
            excelImportObjects.Add(new ExcelImportObject("EmployeeId", "EmployeeId", ExcelColType.COL_STRING, 100, true, true));
            excelImportObjects.Add(new ExcelImportObject("Department", "Department", ExcelColType.COL_STRING, 100, false, false));
            excelImportObjects.Add(new ExcelImportObject("Name", "Name", ExcelColType.COL_STRING, 100, false, false));
            excelImportObjects.Add(new ExcelImportObject("Active", "Active", ExcelColType.COL_BOOL, 20, false, false));
            excelImportObjects.Add(new ExcelImportObject("Permission", "Permission", ExcelColType.COL_STRING, 100, false, false));

            BaseImportControl_DEV baseImportControl = new BaseImportControl_DEV(excelImportObjects, connect_String);
            baseImportControl.ImportExcelAction();

        }
    }
}
