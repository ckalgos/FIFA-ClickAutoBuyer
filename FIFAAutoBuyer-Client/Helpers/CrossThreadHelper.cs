
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace FIFAAutoBuyer_Client.Helpers
{
    public static class CrossThreadHelper
    {
        delegate void SetTextCallback(Form f, Control ctrl, string text);
        delegate void SetVisiblityCallback(Form f, Control ctrl, bool isVisible);
        delegate void SetLoaderVisibility(Form f, Guna2ProgressIndicator ctrl, bool isLoading);

        public static void SetText(Form form, Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }

        public static void SetVisiblity(Form form, Control ctrl, bool isVisible)
        {
            if (ctrl.InvokeRequired)
            {
                SetVisiblityCallback d = new SetVisiblityCallback(SetVisiblity);
                form.Invoke(d, new object[] { form, ctrl, isVisible });
            }
            else
            {
                ctrl.Visible = isVisible;
            }
        }

        public static void SetEnable(Form form, Control ctrl, bool isEnabled)
        {
            if (ctrl.InvokeRequired)
            {
                SetVisiblityCallback d = new SetVisiblityCallback(SetEnable);
                form.Invoke(d, new object[] { form, ctrl, isEnabled });
            }
            else
            {
                ctrl.Enabled = isEnabled;
            }
        }

        public static void SetLoader(Form form, Guna2ProgressIndicator ctrl, bool isLoading)
        {
            if (ctrl.InvokeRequired)
            {
                SetLoaderVisibility d = new SetLoaderVisibility(SetLoader);
                form.Invoke(d, new object[] { form, ctrl, isLoading });
            }
            else
            {
                SetVisiblity(form, ctrl, isLoading);
                if (isLoading)
                { 
                    ctrl.Start();
                }
                else
                { 
                    ctrl.Stop();
                }
            }
        }
    }
}
