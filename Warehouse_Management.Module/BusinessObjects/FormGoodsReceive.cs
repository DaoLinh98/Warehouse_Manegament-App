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
    [MetadataType(typeof(FormGoodsReceive))]
    [DefaultClassOptions, ImageName("BO_FormGoodsReceive")]
    public class FormGoodsReceive : INotifyPropertyChanged,IXafEntityObject
    {
        public FormGoodsReceive()
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
        //
        private string poNo;
        [Key]
        [Column(Order = 1)]
        [MaxLength(20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [RuleRequiredField("RuleRequiredField for FormGoodsReceive.PONo", DefaultContexts.Save)]
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
        [RuleRequiredField("RuleRequiredField for FormGoodsReceive.LineNo", DefaultContexts.Save)]
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
        [Key]
        [Column(Order = 3)]
        [RuleRequiredField("RuleRequiredField for FormGoodsReceive.PartNameId", DefaultContexts.Save)]
        [ForeignKey("ListPartNumber")]
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
        //
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
        private int documentFormId;
        public int DocumentFormId
        {
            get
            {
                return documentFormId;
            }

            set
            {
                documentFormId = value;
                OnPropertyChanged();
            }
        }
        //
        private int qty;
        public int Quantity
        {
            get { return qty; }

            set { qty = value;
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
        private int totalDelivery;
        public int TotalDelivery
        {
            get { return totalDelivery; }
            set
            {

                totalDelivery = value;
                OnPropertyChanged();

            }
        }
        //
        private int statusId;
        [ForeignKey("Status")]
        [RuleRequiredField("RuleRequiredField for FormGoodsReceives.Status", DefaultContexts.Save)]
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
        //
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

        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #endregion
    }
}
