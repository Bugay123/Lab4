namespace Lab4
{
    public partial class Form1 : Form
    {
        private List<string> cities = new List<string>();
        public Form1()
        {
            InitializeComponent();
            InitializeCitiesComboBox();
        }

        private void InitializeCitiesComboBox()
        {
            // Додаємо початкові міста до списку
            cities.Add("Київ");
            cities.Add("Львів");
            cities.Add("Харків");
            cities.Add("Одеса");

            // Додаємо міста зі списку до ComboBox
            foreach (string city in cities)
            {
                comboBox1.Items.Add(city);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCity();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddCity();
            }
        }

        private void AddCity()
        {
            string newCity = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(newCity))
            {
                // Перевіряємо, чи вже існує таке місто у списку
                if (!cities.Contains(newCity))
                {
                    // Додаємо нове місто до списку та ComboBox
                    cities.Add(newCity);
                    comboBox1.Items.Add(newCity);
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Це місто вже є у списку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
