using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Proyecto_DetmerMedina_
{
    public partial class MainWindow : Window
    {
        // Lista de empleados autorizados
        public static Empleado EmpleadoLogueado { get; set; }
        private readonly List<Empleado> EmpleadosAutorizados = new List<Empleado>
        {
            new Empleado("22958544J", "Juan Pérez"),
            new Empleado("31690297T", "María García"),
            new Empleado("22305094Q", "Carlos López"),
            new Empleado("03132613J", "Ana Martínez"),
            new Empleado("12345678Z", "Detmer Medina")
        };

        // Tabla de letras para la validación del DNI
        private static readonly char[] LetrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnValidate_Click(object sender, RoutedEventArgs e)
        {
            string dni = txtDni.Text.Trim().ToUpper();

            if (ValidarDNI(dni))
            {
                var empleado = EmpleadosAutorizados.FirstOrDefault(emp => emp.Dni == dni);

                if (empleado != null)
                {
                    // Si el empleado está autorizado, continuar
                    EmpleadoLogueado = empleado; // Guardar el empleado logueado
                    MessageBox.Show($"Bienvenido, {empleado.Nombre}.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                    Principal prin = new Principal(); // Asegúrate de crear esta ventana
                    prin.Show();
                    this.Close();
                }
                else
                {
                    // DNI válido pero no autorizado
                    txtError.Text = "Acceso denegado. Este DNI no está autorizado.";
                    txtError.Visibility = Visibility.Visible;
                }
            }
            else
            {
                // Formato incorrecto
                txtError.Text = "DNI inválido. Asegúrate de que el formato\n sea correcto (8 dígitos + letra).";
                txtError.Visibility = Visibility.Visible;
            }
        }

        private bool ValidarDNI(string dni)
        {
            // Verificar que el formato tenga 8 números y una letra al final
            if (dni.Length != 9 || !char.IsLetter(dni[dni.Length - 1]) || !int.TryParse(dni.Substring(0, 8), out int numero))
            {
                return false;
            }

            // Obtener la letra correspondiente al número del DNI
            char letraCalculada = LetrasDNI[numero % 23];
            char letraIngresada = dni[dni.Length - 1]; // Última posición del DNI

            // Comparar la letra calculada con la ingresada
            return letraCalculada == letraIngresada;
        }
    }
}
