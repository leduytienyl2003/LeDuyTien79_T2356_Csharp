using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ex3
{
    internal interface IEncryptable
    {
        string Encrypt();//phương thức mã hóa
        string Decrypt();//phương thức giải mã
    }
}
