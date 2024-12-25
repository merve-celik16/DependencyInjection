using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    // ITeacher arayüzü, öğretmen ile ilgili temel işlevleri tanımlamak için kullanılır.
    // Arayüzler, bir sınıfın hangi metotları uygulaması gerektiğini belirtir.
    public interface ITeacher
    {
        // GetInfo metodu, öğretmenin bilgilerini döndürmek için tanımlanmıştır.
        // Bu metod, arayüzü uygulayan sınıflar tarafından gerçekleştirilmelidir.
        void GetInfo();
    }

}