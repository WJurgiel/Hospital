-- Initialize Hospital Database with all tables and relationships

USE klinika;

-- Drop existing tables if they exist (in correct order for foreign keys)
DROP TABLE IF EXISTS opinie;
DROP TABLE IF EXISTS wypisani;
DROP TABLE IF EXISTS recepty;
DROP TABLE IF EXISTS pacjenci;
DROP TABLE IF EXISTS leki;
DROP TABLE IF EXISTS lekarze;
DROP TABLE IF EXISTS specjalizacje;

-- 1. Specializations table
CREATE TABLE specjalizacje (
  ID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  Specjalizacja VARCHAR(255) NOT NULL UNIQUE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 2. Doctors table
CREATE TABLE lekarze (
  ID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  Imie VARCHAR(255) NOT NULL,
  Nazwisko VARCHAR(255) NOT NULL,
  ID_Specjalizacji INT(11) NOT NULL,
  Login VARCHAR(255) NOT NULL UNIQUE,
  Haslo VARCHAR(255) NOT NULL,
  FOREIGN KEY (ID_Specjalizacji) REFERENCES specjalizacje(ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 3. Medications table
CREATE TABLE leki (
  ID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  Nazwa VARCHAR(255) NOT NULL,
  Producent VARCHAR(255) NOT NULL,
  ID_Schorzenia INT(11)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 4. Patients table
CREATE TABLE pacjenci (
  ID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  Imie VARCHAR(255) NOT NULL,
  Nazwisko VARCHAR(255) NOT NULL,
  ID_Schorzenia INT(11),
  Diagnoza TEXT,
  Data_Przyjecia DATE NOT NULL,
  ID_Lekarza INT(11) NOT NULL,
  nr_bliskiego VARCHAR(11),
  login VARCHAR(255) NOT NULL UNIQUE,
  haslo VARCHAR(255) NOT NULL,
  Pesel VARCHAR(11),
  CzyGlosoval TINYINT(1) DEFAULT 0,
  FOREIGN KEY (ID_Lekarza) REFERENCES lekarze(ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 5. Prescriptions table
CREATE TABLE recepty (
  ID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  ID_Leku INT(11) NOT NULL,
  ID_Pacjenta INT(11) NOT NULL,
  ID_Lekarza INT(11) NOT NULL,
  Stosowanie DATE NOT NULL,
  NR_recepty INT(11),
  FOREIGN KEY (ID_Leku) REFERENCES leki(ID),
  FOREIGN KEY (ID_Pacjenta) REFERENCES pacjenci(ID),
  FOREIGN KEY (ID_Lekarza) REFERENCES lekarze(ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 6. Opinions table
CREATE TABLE opinie (
  ID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  ID_Lekarza INT(11) NOT NULL,
  Ocena INT(1),
  komentarz VARCHAR(255),
  Anonimowe INT(1) DEFAULT 0,
  Imie VARCHAR(50),
  Nazwisko VARCHAR(50),
  FOREIGN KEY (ID_Lekarza) REFERENCES lekarze(ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- 7. Discharged table
CREATE TABLE wypisani (
  ID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
  ID_Lekarza INT(11) NOT NULL,
  Ocena INT(1),
  komentarz VARCHAR(255),
  Anonimowe INT(1) DEFAULT 0,
  Imie VARCHAR(50),
  Nazwisko VARCHAR(50),
  FOREIGN KEY (ID_Lekarza) REFERENCES lekarze(ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Seed data: Insert specializations
INSERT INTO specjalizacje (Specjalizacja) VALUES
('Kardiologia'),
('Neurologia'),
('Ortopedia'),
('Pediatria'),
('Chirurgia');

-- Seed data: Insert test doctors
INSERT INTO lekarze (Imie, Nazwisko, ID_Specjalizacji, Login, Haslo) VALUES
('Jan', 'Kowalski', 1, 'doktor1', 'haslo123'),
('Maria', 'Nowak', 2, 'doktor2', 'haslo123'),
('Piotr', 'Zielinski', 3, 'doktor3', 'haslo123');

-- Seed data: Insert test medications
INSERT INTO leki (Nazwa, Producent, ID_Schorzenia) VALUES
('Aspirin', 'Bayer', 1),
('Ibuprofen', 'Novartis', 1),
('Paracetamol', 'GSK', 2);

-- Seed data: Insert test patient
INSERT INTO pacjenci (Imie, Nazwisko, Diagnoza, Data_Przyjecia, ID_Lekarza, nr_bliskiego, login, haslo, Pesel, CzyGlosoval) VALUES
('Anna', 'Lewandowska', 'Choroba serca', NOW(), 1, '123456789', 'pazjent1', 'haslo123', '12345678901', 0);

-- Seed data: Insert admin user (stored in a notes - consider adding admin table in future)
-- For now, admin credentials are hardcoded in application: admin / admin123


