using SQLite;
using SQLiteNetExtensions.Attributes;
using System;

namespace TolyID.Model
{
    public class Captura
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string LocalCap { get; set; }
        public string Coordenadas { get; set; }
        public DateTime DataCap { get; set; }
        public string ObservacaoCap { get; set; }

        [ForeignKey(typeof(Amostra))]
        public int IdAmostra { get; set; }

        [ForeignKey(typeof(Equipe))]
        public int IdEquipe { get; set; }

        [ForeignKey(typeof(Animal))]
        public int AnimalId { get; set; }

        [OneToOne]
        public Amostra Amostra { get; set; }

        [OneToOne]
        public Equipe Equipe { get; set; }

        [OneToOne]
        public Animal Animal { get; set; }

    }
}
