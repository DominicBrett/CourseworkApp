CREATE TABLE [dbo].[ConferenceCallResearchers] (
    [ResearcherID]     INT NOT NULL,
    [ConferenceCallID] INT NOT NULL,
    CONSTRAINT [PK_dbo.ConferenceCallResearchers] PRIMARY KEY CLUSTERED ([ConferenceCallID], [ResearcherID]),
	CONSTRAINT fk_researcherid foreign key (ResearcherID) references [dbo].[Researchers] (ResearcherID),
	constraint fk_conferencecallid foreign key (ConferenceCallID) references [dbo].[ConferenceCalls] (ConferenceCallID)
);

