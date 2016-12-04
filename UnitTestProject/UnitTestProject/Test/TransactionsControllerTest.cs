using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.Controller;

namespace UnitTestProject.Test
{
    [TestClass]
    public class TransactionsControllerTest
    {
        [TestMethod]
        public void makeTransactionInvalidBalanceTest()
        {
            string jsonDados = "{ \"amount\": \"10000\"," +
                                    "\"type\": \"Crédito\"," +
                                    "\"number\": \"1\"," +
                                    "\"card\": { " +
                                                   "\"number\": \"1\"," +
                                                   "\"password\": \"1234\"," +
                                    " }, " +
                                    "\"userLogin\": \"leo\" }";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Transactions/makeTransaction", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Saldo Insuficiente.", message);
        }

        [TestMethod]
        public void makeTransactionInvalidAmountTest()
        {
            string jsonDados = "{ \"amount\": \"0\"," +
                                    "\"type\": \"Crédito\"," +
                                    "\"number\": \"1\"," +
                                    "\"card\": { " +
                                                   "\"number\": \"1\"," +
                                                   "\"password\": \"123\"," +
                                    " }, " +
                                    "\"userLogin\": \"leo\" }";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Transactions/makeTransaction", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Valor inválido: mínimo de 10 centavos.", message);
        }

        [TestMethod]
        public void makeTransactionInvalidCardNumberTest()
        {
            string jsonDados = "{ \"amount\": \"100\"," +
                                    "\"type\": \"Crédito\"," +
                                    "\"number\": \"1\"," +
                                    "\"card\": { " +
                                                   "\"number\": \"12\"," +
                                                   "\"password\": \"1234\"," +
                                    " }, " +
                                    "\"userLogin\": \"leo\" }";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Transactions/makeTransaction", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Dados do cartão inválido", message);
        }

        [TestMethod]
        public void makeTransactionInvalidCardPasswordTest()
        {
            string jsonDados = "{ \"amount\": \"100\"," +
                                    "\"type\": \"Crédito\"," +
                                    "\"number\": \"1\"," +
                                    "\"card\": { " +
                                                   "\"number\": \"1\"," +
                                                   "\"password\": \"123\"," +
                                    " }, " +
                                    "\"userLogin\": \"leo\" }";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Transactions/makeTransaction", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Dados do cartão inválido", message);
        }

        [TestMethod]
        public void makeTransactionValidTransactionTest()
        {
            string jsonDados = "{ \"amount\": \"100\"," +
                                    "\"type\": \"Crédito\"," +
                                    "\"number\": \"1\"," +
                                    "\"card\": { " +
                                                   "\"number\": \"1\"," +
                                                   "\"password\": \"1234\"," +
                                    " }, " +
                                    "\"userLogin\": \"leo\" }";

            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Transactions/makeTransaction", "POST", jsonDados);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("true", sucess);
            Assert.AreEqual("Transação Aprovada", message);
        }

        [TestMethod]
        public void getUserTransactionsValidConsultTest()
        {
            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Transactions/getUserTransactions?userLogin=leo", "GET", null);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("true", sucess);
            Assert.AreEqual("Transações retornadas", message);
        }

        [TestMethod]
        public void getUserTransactionsInvalidConsultTest()
        {
            WebserviceRequisitionController requisition = new WebserviceRequisitionController();

            dynamic item = requisition.makeRequisition("http://localhost:60010/api/Transactions/getUserTransactions?userLogin=vini", "GET", null);
            string message = item["Message"];
            string sucess = item["Sucess"];

            Assert.AreEqual("false", sucess);
            Assert.AreEqual("Não foi possível consultar as transações", message);
        }
    }
}
