using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public class CustomerManager
    {
        public int deneme = 1;

        private static CustomerManager instance;
        static object lockObject = new object();

        private CustomerManager() 
        {
            // ctor'un boş olmasının sebebi private olduğu için bu Class'tan herhangi bir nesne üretmeye izin
            // vermek istemememiz ve bunun önüne geçmemiz.
        }

        // multi tread çalışan ortamlarda bazen Singleton hatalı çalışarak birden fazla işlemci tarafından
        // işleme alınır ve birden fazla Instance üretilir. Bunun önüne geçmek için "lock()" komutunu kullanıyoruz.
        // C# Lock keyword ensures that one thread is executing a piece of code at one time.
        public static CustomerManager CreateAsSingleton()
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new CustomerManager();
                }
                return instance;
            }
        }
        
    }
}
