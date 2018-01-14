namespace ClientSoft.WFTest.UI
{
    partial class ResultForm
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
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usersGrid
            // 
            this.usersGrid.AllowUserToAddRows = false;
            this.usersGrid.AllowUserToDeleteRows = false;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.UserName});
            this.usersGrid.Location = new System.Drawing.Point(12, 12);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.ReadOnly = true;
            this.usersGrid.RowTemplate.Height = 60;
            this.usersGrid.Size = new System.Drawing.Size(417, 462);
            this.usersGrid.TabIndex = 0;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(597, 12);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(198, 51);
            this.DownloadButton.TabIndex = 1;
            this.DownloadButton.Text = "Download users friends";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.FillWeight = 200F;
            this.UserName.HeaderText = "Name";
            this.UserName.MinimumWidth = 200;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 200;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 477);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.usersGrid);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}