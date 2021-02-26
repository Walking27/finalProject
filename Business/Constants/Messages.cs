using Core.Utilites.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string MaintenanceTime = "Bakım";
        public static string ProductListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError = "Bir Kategoryde En Fazla 10 Ürün Olabilir";
        public static string ProductNameAlreadyExists = "Bu İsimde Zaten Başka Bir Ürün Var";
        public static string CategoryLimitExceded = "Kategory Limiti Aşıldığı İçin Yeni Ürün Eklenemiyor";
    }
}
