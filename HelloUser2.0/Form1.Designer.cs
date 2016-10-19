namespace HelloUser2._0
{
    partial class FrmHelloUser
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
            this.lblBest = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCheckBox = new System.Windows.Forms.Label();
            this.rdoScheifele = new System.Windows.Forms.RadioButton();
            this.rdoMonahan = new System.Windows.Forms.RadioButton();
            this.rdoLandeskog = new System.Windows.Forms.RadioButton();
            this.rdoHuberdeau = new System.Windows.Forms.RadioButton();
            this.btnOther = new System.Windows.Forms.RadioButton();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Location = new System.Drawing.Point(46, 13);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(215, 13);
            this.lblBest.TabIndex = 0;
            this.lblBest.Text = "who is the best player? (if other specify who)";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(14, 261);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // lblCheckBox
            // 
            this.lblCheckBox.Location = new System.Drawing.Point(11, 67);
            this.lblCheckBox.Name = "lblCheckBox";
            this.lblCheckBox.Size = new System.Drawing.Size(323, 194);
            this.lblCheckBox.TabIndex = 13;
            // 
            // rdoScheifele
            // 
            this.rdoScheifele.AutoSize = true;
            this.rdoScheifele.Location = new System.Drawing.Point(51, 67);
            this.rdoScheifele.Name = "rdoScheifele";
            this.rdoScheifele.Size = new System.Drawing.Size(96, 17);
            this.rdoScheifele.TabIndex = 14;
            this.rdoScheifele.TabStop = true;
            this.rdoScheifele.Text = "Mark Scheifele";
            this.rdoScheifele.UseVisualStyleBackColor = true;
            this.rdoScheifele.CheckedChanged += new System.EventHandler(this.rdoScheifele_CheckedChanged);
            // 
            // rdoMonahan
            // 
            this.rdoMonahan.AutoSize = true;
            this.rdoMonahan.Location = new System.Drawing.Point(188, 67);
            this.rdoMonahan.Name = "rdoMonahan";
            this.rdoMonahan.Size = new System.Drawing.Size(98, 17);
            this.rdoMonahan.TabIndex = 15;
            this.rdoMonahan.TabStop = true;
            this.rdoMonahan.Text = "Sean Monahan";
            this.rdoMonahan.UseVisualStyleBackColor = true;
            this.rdoMonahan.CheckedChanged += new System.EventHandler(this.rdoMonahan_CheckedChanged);
            // 
            // rdoLandeskog
            // 
            this.rdoLandeskog.AutoSize = true;
            this.rdoLandeskog.Location = new System.Drawing.Point(51, 121);
            this.rdoLandeskog.Name = "rdoLandeskog";
            this.rdoLandeskog.Size = new System.Drawing.Size(114, 17);
            this.rdoLandeskog.TabIndex = 16;
            this.rdoLandeskog.TabStop = true;
            this.rdoLandeskog.Text = "Gabriel Landeskog";
            this.rdoLandeskog.UseVisualStyleBackColor = true;
            this.rdoLandeskog.CheckedChanged += new System.EventHandler(this.rdoLandeskog_CheckedChanged);
            // 
            // rdoHuberdeau
            // 
            this.rdoHuberdeau.AutoSize = true;
            this.rdoHuberdeau.Location = new System.Drawing.Point(188, 121);
            this.rdoHuberdeau.Name = "rdoHuberdeau";
            this.rdoHuberdeau.Size = new System.Drawing.Size(125, 17);
            this.rdoHuberdeau.TabIndex = 17;
            this.rdoHuberdeau.TabStop = true;
            this.rdoHuberdeau.Text = "Jonathan Huberdeau";
            this.rdoHuberdeau.UseVisualStyleBackColor = true;
            this.rdoHuberdeau.CheckedChanged += new System.EventHandler(this.rdoHuberdeau_CheckedChanged);
            // 
            // btnOther
            // 
            this.btnOther.AutoSize = true;
            this.btnOther.Location = new System.Drawing.Point(188, 162);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(49, 17);
            this.btnOther.TabIndex = 18;
            this.btnOther.TabStop = true;
            this.btnOther.Text = "other";
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.CheckedChanged += new System.EventHandler(this.btnOther_CheckedChanged);
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(82, 162);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer.TabIndex = 19;
            // 
            // FrmHelloUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 381);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.rdoHuberdeau);
            this.Controls.Add(this.rdoLandeskog);
            this.Controls.Add(this.rdoMonahan);
            this.Controls.Add(this.rdoScheifele);
            this.Controls.Add(this.lblCheckBox);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblBest);
            this.Name = "FrmHelloUser";
            this.Text = "Hello User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCheckBox;
        private System.Windows.Forms.RadioButton rdoScheifele;
        private System.Windows.Forms.RadioButton rdoMonahan;
        private System.Windows.Forms.RadioButton rdoLandeskog;
        private System.Windows.Forms.RadioButton rdoHuberdeau;
        private System.Windows.Forms.RadioButton btnOther;
        private System.Windows.Forms.TextBox txtPlayer;
    }
}

