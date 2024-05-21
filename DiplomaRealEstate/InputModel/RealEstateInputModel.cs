using System.ComponentModel.DataAnnotations;

namespace DiplomaRealEstate.InputModel
{
    public class RealEstateInputModel
    {
        [Required(ErrorMessage = "Введите общую площадь недвижимости!")]
        public string Area { get; set; }
        [Required(ErrorMessage = "Введите цену!")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Введите количество комнат!")]
        public int Rooms { get; set; }
        public string? Desctiption { get; set; }
        [Required(ErrorMessage = "Введите Страну!")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Введите регион или город Фед. значения")]
        public string Region { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? House { get; set; }
        public string? Latitude { get; set; } = "0";
        public string? Longitude { get; set; } = "0";
        [Required(ErrorMessage = "Выберите фотографию!")]
        [DataType(DataType.ImageUrl)]
        public string Photos { get; set; }
        public string UserId { get; set; }
        [Required(ErrorMessage = "Введите тип продажи!")]
        public Guid TypeSalesId { get; set; }
        [Required(ErrorMessage = "Введите тип недвижимости!")]
        public Guid TypeRealEstateId { get; set; }
        [Required(ErrorMessage = "Введите категорию недвижимости!")]
        public Guid CategoryId { get; set; }
    }
}