using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.TypeLayer
{
    public class Common_Messages
    {
        public static string Common_Messages_Method(bool basarilimi)
        {
            string result = "";
            if (basarilimi)
            {
                result = "Kayıt başarıyla gerçekleştirildi.";
            }
            else
            {
                result = "Malesef kayıt gerçekleştirilemedi.";
            }
            return result;        
        }
        
    }
}
