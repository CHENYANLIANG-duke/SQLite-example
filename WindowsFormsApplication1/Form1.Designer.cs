namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.labname = new System.Windows.Forms.Label();
            this.labtel = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnquery = new System.Windows.Forms.Button();
            this.btncheckstore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labname.Location = new System.Drawing.Point(12, 9);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(53, 21);
            this.labname.TabIndex = 0;
            this.labname.Text = "name";
            // 
            // labtel
            // 
            this.labtel.AutoSize = true;
            this.labtel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtel.Location = new System.Drawing.Point(12, 90);
            this.labtel.Name = "labtel";
            this.labtel.Size = new System.Drawing.Size(87, 21);
            this.labtel.TabIndex = 1;
            this.labtel.Text = "telephone";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(16, 49);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 2;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(16, 126);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 22);
            this.txttel.TabIndex = 3;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(185, 28);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(75, 57);
            this.btnwrite.TabIndex = 4;
            this.btnwrite.Text = "write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnquery
            // 
            this.btnquery.Location = new System.Drawing.Point(185, 91);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(75, 57);
            this.btnquery.TabIndex = 5;
            this.btnquery.Text = "query";
            this.btnquery.UseVisualStyleBackColor = true;
            this.btnquery.Click += new System.EventHandler(this.btnquery_Click);
            // 
            // btncheckstore
            // 
            this.btncheckstore.Location = new System.Drawing.Point(12, 164);
            this.btncheckstore.Name = "btncheckstore";
            this.btncheckstore.Size = new System.Drawing.Size(244, 35);
            this.btncheckstore.TabIndex = 6;
            this.btncheckstore.Text = "check_store";
            this.btncheckstore.UseVisualStyleBackColor = true;
            this.btncheckstore.Click += new System.EventHandler(this.btncheckstore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.btncheckstore);
            this.Controls.Add(this.btnquery);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labtel);
            this.Controls.Add(this.labname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labtel;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.Button btncheckstore;
    }
}

