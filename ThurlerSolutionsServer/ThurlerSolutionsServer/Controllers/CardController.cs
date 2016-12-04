using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
using ThurlerSolutionsServer.Enum;
using ThurlerSolutionsServer.Models;
using ThurlerSolutionsServer.Utils;

namespace ThurlerSolutionsServer.Controllers
{
    /// <summary>
    /// Classe responsável pelos serviços referentes aos dados dos cartões dos usuários.
    /// </summary>
    public class CardController : ApiController
    {
        //TODO: IMPLEMENTAR VALIDAÇÂO PARA PERMITIR SOMENTE UM CARTÂO COM O MESMO NÚMERO

        public static Dictionary<string, List<Card>> cards = new Dictionary<string, List<Card>>();

        public CardController()
        {
            if(cards.Count == 0)
            {         
                //Cartão mocado para teste
                List<Card> listCards = new List<Card>();
                Card card = new Card("leo","Leo P Thurler", "1", "20/11/2050", "Visa", PasswordEncryptUtil.getInstance().encryptPassword("1234"), "CHIP", "500");

                listCards.Add(card);

                cards.Add("leo", listCards);
            }
        }

        [HttpPost]
        [ActionName("registerCard")]
        public HttpResponseMessage registerCard([FromBody] Card cardData)
        {
            List<Card> userCards = null;
            string returnJson;

            if ( true ) //TODO: IMPLEMENTAR VALIDAÇÂO DOS DADOS DO CARTÃO
            {
                cards.TryGetValue(cardData.userLogin, out userCards);

                if (userCards == null)
                {
                    userCards = new List<Card>();
                    cards.Add(cardData.userLogin, userCards);
                }

                cardData.password = PasswordEncryptUtil.getInstance().encryptPassword(cardData.password);

                userCards.Add(cardData);

                returnJson = "{\"Sucess\":\"true\",\"Code\":\"" + CardReturnEnum.CARD_REGISTER_SUCESS + "\",\"Message\":\"Cartão Registrado com sucesso.\"}";
            }



            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(returnJson, Encoding.UTF8, "application/json");

            return response;
        }

        [HttpGet]
        [ActionName("getUserCards")]
        public HttpResponseMessage getUserCards(string userLogin)
        {
            string returnJson;
            List<Card> userCards = null;

            cards.TryGetValue(userLogin, out userCards);

            if (userCards != null)
                returnJson = "{\"Sucess\":\"true\",\"Code\":\"" + CardReturnEnum.CARD_RETURN_SUCESS + "\",\"Message\":\"Cartões retornadas\", \"Data\": " + new JavaScriptSerializer().Serialize(userCards) + " }";
            else
                returnJson = "{\"Sucess\":\"false\",\"Code\":\"" + CardReturnEnum.CARD_RETURN_ERROR + "\",\"Message\":\"Não foi possível consultar os cartões\"}";

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(returnJson, Encoding.UTF8, "application/json");

            return response;
        }
    }
}
