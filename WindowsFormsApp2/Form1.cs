using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeData();
            dataGridView1.DataSource= people;
        }

        private void InitializeData()
        {
            Person p1 = new Person("luka", "grigalashvili");
            p1.PrivateNumber = "57001050825";
            p1.IsMarried = false;
            p1.BirthDate = new DateTime(2003, 7, 22);
            p1.Height = 1.8m;
            p1.age = p1.CalculateAndDisplayAge();



            Person p2 = new Person("rati", "yifiani");
            p2.PrivateNumber = "4564564565";
            p2.IsMarried = true;
            p2.BirthDate = new DateTime(2001, 7, 22);
            p2.Height = 1.8m;
            p2.age = p2.CalculateAndDisplayAge();

            Person p3 = new Person("levan", "beqauri");
            p3.PrivateNumber = "0102785748";
            p3.IsMarried = false;
            p3.BirthDate = new DateTime(2003, 1, 9);
            p3.Height = 1.74m;
            p3.age = p3.CalculateAndDisplayAge();

            //Person p4 = new Person(AddPersonForm(e);
            



            //Console.WriteLine("asaki aris: " + p1.CalculateAndDisplayAge());
            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            //people.Add(p4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPersonForm form = new AddPersonForm();
            form.mainForm = this;
            form.ShowDialog();
             
        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= people;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
