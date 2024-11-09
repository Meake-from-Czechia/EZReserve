namespace EZReserve
{
    partial class Customers_List
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
            dataGridView_Customers = new DataGridView();
            button_Detail = new Button();
            button_Add = new Button();
            button_Edit = new Button();
            button_Delete = new Button();
            button_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Customers).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Customers
            // 
            dataGridView_Customers.AllowUserToAddRows = false;
            dataGridView_Customers.AllowUserToDeleteRows = false;
            dataGridView_Customers.AllowUserToResizeRows = false;
            dataGridView_Customers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Customers.Location = new Point(12, 12);
            dataGridView_Customers.MultiSelect = false;
            dataGridView_Customers.Name = "dataGridView_Customers";
            dataGridView_Customers.ReadOnly = true;
            dataGridView_Customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Customers.Size = new Size(621, 377);
            dataGridView_Customers.TabIndex = 0;
            // 
            // button_Detail
            // 
            button_Detail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Detail.Location = new Point(639, 12);
            button_Detail.Name = "button_Detail";
            button_Detail.Size = new Size(187, 40);
            button_Detail.TabIndex = 1;
            button_Detail.Text = "Zobrazit";
            button_Detail.UseVisualStyleBackColor = true;
            button_Detail.Click += button_Detail_Click;
            // 
            // button_Add
            // 
            button_Add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Add.Location = new Point(639, 58);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(187, 40);
            button_Add.TabIndex = 2;
            button_Add.Text = "Přidat";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Edit
            // 
            button_Edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Edit.Location = new Point(639, 104);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(187, 40);
            button_Edit.TabIndex = 3;
            button_Edit.Text = "Upravit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Delete
            // 
            button_Delete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Delete.Location = new Point(639, 150);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(187, 40);
            button_Delete.TabIndex = 4;
            button_Delete.Text = "Smazat";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Exit
            // 
            button_Exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Exit.Location = new Point(639, 349);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(187, 40);
            button_Exit.TabIndex = 5;
            button_Exit.Text = "Zavřít";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // Customers_List
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_Exit;
            ClientSize = new Size(832, 401);
            Controls.Add(button_Exit);
            Controls.Add(button_Delete);
            Controls.Add(button_Edit);
            Controls.Add(button_Add);
            Controls.Add(button_Detail);
            Controls.Add(dataGridView_Customers);
            MinimumSize = new Size(661, 287);
            Name = "Customers_List";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "EZReserve: Seznam zákazníků";
            Load += Customers_List_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Customers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Customers;
        private Button button_Detail;
        private Button button_Add;
        private Button button_Edit;
        private Button button_Delete;
        private Button button_Exit;
    }
}