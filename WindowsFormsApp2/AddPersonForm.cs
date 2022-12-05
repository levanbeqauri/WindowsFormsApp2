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
    public partial class AddPersonForm : Form
    {
        public Form1 mainForm { get; set; }
        public AddPersonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person(textBox1.Text, lastname.Text);
            p.PrivateNumber = privattext.Text ;
            p.IsMarried = checkBox1.Checked;
            p.BirthDate = dateTimePicker1.Value;
            p.Height = textbox2.Text.Length;
            p.age = p.CalculateAndDisplayAge();
            

            mainForm.people.Add(p);
            mainForm.refresh();

            this.Close();
        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
