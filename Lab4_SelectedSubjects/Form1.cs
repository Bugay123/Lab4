namespace Lab4_SelectedSubjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.Add("Математика");
            checkedListBox1.Items.Add("Фізика");
            checkedListBox1.Items.Add("Хімія");
            checkedListBox1.Items.Add("Історія");
            checkedListBox1.Items.Add("Література");
            checkedListBox1.Items.Add("Інформатика");

            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Перевірити, чи елемент є вибраним, і додати його у ListBox
            if (e.NewValue == CheckState.Checked && !listBox1.Items.Contains(checkedListBox1.Items[e.Index]))
            {
                listBox1.Items.Add(checkedListBox1.Items[e.Index]);
            }
            // Видалити елемент з ListBox, якщо він був знятий з вибору в CheckedListBox
            else if (e.NewValue == CheckState.Unchecked && listBox1.Items.Contains(checkedListBox1.Items[e.Index]))
            {
                listBox1.Items.Remove(checkedListBox1.Items[e.Index]);
            }
        }
    }
}
