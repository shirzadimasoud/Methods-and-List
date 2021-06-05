using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string>();
        int _index;
        public Form1()
        {
            InitializeComponent();
        }

        private void getNameBTN_Click(object sender, EventArgs e)
        {
            getname_function(nameTextBox.Text);

        }

        private void getname_function(string name)
        {
            MessageBox.Show($"Your name is : {name}", "Get Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sumBTN_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(num1_txtBox.Text);
            int num2 = int.Parse(num2_txtbox.Text);

            int sum = _sum(num1, num2);
            MessageBox.Show($"Sum is = {sum}", "Sum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int _sum(int num1, int num2)
        {
            return num1 + num2;
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            string[] names = { "ali", "hasan", "hossein", "masoud" };

            string name_to_find = search_txtbox.Text;

            bool find = _search(names, name_to_find);
            if (find)
            {
                MessageBox.Show($"We found the name: {name_to_find}", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"We cannot find the name: {name_to_find}", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private bool _search(string[] names, string name_to_find)
        {
            bool find = false;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name_to_find) 
                {
                    
                    find = true;

                }
            }
            return find;
        }

        private void list_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(list_textbox.Text);
        }

        private void removeList_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listUpdate_txtbox.Text = (string) listBox1.SelectedItem;
            _index = listBox1.SelectedIndex;
            
        }

        private void updateList_btn_Click(object sender, EventArgs e)
        {
            names = listBox1.Items.Cast<string>().ToList();
            names[_index] = listUpdate_txtbox.Text;
            listBox1.Items.Clear();
            for (int i = 0; i < names.Count; i++)
            {
                listBox1.Items.Add(names[i]);
            }
            
        }
    }
}
