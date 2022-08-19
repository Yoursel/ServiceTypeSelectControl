using ServiceTypeService.Dto;
using System.ComponentModel;
using System.Windows.Input;
using ServiceTypeService.Infrastructure.Commands;
using System.Linq;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ServiceType
{
    public class ModelView : INotifyPropertyChanged
    {
        private static ServiceTypeService.ServiceTypeService Service = new ServiceTypeService.ServiceTypeService();

        private ObservableCollection<ServiceTypeDto> _items = new ObservableCollection<ServiceTypeDto>(Service.GetServiceTypesTree());

        public ObservableCollection<ServiceTypeDto> items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged(nameof(items));
            }
        }

        private ObservableCollection<ServiceTypeDto> _isChekedItems = new ObservableCollection<ServiceTypeDto>();
        public ObservableCollection<ServiceTypeDto> isChekedItems
        {
            get { return _isChekedItems; }
            set
            {
                _isChekedItems = value;
            }
        } 

        #region SearchCommand

        private ActionCommand searchNodesCommand;
        public ICommand SearchNodesCommand
        {
            get
            {
                if (searchNodesCommand == null)
                {
                    searchNodesCommand = new ActionCommand(SearchNodes);
                }
                return searchNodesCommand;
            }
        }

        private void SearchNodes(object parameter)
        {    
            items = new ObservableCollection<ServiceTypeDto>(Service.GetServiceTypesTree());

            string text = parameter as string;
            if (text != "")
            {
                var nodes = Service.GetAllNodes(items).Where(x => x.Name.ToLower().Contains(text.ToLower())
                                                                || x.Code.ToString().Contains(text.ToLower())).ToList();
                items = new ObservableCollection<ServiceTypeDto>(nodes);
            }
        }

        #endregion

        #region CheckCommand

        private ActionCommand checkNodesCommand;
        public ICommand CheckNodesCommand
        {
            get
            {
                if (checkNodesCommand == null)
                {
                    checkNodesCommand = new ActionCommand(CheckNodes);
                }
                return checkNodesCommand;
            }
        }

        private void CheckNodes(object parameter)
        {
            var item = parameter as ServiceTypeDto;
            if (item != null)
            {
                if (item.IsChecked == true)
                    isChekedItems.Add(item);
                else
                    isChekedItems.Remove(item);
            }    
        }

        #endregion

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
