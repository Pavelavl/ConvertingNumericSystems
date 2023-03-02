using ConvertingNumericSystems;

namespace ConvertingForm
{
    public partial class Main : Form
    {
        /// <summary>
        /// Инициализация компонента формы
        /// </summary>
        public Main() => InitializeComponent();
        /// <summary>
        /// Функция обработчик события нажатия на кнопку конвертации СС
        /// </summary>
        /// <param name="sender">Инициатор события</param>
        /// <param name="e">Событие</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Out.Text = ConvertingNumericSystems.Converting.ConvertBase(enterNum.Text, int.Parse(enterFromBase.Text), int.Parse(enterToBase.Text));
        }
    }
}
