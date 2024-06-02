namespace Ejercicio5
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(Altura.Text);
            double baseRectangulo = Convert.ToDouble(Base.Text);

            // Calcular el perímetro y el área del rectángulo
            double perimetro = 2 * (altura + baseRectangulo);
            double area = altura * baseRectangulo;

            // Mostrar los resultados en los labels correspondientes
            Perimetro.Text = $"El perímetro del rectángulo es: {perimetro}";
            Area.Text = $"El área del rectángulo es: {area}";
        }
    }

}
