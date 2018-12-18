namespace Mainstream_Anime_Emporium
{
    partial class ucEmpList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpHolder = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEmpList = new System.Windows.Forms.DataGridView();
            this.tlpBHolder = new System.Windows.Forms.TableLayoutPanel();
            this.btnView = new System.Windows.Forms.Button();
            this.tlpHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpList)).BeginInit();
            this.tlpBHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpHolder
            // 
            this.tlpHolder.ColumnCount = 1;
            this.tlpHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHolder.Controls.Add(this.dgvEmpList, 0, 0);
            this.tlpHolder.Controls.Add(this.tlpBHolder, 0, 1);
            this.tlpHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHolder.Location = new System.Drawing.Point(0, 0);
            this.tlpHolder.Name = "tlpHolder";
            this.tlpHolder.RowCount = 2;
            this.tlpHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpHolder.Size = new System.Drawing.Size(860, 670);
            this.tlpHolder.TabIndex = 0;
            // 
            // dgvEmpList
            // 
            this.dgvEmpList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpList.Location = new System.Drawing.Point(3, 3);
            this.dgvEmpList.Name = "dgvEmpList";
            this.dgvEmpList.Size = new System.Drawing.Size(854, 530);
            this.dgvEmpList.TabIndex = 0;
            // 
            // tlpBHolder
            // 
            this.tlpBHolder.ColumnCount = 3;
            this.tlpBHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpBHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpBHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBHolder.Controls.Add(this.btnView, 1, 0);
            this.tlpBHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBHolder.Location = new System.Drawing.Point(3, 539);
            this.tlpBHolder.Name = "tlpBHolder";
            this.tlpBHolder.RowCount = 1;
            this.tlpBHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBHolder.Size = new System.Drawing.Size(854, 128);
            this.tlpBHolder.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnView.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(287, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(278, 122);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View Schedule";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // ucEmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpHolder);
            this.Name = "ucEmpList";
            this.Size = new System.Drawing.Size(860, 670);
            this.Load += new System.EventHandler(this.usEmpList_Load);
            this.tlpHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpList)).EndInit();
            this.tlpBHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpHolder;
        private System.Windows.Forms.DataGridView dgvEmpList;
        private System.Windows.Forms.TableLayoutPanel tlpBHolder;
        private System.Windows.Forms.Button btnView;
    }
}
