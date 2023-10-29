using Calendar.Models;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayFilteredStudents();
            using (var context = new StudentContext())
            {
                var students = context.Students.ToList();
                dataGridView1.DataSource = students;
            }

            DateTime defaultDate = DateTime.Now;
            monthCalendar.SetDate(defaultDate);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdateIni.Text = monthCalendar.SelectionStart.ToShortDateString();

            DateTime selectedDate = monthCalendar.SelectionStart;

            int desiredHour, desiredMinute;
            if (int.TryParse(txtHour.Text, out desiredHour) && int.TryParse(txtMinute.Text, out desiredMinute))
            {
                TimeSpan selectedTime = new TimeSpan(desiredHour, desiredMinute, 0);
                DateTime selectedDateTime = selectedDate.Date + selectedTime;
                int addMonths = (int)numMonthsEndContract.Value;
                DateTime finalContract = selectedDate.AddMonths(addMonths).Date;

                Students newStudent = new Students
                {
                    Name = txtStudent.Text,
                    ContractInicialDate = DateTime.Now,
                    ContractEndDate = finalContract,
                    Status = true,
                    WeekDays = ddweekday.SelectedItem.ToString()
                };
                using (var context = new StudentContext())
                {
                    context.Students.Add(newStudent);
                    context.SaveChanges();
                }
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Invalid input for hour. Please enter a valid hour.");
            }
        }
        private void RefreshDataGridView()
        {
            using (var context = new StudentContext())
            {
                var students = context.Students.ToList();

                BindingList<Students> studentList = new BindingList<Students>(students);

                dataGridView1.DataSource = studentList;
                dataGridView1.AllowUserToAddRows = false;

            }
        }

        private void btnPegaData_Click(object sender, EventArgs e)
        {
           
        }



        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            //select the data according to:
            //weekday, status == true, contractdate > currentdate

            DateTime selectedDate = monthCalendar.SelectionStart;
            DateTime currentDate = DateTime.Now;
            using (var context = new StudentContext()) 
            {
                var getStudents = context.Students
                    .Where(std => std.Status == true && std.WeekDays == selectedDate.DayOfWeek.ToString() && std.ContractEndDate > currentDate).ToList();

                BindingList<Students> filteredStudentList = new BindingList<Students>(getStudents);
                dataGridView1.DataSource = filteredStudentList;
                dataGridView1.AllowUserToAddRows = false;
            };
        }

        public void DisplayFilteredStudents() 
        {
            DateTime currentDate = DateTime.Now;
            using (var context = new StudentContext())
            {
                var getStudents = context.Students
                    .Where(std =>  std.ContractEndDate < currentDate)
                    .ToList();

                foreach (var item in getStudents)
                {
                    if (item.ContractEndDate < currentDate) 
                    {
                        //update status
                        item.Status = false;
                        context.SaveChanges();
                    }
                }
                BindingList<Students> filteredStudentList = new BindingList<Students>(getStudents);
                dataGridView1.DataSource = filteredStudentList;
                dataGridView1.AllowUserToAddRows = false;
            }
        }

        public DateTime GetScheduleForCurrentMonth()
        {

            return DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetScheduleForCurrentMonth();
        }

        private void numMonthsEndContract_ValueChanged(object sender, EventArgs e)
        {
            int monthsToAdd = (int)numMonthsEndContract.Value;
            DateTime selectedDate = monthCalendar.SelectionStart;
            DateTime finalContractDate = selectedDate.AddMonths(monthsToAdd);
            
            txtdateFinal.Text = finalContractDate.ToShortDateString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}