namespace Lab4_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Document doccument = new Document();
            doccument.content = "đây là nội dung document";
            string filePath = "document.txt";
            //ghi vào file
            doccument.Write(filePath);
            //đọc lại từ file
            doccument.Read(filePath);
            Console.WriteLine($"nội dung tài liệu: {document.content}");

            string encryptedContent = doccument.Encrypt();
            Console.WriteLine($"mã hóa nội dung: {encryptedContent}");

            //gán dữ liệu đã mã hóa cho document để thử giải mã
            doccument.content=encryptedContent;
            string decryptedContent = doccument.Decrypt();
            Console.WriteLine($"Decrypted nội dung: {decryptedContent}");
        }
    }
}

