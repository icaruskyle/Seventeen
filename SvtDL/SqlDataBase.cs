using System;
using System.Data.SqlClient;
using System.Net;
using Carat;

namespace SvtDL
{
    public class SqlDataBase
    {
            string connectionString
            = "Data Source =KYLE-BOOK19\\SQLEXPRESS; Initial Catalog = Seventeen;Integrated Security = True;";

            SqlConnection sqlConnection;


        public SqlDataBase()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<Discography> GetDiscographies()
        {
            string selectStatement = "SELECT Title, Albumtype FROM Carat";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<Discography> discographies = new List<Discography>();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                string Title = reader["Title"].ToString();
                string Albumtype = reader["Albumtype"].ToString();

                Discography readDiscography = new Discography();
                readDiscography.Title = Title;
                readDiscography.Albumtype = Albumtype;

                discographies.Add(readDiscography);
            }

            sqlConnection.Close();

            return discographies;
        }
        public int AddDiscography(string Title, string Albumtype)

        {
            int success;

            string insertStatement = "INSERT INTO Carat VALUES (@Title, @Albumtype)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);


            insertCommand.Parameters.AddWithValue("@Title", Title);
            insertCommand.Parameters.AddWithValue("@Albumtype", Albumtype);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;

        }

        public int UpdateDiscography(string Title, string Albumtype)
        {
            int success;

            string updateStatement = $"UPDATE Carat SET Title = @Title WHERE Albumtype = @Albumtype";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@Title", Title);
            updateCommand.Parameters.AddWithValue("@Albumtype", Albumtype);

            success = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;

        }

        public int DeleteDiscography(string Title, string Albumtype)
        {
            int success;

            string deleteStatement = $"UPDATE FROM Carat WHERE Title = @Title, Albumtype = @Albumtype";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@Title", Title);
            deleteCommand.Parameters.AddWithValue("@Albumtype", Albumtype);

            success = deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;

        }





    }

}