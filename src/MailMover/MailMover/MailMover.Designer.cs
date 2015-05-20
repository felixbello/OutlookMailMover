namespace MailMover
{
    partial class MailMover
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPageMailMover01 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupMailMover01 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonMailMover01 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonMailMover01});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMailMover01});
            this.ribbon.Size = new System.Drawing.Size(442, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPageMailMover01
            // 
            this.ribbonPageMailMover01.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupMailMover01});
            this.ribbonPageMailMover01.Name = "ribbonPageMailMover01";
            this.ribbonPageMailMover01.Text = "Mail Mover";
            // 
            // ribbonPageGroupMailMover01
            // 
            this.ribbonPageGroupMailMover01.ItemLinks.Add(this.barButtonMailMover01);
            this.ribbonPageGroupMailMover01.Name = "ribbonPageGroupMailMover01";
            this.ribbonPageGroupMailMover01.Text = "Mail Mover";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 31);
            // 
            // barButtonMailMover01
            // 
            this.barButtonMailMover01.Caption = "Mail Mover";
            this.barButtonMailMover01.Id = 1;
            this.barButtonMailMover01.Name = "barButtonMailMover01";
            this.barButtonMailMover01.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMailMover01_ItemClick);
            // 
            // MailMover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MailMover";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MailMover";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMailMover01;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupMailMover01;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonMailMover01;
    }
}