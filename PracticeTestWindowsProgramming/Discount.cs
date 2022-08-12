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

namespace PracticeTestForFinal
{
    public partial class Discount : Form
    {
        public Discount()
        {
            InitializeComponent();
        }

        public void display(Form1 obj)
        {

            textBoxStdNm.Text = obj.textBoxStdNm.Text;
            textBoxStdNam.Text = obj.textBoxStdNam.Text;
        }

        public bool ifBlank()
        {
            //validate textboxes which have blank spaces

            if (textBoxStdNm.Text.Equals("") || textBoxStdNam.Text.Equals("") || textBoxNumDstPrcnt.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var path = @"Discount.txt";
            if (ifBlank() == false)
            {
                MessageBox.Show("You must enter data!!");
                return;
            }

            if (Form1.discountDict.ContainsKey(textBoxStdNm.Text))
            {
                MessageBox.Show("There is already an existing discount. You can only add one discount for every student...");
                return;
            }
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                Form1.discountDict.Add(textBoxStdNm.Text, double.Parse(textBoxNumDstPrcnt.Text));
                listViewDiscount.Items.Clear();
                listViewDiscount.Items.Add(new ListViewItem(new String[] { textBoxStdNm.Text, textBoxStdNam.Text, textBoxNumDstPrcnt.Text }));
                var result = from x in Form1.discountDict
                             select x;
                //loop each data
                foreach(var res in result)
                {
                    string data = res.Key + " " + res.Value + "\n";
                    sw.Write(data);
                }
            }
            catch (System.FormatException e1)
            {
                Console.WriteLine(e1.Message);
                MessageBox.Show("You must enter correct type of data");
                textBoxNumDstPrcnt.Text = "";
                return;
            }
            finally
            {
                sw.Flush();
                sw.Close();
            }


             }

        private void buttonBck_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.ShowDialog();
            this.Close();
        }

        private void Discount_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            string[] discounts;
            string data;

            listViewDiscount.Items.Clear();
            var pathDiscount = @"Discount.txt";
            if (File.Exists("Discount.txt")){
                // transfer the file from the textfile to the program
                var sr = new StreamReader(pathDiscount);
                while(sr.Peek() >= 0)
                {
                    data = sr.ReadLine();
                    discounts = data.Split(' ');
                    if (discounts[0].Equals(textBoxStdNm.Text))
                    {
                        listViewDiscount.Items.Add(new ListViewItem(new String[] { textBoxStdNm.Text, textBoxStdNam.Text, discounts[1] }));
                    }
                }
                sr.Close();
            }
        }

        private void buttonEdt_Click(object sender, EventArgs e)
        {
            var path = @"Discount.txt";
            
            if (ifBlank() == false)
            {
                MessageBox.Show("You must enter data!!");
                return;
            }
           
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                double discountNew = double.Parse(textBoxNumDstPrcnt.Text);
                Form1.discountDict[textBoxStdNm.Text] = discountNew;

                listViewDiscount.Items.Clear();
                var result = from x in Form1.discountDict
                             select x;
                //loop each data
                foreach (var res in result)
                {
                    string data = res.Key + " " + res.Value + "\n";
                    sw.Write(data);
                }

                listViewDiscount.Items.Add(new ListViewItem(new String[] { textBoxStdNm.Text, textBoxStdNam.Text, textBoxNumDstPrcnt.Text }));

            }catch(Exception e1)
            {
                Console.WriteLine("buttonEdt_Click --> " + e1.Message);
                sw.Flush();
                sw.Close();
            }


            sw.Flush();
            sw.Close();

        }

        private void buttonDlt_Click(object sender, EventArgs e)
        {
            Form1.discountDict.Remove(textBoxStdNm.Text);
            var path = @"Discount.txt";

            FileStream fs = new FileStream(path, FileMode.Create);
            
            StreamWriter sw = new StreamWriter(fs);

            listViewDiscount.Items.Clear();

            var result = from x in Form1.discountDict
                         select x;

            //loop each data
            foreach(var res in result)
            {
                string data = res.Key + " " + res.Value + "\n";
                sw.Write(data);
            }
            listViewDiscount.Items.Clear();
            sw.Flush();
            sw.Close();
        }
    }
}
