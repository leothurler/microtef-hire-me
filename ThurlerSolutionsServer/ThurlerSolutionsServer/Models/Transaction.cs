using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThurlerSolutionsServer.Models
{
    /// <summary>
    /// Classe que representa o modelo de dados de uma transação no sistema.
    /// </summary>
    public class Transaction
    {
        public string amount { get; set; }
        public string type { get; set; }
        public string number { get; set; }
        public Card card { get; set; }
        public string userLogin { get; set; }
    }
}