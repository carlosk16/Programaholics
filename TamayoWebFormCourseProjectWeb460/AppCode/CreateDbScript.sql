USE [Programaholics]
GO
/****** Object:  Table [dbo].[PastApplications]    Script Date: 6/17/2016 5:47:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PastApplications](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CompletionDate] [datetime] NULL,
	[LanguageUsed] [nvarchar](50) NULL,
	[ApplicationCompleted] [bit] NULL,
	[UserAccountId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 6/17/2016 5:47:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccount](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](2) NULL,
	[FavLanguage] [nvarchar](50) NULL,
	[LeastFavLanguage] [nvarchar](50) NULL,
	[DateOfLastProgramCompleted] [datetime] NULL,
	[Lockout] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
SET IDENTITY_INSERT [dbo].[PastApplications] ON 

GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (7, CAST(0x0000A61A00000000 AS DateTime), N'C#', 1, 2)
GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (8, CAST(0x0000A44000000000 AS DateTime), N'HTML', 1, 5)
GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (9, CAST(0x0000A58900000000 AS DateTime), N'Java', 0, 7)
GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (10, CAST(0x0000A5A800000000 AS DateTime), N'SQL', 1, 8)
GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (11, CAST(0x0000A5E400000000 AS DateTime), N'JavaScript', 0, 9)
GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (12, CAST(0x0000A5E900000000 AS DateTime), N'C++', 1, 10)
GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (13, CAST(0x0000A5E400000000 AS DateTime), N'C#', 1, 11)
GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (14, CAST(0x0000A5E500000000 AS DateTime), N'Java', 1, 12)
GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (15, CAST(0x0000A5F900000000 AS DateTime), N'Java', 1, 13)
GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (17, CAST(0x0000A61800000000 AS DateTime), N'C++', 1, 14)
GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (18, CAST(0x0000A62600000000 AS DateTime), N'C++', 1, 15)
GO
SET IDENTITY_INSERT [dbo].[PastApplications] OFF
GO
SET IDENTITY_INSERT [dbo].[UserAccount] ON 

GO
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [City], [State], [FavLanguage], [LeastFavLanguage], [DateOfLastProgramCompleted], [Lockout]) VALUES (2, N'carlos', N'tamayo', N'Orlando', N'FL', N'C#', N'Java', CAST(0x0000A61A00000000 AS DateTime), 0)
GO
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [City], [State], [FavLanguage], [LeastFavLanguage], [DateOfLastProgramCompleted], [Lockout]) VALUES (5, N'Denys', N'Olleik', NULL, NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [City], [State], [FavLanguage], [LeastFavLanguage], [DateOfLastProgramCompleted], [Lockout]) VALUES (7, N'Denys1', N'Olleik', NULL, NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [City], [State], [FavLanguage], [LeastFavLanguage], [DateOfLastProgramCompleted], [Lockout]) VALUES (8, N'John', N'deer', NULL, NULL, NULL, NULL, NULL, 0)
GO
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [City], [State], [FavLanguage], [LeastFavLanguage], [DateOfLastProgramCompleted], [Lockout]) VALUES (9, N'Gary', N'Yourmom', N'Summerville', N'HI', N'English', N'Spanish', CAST(0x0000A628015EC678 AS DateTime), 0)
GO
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [City], [State], [FavLanguage], [LeastFavLanguage], [DateOfLastProgramCompleted], [Lockout]) VALUES (10, N'Peter', N'Griffin', N'Bufallo', N'IR', N'C++', N'Java', CAST(0x0000A58900000000 AS DateTime), 0)
GO
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [City], [State], [FavLanguage], [LeastFavLanguage], [DateOfLastProgramCompleted], [Lockout]) VALUES (11, N'Lois', N'Griffin', N'Bufallo', N'IR', N'Java', N'C#', CAST(0x0000A5E400000000 AS DateTime), 0)
GO
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [City], [State], [FavLanguage], [LeastFavLanguage], [DateOfLastProgramCompleted], [Lockout]) VALUES (12, N'Brian', N'Griffin', N'Bufallo', N'IR', N'Java', N'C#', CAST(0x0000A5E500000000 AS DateTime), 0)
GO
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [City], [State], [FavLanguage], [LeastFavLanguage], [DateOfLastProgramCompleted], [Lockout]) VALUES (13, N'Stewie', N'Griffin', N'Bufallo', N'IR', N'Java', N'C#', CAST(0x0000A5F900000000 AS DateTime), 0)
GO
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [City], [State], [FavLanguage], [LeastFavLanguage], [DateOfLastProgramCompleted], [Lockout]) VALUES (14, N'Johnson', N'Swanson', N'Buffalo', N'NY', N'C++', N'C#', CAST(0x0000A61800000000 AS DateTime), 0)
GO
INSERT [dbo].[UserAccount] ([ID], [UserName], [Password], [City], [State], [FavLanguage], [LeastFavLanguage], [DateOfLastProgramCompleted], [Lockout]) VALUES (15, N'Teeter', N'John', N'San Diego', N'CA', N'C++', N'C#', CAST(0x0000A62600000000 AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[UserAccount] OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__UserAcco__C9F284567DA6FF7F]    Script Date: 6/17/2016 5:47:54 PM ******/
ALTER TABLE [dbo].[UserAccount] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
GO
ALTER TABLE [dbo].[UserAccount] ADD  DEFAULT ((0)) FOR [Lockout]
GO
ALTER TABLE [dbo].[PastApplications]  WITH CHECK ADD  CONSTRAINT [PastApplications_ID_FK] FOREIGN KEY([UserAccountId])
REFERENCES [dbo].[UserAccount] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PastApplications] CHECK CONSTRAINT [PastApplications_ID_FK]
GO
