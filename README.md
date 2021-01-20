# E-commerce-Website

Projeme bu linkten erişebilirsiniz: https://github.com/IFurkanCakmak/E-commerce-Website 

## Projeyi Başlatma

Vermiş olduğum zip dosyasının içerisindeki Database Backup klasöründeki FurkanProjectDB.bak database yedeklemesinin SQL Server üzerinde geri yüklenmesi gerekmektedir.

Daha sonra Visual Studio aracılığıyla FurkanProject.sln dosyasına çift  tıklandıktan sonra projeyi IIS Express üzerinden çalıştırabilirsiniz.

Veritabanı SQL Server üzerinde yüklendikten sonra ve projeyi çalıştırırken Visual Studioda veritabanını ekledikten sonra hata verme gibi bir durum olursa veritabanının connection string'ini FurkanProject.Core.Model içindeki FurkanDB.cs sınıfının içindeki ":base" kısmının içine yapıştırarak tekrar update-database yapılmalı.   

### Projeyi Test Etme

/admin sayfasına gidilebilmesi için login yapılması gerekli o yüzden ondan önce /Admin/AdminLogin/Index sayfasından admin girişi yapılmalıdır. SQL'den Users tablosuna admin kullanıcısı eklenebilir ya da direkt olarak Email için furkancakmak@gmail.com şifre için "1" girilerek admin yönetici paneline gidilebilir.





