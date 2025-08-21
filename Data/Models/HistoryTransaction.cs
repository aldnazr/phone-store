using System.Text.Json.Serialization;

namespace PhoneStore.Data.Models
{
    public partial class HistoryTransaction
    {
        [JsonPropertyName("id_transaksi")]
        public int? IdTransaksi { get; set; }

        [JsonPropertyName("pelayan")]
        public string? Pelayan { get; set; }

        [JsonPropertyName("nama_pelanggan")]
        public string? NamaPelanggan { get; set; }

        [JsonPropertyName("tanggal")]
        public string Tanggal { get; set; } = string.Empty;

        [JsonPropertyName("nama_brand")]
        public string? NamaBrand { get; set; }

        [JsonPropertyName("nama_handphone")]
        public string? NamaHandphone { get; set; }

        [JsonPropertyName("harga_barang")]
        public int? HargaBarang { get; set; }

        [JsonPropertyName("jumlah_pembelian")]
        public int? JumlahPembelian { get; set; }

        [JsonPropertyName("subtotal")]
        public int? Subtotal { get; set; }

        [JsonPropertyName("total_harga")]
        public int? TotalHarga { get; set; }
    }
}
