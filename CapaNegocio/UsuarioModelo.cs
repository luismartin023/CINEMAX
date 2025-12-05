using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    
            public class UsuarioModelo
            {
            // El ID único del usuario (en la base de datos es UNIQUEIDENTIFIER)
            public Guid Id { get; set; }

            // El nombre de usuario para el login (ej: "admin")
            public string NombreUsuario { get; set; }

            // La contraseña (que luego encriptaremos)
            public string PasswordHash { get; set; }

            // El nombre real de la persona (ej: "Juan Perez")
            public string Nombre { get; set; }

            // Nombre del archivo de imagen (ej: "avatar1.png")
            public string FotoPerfil { get; set; }

            // ¡IMPORTANTE! Esto le dice al programa si bloqueamos opciones o no
            public bool EsInvitado { get; set; }

            // Correo (puede estar vacío si es invitado)
            public string CorreoOpcional { get; set; }

            // Para guardar gustos o configuración visual (JSON)
            public string PreferenciasJSON { get; set; }
            }
}

