using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
namespace Warehouse_Management.Module.BusinessObjects
{


    [DefaultClassOptions, ImageName("BO_Status")]
    public class Status : INotifyPropertyChanged
    {
        private int id;
        [Key]
        [RuleRequiredField("RuleRequiredField for Status.Id", DefaultContexts.Save)]
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
        private string statusName;
        [MaxLength(100)]
        [RuleRequiredField("RuleRequiredField for Status.StatusName", DefaultContexts.Save)]
        public string StatusName
        {
            get { return statusName; }
            set
            {
                if (statusName != value)
                {
                    statusName = value;
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