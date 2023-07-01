using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dtp_InitDate.Value = DateTime.Now;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            CurrentTask Elem = new CurrentTask();
            Elem.Name = tb_Name.Text;
            Elem.Description = textBox2.Text;
            Elem.DateInit = dtp_InitDate.Value;
            Elem.OcenTime = ocTimeNumericUpDown1.Value;
            Elem.Durration = durratNumericUpDown2.Value;
            Elem.fromSt = fromBox.Text;
            Elem.toSt = toBox.Text;
            Elem.comment = commentBox.Text;
            Elem.pathFile = pathBox.Text;
            Elem.status = 0;
            Program.f1.customListBox1.Items.Add(Elem);
            string json = JsonConvert.SerializeObject(Elem);
            string path = "tasks\\" + Elem.Name + ".txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
                sw.Close();
            }

            Close();
        }

        
    }
}
