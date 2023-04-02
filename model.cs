using System;

using MySql.Data.MySqlClient;




namespace App3.Models

{

    public class Person

    {




        static string connStr = "server=localhost;port=3306;database=ecomm;user=ecomm;password=ifundi@2023";

        public int id {get; set;}

        public string? name {get;set;}




        public string? lastname {get;set;}




        public string? contact_number {get;set;}




        public string? email {get;set;}




        public string? address {get;set;}




        public DateTime DOB {get;set;}




        public int age;




        public string? occupation {get;set;}

        public void SetAge(){




        }

        public string RetrieveFullName(){




            return name + " " + lastname;

        }




        public void GetCustomerInfo(int custno){




           // Person customer = new Person();




          //  MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=ecomm;user=ecomm;password=ifundi@2023");

            

            MySqlConnection connection = new MySqlConnection(connStr);




            using(connection){

                connection.Open();

            MySqlCommand sqlstatement = new MySqlCommand("SELECT * FROM ecomm.customer where idcustomer=" + custno+";",connection);




            using(var results = sqlstatement.ExecuteReader()){




            results.Read();

                    id = Convert.ToInt32(results["idcustomer"]);

                    name = Convert.ToString(results["name"]);

                    lastname = Convert.ToString(results["lastname"]);

                    email = Convert.ToString(results["email"]);





            }





            }




            

        }

    }

}