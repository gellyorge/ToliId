using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TolyID.MVVM.Model
{
    public class Parametros
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Parametros { get; set; }

        [ForeignKey(typeof(Ficha_Anestesica))]
        public int Id_Ficha_Anes { get; set; }

        [OneToOne]
        public Ficha_Anestesica FichaAnestesica { get; set; }

        public string FC { get; set; }
        public string FR { get; set; }
        public string Oximetria { get; set; }
        public double Temperatura { get; set; }
    }
}
