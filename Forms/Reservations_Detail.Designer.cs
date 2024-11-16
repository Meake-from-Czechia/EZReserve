namespace EZReserve
{
    partial class Reservations_Detail
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
            label_DescId = new Label();
            label_Id = new Label();
            label_DescCustomer = new Label();
            label_Customer = new Label();
            label_DescRoom = new Label();
            label_Room = new Label();
            label_DescFrom = new Label();
            label_From = new Label();
            label_DescTo = new Label();
            label_To = new Label();
            label_Line = new Label();
            button_Close = new Button();
            button_Detail = new Button();
            SuspendLayout();
            // 
            // label_DescId
            // 
            label_DescId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_DescId.AutoSize = true;
            label_DescId.Font = new Font("Segoe UI", 16F);
            label_DescId.Location = new Point(30, 34);
            label_DescId.Name = "label_DescId";
            label_DescId.Size = new Size(39, 30);
            label_DescId.TabIndex = 0;
            label_DescId.Text = "ID:";
            // 
            // label_Id
            // 
            label_Id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_Id.AutoSize = true;
            label_Id.Font = new Font("Segoe UI", 16F);
            label_Id.Location = new Point(132, 34);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(31, 30);
            label_Id.TabIndex = 1;
            label_Id.Text = "id";
            // 
            // label_DescCustomer
            // 
            label_DescCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_DescCustomer.AutoSize = true;
            label_DescCustomer.Font = new Font("Segoe UI", 16F);
            label_DescCustomer.Location = new Point(30, 64);
            label_DescCustomer.Name = "label_DescCustomer";
            label_DescCustomer.Size = new Size(102, 30);
            label_DescCustomer.TabIndex = 0;
            label_DescCustomer.Text = "Zákazník:";
            // 
            // label_Customer
            // 
            label_Customer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_Customer.AutoSize = true;
            label_Customer.Font = new Font("Segoe UI", 16F);
            label_Customer.Location = new Point(132, 64);
            label_Customer.Name = "label_Customer";
            label_Customer.Size = new Size(94, 30);
            label_Customer.TabIndex = 1;
            label_Customer.Text = "zakaznik";
            // 
            // label_DescRoom
            // 
            label_DescRoom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_DescRoom.AutoSize = true;
            label_DescRoom.Font = new Font("Segoe UI", 16F);
            label_DescRoom.Location = new Point(30, 94);
            label_DescRoom.Name = "label_DescRoom";
            label_DescRoom.Size = new Size(100, 30);
            label_DescRoom.TabIndex = 0;
            label_DescRoom.Text = "Místnost:";
            // 
            // label_Room
            // 
            label_Room.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_Room.AutoSize = true;
            label_Room.Font = new Font("Segoe UI", 16F);
            label_Room.Location = new Point(132, 94);
            label_Room.Name = "label_Room";
            label_Room.Size = new Size(94, 30);
            label_Room.TabIndex = 1;
            label_Room.Text = "mistnost";
            // 
            // label_DescFrom
            // 
            label_DescFrom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_DescFrom.AutoSize = true;
            label_DescFrom.Font = new Font("Segoe UI", 16F);
            label_DescFrom.Location = new Point(30, 124);
            label_DescFrom.Name = "label_DescFrom";
            label_DescFrom.Size = new Size(48, 30);
            label_DescFrom.TabIndex = 0;
            label_DescFrom.Text = "Od:";
            // 
            // label_From
            // 
            label_From.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_From.AutoSize = true;
            label_From.Font = new Font("Segoe UI", 16F);
            label_From.Location = new Point(132, 124);
            label_From.Name = "label_From";
            label_From.Size = new Size(39, 30);
            label_From.TabIndex = 1;
            label_From.Text = "od";
            // 
            // label_DescTo
            // 
            label_DescTo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_DescTo.AutoSize = true;
            label_DescTo.Font = new Font("Segoe UI", 16F);
            label_DescTo.Location = new Point(30, 154);
            label_DescTo.Name = "label_DescTo";
            label_DescTo.Size = new Size(46, 30);
            label_DescTo.TabIndex = 0;
            label_DescTo.Text = "Do:";
            // 
            // label_To
            // 
            label_To.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label_To.AutoSize = true;
            label_To.Font = new Font("Segoe UI", 16F);
            label_To.Location = new Point(132, 154);
            label_To.Name = "label_To";
            label_To.Size = new Size(39, 30);
            label_To.TabIndex = 1;
            label_To.Text = "do";
            // 
            // label_Line
            // 
            label_Line.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Line.AutoSize = true;
            label_Line.Location = new Point(-6, 184);
            label_Line.MaximumSize = new Size(630, 15);
            label_Line.Name = "label_Line";
            label_Line.Size = new Size(627, 15);
            label_Line.TabIndex = 3;
            label_Line.Text = "___________________________________________________________________________________________________________________________________________________________";
            // 
            // button_Close
            // 
            button_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Close.Location = new Point(347, 422);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(67, 23);
            button_Close.TabIndex = 4;
            button_Close.Text = "Zavřít";
            button_Close.UseVisualStyleBackColor = true;
            button_Close.Click += button_Close_Click;
            // 
            // button_Detail
            // 
            button_Detail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button_Detail.Font = new Font("Segoe UI", 12F);
            button_Detail.Location = new Point(110, 224);
            button_Detail.Name = "button_Detail";
            button_Detail.Size = new Size(187, 60);
            button_Detail.TabIndex = 5;
            button_Detail.Text = "Detail zákazníka";
            button_Detail.UseVisualStyleBackColor = true;
            button_Detail.Click += button_Detail_Click;
            // 
            // Reservations_Detail
            // 
            AcceptButton = button_Close;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_Close;
            ClientSize = new Size(426, 457);
            Controls.Add(button_Detail);
            Controls.Add(button_Close);
            Controls.Add(label_Line);
            Controls.Add(label_From);
            Controls.Add(label_DescFrom);
            Controls.Add(label_Customer);
            Controls.Add(label_To);
            Controls.Add(label_Room);
            Controls.Add(label_DescCustomer);
            Controls.Add(label_DescTo);
            Controls.Add(label_DescRoom);
            Controls.Add(label_Id);
            Controls.Add(label_DescId);
            MaximizeBox = false;
            MaximumSize = new Size(622, 9999);
            MinimumSize = new Size(340, 496);
            Name = "Reservations_Detail";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "EZReserve: Detail rezervace";
            Load += Reservations_Detail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_DescId;
        private Label label_Id;
        private Label label_DescCustomer;
        private Label label_Customer;
        private Label label_DescRoom;
        private Label label_Room;
        private Label label_DescFrom;
        private Label label_From;
        private Label label_DescTo;
        private Label label_To;
        private Label label_Line;
        private Button button_Close;
        private Button button_Detail;
    }
}