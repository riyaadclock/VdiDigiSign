using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

/// <summary>
/// Summary description for Encrypt
/// </summary>
public class Encrypt
{
    public Encrypt()
    {
        //
        // TODO: Add constructor logic here


        //
    }
    private static readonly byte[] salt = Encoding.ASCII.GetBytes("OlgarsandKola2017");

    public string EncryptString(string textToEncrypt, string encryptionPassword)
    {
        var algorithm = GetAlgorithm(encryptionPassword);
        byte[] encryptedBytes;
        using (ICryptoTransform encryptor = algorithm.CreateEncryptor(algorithm.Key, algorithm.IV))
        {
            byte[] bytesToEncrypt = Encoding.UTF8.GetBytes(textToEncrypt);
            encryptedBytes = InMemoryCrypt(bytesToEncrypt, encryptor);
        }
        return Convert.ToBase64String(encryptedBytes);
    }

    public string DecryptString(string encryptedText, string encryptionPassword)
    {
        var algorithm = GetAlgorithm(encryptionPassword);
        byte[] descryptedBytes;
        using (ICryptoTransform decryptor = algorithm.CreateDecryptor(algorithm.Key, algorithm.IV))
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            descryptedBytes = InMemoryCrypt(encryptedBytes, decryptor);
        }
        return Encoding.UTF8.GetString(descryptedBytes);
    }

    // Performs an in-memory encrypt/decrypt transformation on a byte array.   
    private static byte[] InMemoryCrypt(byte[] data, ICryptoTransform transform)
    {
        MemoryStream memory = new MemoryStream();
        using (Stream stream = new CryptoStream(memory, transform, CryptoStreamMode.Write))
        {
            stream.Write(data, 0, data.Length);
        }
        return memory.ToArray();
    }

    // Defines a RijndaelManaged algorithm and sets its key and Initialization Vector (IV) 
    // values based on the encryptionPassword received. 
    private static RijndaelManaged GetAlgorithm(string encryptionPassword)
    {  // Create an encryption key from the encryptionPassword and salt.  
        var key = new Rfc2898DeriveBytes(encryptionPassword, salt);
        // Declare that we are going to use the Rijndael algorithm with the key that we've just got.
        var algorithm = new RijndaelManaged();
        int bytesForKey = algorithm.KeySize / 8;
        int bytesForIV = algorithm.BlockSize / 8;
        algorithm.Key = key.GetBytes(bytesForKey);
        algorithm.IV = key.GetBytes(bytesForIV);
        return algorithm;
    }

    static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
    {
        // Check arguments.
        if (plainText == null || plainText.Length <= 0)
            throw new ArgumentNullException("plainText");
        if (Key == null || Key.Length <= 0)
            throw new ArgumentNullException("Key");
        if (IV == null || IV.Length <= 0)
            throw new ArgumentNullException("IV");
        byte[] encrypted;
        // Create an RijndaelManaged object
        // with the specified key and IV.
        using (RijndaelManaged rijAlg = new RijndaelManaged())
        {
            rijAlg.Key = Key;
            rijAlg.IV = IV;

            // Create a decrytor to perform the stream transform.
            ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

            // Create the streams used for encryption.
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {

                        //Write all data to the stream.
                        swEncrypt.Write(plainText);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
        }


        // Return the encrypted bytes from the memory stream.
        return encrypted;

    }


    public string EncryptString(string ClearText)
    {
        string retString = "XXX";

        string EncryptionKey = "kolars2017";
        byte[] clearBytes = Encoding.Unicode.GetBytes(ClearText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    cs.Close();
                }
                retString = Convert.ToBase64String(ms.ToArray());
            }
        }


        return retString;
    }

    public string DecryptString(string cipherText)
    {
        string EncryptionKey = "kolars2017";
        cipherText = cipherText.Replace(" ", "+");
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.Close();
                }
                cipherText = Encoding.Unicode.GetString(ms.ToArray());
            }
        }
        return cipherText;

    }


}

