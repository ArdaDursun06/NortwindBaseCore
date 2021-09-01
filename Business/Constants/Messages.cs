using Core.Entities.Concrete;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 Ürün Olabilir";

        public static string ProductNameAlreadyExists = "Bir İsimde Zaten Başka Bir Ürün Mevcut";

        public static string CategoryLimitExceded = "Sisteme Daha Fazla Kategori Ekleyemezsiniz";
        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "Kayıt Olundu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
