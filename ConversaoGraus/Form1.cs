namespace ConversaoGraus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (this.SelectConv.SelectedIndex == 0)
            {
                float Celsius = 0;
                if (float.TryParse(InsertGrau.Text, out Celsius))
                {

                    float fahrenheit = (float)((Celsius * 9 / 5) + 32);
                    ShowGrau.Text = $"{fahrenheit:N2}";
                }
                else
                {
                    MessageBox.Show("Valor inv�lido");
                    ShowGrau.Text = "";
                }
            }
            else if (this.SelectConv.SelectedIndex == 1)
            {

                {
                    float fahrenheit = 0;
                    if (float.TryParse(InsertGrau.Text, out fahrenheit))
                    {
                        float Celsius = (float)(5 * ((fahrenheit - 32) / 9));
                        ShowGrau.Text = $"{Celsius:N2}";
                    }
                    else
                    {
                        MessageBox.Show("Valor inv�lido");
                        ShowGrau.Text = "";
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecione o tipo de convers�o!");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ShowGrau.Text = "";
            InsertGrau.Text = "";
        }
    }
}