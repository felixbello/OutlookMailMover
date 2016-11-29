namespace MailMover
{
    partial class MailMoverMenu : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MailMoverMenu()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">"true", wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls "false".</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für Designerunterstützung -
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.groupMailMover = this.Factory.CreateRibbonGroup();
            this.buttonMailMover = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.groupMailMover.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.groupMailMover);
            this.tab1.Label = "Mail Mover";
            this.tab1.Name = "tab1";
            // 
            // groupMailMover
            // 
            this.groupMailMover.Items.Add(this.buttonMailMover);
            this.groupMailMover.Label = "MailMover";
            this.groupMailMover.Name = "groupMailMover";
            // 
            // buttonMailMover
            // 
            this.buttonMailMover.Label = "Mail Mover";
            this.buttonMailMover.Name = "buttonMailMover";
            this.buttonMailMover.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonMailMover_Click);
            // 
            // MailMoverMenu
            // 
            this.Name = "MailMoverMenu";
            this.RibbonType = "Microsoft.Outlook.Mail.Read";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MailMoverMenu_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupMailMover.ResumeLayout(false);
            this.groupMailMover.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupMailMover;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonMailMover;
    }

    partial class ThisRibbonCollection
    {
        internal MailMoverMenu MailMoverMenu
        {
            get { return this.GetRibbon<MailMoverMenu>(); }
        }
    }
}
