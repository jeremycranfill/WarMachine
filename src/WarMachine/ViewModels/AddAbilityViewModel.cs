using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarMachine.ViewModels
{
    public class AddAbilityViewModel
    {

        [Required]
        public string Name;
        [Required]
        public string Description;
    }
}
