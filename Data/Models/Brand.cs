using System.Text.Json.Serialization;

namespace PhoneStore.Data.Models
{
    public partial class Brand
    {
        [JsonPropertyName("ID_BRAND")]
        public int? IdBrand { get; set; }

        [JsonPropertyName("NAMA_BRAND")]
        public string? NamaBrand { get; set; }
    }
}