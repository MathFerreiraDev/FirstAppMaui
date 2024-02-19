namespace FirstAppMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_n1.Text);
            double n2 = Convert.ToDouble(txt_n2.Text);

            double result = n1 + n2;

            lbl_result.Text = result.ToString();
            lbl_result.IsVisible = true;
        }
    }

}
