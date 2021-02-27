using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarUpdated = "Araba güncellendi";

        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Listeme yapıldı";
        public static string ErrorId = "hatalı id";
        public static string FailAddedImageLimit="Limit aşıldı.";
    }
}
