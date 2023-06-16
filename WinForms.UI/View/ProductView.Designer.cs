namespace UI.View {
    partial class ProductView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ProductsTab = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.DetailTab = new System.Windows.Forms.TabPage();
            this.QuentityTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PriceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.ProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.DetailTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe WinForms.UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ProductsTab);
            this.MainTabControl.Controls.Add(this.DetailTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 51);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(944, 450);
            this.MainTabControl.TabIndex = 1;
            // 
            // ProductsTab
            // 
            this.ProductsTab.Controls.Add(this.DeleteButton);
            this.ProductsTab.Controls.Add(this.EditButton);
            this.ProductsTab.Controls.Add(this.AddButton);
            this.ProductsTab.Controls.Add(this.ProductGridView);
            this.ProductsTab.Location = new System.Drawing.Point(4, 24);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsTab.Size = new System.Drawing.Size(936, 422);
            this.ProductsTab.TabIndex = 0;
            this.ProductsTab.Text = "Products";
            this.ProductsTab.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(844, 73);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(844, 44);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(844, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(8, 6);
            this.ProductGridView.MultiSelect = false;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.RowTemplate.Height = 25;
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridView.Size = new System.Drawing.Size(817, 408);
            this.ProductGridView.TabIndex = 0;
            // 
            // DetailTab
            // 
            this.DetailTab.Controls.Add(this.QuentityTextBox);
            this.DetailTab.Controls.Add(this.PriceTextBox);
            this.DetailTab.Controls.Add(this.CancelButton);
            this.DetailTab.Controls.Add(this.SaveButton);
            this.DetailTab.Controls.Add(this.label6);
            this.DetailTab.Controls.Add(this.label5);
            this.DetailTab.Controls.Add(this.DateTimePicker);
            this.DetailTab.Controls.Add(this.label4);
            this.DetailTab.Controls.Add(this.ProductNameTextBox);
            this.DetailTab.Controls.Add(this.label3);
            this.DetailTab.Controls.Add(this.ProductIdTextBox);
            this.DetailTab.Controls.Add(this.label2);
            this.DetailTab.Location = new System.Drawing.Point(4, 24);
            this.DetailTab.Name = "DetailTab";
            this.DetailTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailTab.Size = new System.Drawing.Size(936, 422);
            this.DetailTab.TabIndex = 1;
            this.DetailTab.Text = "Detail";
            this.DetailTab.UseVisualStyleBackColor = true;
            // 
            // QuentityTextBox
            // 
            this.QuentityTextBox.Location = new System.Drawing.Point(26, 227);
            this.QuentityTextBox.Mask = "00000";
            this.QuentityTextBox.Name = "QuentityTextBox";
            this.QuentityTextBox.Size = new System.Drawing.Size(202, 23);
            this.QuentityTextBox.TabIndex = 13;
            this.QuentityTextBox.ValidatingType = typeof(int);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(26, 286);
            this.PriceTextBox.Mask = "000000.000";
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(202, 23);
            this.PriceTextBox.TabIndex = 12;
            this.PriceTextBox.ValidatingType = typeof(int);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(72, 323);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(153, 323);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe WinForms.UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Product Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe WinForms.UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quentity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(28, 168);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.DateTimePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe WinForms.UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Receipt Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(28, 109);
            this.ProductNameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.ProductNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe WinForms.UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.Enabled = false;
            this.ProductIdTextBox.Location = new System.Drawing.Point(28, 50);
            this.ProductIdTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(200, 23);
            this.ProductIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe WinForms.UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.ProductsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.DetailTab.ResumeLayout(false);
            this.DetailTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl MainTabControl;
        private TabPage ProductsTab;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private DataGridView ProductGridView;
        private TabPage DetailTab;
        private DateTimePicker DateTimePicker;
        private Label label4;
        private TextBox ProductNameTextBox;
        private Label label3;
        private TextBox ProductIdTextBox;
        private Label label2;
        private Button CancelButton;
        private Button SaveButton;
        private Label label6;
        private Label label5;
        private MaskedTextBox QuentityTextBox;
        private MaskedTextBox PriceTextBox;
    }
}