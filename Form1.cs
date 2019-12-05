using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     class Calendar
        {
            bool busy = false;
            public
            Calendar()
            {
                busy = false;
            }
           

        public void setbusy()
            {
                busy = true;
            }
        public bool pap()
            {
                return busy;
            }
        public void setfree()
            {
                busy = false;
            }
        public string chedule()
            {
                string str="";
                if(busy == false)
                { str = "Вільно"; }else { str = "Зайнято"; }

                return str;
            }
        }
       
        Calendar Mondayone = new Calendar();
        Calendar Tuesdayone = new Calendar();
        Calendar Wednesdayone = new Calendar();
        Calendar Thursdayone = new Calendar();
        Calendar Fridayone = new Calendar();
        Calendar Mondaytwo = new Calendar();
        Calendar Tuesdaytwo = new Calendar();
        Calendar Wednesdaytwo = new Calendar();
        Calendar Thursdaytwo = new Calendar();
        Calendar Fridaytwo = new Calendar();
        Calendar Mondaythree = new Calendar();
        Calendar Tuesdaythree = new Calendar();
        Calendar Wednesdaythree = new Calendar();
        Calendar Thursdaythree = new Calendar();
        Calendar Fridaythree = new Calendar();
        Calendar Mondayfour = new Calendar();
        Calendar Tuesdayfour = new Calendar();
        Calendar Wednesdayfour = new Calendar();
        Calendar Thursdayfour = new Calendar();
        Calendar Fridayfour = new Calendar();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox3.Items.Add("1");
            comboBox3.Items.Add("2");
            comboBox3.Items.Add("3");
            comboBox3.Items.Add("4");
            comboBox4.Items.Add("Понедельник");
            comboBox4.Items.Add("Вторник");
            comboBox4.Items.Add("Среда");
            comboBox4.Items.Add("Четверг");
            comboBox4.Items.Add("Пятница");
            try
            {
                comboBox2.Items.Add("Понедельник");
                StreamReader sr = new StreamReader(@"d:\chars.txt");
                string line = sr.ReadLine();

                while (line != null)
                {
                    comboBox1.Items.Add(line);
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет базы аудиторий!!!\n" + ex.Message);
            }
            // if(dateTimePicker1.Value==)
        }



        private void button2_Click(object sender, EventArgs e)
        {

            const string monday = "Понедельник";
            const string tuesday = "Вторник";
            const string wednesday = "Среда";
            const string thursday = "Четверг";
            const string friday = "Пятница";
            switch (comboBox2.Text)
            {
                case monday:
                    switch (comboBox1.Text)
                    {
                        case "1":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\1.txt", RichTextBoxStreamType.PlainText);
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Mondayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Mondaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Mondaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Mondayfour.chedule());
                            richTextBox1.AppendText("\n");
                            
                            break;
                        case "2":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\2.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Mondayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Mondaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Mondaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Mondayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "3":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\3.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Mondayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Mondaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Mondaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Mondayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "4":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\4.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Mondayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Mondaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Mondaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Mondayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                    }
                    break;
                case tuesday:
                    switch (comboBox1.Text)
                    {
                        case "1":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\1.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Tuesdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Tuesdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Tuesdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Tuesdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "2":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\2.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Tuesdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Tuesdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Tuesdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Tuesdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "3":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\3.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Tuesdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Tuesdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Tuesdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Tuesdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "4":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\4.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Tuesdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Tuesdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Tuesdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Tuesdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                    }
                    break;
                case wednesday:
                    switch (comboBox1.Text)
                    {
                        case "1":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\1.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Wednesdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Wednesdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Wednesdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Wednesdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "2":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\2.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Wednesdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Wednesdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Wednesdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Wednesdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "3":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\3.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Wednesdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Wednesdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Wednesdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Wednesdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "4":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\4.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Wednesdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Wednesdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Wednesdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Wednesdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                    }
                    break;
                case thursday:
                    switch (comboBox1.Text)
                    {
                        case "1":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\1.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Thursdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Thursdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Thursdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Thursdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "2":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\2.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Thursdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Thursdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Thursdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Thursdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "3":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\3.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Thursdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Thursdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Thursdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Thursdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "4":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\41.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Thursdayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Thursdaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Thursdaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Thursdayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                    }
                    break;
                case friday:
                    switch (comboBox1.Text)
                    {
                        case "1":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\1.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Fridayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Fridaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Fridaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Fridayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "2":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\2.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Fridayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Fridaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Fridaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Fridayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "3":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\3.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Fridayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Fridaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Fridaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Fridayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                        case "4":
                            richTextBox2.Clear();
                            richTextBox2.LoadFile(@"d:\4.txt");
                            richTextBox1.Clear();
                            richTextBox1.AppendText("1 пара - ");
                            richTextBox1.AppendText(Fridayone.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("2 пара - ");
                            richTextBox1.AppendText(Fridaytwo.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("3 пара - ");
                            richTextBox1.AppendText(Fridaythree.chedule());
                            richTextBox1.AppendText("\n");
                            richTextBox1.AppendText("4 пара - ");
                            richTextBox1.AppendText(Fridayfour.chedule());
                            richTextBox1.AppendText("\n");
                            break;
                    }
                    break;
            }


        } 

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = File.AppendText(@"d:\chars.txt"))
            {
               // w.WriteLine(textBox3.Text);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          const  string monday = "Понедельник";
          const string tuesday = "Вторник";
          const string wednesday = "Среда";
          const string thursday = "Четверг";
          const string friday = "Пятница";
            switch (comboBox4.Text)
            {
                case monday:
                    switch (comboBox3.Text)
                    {
                        case "1":
                            Mondayone.setbusy();
                      
                            break;
                        case "2":
                            Mondaytwo.setbusy();
                          
                            break;
                        case "3":
                            Mondaythree.setbusy();
                            
                            break;
                        case "4":
                            Mondayfour.setbusy();
                            //four.setbusy();
                            break;
                    }
                    break;
                case tuesday:
                    switch (comboBox3.Text)
                    {
                        case "1":
                            Tuesdayone.setbusy();
                           // one.setbusy();
                            break;
                        case "2":
                            Tuesdaytwo.setbusy();
                          //  two.setbusy();
                            break;
                        case "3":
                            Tuesdaythree.setbusy();
                           // three.setbusy();
                            break;
                        case "4":
                            Tuesdayfour.setbusy();
                            //four.setbusy();
                            break;
                    }
                    break;
                case wednesday:
                    switch (comboBox3.Text)
                    {
                        case "1":
                            Wednesdayone.setbusy();
                           // one.setbusy();
                            break;
                        case "2":
                            Wednesdaytwo.setbusy();
                           // two.setbusy();
                            break;
                        case "3":
                            Wednesdaythree.setbusy();
                           // three.setbusy();
                            break;
                        case "4":
                            Wednesdayfour.setbusy();
                           // four.setbusy();
                            break;
                    }
                    break;
                case thursday:
                    switch (comboBox3.Text)
                    {
                        case "1":
                            Thursdayone.setbusy();
                           // one.setbusy();
                            break;
                        case "2":
                            Thursdaytwo.setbusy();
                           // two.setbusy();
                            break;
                        case "3":
                            Thursdaythree.setbusy();
                          //  three.setbusy();
                            break;
                        case "4":
                            Thursdayfour.setbusy();
                            //four.setbusy();
                            break;
                    }
                    break;
                case friday:
                    switch (comboBox3.Text)
                    {
                        case "1":
                            Fridayone.setbusy();
                          //  one.setbusy();
                            break;
                        case "2":
                            Fridaytwo.setbusy();
                            //two.setbusy();
                            break;
                        case "3":
                            Fridaythree.setbusy();
                         //   three.setbusy();
                            break;
                        case "4":
                            Fridayfour.setbusy();
                            //four.setbusy();
                            break;
                    }
                    break;
            }


            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            const string monday = "Понедельник";
            const string tuesday = "Вторник";
            const string wednesday = "Среда";
            const string thursday = "Четверг";
            const string friday = "Пятница";
            switch (comboBox4.Text)
            {
                case monday:
                    switch (comboBox3.Text)
                    {
                        case "1":
                            Mondayone.setfree();
                            //one.setfree();
                            break;
                        case "2":
                            Mondaytwo.setfree();
                           // two.setfree();
                            break;
                        case "3":
                            Mondaythree.setfree();
                            //three.setfree();
                            break;
                        case "4":
                            Mondayfour.setfree();
                          //  four.setfree();
                            break;
                    }
                    break;
                case tuesday:
                    switch (comboBox3.Text)
                    {
                        case "1":
                            Tuesdayone.setfree();
                          //  one.setfree();
                            break;
                        case "2":
                            Tuesdaytwo.setfree();
                           // two.setfree();
                            break;
                        case "3":
                            Tuesdaythree.setfree();
                           // three.setfree();
                            break;
                        case "4":
                            Tuesdayfour.setfree();
                           // four.setfree();
                            break;
                    }
                    break;
                case wednesday:
                    switch (comboBox3.Text)
                    {
                        case "1":
                            Wednesdayone.setfree();
                           // one.setfree();
                            break;
                        case "2":
                            Wednesdaytwo.setfree();
                         //   two.setfree();
                            break;
                        case "3":
                            Wednesdaythree.setfree();
                            //three.setfree();
                            break;
                        case "4":
                            Wednesdayfour.setfree();
                          //  four.setfree();
                            break;
                    }
                    break;
                case thursday:
                    switch (comboBox3.Text)
                    {
                        case "1":
                            Thursdayone.setfree();
                         //   one.setfree();
                            break;
                        case "2":
                            Thursdaytwo.setfree();
                         //   two.setfree();
                            break;
                        case "3":
                            Thursdaythree.setfree();
                           // three.setfree();
                            break;
                        case "4":
                            Thursdayfour.setfree();
                            //four.setfree();
                            break;
                    }
                    break;
                case friday:
                    switch (comboBox3.Text)
                    {
                        case "1":
                            Fridayone.setfree();
                          //  one.setfree();
                            break;
                        case "2":
                            Fridaytwo.setfree();
                           // two.setfree();
                            break;
                        case "3":
                            Fridaythree.setfree();
                            //three.setfree();
                            break;
                        case "4":
                            Fridayfour.setfree();
                         //   four.setfree();
                            break;
                    }
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
