﻿using RentalSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalSystem.BL.Helper
{
    public static class ListHelper
    {
        public static IEnumerable<ProductModel> DataSetToProductList(DataSet ds)
        {
            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new ProductModel
            {
                Id = int.Parse(dataRow["Id"].ToString()),
                VendorId = int.Parse(dataRow["VendorId"].ToString()),
                Name = dataRow["Name"].ToString(),
                Description = dataRow["Description"].ToString(),
                Image1 = dataRow["Image1"].ToString(),
                Image2 = dataRow["Image2"].ToString(),
                Image3 = dataRow["Image3"].ToString(),
                Availability = Convert.ToBoolean(dataRow["Availability"].ToString()),
                StartDate = Convert.ToDateTime(dataRow["StartDate"].ToString()),
                EndDate = Convert.ToDateTime(dataRow["EndDate"].ToString()),
                CategoryId = int.Parse(dataRow["CategoryId"].ToString()),
                UnitPrice = Convert.ToDouble(dataRow["UnitPrice"].ToString())
            });
            return list;
        }


        public static IEnumerable<RentProductsModel> DataSetToRentList(DataSet ds)
        {
            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new RentProductsModel
            {
                Id = int.Parse(dataRow["Id"].ToString()),
                VendorId = int.Parse(dataRow["VendorId"].ToString()),
                Email = dataRow["Email"].ToString(),
                ProductId = Convert.ToInt32(dataRow["ProductId"].ToString()),
                Payment = Convert.ToBoolean(dataRow["Payment"].ToString()),
                Status = Convert.ToBoolean(dataRow["Status"].ToString()),
                TotalCost = Convert.ToDouble(dataRow["TotalCost"].ToString()),
                StartDate = Convert.ToDateTime(dataRow["StartDate"].ToString()),
                EndDate = Convert.ToDateTime(dataRow["EndDate"].ToString()),
                CategoryId = int.Parse(dataRow["CategoryId"].ToString()),
                UnitCost = Convert.ToDouble(dataRow["UnitCost"].ToString())
            });
            return list;
        }

        public static IEnumerable<UserModel> DataSetToUserList(DataSet ds)
        {
            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new UserModel
            {
                Id = int.Parse(dataRow["Id"].ToString()),
                Name = Convert.ToString(dataRow["Name"]),
                Email = dataRow["Email"].ToString(),
                Contact = Convert.ToString(dataRow["Contact"]),
                Address = Convert.ToString(dataRow["Address"]),
                Photo = Convert.ToString(dataRow["Photo"]),
                Valid = Convert.ToBoolean(dataRow["Valid"]),
                Age = dataRow["Age"] is DBNull?0: Convert.ToInt32(dataRow["Age"]),
                PaymentId = dataRow["PaymentId"] is DBNull ? 0 : Convert.ToInt32(dataRow["PaymentId"])
            });
            return list;
        }
        public static IEnumerable<UserLoginModel> DataSetToUserLogins(DataSet ds)
        {
            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new UserLoginModel
            {
                Id = int.Parse(dataRow["Id"].ToString()),
                Password = dataRow["Password"].ToString(),
                Email = dataRow["Email"].ToString(),
                RoleId = int.Parse(dataRow["RoleId"].ToString())
            });
            return list;
        }

        public static IEnumerable<CategoryModel> DataSetToCategoryList(DataSet ds)
        {
            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new CategoryModel
            {
                Id = int.Parse(dataRow["Id"].ToString()),
                Name = dataRow["Name"].ToString()
            });
            return list;
        }
    }
}
