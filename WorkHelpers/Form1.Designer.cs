namespace WorkHelpers
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbSQLTable = new System.Windows.Forms.Label();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.btCreateWordFromSQLTable = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btCreateWordFromSQLTable);
            this.tabPage1.Controls.Add(this.tbSQL);
            this.tabPage1.Controls.Add(this.lbSQLTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Convert SQL Table To Word";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbSQLTable
            // 
            this.lbSQLTable.AutoSize = true;
            this.lbSQLTable.Location = new System.Drawing.Point(6, 6);
            this.lbSQLTable.Name = "lbSQLTable";
            this.lbSQLTable.Size = new System.Drawing.Size(40, 17);
            this.lbSQLTable.TabIndex = 0;
            this.lbSQLTable.Text = "SQL:";
            // 
            // tbSQL
            // 
            this.tbSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSQL.Location = new System.Drawing.Point(52, 6);
            this.tbSQL.Multiline = true;
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.Size = new System.Drawing.Size(579, 436);
            this.tbSQL.TabIndex = 1;
            this.tbSQL.Text = resources.GetString("tbSQL.Text");
            this.tbSQL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btCreateWordFromSQLTable
            // 
            this.btCreateWordFromSQLTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateWordFromSQLTable.Location = new System.Drawing.Point(456, 448);
            this.btCreateWordFromSQLTable.Name = "btCreateWordFromSQLTable";
            this.btCreateWordFromSQLTable.Size = new System.Drawing.Size(175, 31);
            this.btCreateWordFromSQLTable.TabIndex = 2;
            this.btCreateWordFromSQLTable.Text = "Wordtabelle erzeugen";
            this.btCreateWordFromSQLTable.UseVisualStyleBackColor = true;
            this.btCreateWordFromSQLTable.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 538);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btCreateWordFromSQLTable;
        private System.Windows.Forms.TextBox tbSQL;
        private System.Windows.Forms.Label lbSQLTable;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

