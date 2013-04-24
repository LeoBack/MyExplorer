﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Controles
{
    public class classTextos
    {
        //TitulosFrm
        public string SeparadorTitulo = " -> Dr. ";
        public string TituloLogin = " -> Sesion No Iniciada";
        public string TituloAdministradorUsuario = "Administrador de Usuarios.";
        public string TituloListaUsuarios = "Planilla de Usuarios del Sistema.";
        public string TituloObrasSociales = "Obras Sociales";
        public string TituloObraSocial = "Obra Social - Detalles";
        public string TituloFichaPaciente = "Ficha Medica";

        //
        public string Nombre = "Nombre";
        public string Aplicar  = "Aplicar";
        public string Editar = "Editar";
        public string Limpiar = "Limpiar";
        public string Bloquear = "Bloquear";
        public string Desbloquear = "Desloquear";

        public string AccionIndefinida = "Accion no definida";

        // Errores
        public string ErrorListaConsulta = "Error al obtener registros.";
        public string ErrorActualizarConsulta = "Error al actualizar registros.";
        public string ErrorEliminarConsulta = "Error al eliminar registros.";
        public string ErrorAgregarConsulta = "Error al agregar registros.";
        public string ErrorObjetoIndefinido = "Error: Objeto indefinido";

        // Validaciones
        public string CasillaBusquedaVacia = "Ingrese un criterio de búsqueda.";
        public string CaillasVacias = "Se encontraron casillas vacias";
        public string None = "No Aplica";
        public string LoginInvalido = "El nombre de usuario o contraseña no es valido.";
        public string CerrarSesion = "Cerrar Sesion";
        public string IniciarSesion = "Iniciar Sesion";

        //Usuario
        public string AgregarUsuario = "El Usuario a sido grabado con exito.";
        public string ModificarUsuario = "El Usuario a sido actualizado con exito.";
        public string MostrarUsuariosBloqueados = "Mostrar usuarios bloqueados";
        public string OcultarUsuariosBloqueados = "Ocultar usuarios bloqueados";

        //Barrio
        public string Barrio = "Barrio";
        public string ModificarBarrio = "Modificar barrio.";
        public string AgregarBarrio = "Agregar barrio.";

        //Ciudad
        public string Ciudad = "Ciudad";
        public string ModificarCiudad = "Modificar ciudad.";
        public string AgregarCiudad = "Agregar ciudad.";

        //patología
        public string Patología = "Patología";
        public string ModificarPatología = "Modificar patología.";
        public string AgregarPatología = "Agregar patología.";

        //ObraSocial
        public string AgregarObraSocial = "Obra Social agregada con exito.";
        public string ModificarObraSocial = "Obra Social actualizada con exito.";

        //Mensajes
        public string MsgTituloCerrarAplicacion = "Atencion";
        public string MsgCerrarAplicacion = "¿Deseas cerrar la Aplicación?";
        public string MsgTituloDiagnostico = "Atencion";
        public string MsgEliminarDiagnostico = "La accion eliminara el diagnostico\n¿Desea Continuar?";
        public string MsgTituloHistoriClinica = "Armando planilla";
        public string MsgHistoriaClinica = "SI - La planilla mostrara los registros visualizados.\nNO - La planilla mostrara los registros que cumplan la condicion.";

        //Pacientes
        public string AgregarPaciente = "El Paciente a sido grabado con exito.";
        public string ModificarPaciente = "El Paciente a sido actualizado con exito.";
        public string PacienteSeleccionado = "Paciente Seleccionado : ";

        //Conexciones
        public string ConexionExitosa = "Conexion establecida";
        public string ConexionNuevaExitosa = "Nueva coneccion establecida";
        public string ConexionErronea = "Error al conectar";
        public string RestauracionExitosa = "Copia levantada con Exito!";
        public string RestauracionErronea = "A ocurrido un error al realizar la copia.";
        public string CopiaExitosa = "Copia realizada con Exito!";
        public string CopiaErronea = "A ocurrido un error al realizar la copia.";
    }
}
