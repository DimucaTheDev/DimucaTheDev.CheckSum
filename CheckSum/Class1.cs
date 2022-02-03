using CR = System.Security.Cryptography;
using System.Security.Cryptography;
using System.Text;

namespace DimucaTheDev.HashSum
{
    public class CheckSum
    {
        /// <summary>
        /// Returns SHA1 hash code as a string
        /// </summary>
        /// <param name="file">File location</param>
        /// <returns>System.String</returns>
        /// <exception cref="System.IO.FileNotFoundException"></exception>
        public static string SHA1(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                using (SHA1Managed sha1 = new SHA1Managed())
                {
                    byte[] hash = sha1.ComputeHash(bs);
                    StringBuilder formatted = new StringBuilder(2 * hash.Length);
                    foreach (byte b in hash)
                    {
                        formatted.AppendFormat("{0:X2}", b);
                    }
                    return formatted.ToString();
                }
            }
        }
        /// <summary>
        /// Returns MD5 hash code as a string
        /// </summary>
        /// <param name="file">File location</param>
        /// <returns>System.String</returns>
        /// <exception cref="System.IO.FileNotFoundException"></exception>
        public static string MD5(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                using (MD5 md5 = System.Security.Cryptography.MD5.Create())
                {
                    byte[] hash = md5.ComputeHash(bs);
                    StringBuilder formatted = new StringBuilder(2 * hash.Length);
                    foreach (byte b in hash)
                    {
                        formatted.AppendFormat("{0:X2}", b);
                    }
                    return formatted.ToString();
                }
            }
        }
        /// <summary>
        /// Returns SHA256 hash code as a string
        /// </summary>
        /// <param name="file">File location</param>
        /// <returns>System.String</returns>
        /// <exception cref="System.IO.FileNotFoundException"></exception>
        public static string SHA256(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                using (SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
                {
                    byte[] hash = sha256.ComputeHash(bs);
                    StringBuilder formatted = new StringBuilder(2 * hash.Length);
                    foreach (byte b in hash)
                    {
                        formatted.AppendFormat("{0:X2}", b);
                    }
                    return formatted.ToString();
                }
            }
        }
        /// <summary>
        /// Returns SHA512 hash code as a string
        /// </summary>
        /// <param name="file">File location</param>
        /// <returns>System.String</returns>
        /// <exception cref="System.IO.FileNotFoundException"></exception>
        public static string SHA512(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                using (CR.SHA512 sha512 = CR.SHA512.Create())
                {
                    byte[] hash = sha512.ComputeHash(bs);
                    StringBuilder formatted = new StringBuilder(2 * hash.Length);
                    foreach (byte b in hash)
                    {
                        formatted.AppendFormat("{0:X2}", b);
                    }
                    return formatted.ToString();
                }
            }
        }
        /// <summary>
        /// Returns SHA384 hash code as a string
        /// </summary>
        /// <param name="file">File location</param>
        /// <returns>System.String</returns>
        /// <exception cref="System.IO.FileNotFoundException"></exception>
        public static string SHA384(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                using (CR.SHA384 sha384 = CR.SHA384.Create())
                {
                    byte[] hash = sha384.ComputeHash(bs);
                    StringBuilder formatted = new StringBuilder(2 * hash.Length);
                    foreach (byte b in hash)
                    {
                        formatted.AppendFormat("{0:X2}", b);
                    }
                    return formatted.ToString();
                }
            }
        }

    }
}