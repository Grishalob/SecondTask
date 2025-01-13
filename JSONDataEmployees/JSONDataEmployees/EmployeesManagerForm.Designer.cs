namespace JSONDataEmployees
{
    partial class EmployeesManagerForm
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
            EmployeesGridView = new DataGridView();
            DeleteAllEmplsBttn = new Button();
            FindEmployeeBttn = new Button();
            GuidLabel = new Label();
            GuidBox = new TextBox();
            GenRandomEmployeeBtn = new Button();
            RemoveEmployee = new Button();
            groupBox1 = new GroupBox();
            ShowAllEmployeesBttn = new Button();
            groupBox2 = new GroupBox();
            AddNewEmplBttn = new Button();
            femaleRadio = new RadioButton();
            maleRadio = new RadioButton();
            workPostBox = new TextBox();
            label5 = new Label();
            divisionBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            birthdayPicker = new DateTimePicker();
            label2 = new Label();
            surnameBox = new TextBox();
            Surname = new Label();
            nameBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)EmployeesGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // EmployeesGridView
            // 
            EmployeesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeesGridView.Location = new Point(0, 3);
            EmployeesGridView.Name = "EmployeesGridView";
            EmployeesGridView.Size = new Size(1184, 214);
            EmployeesGridView.TabIndex = 0;
            // 
            // DeleteAllEmplsBttn
            // 
            DeleteAllEmplsBttn.Location = new Point(6, 272);
            DeleteAllEmplsBttn.Name = "DeleteAllEmplsBttn";
            DeleteAllEmplsBttn.Size = new Size(377, 38);
            DeleteAllEmplsBttn.TabIndex = 1;
            DeleteAllEmplsBttn.Text = "Удалить всех сотрудников";
            DeleteAllEmplsBttn.UseVisualStyleBackColor = true;
            DeleteAllEmplsBttn.Click += DeleteAllEmplsBttn_Click;
            // 
            // FindEmployeeBttn
            // 
            FindEmployeeBttn.Location = new Point(6, 47);
            FindEmployeeBttn.Name = "FindEmployeeBttn";
            FindEmployeeBttn.Size = new Size(424, 27);
            FindEmployeeBttn.TabIndex = 2;
            FindEmployeeBttn.Text = "Найти сотрудника";
            FindEmployeeBttn.UseVisualStyleBackColor = true;
            FindEmployeeBttn.Click += FindEmployeeBttn_Click;
            // 
            // GuidLabel
            // 
            GuidLabel.AutoSize = true;
            GuidLabel.Location = new Point(6, 21);
            GuidLabel.Name = "GuidLabel";
            GuidLabel.Size = new Size(32, 15);
            GuidLabel.TabIndex = 3;
            GuidLabel.Text = "Guid";
            // 
            // GuidBox
            // 
            GuidBox.Location = new Point(44, 18);
            GuidBox.Name = "GuidBox";
            GuidBox.Size = new Size(386, 23);
            GuidBox.TabIndex = 4;
            // 
            // GenRandomEmployeeBtn
            // 
            GenRandomEmployeeBtn.Location = new Point(825, 225);
            GenRandomEmployeeBtn.Name = "GenRandomEmployeeBtn";
            GenRandomEmployeeBtn.Size = new Size(359, 36);
            GenRandomEmployeeBtn.TabIndex = 5;
            GenRandomEmployeeBtn.Text = "Сгенерировать случайного сотрудника";
            GenRandomEmployeeBtn.UseVisualStyleBackColor = true;
            GenRandomEmployeeBtn.Click += GenRandomEmployeeBtn_Click;
            // 
            // RemoveEmployee
            // 
            RemoveEmployee.Location = new Point(6, 80);
            RemoveEmployee.Name = "RemoveEmployee";
            RemoveEmployee.Size = new Size(424, 27);
            RemoveEmployee.TabIndex = 6;
            RemoveEmployee.Text = "Удалить сотрудника";
            RemoveEmployee.UseVisualStyleBackColor = true;
            RemoveEmployee.Click += RemoveEmployee_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GuidLabel);
            groupBox1.Controls.Add(RemoveEmployee);
            groupBox1.Controls.Add(GuidBox);
            groupBox1.Controls.Add(FindEmployeeBttn);
            groupBox1.Location = new Point(383, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 119);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск и удаление";
            // 
            // ShowAllEmployeesBttn
            // 
            ShowAllEmployeesBttn.Location = new Point(6, 225);
            ShowAllEmployeesBttn.Name = "ShowAllEmployeesBttn";
            ShowAllEmployeesBttn.Size = new Size(377, 38);
            ShowAllEmployeesBttn.TabIndex = 8;
            ShowAllEmployeesBttn.Text = "Показать всех сотрудников";
            ShowAllEmployeesBttn.UseVisualStyleBackColor = true;
            ShowAllEmployeesBttn.Click += ShowAllEmployeesBttn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(AddNewEmplBttn);
            groupBox2.Controls.Add(femaleRadio);
            groupBox2.Controls.Add(maleRadio);
            groupBox2.Controls.Add(workPostBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(divisionBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(birthdayPicker);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(surnameBox);
            groupBox2.Controls.Add(Surname);
            groupBox2.Controls.Add(nameBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(320, 350);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(541, 273);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Добавление сотрудника";
            // 
            // AddNewEmplBttn
            // 
            AddNewEmplBttn.Location = new Point(107, 223);
            AddNewEmplBttn.Name = "AddNewEmplBttn";
            AddNewEmplBttn.Size = new Size(359, 36);
            AddNewEmplBttn.TabIndex = 17;
            AddNewEmplBttn.Text = "Добавить сотрудника";
            AddNewEmplBttn.UseVisualStyleBackColor = true;
            AddNewEmplBttn.Click += AddNewEmplBttn_Click;
            // 
            // femaleRadio
            // 
            femaleRadio.AutoSize = true;
            femaleRadio.Location = new Point(193, 91);
            femaleRadio.Name = "femaleRadio";
            femaleRadio.Size = new Size(73, 19);
            femaleRadio.TabIndex = 16;
            femaleRadio.TabStop = true;
            femaleRadio.Text = "женский";
            femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            maleRadio.AutoSize = true;
            maleRadio.Location = new Point(79, 91);
            maleRadio.Name = "maleRadio";
            maleRadio.Size = new Size(75, 19);
            maleRadio.TabIndex = 15;
            maleRadio.TabStop = true;
            maleRadio.Text = "мужской";
            maleRadio.UseVisualStyleBackColor = true;
            // 
            // workPostBox
            // 
            workPostBox.Location = new Point(114, 194);
            workPostBox.Name = "workPostBox";
            workPostBox.Size = new Size(386, 23);
            workPostBox.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 202);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 13;
            label5.Text = "Должность";
            // 
            // divisionBox
            // 
            divisionBox.Location = new Point(114, 157);
            divisionBox.Name = "divisionBox";
            divisionBox.Size = new Size(386, 23);
            divisionBox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 165);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 11;
            label4.Text = "Подразделение";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 128);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 10;
            label3.Text = "Дата рождения";
            // 
            // birthdayPicker
            // 
            birthdayPicker.Location = new Point(126, 122);
            birthdayPicker.Name = "birthdayPicker";
            birthdayPicker.Size = new Size(200, 23);
            birthdayPicker.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 8;
            label2.Text = "Пол";
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(79, 52);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(386, 23);
            surnameBox.TabIndex = 7;
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Location = new Point(15, 64);
            Surname.Name = "Surname";
            Surname.Size = new Size(58, 15);
            Surname.TabIndex = 6;
            Surname.Text = "Фамилия";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(79, 23);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(379, 23);
            nameBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Имя";
            // 
            // EmployeesManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 658);
            Controls.Add(groupBox2);
            Controls.Add(ShowAllEmployeesBttn);
            Controls.Add(groupBox1);
            Controls.Add(GenRandomEmployeeBtn);
            Controls.Add(DeleteAllEmplsBttn);
            Controls.Add(EmployeesGridView);
            Name = "EmployeesManagerForm";
            Text = "Управление сотрудниками";
            ((System.ComponentModel.ISupportInitialize)EmployeesGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView EmployeesGridView;
        private Button DeleteAllEmplsBttn;
        private Button FindEmployeeBttn;
        private Label GuidLabel;
        private TextBox GuidBox;
        private Button GenRandomEmployeeBtn;
        private Button RemoveEmployee;
        private GroupBox groupBox1;
        private Button ShowAllEmployeesBttn;
        private GroupBox groupBox2;
        private Label label3;
        private DateTimePicker birthdayPicker;
        private Label label2;
        private TextBox surnameBox;
        private Label Surname;
        private TextBox nameBox;
        private Label label1;
        private TextBox divisionBox;
        private Label label4;
        private TextBox workPostBox;
        private Label label5;
        private RadioButton femaleRadio;
        private RadioButton maleRadio;
        private Button AddNewEmplBttn;
    }
}
