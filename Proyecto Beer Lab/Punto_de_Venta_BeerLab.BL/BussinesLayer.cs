using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_Venta_BeerLab.DAL;
using System.Text.RegularExpressions;

namespace Punto_de_Venta_BeerLab.BL
{
    public class BussinesLayer
    {

        #region Inicialización de Variables.

        string Tipo_Usuario = "";
        string Identificacion;
        string NombreCompleto;
        string Contrasenna;
        int descVIP;
        decimal descEstandar;
        int PuntosActuales;
        decimal TotalFacturar;

        #region Variables para Reportes Contables 

        int Total_Ventas_Contado;
        int Total_Ventas_Credito;
        int Total_Devoluciones;
        int Total_Efectivo;
        int Total_Tarjeta;
        int Total_General;

        #endregion

        #endregion

        // |------------------------|-------------------------------------|------------------------| //
        // |------------------------| Métodos para el módulo de Seguridad |------------------------| //

        #region Compilación de métodos.

        // Método encargado de verificar los datos del usuario para iniciar sesión. 

        public Boolean IniciarSession(string identificacion, string contraseña)
        {
            Boolean validar;
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {

                var Usuario = (from p in context.sp_Iniciar_Session(identificacion, contraseña) select p).SingleOrDefault();
                Identificacion = Usuario.Identificacion;
                if (Usuario.Identificacion == identificacion && Usuario.Contraseña == contraseña)
                {
                    validar = true;
                }
                else
                {
                    validar = false;
                }

                return validar;
            }

        }

        // Método encargado de determinar el tipo de usuario con un procedimiento almacenado.

        public string TipoUsuario()
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {


                var Usuario = (from u in context.sp_Tipo_Usuario(Identificacion) select u).FirstOrDefault();

                if (Usuario != null)
                {
                    if (Usuario.Id_Rol == 1)
                    {
                        Tipo_Usuario = "Administrador";
                    }
                    else

                    if (Usuario.Id_Rol == 2)
                    {
                        Tipo_Usuario = "Contabilidad";
                    }

                    if (Usuario.Id_Rol == 3)
                    {
                        Tipo_Usuario = "Inventario";
                    }

                    if (Usuario.Id_Rol == 4)
                    {
                        Tipo_Usuario = "Vendedor";
                    }

                    if (Usuario.Id_Rol == 5)
                    {
                        Tipo_Usuario = "Sin Privilegios";
                    }

                    return Tipo_Usuario;
                }
                else
                {
                    return null;
                }

            }
        }

        // Método encargado de determinar el tipo de usuario con Entity Framework.

        public string TipoUsuario2(int id)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                string user = "";

                var usuario = (from u in context.TBL_Usuarios
                               where u.Id_usuario == id
                               select u).FirstOrDefault();

                if (usuario != null)
                {
                    if (usuario.Id_Rol == 1)
                    {
                        user = "Administrador";

                    }
                    else

                    if (usuario.Id_Rol == 2)
                    {
                        user = "Contabilidad";


                    }

                    if (usuario.Id_Rol == 3)
                    {
                        user = "Inventario";

                    }

                    if (usuario.Id_Rol == 4)
                    {
                        user = "Vendedor";
                    }

                    if (usuario.Id_Rol == 5)
                    {
                        user = "Sin Privilegios";

                    }
                    return user;

                }
                else
                {
                    return null;
                }
            }
        }

        // Método encargado de asignar el privilegio.

        public void SetPrivilegio(int id, int privilegio)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {


                try
                {
                    var usuario = context.TBL_Usuarios.Where(x => x.Id_usuario == id).SingleOrDefault();
                    usuario.Id_Rol = privilegio;
                    context.SaveChanges();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

        }

        // Método encargado de obtener la contraseña actual del usuario seleccionado.

        public string Contrasenna_Usuario(string NumeroIdentificacion)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var usuario = (from u in context.TBL_Usuarios where u.Identificacion == NumeroIdentificacion select u).FirstOrDefault();
                Contrasenna = usuario.Contraseña;
            }
            return Contrasenna;
        }

        // Método encargado de asignar una nueva contraseña al usuario.

        public void ChangePassword(string ID_User, string NewPassword)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                try
                {
                    var usuario = context.TBL_Usuarios.Where(x => x.Identificacion == ID_User).SingleOrDefault();
                    usuario.Contraseña = NewPassword;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // Método encargado de obtener el nombre completo del usuario.

        public string Nombre_Usuario()
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var usuario = (from u in context.TBL_Usuarios
                               where u.Identificacion == Identificacion
                               select u).FirstOrDefault();
                NombreCompleto = usuario.Nombre + " " + usuario.Apellido1 + " " + usuario.Apellido2;
            }
            return NombreCompleto;
        }

        #endregion

        // |-------------------------| Fin de los Métodos para Seguridad |-------------------------| //
        // |------------------------|-------------------------------------|------------------------| //
        // |---------------------| Métodos para el módulo de Mantenimientos |----------------------| //

        #region Compilación de métodos.

        #region Métodos para Usuarios.

        // Método encargado de agregar nuevos usuarios.

        public void AgregarUsuario(string identificacion, string nombre, string apellido1, string apellido2, string correo)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {

                context.sp_Insertar_Usuarios(identificacion, nombre, apellido1, apellido2, correo, DateTime.Now, 2);
                context.SaveChanges();
            }
        }

        // Método encargado de modificar usuarios existentes.

        public void ModificarUsuario(string identificacion, string nombre, string apellido1, string apellido2, string correo, string contrasenna)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var persona = context.sp_Modificar_Usuarios(identificacion, nombre, apellido1, apellido2, correo, DateTime.Now);
                context.SaveChanges();
            }
        }

        // Método encargado de mostrar la lista de usuarios.

        public List<TBL_Usuarios> MostrarUsuarios()
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var Query = (from persona in context.TBL_Usuarios select persona).ToList();
                return Query;
            }
        }

        // Método encargado de mostrar la lista de usuarios con un procedimiento almacenado.

        public List<sp_Mostrar_Usuarios_Result> MostrarUsuariosStoreProcedure()
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var Query = context.sp_Mostrar_Usuarios().ToList();
                return Query;
            }
        }

        // Método encargado de determinar si el número de identificación ya fue agregado.

        public TBL_Usuarios IdNumberExist(string ID_User)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var datos = (from p in context.TBL_Usuarios select p).Where(x => x.Identificacion == ID_User).FirstOrDefault();

                return datos;
            }
        }

        // Método encargado de activar un usuario.

        public void ActivarUsuario(int id)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                try
                {
                    var persona = context.TBL_Usuarios.Where(x => x.Id_usuario == id).SingleOrDefault();
                    persona.Id_estado = 1;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // Método encargado de desactivar un usuario.

        public void DesactivarUsuario(int id)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                try
                {
                    var persona = context.TBL_Usuarios.Where(x => x.Id_usuario == id).SingleOrDefault();
                    persona.Id_estado = 2;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        #endregion

        #region Métodos para Clientes.

        // Método encargado de agregar clientes.

        public void AgregarCliente(string tipoId, string cedula, string nombre, string apellido1, string apellido2, DateTime fechaNacimiento, DateTime fechaCreacion, string correo, int teléfono)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                context.sp_Insertar_Clientes(tipoId, cedula, nombre, apellido1, apellido2, fechaNacimiento, fechaCreacion, correo, teléfono);
                context.SaveChanges();
            }

        }

        // Método encargado de modificar los clientes existentes.

        public void ModificarCliente(string tipoId, string cedula, string nombre, string apellido1, string apellido2, DateTime fechaNacimiento, DateTime fechaCreacion, string correo, int teléfono)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                context.sp_Modificar_Clientes(tipoId, cedula, nombre, apellido1, apellido2, fechaNacimiento, fechaCreacion, correo, teléfono);
                context.SaveChanges();
            }

        }

        // Método encargado de mostrar una lista de los clientes registrados.

        public List<sp_Mostrar_Clientes_Result> MostrarClientes()
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var estado = context.sp_Mostrar_Clientes().ToList();

                return estado;
            }

        }

        // Método encargado de activar un cliente.

        public void ActivarCliente(string ID_Cliente)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                try
                {
                    var persona = context.TBL_Clientes.Where(x => x.Identificacion == ID_Cliente).SingleOrDefault();
                    persona.Id_estado = 1;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // Método encargado de desactivar un cliente.

        public void DesactivarCliente(string ID_Cliente)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                try
                {
                    var persona = context.TBL_Clientes.Where(x => x.Identificacion == ID_Cliente).SingleOrDefault();
                    persona.Id_estado = 2;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // Método encargado de revisar si el cliente ya existe. 

        public TBL_Clientes ClienteExiste(string ID_Cliente)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var datos = (from p in context.TBL_Clientes select p).Where(x => x.Identificacion == ID_Cliente).FirstOrDefault();
                return datos;
            }
        }


        public TBL_Clientes Datos_Cliente(int ID_Cliente)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var datos = (from p in context.TBL_Clientes select p).Where(x => x.Id_cliente == ID_Cliente).FirstOrDefault();
                return datos;
            }
        }
        #endregion

        #region Métodos para Productos.

        // Método encargado de agregar productos

        public void AgregarProducto(string Codigo, string NombreProducto, string TipoEnvasado, string NivelFragilidad, int CantidadMililitros, int NivelAlcohol, decimal PrecioProducto, DateTime FechaEmision, DateTime FechaCaducidad, int StockInicial, int StockActual, DateTime FechaIngreso, int Estado, string DescripcionProducto)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                context.sp_Insertar_Productos(Codigo, NombreProducto, TipoEnvasado, NivelFragilidad, CantidadMililitros, NivelAlcohol, PrecioProducto, FechaEmision, FechaCaducidad, StockInicial, StockActual, FechaIngreso, Estado, DescripcionProducto);
                context.SaveChanges();
            }

        }

        // Método encargado de modificar los productos

        public void ModificarProducto(string Codigo, string NombreProducto, string TipoEnvasado, string NivelFragilidad, int CantidadMililitros, int NivelAlcohol, decimal PrecioProducto, DateTime FechaEmision, DateTime FechaCaducidad, int StockInicial, int StockActual, string DescripcionProducto, DateTime FechaModificacion)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                context.sp_Modificar_Productos(Codigo, NombreProducto, TipoEnvasado, NivelFragilidad, CantidadMililitros, NivelAlcohol, PrecioProducto, FechaEmision, FechaCaducidad, StockInicial, StockActual, DescripcionProducto, FechaModificacion);
                context.SaveChanges();
            }

        }

        // Método encargado de mostrar los productos existentes.

        public List<sp_Mostrar_Productos_Result> MostrarProductos()
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var estado = context.sp_Mostrar_Productos().ToList();

                return estado;
            }

        }


        //Método encargado de determinar si el producto ya existe. 

        public TBL_Productos ProductExists(string ID_Product)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var datos = (from p in Context.TBL_Productos select p).Where(x => x.Codigo == ID_Product).FirstOrDefault();

                return datos;
            }
        }

        public void ChangeProductState(string ID_Product, string State)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                try
                {
                    var persona = context.TBL_Productos.Where(x => x.Codigo == ID_Product).SingleOrDefault();
                    if (State == "1")
                    {
                        persona.Id_estado = 1;
                    }
                    else
                    {
                        persona.Id_estado = 2;
                    }
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        #endregion

        #region Métodos para Descuentos VIP.

        // Método encargado de agregar los descuentos VIP.

        public void AgregarDescuentosVIP(int descuento, int puntos)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var estado = context.sp_Insertar_DescuentosVIP(DateTime.Now, descuento, puntos, 1);
                context.SaveChanges();
            }

        }

        // Método encargado de modificar los descuentos VIP.

        public void ModificarDescuentosVIP(int id, int descuento, int puntos)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var estado = context.sp_Modificar_DescuentosVIP(id, DateTime.Now, descuento, puntos, 1);
                context.SaveChanges();
            }

        }

        // Método encargado de mostrar una lista con los descuentos VIP.

        public List<sp_Mostrar_DescuentosVIP_Result> MostrarDescuentosVIP()
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var estado = context.sp_Mostrar_DescuentosVIP().ToList();

                return estado;
            }
        }

        // Método encargado de determinar si el descuento ya existe.

        public TBL_DescuentosVIP VIPDiscountExists(int Value, int Equivalent)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var datos = (from p in context.TBL_DescuentosVIP select p).Where(x => x.Descuento == Value && x.Puntos == Equivalent).FirstOrDefault();
                return datos;
            }
        }

        // Método encargado de modificar el estado de un descuento VIP.

        public void ChangeVIPDiscountState(int ID_DiscountVIP, string State)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                try
                {
                    var persona = Context.TBL_DescuentosVIP.Where(x => x.Id_DescVIP == ID_DiscountVIP).SingleOrDefault();

                    if (State == "1")
                    {
                        persona.Estado = "1";
                    }
                    else if (State == "2")
                    {
                        persona.Estado = "2";
                    }
                    Context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        #endregion

        #region Métodos para Descuentos Estándar.

        // Método encargado de agregar descuentos estándar.

        public void AgregarDescuentos_Estandar(int Cantidad_Min, int Cantidad_Max, int descuento, string dia)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var estado = context.sp_Insertar_Descuentos_Estandar(DateTime.Now, Cantidad_Min, Cantidad_Max, descuento, dia, 1);
                context.SaveChanges();
            }

        }

        // Método encargado de modifcar los descuentos estándar

        public void ModificarDescuentos_Estandar(int id, int Cantidad_Min, int Cantidad_Max, int descuento, string dia)
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var estado = context.sp_Modificar_Descuentos_Estandar(id, DateTime.Now, Cantidad_Min, Cantidad_Max, descuento, dia, 1);
                context.SaveChanges();
            }

        }

        // Método encargado de mostrar una lista con los descuentos estándar existentes. 

        public List<sp_Mostrar_Descuentos_Estandar_Result> MostrarDescuentos_Estandar()
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var estado = context.sp_Mostrar_Descuentos_Estandar().ToList();

                return estado;
            }

        }

        //Método encargado de determinar si existe el descuento estándar.

        public TBL_DescuentosEstandar StandarDiscountExists(int Min, int Max, string Day)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var datos = (from p in context.TBL_DescuentosEstandar select p).Where(x => x.Cantidad_Minima == Min && x.Cantidad_Maxima == Max && x.Dia == Day).FirstOrDefault();
                return datos;
            }
        }

        public TBL_DescuentosEstandar Descuento_Aplicado(int Cantidad, string Day)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {

                if (Day == "Monday")
                {
                    Day = "Lunes";
                    
                }

                if (Day == "Tuesday")
                {
                    Day = "Martes";
                    
                }

                if (Day == "Wednesday")
                {
                    Day = "Miércoles";
                   
                }

                if (Day == "Thursday")
                {
                    Day = "Jueves";
                    
                }

                if (Day == "Friday")
                {
                    Day = "Viernes";
                    
                }

                if (Day == "Saturday")
                {
                    Day = "Sábado";
                    
                }
                if (Day == "Sunday")
                {
                    Day = "Domingo";
                    
                }
                var datos = (from p in context.TBL_DescuentosEstandar select p).Where(x => Cantidad >= x.Cantidad_Minima && Cantidad <= x.Cantidad_Maxima && x.Dia == Day).FirstOrDefault();
                return datos;
            }
        }

        public TBL_DescuentosVIP Descuento_Aplicado_VIP(int Puntos)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var datos = (from p in context.TBL_DescuentosVIP select p).Where(x => Puntos == x.Puntos).FirstOrDefault();
                return datos;
            }
        }


        // Método encargado de modificar el estado de un descuento estándar.

        public void ChangeStandarDiscountState(int ID_DiscountVIP, string State)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                try
                {
                    var persona = Context.TBL_DescuentosVIP.Where(x => x.Id_DescVIP == ID_DiscountVIP).SingleOrDefault();

                    if (State == "1")
                    {
                        persona.Estado = "1";
                    }
                    else if (State == "2")
                    {
                        persona.Estado = "2";
                    }
                    Context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        #endregion

        #region Métodos para Direcciones

        // Método para agregar direcciones.
        public void Agregar_DireccionCliente(int ID_Client, string Description, string ID_Provincia, string ID_Canton, string ID_Distrito)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                TBL_Direcciones_cliente datos = new TBL_Direcciones_cliente();

                datos.Id_cliente = this.ClienteExiste(Convert.ToString(ID_Client)).Id_cliente;
                datos.Dsc_direccion = Description;
                datos.Id_provincia = ID_Provincia;
                datos.Id_canton = ID_Canton;
                datos.Id_distrito = ID_Distrito;

                context.TBL_Direcciones_cliente.Add(datos);
                context.SaveChanges();
            }
        }

        // Método encargado de listar todas las direcciones del sistema.
        public List<SP_Listar_Direcciones_Result> Mostrar_Direcciones_Cliente()
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var Direcciones = Context.SP_Listar_Direcciones().ToList();
                return Direcciones;
            }
        }

        // Método encargado de validar si esa dirección ya existe.
        public TBL_Direcciones_cliente AdressExist(int ID_Client)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var datos = (from p in context.TBL_Direcciones_cliente select p).Where(x => x.Id_cliente == ID_Client).FirstOrDefault();
                return datos;
            }
        }

        // Método encargado de modificar una dirección ya existen.
        public void Modificar_DireccionCliente(int ID_Client, string Description, string ID_Provincia, string ID_Canton, string ID_Distrito)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var datos = (from p in context.TBL_Direcciones_cliente select p).Where(x => x.Id_cliente == ID_Client).FirstOrDefault();

                if (datos != null)
                {
                    datos.Dsc_direccion = Description;
                    datos.Id_provincia = ID_Provincia;
                    datos.Id_canton = ID_Canton;
                    datos.Id_distrito = ID_Distrito;
                }
            }
        }

        // Método encargado de cargar los datos de provincias.
        public List<string> Cargar_Provincias()
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var Informacion = (from Provincia in context.TBL_Provincias select Provincia.Desc_provincia).ToList();
                return Informacion;
            }
        }

        public TBL_Provincias Obtener_Codigo_Provincia(string Nombre_Provincia)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var Codigo = (from p in context.TBL_Provincias select p).Where(x => x.Desc_provincia == Nombre_Provincia).FirstOrDefault();
                return Codigo;
            }
        }

        // Método encargado de cargar los datos de cantones.
        public List<string> Cargar_Cantones(string ID_Provincia)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var Informacion = (from Canton in Context.TBL_Cantones where Canton.Id_provincia == ID_Provincia select Canton.Desc_canton).ToList();
                return Informacion;
            }
        }

        public TBL_Cantones Obtener_Codigo_Canton(string Nombre_Canton)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var Codigo = (from p in context.TBL_Cantones select p).Where(x => x.Desc_canton == Nombre_Canton).FirstOrDefault();
                return Codigo;
            }
        }

        // Método encargado de cargar los datos de distritos.
        public List<string> Cargar_Distritos(string ID_Provincia, string ID_Canton)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var Informacion = (from Distrito in Context.TBL_Distritos where Distrito.Id_provincia == ID_Provincia && Distrito.Id_canton == ID_Canton select Distrito.Desc_distrito).ToList();
                return Informacion;
            }
        }

        public TBL_Distritos Obtener_Codigo_Distrito(string Nombre_Distrito)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var Codigo = (from p in context.TBL_Distritos select p).Where(x => x.Desc_distrito == Nombre_Distrito).FirstOrDefault();
                return Codigo;
            }
        }


        #endregion

        #endregion

        // |-----------------------| Fin de los métodos para Cat. & Mant. |------------------------| //
        // |------------------------|-------------------------------------|------------------------| //
        // |---------------------| Métodos para el módulo de Punto de Venta|-----------------------| //

        #region Compilación de Métodos.

        #region Métodos para la validación del cliente y para la generación de la factura.

        // Método encargado de buscar a un cliente por el número de identificación y el tipo de identificación.
        public TBL_Clientes BuscarCliente(string identificacion, string tipoid)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var datos = (from p in context.TBL_Clientes select p).Where(x => x.Identificacion == identificacion && x.Tipo_identificacion == tipoid).FirstOrDefault();

                return datos;
            }

        }

        //Método encargado de buscar a un cliente por el número de identificación.
        public TBL_Clientes BuscarClienteId(string identificacion)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var datos = (from p in context.TBL_Clientes select p).Where(x => x.Identificacion == identificacion).FirstOrDefault();
                return datos;
            }

        }

        //Método encargado de validar el tipo de cliente.
        public string validarTipoCliente(string identificacion)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                string tipocliente = "";
                var client = context.TBL_Clientes.Where(x => x.Identificacion == identificacion).SingleOrDefault();

                tipocliente = client.Tipo_cliente;
                return tipocliente;

            }
        }
        #endregion

        #region Métodos para el proceso de selección de producto, detalle factura y calcular montos:

        //Método para obtener el último número de factura realizado. 
        public int ObtenerUltimoNumero()
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var LastDigit = (from p in context.TBL_Factura.OrderByDescending(p => p.Id_factura) select p).FirstOrDefault();

                if (String.IsNullOrEmpty(Convert.ToString(LastDigit.Id_factura)))
                {
                    return 1;
                }
                else
                {
                    return LastDigit.Id_factura + 1;
                }
            }
        }

        //Metódo encargado de facturar y calcular el vuelto.
        public void FacturarPago(string Bill_Type, string Payment_Type, decimal Subtotal, decimal Subtotal_Discount, decimal Total_Taxes, decimal Total, int ID_Client, int ID_Discount)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {

                // Proceso de guardado de datos en la tabla de Factura. 

                TBL_Factura Agregar_Datos = new TBL_Factura();

                Agregar_Datos.Tipo_Factura = Bill_Type;
                Agregar_Datos.Tipo_Pago = Payment_Type;
                Agregar_Datos.Subtotal = Subtotal;
                Agregar_Datos.SubtotalDescuento = Subtotal_Discount;
                Agregar_Datos.Total_impuesto = Total_Taxes;
                Agregar_Datos.Total = Total;
                Agregar_Datos.Fecha_venta = DateTime.Today.Date;
                Agregar_Datos.Id_estado = 1;
                Agregar_Datos.Id_cliente = ID_Client;

                //Aquí determina si el cliente era estándar o VIP.

                if (this.Datos_Cliente(ID_Client).Tipo_cliente == "Estandar")
                {
                    if (ID_Discount == 0)
                    {
                        Agregar_Datos.Id_DescEstandar = null;
                    }
                    else { Agregar_Datos.Id_DescEstandar = ID_Discount; }

                    Agregar_Datos.Id_DescVIP = null;
                }
                else if (this.Datos_Cliente(ID_Client).Tipo_cliente == "VIP")
                {
                    if (ID_Discount == 0)
                    {
                        Agregar_Datos.Id_DescVIP = null;
                    }
                    else { Agregar_Datos.Id_DescVIP = ID_Discount; }

                    Agregar_Datos.Id_DescEstandar = null;

                }
                context.TBL_Factura.Add(Agregar_Datos);
                context.SaveChanges();
            }
        }

        //Método encargado de obtener el total según los productos seleccionados.
        public void GetTotal(decimal total)
        {
            TotalFacturar = total;
        }

        //Método encargado de enviar el total según los productos facturados.
        public decimal SetTotal()
        {
            return TotalFacturar;
        }

        //Método encargado de buscar un producto en la base de datos
        public TBL_Productos BuscarProductos_PorNombre(string Product_Name, string Tipo_Envase)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var producto = (from p in context.TBL_Productos select p).Where(x => x.Nombre_producto == Product_Name && x.Tipo_envasado == Tipo_Envase).FirstOrDefault();
                return producto;
            }
        }

        //Método encargado de llenar la lista desplegable con los productos disponibles.
        public List<string> InfoProductos()
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var Productos = (from p in context.TBL_Productos select p.Nombre_producto).ToList();
                return Productos;
            }
        }

        //Método encargado de añadir productos al detalle de factura.
        public void AgregarProducto_DetalleFactura(string Product_Description, string Product_Code, decimal Unitary_Price, int Quantity)
        {
            TBL_Detalle_Factura CurrentBillDetails = new TBL_Detalle_Factura();

            if (Quantity == 0)
            {
                return;
            }
            else
            {
                CurrentBillDetails.Descripcion_Producto = Product_Description;
                CurrentBillDetails.Codigo = Product_Code;
                CurrentBillDetails.Precio_unitario = Unitary_Price;
                CurrentBillDetails.Cantidad = Quantity;
                CurrentBillDetails.Id_estado = 1;
                CurrentBillDetails.Id_factura = null;
            }
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                context.TBL_Detalle_Factura.Add(CurrentBillDetails);
                context.SaveChanges();
            }
        }

        public void Modificar_Stock_Producto(int ID_Factura)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {

                List<TBL_Detalle_Factura> Detalle = new List<TBL_Detalle_Factura>();
                TBL_Productos Producto = new TBL_Productos();

                Detalle = (from p in context.TBL_Detalle_Factura where p.Id_factura == ID_Factura select p).ToList();

                foreach (var item in Detalle)
                {
                    Producto = (from p in context.TBL_Productos select p).Where(x => x.Codigo == item.Codigo).FirstOrDefault();
                    Producto.Stock_Actual = Producto.Stock_Actual - item.Cantidad;
                }
                context.SaveChanges();
            }
        }

        //Método encargado de ligar el detalle de factura a la factura. 
        public void Ligar_DetalleFactura_Factura(int ID_Factura)
        {
            using(ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                context.SP_Modificar_Detalle_Factura(ID_Factura);
                this.Modificar_Stock_Producto(ID_Factura);
                context.SaveChanges();
            }
        }

        #endregion

        #region Métodos para el proceso de facturación (Cliente Estándar):

        //Método para calcular el descuento estándar que será aplicado.
        public decimal DescuentosEstandar(int cantidad)
        {
            string dia;

            TBL_DescuentosEstandar dd = new TBL_DescuentosEstandar();

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())

            {

                if (DateTime.Now.DayOfWeek.ToString() == "Monday")
                {
                    dia = "Lunes";
                    int CantidadActual = 0;
                    var datos1 = (from p in context.TBL_DescuentosEstandar select p).Where(x => x.Dia == dia && x.Cantidad_Minima <= cantidad && x.Cantidad_Maxima >= cantidad).FirstOrDefault();

                    if (datos1 == null)
                    {
                        descEstandar = 0;
                    }
                    else
                    {
                        descEstandar = datos1.Descuento;
                    }

                }

                if (DateTime.Now.DayOfWeek.ToString() == "Tuesday")
                {
                    dia = "Martes";
                    int CantidadActual = 0;
                    var datos1 = (from p in context.TBL_DescuentosEstandar select p).Where(x => x.Dia == dia && x.Cantidad_Minima <= cantidad && x.Cantidad_Maxima >= cantidad).FirstOrDefault();

                    if (datos1 == null)
                    {
                        descEstandar = 0;
                    }
                    else
                    {
                        descEstandar = datos1.Descuento;
                    }

                }

                if (DateTime.Now.DayOfWeek.ToString() == "Wednesday")
                {
                    dia = "Miércoles";
                    int CantidadActual = 0;
                    var datos1 = (from p in context.TBL_DescuentosEstandar select p).Where(x => x.Dia == dia && x.Cantidad_Minima <= cantidad && x.Cantidad_Maxima >= cantidad).FirstOrDefault();

                    if (datos1 == null)
                    {
                        descEstandar = 0;
                    }
                    else
                    {
                        descEstandar = datos1.Descuento;
                    }

                }

                if (DateTime.Now.DayOfWeek.ToString() == "Thursday")
                {
                    dia = "Jueves";
                    int CantidadActual = 0;
                    var datos1 = (from p in context.TBL_DescuentosEstandar select p).Where(x => x.Dia == dia && x.Cantidad_Minima <= cantidad && x.Cantidad_Maxima >= cantidad).FirstOrDefault();

                    if (datos1 == null)
                    {
                        descEstandar = 0;
                    }
                    else
                    {
                        descEstandar = datos1.Descuento;
                    }
                }

                if (DateTime.Now.DayOfWeek.ToString() == "Friday")
                {
                    dia = "Viernes";
                    int CantidadActual = 0;
                    var datos1 = (from p in context.TBL_DescuentosEstandar select p).Where(x => x.Dia == dia && x.Cantidad_Minima <= cantidad && x.Cantidad_Maxima >= cantidad).FirstOrDefault();

                    if (datos1 == null)
                    {
                        descEstandar = 0;
                    }
                    else
                    {
                        descEstandar = datos1.Descuento;
                    }

                }

                if (DateTime.Now.DayOfWeek.ToString() == "Saturday")
                {
                    dia = "Sábado";
                    int CantidadActual = 0;
                    var datos1 = (from p in context.TBL_DescuentosEstandar select p).Where(x => x.Dia == dia && x.Cantidad_Minima <= cantidad && x.Cantidad_Maxima >= cantidad).FirstOrDefault();

                    if (datos1 == null)
                    {
                        descEstandar = 0;
                    }
                    else
                    {
                        descEstandar = datos1.Descuento;
                    }


                }
                if (DateTime.Now.DayOfWeek.ToString() == "Sunday")
                {
                    dia = "Domingo";
                    int CantidadActual = 0;
                    var datos1 = (from p in context.TBL_DescuentosEstandar select p).Where(x => x.Dia == dia && x.Cantidad_Minima <= cantidad && x.Cantidad_Maxima >= cantidad).FirstOrDefault();

                    if (datos1 == null)
                    {
                        descEstandar = 0;
                    }
                    else
                    {
                        descEstandar = datos1.Descuento;
                    }
                }
                return descEstandar;
            }
        }

        //Método para calcular el subtotal.
        public decimal SubTotal(string codigo, int cantidadTotal)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                decimal Total;

                var producto = context.TBL_Productos.Where(x => x.Codigo == codigo).SingleOrDefault();
                Total = cantidadTotal * producto.Precio_producto; 
                context.SaveChanges();
                return Total;
            }
        }

        // Método para determinar el monto una vez hecha la reducción del descuento (Estándar).
        public decimal MontoMenosDescuentoTotal(int cantidad, string codigo)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                decimal resultado;
                var producto = context.TBL_Productos.Where(x => x.Codigo == codigo).SingleOrDefault();
                resultado = SubTotal(codigo, cantidad) - DescuentosEstandar(cantidad);

                return resultado;
            }
        }

        // Método para determinar la cantidad de impuestos según el total (Estándar).
        public decimal ImpuestosTotalEstandar(int cantidad, string codigo)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var producto = context.TBL_Productos.Where(x => x.Codigo == codigo).SingleOrDefault();
                decimal TotalImuestos = (MontoMenosDescuentoTotal(cantidad, codigo)) * 13 / 100;

                return TotalImuestos;
            }

        }

        // Método para determinar el total Estándar.
        public decimal TotalEstandar(int cantidad, string codigo)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())

            {
                var producto = context.TBL_Productos.Where(x => x.Codigo == codigo).SingleOrDefault();

                decimal MenosDescuentoTotal;
                decimal TotalImuestos;
                decimal TOTAL;

                MenosDescuentoTotal = MontoMenosDescuentoTotal(cantidad, codigo);
                TotalImuestos = ImpuestosTotalEstandar(cantidad, codigo);
                TOTAL = TotalImuestos;
                TOTAL = TOTAL + MenosDescuentoTotal;
                return TOTAL;
            }

        }
        #endregion

        #region Métodos para el proceso de facturación (Cliente VIP):

        //Método para aplicar el descuento VIP.
        public int DescuentosVIP(int ptosUsados, string id)
        {

            int Totaldesc;

            TBL_DescuentosVIP ptos = new TBL_DescuentosVIP();

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {

                var client = context.TBL_Clientes.Where(x => x.Identificacion == id).SingleOrDefault();
                var p = context.TBL_DescuentosVIP.SingleOrDefault();
                PuntosActuales = client.Puntos_acumulados.GetValueOrDefault();

                if (client.Puntos_acumulados >= ptosUsados || client.Puntos_acumulados > 0)
                {
                    client.Puntos_acumulados = client.Puntos_acumulados.GetValueOrDefault() - ptosUsados;
                    Totaldesc = ptosUsados * p.Descuento;
                    descVIP = Totaldesc;
                    context.SaveChanges();

                }
                else
                {

                    descVIP = 0;

                }


            }
            return descVIP;


        }

        // Método para determinar el total menos el descuento VIP.
        public decimal MontoDescuentoTotalVIP(int ptos, string identificacion, int cantidad, string codigo)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())

            {
                decimal St;
                decimal Td;
                decimal Total;
                var producto = context.TBL_Productos.Where(x => x.Codigo == codigo).SingleOrDefault();
                St = SubTotal(codigo, cantidad);
                Total = St - descVIP;

                return Total;

            }

        }

        // Método para determinar el total de impuesto para el cliente VIP.
        public decimal TotalImpuestosVIP(int ptos, string identificacion, int cantidad, string codigo)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())

            {
                int IVA;
                decimal Total;
                decimal MDTV;
                MDTV = MontoDescuentoTotalVIP(ptos, identificacion, cantidad, codigo);

                Total = MDTV * 13 / 100;


                return Total;

            }

        }

        //Método para calcular el monto final una vez hecha la reducción del descuento (VIP).
        public decimal TotalVIP(int ptos, string identificacion, int cantidad, string codigo)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())

            {
                decimal TIV;
                decimal Total;
                decimal MDTV;

                TIV = TotalImpuestosVIP(ptos, identificacion, cantidad, codigo);
                MDTV = MontoDescuentoTotalVIP(ptos, identificacion, cantidad, codigo);
                Total = MDTV + TIV;

                return Total;

            }

        }

        // Método para determinar el total VIP sin aplicar descuento.
        public decimal TotalVIPSinDescuento(int cantidad, string codigo)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())

            {
                var producto = context.TBL_Productos.Where(x => x.Codigo == codigo).SingleOrDefault();

                decimal Subtotal;
                decimal TotalImuestos;
                decimal TOTAL;

                Subtotal = SubTotal(codigo, cantidad);
                TotalImuestos = ImpuestosTotalVIP(cantidad, codigo);
                TOTAL = Subtotal + TotalImuestos;
                return TOTAL;
            }

        }

        // Método para determinar la cantidad de impuestos según el total (VIP).
        public decimal ImpuestosTotalVIP(int cantidad, string codigo)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())

            {
                var producto = context.TBL_Productos.Where(x => x.Codigo == codigo).SingleOrDefault();

                decimal Subtotal;
                decimal TotalImuestos;

                Subtotal = SubTotal(codigo, cantidad);

                TotalImuestos = Subtotal * 13 / 100;

                return TotalImuestos;
            }

        }
        #endregion

        #region Métodos para el proceso de devolución:

        // Método para obtener los datos de una factura según el número de factura.
        public TBL_Factura Mostrar_FacturaXNumero(int ID_Factura)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var Datos_Factura = (from p in Context.TBL_Factura select p).Where(x => x.Id_factura == ID_Factura).FirstOrDefault();
                return Datos_Factura;
            }
        }

        // Método para obtener los datos de un cliente asociado a una factura.
        public TBL_Clientes Mostrar_ClienteXNumero(int ID_Cliente_Factura)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var Datos_Factura = (from p in Context.TBL_Clientes select p).Where(x => x.Id_cliente == ID_Cliente_Factura).FirstOrDefault();
                
                return Datos_Factura;
            }
        }

        // Método para obtener los datos asociados a un detalle de factura asociado a un número de factura. 
        public List<TBL_Detalle_Factura> Mostrar_DetalleFacturaXNumero(int ID_Factura)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var Datos_Factura = (from p in Context.TBL_Detalle_Factura where p.Id_factura == ID_Factura select p).ToList();
                return Datos_Factura;
            }
        }

        public TBL_Detalle_Factura Obtener_Datos_DetalleFactura(int ID_Detalle_Factura)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var Datos_Factura = (from p in Context.TBL_Detalle_Factura select p).Where(x => x.Id_detalle_factura == ID_Detalle_Factura).FirstOrDefault();

                return Datos_Factura;
            }
        }

        // Método para insertar una devolución en la base de datos. 
        public void Insertar_Devolucion(string Razon_Devolucion, string Estado_Fisico, decimal Monto_Devolucion, string Estado_Inventario, string Descripcion, int ID_Factura, int ID_Cliente)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                TBL_Devoluciones datos = new TBL_Devoluciones();

                datos.Razon_Devolucion = Razon_Devolucion;
                datos.Estado_Fisico = Estado_Fisico;
                datos.MontoDevolucion = Monto_Devolucion;
                datos.Estado_Inventario = Estado_Inventario;
                datos.Descripcion = Descripcion;
                datos.Id_factura = ID_Factura;
                datos.Id_cliente = ID_Cliente;
                datos.Id_Estado = 1;

                context.TBL_Devoluciones.Add(datos);
                context.SaveChanges();
            }
        }

        // Método para listar las devoluciones
        public List<TBL_Devoluciones> Mostrar_Devoluciones()
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var Datos_Factura = (from p in Context.TBL_Devoluciones select p).ToList();
                return Datos_Factura;
            }
        }

        // Método para activar una devolución.

        public void Activar_Devolución(int ID_Devolucion)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                try
                {
                    var Devolucion = context.TBL_Devoluciones.Where(x => x.Id_Devolucion == ID_Devolucion).SingleOrDefault();
                    Devolucion.Id_Estado = 1;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // Método para desactivar una devolución. 
        public void Desactivar_Devolución(int ID_Devolucion)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                try
                {
                    var Devolucion = context.TBL_Devoluciones.Where(x => x.Id_Devolucion == ID_Devolucion).SingleOrDefault();
                    Devolucion.Id_Estado = 2;
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        #endregion

        #endregion

        // |---------------------| Fin de los métodos para Punto de Venta |------------------------| //
        // |------------------------|-------------------------------------|------------------------| //
        // |-----------------------| Métodos para el módulo de Inventario|-------------------------| //

        #region Compilación de Métodos.

        #region Métodos Órdenes de Fabricación:

        // Método para listar las órdenes de fabricación.
        public List<sp_Mostrar_Ordenes_Fabricacion_Result> MostrarOrdenesFabricacion()
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var estado = context.sp_Mostrar_Ordenes_Fabricacion().ToList();

                return estado;
            }

        }

        #endregion

        #endregion

        // |-----------------------| Fin de los métodos para Inventario |--------------------------| //
        // |------------------------|-------------------------------------|------------------------| //
        // |----------------------| Métodos para el módulo de Contabilidad |-----------------------| //

        #region Compilación de métodos.

        #region Métodos para Listar Información de Contabilidad.

        // Método para listar los cierre de caja. |Pendiente de solucionar|

        public List<Sp_Listar_CierreCajas_Result> MostrarCierreCajas()
        {

            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var List = Context.Sp_Listar_CierreCajas().ToList();

                return List;
            }
        }

        // Método para listar las cuentas por cobrar. 

        public List<Sp_Listar_CuentasCobrar_Result> MostrarCuentasCobrar()
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var Lista = context.Sp_Listar_CuentasCobrar().ToList();

                return Lista;
            }
        }

        // Método para listar las cuentas por pagar. 

        public List<Sp_Listar_CuentasPagar_Result> MostrarCuentasPagar()
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var Lista = context.Sp_Listar_CuentasPagar().ToList();

                return Lista;
            }
        }

        // Método para listar el reporte de cierre de cajas. 

        public void MostrarReporteCierreCajas()
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                Total_Ventas_Contado = Convert.ToInt32(context.TBL_CierreCajas.Where(x => x.Forma_Pago == "Contado").Sum(x => x.Entradas));
            }
        }

        // Método para listar el reporte de cuentas por cobrar. 

        public List<Sp_Listar_ReporteCuentasXCobrar_Result> MostrarReporteCuentasXCobrar()
        {

            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                var Lista = context.Sp_Listar_ReporteCuentasXCobrar().ToList();

                return Lista;
            }
        }

        #endregion

        #region Métodos para Filtrar Información de Contabilidad.

        // Método para filtrar datos de Cierre de Cajas. 
        public List<Sp_Filtrar_CierreCajas_Result> FiltrarCierreCajas(int ID_Cierre_Cajas)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var Lista_Cierre_Cajas = Context.Sp_Filtrar_CierreCajas(ID_Cierre_Cajas).ToList();

                if (Lista_Cierre_Cajas != null)
                {

                    return Lista_Cierre_Cajas;
                }
                else
                {
                    return null;
                }
            }
        }

        // Método para filtrar datos de Cuentas por Cobrar.
        public List<Sp_Filtrar_CuentasCobrar_Result> FiltrarCuentasCobrar(int ID_Cuenta_Cobrar)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var Lista_Cuenta_Cobrar = Context.Sp_Filtrar_CuentasCobrar(ID_Cuenta_Cobrar).ToList();

                if (Lista_Cuenta_Cobrar != null)
                {

                    return Lista_Cuenta_Cobrar;
                }
                else
                {
                    return null;
                }
            }
        }

        // Método para filtrar datos de Cuentas por Pagar.
        public List<Sp_Filtrar_Pagar_Result> FiltrarCuentasPagar(int ID_Cuenta_Pagar)
        {
            using (ProyectoFinalBeerLabEntities Context = new ProyectoFinalBeerLabEntities())
            {
                var Lista_Cuenta_Pagar = Context.Sp_Filtrar_Pagar(ID_Cuenta_Pagar).ToList();

                if (Lista_Cuenta_Pagar != null)
                {

                    return Lista_Cuenta_Pagar;
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion

        #region Métodos para Insertar Datos de Contabilidad.

        // --| Métodos para insertar información de Contabilidad|--

        // Método para insertar datos al cierre de cajas (Facturación).

        public void Insertar_CierreCajas_Facturacion(DateTime Fecha_Cierre, string Tipo_Factura, string Forma_Pago, decimal Total, int Id_Factura)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                context.Sp_Insertar_CierreFacturas(Id_Factura, Fecha_Cierre, Tipo_Factura, Forma_Pago,Total);
                context.SaveChanges();
            }
        }

        // Método para insertar datos al cierre de cajas (Devolución).

        public void Insertar_CierreCajas_Devolucion(DateTime Fecha_Cierre, string Tipo_Factura, string Forma_Pago, decimal Total, int Id_Factura)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                context.Sp_Insertar_CierreFacturas(Id_Factura, Fecha_Cierre, Tipo_Factura, Forma_Pago, Total);
                context.SaveChanges();
            }
        }

        // Método para insertar datos al cierre de cajas (Merma).

        // Método para insertar datos al cierre de cajas (Reciclaje).

        // Método para insertar cuentas por cobrar.

        public void Insertar_CuentaCobrar_Facturacion(DateTime Fecha_Facturacion, string Identificacion, string Nombre_Cliete, decimal Interes_Mora, decimal Total_Facturado, int Id_Factura)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                TBL_CuentasCobrar CXC = new TBL_CuentasCobrar();

                if (Identificacion == "" || Id_Factura == 0)
                {
                    return;
                }
                else
                {
                    CXC.Fecha_Facturacion = Fecha_Facturacion;
                    CXC.Fecha_Vencimiento = Fecha_Facturacion.AddDays(30);
                    CXC.Identificacion_Cliente = Identificacion;
                    CXC.Nombre_Cliente = Nombre_Cliete;
                    CXC.Interes_Mora = Interes_Mora;
                    CXC.Total_Facturado = Total_Facturado;
                    CXC.Id_factura = Id_Factura;

                    context.TBL_CuentasCobrar.Add(CXC);
                    context.SaveChanges();
                }
            }
        }

        // Método para insertar cuentas por pagar.

        public void Insertar_CuentaXPagar_Devolucion(int ID_Client, DateTime Fecha_Factura, string Tipo_Devolucion,decimal Monto_Devolucion, int Id_Factura)
        {
            using (ProyectoFinalBeerLabEntities context = new ProyectoFinalBeerLabEntities())
            {
                TBL_Cuentas_por_pagar CXP = new TBL_Cuentas_por_pagar();

                if (ID_Client == 0 || Id_Factura == 0)
                {
                    return;
                }
                else
                {
                    CXP.Id_Cliente = ID_Client;
                    CXP.Fecha_factura = Fecha_Factura;
                    CXP.Tipo_devolucion = Tipo_Devolucion;
                    CXP.Monto_devolucion = Monto_Devolucion;
                    CXP.Id_factura = Id_Factura;

                    context.TBL_Cuentas_por_pagar.Add(CXP);
                    context.SaveChanges();

                }
            }
        }

        #endregion

        #endregion

        // |-----------------------| Fin de los métodos para Contabilidad |------------------------| //
        // |------------------------|-------------------------------------|------------------------| //

    }

}