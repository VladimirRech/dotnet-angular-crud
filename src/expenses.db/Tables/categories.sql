CREATE TABLE [dbo].[categories]
(
  [id] INT NOT NULL IDENTITY PRIMARY KEY,
  [description] VARCHAR(100) NOT NULL,
  [update_date] DATETIME NOT NULL
)
