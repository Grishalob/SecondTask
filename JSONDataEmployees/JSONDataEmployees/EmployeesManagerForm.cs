using System.Windows.Forms;
using EmployeeToJSONTool.Models;

namespace JSONDataEmployees
{
    public partial class EmployeesManagerForm : Form
    {
        private string _filePath;
        private Manager _manager;
        public EmployeesManagerForm()
        {
            InitializeComponent();
            var fileDialog = new OpenFileDialog();
            _filePath = fileDialog.FileName;

            while (true)
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filePath = fileDialog.FileName;
                    break;
                }
            }

            _manager = new Manager(_filePath);
            InitDataGrid();
            RefreshData();
        }

        private void InitDataGrid()
        {
            var with = 150;
            var gridColumns = this.EmployeesGridView.Columns;
            gridColumns.Add(nameof(Employee.Guid), "Guid");
            gridColumns.Add(nameof(Employee.Name), "���");
            gridColumns.Add(nameof(Employee.Surmame), "�������");
            gridColumns.Add(nameof(Employee.IsMale), "���");
            gridColumns.Add(nameof(Employee.Age), "�������");
            gridColumns.Add(nameof(Employee.BirthDay), "���� ��������");
            gridColumns.Add(nameof(Employee.Division), "�������������");
            gridColumns.Add(nameof(Employee.WorkPost), "���������");

            for (int i = 0; i < this.EmployeesGridView.Columns.Count; i++)
                this.EmployeesGridView.Columns[i].Width = with;

            this.Width = with * gridColumns.Count + 50;
            this.EmployeesGridView.Width = this.Width;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            RefreshData();
        }

        private void RefreshData()
        {
            var grid = this.EmployeesGridView;
            grid.Rows.Clear();
            var employees = _manager.GetAllEmployees().Result;
            if (!employees.Any())
                return;

            grid.RowCount = employees.Count;

            for (int i = 0; i < grid.RowCount; i++)
            {
                PrintEmployee(i, employees[i]);
            }
        }

        private void PrintEmployee(int i, Employee employee)
        {
            if (employee == null)
                return;

            var grid = this.EmployeesGridView;
            grid.Rows[i].Cells[nameof(Employee.Guid)].Value = employee.Guid;
            grid.Rows[i].Cells[nameof(Employee.Name)].Value = employee.Name;
            grid.Rows[i].Cells[nameof(Employee.Surmame)].Value = employee.Surmame;
            grid.Rows[i].Cells[nameof(Employee.Age)].Value = employee.Age;
            grid.Rows[i].Cells[nameof(Employee.BirthDay)].Value = employee.BirthDay;
            grid.Rows[i].Cells[nameof(Employee.IsMale)].Value = employee.IsMale ? "�������" : "�������";
            grid.Rows[i].Cells[nameof(Employee.Division)].Value = employee.Division;
            grid.Rows[i].Cells[nameof(Employee.WorkPost)].Value = employee.WorkPost;
        }

        private void DeleteAllEmplsBttn_Click(object sender, EventArgs e)
        {
            var message = String.Empty;

            if (_manager.CleanAllEmployees())
            {
                message = "�������!"; RefreshData();
            }
            else message = "�� ������� ������� ���� �����������!";

            MessageBox.Show(message);
        }

        private void GenRandomEmployeeBtn_Click(object sender, EventArgs e)
        {
            var message = String.Empty;
            var randomEmployee = Generator.GenerateEmployee();

            if (_manager.AddEmployee(randomEmployee))
            {
                message = "������� �������� ��������� ���������!";
                RefreshData();
            }
            else message = "�� ������� �������� ���������� ����������!";
        }

        private void FindEmployeeBttn_Click(object sender, EventArgs e)
        {
            this.EmployeesGridView.Rows.Clear();
            Employee searchedEmployee;
            var message = String.Empty;

            if (_manager.TryGetEmployeeByGuid(GuidBox.Text, out searchedEmployee))
            {
                message = "��������� ������";
                PrintEmployee(0, searchedEmployee);
            }
            else message = "�� ������� �����";

            MessageBox.Show(message);
        }

        private void RemoveEmployee_Click(object sender, EventArgs e)
        {
            var message = String.Empty;

            if (_manager.RemoveEmployeeByGuid(Guid.Parse(GuidBox.Text)))
            {
                message = $"������� ������ ���������� � guid:{GuidBox.Text}!";
                RefreshData();
            }
            else message = "�� ������� ������� ����������!";

            MessageBox.Show(message);
        }

        private void ShowAllEmployeesBttn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void AddNewEmplBttn_Click(object sender, EventArgs e)
        {
            string message;
            var employee = new Employee()
            {
                Guid = Guid.NewGuid(),
                Name = nameBox.Text,
                Surmame = nameBox.Text,
                Division = divisionBox.Text,
                WorkPost = workPostBox.Text,
                IsMale = maleRadio.Checked,
                BirthDay = birthdayPicker.Value
            };

            if (_manager.AddEmployee(employee))
            {
                message = $"������� �������� {employee.Name} {employee.Surmame}!";
                RefreshData();
            }
            else message = "�� ������� �������� ������ ����������!";
        }
    }
}
