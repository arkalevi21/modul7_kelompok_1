using System;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok_1
{
    public class DataMahasiswa103082400051 
    {
        // Menambahkan '?' agar boleh null
        public string? nama { get; set; }
        public long nim { get; set; }
        public string? fakultas { get; set; }

        public void ReadJson() 
        {
            try {
                string filePath = "jurnal7_1_103082400051.json";
                string jsonString = File.ReadAllText(filePath);
                
                // Deserialisasi JSON ke object
                var mhs = JsonSerializer.Deserialize<DataMahasiswa103082400051>(jsonString);
                
                if (mhs != null) {
                    Console.WriteLine($"Nama: {mhs.nama}, NIM: {mhs.nim}, Fakultas: {mhs.fakultas}");
                }
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {
            DataMahasiswa103082400051 mahasiswa = new DataMahasiswa103082400051();
            mahasiswa.ReadJson();
        }
    }
}