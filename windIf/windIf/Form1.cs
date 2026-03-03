namespace windIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.cop.Text);
        }
    }

    public class Logic
    {
        public static string Convert(int cop)
        {
            string text;
            string normRub;
            string normCop;

            if (cop % 100 > 4)
            {
                normCop = "копеек";
            }
            else if (cop == 1)
            {
                normCop = "копейка";
            }
            else
            {
                normCop = "копейки";
            }

            if (cop >= 100)
            {

                int rub = cop / 100;
                int ost = cop % 100;

                if (rub % 100 == 1)
                {
                    normRub = "рубль";
                }
                else if (rub % 100 < 5)
                {
                    normRub = "рубля";
                }
                else
                {
                    normRub = "рублей";
                }

                if (ost > 0)
                {

                    text = $"{rub} {normRub}  {ost} {normCop}";
                }
                else
                {
                    text = $"{rub} {normRub}";
                }
            }
            else
            {
                text = $"{cop} {normCop}";
            }
            return text;
        }
    }
}
