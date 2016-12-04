using System.Text.RegularExpressions;
using ThurlerSolutionsServer.Enum;
using ThurlerSolutionsServer.Models;

/// <summary>
/// Classe responsável por realizar as validações dos serviços do usuário.
/// </summary>
namespace ThurlerSolutionsServer.Helper
{
    public class UserHelper
    {
        public static UserHelper instance;

        private UserHelper()
        {
        }

        public static UserHelper getInstance()
        {
            if (instance == null)
                instance = new UserHelper();

            return instance;
        }

        /// <summary>
        /// Classe responsável por realizar as validações dos dados de um usuário novo.
        /// </summary>
        public bool validateUser(User user, out string error)
        {
            bool validateStatus = true;

            error = "";

            if(string.IsNullOrEmpty(user.name))
                error = "{\"Sucess\":\"false\",\"Code\":\"" + UserReturnEnum.USER_NAME_REQUIRED + "\",\"Message\":\"Informe o nome do usuário\"}";
            else if (string.IsNullOrEmpty(user.login))
                error = "{\"Sucess\":\"false\",\"Code\":\"" + UserReturnEnum.USER_LOGIN_REQUIRED + "\",\"Message\":\"Informe o login do usuário\"}";
            else if (string.IsNullOrEmpty(user.password))
                error = "{\"Sucess\":\"false\",\"Code\":\"" + UserReturnEnum.USER_PASSWORD_REQUIRED + "\",\"Message\":\"Informe a senha do usuário\"}";
            else if (!(user.password.Length >= 6 && user.password.Length <= 8))
                error = "{\"Sucess\":\"false\",\"Code\":\"" + UserReturnEnum.INVALID_PASSWORD_SIZE + "\",\"Message\":\"Erro no tamanho da senha: A senha deve ter entre 6 e 8 dítigos\"}";
            else if (!Regex.IsMatch(user.password, "[A-Z]"))
                error = "{\"Sucess\":\"false\",\"Code\":\"" + UserReturnEnum.INVALID_PASSWORD + "\",\"Message\":\"Senha inválida: A senha deve conter ao menos um caracter maiúsculo\"}";

            if (!string.IsNullOrEmpty(error))
                validateStatus = false;

            return validateStatus;
        }
    }
}