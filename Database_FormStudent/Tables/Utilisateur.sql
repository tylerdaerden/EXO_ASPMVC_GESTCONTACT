CREATE TABLE [dbo].[Utilisateur]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Nom] NVARCHAR(50) NOT NULL , 
	[Prenom] nvarchar(50) NOT NULL,
	[Email] nvarchar(384) NOT NULL UNIQUE,
	[Passwd] nvarchar(50) NOT NULL,
	constraint PK_Utilisateur Primary Key ([Id])

)
