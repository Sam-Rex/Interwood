using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System;

namespace EOM_stores._contr.Shared
{
    class closeForm
    {
        private Form _OpenedForm;
        private Form OpenedForm { get; set; }

        private Form _MainForm;
        private Form MainForm { get; set; }

        private void prepareSecction()
        {
          _OpenedForm = OpenedForm;
            _MainForm = MainForm;
        }

        public void closeThis(Form _OpenedForm)
        {
            try
            {
                
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name != "decorateHomeScreen"&&form.Name == _OpenedForm.Name)
                    {
                       
                    }
                    else
                    {
                        _OpenedForm.Close();
                    }
                }
            }catch(InvalidOperationException ioe) { }
        }
       
    }
}
