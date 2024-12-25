using DependencyInjection;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Öğretmen'nin Bilgileri ******");

            // Classroom sınıfının bir örneğini oluşturuyoruz.
            // Teacher sınıfının bir örneğini constructor'a geçiriyoruz.
            // Bu, Dependency Injection kullanarak Classroom'a bir Teacher nesnesi sağlıyoruz.

            Classroom classroom = new(new Teacher());

            // Classroom sınıfındaki GetTeacherInfo metodunu çağırıyoruz.
            // Bu metod, Classroom'da tanımlı olan öğretmenin bilgilerini alır ve ekrana yazdırır.
            classroom.GetTeacherInfo();


        }
    }
}