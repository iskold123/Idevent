﻿CREATE PROCEDURE [dbo].[spGetCompanyById]
	@id int
AS
BEGIN
	SELECT C.id, C.Name, C.CVR, C.PhoneNumber, C.Email, C.CVR, C.Note, A.Id, A.StreetAddress,A.City, A.PostalCode, A.Country, B.Id, B.StreetAddress, B.City, B.PostalCode, B.Country
	FROM CompanyModel AS C
	INNER JOIN AddressModel as A ON C.AddressId = A.Id
	INNER JOIN AddressModel AS B ON C.InvoiceAddressId = B.Id
	WHERE C.Id = @id
END