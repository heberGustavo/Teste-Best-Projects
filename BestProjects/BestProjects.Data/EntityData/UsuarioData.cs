using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestProjects.Data.EntityData
{
    [Table("Usuario")]
    public class UsuarioData
    {
        [Key]
        public int id_usuario { get; set; }
        public int id_tipo_usuario { get; set; }
        public bool status { get; set; }
    }
}
