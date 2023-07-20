using System.ComponentModel.DataAnnotations;

namespace DernekSitesi.Entities
{
	public class Yonetim : IEntity
	{
		public int Id { get; set; }

		[Display(Name = "Adı"), StringLength(100), Required(ErrorMessage = "{0} Boş Bırakılamaz")]
		public string Name { get; set; }

		[Display(Name = "Soyadı"), StringLength(100), Required(ErrorMessage = "{0} Boş Bırakılamaz")]
		public string Surname { get; set; }

		[Display(Name = "Görevi")]
		public string? Position { get; set; }

		[Display(Name = "Kişi Resmi"), StringLength(100)]
		public string? Image { get; set; }

		[Display(Name = "Durum")]
		public bool IsActive { get; set; }

		[Display(Name = "Görevlendirme Tarihi")]
		public DateTime? CreateDate { get; set; } = DateTime.Now;
	}
}
