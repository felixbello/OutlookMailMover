using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace MailMover
{
    public partial class MailMover : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MailMover()
        {
            InitializeComponent();
        }

        private void barButtonMailMover01_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {
                Form mainForm = new mover();
                mainForm.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //Application.Exit();
            }


            
        }
    }
}