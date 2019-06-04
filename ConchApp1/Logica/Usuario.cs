using ConchApp1.Models;
using System;
using System.Linq;

namespace ConchApp1.Logica
{
    public class Usuario
    {
        CONCHAPPContext context = new CONCHAPPContext();
        public void registrarUsuarioTransportista(Models.UsuariosTransportistas usuariosTransportistas)
        {
            try
            {
                context.UsuariosTransportistas.Add(usuariosTransportistas);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }

        public void registrarUsuarioPasajero(Models.UsuarioPasajero usuarioPasajero)
        {
            try
            {
                context.UsuarioPasajeros.Add(usuarioPasajero);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

        }
        public Models.UsuarioPasajero MostrarUsuarioPasajero(int id)
        {
            var pasajero = new Models.UsuarioPasajero();
            try
            {

                pasajero = context.UsuarioPasajeros.Where(x => x.Id == id).Single();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return pasajero;
        }

        public Models.UsuariosTransportistas MostrarUsuarioTransportista(int id)
        {
            var transportista = new Models.UsuariosTransportistas();
            try
            {

                transportista = context.UsuariosTransportistas.Where(x => x.Id == id).Single();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return transportista;
        }
    }
}
    