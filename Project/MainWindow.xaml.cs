using ServiceTypeService.Dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ServiceTypeService.ServiceTypeService service = new ServiceTypeService.ServiceTypeService();
        private List<ServiceTypeDto> tree = service.GetServiceTypesTree();

        public MainWindow()
        {
            InitializeComponent();

            treeView.ItemsSource = tree;
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchNodeByName = service.GetAllNodes(tree).Where(x => x.Name.ToLower().Contains(tbSearch.Text.ToLower()));

            treeView.ItemsSource = searchNodeByName;
        }

        private CheckedElementList elementList = new CheckedElementList();

        private void cbName_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Content != null)
            {
                string text = (sender as CheckBox).Content.ToString();

                CheckedElement sit = new CheckedElement() { Name = text };

                elementList.Add(sit);
            }

            lvCheck.ItemsSource = elementList;       
        }

        private void cbName_Unchecked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).Content != null)
            {
                string text = (sender as CheckBox).Content.ToString();

                elementList.Delete(elementList.Where(x => x.Name == text).FirstOrDefault());
            }

            lvCheck.ItemsSource = elementList;
        }

        private void deleteItem(object sender, RoutedEventArgs e)
        {
            var task = lvCheck.SelectedItem as CheckedElement;

            elementList.Delete(task);           
        }
    }
}
