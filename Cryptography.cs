using System;
namespace Crypto
{
    public interface Cryptography
    {
        string Encrypt(string plainText, string passPhrase);
        string Decrypt(string cipherText, string passPhrase);
    }
}
