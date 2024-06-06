using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TolyID.Model
{
    public class Ficha_Anestesica
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Ficha { get; set; }

        [ForeignKey(typeof(Captura))]
        public int Id_Captura { get; set; }

        [ManyToOne]
        public Captura Captura { get; set; }

        public string Tipo_Anestesico { get; set; }
        public double Dose { get; set; }
        public string Via_Adm { get; set; }
        public string Observacao { get; set; }
    }
}
