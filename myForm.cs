using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace xmlDb
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }
        List<student> p1 = new List<student>();
        XmlSerializer serial = new XmlSerializer(typeof(List<student>));

        private void button1_Click(object sender, EventArgs e)
        {
            
            p1.Add(new student() { Id = "ATR/0078/09", Name = "kalab/Amare" });
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\kalab.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, p1);
                MessageBox.Show("Created");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<student> p1 = new List<student>();
            XmlSerializer serial = new XmlSerializer(typeof(List<student>));
            
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\kalab.xml", FileMode.Open, FileAccess.Read))
            {
                p1 = serial.Deserialize(fs) ass List<student>;
                dataGridView1.DataSource = p1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            p1.Add(new student() { Id = textBox2.Text, Name = textBox1.Text });
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\kalab.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, p1);
                MessageBox.Show("user added");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
