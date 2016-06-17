CREATE TABLE [dbo].[PastApplications](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CompletionDate] [datetime] NULL,
	[LanguageUsed] [nvarchar](50) NULL,
	[ApplicationCompleted] [bit] NULL,
	[UserAccountId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 6/17/2016 4:33:06 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[PastApplications] ON 

GO
INSERT [dbo].[PastApplications] ([ID], [CompletionDate], [LanguageUsed], [ApplicationCompleted], [UserAccountId]) VALUES (7, CAST(0x0000A61A00000000 AS DateTime), N'C#', 1, 2)
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
SET IDENTITY_INSERT [dbo].[UserAccount] OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__UserAcco__C9F28456D7862B05]    Script Date: 6/17/2016 4:33:06 PM ******/
ALTER TABLE [dbo].[UserAccount] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserAccount] ADD  DEFAULT ((0)) FOR [Lockout]
GO
ALTER TABLE [dbo].[PastApplications]  WITH CHECK ADD  CONSTRAINT [PastApplications_ID_FK] FOREIGN KEY([UserAccountId])
REFERENCES [dbo].[UserAccount] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PastApplications] CHECK CONSTRAINT [PastApplications_ID_FK]
GO
