USE upisi_test
CREATE TABLE polaznici (
id INT NULL,
ime VARCHAR(50) NOT NULL,
prezime VARCHAR(50) NOT NULL,
mjesto_stanovanja VARCHAR(25),
CONSTRAINT chk_id CHECK (id BETWEEN 1 AND 1000)
)
GO