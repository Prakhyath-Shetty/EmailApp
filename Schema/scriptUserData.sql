USE [EMailApp.Database]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [CreatedDate]) VALUES (1, N'prakhyath', N'prakhyath@gmail.com', N'BtC4uFjVRmbnyUJZgN2sbY6YNrqK2xZyMAipT+fTkB8=', CAST(N'2021-01-12T12:03:27.0843408' AS DateTime2))
INSERT [dbo].[User] ([Id], [Name], [Email], [Password], [CreatedDate]) VALUES (4, N'prak', N'prak@mail.com', N'BtC4uFjVRmbnyUJZgN2sbY6YNrqK2xZyMAipT+fTkB8=', CAST(N'2021-01-30T13:11:25.9071985' AS DateTime2))
SET IDENTITY_INSERT [dbo].[User] OFF
GO
