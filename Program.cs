using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;//Sử dụng thư viện này để làm việc với Stream

namespace ReadText
{
    class Programg
    {
        static void Main(string[] args)
        {
            String line = ""; try
            {
                StreamReader sr = new StreamReader(args[0]); //đọc file 
                StreamWriter sw = new StreamWriter("./email.txt"); // file vừa tạo lưu imail
                Regex pattern = new Regex(@".+[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)"); //regex ra trường Email 
                List<string> kq = new List<string>(); // tạo list để tinh độ từng dòng một 
                while (line != null)
                {
                    kq.Add(line);
                    //Đọc dòng kế tiếp
                    line = sr.ReadLine();
                }
                foreach (var str in kq)
                {
                    Match match = pattern.Match(str);
                    if (match.Success)
                    {
                        sw.WriteLine(match);
                    }
                }
                
             sr.Close ();
             sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}