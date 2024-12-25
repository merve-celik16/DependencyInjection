# Dependency Injection
Bu proje, Bağımlılık Enjeksiyonu (Dependency Injection, DI) kullanarak iki sınıf arasındaki bağımlılıkların nasıl yönetileceğini gösterir. Örnekte bir öğretmen (Teacher) ve sınıf (Classroom) ele alınmıştır.

# Genel Bakış
## Dependency Injection(Bağımlılık Enjeksiyonu) Neidr?
Bağımlılık Enjeksiyonu, bir sınıfın ihtiyaç duyduğu bağımlılıkların dışarıdan sağlanmasını ifade eder. Bu yaklaşım:

 * Sınıflar arası sıkı bağlılığı (tight coupling) azaltır.
 * Kodun yeniden kullanılabilirliğini ve test edilebilirliğini artırır.
 * Esnekliği geliştirir ve genişlemeyi kolaylaştırır.

   Bu projede:

 * Constructor Injection (Yapıcı Enjeksiyon) yöntemi kullanılarak Classroom sınıfına Teacher nesnesi dışarıdan sağlanır.

   # Yapı
  ##  1. IOgretmen (Arayüz)
  Bu arayüz, bir öğretmeni temsil eden sınıfların uyması gereken sözleşmeyi tanımlar.
Özellikler:

 * FirstName: Öğretmenin adı.
 * LastName: Öğretmenin soyadı.
Metot:

 * GetInfo(): Öğretmenin adını ve soyadını döndürür.

 ## 2. Teacher (Somut Sınıf)
 * IOgretmen arayüzünü uygular.
 * Gerçek bir öğretmeni temsil eder.
 * Öğretmenin adını ve soyadını içerir.
 * GetInfo() metodu ile öğretmenin bilgilerini formatlı şekilde döndürür.

 ## 3. Classroom (Tüketici Sınıf)
 * IOgretmen türünde bir bağımlılığı yapıcı metoduyla alır.
 * GetTeacherInfo() metodu, enjeksiyon yoluyla alınan Teacher nesnesinin bilgilerini döndürür.

   
