namespace Calendar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendar = new MonthCalendar();
            button1 = new Button();
            txtdateIni = new TextBox();
            txtdateFinal = new TextBox();
            btnPegaData = new Button();
            txtcurrentDate = new TextBox();
            txtMinute = new NumericUpDown();
            txtHour = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            txtStudent = new TextBox();
            label3 = new Label();
            button2 = new Button();
            ddweekday = new ComboBox();
            dataGridView1 = new DataGridView();
            txtEndContract = new Label();
            label4 = new Label();
            numMonthsEndContract = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMonthsEndContract).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(37, 19);
            monthCalendar.MaxSelectionCount = 30;
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(566, 149);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtdateIni
            // 
            txtdateIni.Location = new Point(369, 67);
            txtdateIni.Name = "txtdateIni";
            txtdateIni.Size = new Size(129, 27);
            txtdateIni.TabIndex = 3;
            // 
            // txtdateFinal
            // 
            txtdateFinal.Location = new Point(517, 67);
            txtdateFinal.Name = "txtdateFinal";
            txtdateFinal.Size = new Size(162, 27);
            txtdateFinal.TabIndex = 4;
            // 
            // btnPegaData
            // 
            btnPegaData.Location = new Point(37, 357);
            btnPegaData.Name = "btnPegaData";
            btnPegaData.Size = new Size(136, 29);
            btnPegaData.TabIndex = 5;
            btnPegaData.Text = "btnPegaData";
            btnPegaData.UseVisualStyleBackColor = true;
            btnPegaData.Click += btnPegaData_Click;
            // 
            // txtcurrentDate
            // 
            txtcurrentDate.Location = new Point(373, 115);
            txtcurrentDate.Name = "txtcurrentDate";
            txtcurrentDate.Size = new Size(125, 27);
            txtcurrentDate.TabIndex = 6;
            // 
            // txtMinute
            // 
            txtMinute.Location = new Point(106, 271);
            txtMinute.Name = "txtMinute";
            txtMinute.Size = new Size(89, 27);
            txtMinute.TabIndex = 10;
            // 
            // txtHour
            // 
            txtHour.Location = new Point(106, 238);
            txtHour.Name = "txtHour";
            txtHour.Size = new Size(89, 27);
            txtHour.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 242);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 12;
            label1.Text = "Hour:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 278);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 13;
            label2.Text = "Minute:";
            // 
            // txtStudent
            // 
            txtStudent.Location = new Point(422, 225);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(255, 27);
            txtStudent.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 232);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 15;
            label3.Text = "Student:";
            // 
            // button2
            // 
            button2.Location = new Point(37, 315);
            button2.Name = "button2";
            button2.Size = new Size(173, 36);
            button2.TabIndex = 17;
            button2.Text = "GetMonthSchedule";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ddweekday
            // 
            ddweekday.DropDownStyle = ComboBoxStyle.DropDownList;
            ddweekday.FormattingEnabled = true;
            ddweekday.Items.AddRange(new object[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            ddweekday.Location = new Point(882, 67);
            ddweekday.Name = "ddweekday";
            ddweekday.Size = new Size(151, 28);
            ddweekday.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(363, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(670, 227);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtEndContract
            // 
            txtEndContract.AutoSize = true;
            txtEndContract.Location = new Point(706, 44);
            txtEndContract.Name = "txtEndContract";
            txtEndContract.Size = new Size(97, 20);
            txtEndContract.TabIndex = 21;
            txtEndContract.Text = "End Contract:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(882, 44);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 22;
            label4.Text = "Week Day Class";
            // 
            // numMonthsEndContract
            // 
            numMonthsEndContract.Location = new Point(714, 70);
            numMonthsEndContract.Name = "numMonthsEndContract";
            numMonthsEndContract.Size = new Size(150, 27);
            numMonthsEndContract.TabIndex = 23;
            numMonthsEndContract.ValueChanged += numMonthsEndContract_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 613);
            Controls.Add(numMonthsEndContract);
            Controls.Add(label4);
            Controls.Add(txtEndContract);
            Controls.Add(dataGridView1);
            Controls.Add(ddweekday);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(txtStudent);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHour);
            Controls.Add(txtMinute);
            Controls.Add(txtcurrentDate);
            Controls.Add(btnPegaData);
            Controls.Add(txtdateFinal);
            Controls.Add(txtdateIni);
            Controls.Add(button1);
            Controls.Add(monthCalendar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)txtMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMonthsEndContract).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar;
        private Button button1;
        private TextBox txtdateIni;
        private TextBox txtdateFinal;
        private Button btnPegaData;
        private TextBox txtcurrentDate;
        private NumericUpDown txtMinute;
        private NumericUpDown txtHour;
        private Label label1;
        private Label label2;
        private TextBox txtStudent;
        private Label label3;
        private Button button2;
        private ComboBox ddweekday;
        private DataGridView dataGridView1;
        private Label txtEndContract;
        private Label label4;
        private NumericUpDown numMonthsEndContract;
    }
}