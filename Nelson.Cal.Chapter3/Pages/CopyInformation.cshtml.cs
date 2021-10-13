using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Nelson.Cal.Chapter3.Pages
{
    [BindProperties]
    public class CopyInformationModel : PageModel
    {

        public string Color;

        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public void OnPostCopy()
        {

        }

        public void OnPostClear()
        {
           
                FirstName = "";
                MiddleInitial = "";
                LastName = "";
                Address = "";
                City = "";
                State = "";
                ZipCode = "";
            

        }

        public void OnPostColor()
        {
            Color = "red";

            /*
            string []lmnts = { FirstName, MiddleInitial, LastName, Address, City, State, ZipCode };

            for(int i = 0; i < 7; i++)
            {
                if(lmnts[i].Length < 1)
                {

                } else
                {
                    Color = "red";
                }
            }*/

        }

        public void OnGet()
        {
        }
    }
}
