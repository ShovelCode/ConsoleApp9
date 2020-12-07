using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Xml.Linq;
using static System.Convert;

namespace ConsoleApp9
{
    class Protector
    {
        private static readonly byte[] salt = Encoding.Unicode.GetBytes("7Bananas");
    }
}
