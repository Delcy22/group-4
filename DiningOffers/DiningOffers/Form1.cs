// =============================
// Form1.cs (MAIN LOGIC)
// =============================
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DiningFullSystem
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> menu = new Dictionary<string, double>()
{
    {"Burger", 5.00},
    {"Pizza", 8.50},
    {"Steak", 12.00},
    {"Juice", 2.50},
    {"Ice Cream", 3.00}
};

        double total = 0;

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listViewMenu.Items.Clear();

            if (menu.ContainsKey(e.Node.Text))
            {
                ListViewItem item = new ListViewItem(e.Node.Text);
                item.SubItems.Add(menu[e.Node.Text].ToString("0.00"));
                listViewMenu.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listViewMenu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item!");
                return;
            }

            string itemName = listViewMenu.SelectedItems[0].Text;
            double price = menu[itemName];

            // Add to Order ListView
            ListViewItem orderItem = new ListViewItem(itemName);
            orderItem.SubItems.Add("$" + price.ToString("0.00"));
            listViewOrder.Items.Add(orderItem);

            // Update total
            total += price;
            lblTotal.Text = "Total: $" + total.ToString("0.00");

            // Progress bar
            progressBar1.Value = Math.Min(progressBar1.Value + 20, 100);

            // Status message
            toolStripStatusLabel1.Text = itemName + " added!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (listViewOrder.Items.Count == 0)
            {
                MessageBox.Show("No items in order!");
                return;
            }

            // Show receipt
            string receipt = "***** RECEIPT *****\n\n";

            foreach (ListViewItem item in listViewOrder.Items)
            {
                receipt += item.Text + " - " + item.SubItems[1].Text + "\n";
            }

            receipt += "\nTotal: $" + total.ToString("0.00");

            MessageBox.Show(receipt, "Receipt");

            // Reset everything
            listViewOrder.Items.Clear();
            total = 0;
            lblTotal.Text = "Total: $0.00";
            progressBar1.Value = 0;
            toolStripStatusLabel1.Text = "Order completed!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in menu)
            {
                ListViewItem row = new ListViewItem(item.Key);
                row.SubItems.Add(item.Value.ToString("0.00"));
                listViewMenu.Items.Add(row);
            }
        }
    }
    }
    }
    }    