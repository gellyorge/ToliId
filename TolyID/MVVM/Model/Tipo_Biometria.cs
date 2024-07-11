using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TolyID.MVVM.Model
{
    public class Tipo_Biometria
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Tipo { get; set; }
        public string Nome_Bio { get; set; }

        [OneToOne]
        public Biometria Biometrias { get; set; }
    }
}
