

namespace ThurlerSolutionsServer.Enum
{
    /// <summary>
    /// Classe responsavél por guarda a descrição e o código dos possíveis retornos dos serviços que envolvem o usuário
    /// </summary>
    public enum UserReturnEnum
    {
        INVALID_PASSWORD_SIZE,
        INVALID_PASSWORD,
        USER_REGISTERED,
        USER_LOGIN_SUCESS,
        USER_LOGIN_REJECT,
        USER_NAME_REQUIRED,
        USER_LOGIN_REQUIRED,
        USER_PASSWORD_REQUIRED
    }
}