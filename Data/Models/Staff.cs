using System.Text.Json.Serialization;

namespace PhoneStore.Data.Models
{
    public partial class Staff
    {
        [JsonPropertyName("ID_USER")]
        public int? IdUser { get; set; }

        [JsonPropertyName("NAMA_LENGKAP")]
        public string? NamaLengkap { get; set; }

        [JsonPropertyName("TANGGAL_LAHIR")]
        public string? TanggalLahir { get; set; } = string.Empty;

        [JsonPropertyName("GENDER")]
        public string? Gender { get; set; }

        [JsonPropertyName("ALAMAT")]
        public string? Alamat { get; set; }

        [JsonPropertyName("EMAIL")]
        public string? Email { get; set; }

        [JsonPropertyName("NO_TELP")]
        public string? NoTelp { get; set; }

        [JsonPropertyName("TIPE_AKUN")]
        public string? TipeAkun { get; set; }

        [JsonPropertyName("USERNAME")]
        public string? Username { get; set; }

        [JsonPropertyName("PASSWORD")]
        public string? Password { get; set; }
    }
}