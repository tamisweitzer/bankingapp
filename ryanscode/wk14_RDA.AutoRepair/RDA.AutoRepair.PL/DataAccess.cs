using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;

namespace RDA.AutoRepair.PL
{
    public static class DataAccess
    {
        private static SqlConnection connection;
        public static string XmlPath { get; set; }

        public static string ConnectionString { get; set; }

        private static void connect()
        {
            if (ConnectionString == null)
            {
                throw new Exception("You didn't specify a connenction string!");
            }

            if (connection == null)
            {
                connection = new SqlConnection(ConnectionString);
            }
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Close()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable Select(string sql, SqlParameter[] parameters = null, bool autoClose = true)
        {
            try
            {
                connect();

                SqlCommand command = new SqlCommand(sql, connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (autoClose) Close();
            }

        }

        public static int RunSql(string sql, SqlParameter[] parameters = null, bool autoClose = true)
        {
            try
            {
                connect();

                SqlCommand command = new SqlCommand(sql, connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (autoClose) Close();
            }
        }

        public static void SaveXml(Type type, object o)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(XmlPath);
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
                reader = new StreamReader(XmlPath);
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
