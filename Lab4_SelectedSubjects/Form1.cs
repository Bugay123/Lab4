namespace Lab4_SelectedSubjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.Add("����������");
            checkedListBox1.Items.Add("Գ����");
            checkedListBox1.Items.Add("ճ��");
            checkedListBox1.Items.Add("������");
            checkedListBox1.Items.Add("˳��������");
            checkedListBox1.Items.Add("�����������");

            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // ���������, �� ������� � ��������, � ������ ���� � ListBox
            if (e.NewValue == CheckState.Checked && !listBox1.Items.Contains(checkedListBox1.Items[e.Index]))
            {
                listBox1.Items.Add(checkedListBox1.Items[e.Index]);
            }
            // �������� ������� � ListBox, ���� �� ��� ������ � ������ � CheckedListBox
            else if (e.NewValue == CheckState.Unchecked && listBox1.Items.Contains(checkedListBox1.Items[e.Index]))
            {
                listBox1.Items.Remove(checkedListBox1.Items[e.Index]);
            }
        }
    }
}
