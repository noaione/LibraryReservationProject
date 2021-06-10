using System;
using System.Security.Cryptography;

namespace LibraryReservation
{
    public static class PasswordManager
    {
        private const int Salt = 16;
        private const int Hash = 20;

        // This password hasher are based on:
        // https://stackoverflow.com/a/10402129
        //
        // It's modified to use a predefined password prefix to make it much more secure
        public static string HashPassword(string password)
        {
            string combinedWithEntropy = new LibrarySecrets().PassEntropy + password;
            // Create a new salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[Salt]);

            // Create hash
            // Use 50k iteration for now
            var pbkdf2 = new Rfc2898DeriveBytes(combinedWithEntropy, salt, 50000);
            var hash = pbkdf2.GetBytes(Hash);

            // Combine the salt and pasword bytes
            byte[] hashBytes = new byte[Salt + Hash];
            Array.Copy(salt, 0, hashBytes, 0, Salt);
            Array.Copy(hash, 0, hashBytes, Salt, Hash);

            // Convert to base64
            var base64hash = Convert.ToBase64String(hashBytes);
            return base64hash;
        }

        public static bool Verify(string password, string hashedPass)
        {
            string combinedWithEntropy = new LibrarySecrets().PassEntropy + password;
            // TODO: fix this
            byte[] hashBytes = Convert.FromBase64String(hashedPass);
            byte[] salt = new byte[Salt];
            Array.Copy(hashBytes, 0, salt, 0, Salt);

            var pbkdf2 = new Rfc2898DeriveBytes(combinedWithEntropy, salt, 50000);
            byte[] hash = pbkdf2.GetBytes(Hash);
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i+16] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
