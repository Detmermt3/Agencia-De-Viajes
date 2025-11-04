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
using System.Windows.Shapes;

namespace Proyecto_DetmerMedina_
{
    /// <summary>
    /// Lógica de interacción para Destinos.xaml
    /// </summary>
    public partial class Destinos : Window
    {
        public Destinos()
        {
            InitializeComponent();
        }

        private void ButtonInicio(object sender, RoutedEventArgs e)
        {
            Principal prin = new Principal(); // Asegúrate de crear esta ventana
            prin.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GestionClientes GesCli = new GestionClientes(); // Asegúrate de crear esta ventana
            GesCli.Show();
            this.Close();
        }
    }
}

