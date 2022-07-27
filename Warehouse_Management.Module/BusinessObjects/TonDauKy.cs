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

namespace Warehouse_Management.Module.BusinessObjects
{

    [MetadataType(typeof(TonDauKy))]
    [DefaultClassOptions, ImageName("BO_TonDauKy")]
    public class TonDauKy : INotifyPropertyChanged
    {
        private int id;
        [Key]
        [RuleRequiredField("RuleRequiredField for TonDauKy.Id", DefaultContexts.Save)]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                    OnPropertyChanged();
            }
        }
        //
        private DateTime year;
        public DateTime Year
        {
            get { return year; }
            set
            {
               
                    year = value;
                    OnPropertyChanged();
            }

        }

        private int warehouseId;
        [ForeignKey("ListWarehouse")]
        [RuleRequiredField("RuleRequiredField for TonDauKy.ListWarehouseId", DefaultContexts.Save)]

        public int WarehouseId
        {
            get
            {
                return warehouseId;
            }
            set
            {
                warehouseId = value;
                OnPropertyChanged();
            }
        }

        private ListWarehouse listWarehouse;
        #region Virtual Properties  
        public virtual ListWarehouse ListWarehouse
        {
            get { return listWarehouse; }
            set
            {
                listWarehouse = value;
                OnPropertyChanged();
            }
        }
        #endregion


        private int partNumberId;
        [ForeignKey("ListPartNumber")]
        [RuleRequiredField("RuleRequiredField for TonDauKy.ListPartNumber", DefaultContexts.Save)]

        public int PartNumberId
        {
            get
            {
                return partNumberId;
            }
            set
            {
                partNumberId = value;
                OnPropertyChanged();
            }
        }

        private ListPartNumber _listPartNumber;
        #region Virtual Properties  
        public virtual ListPartNumber ListPartNumber
        {
            get { return _listPartNumber; }
            set
            {
                _listPartNumber = value;
                OnPropertyChanged();
            }
        }
        #endregion
        //
        private int quantity;
        public int Quantuty
        {
            get { return quantity; }
            set
            {
                    quantity = value;
                    OnPropertyChanged();
                
            }
        }
        //
        private string lotNo;
        public string LotNo
        {
            get { return lotNo; }
            set
            {
              lotNo = value;
                   OnPropertyChanged();
                
            }
        }
//
        private int statusId;
        [ForeignKey("Status")]
        [RuleRequiredField("RuleRequiredField for TonDauKy.Status", DefaultContexts.Save)]
        public int StatusId
        {
            get
            {
                return statusId;
            }
            set
            {
                statusId = value;
                OnPropertyChanged();
            }
        }

        private Status status;
        #region Virtual Properties  
        public virtual Status Status
        {
            get { return status; }
            set
            {
                status = value;
                OnPropertyChanged();
            }
        }
        #endregion
       

        
        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
