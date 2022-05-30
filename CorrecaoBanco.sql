ALTER TABLE cadFunc
DROP COLUMN endereço;

ALTER TABLE cadClientForn
DROP COLUMN endereço;

ALTER TABLE cadFunc
ADD bairro nvarchar(40),
    numero nvarchar(20),
	rua nvarchar(40);

ALTER TABLE cadClientForn
ADD rua nvarchar(40);