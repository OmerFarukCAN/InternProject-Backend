using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun Eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductListed = "Urunler Listesi";
        public static string ProductDetails = "Urun Detaylari";
        public static string ProductCountOfCategoryError = "Bir kategorideki urun sayısı sınırı asıldı";
        public static string ProductNameAlreadyExist = "Bu isimde bir urun mevcuttur";
        public static string CategoryLimitExceded = "Kategori limit asildi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string ProductUpdated = "Urun guncellendi";
    }
}

// static newlenmeden ulasilabilir anlamina gelir
// public degiskenler büyük harfle yazılır.