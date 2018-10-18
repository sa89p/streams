using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.Extensions.Primitives;

namespace Streams
{
    public class Program
    {
        public static void Main(string[] args)
        {
//            var fileInfo = new FileInfo("arg.txt");
//            StreamWriter sw = fileInfo.CreateText();
//            sw.WriteLine("the first line of the code");
//            sw.WriteLine("csharp is my language of choice");
//            sw.Close();
//            Console.WriteLine("File content: ");
//            
//            StreamReader reader = new StreamReader(new FileStream("arg.txt", FileMode.Open));
//            Console.WriteLine($"1-{reader.ReadLine()}");
//            reader.Close();
//            
//            StreamReader reader1 = fileInfo.OpenText();
//            Console.WriteLine(reader1.ReadLine());
//            reader1.Close();
            /*
             *    var reader = File.OpenText(filePath);
             *     var reader= fileInfo.OpenText();
             *     var reader = new StreamRe
             * 
             */


            /*var sw = new StringWriter();
            sw.Write("friendship is not a two way road");
            sw.Write(sw.NewLine);
            sw.WriteLine("it is part of the life to lose");
            sw.Close();
//            Console.WriteLine($"Data: {sw.ToString()}");
            var sb = sw.GetStringBuilder();
            string entireData = sb.ToString();
            Console.WriteLine("Entire Data:\n {0}", entireData);
            // TO ADD SOME STRING
            sb.Insert(45, "together face-to-face");
            entireData = sb.ToString();
            Console.WriteLine("modified data: \n{0}", entireData);
            // TO REMOVE SOME STRING
            sb.Remove(45, "together face-to-face".Length);
            entireData = sb.ToString();
            Console.WriteLine("The original data: \n{0}", entireData);
            var file = File.Create("g.txt");
            file.Dispose();
            File.WriteAllText("g.txt", entireData);*/


            var encoding = 
                new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
            using (TextWriter w = File.CreateText("writer.txt"))
            {
                w.WriteLine("but-");
            }

            using (var r = File.OpenRead("writer.txt"))
            {
                for (int b; (b = r.ReadByte()) > -1;)
                    Console.WriteLine(b);
            }
        }
    }
}