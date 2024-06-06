using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TolyID.Model
{
    public class Tempo_Anest
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Tempo_Anes { get; set; }

        [ForeignKey(typeof(Ficha_Anestesica))]
        public int Id_Ficha_Anes { get; set; }

        [ManyToOne]
        public Ficha_Anestesica FichaAnestesica { get; set; }

        public string Aplicacao { get; set; }
        public string Inducao { get; set; }
        public string Retorno { get; set; }
    }
}
