GO
/****** Object:  Table [dbo].[Lop]    Script Date: 12/05/2017 20:01:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Lop]') AND type in (N'U'))
BEGIN
CREATE TABLE [Lop](
	[Malop] [nchar](10) NOT NULL,
	[Tenlop] [nvarchar](50) NOT NULL,
	[Sosv] [int] NOT NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[Malop] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [Lop] ([Malop], [Tenlop], [Sosv]) VALUES (N'022       ', N'huy', 9995)
INSERT [Lop] ([Malop], [Tenlop], [Sosv]) VALUES (N'hhh       ', N'hahaha', 29)
