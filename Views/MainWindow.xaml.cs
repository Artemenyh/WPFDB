using System.Windows;
using System.Windows.Controls;
using WPFDB.Models;
using WPFDB.BusinessLogic;
using WPFDB.Views;

namespace WPFDB
{
    public partial class MainWindow : Window
    {
        StudentService _studentService = new StudentService();
                
        public MainWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = _studentService.Get();
        }
        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            AddForm add = new AddForm();
            add.Show();
        }
        private void UpdateData_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = null;
            DataGrid.ItemsSource = _studentService.Get();
        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItems.Count > 0 && MessageBox.Show("Подтвержение удаления", "Удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                for (int i = 0; i < DataGrid.SelectedItems.Count; i++)
                {
                    Students? student = DataGrid.SelectedItems[i] as Students;
                    if (student != null)
                    {
                        _studentService.Delete(student);
                    }
                }
            }
        }
        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < DataGrid.SelectedItems.Count; i++)
                {
                    Students? student = DataGrid.SelectedItems[i] as Students;
                    if (student != null)
                    {
                        UpdateForm update = new UpdateForm();
                        update.ShowData(student);
                        update.Show();
                    }
                }
            }
        }
    }
}