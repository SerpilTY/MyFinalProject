using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";

        public static string ProductNameInvalid = " Product Name is invalid";

        public static string ProductsListed = " Products Listed";

        public static string MaintenanceTime = " System is on Maintenance";

        public static string ProductCountOfCategoryError = " Category Limit Exceeded for this product";

        public static string ProductNameAlreadyExists = " Product Name Already Exists";

        public  static string CategoryLimitExceeded= "Category Limit Exceeded";
        public static string AuthorizationDenied = "Authorization Denied ";

        public static string UserRegistered = "User Registered";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Successful Login";
        public static string UserAlreadyExists = "User Already Exists";
        public static string AccessTokenCreated = "Access Token Created";
    }
}
