using StudentScores.Data;
using System.Collections.Generic;
using System.Windows;
using StudentScores.Data;
using StudentScores.Entities;
using StudentScores.Models;

namespace StudentScores
{
    public partial class MainWindow : Window
    {
        private StudentStore _store;
        
        public MainWindow()
        {
            InitializeComponent();

            _store = new StudentStore();
        }

        private void showAllStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource = null;
            resultListBox.Items.Clear();

            resultListBox.ItemsSource = _store.AllStudents();
        }

        private void showStudentsThatPassedButton_Click(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource = null;
            resultListBox.Items.Clear();

            foreach (Student student in _store.PassedStudents)
            { 
                resultListBox.Items.Add(student);
            }
        }

        private void showStudentsOrderByNameButton_Click(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource = null;
            resultListBox.Items.Clear();

            List<Student> studentsOrderByName = _store.studentsOrderedByName();

            foreach (Student student in studentsOrderByName)
            {
                resultListBox.Items.Add(student);
            }
        }

        private void showAmountOfStudentsPerDepartmentButton_Click(object sender, RoutedEventArgs e)
        {
            resultListBox.ItemsSource = null;
            resultListBox.Items.Clear();

            List<DepartmentSummary> amountOfStudentsPerDepartment = _store.AmountOfStudentsPerDepartment();

            foreach (DepartmentSummary summary in amountOfStudentsPerDepartment)
            {
                resultListBox.Items.Add($"Department: {summary.Department} has {summary.NumberOfStudents} students & a max grade of {summary.MaxGrade}/20");
            }
        }

        private void showSummaryButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_store.Summary(), "Summary", MessageBoxButton.OK);
        }

        private void showAmountOfDepartmentsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Aantal departementen: {_store.AmountOfDepartments()}", "Amount of departments", MessageBoxButton.OK);
        }
    }
}
