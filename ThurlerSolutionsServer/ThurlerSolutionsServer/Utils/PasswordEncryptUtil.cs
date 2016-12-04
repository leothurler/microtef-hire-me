using System;

namespace ThurlerSolutionsServer.Utils
{
    /// <summary>
    /// Classe utilizada para controlar a encriptação das senhas.
    /// </summary>
    public class PasswordEncryptUtil
    {
        public static PasswordEncryptUtil instance;

        private PasswordEncryptUtil()
        {
        }

        public static PasswordEncryptUtil getInstance()
        {
            if (instance == null)
                instance = new PasswordEncryptUtil();

            return instance;
        }

        public string encryptPassword(string password)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String newPassword = System.Text.Encoding.ASCII.GetString(data);

            return newPassword;
        }
    }
}