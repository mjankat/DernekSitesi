using System.ComponentModel.DataAnnotations;

namespace DernekSitesi.Entities
{
	public class User : IEntity
	{
		public int Id { get; set; }

		[Display(Name = "Adı"), StringLength(100), Required(ErrorMessage ="{0} Boş Bırakılamaz")]
		public string Name { get; set; }

		[Display(Name = "Soyadı"), StringLength(100), Required(ErrorMessage = "{0} Boş Bırakılamaz")]
		public string Surname { get; set; }

		[Display(Name = "Email"), StringLength(100), Required(ErrorMessage = "{0} Boş Bırakılamaz")]
		public string Email { get; set; }

		[Display(Name = "Şifre"), StringLength(100), Required(ErrorMessage = "{0} Boş Bırakılamaz")]
		public string Password { get; set; }

		[Display(Name = "Kullanıcı Adı"), StringLength(100)]
		public string? UserName { get; set; }

		[Display(Name = "Durum")]
		public bool IsActive { get; set; }

		[Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
		public DateTime? CreateDate { get; set; } = DateTime.Now;

        [Display(Name = "Kullanıcı Rolü"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int RolId { get; set; }

        [Display(Name = "Kullanıcı Rolü")]
        public virtual Rol? Rol { get; set; }
    }
}
