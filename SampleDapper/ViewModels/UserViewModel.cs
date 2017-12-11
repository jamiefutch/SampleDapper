using System.Collections.Generic;
using SampleDapper.Models;

namespace SampleDapper.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public int PageNumber { get; set; }
    }
}