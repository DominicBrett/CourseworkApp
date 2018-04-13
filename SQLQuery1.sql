CREATE TABLE [dbo].[Reports]
(
	[ReportID] INT NOT NULL PRIMARY KEY, 
    [ReportTitle] VARCHAR(50) NOT NULL, 
    [ReportAbstract] VARCHAR(MAX) NOT NULL, 
    [ReportLink] VARCHAR(MAX) NOT NULL
)

