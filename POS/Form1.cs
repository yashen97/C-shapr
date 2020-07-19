using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_items.Items.Clear();
            cmb_items.Items.Add("Item 1");
            cmb_items.Items.Add("Item 2");   //combo box items 
            cmb_items.Items.Add("Item 3");
            cmb_items.Items.Add("Item 4");
        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_items.SelectedItem.ToString() == "Item 1")
            {
                txt_price.Text = "50";
            }
            else if (cmb_items.SelectedItem.ToString() == "Item 2")   //Prices index
            {
                txt_price.Text = "100";
            }
            else if (cmb_items.SelectedItem.ToString() == "Item 3")
            {
                txt_price.Text = "150";
            }
            else if (cmb_items.SelectedItem.ToString() == "Item 4")
            {
                txt_price.Text = "200";
            }
            else
            {
                txt_price.Text = "0";
            }

            //txt_qty.Text = "";
            //txt_price.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txt_price.Text;                           //array passed to ListViewItem obj
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem litem = new ListViewItem(arr);
            listView1.Items.Add(litem);

            txt_sub.Text = (Convert.ToInt32(txt_sub.Text) + Convert.ToInt32(txt_total.Text)).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length>0)
            {
                txt_total.Text = (Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_qty.Text)).ToString();
            }
        }
    }
}
