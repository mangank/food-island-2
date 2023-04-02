using Microsoft.AspNetCore.Mvc;

using App3.Models;

namespace App3.Controllers;

public class AccountsController: Controller
{

public IActionResult Create(){

    return View();
}

    public IActionResult Login(){

        return View();
    }

    public IActionResult Profile(){

       /*   Person user1 = new Person();

          user1.id = 1;
          user1.name = "Monty";
          user1.lastname = "Phahlane";
          user1.contact_number = "0812365460";
          user1.email = "phahlanemm@gmail.com";
          user1.age = 16;
          user1.occupation = "Programmer";
        */
        

        Person user1 = new Person();

        user1.GetCustomerInfo(2);
        return View(user1);
    }
    public IActionResult CustomerProfile(int cuscode){

       /*   Person user1 = new Person();

          user1.id = 1;
          user1.name = "Monty";
          user1.lastname = "Phahlane";
          user1.contact_number = "0812365460";
          user1.email = "phahlanemm@gmail.com";
          user1.age = 16;
          user1.occupation = "Programmer";
        */
        

        Person user1 = new Person();

        user1.GetCustomerInfo(cuscode);
        return View("~/Views/Accounts/Profile.cshtml",user1);
    }

    public IActionResult ChangePassword(){

        return View();
    }
    [HttpPost]
    public IActionResult CreateProfile(string name,string lastname, string contact, string email){

        Person newuser  = new Person();

        newuser.name = name;
        newuser.lastname = lastname;
        newuser.contact_number = contact;
        newuser.email = email;

        string status = newuser.Insert();

            if(status.Equals("success")){

        return View("~/Views/Accounts/Login.html");

            }else{
                return View("~/Views/Accounts/Create.cshtml");
            }
    }
}


/*

- User to create an account
- User will login
- User View/Update thier Profile
- user will change Password

*/