using System.Diagnostics.CodeAnalysis;
#region Yazdırma Komutları
//Console.WriteLine("***** Yemek Kategorileri*****");
//Console.WriteLine();
//Console.WriteLine("1-Çorbalar");
//Console.WriteLine("2-Ana Yemekler");
//Console.WriteLine("3- Soğuk Başlangıçlar");
//Console.WriteLine("4-Salatalar");
//Console.WriteLine("5-Tatlılar");
//Console.WriteLine("6-İçecekler");
//Console.WriteLine();
//Console.WriteLine("***** Yemek Kategorileri*****");
#endregion
#region  String Değişkenler

//string name;
//name = "Betül";
//Console.Write(name);
//string customerName;
//string customerSurname;
//string customerPhone;
//string customerEmail, district, city;
//customerName="Ali";
//customerSurname="Çınar";
//customerPhone="+90 500 400 30 20";
//customerEmail="deneme@gmail.com";
//district="Kadıköy";
//city="İstanbul";
//Console.WriteLine("**** Rezervasyon Kartı ****");
//Console.WriteLine();
//Console.WriteLine("-----------------------------------------------");
//Console.WriteLine("Müşteri: " + customerName+ " " +customerSurname);
//Console.WriteLine("İletişim: " + customerPhone);
//Console.WriteLine("Email adresi: " + customerEmail);
//Console.WriteLine("Adres: " +district + "/" +city);
//Console.WriteLine("-----------------------------------------------");


#endregion
#region Int Değişkenler
int number = 24;
Console.WriteLine(number);
int hamburgerPrice=300;
int cokePrice=35;
int waterPrice=10;
int friesPrice=50;
int pizzaPrice=250;
int lemonadePrice=30;
Console.WriteLine("**** Restoran Menü Fiyatı ****");
Console.WriteLine();
Console.WriteLine("----Hamburger: " +hamburgerPrice + " TL");
Console.WriteLine("----Kola: " +cokePrice + " TL");
Console.WriteLine("----Su: " +waterPrice + " TL");
Console.WriteLine("----patates: " +friesPrice + " TL");
Console.WriteLine("----pizza: " +pizzaPrice + " TL");
Console.WriteLine("----limonata: " +lemonadePrice +  " TL");
Console.WriteLine();
int hamburgerCount=3;
int cokeCount=3;
int waterCount=3;
int friesCount=1;
int pizzaCount=0;
int lemonadeCount=0;
int totalHamburgerPrice=0;
int totalCokePrice=0;
int totalWaterPrice=0;
int totalFriesPrice=0;
int totalPizzaPrice=0;
int totalLemonadePrice=0;

totalHamburgerPrice = hamburgerCount*hamburgerPrice;
totalCokePrice = cokeCount*cokePrice;
totalWaterPrice = waterCount*waterPrice;
totalFriesPrice = friesCount*friesPrice;
totalPizzaPrice = pizzaCount*pizzaPrice;
totalLemonadePrice = lemonadeCount*lemonadePrice;
int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
Console.WriteLine("-------------------------------");
Console.WriteLine();
Console.WriteLine("Hamburger Tutarı: " +totalHamburgerPrice + " TL");
Console.WriteLine("Kola Tutarı: " +totalCokePrice + " TL");
Console.WriteLine("Su Tutarı: " +totalWaterPrice + " TL");
Console.WriteLine("Patates Tutarı: " +totalFriesPrice + " TL");
Console.WriteLine("Pizza Tutarı: " +totalPizzaPrice + " TL");
Console.WriteLine("Limonata Tutarı: " +totalLemonadePrice + " TL");
Console.WriteLine("Toplam Tutar: " +totalPrice + " TL");
Console.WriteLine();
Console.WriteLine("-------------------------------");

#endregion
