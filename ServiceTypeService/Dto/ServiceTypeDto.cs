using System.Collections.Generic;
using System.ComponentModel;

namespace ServiceTypeService.Dto
{
    public class ServiceTypeDto : INotifyPropertyChanged
    {
        public ServiceTypeDto()
        {
            ChildrenList=new List<ServiceTypeDto>();
        }
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<ServiceTypeDto> ChildrenList { get; set; }

        private bool _IsChecked = false;
        public bool IsChecked
        {
            get => _IsChecked;
            set
            {
                _IsChecked = value;
                OnPropertyChanged(nameof(IsChecked));
            }
        }

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
