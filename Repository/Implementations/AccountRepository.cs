using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using Repository.Interfaces;
using Repository.Models;

namespace Repository.Implementations
{
    public class AccountRepository : IAccountInterface
    {
         private readonly NpgsqlConnection _conn;

        public AccountRepository(NpgsqlConnection conn)
        {
            _conn= conn;
        }

        public async Task<bool> Register(t_User user)
        {
            
            if (_conn.State != System.Data.ConnectionState.Open)
                await _conn.OpenAsync();

            var sql = @"INSERT INTO t_user (c_companyname, c_emailid, c_password)  
                        VALUES (@name, @email, @pass)";

            using var cmd = new NpgsqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("name", user.c_CompanyName);
            cmd.Parameters.AddWithValue("email", user.c_EmailId);
            cmd.Parameters.AddWithValue("pass", user.c_Password);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<t_User?> LoginUser(string email, string password)
        {
            if (_conn.State != System.Data.ConnectionState.Open)
                await _conn.OpenAsync();
            

            var sql = "SELECT * FROM t_user WHERE c_emailid = @email AND c_password = @pass";
            using var cmd = new NpgsqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("pass", password);

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new t_User
                {
                    c_UserId = (int)reader["c_userid"],
                    c_CompanyName = reader["c_companyname"].ToString(),
                    c_EmailId = reader["c_emailid"].ToString()
                };
            }
            return null;
        }

        public async Task<t_Employee?> LoginEmployee(string email, string password)
        {
            if (_conn.State != System.Data.ConnectionState.Open)
                await _conn.OpenAsync();


            // Using c_email and c_empname based on your t_employee table schema
            var sql = "SELECT * FROM t_employee WHERE c_email = @email AND c_password = @pass";
            using var cmd = new NpgsqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("pass", password);

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new t_Employee
                {
                    c_EmpId = (int)reader["c_empid"],
                    c_EmpName = reader["c_empname"].ToString(),
                    c_Email = reader["c_email"].ToString(),
                    c_Role = reader["c_role"].ToString()
                };
            }
            return null;
        }
    }
}