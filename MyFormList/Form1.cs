using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormList
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            employees = new List<Employee>(); 
        }

        List<Employee> employees;

        private void Button1_Click(object sender, EventArgs e)
        {

            Employee employee = new Employee
            {
                ID = idBox.Text,
                Name = nameBox.Text,
                Surname = surnameBox.Text,
                Email = emailBox.Text,
                Position = positionBox.Text,
                Salary = salaryBox.Text
            };

            employees.Add(employee);

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = employees;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

    }
}
