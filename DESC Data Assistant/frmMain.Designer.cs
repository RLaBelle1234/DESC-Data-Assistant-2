namespace DESC_Data_Assistant
{
    partial class frmMain
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
            this.lblCRM = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCRM.Location = new System.Drawing.Point(23, 36);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(70, 13);
            this.lblCRM.TabIndex = 0;
            this.lblCRM.Text = "CRM Service";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(382, 36);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(256, 436);
            this.txtSQL.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(578, 487);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create This Entity";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(269, 36);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 536);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCRM);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnConnect;
    }
}

