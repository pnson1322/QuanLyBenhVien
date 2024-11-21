﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace QuanLyBenhVien.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            //_connectionString = "Server=(local); Database=QuanLyBenhVien; Integrated Security=true";
            _connectionString = "Data Source=.\\SQLEXPRESS01;Initial Catalog=QuanLyBenhVien;Integrated Security=True;Trust Server Certificate=True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
