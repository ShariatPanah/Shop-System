
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Shop_System.BLL;

namespace Shop_System.DAL
{
    public class ShopDAL
    {
        public static string ConnectionString = "Data Source=.;Initial Catalog=Shop;Integrated Security=True";
        public static SqlConnection Connection;
        public static SqlCommand Command;

        public static int Login(string User, string Pass)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select Count(Username) From [User] Where Username='{0}' And Password='{1}'", User, Pass);

                int Counter = (int)Command.ExecuteScalar();
                return Counter;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void NewShopping(Shopping oShopping)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"NewShopping";

                Command.Parameters.AddWithValue("@FactorNo", oShopping.FactorNo);
                Command.Parameters.AddWithValue("@Seller", oShopping.Seller);
                Command.Parameters.AddWithValue("@ShopDate", oShopping.ShopDate);
                Command.Parameters.AddWithValue("@WareTitle", oShopping.WareTitle);
                Command.Parameters.AddWithValue("@Price", oShopping.Price);
                Command.Parameters.AddWithValue("@Count", oShopping.Count);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetShopping()
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Select * From Shopping";

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void DeleteShoppingRow(int _id)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Delete From Shopping Where ID={0}", _id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State != ConnectionState.Closed)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetSell()
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Select * From Sell";

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void NewSell(Sell oSell)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"NewSell";

                Command.Parameters.AddWithValue("@WareTitle", oSell.WareTitle);
                Command.Parameters.AddWithValue("@ShopFrom", oSell.ShopFrom);
                Command.Parameters.AddWithValue("@Price", oSell.Price);
                Command.Parameters.AddWithValue("@Count", oSell.Count);
                Command.Parameters.AddWithValue("@Profit", oSell.Profit);
                Command.Parameters.AddWithValue("@Amount", oSell.Amount);
                Command.Parameters.AddWithValue("@SellDate", oSell.SellDate);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void DeleteSellRow(int _id)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Delete From Sell Where ID={0}", _id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetPhoneBook()
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Select * From PhoneBook";

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void DeletePhoneRow(int _id)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Delete From PhoneBook Where ID={0}", _id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void NewPhonePerson(PhoneBook oPhoneBook)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"NewPhoneBook";

                Command.Parameters.AddWithValue("@Name", oPhoneBook.Name);
                Command.Parameters.AddWithValue("@Family", oPhoneBook.Family);
                Command.Parameters.AddWithValue("@Address", oPhoneBook.Address);
                Command.Parameters.AddWithValue("@Mobile", oPhoneBook.Mobile);
                Command.Parameters.AddWithValue("Home", oPhoneBook.Home);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable DueSell(string StartDate, string EndDate)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select * From Sell Where SellDate >= '{0}' And SellDate <= '{1}'", StartDate, EndDate);

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetInstallment()
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Select * From Installment";

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void UpdateRemainder(int id, Int64 Remainder)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Update Installment Set Remainder={0} Where ID={1}", Remainder, id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetInstallmentForSearch()
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = "Select * From Installment Where Remainder>0";

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void DeleteInstallmentRow(int _id)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Delete From Installment Where ID={0}", _id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void NewInstallment(Installment oInstallment)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"NewInstallment";

                Command.Parameters.AddWithValue("@ShopDate", oInstallment.ShopDate);
                Command.Parameters.AddWithValue("@Name", oInstallment.Name);
                Command.Parameters.AddWithValue("@Family", oInstallment.Family);
                Command.Parameters.AddWithValue("@Address", oInstallment.Address);
                Command.Parameters.AddWithValue("@Mobile", oInstallment.Mobile);
                Command.Parameters.AddWithValue("@FactorAmount", oInstallment.FactorAmount);
                Command.Parameters.AddWithValue("@ChequeNo", oInstallment.ChequeNo);
                Command.Parameters.AddWithValue("@ChequeOwner", oInstallment.ChequeOwner);
                Command.Parameters.AddWithValue("@RecieveDate", oInstallment.RecieveDate);
                Command.Parameters.AddWithValue("@BankName", oInstallment.BankName);
                Command.Parameters.AddWithValue("@PrePayment", oInstallment.PrePayment);
                Command.Parameters.AddWithValue("@Remainder", oInstallment.Remainder);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static Installment GetOneRow(int _id)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select * From Installment Where ID={0}", _id);

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                Installment oInstallment = new Installment();
                oInstallment.Name = Convert.ToString(Table.Rows[0]["Name"]);
                oInstallment.Family = Convert.ToString(Table.Rows[0]["Family"]);
                oInstallment.FactorAmount = Convert.ToInt64(Table.Rows[0]["FactorAmount"]);
                oInstallment.Remainder = Convert.ToInt64(Table.Rows[0]["Remainder"]);

                return oInstallment;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetPayment(int _id)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select * From Payment where Installment_ID={0}", _id);

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void NewPayment(Payment oPayment, int id)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Insert into Payment Select {0}, '{1}', '{2}', '{3}', {4}",
                    id, oPayment.DueDate, oPayment.Name, oPayment.Family, oPayment.PaymentAmount);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static Int64 GetOnePersonPayment(int id)
        {
            #region OldWay
            //Connection = new SqlConnection(ConnectionString);
            //Command = new SqlCommand();
            //try
            //{
            //    Connection.Open();
            //    Command.Connection = Connection;
            //    Command.CommandText = string.Format("Select * from Payment Where Installment_ID={0}", id);
            //    DataTable Table = new DataTable();
            //    SqlDataReader Reader = Command.ExecuteReader();
            //    Table.Load(Reader);
            //}
            //finally
            //{
            //    if (Connection.State==ConnectionState.Open)
            //    {
            //        Connection.Close();
            //    }
            //}
            #endregion
            DataTable Table = GetPayment(id);
            Int64 Sum = 0;
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                Sum += Convert.ToInt64(Table.Rows[i]["PaymentAmount"]);
            }
            return Sum;
        }

        public static void DeletePaymentRow(int id)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Delete From Payment Where ID={0}", id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void NewUser(User oUser)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = @"NewUser";

                Command.Parameters.AddWithValue("@Name", oUser.Name);
                Command.Parameters.AddWithValue("@Family", oUser.Family);
                Command.Parameters.AddWithValue("@Username", oUser.Username);
                Command.Parameters.AddWithValue("@Password", oUser.Password);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static DataTable GetAllUsers()
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select * From [User]");

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                return Table;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static User GetOneUser(int id)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Select * From [User] Where ID={0}", id);

                DataTable Table = new DataTable();
                SqlDataReader Reader = Command.ExecuteReader();
                Table.Load(Reader);

                User oUser = new User();
                oUser.ID = id;
                oUser.Name = Convert.ToString(Table.Rows[0]["Name"]);
                oUser.Family = Convert.ToString(Table.Rows[0]["Family"]);
                oUser.Username = Convert.ToString(Table.Rows[0]["Username"]);
                oUser.Password = Convert.ToString(Table.Rows[0]["Password"]);

                return oUser;
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void UpdateUser(User oUser)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Update [User] Set Name='{0}', Family='{1}', Username='{2}' Where ID={3}",
                    oUser.Name, oUser.Family, oUser.Username, oUser.ID);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void UpdateUserPassword(User oUser)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Update [User] Set Password='{0}' Where ID={1}",
                    oUser.Password, oUser.ID);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        public static void DeleteUser(int id)
        {
            Connection = new SqlConnection(ConnectionString);
            Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format("Delete From [User] Where ID={0}", id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }
    }
}
