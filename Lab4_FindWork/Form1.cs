namespace Lab4_FindWork
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // Обробник події для зміни вибору у ListBox
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отримання вибраної професії
            string selectedJob = listBox1.SelectedItem?.ToString();
            // Знаходимо початкову зарплату за обраною професією
            string selectedSalary = "";

            switch (selectedJob)
            {
                case "системний адміністратор":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "веб-програміст":
                    comboBox1.SelectedIndex = 1;
                    break;
                case "веб-дизайнер":
                    comboBox1.SelectedIndex = 2;
                    break;
                case "модератор сайтів":
                    comboBox1.SelectedIndex = 3;
                    break;
            }

            // Встановлення вибраної зарплати у ComboBox
            if (!string.IsNullOrEmpty(selectedSalary))
            {
                comboBox1.SelectedItem = selectedSalary;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримання введених значень
            string selectedJob = listBox1.SelectedItem?.ToString();
            string selectedSalary = comboBox1.SelectedItem?.ToString();
            int experience = (int)numericUpDown1.Value;

            // Перевірка на наявність вибраних значень
            if (selectedJob != null && selectedSalary != null)
            {
                // Обчислення зарплати на основі початкової зарплати та стажу роботи
                double salary = double.Parse(selectedSalary) * Math.Pow(1.25, experience);

                // Виведення результатів в текстове поле
                textBox1.Text = $"Тип роботи: {selectedJob}\r\nЗарплата: {salary:C}\r\nСтаж роботи: {experience} років";
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть тип роботи та початкову зарплату!");
            }
        }
    }
}
