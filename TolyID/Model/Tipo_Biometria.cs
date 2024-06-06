using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TolyID.Model
{
    public class Tipo_Biometria
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Tipo { get; set; }
        public string Nome_Bio { get; set; }

        [OneToMany]
        public List<Biometria> Biometrias { get; set; }
    }
}
