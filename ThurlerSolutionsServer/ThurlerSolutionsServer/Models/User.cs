using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThurlerSolutionsServer.Models
{
    /// <summary>
    /// Classe que representa o modelo de dados de um usuário no sistema.
    /// </summary>
    public class User
    {
        public User(string login, string password, string name)
        {
            this.login = login;
            this.password = password;
            this.name = name;
        }

        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public List<Card> cards { get; set; }
    }
}