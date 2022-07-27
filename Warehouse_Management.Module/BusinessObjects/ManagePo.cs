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
    [MetadataType(typeof(ManagePo))]
    [DefaultClassOptions, ImageName("BO_ManagePo")]
    public class ManagePo : INotifyPropertyChanged, IXafEntityObject
    {
        public ManagePo()
        {

        }

        public void OnCreated()
        {
            PONo = "";
            LineNo = "";
        }

        public void OnSaving()
        {

        }
        public void OnLoaded()
        {

        }

        private string poNo;
        [Key]
        [Column(Order = 1)]
        [MaxLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [RuleRequiredField("RuleRequiredField for ManagePo.PONo", DefaultContexts.Save)]
        public string PONo
        {
            get
            {
                return poNo;
            }

            set
            {
                poNo = value;
                OnPropertyChanged();
            }
        }
        //
        private string lineNo;
        [Key]
        [Column(Order = 2)]
        [MaxLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [RuleRequiredField("RuleRequiredField for ManagePo.LineNo", DefaultContexts.Save)]
        public string LineNo
        {
            get
            {
                return lineNo;
            }

            set
            {

                lineNo = value;
                OnPropertyChanged();

            }
        }
        //
        private int partNameId;
        [ForeignKey("ListPartNumber")]
        [RuleRequiredField("RuleRequiredField for ManagePo.ListPartNumber", DefaultContexts.Save)]
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
        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                OnPropertyChanged();

            }
        }
        //
        private int supplierId;
        [ForeignKey("ListSupplier")]
        [RuleRequiredField("RuleRequiredField for ManagePo.ListSupplier", DefaultContexts.Save)]
        public int SupplierId
        {
            get { return supplierId; }
            set
            {
                supplierId = value;
                OnPropertyChanged();

            }
        }

        private ListSupplier listSupplier;
        public virtual ListSupplier ListSupplier
        {
            get
            {
                return listSupplier;
            }
            set
            {

                listSupplier = value;
                OnPropertyChanged();

            }
        }
        //
        private DateTime deliveryDate;
        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set
            {

                deliveryDate = value;
                OnPropertyChanged();

            }
        }
        //
        private int totalReceive;
        public int TotalReceive
        {
            get { return totalReceive; }
            set
            {

                totalReceive = value;
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
        //
        private int statusId;
        [ForeignKey("Status")]
        [RuleRequiredField("RuleRequiredField for ManagePo.Status", DefaultContexts.Save)]
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
