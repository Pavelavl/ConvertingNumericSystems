using ConvertingNumericSystems;

namespace ConvertingForm
{
    public partial class Main : Form
    {
        /// <summary>
        /// ������������� ���������� �����
        /// </summary>
        public Main() => InitializeComponent();
        /// <summary>
        /// ������� ���������� ������� ������� �� ������ ����������� ��
        /// </summary>
        /// <param name="sender">��������� �������</param>
        /// <param name="e">�������</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Out.Text = ConvertingNumericSystems.Converting.ConvertBase(enterNum.Text, int.Parse(enterFromBase.Text), int.Parse(enterToBase.Text));
        }
    }
}
