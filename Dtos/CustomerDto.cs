using System;
using System.ComponentModel.DataAnnotations;


namespace Dash_Movies.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tu nombre completo")]
        [StringLength(30, ErrorMessage = "El Nombre es muy largo :(")]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //        [Min18YearsIfAMember]
        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }

    }
}