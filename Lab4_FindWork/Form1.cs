namespace Lab4_FindWork
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // �������� ��䳿 ��� ���� ������ � ListBox
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ��������� ������� ������
            string selectedJob = listBox1.SelectedItem?.ToString();
            // ��������� ��������� �������� �� ������� �������
            string selectedSalary = "";

            switch (selectedJob)
            {
                case "��������� �����������":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "���-���������":
                    comboBox1.SelectedIndex = 1;
                    break;
                case "���-��������":
                    comboBox1.SelectedIndex = 2;
                    break;
                case "��������� �����":
                    comboBox1.SelectedIndex = 3;
                    break;
            }

            // ������������ ������� �������� � ComboBox
            if (!string.IsNullOrEmpty(selectedSalary))
            {
                comboBox1.SelectedItem = selectedSalary;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ��������� �������� �������
            string selectedJob = listBox1.SelectedItem?.ToString();
            string selectedSalary = comboBox1.SelectedItem?.ToString();
            int experience = (int)numericUpDown1.Value;

            // �������� �� �������� �������� �������
            if (selectedJob != null && selectedSalary != null)
            {
                // ���������� �������� �� ����� ��������� �������� �� ����� ������
                double salary = double.Parse(selectedSalary) * Math.Pow(1.25, experience);

                // ��������� ���������� � �������� ����
                textBox1.Text = $"��� ������: {selectedJob}\r\n��������: {salary:C}\r\n���� ������: {experience} ����";
            }
            else
            {
                MessageBox.Show("���� �����, ������� ��� ������ �� ��������� ��������!");
            }
        }
    }
}
