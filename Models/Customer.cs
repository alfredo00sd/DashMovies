using System;
using System.ComponentModel.DataAnnotations;

namespace Dash_Movies.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tu nombre completo")]
        [StringLength(30, ErrorMessage = "El Nombre es muy largo :(")]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Tipo de la membresia")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        [Min18YearsifAMember]
        public DateTime? Birthdate { get; set; }

    }
}