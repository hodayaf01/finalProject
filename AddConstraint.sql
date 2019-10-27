alter table [dbo].[MedicinesToChild]
	add CONSTRAINT fk_KingOfDosage FOREIGN KEY ([Dosage])
	REFERENCES [dbo].[KingOfDosage]([kindOfDosageId])

alter table [dbo].[MedicinesToChild]
	add CONSTRAINT fk_medicineId FOREIGN KEY ([medicineId])
	REFERENCES [dbo].[Medicines] ([medicineId])

	alter table [dbo].[MedicinesToChild]
	add CONSTRAINT fk_childId FOREIGN KEY ([childId])
	REFERENCES [dbo].[Users] ([Id])

	alter table [dbo].[Users]
	add CONSTRAINT fk_userHMO FOREIGN KEY ([userHMO])
	REFERENCES [dbo].[HMO] ([IdHMO])

	alter table [dbo].[guardiansToUser]
	add CONSTRAINT fk_userId FOREIGN KEY ([userId])
	REFERENCES [dbo].[Users] ([Id])

	alter table [dbo].[guardiansToUser]
	add CONSTRAINT fk_guardianId FOREIGN KEY ([guardianId])
	REFERENCES [dbo].[Guardian] ([Id])

ALTER TABLE [dbo].[guardiansToUser]
	DROP CONSTRAINT fk_