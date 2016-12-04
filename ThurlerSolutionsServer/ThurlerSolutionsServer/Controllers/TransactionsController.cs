using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
using ThurlerSolutionsServer.Enum;
using ThurlerSolutionsServer.Helper;
using ThurlerSolutionsServer.Models;

namespace ThurlerSolutionsServer.Controllers
{
    /// <summary>
    /// Classe responsável pelos serviços referentes aos dados das transações dos usuários.
    /// </summary>
    public class TransactionsController : ApiController
    {
        public static Dictionary<string, List<Transaction>> transactions = new Dictionary<string, List<Transaction>>();

        [HttpPost]
        [ActionName("makeTransaction")]
        public HttpResponseMessage makeTransaction([FromBody] Transaction transactionData )
        {
            List<Transaction> userTransactions = null;
            string returnJson;
            Card cardData;

            if ( TransactionHelper.getInstance().validateTransaction(transactionData, out returnJson, out cardData) )
            {  
                transactions.TryGetValue(transactionData.userLogin, out userTransactions);
               
                if( userTransactions == null )
                {
                    userTransactions = new List<Transaction>();
                    transactions.Add(transactionData.userLogin, userTransactions);
                }

                userTransactions.Add(transactionData);

                cardData.balance = (float.Parse(transactionData.card.balance) - float.Parse(transactionData.amount)).ToString();

                returnJson = "{\"Sucess\":\"true\",\"Code\":\"" + TransactionReturnEnum.TRANSACTION_APROVED + "\",\"Message\":\"Transação Aprovada\"}";
            }

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(returnJson, Encoding.UTF8, "application/json");

            return response;
        }

        [HttpGet]
        [ActionName("getUserTransactions")]
        public HttpResponseMessage getUserTransactions(string userLogin)
        {
            string returnJson;
            List<Transaction> userTransactions = null;

            transactions.TryGetValue(userLogin, out userTransactions);

            if (userTransactions != null)
                returnJson = "{\"Sucess\":\"true\",\"Code\":\"" + TransactionReturnEnum.TRANSACTION_RETURN_SUCESS + "\",\"Message\":\"Transações retornadas\", \"Data\": " + new JavaScriptSerializer().Serialize(userTransactions) + " }";
            else
                returnJson = "{\"Sucess\":\"false\",\"Code\":\"" + TransactionReturnEnum.TRANSACTION_RETURN_ERROR + "\",\"Message\":\"Não foi possível consultar as transações\"}";

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(returnJson, Encoding.UTF8, "application/json");

            return response;
        }
    }
}
