﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Outlook;
namespace MailMover
{
    public partial class MailMoverMenu
    {
        private void MailMoverMenu_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void buttonMailMover_Click(object sender, RibbonControlEventArgs e)
        {
            mover moverForm = new mover();
            moverForm.ShowDialog();
        }
    }
}
