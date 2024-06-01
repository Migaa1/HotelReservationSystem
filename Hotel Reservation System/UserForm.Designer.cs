namespace Hotel_Reservation_System
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxAvailableRooms = new System.Windows.Forms.ListBox();
            this.hotelReservationDBDataSet = new Hotel_Reservation_System.HotelReservationDBDataSet();
            this.hotelReservationDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonReserve);
            this.tabPage1.Controls.Add(this.labelEnd);
            this.tabPage1.Controls.Add(this.labelStart);
            this.tabPage1.Controls.Add(this.dateTimePickerStartDate);
            this.tabPage1.Controls.Add(this.dateTimePickerEndDate);
            this.tabPage1.Controls.Add(this.listBoxAvailableRooms);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Available Rooms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxReservations);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Reservations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxAvailableRooms
            // 
            this.listBoxAvailableRooms.FormattingEnabled = true;
            this.listBoxAvailableRooms.Location = new System.Drawing.Point(8, 6);
            this.listBoxAvailableRooms.Name = "listBoxAvailableRooms";
            this.listBoxAvailableRooms.Size = new System.Drawing.Size(271, 407);
            this.listBoxAvailableRooms.TabIndex = 0;
            // 
            // hotelDBDataSet
            // 
            this.hotelReservationDBDataSet.DataSetName = "HotelReservationDBDataSet";
            this.hotelReservationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelDBDataSetBindingSource
            // 
            this.hotelReservationDBDataSetBindingSource.DataSource = this.hotelReservationDBDataSet;
            this.hotelReservationDBDataSetBindingSource.Position = 0;
            // 
            // listBoxReservations
            // 
            this.listBoxReservations.FormattingEnabled = true;
            this.listBoxReservations.Location = new System.Drawing.Point(6, 6);
            this.listBoxReservations.Name = "listBoxReservations";
            this.listBoxReservations.Size = new System.Drawing.Size(778, 407);
            this.listBoxReservations.TabIndex = 0;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(571, 51);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 1;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(324, 51);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 2;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(324, 19);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(55, 13);
            this.labelStart.TabIndex = 3;
            this.labelStart.Text = "Start Date";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(571, 18);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(52, 13);
            this.labelEnd.TabIndex = 4;
            this.labelEnd.Text = "End Date";
            // 
            // buttonReserve
            // 
            this.buttonReserve.Location = new System.Drawing.Point(444, 293);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(179, 45);
            this.buttonReserve.TabIndex = 5;
            this.buttonReserve.Text = "Reserve";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "UserForm";
            this.Text = "User Panel";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxAvailableRooms;
        private HotelReservationDBDataSet hotelReservationDBDataSet;
        private System.Windows.Forms.BindingSource hotelReservationDBDataSetBindingSource;
        private System.Windows.Forms.ListBox listBoxReservations;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button buttonReserve;
    }
}