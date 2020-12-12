using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace FIFAAutoBuyer_Client.Helpers
{
    static class CommonHelper
    {
        public static DataTable ToDataTable<T>(this List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance); 

            for (int i = 0; i < Props.Length; i++)
            {
                var prop = Props[i];
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                { 
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        public static void HideColumns(this DataGridView dataView, List<string> columnsToHide)
        {
            foreach (var column in columnsToHide)
            {
                dataView.Columns[column].Visible = false;
            }
        }

        public static void ResetAllControls(this ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)control;
                    textBox.Text = null;
                }

                if (control is Guna2ComboBox)
                {
                    Guna2ComboBox comboBox = (Guna2ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is Guna2CheckBox)
                {
                    Guna2CheckBox checkBox = (Guna2CheckBox)control;
                    checkBox.Checked = false;
                }
            }
        }
    }
}
