CREATE TABLE New(
	NewsId INT NOT NULL IDENTITY,
	Sections NVARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_News PRIMARY KEY(NewsId)
);

CREATE TABLE Post(
	PostId INT NOT NULL IDENTITY,
	NewsId INT NOT NULL,
	Content NVARCHAR(MAX),
	Title NVARCHAR(MAX),
	CONSTRAINT PK_Post PRIMARY KEY(PostId),
	CONSTRAINT FK_Post_News_NewsId FOREIGN KEY(NewsId) REFERENCES New (NewsId) ON DELETE CASCADE
);


INSERT INTO dbo.New
        ( Sections )
VALUES  ( 'N Entertainment');
INSERT INTO dbo.New
        ( Sections )
VALUES  ( 'N Sports');
INSERT INTO dbo.New
        ( Sections )
VALUES  ( 'N Education');
INSERT INTO dbo.New
        ( Sections )
VALUES  ( 'N Business');
INSERT INTO dbo.New
        ( Sections )
VALUES  ( 'N Entertainment');
INSERT INTO dbo.New
        ( Sections )
VALUES  ( 'N Entertainment');

SELECT TOP (1000)[NewsId],[Sections] FROM [Newspaper].[dbo].[New]