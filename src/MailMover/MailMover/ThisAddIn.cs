using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace MailMover
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            
            this.Application.NewMail += new Microsoft.Office.Interop.Outlook.
        ApplicationEvents_11_NewMailEventHandler
        (MoveItem );
            
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Von VSTO generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        private void MoveItem() {
            Outlook.MAPIFolder inBox = (Outlook.MAPIFolder)this.Application.ActiveExplorer().Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
            Outlook.Items items = (Outlook.Items )inBox.Items ;
            Outlook.MailItem moveItem = null;
            items.Restrict("[UnRead] = true");
            Outlook.MAPIFolder destinationFolder = inBox.Folders["test"];
            foreach (object eMail in items)
            {
                try
                {
                    moveItem = eMail as Outlook.MailItem;
                    if (moveItem != null)
                    {
                        string subject = (string)moveItem.Subject;
                        if (subject.IndexOf("test")>0)
                        {
                            moveItem.Move(destinationFolder );
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }


        }
        
        #endregion
    }
}
