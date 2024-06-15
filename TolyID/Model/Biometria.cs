using SQLite;
using SQLiteNetExtensions.Attributes;

namespace TolyID.Model
{
    public class Biometria
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Biometria { get; set; }
        public string Valor_Bio { get; set; }

        [ForeignKey(typeof(Tipo_Biometria))]
        public int Id_Tipo { get; set; }

        [ForeignKey(typeof(Captura))]
        public int Id_Captura { get; set; }

        [OneToOne]
        public Tipo_Biometria TipoBiometria { get; set; }

        [OneToMany]
        public List<Captura> Captura { get; set; }
    }
}
