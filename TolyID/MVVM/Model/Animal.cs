using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TolyID.MVVM.Model
{
    public class Animal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Identificacao { get; set; }
        public double Peso { get; set; }
        public int IdMicrochip { get; set; }

        [OneToMany]
        public List<Captura> Capturas { get; set; }
    }
}
