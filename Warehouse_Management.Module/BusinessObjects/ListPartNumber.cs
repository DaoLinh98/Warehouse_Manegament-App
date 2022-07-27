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
    [MetadataType(typeof(ListPartNumber))]
    [DefaultClassOptions, ImageName("BO_ListPartNumber")]
  public  class ListPartNumber : INotifyPropertyChanged
    {
        private int partNumberid;
        [Key]
        [RuleRequiredField("RuleRequiredField for ListPartNumber.PartNumberId", DefaultContexts.Save)]

        public int PartNumberId
        {
            get { return partNumberid; }
             set
            {

                partNumberid = value;
                    OnPropertyChanged();
                
            }
        }

        private string partNumber;
        [MaxLength(100)]
        [RuleRequiredField("RuleRequiredField for ListPartNumber.PartNumber", DefaultContexts.Save)]
        public string PartNumber
        {
            get { return partNumber; }
            set
            {
               
                    partNumber = value;
                    OnPropertyChanged();
                
            }
        }

        private string partName;
        [MaxLength(100)]
        [RuleRequiredField("RuleRequiredField for ListPartNumber.PartName", DefaultContexts.Save)]
        public string PartName
        {
            get { return partName; }
            set
            {
              
                    partName = value;
                    OnPropertyChanged();
                
            }
        }

        private int sectionStorageId;

        [ForeignKey("ListSection")]
        [RuleRequiredField("RuleRequiredField for ListPartNumber.ListSection", DefaultContexts.Save)]
        public int SectionStorageId
        {
            get
            {
                return sectionStorageId;
            }
            set
            {

                sectionStorageId = value;
                OnPropertyChanged();

            }
        }

        private ListSection listSection;
        public virtual ListSection ListSection
        {
            get
            {
                return listSection;
            }
            set
            {

                listSection = value;
                OnPropertyChanged();

            }
        }
        //
        private int binStorageId;

        [ForeignKey("ListBin")]
        [RuleRequiredField("RuleRequiredField for ListPartNumber.ListBin", DefaultContexts.Save)]
        public int BinStorageId
        {
            get
            {
                return binStorageId;
            }
            set
            {

                binStorageId = value;
                OnPropertyChanged();

            }
        }

        private ListBin listBin;
        public virtual ListBin ListBin
        {
            get
            {
                return listBin;
            }
            set
            {

                listBin = value;
                OnPropertyChanged();

            }
        }

        //

        private int rackStorageId;

        [ForeignKey("ListRack")]
        [RuleRequiredField("RuleRequiredField for ListPartNumber.ListRack", DefaultContexts.Save)]
        public int RackStorageId
        {
            get
            {
                return rackStorageId;
            }
            set
            {

                rackStorageId = value;
                OnPropertyChanged();

            }
        }

        private ListRack listRack;
        public virtual ListRack ListRack
        {
            get
            {
                return listRack;
            }
            set
            {

                listRack = value;
                OnPropertyChanged();

            }
        }

        //private int warehouseId;
        //[ForeignKey("ListWarehouse")]
        //[RuleRequiredField("RuleRequiredField for ListPartNumber.ListWarehouseId", DefaultContexts.Save)]

        //public int WarehouseId
        //{
        //    get
        //    {
        //        return warehouseId;
        //    }
        //    set
        //    {
        //        warehouseId = value;
        //        OnPropertyChanged();
        //    }
        //}

        //private ListWarehouse listWarehouse;
        //#region Virtual Properties  
        //public virtual ListWarehouse ListWarehouse
        //{
        //    get { return listWarehouse; }
        //    set
        //    {
        //        listWarehouse = value;
        //        OnPropertyChanged();
        //    }
        //}
        //#endregion

        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
