using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinTodo.Helper;

namespace WinTodo.Business.Main
{
    public partial class Main : MaterialForm
    {
        private int _drawerWidth = 100;
        private int _panelWidth { get => UserArea.Width - _drawerWidth; }
        public Main()
        {
            InitializeComponent();
            MaterialHelper.ManageForm(this);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            string[] row = { "Hello", "Hello", "Hello" };
            materialListView1.Columns.Add("");
            var listViewItem = new ListViewItem(row);
            materialListView1.Items.Add("NEIN");
        }

        private void SetUIForDrawer()
        {

        }

        private void SetUIForPanel()
        {

        }
    }
}
