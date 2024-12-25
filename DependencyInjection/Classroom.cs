using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Classroom
    {

        // Classroom sınıfının yapıcısı (constructor).
        // Bu yapıcı, Teacher türünde bir nesne alır ve bu nesneyi sınıfın Teacher özelliğine atar.
        public Classroom(Teacher _teacher)
        {
            // Alınan Teacher nesnesini sınıfın Teacher özelliğine atıyoruz.
            // Bu, Dependency Injection (bağımlılık enjeksiyonu) kullanarak Classroom'a bir Teacher nesnesi sağladığımız anlamına gelir.
            Teacher = _teacher;
        }

        // Teacher özelliği, Classroom sınıfında bir Teacher nesnesini tutmak için kullanılır.
        // Bu özellik, dışarıdan erişilebilir ve sınıfın içinde kullanılabilir.
        public Teacher Teacher { get; set; }

        // GetTeacherInfo metodu, Classroom sınıfındaki öğretmenin bilgilerini almak için kullanılır.
        // Bu metod, Teacher nesnesinin GetInfo metodunu çağırarak öğretmenin adını ve soyadını döndürür.
        public void GetTeacherInfo()
        {
            // Teacher nesnesinin GetInfo metodunu çağırıyoruz.
            // Bu metod, öğretmenin adını ve soyadını döndürür.
            Teacher.GetInfo();
        }
    }
}

