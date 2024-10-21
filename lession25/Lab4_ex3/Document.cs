using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ex3
{
    internal class Document
    {
        public class Document : IStoreable, IEncryptable
        {
            public string content { get; set}
            public string Data
            {
                get { return content; }
                set { content = value; }
            }
            public void Write(string fileName)
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                using (StreamWrite sw = new StreamWrite(fs))
                {
                    sw.Write(content);
                    Console.WriteLine($"nội dung viết{fileName}");
                }
            }
            public void Read(string fileName) {
                if (!File.Exists(fileName))
                {
                    Console.WriteLine($"File{fileName}không thoát");
                    return;
                }
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs))
                {
                    content = sr.ReadToEnd();
                    Console.WriteLine($"nội dung đọc được từ file {fileName}");
                }
            }
            public string Encrypt()
            {
                string encryptData = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(content));
                Console.WriteLine("nội dung encrypt");
                return encryptData;
            }
            public string Decrypt() {
                string decryptedData = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(content));
                Console.WriteLine("nội dung Decrypt");
                return decryptedData;
            }
        }
    }
}
