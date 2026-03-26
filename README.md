# Araç Kiralama Otomasyonu / Vehicle Rental Automation System

> **C# Windows Forms + Microsoft SQL Server** tabanlı masaüstü araç kiralama yönetim uygulaması.
> A desktop vehicle rental management application built with **C# Windows Forms + Microsoft SQL Server**.

---

## İçindekiler / Table of Contents

- [Proje Hakkında / About](#proje-hakkında--about)
- [Ekran Görüntüleri / Screenshots](#ekran-görüntüleri--screenshots)
- [Teknolojiler / Technologies](#teknolojiler--technologies)
- [Proje Yapısı / Project Structure](#proje-yapısı--project-structure)
- [Veritabanı Şeması / Database Schema](#veritabanı-şeması--database-schema)
- [Stored Procedure'lar / Stored Procedures](#stored-procedureler--stored-procedures)
- [Kurulum / Installation](#kurulum--installation)
- [Çalıştırma / Running the Project](#çalıştırma--running-the-project)
- [Konfigürasyon / Configuration](#konfigürasyon--configuration)
- [Lisans / License](#lisans--license)

---

## Proje Hakkında / About

**TR:** Bu proje, küçük ve orta ölçekli araç kiralama işletmeleri için geliştirilmiş bir masaüstü yönetim sistemidir. Müşteri kayıt, personel yönetimi, araç envanteri ve kiralama raporlarını tek bir arayüzden yönetmeye olanak tanır.

**EN:** This project is a desktop management system developed for small to medium-sized vehicle rental businesses. It enables the management of customer registration, staff management, vehicle inventory, and rental reports from a single interface.

### Temel Özellikler / Key Features

| Özellik / Feature | Açıklama / Description |
|---|---|
| Bağlantı Doğrulama | Uygulama başlangıcında SQL Server bağlantısını test eder |
| Müşteri Yönetimi | Ad, soyad, telefon, e-posta ve şehir bilgisiyle müşteri kaydı |
| Personel Yönetimi | Tam CRUD operasyonları (Ekle / Listele / Güncelle / Sil) |
| Araç Envanteri | Typed DataSet ile plaka, marka, model, yıl, renk, vites, yakıt ve günlük ücret takibi |
| Raporlama | En çok kiralama yapan müşteri ve en yüksek tutarlı kiralama sorguları |
| Şehir Seçimi | Combo box ile dinamik şehir listesi yükleme |

---

## Ekran Görüntüleri / Screenshots

> Uygulamaya ait ekran görüntüleri `AracKiralamAutomationExample/AracKiralamAutomationExample/Resources/` klasörü altında bulunmaktadır.

---

## Teknolojiler / Technologies

| Katman / Layer | Teknoloji / Technology |
|---|---|
| Dil / Language | C# (.NET Framework 4.7.2) |
| UI Framework | Windows Forms (WinForms) |
| Veritabanı / Database | Microsoft SQL Server (MSSQL) |
| Veri Erişimi / Data Access | ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`) |
| Typed DataSet | XSD tabanlı otomatik üretilmiş (auto-generated) dataset |
| Konfigürasyon / Config | `App.config` + `System.Configuration.ConfigurationManager` |
| Bağımlılık / Dependency | NuGet: `System.Configuration.ConfigurationManager v10.0.1` |
| IDE | Microsoft Visual Studio 2019+ |

---

## Proje Yapısı / Project Structure

Bu repo, gelişim sürecini yansıtan **3 ayrı Visual Studio solution** içermektedir.

```
arac-kiralama-otomasyonu/
│
├── AracKiralama.sln                          # Ana solution dosyası / Main solution
├── AracKiralama/                             # Ana proje / Main project
│   ├── Program.cs                            # Uygulama giriş noktası / Entry point
│   ├── Form1.cs                              # Veritabanı bağlantı ekranı / DB connection screen
│   ├── Form1.Designer.cs                     # Form1 UI layout (auto-generated)
│   ├── Form2.cs                              # Boş form / Empty placeholder form
│   ├── Form_User_Login_cs.cs                 # Müşteri yönetim formu / Customer management form
│   ├── Form_User_Login_cs.Designer.cs        # Form UI layout (auto-generated)
│   ├── AracKiralamaDataSet.xsd               # Typed DataSet şeması / schema
│   ├── AracKiralamaDataSet.Designer.cs       # DataSet (auto-generated)
│   ├── App.config                            # Bağlantı dizisi / Connection string
│   ├── packages.config                       # NuGet bağımlılıkları / Dependencies
│   └── Properties/
│       ├── AssemblyInfo.cs
│       ├── Resources.resx
│       └── Settings.settings
│
├── AracKiralamAutomationExample/             # Gelişmiş örnek / Advanced example
│   └── AracKiralamAutomationExample/
│       ├── Program.cs
│       ├── Form1.cs                          # Bağlantı ekranı / Connection screen
│       ├── Form_User_Login.cs                # Personel yönetim formu / Staff management form
│       ├── AracKiralamaDataSet.xsd
│       ├── App.config
│       ├── Resources/
│       │   ├── arka plan.jpg                 # Arka plan görseli / Background image
│       │   └── kiralik-aracta-hasari-kim-oder.jpg
│       └── Properties/
│
├── AracKiralamaOtomasyon/                    # Başlangıç taslağı / Initial scaffold
│   └── WindowsFormsApp1/
│       ├── Program.cs
│       ├── Form1.cs                          # Boş form / Empty form
│       ├── App.config
│       └── Properties/
│
└── packages/                                 # NuGet paket klasörü / NuGet packages
    └── System.Configuration.ConfigurationManager.10.0.1/
```

### Solution Açıklamaları / Solution Descriptions

| Solution | Açıklama |
|---|---|
| `AracKiralama.sln` | **Ana proje.** Müşteri (Müşteriler) yönetimi ve araç envanteri içerir. |
| `AracKiralamAutomationExample.sln` | **Gelişmiş örnek.** Personel (Personeller) için tam CRUD + raporlama içerir. |
| `AracKiralamaOtomasyon.sln` | **Başlangıç iskeleti.** Henüz geliştirilmemiş taslak proje. |

---

## Veritabanı Şeması / Database Schema

> **Veritabanı adı / Database name:** `AracKiralama`

### Table_Araclar (Araçlar / Vehicles)

```sql
CREATE TABLE Table_Araclar (
    AracID        INT           PRIMARY KEY IDENTITY(1,1),
    Plaka         NVARCHAR(20)  NOT NULL,          -- License Plate
    Marka         NVARCHAR(50)  NULL,               -- Brand/Make
    Model         NVARCHAR(50)  NULL,               -- Model
    Model_Yili    INT           NULL,               -- Model Year
    Renk          NVARCHAR(30)  NULL,               -- Color
    Vites         NVARCHAR(20)  NULL,               -- Transmission (Manual/Auto)
    Yakit_Tipi    NVARCHAR(20)  NULL,               -- Fuel Type
    Kilometre     INT           NULL,               -- Mileage (km)
    Gunluk_Ucret  DECIMAL(10,2) NULL,               -- Daily Rental Rate (₺)
    Durum         NVARCHAR(20)  NULL                -- Status (Müsait/Kirada/Bakımda)
);
```

### Table_Musteriler (Müşteriler / Customers)

```sql
CREATE TABLE Table_Musteriler (
    MusteriID  INT           PRIMARY KEY IDENTITY(1,1),
    ad         NVARCHAR(50)  NOT NULL,   -- First Name
    soyad      NVARCHAR(50)  NOT NULL,   -- Last Name
    telefon    NVARCHAR(15)  NULL,       -- Phone Number
    mail       NVARCHAR(100) NULL        -- Email Address
);
```

### Table_Personeller (Personel / Staff)

```sql
CREATE TABLE Table_Personeller (
    PersonelID       INT           PRIMARY KEY IDENTITY(1,1),
    personel_ad      NVARCHAR(50)  NOT NULL,  -- First Name
    personel_soyad   NVARCHAR(50)  NOT NULL,  -- Last Name
    personel_telefon NVARCHAR(15)  NULL,      -- Phone Number
    Pozisyon         NVARCHAR(50)  NULL       -- Position/Role
);
```

### Table_Cities (Şehirler / Cities)

```sql
CREATE TABLE Table_Cities (
    CityID     INT           PRIMARY KEY IDENTITY(1,1),
    city_name  NVARCHAR(100) NOT NULL   -- City Name
);
```

---

## Stored Procedure'ler / Stored Procedures

Uygulama, veritabanı operasyonlarını doğrudan SQL sorgusu yerine **Stored Procedure** aracılığıyla gerçekleştirir. Bu yaklaşım SQL Injection'a karşı ek koruma sağlar ve mantığı veritabanı katmanında toplar.

The application performs all database operations via **Stored Procedures** instead of inline SQL queries. This provides additional SQL Injection protection and centralizes logic in the database layer.

### Müşteri İşlemleri / Customer Operations

```sql
-- Yeni müşteri ekle / Insert new customer
CREATE PROCEDURE sp_new_Insert_Into_Table_Musteriler
    @ad       NVARCHAR(50),
    @soyad    NVARCHAR(50),
    @telefon  NVARCHAR(15),
    @mail     NVARCHAR(100)
AS
BEGIN
    INSERT INTO Table_Musteriler (ad, soyad, telefon, mail)
    VALUES (@ad, @soyad, @telefon, @mail);
END;

-- Şehir referansı ekle / Insert city reference
CREATE PROCEDURE sp_new_insert_Table_Cities
    @city_name NVARCHAR(100)
AS
BEGIN
    INSERT INTO Table_Cities (city_name)
    VALUES (@city_name);
END;
```

### Personel İşlemleri / Staff Operations

```sql
-- Personel ekle / Insert staff
CREATE PROCEDURE sp_Table_Personeller_Insert_Into
    @personel_ad      NVARCHAR(50),
    @personel_soyad   NVARCHAR(50),
    @personel_telefon NVARCHAR(15),
    @Pozisyon         NVARCHAR(50)
AS
BEGIN
    INSERT INTO Table_Personeller (personel_ad, personel_soyad, personel_telefon, Pozisyon)
    VALUES (@personel_ad, @personel_soyad, @personel_telefon, @Pozisyon);
END;

-- Tüm personeli listele / Select all staff
CREATE PROCEDURE sp_Table_Personeller_Select
AS
BEGIN
    SELECT * FROM Table_Personeller;
END;

-- Personel güncelle / Update staff
CREATE PROCEDURE sp_Table_Personeller_Update
    @PersonelID       INT,
    @personel_ad      NVARCHAR(50),
    @personel_soyad   NVARCHAR(50),
    @personel_telefon NVARCHAR(15),
    @Pozisyon         NVARCHAR(50)
AS
BEGIN
    UPDATE Table_Personeller
    SET personel_ad = @personel_ad,
        personel_soyad = @personel_soyad,
        personel_telefon = @personel_telefon,
        Pozisyon = @Pozisyon
    WHERE PersonelID = @PersonelID;
END;

-- Personel sil / Delete staff
CREATE PROCEDURE sp_Table_Personeller_Delete
    @PersonelID INT
AS
BEGIN
    DELETE FROM Table_Personeller WHERE PersonelID = @PersonelID;
END;
```

### Raporlama / Reporting Queries

```sql
-- En çok kiralama yapan müşteri / Customer with most rentals
CREATE PROCEDURE sp_EnCokKiralamaYapanMusteri
AS
BEGIN
    SELECT TOP 1
        m.ad, m.soyad, COUNT(k.MusteriID) AS KiralamaSayisi
    FROM Table_Musteriler m
    JOIN Table_Kiralamalar k ON m.MusteriID = k.MusteriID
    GROUP BY m.ad, m.soyad
    ORDER BY KiralamaSayisi DESC;
END;

-- En yüksek tutarlı kiralama / Highest amount rental
CREATE PROCEDURE sp_EnYuksekTutarliKiralama
AS
BEGIN
    SELECT TOP 1 *
    FROM Table_Kiralamalar
    ORDER BY ToplamTutar DESC;
END;
```

### Veri Akışı / Data Flow

```
[Form1] ──Bağlantı Testi──► SQL Server
    │
    └──► [Form_User_Login]
              │
              ├── ComboBox ◄── sp_new_insert_Table_Cities (Şehirler)
              ├── Kaydet   ──► sp_new_Insert_Into_Table_Musteriler
              ├── Listele  ──► sp_Table_Personeller_Select ──► DataGridView
              ├── Güncelle ──► sp_Table_Personeller_Update
              ├── Sil      ──► sp_Table_Personeller_Delete
              └── Rapor    ──► sp_EnCokKiralamaYapanMusteri
                               sp_EnYuksekTutarliKiralama
```

---

## Kurulum / Installation

### Gereksinimler / Prerequisites

| Gereksinim / Requirement | Versiyon / Version | İndirme / Download |
|---|---|---|
| Visual Studio | 2019 veya üstü / 2019 or later | [visualstudio.microsoft.com](https://visualstudio.microsoft.com/) |
| .NET Framework | 4.7.2 | Visual Studio ile birlikte gelir / Included with Visual Studio |
| SQL Server | 2017 veya üstü / 2017 or later | [microsoft.com/sql-server](https://www.microsoft.com/tr-tr/sql-server/sql-server-downloads) |
| SQL Server Management Studio (SSMS) | 18+ | [SSMS İndir / Download SSMS](https://aka.ms/ssmsfullsetup) |
| Git | Herhangi bir sürüm | [git-scm.com](https://git-scm.com/) |

> Visual Studio kurulumunda **".NET masaüstü geliştirme"** iş yükünün seçili olduğundan emin olun.
> During Visual Studio setup, make sure the **".NET desktop development"** workload is selected.

---

### 1. Adım — Repoyu Klonlayın / Step 1 — Clone the Repository

```bash
git clone https://github.com/<kullanici-adi>/<repo-adi>.git
cd arac-kiralama-otomasyonu
```

---

### 2. Adım — Veritabanını Kurun / Step 2 — Set Up the Database

**SSMS** (SQL Server Management Studio) ile aşağıdaki adımları izleyin:

1. SSMS'i açın ve SQL Server'a bağlanın.
2. Yeni bir veritabanı oluşturun:

```sql
CREATE DATABASE AracKiralama;
USE AracKiralama;
```

3. Tabloları oluşturun (`CREATE TABLE` sorgularını [Veritabanı Şeması](#veritabanı-şeması--database-schema) bölümünden kopyalayın).
4. Stored Procedure'leri oluşturun (`CREATE PROCEDURE` sorgularını [Stored Procedure'ler](#stored-procedureler--stored-procedures) bölümünden kopyalayın).

---

### 3. Adım — Bağlantı Dizisini Güncelleyin / Step 3 — Update the Connection String

Her solution içindeki `App.config` dosyasını açın ve `connectionStrings` bölümünü kendi SQL Server örneğinize göre güncelleyin:

```xml
<connectionStrings>
  <add name="AracKiralama.Properties.Settings.AracKiralamaConnectionString"
       connectionString="Data Source=SUNUCU_ADI\ORNEK_ADI;Initial Catalog=AracKiralama;Integrated Security=True;TrustServerCertificate=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

| Parametre | Açıklama | Örnek |
|---|---|---|
| `Data Source` | SQL Server sunucu ve örnek adı | `BILGISAYAR_ADI\SQLEXPRESS` |
| `Initial Catalog` | Veritabanı adı | `AracKiralama` |
| `Integrated Security` | Windows kimlik doğrulaması | `True` |
| `TrustServerCertificate` | Yerel geliştirme için sertifika uyarısını atlar | `True` |

> **NOT / NOTE:** Eğer SQL Server Authentication kullanıyorsanız `Integrated Security=False` yaparak `User ID=kullanici;Password=sifre;` ekleyin. Şifreleri asla kaynak koda ya da repoya koymayın.
> If using SQL Server Authentication, set `Integrated Security=False` and add `User ID=user;Password=pass;`. Never commit passwords to source control.

---

### 4. Adım — NuGet Paketlerini Yükleyin / Step 4 — Restore NuGet Packages

Visual Studio'da solution'ı açtığınızda paketler otomatik olarak yüklenir. Manuel yükleme için:

```
Araçlar > NuGet Paket Yöneticisi > Paket Yöneticisi Konsolu
Tools > NuGet Package Manager > Package Manager Console
```

```powershell
Update-Package -reinstall
```

---

## Çalıştırma / Running the Project

1. **Solution'ı açın:** `AracKiralama.sln` dosyasına çift tıklayın.
2. **Başlangıç projesini ayarlayın:** Solution Explorer'da `AracKiralama` projesine sağ tıklayın → *Set as Startup Project*.
3. **Derleyin:** `Ctrl + Shift + B` (Build Solution).
4. **Çalıştırın:** `F5` (Debug) veya `Ctrl + F5` (Release without debug).

Uygulama açıldığında ilk ekranda SQL Server bağlantısı test edilir. Bağlantı başarılıysa ana form otomatik olarak açılır.

---

## Konfigürasyon / Configuration

### App.config Dosyası

Her proje klasöründe bir `App.config` bulunur. Bu dosya bağlantı dizisini (connection string) içerir ve **yerel ortama göre düzenlenmelidir**.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <configSections>
    <sectionGroup name="applicationSettings" ...>
      <section name="AracKiralama.Properties.Settings" ... />
    </sectionGroup>
  </configSections>
  <connectionStrings>
    <add name="..."
         connectionString="Data Source=SUNUCU\ORNEK;Initial Catalog=AracKiralama;
                           Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
```

> `App.config` dosyası `.gitignore` tarafından **hariç tutulmamıştır** çünkü proje yapısı için gereklidir. Ancak gerçek sunucu adı veya kimlik bilgisi içeriyorsa hassas bilgileri kaldırarak repoya yükleyin.

---

## Mimari / Architecture

```
┌─────────────────────────────────────┐
│         Presentation Layer          │
│   Windows Forms (Form1, Form_User)  │
├─────────────────────────────────────┤
│         Data Access Layer           │
│   ADO.NET (SqlConnection/Command)   │
│   Typed DataSet (XSD + Designer)    │
├─────────────────────────────────────┤
│           Database Layer            │
│  SQL Server — Stored Procedures     │
│  Tables: Araclar, Musteriler,       │
│          Personeller, Cities        │
└─────────────────────────────────────┘
```

---

## Lisans / License

Bu proje eğitim ve staj başvurusu amaçlı geliştirilmiştir.
This project was developed for educational purposes and internship application.

---

<div align="center">

**Geliştirici / Developer**

C# · Windows Forms · MSSQL · ADO.NET · .NET Framework 4.7.2

</div>
