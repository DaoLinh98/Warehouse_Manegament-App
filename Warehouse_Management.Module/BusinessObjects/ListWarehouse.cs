using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace Warehouse_Management.Module.BusinessObjects
{
    [MetadataType(typeof(ListWarehouse))]

    [DefaultClassOptions, ImageName("BO_ListWarehouse")]
    public class ListWarehouse : INotifyPropertyChanged
    {
        private int listWarehouseId;
        [Key]
        public int ListWarehouseId
        {
            get { return listWarehouseId; }
             set
            {

                if (listWarehouseId != value)
                {
                    listWarehouseId = value;
                    OnPropertyChanged();
                }

            }
        }
        //
        private string warehouseName;
        [MaxLength(100)]
        [RuleRequiredField("RuleRequiredField for ListWarehouse.ListWarehouseName", DefaultContexts.Save)]
        public string ListWarehouseName
        {
            get { return warehouseName; }
            set
            {

                if (warehouseName != value)
                {
                    warehouseName = value;
                    OnPropertyChanged();
                }

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
