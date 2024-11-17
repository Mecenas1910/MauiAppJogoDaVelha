namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if(vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            } else
            {
                btn.Text = "O";
                vez = "X";
            }

            /* Verificando se o X ganhou na 1ª linha */
            // Verificação de vitória nas linhas horizontais
if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X" ||
    btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X" ||
    btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
{
    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
    Zerar();
}
// Verificação de vitória nas colunas
else if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X" ||
         btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X" ||
         btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
{
    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
    Zerar();
}
// Verificação de vitória nas diagonais
else if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X" ||
         btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
{
    DisplayAlert("Parabéns!", "O X ganhou!", "OK");
    Zerar();
}
// Repetição para "O"
else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O" ||
         btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O" ||
         btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
{
    DisplayAlert("Parabéns!", "O O ganhou!", "OK");
    Zerar();
}
else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O" ||
         btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O" ||
         btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
{
    DisplayAlert("Parabéns!", "O O ganhou!", "OK");
    Zerar();
}
else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O" ||
         btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
{
    DisplayAlert("Parabéns!", "O O ganhou!", "OK");
    Zerar();
}

           
        } // Fecha método 
    } // Fecha Classe
} // Fecha Namespace
