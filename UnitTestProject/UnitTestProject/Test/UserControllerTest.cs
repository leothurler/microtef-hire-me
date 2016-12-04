using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.Controller;

namespace UnitTestProject.Test
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void loginUserLoginRequiredTest()
        {

            //Login Válido
            string jsonDados = "{ \"login\": \"\"," +
                                 "\"password\": \"le\"";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/loginUser", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Informe o login do usuário", message);
        }

        [TestMethod]
        public void loginUserPasswordRequiredTest()
        {

            //Login Válido
            string jsonDados = "{ \"login\": \"leo\"," +
                                 "\"password\": \"\"";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/loginUser", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Informe a senha do usuário", message);
        }

        [TestMethod]
        public void loginUserInvalidLoginTest()
        {

            //Login Válido
            string jsonDados = "{ \"login\": \"le\"," +
                                 "\"password\": \"le\"";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/loginUser", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Não foi possível efetuar o login", message);
        }

        [TestMethod]
        public void loginUserValidLoginTest()
        {

            //Login Válido
            string jsonDados = "{ \"login\": \"leo\"," +
                                 "\"password\": \"Leo123\"";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/loginUser", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("true", sucess);
            Assert.AreEqual("Usuário Logado com sucesso", message);
        }

        [TestMethod]
        public void registerUserNameRequired()
        {

            string jsonDados = "{ \"login\": \"leo21\"," +
                                  "\"name\": \"\"," +
                                  "\"password\": \"Leo123\"";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/registerUser", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Informe o nome do usuário", message);
        }

        [TestMethod]
        public void registerUserLoginRequired()
        {

            string jsonDados = "{ \"login\": \"\"," +
                                  "\"name\": \"Leonardo\"," +
                                  "\"password\": \"Leo123\"";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/registerUser", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Informe o login do usuário", message);
        }

        [TestMethod]
        public void registerUserPasswordRequired()
        {

            string jsonDados = "{ \"login\": \"leo21\"," +
                                  "\"name\": \"Leonardo\"," +
                                  "\"password\": \"\"";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/registerUser", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Informe a senha do usuário", message);
        }

        [TestMethod]
        public void registerUserPasswordLengthSmaller()
        {

            string jsonDados = "{ \"login\": \"leo21\"," +
                                  "\"name\": \"Leonardo\"," +
                                  "\"password\": \"Leo12\"";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/registerUser", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Erro no tamanho da senha: A senha deve ter entre 6 e 8 dítigos", message);
        }

        [TestMethod]
        public void registerUserPasswordLengthBigger()
        {

            string jsonDados = "{ \"login\": \"leo21\"," +
                                  "\"name\": \"Leonardo\"," +
                                  "\"password\": \"Leo123456\"";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/registerUser", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Erro no tamanho da senha: A senha deve ter entre 6 e 8 dítigos", message);
        }

        [TestMethod]
        public void registerUserPasswordFormat()
        {

            string jsonDados = "{ \"login\": \"leo21\"," +
                                  "\"name\": \"Leonardo\"," +
                                  "\"password\": \"leo123\"";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/registerUser", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Senha inválida: A senha deve conter ao menos um caracter maiúsculo", message);
        }

        [TestMethod]
        public void registerUserValidRegister()
        {

            string jsonDados = "{ \"login\": \"leo21\"," +
                                  "\"name\": \"Leonardo\"," +
                                  "\"password\": \"Leo123\"";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/User/registerUser", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("true", sucess);
            Assert.AreEqual("Usuário Cadastrado", message);
        }
    }
}
