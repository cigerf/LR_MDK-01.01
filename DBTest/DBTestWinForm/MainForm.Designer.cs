namespace DBTestWinForm
{
    partial class MainForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.CreateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 277);
            this.dataGridView.TabIndex = 0;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(158, 310);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(105, 45);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Добавить";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(269, 310);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 45);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(380, 310);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(105, 45);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(47, 310);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(105, 45);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button editButton;
    }
}

