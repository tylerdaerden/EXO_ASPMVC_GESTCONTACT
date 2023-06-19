CREATE TABLE [dbo].[Contact]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Nom] nvarchar(50) not null ,
	[Prenom] nvarchar(50) not null ,
	[Email] nvarchar(384) not null ,
	[DateNaissance] DATE NOT NULL,
	[Tel] INT NOT NULL,
	Id_Utilisateur INT NOT NULL,
	CONSTRAINT PK_CONTACT PRIMARY KEY (Id),
	CONSTRAINT FK_CONTACT FOREIGN KEY (Id_Utilisateur) REFERENCES [Utilisateur](Id)
)
