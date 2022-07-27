using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management.Module.BusinessObjects
{
    [DefaultClassOptions, ImageName("BO_ListBin")]
    public class ListBin : INotifyPropertyChanged
    {
        private int Id;
        [Key]
        [RuleRequiredField("RuleRequiredField for ListBin.ID", DefaultContexts.Save)]
        public int ID
        {
            get { return Id; }
            protected set
            {
              
                    Id = value;
                    OnPropertyChanged();
                
            }
        }

        private string listBinName;
        [MaxLength(100)]
        [RuleRequiredField("RuleRequiredField for ListBin.ListBinName", DefaultContexts.Save)]
        public string ListBinName
        {
            get { return listBinName; }
            set
            {
                  listBinName = value;
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
