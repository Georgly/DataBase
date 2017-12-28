namespace Library_DB
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
            this.removeBookmarkBt = new System.Windows.Forms.Button();
            this.removeUserBt = new System.Windows.Forms.Button();
            this.addBookmarkBt = new System.Windows.Forms.Button();
            this.addUserBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookmarkDataGrid = new System.Windows.Forms.DataGridView();
            this.usersDataGrid = new System.Windows.Forms.DataGridView();
            this.addBookBt = new System.Windows.Forms.Button();
            this.editBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // removeBookmarkBt
            // 
            this.removeBookmarkBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBookmarkBt.Location = new System.Drawing.Point(700, 295);
            this.removeBookmarkBt.Name = "removeBookmarkBt";
            this.removeBookmarkBt.Size = new System.Drawing.Size(108, 52);
            this.removeBookmarkBt.TabIndex = 15;
            this.removeBookmarkBt.Text = "Remove bookmark";
            this.removeBookmarkBt.UseVisualStyleBackColor = true;
            this.removeBookmarkBt.Click += new System.EventHandler(this.removeBookmarkBt_Click);
            // 
            // removeUserBt
            // 
            this.removeUserBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUserBt.Location = new System.Drawing.Point(126, 295);
            this.removeUserBt.Name = "removeUserBt";
            this.removeUserBt.Size = new System.Drawing.Size(108, 52);
            this.removeUserBt.TabIndex = 14;
            this.removeUserBt.Text = "Remove user";
            this.removeUserBt.UseVisualStyleBackColor = true;
            this.removeUserBt.Click += new System.EventHandler(this.removeUserBt_Click);
            // 
            // addBookmarkBt
            // 
            this.addBookmarkBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookmarkBt.Location = new System.Drawing.Point(586, 295);
            this.addBookmarkBt.Name = "addBookmarkBt";
            this.addBookmarkBt.Size = new System.Drawing.Size(108, 52);
            this.addBookmarkBt.TabIndex = 13;
            this.addBookmarkBt.Text = "Add bookmark";
            this.addBookmarkBt.UseVisualStyleBackColor = true;
            this.addBookmarkBt.Click += new System.EventHandler(this.addBookmarkBt_Click);
            // 
            // addUserBt
            // 
            this.addUserBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBt.Location = new System.Drawing.Point(12, 295);
            this.addUserBt.Name = "addUserBt";
            this.addUserBt.Size = new System.Drawing.Size(108, 52);
            this.addUserBt.TabIndex = 12;
            this.addUserBt.Text = "Add user";
            this.addUserBt.UseVisualStyleBackColor = true;
            this.addUserBt.Click += new System.EventHandler(this.addUserBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bookmarks";
            // 
            // bookmarkDataGrid
            // 
            this.bookmarkDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.bookmarkDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.bookmarkDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookmarkDataGrid.Location = new System.Drawing.Point(586, 34);
            this.bookmarkDataGrid.Name = "bookmarkDataGrid";
            this.bookmarkDataGrid.RowTemplate.Height = 24;
            this.bookmarkDataGrid.Size = new System.Drawing.Size(568, 255);
            this.bookmarkDataGrid.TabIndex = 9;
            // 
            // usersDataGrid
            // 
            this.usersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.usersDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.usersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGrid.Location = new System.Drawing.Point(12, 34);
            this.usersDataGrid.Name = "usersDataGrid";
            this.usersDataGrid.RowTemplate.Height = 24;
            this.usersDataGrid.Size = new System.Drawing.Size(568, 255);
            this.usersDataGrid.TabIndex = 8;
            this.usersDataGrid.DoubleClick += new System.EventHandler(this.usersDataGrid_DoubleClick);
            // 
            // addBookBt
            // 
            this.addBookBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBt.Location = new System.Drawing.Point(240, 295);
            this.addBookBt.Name = "addBookBt";
            this.addBookBt.Size = new System.Drawing.Size(108, 52);
            this.addBookBt.TabIndex = 16;
            this.addBookBt.Text = "Add book";
            this.addBookBt.UseVisualStyleBackColor = true;
            this.addBookBt.Click += new System.EventHandler(this.addBook_Click);
            // 
            // editBt
            // 
            this.editBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBt.Location = new System.Drawing.Point(814, 296);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(108, 52);
            this.editBt.TabIndex = 17;
            this.editBt.Text = "Edit bookmark";
            this.editBt.UseVisualStyleBackColor = true;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 356);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.addBookBt);
            this.Controls.Add(this.removeBookmarkBt);
            this.Controls.Add(this.removeUserBt);
            this.Controls.Add(this.addBookmarkBt);
            this.Controls.Add(this.addUserBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookmarkDataGrid);
            this.Controls.Add(this.usersDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeBookmarkBt;
        private System.Windows.Forms.Button removeUserBt;
        private System.Windows.Forms.Button addBookmarkBt;
        private System.Windows.Forms.Button addUserBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bookmarkDataGrid;
        private System.Windows.Forms.DataGridView usersDataGrid;
        private System.Windows.Forms.Button addBookBt;
        private System.Windows.Forms.Button editBt;
    }
}

