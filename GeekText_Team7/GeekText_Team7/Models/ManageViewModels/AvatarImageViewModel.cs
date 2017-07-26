using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.Models.ManageViewModels
{
    public class AvatarImageViewModel
    {
        [DataType(DataType.Upload)]
        [Display(Name = "Avatar Image")]
        public byte[] AvatarImage { get; set; }
    }
}
