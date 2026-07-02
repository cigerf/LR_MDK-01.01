namespace WindowsFormsApp1.Delivery_Points
{
    partial class AddDeliveryPoint
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
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CanselButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressTextBox.Location = new System.Drawing.Point(183, 23);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 24);
            this.AddressTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адрес пункта выдачи";
            // 
            // CanselButton
            // 
            this.CanselButton.BackColor = System.Drawing.Color.Chartreuse;
            this.CanselButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CanselButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CanselButton.Location = new System.Drawing.Point(168, 75);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(127, 37);
            this.CanselButton.TabIndex = 11;
            this.CanselButton.Text = "Отмена";
            this.CanselButton.UseVisualStyleBackColor = false;
            this.CanselButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserButton.Location = new System.Drawing.Point(24, 75);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(138, 37);
            this.AddUserButton.TabIndex = 10;
            this.AddUserButton.Text = "Добавить";
            this.AddUserButton.UseVisualStyleBackColor = false;
            this.AddUserButton.Click += new System.EventHandler(this.AddPointButton_Click);
            // 
            // AddDeliveryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 150);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTextBox);
            this.Name = "AddDeliveryPoint";
            this.Text = "AddDeliveryPoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.Button AddUserButton;
    }
}