using EFCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeFirst
{
    public partial class Form1 : Form
    {
        int id = 0;
        Employee model = new Employee();
        EmployeeContext db = new EmployeeContext();

        public Form1()
        {
            InitializeComponent();
            bindGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void bindGridView()
        {
            dataGridView1.DataSource = db.Employees.ToList<Employee>();

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            model.Name = NameTextBox.Text;
            model.Gender = GenderTextBox.Text;
            model.Age = Convert.ToInt32(AgeTextBox.Text);
            model.Department = DepartmentTextBox.Text;
            db.Employees.Add(model);
            db.SaveChanges();
            bindGridView();
            ClearTextBox();
        }
        void ClearTextBox()
        {
            NameTextBox.Clear();
            GenderTextBox.Clear();
            AgeTextBox.Clear();
            DepartmentTextBox.Clear();
        }

        
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            model.Id = id;
            model.Name = NameTextBox.Text;
            model.Gender = GenderTextBox.Text;
            model.Age = Convert.ToInt32(AgeTextBox.Text);
            model.Department = DepartmentTextBox.Text;
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            bindGridView();
            ClearTextBox();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            model = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            NameTextBox.Text = model.Name;
            GenderTextBox.Text = model.Gender;
            AgeTextBox.Text = model.Age.ToString();
            DepartmentTextBox.Text = model.Department;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            model = db.Employees.Where(x => x.Id == id).FirstOrDefault();
            db.Entry(model).State = EntityState.Deleted;
            db.SaveChanges();
            bindGridView(); 
            ClearTextBox();
        }
    }
}
