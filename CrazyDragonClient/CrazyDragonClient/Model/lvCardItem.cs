using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyDragonClient.Model
{
    /// <summary>
    /// Classe que representa os dados da listview da tela de cartões
    /// </summary>
    public class lvCardItem
    {
        public string cardName { get; set; }
        public string cardNumber { get; set; }
        public string cardBalance { get; set; }
        public string cardExpDate { get; set; }
        public string cardBrand { get; set; }
        public string cardType { get; set; }
    }
}
