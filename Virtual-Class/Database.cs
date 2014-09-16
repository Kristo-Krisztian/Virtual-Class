﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Virtual_Class
{
    class Database
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        
        public Database(string connectionString)
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }

        ~Database()
        {
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }
        public void InsertData(string where,string data)
        {
            try
            {
                command.CommandText = "INSERT INTO Users(UserName) VALUES (@value)";
                command.Parameters.AddWithValue("@value", data);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error inserting value,error string: " + ex.ToString());
            }
        }

        public void UpdateData(string where,int id,string data)
        {
            try
            {
                command.CommandText = "UPDATE Users SET  " + where + " =@value where Id="+id;
                command.Parameters.AddWithValue("@value", data);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error updating value,error string: ", ex.ToString());
            }
        }

        public void InsertObject(User userObject)
        {
            try
            {
                command.CommandText = "INSERT INTO Users(@userName,@Password,@isAdmin) values(@v_userName,@v_Password,@v_isAdmin)";
                command.Parameters.AddWithValue("@v_userName", userObject.Username);
                command.Parameters.AddWithValue("@v_Password", userObject.Password);
                command.Parameters.AddWithValue("@v_isAdmin", userObject.IsAdmin);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error inserting user object,error message: " + ex.ToString());
            }
        }

        public void ReadData(string from)
        {
            try
            {
                command.CommandText = "SELECT " + from + " FROM Users";
                reader = command.ExecuteReader();
                while(reader.Read())
                {
                    MessageBox.Show(reader[from].ToString());
                }
                reader.Close();
                command.Parameters.Clear();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error reading from database,error string: " + ex.ToString());
            }
        }

        public bool CompareObject(User inObject)
        {
            command.CommandText = "SELECT * from Users";
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                if (reader["userName"].ToString() == inObject.Username && reader["Password"].ToString() == inObject.Password)
                    return true;
            }

            return false;
        }
    }
}