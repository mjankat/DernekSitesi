using System.ComponentModel.DataAnnotations;

namespace DernekSitesi.Entities
{
	public class Haber : IEntity
	{
		public int Id { get; set; }

		[Display(Name = "Haber Adı"), StringLength(100)]
		public string Name { get; set; }

		[Display(Name = "Haber Açıklaması")]
		public string? Description { get; set; }

		[Display(Name = "Haber Resmi"), StringLength(100)]
		public string? Image { get; set; }

		[Display(Name = "Durum")]
		public bool IsActive { get; set; }

		[Display(Name = "Eklenme Tarihi")]
		public DateTime? CreateDate { get; set; } = DateTime.Now;

		[Display(Name = "Kayan Paylaşım")]
		public bool IsSlider { get; set; }
	}
}
