# .Net Core n-Tier Architecture Base Project

Projelerimde kullanmak üzere oluşturduğum  .Net Core 6 frameworkü ile hazırlanmış katmanlı mimari yapısına sahip base projem. Daha sonra bu base proje üzerine çeşitli projeler geliştireceğim. Şu an geliştirme aşamasındadır. Tamamamlandığında kullanılan tüm teknolojileri buraya ekleyeceğim.


## Kullandığım Teknolojiler 

- ASP.Net Core 6
- Entity Framework
- IoC - Autofac
- Validation - Fluent Validation

### Proje içeriği

- Business katmanındaki işlemler için bir Validation yapısı kuruldu, bu yapıyıda AOP mantığı ile oluşturdum. Kütüphane olarak da Fluent Validation kullandım.
![image](https://user-images.githubusercontent.com/19391683/211897757-a34d3be6-ea44-4752-a560-039fb02ac4ea.png)

Validation kodlarını business kodlarının içerisine yazmadan metot çağırıldığında kontrol etmesini sağlayan bir yapı oluşturdum. 

- Business rules kodları içinde Core katmanında bir tool oluşturduk. Burada da ilgili manager dosyasında oluşturduğumuz business kurallarımızı toola gönderip gerekli kuralları sağlayıp sağlamadığını kontrol ediyoruz.

![image](https://user-images.githubusercontent.com/19391683/211898420-04112411-54bb-446c-b9a7-c1994b4bf2ea.png)


### Güncelleme Tarihi : 11.01.2023
