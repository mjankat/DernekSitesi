using System.ComponentModel.DataAnnotations;

namespace DernekSitesi.Entities
{
	public class Etkinlik : IEntity
	{
		public int Id { get; set; }

		[Display(Name = "Etkinlik Adı"), StringLength(100), Required(ErrorMessage = "{0} Boş Bırakılamaz")]
		public string Name { get; set; }

		[Display(Name = "Etkinlik Açıklaması")]
		public string? Description { get; set; }

		[Display(Name = "Etkinlik Resmi"), StringLength(100)]
		public string? Image { get; set; }

		[Display(Name = "Durum")]
		public bool IsActive { get; set; }

		[Display(Name = "Eklenme Tarihi")]
		public DateTime? CreateDate { get; set; } = DateTime.Now;

		[Display(Name = "Kayan Paylaşım")]
		public bool IsSlider { get; set; }
	}
}
