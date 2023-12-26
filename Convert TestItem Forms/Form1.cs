using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MerryTest.Entity;

namespace Convert_TestItem_Forms
{
    public partial class Form1 : Form
    {
        UIAdaptiveSize uias;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                var text = rtbInput.Text;
                rtbOutput.Text = Convert(text, 1);
                rtbUnit.Text = Convert(text, 2);
                rtbDown.Text = Convert(text, 3);
                rtbUp.Text = Convert(text, 4);
                rtbDevice.Text = Convert(text, 6);
                Convert_List();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"字段格式不正确、Lỗi định dạng\n{ex}");
            }
        }
        static string Convert(string text, int position)
        {
            var mang1 = text.Split('\n');
            string output = "";
            int number = 0;
            foreach (var item in mang1)
            {
                var item_test = item.Split(',');
                if (item_test[1].Contains("-")|| position==6) 
                //if (position == 6)
                {
                    if (item_test[1].Contains(".") && !output.Contains("Switch")) output += "Switch\n";
                    if (!item_test[position].Contains("=")) continue;
                    item_test[position] = (item_test[position]).Split('=', '&')[1];
                    if(!output.Contains(item_test[position]))
                    output += item_test[position] + "\n";
                }
                else
                {
                    number++;
                    if (position == 1)
                    {
                        //item_test[position] = $"{number}. "+(item_test[position]).Split('|')[0].Replace("+","");
                        item_test[position] = (item_test[position]).Split('|')[0].Replace("+", "")+" NG";

                    }
                    output += item_test[position] + "\n";
                }
                
               
                

            }
            return output;
        }

        private void Convert_List()
        {
            listView1.Items.Clear();
            var TestItem = rtbInput.Text.Split('\r', '\n');
            int number = 0;
            foreach(var item1 in TestItem)
            {
                var item = item1.Split(',');
                number = item[1].Contains("-") ? number : number + 1;
                //number = number + 1;
                if (item[1].Contains("|")) item[1] = item[1].Split('|')[0];
                if (item[1].Contains("-")) continue;
                string[] str = { number.ToString(), item[1],  item[2], item[3], item[4] , item[6]};
                listView1.Items.Add(new ListViewItem(str));
                int i = number - 1;
                listView1.Items[i].UseItemStyleForSubItems = true;
                if (number % 2 == 0)
                {
                    listView1.Items[i].BackColor = Color.Gainsboro;
                }
                else
                {
                    listView1.Items[i].BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uias = new UIAdaptiveSize
            {
                Width = Width,
                Height = Height,
                FormsName = this.Text,
                X = Width,
            };
            uias.SetInitSize(this);
            flag1 = true;
            this.WindowState = FormWindowState.Maximized;
        }

        bool flag1 = false;
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (!flag1) return;
            var newx = Width;
            uias.UpdateSize(Width, Height, this);
            uias.X = newx;
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(e.ItemIndex % 2 == 0 ? Color.Gainsboro : Color.WhiteSmoke), e.Bounds);
            e.DrawText();
        }
    }
}
