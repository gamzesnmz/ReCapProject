using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem Bakımda";
    }    
    public static class CarMessages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarNameInvalid = "Araç Adı Geçersiz";
        public static string CarListed = "Araçlar Listelendi";
        public static string CarByIdListed = "Seçilen Araçlar listelendi";
        public static string CarByBrandListed = "Araçlar Markalarına göre listelendi";
        public static string CarByColorListed = "Araçlar Renklerine Göre Listelendi";
        public static string CarDetailsListed = "Seçilen Aracın Detayları Listelendi";
        public static string CarByDailyPriceListed = "Günlük Kiralama fiyatlarına göre Listelendi";
         
    }
    public static class UserMessages
    {
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncelllendi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserByIdListed = "Seçilen Kullanıcalar Listelendi";

    }
    public static class CustomerMessages
    {
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomersListedById = "Seçilen Müşteriler Listelendi";

    }
    public static class RentalMessages
    {
        public static string RentalAdded = "Kiralama işlemi yapıldı";
        public static string RentalDeleted = "Kiralama işlemi Silindi";
        public static string RentalUpdated = "Kiralama işlemi Güncellendi";
        public static string RentalInvalid = "Araç teslim alınmadığından dolayı kiralanamaz";
        public static string RentalListed = "Kiralama işlemlerin tümü listelendi";
        public static string RentalByIdListed = "Seçilen Kiralama İŞlemi Tamamlandı"
;    }
    public static class ColorMessages
    {
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorListed = "Renkler Listelendi";
        public static string ColorListedById = "Seçilen Renkler Listelendi";
    }
    public static class BrandMessages
    {
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string BrandListedById = "Seçilen Markalar Listelendi";
    }

}

