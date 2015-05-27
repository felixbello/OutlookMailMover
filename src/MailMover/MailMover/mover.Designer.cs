namespace MailMover
{
    partial class mover
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.treeViewFolders = new System.Windows.Forms.TreeView();
            this.buttonMoveIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(13, 13);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(213, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Text = "... input Searching Text here ...";
            // 
            // treeViewFolders
            // 
            this.treeViewFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewFolders.Location = new System.Drawing.Point(13, 40);
            this.treeViewFolders.Name = "treeViewFolders";
            this.treeViewFolders.Size = new System.Drawing.Size(213, 197);
            this.treeViewFolders.TabIndex = 1;
            // 
            // buttonMoveIT
            // 
            this.buttonMoveIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMoveIT.Location = new System.Drawing.Point(152, 241);
            this.buttonMoveIT.Name = "buttonMoveIT";
            this.buttonMoveIT.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveIT.TabIndex = 2;
            this.buttonMoveIT.Text = "Move It!";
            this.buttonMoveIT.UseVisualStyleBackColor = true;
            // 
            // mover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 270);
            this.Controls.Add(this.buttonMoveIT);
            this.Controls.Add(this.treeViewFolders);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "mover";
            this.Text = "Mail Mover";
            this.Load += new System.EventHandler(this.mover_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TreeView treeViewFolders;
        private System.Windows.Forms.Button buttonMoveIT;
    }
}