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
    [DefaultClassOptions, ImageName("BO_ListRack")]
    public class ListRack : INotifyPropertyChanged
    {
        private int Id;
        [Key]
        [RuleRequiredField("RuleRequiredField for ListRack.ID", DefaultContexts.Save)]
        public int ID
        {
            get { return Id; }
            set
            {
                
                    Id = value;
                    OnPropertyChanged();
                
            }
        }

        private string listRackName;
        [MaxLength(100)]
        [RuleRequiredField("RuleRequiredField for ListRack.ListRackName", DefaultContexts.Save)]
        public string ListRackName
        {
            get { return listRackName; }
            set
            {
               
                    listRackName = value;
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
