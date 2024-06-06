using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TolyID.Model
{
    public class Cientista
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Cientista { get; set; }

        [ForeignKey(typeof(Equipe))]
        public int? Id_EquipeFk { get; set; }

        [ManyToOne]
        public Equipe Equipe { get; set; }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Instituicao { get; set; }
        public string Senha { get; set; }
    }
}
