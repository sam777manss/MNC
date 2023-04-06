     function validateForm()
     {
         debugger;
         var fname = document.getElementById("Fname").value;
         var lname = document.getElementById("Lname").value;
         var email = document.getElementById("Email").value;
         var phone = document.getElementById("Phone").value;
         var address = document.getElementById("Address").value;
         var country = document.getElementById("country-dropdown").value;
         var state = document.getElementById("State").value;
         var pincode = document.getElementById("Pincode").value;

         // fname and lname checking
         let result = /^[a-zA-Z ]+$/.test(fname);
         let resultlname = /^[a-zA-Z ]+$/.test(lname);
          if(fname == "" || !result)
         {
                alert("Invalid First Name");
                return false;
         }
         if(lname == "" || !resultlname)
         {
             alert("Invalid Last Name")
             return false;
         }
         // Country DropDown
         if(country == "")
         {
             alert("Select Country");
             return false;
         }

     }