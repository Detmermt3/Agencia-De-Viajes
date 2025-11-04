using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Proyecto_DetmerMedina_
{
    public partial class ListaClientes : Window
        
    {
       

        public ListaClientes(ObservableCollection<Cliente> clientes)
        {
            InitializeComponent();

            // Usar directamente la ObservableCollection
            LstClientesLista.ItemsSource = ClientesData.Clientes;
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
  
                GestionClientes gest = new GestionClientes();
                gest.Show();
                this.Close();

        }

        private void BtnVolverPrin(object sender, RoutedEventArgs e)
        {

            Principal prin = new Principal();
            prin.Show();
            this.Close();

        }
    }
}
