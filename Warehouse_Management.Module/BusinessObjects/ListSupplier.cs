using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace Warehouse_Management.Module.BusinessObjects
{
    [DefaultClassOptions, ImageName("BO_ListSupplier")]
    public class ListSupplier : INotifyPropertyChanged
    {
        private int id;
        [Key]
        [RuleRequiredField("RuleRequiredField for ListSupplier.Id", DefaultContexts.Save)]
        public int Id
        {
            get { return id; }
            protected set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged();
                }
            }
        }
        //
        private string supplierName;
        [MaxLength(100)]
        [RuleRequiredField("RuleRequiredField for ListSupplier.SupplierName", DefaultContexts.Save)]
        public string SupplierName
        {
            get { return supplierName; }
            set
            {
                if (supplierName != value)
                {
                    supplierName = value;
                    OnPropertyChanged();
                }
            }
        }
        //
        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

     
    }
}
