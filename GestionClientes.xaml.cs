using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Proyecto_DetmerMedina_
{
    public partial class GestionClientes : Window
    {
        public GestionClientes()
        {
            InitializeComponent();

            // Enlazar la ObservableCollection directamente al ListView
            LstClientes.ItemsSource = ClientesData.Clientes;
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            Destinos des = new Destinos(); // Asegúrate de crear esta ventana
            des.Show();
            this.Close();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (LstClientes.SelectedItem is Cliente clienteSeleccionado)
            {
                // Actualizar los valores de Nombre, DNI y Estado con los valores editados en los controles
                clienteSeleccionado.Nombre = TxtNombre.Text;
                clienteSeleccionado.DNI = TxtDNI.Text;
                clienteSeleccionado.Estado = (CmbEstado.SelectedItem as ComboBoxItem)?.Content.ToString();

                MessageBox.Show("Cambios guardados con éxito.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            // Crear un nuevo cliente con propiedades predefinidas o obtenidas de entradas del usuario
            var nuevoCliente = new Cliente(
                "Nuevo Cliente",          // Nombre
                "00000000X",              // DNI
                "Pendiente",              // Estado
                "Origen por defecto",     // Origen
                "Destino por defecto",    // Destino
                "Tipo de viaje por defecto" // TipoDeViaje
            );

            // Agregar el nuevo cliente a la lista global
            ClientesData.Clientes.Add(nuevoCliente);

            // Refrescar la vista del ListView para incluir el nuevo cliente
            LstClientes.Items.Refresh();

            // Seleccionar automáticamente el nuevo cliente en la lista
            LstClientes.SelectedItem = nuevoCliente;
        }


        private void LstClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LstClientes.SelectedItem is Cliente clienteSeleccionado)
            {
                TxtNombre.Text = clienteSeleccionado.Nombre;
                TxtDNI.Text = clienteSeleccionado.DNI;
                CmbEstado.SelectedItem = CmbEstado.Items.Cast<ComboBoxItem>()
                    .FirstOrDefault(item => item.Content.ToString() == clienteSeleccionado.Estado);

                // Rellenar los campos de Origen, Destino y TipoDeViaje
                TxtOrigen.Text = clienteSeleccionado.Origen;
                TxtDestino.Text = clienteSeleccionado.Destino;
                CmbTipoDeViaje.SelectedItem = CmbTipoDeViaje.Items.Cast<ComboBoxItem>()
                    .FirstOrDefault(item => item.Content.ToString() == clienteSeleccionado.TipoDeViaje);

                BtnGuardar.IsEnabled = true; // Habilitar el botón "Guardar Cambios"
            }
            else
            {
                BtnGuardar.IsEnabled = false; // Deshabilitar el botón si no hay selección
            }
        }

        private void BtnVerClientes(object sender, RoutedEventArgs e)
        {
            // Aquí puedes mostrar la ventana con la lista de clientes
            ListaClientes listaClientesWindow = new ListaClientes(ClientesData.Clientes);
            listaClientesWindow.Show();
        }

    }

}
