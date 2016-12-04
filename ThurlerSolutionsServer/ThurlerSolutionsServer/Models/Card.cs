using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThurlerSolutionsServer.Models
{
    /// <summary>
    /// Classe que representa o modelo de dados de um cartão no sistema.
    /// </summary>
    public class Card
    {
        public Card( string userLogin, string cardholderName, string number, string expirationDate, string cardBrand, string password, string type, string balance)
        {
            this.userLogin = userLogin;
            this.cardholderName = cardholderName;
            this.number = number;
            this.expirationDate = expirationDate;
            this.cardBrand = cardBrand;
            this.password = password;
            this.type = type;
            this.balance = balance;
        }

        public string userLogin { get; set; }
        public string cardholderName { get; set; }
        public string number { get; set; }
        public string expirationDate { get; set; }
        public string cardBrand { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public string balance { get; set; }
        public bool hasPassword { get; set; }
    }
}