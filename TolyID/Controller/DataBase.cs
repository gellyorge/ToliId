using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TolyID.MVVM.Model;

namespace TolyID.Controller
{
    class DataBase
    {
        private static readonly string _path = Path.Combine(FileSystem.AppDataDirectory, "TolyId.db3");
        private static readonly SQLiteConnection conn;

        static DataBase()
        {            
            conn = new SQLiteConnection(_path);
            conn.Execute("PRAGMA foreign_keys = ON;"); //   é executado sempre que a conexão é aberta para garantir que as restrições de chave estrangeira sejam respeitadas.

            //inicia as tabelas caso nao exista
            //
            conn.CreateTable<Amostra>();
            conn.CreateTable<Animal>();
            conn.CreateTable<Biometria>();
            conn.CreateTable<Captura>();
            conn.CreateTable<Cientista>();
            conn.CreateTable<Equipe>();
            conn.CreateTable<Ficha_Anestesica>();
            conn.CreateTable<Tipo_Amostra>();
            conn.CreateTable<Parametros>();
            conn.CreateTable<Tempo_Anest>();
            conn.CreateTable<Tipo_Biometria>();
            //
        }

        public static SQLiteConnection GetConnection()
        {
            
            return conn;
        }
    }
}
