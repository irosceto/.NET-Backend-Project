using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir!";
        public static string ProductNameAlreadyExists = "bir isimde zaten başka bir ürün var";
        internal static string CategoryLimitExceded = "kategori limiti aşıldığı için yeni ürün eklemiyor";
        internal static string? AuthorizationDenied = "yetkiniz yok";
    }
}
