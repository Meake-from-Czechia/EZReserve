namespace EZReserve
{
    partial class Reporting_Menu
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
            button_ExportCsv = new Button();
            button_ExportExcel = new Button();
            button_Graph = new Button();
            button_Exit = new Button();
            dateTimePicker_DateTo = new DateTimePicker();
            dateTimePicker_DateFrom = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_ExportCsv
            // 
            button_ExportCsv.Location = new Point(12, 90);
            button_ExportCsv.Name = "button_ExportCsv";
            button_ExportCsv.Size = new Size(118, 46);
            button_ExportCsv.TabIndex = 3;
            button_ExportCsv.Text = "Export do CSV";
            button_ExportCsv.UseVisualStyleBackColor = true;
            button_ExportCsv.Click += button_ExportCsv_Click;
            // 
            // button_ExportExcel
            // 
            button_ExportExcel.Location = new Point(172, 90);
            button_ExportExcel.Name = "button_ExportExcel";
            button_ExportExcel.Size = new Size(118, 46);
            button_ExportExcel.TabIndex = 4;
            button_ExportExcel.Text = "Export do Excelu";
            button_ExportExcel.UseVisualStyleBackColor = true;
            button_ExportExcel.Click += button_ExportExcel_Click;
            // 
            // button_Graph
            // 
            button_Graph.Location = new Point(12, 142);
            button_Graph.Name = "button_Graph";
            button_Graph.Size = new Size(278, 46);
            button_Graph.TabIndex = 5;
            button_Graph.Text = "Graf vytíženosti";
            button_Graph.UseVisualStyleBackColor = true;
            button_Graph.Click += button_Graph_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(215, 194);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(75, 23);
            button_Exit.TabIndex = 6;
            button_Exit.Text = "Zavřít";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // dateTimePicker_DateTo
            // 
            dateTimePicker_DateTo.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker_DateTo.Format = DateTimePickerFormat.Custom;
            dateTimePicker_DateTo.Location = new Point(154, 50);
            dateTimePicker_DateTo.Name = "dateTimePicker_DateTo";
            dateTimePicker_DateTo.Size = new Size(136, 23);
            dateTimePicker_DateTo.TabIndex = 2;
            // 
            // dateTimePicker_DateFrom
            // 
            dateTimePicker_DateFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker_DateFrom.Format = DateTimePickerFormat.Custom;
            dateTimePicker_DateFrom.Location = new Point(12, 50);
            dateTimePicker_DateFrom.Name = "dateTimePicker_DateFrom";
            dateTimePicker_DateFrom.Size = new Size(136, 23);
            dateTimePicker_DateFrom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Datum od:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 32);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Datum do:";
            // 
            // Reporting_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_Exit;
            ClientSize = new Size(302, 229);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker_DateFrom);
            Controls.Add(dateTimePicker_DateTo);
            Controls.Add(button_Exit);
            Controls.Add(button_Graph);
            Controls.Add(button_ExportExcel);
            Controls.Add(button_ExportCsv);
            MaximizeBox = false;
            MaximumSize = new Size(318, 268);
            MinimumSize = new Size(318, 268);
            Name = "Reporting_Menu";
            Text = "Reporting_Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_ExportCsv;
        private Button button_ExportExcel;
        private Button button_Graph;
        private Button button_Exit;
        private DateTimePicker dateTimePicker_DateTo;
        private DateTimePicker dateTimePicker_DateFrom;
        private Label label1;
        private Label label2;
    }
}