using PatikaWeek7PracticePatikafyMusicPlatform;

List<Singer> singers = new List<Singer>() // Bir liste oluşturup, şarkıcıları ekliyorum
{
    new Singer
    {
        FullName = "Ajda Pekkan", Genre = "Pop", ReleaseYear = 1968, AlbumSales = 20000000
    },
    new Singer
    {
        FullName = "Sezen Aksu", Genre = "Türk Halk Müziği, Pop", ReleaseYear = 1971, AlbumSales = 10000000
    },
    new Singer
    {
        FullName = "Funda Arar", Genre = "Pop", ReleaseYear = 1999, AlbumSales = 3000000
    },
    new Singer
    {
        FullName = "Sertab Erener", Genre = "Pop", ReleaseYear = 1994, AlbumSales = 5000000
    },
    new Singer
    {
        FullName = "Sıla", Genre = "Pop", ReleaseYear = 2009, AlbumSales = 3000000
    },
    new Singer
    {
        FullName = "Serdar Ortaç", Genre = "Pop", ReleaseYear = 1994, AlbumSales = 10000000
    },
    new Singer
    {
        FullName = "Tarkan", Genre = "Pop", ReleaseYear = 1992, AlbumSales = 40000000
    },
    new Singer
    {
        FullName = "Hande Yener", Genre = "Pop", ReleaseYear = 1999, AlbumSales = 7000000
    },
    new Singer
    {
        FullName = "Hadise", Genre = "Pop", ReleaseYear = 2005, AlbumSales = 5000000
    },
    new Singer
    {
        FullName = "Gülben Ergen", Genre = "Pop, Türk Halk Müziği", ReleaseYear = 1997, AlbumSales = 10000000
    },
    new Singer
    {
        FullName = "Neşet Ertaş", Genre = "Türk Halk Müziği, Türk Sanat Müziği", ReleaseYear = 1960, AlbumSales = 2000000
    },
};

Console.WriteLine("Adı 'S' ile başlayan şarkıcılar");

var nameStartingWithS = singers.Where(singer => singer.FullName.StartsWith("S")).ToList(); // Adı 'S' ile başlayan şarkıcılar

foreach (var singer in nameStartingWithS)
{
    Console.WriteLine($"Şarkıcı Adı ve Soyadı: {singer.FullName}");
}

Console.WriteLine("---------------------");

Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar"); 

var AlbumSalesMoreThanTenMillion = singers.Where(singer => singer.AlbumSales >= 10000000);// Albüm satışı 10 milyon ve üstünde olan şarkıcılar


foreach (var singer in AlbumSalesMoreThanTenMillion)
{
    Console.WriteLine($"Şarkıcı Adı ve Soyadı: {singer.FullName}, Albüm Satışları: {singer.AlbumSales}");
}

Console.WriteLine("----------------------");

Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.");

var popBefore2000 = singers.Where(singer => singer.ReleaseYear < 2000 && singer.Genre.Contains("Pop")) // 2000 yılı öncesi çıkmış ve pop müzik yapan şarkıcılar
                           .OrderBy(singer => singer.ReleaseYear)
                           .ThenBy(singer => singer.FullName)
                           .ToList();

var groupedByYear = popBefore2000.GroupBy(singer => singer.ReleaseYear); // Çıkış yıllarına göre gruplama işlemi

foreach (var group in groupedByYear)
{
    Console.WriteLine($"Yıl: {group.Key}"); 
    foreach (var singer in group.OrderBy(s => s.FullName))
    {
        Console.WriteLine($"Şarkıcı Adı ve Soyadı: {singer.FullName}, Yaptığı Müzik Türü: {singer.Genre}, Albüm Satışları: {singer.AlbumSales}");
    }
}

Console.WriteLine("-------------------------------------");

var topSeller = singers.OrderByDescending(singer => singer.AlbumSales)
                       .FirstOrDefault();

Console.WriteLine($"En çok satış yapan şarkıcı: {topSeller.FullName}, Albüm Satışları: {topSeller.AlbumSales}");

Console.WriteLine("-------------------------------------");

var oldestSinger = singers.OrderBy(singer => singer.ReleaseYear)
                          .FirstOrDefault();

Console.WriteLine($"En eski çıkış yapan şarkıcı: {oldestSinger.FullName}, Çıkış Yılı: {oldestSinger.ReleaseYear}");

Console.WriteLine("-------------------------------------");

var newestSinger = singers.OrderByDescending (singer => singer.ReleaseYear)
                          .FirstOrDefault();

Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newestSinger.FullName}, Çıkış Yılı: {newestSinger.ReleaseYear}");
