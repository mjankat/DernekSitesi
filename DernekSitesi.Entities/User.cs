using System.ComponentModel.DataAnnotations;

namespace DernekSitesi.Entities
{
	public class User : IEntity
	{
		public int Id { get; set; }

		[Display(Name = "Adı"), StringLength(100)]
		public string Name { get; set; }

		[Display(Name = "Soyadı"), StringLength(100)]
		public string Surname { get; set; }

		[Display(Name = "Email"), StringLength(100)]
		public string Email { get; set; }

		[Display(Name = "Şifre"), StringLength(100)]
		public string Password { get; set; }

		[Display(Name = "Kullanıcı Adı"), StringLength(100)]
		public string? UserName { get; set; }

		[Display(Name = "Durum")]
		public bool IsActive { get; set; }

		[Display(Name = "Eklenme Tarihi")]
		public DateTime? CreateDate { get; set; } = DateTime.Now;
	}
}
