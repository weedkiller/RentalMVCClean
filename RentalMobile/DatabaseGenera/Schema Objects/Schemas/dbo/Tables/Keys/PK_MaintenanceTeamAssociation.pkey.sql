﻿ALTER TABLE [dbo].[MaintenanceTeamAssociation]
    ADD CONSTRAINT [PK_MaintenanceTeamAssociation] PRIMARY KEY CLUSTERED ([TeamAssociationID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
