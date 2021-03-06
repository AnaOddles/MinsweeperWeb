USE [MinesweeperWeb]
GO
/****** Object:  Table [dbo].[tbl_GameState]    Script Date: 4/15/2021 8:31:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_GameState](
	[gameStateID] [int] IDENTITY(1,1) NOT NULL,
	[board] [text] NULL,
	[numOfClicks] [int] NULL,
	[userID] [int] NULL,
	[seconds] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[gameStateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 4/15/2021 8:31:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Age] [nvarchar](50) NOT NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[GameStateID] [int] NULL,
	[State] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_GameState]  WITH CHECK ADD FOREIGN KEY([userID])
REFERENCES [dbo].[tbl_User] ([UserID])
GO
ALTER TABLE [dbo].[tbl_GameState]  WITH CHECK ADD FOREIGN KEY([userID])
REFERENCES [dbo].[tbl_User] ([UserID])
GO
ALTER TABLE [dbo].[tbl_User]  WITH CHECK ADD FOREIGN KEY([GameStateID])
REFERENCES [dbo].[tbl_GameState] ([gameStateID])
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteSave]    Script Date: 4/15/2021 8:31:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_DeleteSave]
	@GameStateID int = 0
AS
BEGIN
DELETE 
FROM tbl_GameState
WHERE gameStateID = @GameStateID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GrabGameState]    Script Date: 4/15/2021 8:31:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GrabGameState]
	@UserID int = 0
AS
BEGIN
	SELECT GameStateID
	FROM tbl_User
	WHERE UserID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GrabUserByID]    Script Date: 4/15/2021 8:31:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_GrabUserByID]
	@UserID int = 0
AS
BEGIN
	SELECT * 
	FROM tbl_User
	WHERE UserID = @UserID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertUser]    Script Date: 4/15/2021 8:31:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_InsertUser]
	@FirstName nvarchar(50) = '',
	@LastName nvarchar(50) = '',
	@Gender nvarchar(50) = '',
	@Age nvarchar(50) = '',
	@Email nvarchar(50) = '',
	@Username nvarchar(50) = '',
	@Password nvarchar(50) = '',
	@State nvarchar(50) = '' 
AS
BEGIN
INSERT INTO tbl_User (FirstName, LastName, Gender, Age,
	EmailAddress, Username, Password, State) VALUES(@FirstName, @LastName, @Gender, @Age, @Email, @Username, @Password, @State)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_LoginUser]    Script Date: 4/15/2021 8:31:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_LoginUser]
	@Username nvarchar(50) = '',
	@Password nvarchar(50) = ''
AS
BEGIN
	SELECT * 
	FROM tbl_User
	WHERE Username = @Username
	AND Password = @Password
END
GO
