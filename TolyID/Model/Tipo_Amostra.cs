using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace TolyID.Model
{
    public class Tipo_Amostra
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Tipo_Amostra { get; set; }
        public string Nome_Amostra { get; set; }

        [OneToMany]
        public List<Amostra> Amostras { get; set; }
    }
}
