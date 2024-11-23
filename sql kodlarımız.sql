CREATE TABLE universite (
    uni_id SERIAL PRIMARY KEY,
    uni_adi VARCHAR(255) NOT NULL,
    rektor INT NOT NULL
    -- FOREIGN KEY (rektor) REFERENCES personel(pers_id)  
);

CREATE TABLE fakulteler (
    fak_id SERIAL PRIMARY KEY,
    fak_adi VARCHAR(255) NOT NULL,
    dekan INT NOT NULL,
    fk_uni_id INT NOT NULL,
    FOREIGN KEY (fk_uni_id) REFERENCES universite(uni_id)
);


CREATE TABLE personel (
    pers_id INT PRIMARY KEY UNIQUE NOT NULL,
    pers_adi VARCHAR(255) NOT NULL,
    pers_soyadi VARCHAR(255) NOT NULL,
    pers_gorev VARCHAR(255),
    pers_sifre VARCHAR(255) NOT NULL,
    fk_fak_id INT NOT NULL,
    FOREIGN KEY (fk_fak_id) REFERENCES fakulteler(fak_id)
);


CREATE TABLE bolumler (
    bolum_id SERIAL PRIMARY KEY,
    bolum_adi VARCHAR(255) NOT NULL,
    baskan INT NOT NULL,
    -- FOREIGN KEY (baskan) REFERENCES akademisyen(akademisyen_id) 
    fk_sekreter INT NOT NULL,
    FOREIGN KEY (fk_sekreter) REFERENCES personel(pers_id),
    fk_fakid INT NOT NULL,
    FOREIGN KEY (fk_fakid) REFERENCES fakulteler(fak_id)
);


CREATE TABLE akademisyen (
    akademisyen_id INT PRIMARY KEY UNIQUE NOT NULL,
    akademisyen_adi VARCHAR(50) NOT NULL,
    akademisyen_soyadi VARCHAR(50) NOT NULL,
    akademisyen_tc VARCHAR(11) UNIQUE,
    akademisyen_tel VARCHAR(15),
    akademisyen_mail VARCHAR(255) UNIQUE,
    akademisyen_sifre VARCHAR(255) NOT NULL,
    fk_bolum_id INT NOT NULL,
    FOREIGN KEY (fk_bolum_id) REFERENCES bolumler(bolum_id)
);


CREATE TABLE sinif (
    snf INT CHECK (snf BETWEEN 1 AND 4), 
    fk_bol_id INT NOT NULL,
    CONSTRAINT pk_sinif_id PRIMARY KEY (snf, fk_bol_id),  
    FOREIGN KEY (fk_bol_id) REFERENCES bolumler(bolum_id)  
);



CREATE TABLE dersler (
    ders_id SERIAL PRIMARY KEY UNIQUE NOT NULL,
    ders_adi VARCHAR(255) NOT NULL,
    derslik VARCHAR(50),
    kredi INT NOT NULL,
    akts INT NOT NULL,
    ders_donem VARCHAR(50),
    fk_bolm_id INT NOT NULL,
	FOREIGN KEY (fk_bolm_id) REFERENCES bolumler(bolum_id),
    fk_snf INT NOT NULL,
	fk_bolm INT NOT NULL,
	FOREIGN KEY (fk_snf, fk_bolm) REFERENCES sinif(snf, fk_bol_id)
);


CREATE TABLE ogrenci (
    ogr_no INT PRIMARY KEY UNIQUE NOT NULL,
    ogr_adi VARCHAR(255) NOT NULL,
    ogr_soyadi VARCHAR(255) NOT NULL,
    ogr_tel VARCHAR(15),
    ogr_mail VARCHAR(255) UNIQUE,
    ogr_tc VARCHAR(11) UNIQUE,
    ogr_sifre VARCHAR(255) NOT NULL,
    ogr_program VARCHAR(255),
    ogr_ogretim VARCHAR(2),
    ogr_durum BOOLEAN,
    danisman INT UNIQUE NOT NULL,
    FOREIGN KEY (danisman) REFERENCES akademisyen(akademisyen_id),
    fk_snff INT NOT NULL,
	fk_bolmm INT NOT NULL,
	FOREIGN KEY (fk_snff, fk_bolmm) REFERENCES sinif(snf, fk_bol_id)
);



CREATE TABLE devamsizlik (
    devamsizlik_id SERIAL PRIMARY KEY,
    tarih DATE NOT NULL,
    fk_ogr_no INT NOT NULL,
    fk_ders_id INT NOT NULL,
    FOREIGN KEY (fk_ogr_no) REFERENCES ogrenci(ogr_no),
    FOREIGN KEY (fk_ders_id) REFERENCES dersler(ders_id)
);


CREATE TABLE notlar (
    not_id SERIAL PRIMARY KEY,
    puan DECIMAL(3,1) NOT NULL,
    not_tur VARCHAR(10) NOT NULL,
    fk_ogrr_no INT NOT NULL,
    fk_derss_id INT NOT NULL,
    FOREIGN KEY (fk_ogrr_no) REFERENCES ogrenci(ogr_no),
    FOREIGN KEY (fk_derss_id) REFERENCES dersler(ders_id)
);

CREATE TABLE yonetici (
    yonetici_id SERIAL PRIMARY KEY,
    adi VARCHAR(255) NOT NULL,
    soyadi VARCHAR(255) NOT NULL,
    sifre VARCHAR(255) NOT NULL
);


ALTER TABLE universite
ADD FOREIGN KEY (rektor) 
REFERENCES personel(pers_id);

ALTER TABLE bolumler
ADD CONSTRAINT fk_baskan FOREIGN KEY (baskan) REFERENCES akademisyen(akademisyen_id);

ALTER TABLE fakulteler
ADD FOREIGN KEY (dekan) 
REFERENCES personel(pers_id)
