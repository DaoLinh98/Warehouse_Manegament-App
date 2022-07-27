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
    [MetadataType(typeof(DeliveryMaster))]
    [DefaultClassOptions, ImageName("BO_DeliveryMaster")]
    public class DeliveryMaster : INotifyPropertyChanged, IXafEntityObject
    {

        public DeliveryMaster()
        {

        }

        public void OnCreated()
        {
           // Id = "";
            TransactionId = "";
            DeliveryId = "";
        }

        public void OnSaving()
        {

        }
        public void OnLoaded()
        {

        }

        private int deliveryMasterId;
        [Key]
        [Column(Order = 1)]
        public int DeliveryMasterID
        {
            get
            {
                return deliveryMasterId;
            }

            set
            {
                deliveryMasterId = value;
                OnPropertyChanged();
            }
        }
        //
        private string transactionId;
        [MaxLength(100)]
        [RuleRequiredField("RuleRequiredField for DeliveryMaster.TransactionId", DefaultContexts.Save)]
        [Key]
        [Column(Order = 2)]
        public string TransactionId
        {
            get
            {
                return transactionId;
            }

            set
            {

                transactionId = value;
                OnPropertyChanged();

            }
        }
        //
        private string deliveryId;
        [MaxLength(20)]
        [RuleRequiredField("RuleRequiredField for DeliveryMaster.DeliveryId", DefaultContexts.Save)]
        [Key]
        [Column(Order = 3)]
        public string DeliveryId
        {
            get
            {
                return deliveryId;
            }

            set
            {

                deliveryId = value;
                OnPropertyChanged();

            }
        }
        //
        private DateTime year;
        public DateTime Year
        {
            get
            {
                return year;
            }

            set
            {

                year = value;
                OnPropertyChanged();

            }
        }
        //
        private int warehouseId;
        [ForeignKey("ListWarehouse")]
        [RuleRequiredField("RuleRequiredField for DeliveryMaster.ListWarehouseId", DefaultContexts.Save)]
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
        //
        private ListWarehouse listWarehouse;
        public virtual ListWarehouse ListWarehouse
        {
            get
            {
                return listWarehouse;
            }
            set
            {

                listWarehouse = value;
                OnPropertyChanged();

            }
        }
        //

        private string typeIO;
        public string TypeIO
        {
            get
            {
                return typeIO;
            }

            set
            {

                typeIO = value;
                OnPropertyChanged();

            }
        }
        //
        private int partNameId;
        [ForeignKey("ListPartNumber")]
        [RuleRequiredField("RuleRequiredField for ManageSo.DeliveryMaster", DefaultContexts.Save)]
        public int PartNameId
        {
            get
            {
                return partNameId;
            }
            set
            {

                partNameId = value;
                OnPropertyChanged();

            }
        }

        private ListPartNumber listPartNumber;
        public virtual ListPartNumber ListPartNumber
        {
            get
            {
                return listPartNumber;
            }
            set
            {

                listPartNumber = value;
                OnPropertyChanged();

            }
        }
        //
        private int quantity;
        public int Qty_SO
        {
            get { return quantity; }
            set
            {

                quantity = value;
                OnPropertyChanged();

            }
        }
        //
        private string deliveryBy;
        public string DeliveryBy
        {
            get { return deliveryBy; }
            set
            {

                deliveryBy = value;
                OnPropertyChanged();

            }

        }
        //
        private string receiveBy;
        public string ReceiveBy
        {
            get { return receiveBy; }
            set
            {

                receiveBy = value;
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
