using System;

namespace EncodeDecode
{
    public class Encrypter
    {
        public static string getEncryptedString(string original, string encryptionKey)
        {
            int currentIndex = 0;
            string encryptedString = "";

            foreach (char c in original)
            {
                if (currentIndex == encryptionKey.Length)
                {
                    currentIndex = 0;
                }

                // Check with the ASCII code if the character is a letter from the alphabet
                if ((c > 64 && c < 91) || (c > 96 && c < 123))
                {
                    // Check if the next char in the key is a number or something else
                    if (encryptionKey[currentIndex] > 47 && encryptionKey[currentIndex] < 58)
                    {
                        encryptedString +=
                            getEncryptedChar(c, Convert.ToInt32(encryptionKey.Substring(currentIndex, 1)));
                    }
                    else
                    {
                        encryptedString += getEncryptedChar(c, encryptionKey[currentIndex] - 96);
                    }
                }
                else
                {
                    encryptedString += c;
                }

                currentIndex++;
            }

            return encryptedString;
        }

        public static string getDecryptedString(string encrypted, string encryptionKey)
        {
            int currentIndex = 0;
            string decryptedString = "";

            foreach (char c in encrypted)
            {
                if (currentIndex == encryptionKey.Length)
                {
                    currentIndex = 0;
                }
                // Check with the ASCII code if the character is a letter from the alphabet
                if ((c > 64 && c < 91) || (c > 96 && c < 123))
                {
                    // Check if the next char in the key is a number or something else
                    if (encryptionKey[currentIndex] > 47 && encryptionKey[currentIndex] < 58)
                    {
                        decryptedString +=
                            getDecryptedChar(c, Convert.ToInt32(encryptionKey.Substring(currentIndex, 1)));
                    }
                    else
                    {
                        decryptedString += getDecryptedChar(c, encryptionKey[currentIndex] - 96);
                    }
                }
                else
                {
                    decryptedString += c;
                }

                currentIndex++;
            }

            return decryptedString;
        }

        private static char getEncryptedChar(char original, int cipher)
        {
            int newCode = original;

            while (cipher != 0)
            {
                newCode++;

                if (newCode > 90 && newCode < 97)
                {
                    newCode = 97;
                }
                else if (newCode > 122)
                {
                    newCode = 65;
                }

                cipher--;
            }

            return (char)newCode;
        }

        private static char getDecryptedChar(char encrypted, int cipher)
        {
            int newCode = encrypted;

            while (cipher != 0)
            {
                newCode--;

                if (newCode > 90 && newCode < 97)
                {
                    newCode = 90;
                }
                else if (newCode < 65)
                {
                    newCode = 122;
                }

                cipher--;
            }

            return (char)newCode;
        }
    }
}