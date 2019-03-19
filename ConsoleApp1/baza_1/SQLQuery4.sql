use upisi_test
create table upisi(
polaznici_id INT
FOREIGN KEY
REFERENCES polaznici(id)
)