using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models {
    public class Family {
        
        [JsonPropertyName("Id")]
        [Key]
        public int Id { get; set; }
        [JsonPropertyName("Photo")]
        public string Photo  { get; set; }
        [JsonPropertyName("StreetName")]
        [Required, StringLength(30)]
        public string StreetName { get; set; }
        [JsonPropertyName("HouseNumber")]
        [Required, Range(0,1000)]
        public int HouseNumber{ get; set; }
        [JsonPropertyName("Adults")]
        public IList<Adult> Adults { get; set; }
        [JsonPropertyName("Children")]
        public IList<Child> Children{ get; set; }
        [JsonPropertyName("Pets")]
        public IList<Pet> Pets{ get; set; }

        public Family() {
            Adults = new List<Adult>();
            Children = new List<Child>();
            Pets = new List<Pet>();
        }
    }


}