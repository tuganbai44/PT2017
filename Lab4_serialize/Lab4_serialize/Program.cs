using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //function1();
            function2();
        
        }

        static void function2()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("test.ser", FileMode.Open, FileAccess.Read);

            try
            {
                Student s = bf.Deserialize(fs) as Student;
                Console.Write(s);

                Console.ReadKey();
            }
            catch
            {
                Console.Write("deserialize error");
            }
            finally
            {
                fs.Close();
            }

        }

            static void function1()
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("test.ser", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                Student s = new Student();
                s.setInfo();

                try
                {
                    bf.Serialize(fs, s);
                }
                catch
                {
                Console.Write("serialize error");
                }
                finally
                {
                    fs.Close();
                }
            }
    }
}
