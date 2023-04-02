@{
    ViewData["Title"] = "Login";
}
@model loginModel
<div class="text-center">
    <h1 class="display-4">Login</h1>
   
<div class="jumbotron">  
    <strong>ASP.NET MVC</strong>  
</div>  
 
<form action="Login" method="post">
    <table>
       
        <tr>
            <td>Username: </td>
            <td><input type="text" name="Username" /></td>
        </tr>
        <tr>
            <td>Password: </td>
            <td><input type="text" name="Password" /></td>
        </tr>
        <tr>
            <td colspan="2"><input type="submit" value="Submit Form" /></td>
        </tr>
    </table>
</form>
 
<table cellpadding="0" cellspacing="0">
 
    <tr>
        <th>Username</th>
        <th>Password</th>
    </tr>        
    @if(@Model!=null)
    {
        <tr>
            <td>@Model.Username</td>
            <td>@Model.Password</td>
        </tr>
        <tr>
            <td><p>&nbsp&nbsp Your Password is successfully authenticated.</p></td>
        </tr>
    }
 
</table>
 
Userlogin.cs
 
using System;
 
namespace potsforplants.Models
{
public class loginModel
  {
    public string? RequestId {get; set;}
    public string? Username {get; set;}
    public string? Password {get; set;}
 
  public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
}
 
 
Homecontroller.cs add
 
 [HttpPost]
    public IActionResult Login(loginModel obj)
   {
        MySqlConnection conn = new MySqlConnection(constr);
        using (conn)
        {
             var uname = obj.Username;
   
            string query = $"SELECT First_Name, Last_Name, Email, Password FROM customer where username = '{uname}';";
   
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = conn;
                conn.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        obj.Password = string.Format("{0:S}", sdr["password"]);
                        if (string.Compare(obj.Password,string.Format("{0:S}", sdr["password"]),false)==0)
                            return View("Index");
                        else
                            return View("Privacy");                        
                    }
                }
                conn.Close();
            }
        }        
        return View(obj);
    }
 
  }
}
 
 
 public IActionResult Login()
        {
            return View();
        }