﻿ALTER TABLE [dbo].[UnitType]
    ADD CONSTRAINT [PK_UnitType] PRIMARY KEY CLUSTERED ([TypeID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
