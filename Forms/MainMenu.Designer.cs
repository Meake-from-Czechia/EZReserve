namespace EZReserve
{
    partial class MainMenu
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
            button_Customers = new Button();
            button_Reporting = new Button();
            button_Reservations = new Button();
            button_Exit = new Button();
            SuspendLayout();
            // 
            // button_Customers
            // 
            button_Customers.Location = new Point(12, 107);
            button_Customers.Name = "button_Customers";
            button_Customers.Size = new Size(152, 61);
            button_Customers.TabIndex = 0;
            button_Customers.Text = "Zákazníci";
            button_Customers.UseVisualStyleBackColor = true;
            button_Customers.Click += button_Customers_Click;
            // 
            // button_Reporting
            // 
            button_Reporting.Location = new Point(348, 107);
            button_Reporting.Name = "button_Reporting";
            button_Reporting.Size = new Size(152, 61);
            button_Reporting.TabIndex = 2;
            button_Reporting.Text = "Reporting";
            button_Reporting.UseVisualStyleBackColor = true;
            button_Reporting.Click += button_Reporting_Click;
            // 
            // button_Reservations
            // 
            button_Reservations.Location = new Point(180, 107);
            button_Reservations.Name = "button_Reservations";
            button_Reservations.Size = new Size(152, 61);
            button_Reservations.TabIndex = 1;
            button_Reservations.Text = "Rezervace";
            button_Reservations.UseVisualStyleBackColor = true;
            button_Reservations.Click += button_Reservations_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(180, 186);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(152, 61);
            button_Exit.TabIndex = 3;
            button_Exit.Text = "Ukončit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_Exit;
            ClientSize = new Size(510, 259);
            Controls.Add(button_Reporting);
            Controls.Add(button_Exit);
            Controls.Add(button_Reservations);
            Controls.Add(button_Customers);
            MaximizeBox = false;
            MaximumSize = new Size(526, 298);
            MinimumSize = new Size(526, 298);
            Name = "MainMenu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EZReserve: Rozcestník";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Customers;
        private Button button_Reporting;
        private Button button_Reservations;
        private Button button_Exit;
    }
}