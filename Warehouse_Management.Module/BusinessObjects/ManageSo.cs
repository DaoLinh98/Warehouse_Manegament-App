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
    [MetadataType(typeof(ManageSo))]
    [DefaultClassOptions, ImageName("BO_ManageSo")]
    public class ManageSo : INotifyPropertyChanged, IXafEntityObject
    {
        public ManageSo()
        {

        }

        public void OnCreated()
        {
            SONo = "";
            SOName = "";
            LineNo = "";
        }

        public void OnSaving()
        {

        }
        public void OnLoaded()
        {

        }


        private string soNo;
        [Key]
        [Column(Order = 1)]
        [MaxLength(20)]
        [RuleRequiredField("RuleRequiredField for ManageSo.SONo", DefaultContexts.Save)]
        public string SONo
        {
            get
            {
                return soNo;
            }

            set
            {

                soNo = value;
                OnPropertyChanged();

            }
        }
        //
        private string soName;
        [Key]
        [Column(Order = 2)]
        [MaxLength(20)]
        [RuleRequiredField("RuleRequiredField for ManageSo.SOName", DefaultContexts.Save)]
        public string SOName
        {
            get { return soName; }
            set
            {

                soName = value;
                OnPropertyChanged();

            }
        }
        //
        private string lineNo;
        [Key]
        [Column(Order = 3)]
        [MaxLength(20)]
        [RuleRequiredField("RuleRequiredField for ManageSo.LineNo", DefaultContexts.Save)]
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
        [RuleRequiredField("RuleRequiredField for ManageSo.ListPartNumber", DefaultContexts.Save)]
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
        private string componentName;
        public string ComponentName
        {
            get { return componentName; }
            set
            {
                
                    componentName = value;
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
        //status
        private int statusId;
        [ForeignKey("Status")]
        [RuleRequiredField("RuleRequiredField for ManageSo.Status", DefaultContexts.Save)]
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
