namespace EZReserve
{
    partial class Customers_Modify
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
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            textBox_FirstName = new TextBox();
            label2 = new Label();
            textBox_LastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox_Email = new TextBox();
            textBox_Address = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox_City = new TextBox();
            textBox_PostalCode = new TextBox();
            button_Accept = new Button();
            button_Close = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Jméno:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // textBox_FirstName
            // 
            textBox_FirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_FirstName.Location = new Point(79, 32);
            textBox_FirstName.Name = "textBox_FirstName";
            textBox_FirstName.Size = new Size(255, 23);
            textBox_FirstName.TabIndex = 1;
            textBox_FirstName.Validating += textBox_FirstName_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Příjmení:";
            // 
            // textBox_LastName
            // 
            textBox_LastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_LastName.Location = new Point(79, 61);
            textBox_LastName.Name = "textBox_LastName";
            textBox_LastName.Size = new Size(255, 23);
            textBox_LastName.TabIndex = 2;
            textBox_LastName.Validating += textBox_LastName_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 0;
            label4.Text = "Adresa:";
            // 
            // textBox_Email
            // 
            textBox_Email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Email.Location = new Point(79, 90);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(255, 23);
            textBox_Email.TabIndex = 3;
            textBox_Email.Validating += textBox_Email_Validating;
            // 
            // textBox_Address
            // 
            textBox_Address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Address.Location = new Point(79, 119);
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(255, 23);
            textBox_Address.TabIndex = 4;
            textBox_Address.Validating += textBox_Address_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 151);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 0;
            label5.Text = "Město";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 180);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 0;
            label6.Text = "PSČ:";
            // 
            // textBox_City
            // 
            textBox_City.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_City.Location = new Point(79, 148);
            textBox_City.Name = "textBox_City";
            textBox_City.Size = new Size(255, 23);
            textBox_City.TabIndex = 5;
            textBox_City.Validating += textBox_City_Validating;
            // 
            // textBox_PostalCode
            // 
            textBox_PostalCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_PostalCode.Location = new Point(79, 177);
            textBox_PostalCode.Name = "textBox_PostalCode";
            textBox_PostalCode.Size = new Size(255, 23);
            textBox_PostalCode.TabIndex = 6;
            textBox_PostalCode.Validating += textBox_PostalCode_Validating;
            // 
            // button_Accept
            // 
            button_Accept.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Accept.Location = new Point(12, 241);
            button_Accept.Name = "button_Accept";
            button_Accept.Size = new Size(67, 23);
            button_Accept.TabIndex = 7;
            button_Accept.Text = "Potvrdit";
            button_Accept.UseVisualStyleBackColor = true;
            button_Accept.Click += button_Accept_Click;
            // 
            // button_Close
            // 
            button_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Close.Location = new Point(267, 241);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(67, 23);
            button_Close.TabIndex = 8;
            button_Close.Text = "Zrušit";
            button_Close.UseVisualStyleBackColor = true;
            button_Close.Click += button_Close_Click;
            // 
            // Customers_Modify
            // 
            AcceptButton = button_Accept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_Close;
            ClientSize = new Size(346, 276);
            Controls.Add(button_Close);
            Controls.Add(button_Accept);
            Controls.Add(textBox_PostalCode);
            Controls.Add(textBox_Address);
            Controls.Add(textBox_City);
            Controls.Add(textBox_LastName);
            Controls.Add(textBox_Email);
            Controls.Add(label6);
            Controls.Add(textBox_FirstName);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(700, 315);
            MinimumSize = new Size(362, 315);
            Name = "Customers_Modify";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "EZReserve: Úprava/Přidání zákazníka";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ErrorProvider errorProvider1;
        private TextBox textBox_PostalCode;
        private TextBox textBox_Address;
        private TextBox textBox_City;
        private TextBox textBox_LastName;
        private TextBox textBox_Email;
        private Label label6;
        private TextBox textBox_FirstName;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label3;
        private Button button_Close;
        private Button button_Accept;
    }
}