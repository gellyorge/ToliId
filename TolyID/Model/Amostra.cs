using SQLiteNetExtensions.Attributes;
using SQLite;

namespace TolyID.Model
{
    public class Amostra
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Amostra { get; set; }
        public string Valor_Amostra { get; set; }

        [ForeignKey(typeof(Tipo_Amostra))]
        public int Id_Tipo_Amostra { get; set; }

        [OneToOne]
        public Tipo_Amostra TipoAmostra { get; set; }
        [OneToOne]
        public Captura Capturas { get; set; }
    }
}
