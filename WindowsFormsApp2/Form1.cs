using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<CurrentTask> tasks;
        DirectoryInfo dir;
        string startupPath; //для каталогов
        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
            tasks = new List<CurrentTask>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(Application.StartupPath + "\\tasks");

            foreach (string f in files)
            {
                CurrentTask t = null;

                using (StreamReader sr = new StreamReader(f))
                {
                    t = JsonConvert.DeserializeObject<CurrentTask>(sr.ReadToEnd());
                    sr.Close();
                }

                tasks.Add(t);
            }
 
            customListBox1.Items.AddRange(tasks.ToArray());
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            using (Form2 newMess = new Form2())
            {
                newMess.ShowDialog();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (customListBox1.SelectedItem == null)
                return;

            CurrentTask ct = customListBox1.SelectedItem as CurrentTask;
            if (ct == null)
                return;


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            tasks.Remove(ct);
            File.Delete(Application.StartupPath + "\\tasks" + "\\" + ct.Name + ".txt");
            Directory.Delete(Application.StartupPath + "\\files" + "\\" + ct.Name, true);
            customListBox1.Items.Remove(customListBox1.SelectedItem);
        }


        private void customListBox1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (customListBox1.SelectedItem == null)
                return;

            CurrentTask ct = customListBox1.SelectedItem as CurrentTask;
            if (ct == null)
                return;
            textBox1.Text = ct.fromSt;
            textBox2.Text = ct.toSt;
            textBox3.Text = ct.comment;
            textBox4.Text = ct.pathFile;
            fileListBox1.Items.Clear();
            dir = new DirectoryInfo(Application.StartupPath + "\\files\\" + ct.Name);
            //для работы с каталогами
            startupPath = Application.StartupPath + "\\files\\" + ct.Name;
            if (dir.Exists)
            {
                FileInfo[] filesName = dir.GetFiles();
                foreach (FileInfo f in filesName)
                {
                    fileListBox1.Items.Add(f);
                }
                DirectoryInfo[] direcName = dir.GetDirectories();
                foreach (DirectoryInfo d in direcName)
                {
                    fileListBox1.Items.Add(d);
                }
            }
            else
            {
                dir.Create();
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //открыть прводник
            string filePath = "";
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                filePath = fd.FileName;
            }
            FileInfo fileInfo = new FileInfo(filePath);
            fileListBox1.Items.Add(fileInfo.Name);
            CurrentTask ct = customListBox1.SelectedItem as CurrentTask;

            File.Copy(filePath, Application.StartupPath + "\\files\\"+ct.Name + "\\" + fileInfo.Name , true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ///удалить
            

            FileInfo ct = fileListBox1.SelectedItem as FileInfo;
            if (ct == null)
                return;
            File.Delete(ct.FullName);
            fileListBox1.Items.Remove(fileListBox1.SelectedItem);
            DirectoryInfo dt = fileListBox1.SelectedItem as DirectoryInfo;
            if (dt == null)
                return;
            Directory.Delete(dt.FullName);
            fileListBox1.Items.Remove(fileListBox1.SelectedItem);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            //отправить с копированием
            //Если нет выделеннного файла отправляет весь каталог, иначе только файл
            if (fileListBox1.SelectedItem == null)
            {
                FileInfo[] filesName = dir.GetFiles();
                foreach (FileInfo f in filesName)
                {
                    try
                    {
                        f.MoveTo(@textBox4.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка доступа");
                        //D:\CPP
                    }
                }
                DirectoryInfo[] direcName = dir.GetDirectories();
                foreach (DirectoryInfo d in direcName)
                {

                    try
                    {        
                        d.MoveTo(@textBox4.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка доступа");
                    }
                }
            }
            else
            {
                FileInfo ct = fileListBox1.SelectedItem as FileInfo;
                if (ct == null)
                    return;
                try
                {
                    ct.MoveTo(@textBox4.Text);
                }
                catch
                {
                    MessageBox.Show("Ошибка доступа");
                }

            }

        }

        

        private void playButton_Click(object sender, EventArgs e)
        {
            if (customListBox1.SelectedItem == null)
                return;

            CurrentTask ct = customListBox1.SelectedItem as CurrentTask;
            if (ct == null)
                return;
            ct.status = 0;
            customListBox1.Invalidate();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (customListBox1.SelectedItem == null)
                return;

            CurrentTask ct = customListBox1.SelectedItem as CurrentTask;
            if (ct == null)
                return;
            ct.status = 1;
            customListBox1.Invalidate();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (customListBox1.SelectedItem == null)
                return;

            CurrentTask ct = customListBox1.SelectedItem as CurrentTask;
            if (ct == null)
                return;
            ct.status = 2;
            customListBox1.Invalidate();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (customListBox1.SelectedItem == null)
                return;

            CurrentTask ct = customListBox1.SelectedItem as CurrentTask;
            if (ct == null)
                return;
            ct.status = 3;
            customListBox1.Invalidate();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            while(startupPath[startupPath.Length-1]!= '\\')
            {
                startupPath = startupPath.Remove(startupPath.Length - 1,1);
            }
            fileListBox1.Items.Clear();
            DirectoryInfo newdir = new DirectoryInfo(startupPath);
            DirectoryInfo[] newdirs = newdir.GetDirectories();
            foreach (DirectoryInfo currDir in newdirs)
            {
                fileListBox1.Items.Add(currDir);
            }
            FileInfo[] newFiles = newdir.GetFiles();
            foreach (FileInfo currFile in newFiles)
            {
                fileListBox1.Items.Add(currFile);
            }
        }
        private void fileListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //для открытия каталогов и файлов
            
            //файл
            FileInfo ct = fileListBox1.SelectedItem as FileInfo;
            if (ct != null)
            {
                Process.Start(@ct.FullName);
            }
            //каталог
            DirectoryInfo dt = fileListBox1.SelectedItem as DirectoryInfo;
            if (dt != null)
            {


                startupPath += '\\' + fileListBox1.SelectedItem.ToString();
                fileListBox1.Items.Clear();
                DirectoryInfo newdir = new DirectoryInfo(startupPath);
                DirectoryInfo[] newdirs = newdir.GetDirectories();
                foreach (DirectoryInfo currDir in newdirs)
                {
                    fileListBox1.Items.Add(currDir);
                }
                FileInfo[] newFiles = newdir.GetFiles();
                foreach (FileInfo currFile in newFiles)
                {
                    fileListBox1.Items.Add(currFile);
                }
            }

        }



    }
}
