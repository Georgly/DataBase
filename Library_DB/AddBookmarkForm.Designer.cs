namespace Library_DB
{
    partial class AddBookmarkForm
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
            this.okBt = new System.Windows.Forms.Button();
            this.cancelBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pageTB = new System.Windows.Forms.TextBox();
            this.booksDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // okBt
            // 
            this.okBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBt.Location = new System.Drawing.Point(234, 202);
            this.okBt.Name = "okBt";
            this.okBt.Size = new System.Drawing.Size(75, 29);
            this.okBt.TabIndex = 0;
            this.okBt.Text = "OK";
            this.okBt.UseVisualStyleBackColor = true;
            this.okBt.Click += new System.EventHandler(this.okBt_Click);
            // 
            // cancelBt
            // 
            this.cancelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBt.Location = new System.Drawing.Point(352, 202);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(75, 29);
            this.cancelBt.TabIndex = 1;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Page";
            // 
            // pageTB
            // 
            this.pageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTB.Location = new System.Drawing.Point(60, 202);
            this.pageTB.Name = "pageTB";
            this.pageTB.Size = new System.Drawing.Size(100, 26);
            this.pageTB.TabIndex = 3;
            // 
            // booksDataGrid
            // 
            this.booksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGrid.Location = new System.Drawing.Point(13, 13);
            this.booksDataGrid.Name = "booksDataGrid";
            this.booksDataGrid.RowTemplate.Height = 24;
            this.booksDataGrid.Size = new System.Drawing.Size(414, 170);
            this.booksDataGrid.TabIndex = 4;
            // 
            // AddBookmarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 247);
            this.Controls.Add(this.booksDataGrid);
            this.Controls.Add(this.pageTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBt);
            this.Controls.Add(this.okBt);
            this.Name = "AddBookmarkForm";
            this.Text = "AddBookmarkForm";
            this.Load += new System.EventHandler(this.AddBookmarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBt;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pageTB;
        private System.Windows.Forms.DataGridView booksDataGrid;
    }
}