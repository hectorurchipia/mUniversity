use monsterUniversity

CREATE TABLE [Carreras] (
  [CodCarrera] varchar(4) PRIMARY KEY,
  [Nombre] varchar(15)
)
GO

CREATE TABLE [Materias] (
  [IdMateria] int PRIMARY KEY,
  [CodCarrera] varchar(4),
  [Nombre] varchar(15),
  [IdSemestre] int DEFAULT (0),
  [IdCorrelativa1] int,
  [IdCorrelativa2] int
)
GO

CREATE TABLE [Personas] (
  [IdPersona] int PRIMARY KEY,
  [Nombre] varchar(20),
  [Role] int,
  [CodCarrera] varchar(4)
)
GO

CREATE TABLE [Historial] (
  [IdPersona] int,
  [IdMateria] int,
  [FechaExamen] date,
  [Nota] float
)
GO

CREATE TABLE [SemestreActual] (
  [SemestreActual] varchar(5)
)
GO

ALTER TABLE [Materias] ADD FOREIGN KEY ([CodCarrera]) REFERENCES [Carreras] ([CodCarrera])
GO

ALTER TABLE [Personas] ADD FOREIGN KEY ([CodCarrera]) REFERENCES [Carreras] ([CodCarrera])
GO

ALTER TABLE [Historial] ADD FOREIGN KEY ([IdPersona]) REFERENCES [Personas] ([IdPersona])
GO

ALTER TABLE [historial] ADD FOREIGN KEY ([Idmateria]) REFERENCES [materias] ([Idmateria])
GO
