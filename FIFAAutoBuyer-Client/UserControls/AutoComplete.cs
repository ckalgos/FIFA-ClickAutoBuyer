using MetroFramework.Controls;
using System;
using System.Linq; 

namespace FIFAAutoBuyer_Client.UserControls
{
    public partial class AutoComplete : MetroUserControl
    {
        public AutoComplete()
        {
            InitializeComponent();
            suggestions_listBox.Visible = false;
            this.Height = 52;
        }

        private void txt_autoSuggestText_TextChanged(object sender, System.EventArgs e)
        {
            suggestions_listBox.Items.Clear();
            suggestions_listBox.Visible = false;

            if (string.IsNullOrEmpty(txt_srchTerm.Text))
            {
                suggestions_listBox.Visible = false;
                this.Height = 52;
            }
            else
            {
                foreach (var item in DataSource.Where(a => a.IndexOf(txt_srchTerm.Text, StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    suggestions_listBox.Items.Add(item);
                }

                if (suggestions_listBox.Items.Count > 1)
                {
                    suggestions_listBox.Visible = true;
                    this.Height = 348;
                }
                else if (suggestions_listBox.Items.Count == 1)
                {
                    txt_srchTerm.Text = suggestions_listBox.Items[0] + "";
                    suggestions_listBox.Visible = false;
                    this.Height = 52;
                }
            }
        }

        private void suggestions_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_srchTerm.Text = suggestions_listBox.Text;
            suggestions_listBox.Visible = false;
            this.Height = 52;
        }
    }
}
