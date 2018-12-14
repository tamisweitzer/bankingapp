using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RDA.AutoRepair.PL
{
    public static class DataAccess
    {
        private static string xmlPath = "customers.xml";

        public static void SaveXml(Type type, object o)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(xmlPath);
                XmlSerializer serializer = new XmlSerializer(type);
                serializer.Serialize(writer, o);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                writer?.Close();
            }

        }

        public static object LoadXml(Type type)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(xmlPath);
                XmlSerializer serializer = new XmlSerializer(type);
                return serializer.Deserialize(reader);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                reader?.Close();
            }

        }
    }
}
