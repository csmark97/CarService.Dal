using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarService.Dal.Users
{
    public enum UserType
    {
        [Display(Name = "Ügyfél")]
        CLIENT,
        [Display(Name = "Alkalmazott")]
        WORKER,
        [Display(Name = "Cég")]
        COMPANY
    }
}
