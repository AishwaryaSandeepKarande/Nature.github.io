using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Natue_Gift_Cafe.All_User_Control
{
    public partial class UC_AddItem : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddItem()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into item (name,category,price) values ('" + txtItemName.Text + "','" + txtCategory.Text + "'," + txtPrice.Text + ")";
            fn.setData(query);
            clearAll();

        }
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UC_AddItem_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddItem_Load(object sender, EventArgs e)
        {

        }
    }
}
