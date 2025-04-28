namespace QRCodeControlProject
{
    partial class QRCodeCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutLinePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OutLinePanel
            // 
            this.OutLinePanel.BackColor = System.Drawing.SystemColors.Control;
            this.OutLinePanel.Location = new System.Drawing.Point(30, 27);
            this.OutLinePanel.Name = "OutLinePanel";
            this.OutLinePanel.Size = new System.Drawing.Size(115, 92);
            this.OutLinePanel.TabIndex = 0;
            // 
            // QRCodeCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.OutLinePanel);
            this.Name = "QRCodeCustomControl";
            this.Size = new System.Drawing.Size(175, 141);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OutLinePanel;
    }
}
