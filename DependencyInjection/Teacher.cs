using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    // Teacher sınıfı, ITeacher arayüzünü uygulayan bir sınıftır.
    // Bu sınıf, öğretmen bilgilerini tutar ve öğretmenin bilgilerini döndürmek için gerekli metotları içerir.
    public class Teacher : ITeacher
    {
        // FirstName özelliği, öğretmenin adını tutar.
        // Varsayılan değeri "Kerem Alp " olarak ayarlanmıştır.
        public string FirstName { get; set; } = "Kerem Alp ";

        // LastName özelliği, öğretmenin soyadını tutar.
        // Varsayılan değeri "Çelik" olarak ayarlanmıştır.
        public string LastName { get; set; } = "Çelik";

        // GetInfo metodu, öğretmenin adını ve soyadını konsola yazdırmak için kullanılır.
        public void GetInfo()
        {
            // Konsola öğretmenin tam adını yazdırır.
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
