using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
namespace MailMover
{
    public partial class mover : Form
    {
        public mover()
        {
            InitializeComponent();
        }

        private void mover_Load(object sender, EventArgs e)
        {

            Folder Folder = new Folder();
            getFoldersRecursive(Folder );
        }
        private void getFoldersRecursive(Folder folder) {
            if (folder.Folders.Count == 0)
            {
                MessageBox.Show(folder.FullFolderPath);
            } else
            {
                foreach (Folder  subFolder in folder.Folders)
                {
                    MessageBox.Show(subFolder.FullFolderPath);
                    getFoldersRecursive(subFolder);
                }
            }
        }
    }
}
