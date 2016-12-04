

namespace ThurlerSolutionsServer.Enum
{
    /// <summary>
    /// Classe responsavél por guarda a descrição e o código dos possíveis retornos dos serviços que envolvem transação
    /// </summary>
    public enum TransactionReturnEnum
    {
        TRANSACTION_APROVED,
        TRANSACTION_REJECT,
        INSUFICIENTE_BALANCE,
        INVALID_VALUE,
        CARD_BLOQ,
        INVALID_PASSWORD_SIZE,
        TRANSACTION_RETURN_SUCESS,
        TRANSACTION_RETURN_ERROR,
        INVALID_CARD
    }
}