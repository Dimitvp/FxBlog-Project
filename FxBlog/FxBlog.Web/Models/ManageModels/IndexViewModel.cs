namespace FxBlog.Web.Models.ManageModels
{
    using System.ComponentModel.DataAnnotations;

    public class IndexViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
