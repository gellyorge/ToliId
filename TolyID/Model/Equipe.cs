using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace TolyID.Model
{
    public class Equipe
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Equipe { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [OneToMany]
        public List<Cientista> Cientistas { get; set; }
    }
}
