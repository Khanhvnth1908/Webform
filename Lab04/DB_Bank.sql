CREATE TABLE DB_Bank(
	Id INT NOT NULL IDENTITY,
	BankName NVARCHAR(MAX),
	IFSC NVARCHAR(100),
	CONSTRAINT B_Id PRIMARY KEY(Id)
);