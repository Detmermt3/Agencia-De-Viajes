using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public ObservableCollection<Cliente> Clientes { get; set; }
        public Principal()
        {
            InitializeComponent();
            this.DataContext = MainWindow.EmpleadoLogueado;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // Abrir la ventana principal como invitado
                Destinos destinos = new Destinos(); 
                destinos.Show();
                this.Close();
            }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ListaClientes lisCli = new ListaClientes(Clientes);
            lisCli.Show();
            this.Close();

        }
    }
   
}
