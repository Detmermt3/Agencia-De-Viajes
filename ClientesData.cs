using System.Collections.ObjectModel;

namespace Proyecto_DetmerMedina_
{
    public static class ClientesData
    {
        public static ObservableCollection<Cliente> Clientes { get; set; } = new ObservableCollection<Cliente>
        {
        new Cliente("Lucía Fernández", "11223344D", "Pendiente", "Madrid", "Barcelona", "Negocios"),
        new Cliente("Manuel Sánchez", "22334455E", "Cerrado", "Valencia", "Sevilla", "Turismo"),
        new Cliente("Ana Rodríguez", "33445566F", "Cancelado", "Granada", "Bilbao", "Estudios"),
        new Cliente("Jorge Martín", "44556677G", "Pendiente", "Málaga", "Madrid", "Turismo"),
        new Cliente("Laura Díaz", "55667788H", "Cerrado", "Bilbao", "Valencia", "Negocios"),
        new Cliente("Pedro García", "66778899I", "Cancelado", "Sevilla", "Granada", "Turismo"),
        new Cliente("Sofía Herrera", "77889900J", "Pendiente", "Madrid", "Alicante", "Estudios"),
        new Cliente("Alberto Ruiz", "88990011K", "Cerrado", "Barcelona", "Málaga", "Turismo"),
        new Cliente("Marta Morales", "99001122L", "Cancelado", "Valencia", "Sevilla", "Negocios"),
        new Cliente("Francisco Castro", "10111213M", "Pendiente", "Bilbao", "Granada", "Turismo"),
        new Cliente("Isabel Ortega", "12131415N", "Cerrado", "Madrid", "Barcelona", "Estudios"),
        new Cliente("Raúl Vázquez", "14151617O", "Cancelado", "Sevilla", "Alicante", "Turismo"),
        new Cliente("Carmen Torres", "16171819P", "Pendiente", "Valencia", "Madrid", "Negocios"),
        new Cliente("Andrés Gil", "18192021Q", "Cerrado", "Málaga", "Bilbao", "Turismo"),
        new Cliente("Elena Blanco", "20212223R", "Cancelado", "Granada", "Sevilla", "Estudios"),
        new Cliente("Gonzalo Rivas", "22232425S", "Pendiente", "Barcelona", "Valencia", "Negocios"),
        new Cliente("Victoria León", "24252627T", "Cerrado", "Bilbao", "Granada", "Turismo"),
        new Cliente("Hugo Méndez", "26272829U", "Cancelado", "Madrid", "Málaga", "Estudios"),
        new Cliente("Paula Romero", "28293031V", "Pendiente", "Valencia", "Barcelona", "Turismo"),
        new Cliente("Diego Serrano", "30313233W", "Cerrado", "Sevilla", "Madrid", "Negocios"),
        new Cliente("Juan Pérez", "12345678A", "Pendiente", "Granada", "Bilbao", "Turismo"),
        new Cliente("María Gómez", "87654321B", "Cerrado", "Barcelona", "Sevilla", "Estudios"),
        new Cliente("Carlos López", "56781234C", "Cancelado", "Madrid", "Valencia", "Turismo")


        };
    }
}