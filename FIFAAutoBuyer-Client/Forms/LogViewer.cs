using FIFAAutoBuyer_Client.Helpers;
using FIFAAutoBuyer_Lib.DataModels;
using FIFAAutoBuyer_Lib.Domain;
using FIFAAutoBuyer_Lib.Models;
using Guna.UI2.WinForms;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client.Forms
{
    public partial class LogViewerForm : BaseForm
    {
        private Timer _timer;
        public LogViewerForm()
        {
            InitializeComponent();
        }

        private void LogViewer_Load(object sender, EventArgs e)
        {
            List<UserCredential> usersList = UserDAL.GetUsers();

            foreach (var user in usersList)
            {
                this.tab_userLogs.TabPages.Add(GenerateTabForUser(user.Email));
            }

            if (usersList.Any())
            {
                string userEmail = usersList[0].Email;
                List<LogInfo> logsForUser = LoggerDAL.GetLogForUser(userEmail);

                Guna2DataGridView gridView = this.tab_userLogs.SelectedTab.Controls[userEmail + "_logview"] as Guna2DataGridView;
                gridView.DataSource = logsForUser.ToDataTable();
            }

            InitTimer();
        }
        public void InitTimer()
        {
            _timer = new Timer();
            _timer.Tick += new EventHandler(timer_Tick);
            _timer.Interval = 5000; 
            _timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tab_userLogs_SelectedIndexChanged(sender,e);
        }

        private void tab_userLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userEmail = this.tab_userLogs.SelectedTab.Name;
            List<LogInfo> logsForUser = LoggerDAL.GetLogForUser(userEmail);

            Guna2DataGridView gridView = this.tab_userLogs.SelectedTab.Controls[userEmail + "_logview"] as Guna2DataGridView;

            var dataSource = logsForUser.ToDataTable();
            gridView.DataSource = dataSource;
            dataSource.DefaultView.RowFilter = GetFilterString(); 
            gridView.Refresh();
        }

        private MetroTabPage GenerateTabForUser(string userEmail)
        {
            MetroTabPage metroTabPage = new MetroTabPage();
            metroTabPage.Controls.Add(GenerateDataGrid(userEmail));
            metroTabPage.HorizontalScrollbarBarColor = true;
            metroTabPage.HorizontalScrollbarHighlightOnWheel = false;
            metroTabPage.HorizontalScrollbarSize = 10;
            metroTabPage.Location = new Point(4, 38);
            metroTabPage.Name = userEmail;
            metroTabPage.Size = new Size(979, 562);
            metroTabPage.TabIndex = 0;
            metroTabPage.Text = userEmail.Split('@')[0]; ;
            metroTabPage.VerticalScrollbarBarColor = true;
            metroTabPage.VerticalScrollbarHighlightOnWheel = false;
            metroTabPage.VerticalScrollbarSize = 10;

            return metroTabPage;
        }


        private Guna2DataGridView GenerateDataGrid(string userEmail)
        {
            DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle4 = new DataGridViewCellStyle();

            Guna2DataGridView gridView = new Guna2DataGridView();

            ((ISupportInitialize)(gridView)).BeginInit();
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            cellStyle1.BackColor = Color.White;
            gridView.AlternatingRowsDefaultCellStyle = cellStyle1;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            gridView.BackgroundColor = Color.White;
            gridView.BorderStyle = BorderStyle.None;
            gridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            cellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle2.BackColor = Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            cellStyle2.Font = new Font("Segoe UI", 8F);
            cellStyle2.ForeColor = Color.DimGray;
            cellStyle2.SelectionBackColor = Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            cellStyle2.SelectionForeColor = SystemColors.HighlightText;
            cellStyle2.WrapMode = DataGridViewTriState.True;
            gridView.ColumnHeadersDefaultCellStyle = cellStyle2;
            gridView.ColumnHeadersHeight = 40;
            cellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle3.BackColor = Color.White;
            cellStyle3.Font = new Font("Segoe UI", 8F);
            cellStyle3.ForeColor = Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            cellStyle3.SelectionBackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            cellStyle3.SelectionForeColor = Color.White;
            cellStyle3.WrapMode = DataGridViewTriState.False;
            gridView.DefaultCellStyle = cellStyle3;
            gridView.EnableHeadersVisualStyles = false;
            gridView.GridColor = Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            gridView.Location = new Point(23, 12);
            gridView.MultiSelect = false;
            gridView.Name = userEmail + "_logview";
            gridView.ReadOnly = true;
            cellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle4.BackColor = SystemColors.Control;
            cellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            cellStyle4.ForeColor = SystemColors.WindowText;
            cellStyle4.SelectionBackColor = SystemColors.Highlight;
            cellStyle4.SelectionForeColor = SystemColors.HighlightText;
            cellStyle4.WrapMode = DataGridViewTriState.True;
            gridView.RowHeadersDefaultCellStyle = cellStyle4;
            gridView.RowHeadersVisible = false;
            gridView.RowTemplate.DividerHeight = 3;
            gridView.RowTemplate.Height = 35; 
            gridView.ScrollBars = ScrollBars.Vertical;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.Size = new Size(964, 607);
            gridView.TabIndex = 1;
            gridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            gridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gridView.ThemeStyle.BackColor = Color.White;
            gridView.ThemeStyle.GridColor = Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            gridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            gridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            gridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gridView.ThemeStyle.HeaderStyle.Height = 40;
            gridView.ThemeStyle.ReadOnly = true;
            gridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            gridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 8F);
            gridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            gridView.ThemeStyle.RowsStyle.Height = 50;
            gridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            gridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            ((ISupportInitialize)(gridView)).EndInit();
            return gridView;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string filter = GetFilterString();

            string userEmail = this.tab_userLogs.SelectedTab.Name;
            Guna2DataGridView gridView = this.tab_userLogs.SelectedTab.Controls[userEmail + "_logview"] as Guna2DataGridView;

            var dt = (DataTable)gridView.DataSource; 
            dt.DefaultView.RowFilter = filter;
            gridView.Refresh();
        }

        private string GetFilterString()
        {
            string filter = "";

            if (!string.IsNullOrEmpty(txt_searchTerm.Text))
            {
                filter += string.Format("Message like '%{0}%'", txt_searchTerm.Text.Trim());
            }

            if (cmb_types.SelectedIndex != 0)
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }

                filter += "Type = " + (int)Enum.Parse(typeof(LogType), cmb_types.Text);
            }

            return filter;
        }

        private void btn_clearLog_Click(object sender, EventArgs e)
        {
            string userEmail = this.tab_userLogs.SelectedTab.Name;

            LoggerDAL.ClearLogsForUser(userEmail);

            tab_userLogs_SelectedIndexChanged(sender, e);
        }
    }
}
