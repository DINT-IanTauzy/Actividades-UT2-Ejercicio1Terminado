using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Actividades_UT2_Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int numeroSecreto = NumeroRandom();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        static private int NumeroRandom()
        {
            Random semilla = new Random();
            return semilla.Next(0, 101);
        }

        private void Button_Reiniciar(object sender, RoutedEventArgs e)
        {
            numeroSecreto = NumeroRandom();
            Resultado.Text = "";
            NumeroUsuario.Text = "";
        }

        private void Button_Comprobar(object sender, RoutedEventArgs e)
        {
            if (int.Parse(NumeroUsu()) == numeroSecreto)
                Resultado.Text = "Has acertado";
            else if (int.Parse(NumeroUsuario.Text) > numeroSecreto)
                Resultado.Text = "Te has pasado";
            else if (int.Parse(NumeroUsuario.Text) < numeroSecreto)
                Resultado.Text = "Te has quedado corto";
        }
        private string NumeroUsu()
        {
            return NumeroUsuario.Text;
        }
        private void NumeroUsu(object sender, TextChangedEventArgs e) { }
    }
}
