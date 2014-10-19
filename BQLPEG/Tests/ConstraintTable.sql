CREATE TABLE Person
(
	PersonID INT NOT NULL,
	FirstName NVARCHAR(255),
	LastName NVARCHAR(255),
	SocialInsuranceNumber VARCHAR(50),
	CONSTRAINT UK_SocialInsuranceNumber UNIQUE (SocialInsuranceNumber)
)