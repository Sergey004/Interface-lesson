using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_lesson
{
    class Program
    {
                     
        static void Main(string[] args)
        {
            TestClass test = new TestClass();

            Console.WriteLine(test.GetMemu());
            IWindow window = test;
            Console.WriteLine(window.GetMemu());
            IRestatuant restatuant = test;
            Console.WriteLine(restatuant.GetMemu());
            Console.ReadLine();

        }

        public interface IRestatuant
        {
            object GetMemu();
        }
        public interface IWindow
        {
            object GetMemu();
        }
        public class TestClass : IWindow, IRestatuant
        {
            public object GetMemu()
            {
                return "Собственный метод getMenu";
            }
            object IWindow.GetMemu()
            {
                return "GetMenu интерфейса IWinodw";
            }
            object IRestatuant.GetMemu()
            {
                return "GetMenu интерфейса IRestatuant";
            }
        }
    }
}
