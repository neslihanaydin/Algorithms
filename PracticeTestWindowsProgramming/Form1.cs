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
    public partial class Form1 : Form
    {

        //list of student objects
        static List<Student> studentList = new List<Student>();

        // This is for filtering. This list holds the listview items
        List<ListViewItem> studentListFilter = new List<ListViewItem>();

        //variable that will hold the old value of the student number for editing
        string oldValue = "";

        //Dictionary will be used because each student has only one discount. We can follow this with dictionaries/
        public static Dictionary<string, double> discountDict = new Dictionary<string, double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStudent = listView1.SelectedIndices;
            for(int i = 0; i < selectedStudent.Count; i++)
            {
                textBoxStdNm.Text = listView1.Items[selectedStudent[i]].SubItems[0].Text;
                oldValue = listView1.Items[selectedStudent[i]].SubItems[0].Text;
                textBoxStdNam.Text = listView1.Items[selectedStudent[i]].SubItems[1].Text;
                textBoxNumCrs.Text = listView1.Items[selectedStudent[i]].SubItems[2].Text;
                comboBoxStdTyp.Text = listView1.Items[selectedStudent[i]].SubItems[3].Text;
            }

            if(ifBlank() == false)
            {
                return;
            }

            // Tuition Fee calculation

            double tuitionFee = 0;

            if(comboBoxStdTyp.SelectedIndex == 0) // Domestic
            {
                Domestic domStd = new Domestic(textBoxStdNm.Text, textBoxStdNam.Text, int.Parse(textBoxNumCrs.Text), comboBoxStdTyp.Text);
                tuitionFee = domStd.compute();
            }
            if(comboBoxStdTyp.SelectedIndex == 1) // International
            {
                International intStd = new International(textBoxStdNm.Text, textBoxStdNam.Text, int.Parse(textBoxNumCrs.Text), comboBoxStdTyp.Text);
                tuitionFee = intStd.compute();
            }

            //Discount calculation

            double discountPercent = 0;
            // Check there is any discount for this student
            if (discountDict.ContainsKey(textBoxStdNm.Text))
            {
                discountPercent = discountDict[textBoxStdNm.Text];
                textBoxDst.Text = discountPercent.ToString();

                discountPercent = discountPercent / 100;

                tuitionFee = tuitionFee - (tuitionFee * discountPercent);
                textBoxFee.Text = tuitionFee.ToString("F2");
            }else
            {
                textBoxDst.Text = "No discount";
                textBoxFee.Text = tuitionFee.ToString("F2");
            }

        }

        private void buttonDst_Click(object sender, EventArgs e)
        {
            this.Hide();

            Discount formDiscount = new Discount();
            formDiscount.display(this); //to receive student number and name
            formDiscount.ShowDialog();

            this.Close();

        }
        public void loadData()
        {
            string[] students;
            string[] discounts;
            string data;

            listView1.Items.Clear();
            studentList.Clear();
            discountDict.Clear();

            var pathStudent = @"Student.txt";
            var pathDiscount = @"Discount.txt";
            var pathStudentwError = @"StudentFileError.txt"; //If the previous Student.txt file is broken, this file will be using for backup that student file

            if (File.Exists("Student.txt"))
            {
                //transfer the file from the text file to the program
                var sr = new StreamReader(pathStudent);

                try
                {
                    while (sr.Peek() >= 0)
                    {
                        data = sr.ReadLine();
                        students = data.Split(' ');
                        var studentObj = new Student(students[0], students[1], int.Parse(students[2]), students[3]);
                        studentList.Add(studentObj);

                        //add the new data to the listview
                        listView1.Items.Add(new ListViewItem(new String[] { students[0].ToString(), students[1].ToString(), students[2].ToString(), students[3].ToString() }));

                    }
                    sr.Close();
                    
                }catch(Exception e)
                {
                    MessageBox.Show("Error when reading file. The list will be empty. The Backup file has created. Main file will be deleted.");
                    if(File.Exists(pathStudentwError)) File.Delete(pathStudentwError);
                    backupStudentFileWithError();
                    sr.Close();
                    File.Delete(pathStudent);
                }
                
            }

            if (File.Exists("Discount.txt"))
            {
                var sr = new StreamReader(pathDiscount);
                try
                {
                    while(sr.Peek() >= 0)
                    {
                        data = sr.ReadLine();
                        discounts = data.Split(' ');
                        discountDict.Add(discounts[0].ToString(), double.Parse(discounts[1].ToString()));
                    }
                    sr.Close();
                }catch(Exception e1)
                {
                    Console.WriteLine("Load Discount File --> " + e1.Message);
                    sr.Close();
                }
            }

        }

        public void backupStudentFileWithError()
        {
            var pathStudent = @"Student.txt";
            var pathStudentwError = @"StudentFileError.txt";

            try
            {
                File.Copy(pathStudent, pathStudentwError);
            }
            catch (IOException iox)
            {
                Console.WriteLine("backupStudentFileWithError --> " + iox.Message);
            }

        }
        public void saveData()
        {
            string data;
            var path = @"Student.txt";

            //open the file

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);

            for(int i = 0; i < studentList.Count; i++)
            {
                data = studentList[i].studNumber + " " +
                       studentList[i].studName + " " +
                       studentList[i].courses + " " +
                       studentList[i].studType + "\n";

                sw.Write(data);
            }

            sw.Flush();
            sw.Close();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //check textBoxes if it is empty

            if(ifBlank() == false)
            {
                MessageBox.Show("You must enter data!!");
                return;
            }
            
            for(int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].studNumber.Equals(textBoxStdNm.Text.ToString()))
                {
                    MessageBox.Show("Record already existing!");
                    doBlank();
                    return;
                } 
            }

            try
            {
                Student st = new Student(textBoxStdNm.Text.ToString(), textBoxStdNam.Text.ToString(), int.Parse(textBoxNumCrs.Text), comboBoxStdTyp.SelectedItem.ToString());
                studentList.Add(st);
                saveData();
            }
            catch(System.FormatException e1)
            {
                Console.WriteLine(e1.Message);
                MessageBox.Show("You must enter correct type of data");
                textBoxNumCrs.Text = "";
                return;
            }

           

            // add student to the list view

            listView1.Items.Add(new ListViewItem(new String[] { textBoxStdNm.Text, textBoxStdNam.Text, textBoxNumCrs.Text, comboBoxStdTyp.Text }));
            
            doBlank();

            //clear the studentListFilter list
            studentListFilter.Clear();
            //prepare the new list view object to accept items
            studentListFilter.AddRange(listView1.Items.Cast<ListViewItem>());




        }

        public void doBlank()
        {
            textBoxStdNm.Text = "";
            textBoxStdNam.Text = "";
            textBoxNumCrs.Text = "";
            comboBoxStdTyp.SelectedIndex = 0;

        }

        public bool ifBlank()
        {
            //validate textboxes which have blank spaces

            if(textBoxStdNm.Text.Equals("") || textBoxStdNam.Text.Equals("") || textBoxNumCrs.Text.Equals("") || comboBoxStdTyp.Text.Equals(""))
            {
                return false;
            } else
            {
                return true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxStdTyp.SelectedIndex = 0;
            doBlank();
            //clear the new listview object
            studentListFilter.Clear();
            //prepare the new list view object to accept items
            studentListFilter.AddRange(listView1.Items.Cast<ListViewItem>());

            //Clear the list view to receive the new data
            listView1.Items.Clear();
            loadData();
            
        }

        private void textBoxFlt_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            
            if(textBoxFlt.Text == "")
            {
                listView1.Items.AddRange(studentListFilter.ToArray());
                return;
            }
            //LINQ
            //We need to go inside listview for double time, so this is the best solution for this.
            var list = studentListFilter.Cast<ListViewItem>()
                        .Where(x => x.SubItems
                            .Cast<ListViewItem.ListViewSubItem>()
                            .Any(y => y.Text.Contains(textBoxFlt.Text.ToString())))
                        .ToArray();

            listView1.Items.AddRange(list);


        }

        private void buttonEdt_Click(object sender, EventArgs e)
        {
            string data;
            if(ifBlank() == false)
            {
                MessageBox.Show("You must to choose a record!");
                return;
            }

            var selectedStudent = listView1.SelectedIndices;
            
            if(selectedStudent.Count == 0)
            {
                return;
            }
            //first delete the record from studentList list
            for(int i=0; i<studentList.Count; i++)
            {
                if (studentList[i].studNumber.Equals(oldValue))
                {
                    studentList.RemoveAt(i);
                }
            }
            //then add as a new record
            string num = textBoxStdNm.Text.ToString();
            string name = textBoxStdNam.Text.ToString();
            string course = textBoxNumCrs.Text.ToString();
            string type = comboBoxStdTyp.Text.ToString();
            try
            {
                studentList.Add(new Student(num, name, int.Parse(course), type));

            }
            catch (System.FormatException e1)
            {
                Console.WriteLine(e1.Message);
                MessageBox.Show("You must enter correct type of data");
                textBoxNumCrs.Text = "";
                return;
            }

            

            var path = @"Student.txt";
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //Clear the list view to receive the new data
            listView1.Items.Clear();
            try
            {
                for (int i = 0; i < studentList.Count; i++)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { studentList[i].studNumber, studentList[i].studName, (studentList[i].courses).ToString(), studentList[i].studType }));
                    data = studentList[i].studNumber + " " + studentList[i].studName + " " + studentList[i].courses + " " + studentList[i].studType + "\n";
                    sw.Write(data);
                }
            }catch(Exception e1)
            {
                Console.WriteLine("buttonEdt_Click() --> " + e1.Message);

            }
            finally
            {
                sw.Flush();
                sw.Close();
            }
            


            doBlank();

            //clear the studentListFilter list
            studentListFilter.Clear();
            //prepare the new list view object to accept items
            studentListFilter.AddRange(listView1.Items.Cast<ListViewItem>());
        }

        private void buttonDlt_Click(object sender, EventArgs e)
        {
            if (ifBlank() == false)
            {
                MessageBox.Show("You must choose a record!");
                return;
            }

            var selectedStudent = listView1.SelectedIndices;

            if (selectedStudent.Count == 0)
            {
                return;
            }
            

            // delete the record from studentList list
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].studNumber.Equals(oldValue))
                {
                    studentList.RemoveAt(i);
                }
            }

            doBlank();
            string data;
            var path = @"Student.txt";
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //Clear the list view to receive the new data
            listView1.Items.Clear();
            try
            {
                for (int i = 0; i < studentList.Count; i++)
                {
                    listView1.Items.Add(new ListViewItem(new String[] { studentList[i].studNumber, studentList[i].studName, (studentList[i].courses).ToString(), studentList[i].studType }));
                    data = studentList[i].studNumber + " " + studentList[i].studName + " " + studentList[i].courses + " " + studentList[i].studType + "\n";
                    sw.Write(data);
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine("buttonEdt_Click() --> " + e1.Message);

            }
            finally
            {
                sw.Flush();
                sw.Close();
            }


            //clear the studentListFilter list
            studentListFilter.Clear();
            //prepare the new list view object to accept items
            studentListFilter.AddRange(listView1.Items.Cast<ListViewItem>());
        }
    }
}


/*
 * Creating and opening a file

Var path = @”file.txt”;
  FileStream fs = new FileStream(path, FileMode.OpenOrCreate);

1) Append: It opens the file if it exists and places the cursor at the end of the file or creates a new file 
2) Create: It creates a new file
3) CreateNew: It specifies to an operating system that a new file should be created
4) Open: It opens an existing file
5) OpenOrCreate: It specifies to the system that open a file I it exists, else create a new file
6) Truncate: It opens an existing file. When opened, the file should be truncated, the size of the file is zero bytes.
*/
