using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.TestData
{
    internal class FormSubmissionData
    {
        public static List<Dictionary<string, string>> testFormData = new()
        {
            new Dictionary<string, string>
            {
                { "firstName", "Peter" },
                { "lastName", "Test" },
                { "title", "Mr" },
                { "birthDay", "1" },
                { "birthMonth", "July" },
                { "birthYear", "1984" },
                { "password", "Password" },
                { "email", "pmmandes@gmail.com" },
                { "address", "16 Galway road" },
                { "state", "Cape Town" },
                { "city", "Parow" },
                { "country", "United States" },
                { "zipcode", "7500" },
                { "mobileNumber", "0603411618" }
            },
            new Dictionary<string, string>
            {
                { "firstName", "Kandy" },
                { "lastName", "Test" },
                { "title", "Mrs" },
                { "birthDay", "2" },
                { "birthMonth", "February" },
                { "birthYear", "1982" },
                { "password", "Password1" },
                { "email", "kandy.m@gmail.com" },
                { "address", "16 Galway road" },
                { "state", "Cape Town" },
                { "city", "Belhar" },
                { "country", "United States" },
                { "zipcode", "7493" },
                { "mobileNumber", "0810810810" }
            },
            new Dictionary<string, string>
            {
                { "firstName", "Zack" },
                { "lastName", "Test" },
                { "title", "Mr" },
                { "birthDay", "13" },
                { "birthMonth", "March" },
                { "birthYear", "2015" },
                { "password", "Password2" },
                { "email", "zac@gmail.com" },
                { "address", "16 Galway road" },
                { "state", "Cape Town" },
                { "city", "Goedverwacht" },
                { "country", "India" },
                { "zipcode", "7501" },
                { "mobileNumber", "0810810811" }
            }
        };
        public static List<Dictionary<string, string>> testCase2Data = new()
        {
            new Dictionary<string, string>
            {
                { "firstName", "Zack" },
                { "lastName", "Test" },
                { "title", "Mr" },
                { "birthDay", "13" },
                { "birthMonth", "March" },
                { "birthYear", "2015" },
                { "password", "Password2" },
                { "email", "zac@gmail.com" },
                { "address", "16 Galway road" },
                { "state", "Cape Town" },
                { "city", "Goedverwacht" },
                { "country", "India" },
                { "zipcode", "7501" },
                { "mobileNumber", "0810810811" }

            }
        };
    }
}
