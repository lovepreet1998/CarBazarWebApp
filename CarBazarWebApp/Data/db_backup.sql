SET IDENTITY_INSERT [dbo].[Companies] ON 
GO
INSERT [dbo].[Companies] ([Id], [CompanyName]) VALUES (1, N'Toyota')
GO
INSERT [dbo].[Companies] ([Id], [CompanyName]) VALUES (2, N'Mazda')
GO
INSERT [dbo].[Companies] ([Id], [CompanyName]) VALUES (3, N'Holden')
GO
INSERT [dbo].[Companies] ([Id], [CompanyName]) VALUES (4, N'Mitsubishi')
GO
INSERT [dbo].[Companies] ([Id], [CompanyName]) VALUES (5, N'Hyundai')
GO
INSERT [dbo].[Companies] ([Id], [CompanyName]) VALUES (6, N'Kia')
GO
INSERT [dbo].[Companies] ([Id], [CompanyName]) VALUES (7, N'Suzuki')
GO
INSERT [dbo].[Companies] ([Id], [CompanyName]) VALUES (8, N'Ford')
GO
SET IDENTITY_INSERT [dbo].[Companies] OFF
GO
SET IDENTITY_INSERT [dbo].[Models] ON 
GO
INSERT [dbo].[Models] ([Id], [ModelName], [CompanyID]) VALUES (1, N'Camry', 1)
GO
INSERT [dbo].[Models] ([Id], [ModelName], [CompanyID]) VALUES (2, N'Yaris', 1)
GO
INSERT [dbo].[Models] ([Id], [ModelName], [CompanyID]) VALUES (3, N'Cruiser', 1)
GO
INSERT [dbo].[Models] ([Id], [ModelName], [CompanyID]) VALUES (4, N'MAZDA2 ', 2)
GO
INSERT [dbo].[Models] ([Id], [ModelName], [CompanyID]) VALUES (5, N'MAZDA4', 1)
GO
INSERT [dbo].[Models] ([Id], [ModelName], [CompanyID]) VALUES (6, N'Espresso', 7)
GO
SET IDENTITY_INSERT [dbo].[Models] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 
GO
INSERT [dbo].[Cars] ([Id], [CarNo], [ModelID], [ModelYear], [OwnerName], [ContactNo]) VALUES (1, N'RG2380', 1, 2021, N'LIam Shen', N'0508 558 855')
GO
INSERT [dbo].[Cars] ([Id], [CarNo], [ModelID], [ModelYear], [OwnerName], [ContactNo]) VALUES (2, N'LSL01', 3, 2011, N'Emma Watson', N'0508 558 855')
GO
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Reviews] ON 
GO
INSERT [dbo].[Reviews] ([Id], [ReviewText], [Rating], [ModelID]) VALUES (1, N'Toyota Camry is a truly fantastic Car. I''ve been using it since past 2 months. Pros: 1. Great Mileage of around 24km/liter. 2. Hybrid Car - It runs on a petrol engine, on battery and even charges the battery from the tyres when not accelerating. 3. When it runs on battery, it doesn''t make any noise, when on engine there is engine noise but is barely heard. 4. Ride quality is fantastic, it feels like you are floating on a cloud. 5. The exterior and interior looks are great and the seats are very comfortable. 6. It has a remote control to unlock doors and push-button starts to turn on a car so no more keys. Cons: - none Toyota Camry is beautiful to look at and even better to drive. It is expensive but the money is worth it. Better than any other car I''ve seen.', 4, 1)
GO
INSERT [dbo].[Reviews] ([Id], [ReviewText], [Rating], [ModelID]) VALUES (2, N'A good budget car, overall good package under this budget, a better option than Wagonr and Celerio under same engine spec. Good performer and spacious car. 1000cc engine is the best part of it. Almost everything has this car in it because it''s a budget car. There could be rear power windows and speakers, but as a budget car, I have no issue. Safety is a concern. Love u S-Presso', 4, 6)
GO
SET IDENTITY_INSERT [dbo].[Reviews] OFF
GO
