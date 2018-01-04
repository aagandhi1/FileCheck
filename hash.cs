using System;

namespace libfc
{
    public class Hash
    {
        //Write a function to return md5 hash for the contentes of the textfile
        public static string getMd5(String path)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = System.IO.File.OpenRead(path))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        //Write a function to return Sha1 hash for the contentes of the textfile
        public static string getSha1(String path)
        {
            using (var sha1 = System.Security.Cryptography.SHA1.Create())
            {
                using (var stream = System.IO.File.OpenRead(path))
                {
                    var hash = sha1.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
               
        }

        //Write a function to calculate md5 hash of the given file

        public string checkMd5(String path)
        {
            return "hash";
        }

        //Write a function to calculate Sha1 hash of the given file
        public string checkSha1(String path)
        {
            return "hash";
        }

        // Function to calculate the Size of given file

        public string getSize(String path)
        {
            long size = path.length;
            Console.Write("File Size in Bytes: ", size);
        }

    }
}
