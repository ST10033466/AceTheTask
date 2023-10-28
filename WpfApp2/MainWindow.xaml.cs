using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string connectionstring = "Data Source=lab000000\\SQLEXPRESS;Initial Catalog=AceTheTask;Integrated Security=True";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void InsertUserData()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring)) // Replace with your actual DbContext class
            {
                connection.Open();

                string insert Query
            }
        }

        public void InsertData(string connectionstring, string tableName, string[] ) { }
    }
}



//// Establish a connection to the database
//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    connection.Open();

//    string insertQuery = "INSERT INTO ModuleDetails (UserName, ModuleCode, ModuleName, NumberOfCredits, ClassHoursPerWeek, SelfStudyHoursPerWeek, RemainingHours, NumberOfWeeksSemester, HoursWorked, SemesterDate, EndDate, StudyDate) " +
//"VALUES (@UserName, @ModuleCode, @ModuleName, @NumberOfCredits, @ClassHoursPerWeek, @SelfStudyHours, @RemainingHours, @NumberOfWeeksSemester, @HoursWorked, @SemesterDate, @EndDate, @StudyDate)";

//    using (SqlCommand command = new SqlCommand(insertQuery, connection))
//    {
//        // Add parameters to the SQL query to avoid SQL injection
//        command.Parameters.AddWithValue("@ModuleCode", moduleCode);
//        command.Parameters.AddWithValue("@ModuleName", moduleName);
//        command.Parameters.AddWithValue("@NumberOfCredits", numberOfCredits);
//        command.Parameters.AddWithValue("@ClassHoursPerWeek", classHoursPerWeek);
//        command.Parameters.AddWithValue("@SelfStudyHours", selfStudyHours);
//        command.Parameters.AddWithValue("@RemainingHours", remainingStudyHours);
//        command.Parameters.AddWithValue("@NumberOfWeeksSemester", numberOfWeeksSemester);
//        command.Parameters.AddWithValue("@HoursWorked", numberOFHoursWorked);
//        command.Parameters.AddWithValue("@SemesterDate", dpStartDate.SelectedDate.Value.Date);
//        command.Parameters.AddWithValue("@EndDate", dpEndDate.SelectedDate.Value.Date);
//        command.Parameters.AddWithValue("@StudyDate", dpStudyDate.SelectedDate.Value.Date);
//        command.Parameters.AddWithValue("@UserName", myLoginObj.UserName);

//        // Execute the SQL command to insert module details
//        command.ExecuteNonQuery();
//    }
//}