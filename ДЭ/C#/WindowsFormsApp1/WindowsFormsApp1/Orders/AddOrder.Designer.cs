namespace WindowsFormsApp1.Orders
{
    partial class AddOrder
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
            this.CanselButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.OrderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClientFullNameTextBox = new System.Windows.Forms.TextBox();
            this.PickupCodeTextBox = new System.Windows.Forms.TextBox();
            this.OrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PickupPointAddressComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CanselButton
            // 
            this.CanselButton.BackColor = System.Drawing.Color.Chartreuse;
            this.CanselButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CanselButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CanselButton.Location = new System.Drawing.Point(174, 248);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(127, 37);
            this.CanselButton.TabIndex = 11;
            this.CanselButton.Text = "Отмена";
            this.CanselButton.UseVisualStyleBackColor = false;
            this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderButton.Location = new System.Drawing.Point(30, 248);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(138, 37);
            this.AddOrderButton.TabIndex = 10;
            this.AddOrderButton.Text = "Добавить";
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // OrderDateDateTimePicker
            // 
            this.OrderDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateDateTimePicker.Location = new System.Drawing.Point(174, 54);
            this.OrderDateDateTimePicker.Name = "OrderDateDateTimePicker";
            this.OrderDateDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.OrderDateDateTimePicker.TabIndex = 13;
            // 
            // DeliveryDateDateTimePicker
            // 
            this.DeliveryDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryDateDateTimePicker.Location = new System.Drawing.Point(174, 83);
            this.DeliveryDateDateTimePicker.Name = "DeliveryDateDateTimePicker";
            this.DeliveryDateDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.DeliveryDateDateTimePicker.TabIndex = 14;
            // 
            // ClientFullNameTextBox
            // 
            this.ClientFullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientFullNameTextBox.Location = new System.Drawing.Point(174, 140);
            this.ClientFullNameTextBox.Name = "ClientFullNameTextBox";
            this.ClientFullNameTextBox.Size = new System.Drawing.Size(200, 24);
            this.ClientFullNameTextBox.TabIndex = 16;
            // 
            // PickupCodeTextBox
            // 
            this.PickupCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PickupCodeTextBox.Location = new System.Drawing.Point(174, 170);
            this.PickupCodeTextBox.Name = "PickupCodeTextBox";
            this.PickupCodeTextBox.Size = new System.Drawing.Size(200, 24);
            this.PickupCodeTextBox.TabIndex = 17;
            // 
            // OrderStatusComboBox
            // 
            this.OrderStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderStatusComboBox.FormattingEnabled = true;
            this.OrderStatusComboBox.Items.AddRange(new object[] {
            "Новый",
            "Завершён"});
            this.OrderStatusComboBox.Location = new System.Drawing.Point(172, 200);
            this.OrderStatusComboBox.Name = "OrderStatusComboBox";
            this.OrderStatusComboBox.Size = new System.Drawing.Size(202, 26);
            this.OrderStatusComboBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Номер заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Дата заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Дата доставки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Адрес пункта выдачи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Код для получения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Статус заказа";
            // 
            // OrderNumberNumericUpDown
            // 
            this.OrderNumberNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderNumberNumericUpDown.Location = new System.Drawing.Point(174, 24);
            this.OrderNumberNumericUpDown.Name = "OrderNumberNumericUpDown";
            this.OrderNumberNumericUpDown.Size = new System.Drawing.Size(200, 24);
            this.OrderNumberNumericUpDown.TabIndex = 26;
            // 
            // PickupPointAddressComboBox
            // 
            this.PickupPointAddressComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PickupPointAddressComboBox.FormattingEnabled = true;
            this.PickupPointAddressComboBox.Location = new System.Drawing.Point(174, 110);
            this.PickupPointAddressComboBox.Name = "PickupPointAddressComboBox";
            this.PickupPointAddressComboBox.Size = new System.Drawing.Size(200, 26);
            this.PickupPointAddressComboBox.TabIndex = 27;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 321);
            this.Controls.Add(this.PickupPointAddressComboBox);
            this.Controls.Add(this.OrderNumberNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderStatusComboBox);
            this.Controls.Add(this.PickupCodeTextBox);
            this.Controls.Add(this.ClientFullNameTextBox);
            this.Controls.Add(this.DeliveryDateDateTimePicker);
            this.Controls.Add(this.OrderDateDateTimePicker);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.AddOrderButton);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            ((System.ComponentModel.ISupportInitialize)(this.OrderNumberNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.DateTimePicker OrderDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker DeliveryDateDateTimePicker;
        private System.Windows.Forms.TextBox ClientFullNameTextBox;
        private System.Windows.Forms.TextBox PickupCodeTextBox;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown OrderNumberNumericUpDown;
        private System.Windows.Forms.ComboBox PickupPointAddressComboBox;
    }
}