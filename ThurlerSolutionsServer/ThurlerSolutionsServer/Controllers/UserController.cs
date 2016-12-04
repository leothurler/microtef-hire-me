using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using ThurlerSolutionsServer.Enum;
using ThurlerSolutionsServer.Helper;
using ThurlerSolutionsServer.Models;
using ThurlerSolutionsServer.Utils;

namespace ThurlerSolutionsServer.Controllers
{
    /// <summary>
    /// Classe responsável pelos serviços referentes aos dados dos usuários.
    /// </summary>
    public class UserController : ApiController
    {
        //TODO: IMPLEMENTAR VALIDAÇÂO PARA PERMITIR SOMENTE UM USUÁRIO COM O MESMO LOGIN

        public static List<User> users = new List<User>();

        public UserController()
        {
            if( users.Count == 0 )
            {    
                //Usuarios mocados para teste
                User user1 = new User("leo", PasswordEncryptUtil.getInstance().encryptPassword("Leo123"),"Leonardo");
                User user2 = new User("vini", PasswordEncryptUtil.getInstance().encryptPassword("Vini123"), "Vinicius");
                User user3 = new User("claudia", PasswordEncryptUtil.getInstance().encryptPassword("Claudia1"), "Claudia");

                users.Add(user1);
                users.Add(user2);
                users.Add(user3);
            }
        }

        [HttpPost]
        [ActionName("registerUser")]
        public HttpResponseMessage registerUser([FromBody] User userData)
        {
            string returnJson;

            if(UserHelper.getInstance().validateUser(userData, out returnJson))
            {
                userData.password = PasswordEncryptUtil.getInstance().encryptPassword(userData.password);
                users.Add(userData);
                returnJson = "{\"Sucess\":\"true\",\"Code\":\"" + UserReturnEnum.USER_REGISTERED + "\",\"Message\":\"Usuário Cadastrado\"}";
            }

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(returnJson, Encoding.UTF8, "application/json");

            return response;
        }

        [HttpPost]
        [ActionName("loginUser")]
        public HttpResponseMessage loginUser([FromBody] User userData)
        {
            string returnJson = "";

            if (string.IsNullOrEmpty(userData.login))
                returnJson = "{\"Sucess\":\"false\",\"Code\":\"" + UserReturnEnum.USER_LOGIN_REQUIRED + "\",\"Message\":\"Informe o login do usuário\"}";
            else if (string.IsNullOrEmpty(userData.password))
                returnJson = "{\"Sucess\":\"false\",\"Code\":\"" + UserReturnEnum.USER_PASSWORD_REQUIRED + "\",\"Message\":\"Informe a senha do usuário\"}";

            if( string.IsNullOrEmpty(returnJson))
            {
                User user = null;

                try
                {
                    user = users.First(x => x.login.Equals(userData.login));
                }
                catch( InvalidOperationException e)
                {
                    // Não encontrou o usuário
                }
              

                if(user != null && user.password.Equals(PasswordEncryptUtil.getInstance().encryptPassword(userData.password)))
                    returnJson = "{\"Sucess\":\"true\",\"Code\":\"" + UserReturnEnum.USER_LOGIN_SUCESS + "\",\"Message\":\"Usuário Logado com sucesso\"}";
                else
                    returnJson = "{\"Sucess\":\"false\",\"Code\":\"" + UserReturnEnum.USER_LOGIN_REJECT + "\",\"Message\":\"Não foi possível efetuar o login\"}";
            }

            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(returnJson, Encoding.UTF8, "application/json");

            return response;
        }
    }
}
