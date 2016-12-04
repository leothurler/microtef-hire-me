using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.Controller;

namespace UnitTestProject.Test
{
    [TestClass]
    public class CardControllerTest
    {
        [TestMethod]
        public void registerCardValidRegisterTest()
        {
            string jsonDados = "{ \"userLogin\": \"leo\"," +
                                     "\"cardholderName\": \"Leonardo\"," +
                                     "\"number\": \"123\"," +
                                     "\"expirationDate\": \"20/10/2020\"," +
                                     "\"cardBrand\": \"Visa\"," +
                                     "\"password\": \"123\"," +
                                     "\"type\": \"CHIP\"," +
                                     "\"balance\": \"500\"" +
                                    " } ";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Card/registerCard", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("true", sucess);
            Assert.AreEqual("Cartão Registrado com sucesso.", message);
        }

        [TestMethod]
        public void getUserCardsValidConsultTest()
        {
            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Card/getUserCards?userLogin=leo", "GET", null);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("true", sucess);
            Assert.AreEqual("Cartões retornadas", message);
        }

        [TestMethod]
        public void getUserCardsInvalidConsultTest()
        {
            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Card/getUserCards?userLogin=vini", "GET", null);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Não foi possível consultar os cartões", message);
        }
    }
}
