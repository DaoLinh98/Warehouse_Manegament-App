using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Warehouse_Management.Module.DatabaseUpdate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DevExpress.ExpressApp;

namespace Warehouse_Management.Module.BusinessObjects
{
    [MetadataType(typeof(Employee))]
    [DefaultClassOptions, ImageName("BO_Employee")]
    public class Employee : INotifyPropertyChanged , IXafEntityObject
    {
        public Employee()
        {

        }

        public void OnCreated()
        {
            EmployeeId = "";
            Department = "";
        }

        public void OnSaving()
        {

        }
        public void OnLoaded()
        {

        }
        //
        private string employeeId;
         [Key]
        [Column(Order = 1)]
        [MaxLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [RuleRequiredField("RuleRequiredField for Employee.EmployeeId", DefaultContexts.Save)]

        public string EmployeeId
        {
            get { return employeeId; }
            set
            {
                
                    employeeId = value;
                    OnPropertyChanged();
                
            }
        }
        //
        private string deparment;
        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [RuleRequiredField("RuleRequiredField for Employee.Department", DefaultContexts.Save)]
        public string Department
        {
            get { return deparment; }
            set
            {
                if (deparment != value)
                {
                    deparment = value;
                    OnPropertyChanged();
                }
            }
        }
        //
        private string name;
        [MaxLength(100)]
        [RuleRequiredField("RuleRequiredField for Employee.Name", DefaultContexts.Save)]
        public string Name
        {
            get { return name; }
            set
            {
                    name = value;
                    OnPropertyChanged();
                
            }
        }
        //
        private bool active = true;
        public bool Active
        {
            get { return active; }
            set
            {
               
                    active = value;
                    OnPropertyChanged();
                
            }
        }
        //
        private string permission;
        public string Permission
        {
            get { return permission; }
            set
            {
                 permission = value;
                    OnPropertyChanged();
                
            }
        }

        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
