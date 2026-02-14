using ModelViewLib.Models;
using ModelViewLib.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelMVC
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            UsersTableView table = new UsersTableView();
            Controls.Add(table);
            table.Dock = DockStyle.Top;
            UserPresenter user = new UserPresenter(table, new MemoryUserModel());
        }
    }
}
