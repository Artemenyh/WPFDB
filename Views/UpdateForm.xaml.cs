using System.Windows;
using WPFDB.BusinessLogic;
using WPFDB.Models;

namespace WPFDB.Views
{
    public partial class UpdateForm : Window
    {
        StudentService _studentService = new StudentService();
        Students _studentToUpdate;
        public UpdateForm()
        {
            InitializeComponent();
        }
        public void ShowData(Students student)
        {
            TextBoxName.Text = student.Name;
            TextBoxAge.Text = student.Age;
            TextBoxClass.Text = student.Class;
            _studentToUpdate = student;
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            _studentToUpdate.Name = TextBoxName.Text;
            _studentToUpdate.Age = TextBoxAge.Text;
            _studentToUpdate.Class = TextBoxClass.Text;
            _studentService.Update(_studentToUpdate);
            Close();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}