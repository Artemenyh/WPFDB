using System.Windows;
using WPFDB.BusinessLogic;
using WPFDB.Models;

namespace WPFDB.Views
{
    public partial class AddForm : Window
    {
        StudentService _studentService = new StudentService();
        public AddForm()
        {
            InitializeComponent();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            _studentService.Add(new Students { Name = TextBoxName.Text, Age = TextBoxAge.Text, Class = TextBoxClass.Text });
            TextBoxName.Clear();
            TextBoxAge.Clear();
            TextBoxClass.Clear();
        }
    }
}