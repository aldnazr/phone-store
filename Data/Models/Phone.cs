using System.Text.Json.Serialization;

namespace PhoneStore.Data.Models
{
    public partial class Phone
    {
        [JsonPropertyName("ID_PHONE")]
        public int? IdPhone { get; set; }

        [JsonPropertyName("ID_BRAND")]
        public int? IdBrand { get; set; }

        [JsonPropertyName("NAMA_HANDPHONE")]
        public string? NamaHandphone { get; set; }

        [JsonPropertyName("DESKRIPSI")]
        public string? Deskripsi { get; set; }

        [JsonPropertyName("HARGA")]
        public int? Harga { get; set; }

        [JsonPropertyName("STOK")]
        public int? Stok { get; set; }

        [JsonPropertyName("NAMA_BRAND")]
        public string? NamaBrand { get; set; }
    }
}