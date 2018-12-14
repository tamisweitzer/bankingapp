
using RDA.AutoRepair.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RDA.AutoRepair.BL
{
    public class Customer : IComparable<Customer>
    {

        // Properties
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public List<Car> Cars { get; set; }

        public string DisplayName
        {
            get { return LastName + ", " + FirstName; }
        }

        // Constructor
        public Customer()
        {
            Cars = new List<Car>();
        }

        public Customer(int id, string firstName, string lastName, string phone)
        {
            Cars = new List<Car>();
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phone;
        }

        public Customer(DataRow row)
        {
            Cars = new List<Car>();
            ID = Convert.ToInt32(row["ID"]);
            FirstName = Convert.ToString(row["FirstName"]);
            LastName = Convert.ToString(row["LastName"]);
            PhoneNumber = Convert.ToString(row["Phone"]);
        }

        // Methods
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public int CompareTo(Customer other)
        {
            return DisplayName.CompareTo(other.DisplayName);
        }

        // HACK: I changed this to return the number of rows affected.
        public int InsertIntoDB()
        {
            string sql = "INSERT INTO autoCustomers VALUES(@id, @firstName, @lastName, @phone)";
            int rowsAffected = DataAccess.RunSql(sql, GetParameters());
            return rowsAffected;
        }

        // HACK: Did this after I let you go.
        public int UpdateDB()
        {
            string sql = "UPDATE autoCustomers SET FirstName = @firstName, LastName = @lastName, Phone = @phone WHERE ID = @id";
            int rowsAffected = DataAccess.RunSql(sql, GetParameters());
            return rowsAffected;
        }

        // HACK: Did this after I let you go.
        public int DeleteFromDB()
        {
            string sql = "DELETE FROM autoCustomers WHERE ID = @id";
            int rowsAffected = DataAccess.RunSql(sql, GetParameters());
            return rowsAffected;
        }

        private SqlParameter[] GetParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", ID));
            parameters.Add(new SqlParameter("@firstName", FirstName));
            parameters.Add(new SqlParameter("@lastName", LastName));
            parameters.Add(new SqlParameter("@phone", PhoneNumber));

            return parameters.ToArray();
        }

        public void LoadCarsFromDB()
        {
            Cars.Clear();
            string sql = "SELECT * FROM autoVehicles WHERE OwnerID = @id";
            DataTable data = DataAccess.Select(sql, GetParameters());
            foreach (DataRow row in data.Rows)
            {
                Cars.Add(new Car(row));
            }
        }
    }
}
