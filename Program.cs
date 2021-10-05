using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace zhTOen
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string line;
                List<string> lines = new List<string>();
                Console.WriteLine("Convert common Chinese punctuation in text files to English punctuation.");
                Console.WriteLine("Drag and drop the file into this command box to run");
                Console.WriteLine("or enter the full pathname of the file:");
                string path = Console.ReadLine();
                StreamReader sr = new StreamReader(path);
                while ((line = sr.ReadLine()) != null)
                {
                    char[] c = line.ToCharArray();
                    for (int i = 0; i < c.Length; i++)
                    {
                        if (c[i] == '！')
                        {
                            c[i] = '!';
                        }
                        else if (c[i] == '＃')
                        {
                            c[i] = '#';
                        }
                        else if (c[i] == '＄')
                        {
                            c[i] = '$';
                        }
                        else if (c[i] == '％')
                        {
                            c[i] = '%';
                        }
                        else if (c[i] == '＆')
                        {
                            c[i] = '&';
                        }
                        else if (c[i] == '（')
                        {
                            c[i] = '(';
                        }
                        else if (c[i] == '）')
                        {
                            c[i] = ')';
                        }
                        else if (c[i] == '｛')
                        {
                            c[i] = '{';
                        }
                        else if (c[i] == '｝')
                        {
                            c[i] = '}';
                        }
                        else if (c[i] == '【')
                        {
                            c[i] = '[';
                        }
                        else if (c[i] == '】')
                        {
                            c[i] = ']';
                        }
                        else if (c[i] == '；')
                        {
                            c[i] = ';';
                        }
                        else if (c[i] == '：')
                        {
                            c[i] = ':';
                        }
                        else if (c[i] == '“')
                        {
                            c[i] = '\"';
                        }
                        else if (c[i] == '”')
                        {
                            c[i] = '\"';
                        }
                        else if (c[i] == '‘')
                        {
                            c[i] = '\'';
                        }
                        else if (c[i] == '’')
                        {
                            c[i] = '\'';
                        }
                        else if (c[i] == '＞')
                        {
                            c[i] = '>';
                        }
                        else if (c[i] == '＜')
                        {
                            c[i] = '<';
                        }
                        else if (c[i] == '，')
                        {
                            c[i] = ',';
                        }
                        else if (c[i] == '。')
                        {
                            c[i] = '.';
                        }
                        else if (c[i] == '？')
                        {
                            c[i] = '?';
                        }
                        else if (c[i] == '、')
                        {
                            c[i] = ',';
                        }
                        else if (c[i] == '《')
                        {
                            c[i] = '<';
                        }
                        else if (c[i] == '》')
                        {
                            c[i] = '>';
                        }
                    }
                    String str = new String(c);
                    lines.Add(str);
                }
                sr.Close();
                StreamWriter sw = new StreamWriter(path);
                foreach (string s in lines)
                {
                    sw.WriteLine(s);
                }
                sw.Flush();
                sw.Close();
                Console.WriteLine("If there is no error message, the conversion is complete.");
                Console.WriteLine("Press any character to exit");
                Console.ReadKey();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any character to exit");
                Console.ReadKey();
            }
        }
    }
}
