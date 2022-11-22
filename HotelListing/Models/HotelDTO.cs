using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 50,ErrorMessage = "The Hotel Name Is Too Long")]
        public string name { get; set; }
        
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "The Adress Is Too Long")]
        public string adress { get; set; }
        
        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
    public class HotelDTO : CreateHotelDTO
    {
        public int id { get; set; }
        public CountryDTO Country { get; set; }

    }
}
