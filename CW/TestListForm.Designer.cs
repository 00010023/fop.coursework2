
namespace CW
{
    partial class TestListForm
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
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tsid10023DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsname10023DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq110023DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq1answer10023DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq210023DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq2answer10023DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq310023DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq3answer10023DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tsid10023DataGridViewTextBoxColumn,
            this.tsname10023DataGridViewTextBoxColumn,
            this.tsq110023DataGridViewTextBoxColumn,
            this.tsq1answer10023DataGridViewTextBoxColumn,
            this.tsq210023DataGridViewTextBoxColumn,
            this.tsq2answer10023DataGridViewTextBoxColumn,
            this.tsq310023DataGridViewTextBoxColumn,
            this.tsq3answer10023DataGridViewTextBoxColumn});
            this.dgv.DataSource = this.testBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(848, 486);
            this.dgv.TabIndex = 0;
            // 
            // tsid10023DataGridViewTextBoxColumn
            // 
            this.tsid10023DataGridViewTextBoxColumn.DataPropertyName = "ts_id_10023";
            this.tsid10023DataGridViewTextBoxColumn.HeaderText = "ID";
            this.tsid10023DataGridViewTextBoxColumn.Name = "tsid10023DataGridViewTextBoxColumn";
            this.tsid10023DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsname10023DataGridViewTextBoxColumn
            // 
            this.tsname10023DataGridViewTextBoxColumn.DataPropertyName = "ts_name_10023";
            this.tsname10023DataGridViewTextBoxColumn.HeaderText = "Name";
            this.tsname10023DataGridViewTextBoxColumn.Name = "tsname10023DataGridViewTextBoxColumn";
            this.tsname10023DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq110023DataGridViewTextBoxColumn
            // 
            this.tsq110023DataGridViewTextBoxColumn.DataPropertyName = "ts_q1_10023";
            this.tsq110023DataGridViewTextBoxColumn.HeaderText = "Question 1";
            this.tsq110023DataGridViewTextBoxColumn.Name = "tsq110023DataGridViewTextBoxColumn";
            this.tsq110023DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq1answer10023DataGridViewTextBoxColumn
            // 
            this.tsq1answer10023DataGridViewTextBoxColumn.DataPropertyName = "ts_q1_answer_10023";
            this.tsq1answer10023DataGridViewTextBoxColumn.HeaderText = "Question 1 Answer";
            this.tsq1answer10023DataGridViewTextBoxColumn.Name = "tsq1answer10023DataGridViewTextBoxColumn";
            this.tsq1answer10023DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq210023DataGridViewTextBoxColumn
            // 
            this.tsq210023DataGridViewTextBoxColumn.DataPropertyName = "ts_q2_10023";
            this.tsq210023DataGridViewTextBoxColumn.HeaderText = "Question 2";
            this.tsq210023DataGridViewTextBoxColumn.Name = "tsq210023DataGridViewTextBoxColumn";
            this.tsq210023DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq2answer10023DataGridViewTextBoxColumn
            // 
            this.tsq2answer10023DataGridViewTextBoxColumn.DataPropertyName = "ts_q2_answer_10023";
            this.tsq2answer10023DataGridViewTextBoxColumn.HeaderText = "Question 2 Answer";
            this.tsq2answer10023DataGridViewTextBoxColumn.Name = "tsq2answer10023DataGridViewTextBoxColumn";
            this.tsq2answer10023DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq310023DataGridViewTextBoxColumn
            // 
            this.tsq310023DataGridViewTextBoxColumn.DataPropertyName = "ts_q3_10023";
            this.tsq310023DataGridViewTextBoxColumn.HeaderText = "Question 3 Answer";
            this.tsq310023DataGridViewTextBoxColumn.Name = "tsq310023DataGridViewTextBoxColumn";
            this.tsq310023DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq3answer10023DataGridViewTextBoxColumn
            // 
            this.tsq3answer10023DataGridViewTextBoxColumn.DataPropertyName = "ts_q3_answer_10023";
            this.tsq3answer10023DataGridViewTextBoxColumn.HeaderText = "Question 3 Answer";
            this.tsq3answer10023DataGridViewTextBoxColumn.Name = "tsq3answer10023DataGridViewTextBoxColumn";
            this.tsq3answer10023DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(CW.DAL.Test);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(869, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(868, 43);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(867, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(866, 103);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 510);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Name = "TestListForm";
            this.Text = "TestEditForm";
            this.Load += new System.EventHandler(this.TestListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsid10023DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsname10023DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq110023DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq1answer10023DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq210023DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq2answer10023DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq310023DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq3answer10023DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource testBindingSource;
    }
}