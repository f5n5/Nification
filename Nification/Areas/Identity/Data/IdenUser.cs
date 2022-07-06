using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Nification.Models;

namespace Nification.Areas.Identity.Data;

// Add profile data for application users by adding properties to the IdenUser class
public class IdenUser : IdentityUser
{
    public List<Customer>? Customer{ get; set; }
}

