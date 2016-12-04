using System.Collections.Generic;
using ThurlerSolutionsServer.Controllers;
using ThurlerSolutionsServer.Enum;
using ThurlerSolutionsServer.Models;
using ThurlerSolutionsServer.Utils;

/// <summary>
/// Classe responsável por realizar as validações das transações.
/// </summary>
namespace ThurlerSolutionsServer.Helper
{
    public class TransactionHelper
    {
        public static TransactionHelper instance;

        private TransactionHelper()
        {
        }

        public static TransactionHelper getInstance()
        {
            if (instance == null)
                instance = new TransactionHelper();

            return instance;
        }

        /// <summary>
        /// Método responsável por realizar as validações dos dados da transação
        /// </summary>
        /// <param name="transaction">Dados da transação</param>
        /// <param name="error">Caso tenha algum erro de validação essa variável é preenchida com o json de retorno</param>
        /// <param name="cardData">Retorna os dados do cartão utilizado</param>
        /// <returns>Retorna verdadeiro caso a transação seja válida e falso caso não seja.</returns>
        public bool validateTransaction( Transaction transaction, out string error, out Card cardData )
        {
            bool validateStatus = true;

            error = "";
            cardData = null;

            if ( float.Parse(transaction.amount) < 0.1 )
                error = "{\"Sucess\":\"false\",\"Code\":\"" + TransactionReturnEnum.INVALID_VALUE + "\",\"Message\":\"Valor inválido: mínimo de 10 centavos.\"}";

            else
            {
                List<Card> userCards = null;

                CardController.cards.TryGetValue(transaction.userLogin, out userCards);

                if(userCards != null)
                {
                    cardData = userCards.Find( x => x.number.Equals(transaction.card.number) && x.password.Equals(PasswordEncryptUtil.getInstance().encryptPassword(transaction.card.password)) );

                    //TODO: IMPLEMENTAR VALIDAÇÂO DA DATA DO CARTÂO PARA VERIFICAR SE ELE ESTÁ EXPIRADO

                    if (cardData == null)
                        error = "{\"Sucess\":\"false\",\"Code\":\"" + TransactionReturnEnum.INVALID_CARD + "\",\"Message\":\"Dados do cartão inválido\"}";
                    else if (float.Parse(transaction.amount) > float.Parse(cardData.balance))
                        error = "{\"Sucess\":\"false\",\"Code\":\"" + TransactionReturnEnum.INSUFICIENTE_BALANCE + "\",\"Message\":\"Saldo Insuficiente.\"}";
                    else
                        transaction.card = cardData;
                }
                else
                    error = "{\"Sucess\":\"false\",\"Code\":\"" + TransactionReturnEnum.INVALID_CARD + "\",\"Message\":\"Dados do cartão inválido\"}";
            }
         


            if (!string.IsNullOrEmpty(error))
                validateStatus = false;

            return validateStatus;
        }
    }
}