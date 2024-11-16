namespace EZReserve
{
    partial class Reservations_Modify
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
            components = new System.ComponentModel.Container();
            label_Customer = new Label();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_Accept = new Button();
            button_Close = new Button();
            comboBox_Customer = new ComboBox();
            comboBox_Room = new ComboBox();
            dateTimePicker_From = new DateTimePicker();
            dateTimePicker_To = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label_Customer
            // 
            label_Customer.AutoSize = true;
            label_Customer.Location = new Point(12, 35);
            label_Customer.Name = "label_Customer";
            label_Customer.Size = new Size(56, 15);
            label_Customer.TabIndex = 0;
            label_Customer.Text = "Zákazník:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 0;
            label2.Text = "Místnost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 0;
            label3.Text = "Od:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 0;
            label4.Text = "Do:";
            // 
            // button_Accept
            // 
            button_Accept.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Accept.Location = new Point(12, 151);
            button_Accept.Name = "button_Accept";
            button_Accept.Size = new Size(67, 23);
            button_Accept.TabIndex = 13;
            button_Accept.Text = "Potvrdit";
            button_Accept.UseVisualStyleBackColor = true;
            button_Accept.Click += button_Accept_Click;
            // 
            // button_Close
            // 
            button_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Close.Location = new Point(267, 151);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(67, 23);
            button_Close.TabIndex = 14;
            button_Close.Text = "Zrušit";
            button_Close.UseVisualStyleBackColor = true;
            button_Close.Click += button_Close_Click;
            // 
            // comboBox_Customer
            // 
            comboBox_Customer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Customer.FormattingEnabled = true;
            comboBox_Customer.Location = new Point(79, 32);
            comboBox_Customer.Name = "comboBox_Customer";
            comboBox_Customer.Size = new Size(255, 23);
            comboBox_Customer.TabIndex = 9;
            comboBox_Customer.Validating += comboBox_Customer_Validating;
            // 
            // comboBox_Room
            // 
            comboBox_Room.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Room.FormattingEnabled = true;
            comboBox_Room.Location = new Point(79, 61);
            comboBox_Room.Name = "comboBox_Room";
            comboBox_Room.Size = new Size(255, 23);
            comboBox_Room.TabIndex = 10;
            comboBox_Room.Validating += comboBox_Room_Validating;
            // 
            // dateTimePicker_From
            // 
            dateTimePicker_From.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker_From.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker_From.Format = DateTimePickerFormat.Custom;
            dateTimePicker_From.Location = new Point(79, 90);
            dateTimePicker_From.Name = "dateTimePicker_From";
            dateTimePicker_From.ShowUpDown = true;
            dateTimePicker_From.Size = new Size(255, 23);
            dateTimePicker_From.TabIndex = 11;
            dateTimePicker_From.Validating += dateTimePicker_From_Validating;
            // 
            // dateTimePicker_To
            // 
            dateTimePicker_To.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker_To.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker_To.Format = DateTimePickerFormat.Custom;
            dateTimePicker_To.Location = new Point(79, 119);
            dateTimePicker_To.Name = "dateTimePicker_To";
            dateTimePicker_To.ShowUpDown = true;
            dateTimePicker_To.Size = new Size(255, 23);
            dateTimePicker_To.TabIndex = 12;
            dateTimePicker_To.Validating += dateTimePicker_To_Validating;
            // 
            // Reservations_Modify
            // 
            AcceptButton = button_Accept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_Close;
            ClientSize = new Size(346, 186);
            Controls.Add(dateTimePicker_To);
            Controls.Add(dateTimePicker_From);
            Controls.Add(comboBox_Room);
            Controls.Add(comboBox_Customer);
            Controls.Add(button_Close);
            Controls.Add(button_Accept);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label_Customer);
            MaximizeBox = false;
            MaximumSize = new Size(700, 225);
            MinimumSize = new Size(362, 225);
            Name = "Reservations_Modify";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "EZReserve: Úprava/Přidání rezervace";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Customer;
        private ErrorProvider errorProvider1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button button_Close;
        private Button button_Accept;
        private ComboBox comboBox_Customer;
        private ComboBox comboBox_Room;
        private DateTimePicker dateTimePicker_To;
        private DateTimePicker dateTimePicker_From;
    }
}