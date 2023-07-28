namespace sunsudrill
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InBOX = new System.Windows.Forms.TextBox();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(183, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "答え";
            // 
            // InBOX
            // 
            this.InBOX.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InBOX.Location = new System.Drawing.Point(270, 253);
            this.InBOX.Name = "InBOX";
            this.InBOX.Size = new System.Drawing.Size(194, 34);
            this.InBOX.TabIndex = 1;
            this.InBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InBOX_KeyPress);
            // 
            // OutBox
            // 
            this.OutBox.Location = new System.Drawing.Point(514, 119);
            this.OutBox.Multiline = true;
            this.OutBox.Name = "OutBox";
            this.OutBox.ReadOnly = true;
            this.OutBox.Size = new System.Drawing.Size(156, 168);
            this.OutBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutBox);
            this.Controls.Add(this.InBOX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "算数ドリル";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InBOX;
        private System.Windows.Forms.TextBox OutBox;
    }
}

