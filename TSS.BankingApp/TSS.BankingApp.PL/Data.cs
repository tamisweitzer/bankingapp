using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace TSS.BankingApp.PL
{
    public static class Data
    {
        private static string XMLPath = "CustomerList.xml";

        public static void SaveXML(Type type, object obj)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(XMLPath);
                XmlSerializer serializer = new XmlSerializer(type);
                serializer.Serialize(writer, obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                writer?.Close();
            }
        }

        public static object LoadXML(Type t)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(XMLPath);
                XmlSerializer serializer = new XmlSerializer(t);
                return serializer.Deserialize(reader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader?.Close();
            }
        }

    }
}

