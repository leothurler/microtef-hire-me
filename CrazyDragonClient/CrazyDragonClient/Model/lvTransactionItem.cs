using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDragonClient.Model
{
    /// <summary>
    /// Classe que representa os dados da listview da tela de transações
    /// </summary>
    public class lvTransactionItem
    {
        public string amount { get; set; }
        public string type { get; set; }
        public string number { get; set; }
        public string cardName { get; set; }
        public string cardNumber { get; set; }
        public string cardExpDate { get; set; }
        public string cardBrand { get; set; }
    }
}
