using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace LandivarApi.Models
{
    public enum Places
    {
        Santa_Cruz = 1,
        Montero,
        Concepcion,
        Warnes,
        Porongo
    };
    public class Landivar
    {
        [Key]
        public int LandivarID { get; set; }

        [Required]
        [Display(Name = "Nombre completo")]
        [StringLength(24, MinimumLength = 2)]
        public string FriendofLandivar { get; set; }

        [Required]
        public Places place { get; set; }
        // VALIDACION PARA CORREOS
        [DataType(DataType.EmailAddress, ErrorMessage = "Email no valido")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Cumpleaños")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
    }
}