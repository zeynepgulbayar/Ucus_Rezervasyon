## UçakRezervasyon Projesi

### Proje Açıklaması
UçakRezervasyon, uçak rezervasyon işlemlerini yönetmek için geliştirilmiş bir Windows Forms uygulamasıdır. Bu proje, uçaklar, lokasyonlar ve rezervasyonlar gibi temel bileşenleri içerir ve Entity Framework Core kullanarak SQLite veritabanı ile etkileşim sağlar.

### Gereksinimler
- .NET Framework 4.8
- Visual Studio 2019 veya üzeri
- NuGet paketleri:
  - Microsoft.EntityFrameworkCore
  - Microsoft.EntityFrameworkCore.Sqlite
  - Microsoft.EntityFrameworkCore.Tools
  - Newtonsoft.Json

### Kurulum
1. Projeyi klonlayın:
    ```sh
    git clone https://github.com/kullanici/ucakrezervasyon.git
    cd ucakrezervasyon
    ```

2. Gerekli NuGet paketlerini yükleyin:
    ```sh
    dotnet restore
    ```

3. Veritabanını oluşturun ve gerekli migrasyonları uygulayın:
    ```sh
    dotnet ef database update
    ```

### Kullanım
1. Visual Studio'da `UcakRezervasyon.sln` dosyasını açın.
2. Çözümü derleyin ve çalıştırın.
3. Uygulama açıldığında, uçak, lokasyon ve rezervasyon işlemlerini yönetmek için ilgili formları kullanabilirsiniz.

### Proje Yapısı ve Sınıflar

#### `Program.cs`
Uygulamanın giriş noktasıdır. `Main` metodu, uygulamanın başlatılmasını sağlar.

#### `MainForm.cs`
Ana form ve navigasyon işlemlerini yönetir. Kullanıcı, buradan diğer formlara geçiş yapabilir.

#### `ReservationForm.cs`
Rezervasyon işlemlerini yönetir. Rezervasyon ekleme, listeleme ve koltuk seçimi gibi işlemleri içerir.

#### `AircraftForm.cs`
Uçak bilgilerini yönetir. Uçak ekleme ve listeleme işlemlerini içerir.

#### `LocationForm.cs`
Lokasyon bilgilerini yönetir. Lokasyon ekleme ve listeleme işlemlerini içerir.

#### `ApplicationDBContext.cs`
Veritabanı bağlantılarını ve DbSet'leri tanımlar. Veritabanı işlemlerinin yönetildiği sınıftır.


```16:42:ApplicationDBContext.cs
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Aircraft> Aircrafts { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Reservation> Reservations { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string dbPath = "database.db";
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlite($"Data Source={dbPath}");
			}

			// Check if the database file exists
			if (!File.Exists(dbPath))
			{
				throw new FileNotFoundException($"The database file '{dbPath}' does not exist.");
			}

			// Ensure the application has permission to access the database file
			FileInfo fileInfo = new FileInfo(dbPath);
			if (!fileInfo.Exists || fileInfo.IsReadOnly)
			{
				throw new UnauthorizedAccessException($"The database file '{dbPath}' is not accessible or is read-only.");
			}
		}
```


#### `Reservation.cs`
Rezervasyon sınıfı. Rezervasyon bilgilerini tutar.


```9:25:Reservation.cs
	public class Reservation
	{
		public int Id { get; set; }
		public int AircraftId { get; set; }
		public Aircraft Aircraft { get; set; }
		public int DepartureLocationId { get; set; }
		public Location DepartureLocation { get; set; }
		public int ArrivalLocationId { get; set; }
		public Location ArrivalLocation { get; set; }
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public string SelectedSeat { get; set; } // Seçilen koltuk
		public string CustomerName { get; set; }
		public string CustomerSurname { get; set; }
		public string CustomerPhone { get; set; }
		public string CustomerEmail { get; set; }
	}
```


#### `Aircraft.cs`
Uçak sınıfı. Uçak bilgilerini tutar.


```9:16:Aircrafts.cs
	public class Aircraft
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public string Brand { get; set; }
		public string SerialNumber { get; set; }
		public int SeatCapacity { get; set; }
	}
```


#### `Location.cs`
Lokasyon sınıfı. Lokasyon bilgilerini tutar.


```9:16:Location.cs
	public class Location
	{
		public int Id { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public string Airport { get; set; }
		public bool IsActive { get; set; }
	}
```


### Lisans
Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.
