namespace LibraryDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.authorBookGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Location = new System.Drawing.Point(13, 13);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.RowTemplate.Height = 24;
            this.usersDataGrid.Size = new System.Drawing.Size(240, 255);
            this.usersDataGrid.TabIndex = 0;
            this.usersDataGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDataGrid_CellContentDoubleClick);
            // 
            // authorBookGrid
            // 
            this.authorBookGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.authorBookGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.authorBookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorBookGrid.Location = new System.Drawing.Point(287, 13);
            this.authorBookGrid.Name = "authorBookGrid";
            this.authorBookGrid.RowTemplate.Height = 24;
            this.authorBookGrid.Size = new System.Drawing.Size(568, 255);
            this.authorBookGrid.TabIndex = 1;
            this.authorBookGrid.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 283);
            this.Controls.Add(this.authorBookGrid);
            this.Controls.Add(this.usersDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBookGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.DataGridView authorBookGrid;
    }
}

