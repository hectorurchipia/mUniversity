use monsterUniversity

--inserta Carreras
INSERT INTO Carreras (CodCarrera, Nombre ) VALUES ('lSis', 'Lic.Sistemas');
INSERT INTO Carreras (CodCarrera, Nombre ) VALUES ('lPsi', 'Lic.Psicologia');

--inserta  mMaterias de sistemas
INSERT INTO Materias (IdMateria, CodCarrera, Nombre,IdSemestre, IdCorrelativa1, IdCorrelativa2 ) VALUES (1, 'lSis', 'algebra I',1, 0 , 0);
INSERT INTO Materias (IdMateria, CodCarrera, Nombre,IdSemestre, IdCorrelativa1, IdCorrelativa2 ) VALUES (2, 'lSis', 'algebra II',2, 1 , 10);
INSERT INTO Materias (IdMateria, CodCarrera, Nombre,IdSemestre, IdCorrelativa1, IdCorrelativa2 ) VALUES (3, 'lSis', 'algebra III',3, 2 , 11);


INSERT INTO Materias (IdMateria, CodCarrera, Nombre,IdSemestre, IdCorrelativa1, IdCorrelativa2 ) VALUES (10, 'lSis', 'Logica I',1, 0 , 0);
INSERT INTO Materias (IdMateria, CodCarrera, Nombre,IdSemestre, IdCorrelativa1, IdCorrelativa2 ) VALUES (11, 'lSis', 'Logica II',2, 10 , 0);


-- inserta alumnos  Roles  1=alumno 2=profe  3=adm
INSERT INTO Personas (IdPersona, Nombre, Rol, CodCarrera ) VALUES (18053220, 'Hector', 1, 'lSis' );
INSERT INTO Personas (IdPersona, Nombre, Rol, CodCarrera ) VALUES (22201616, 'Adriana', 1, 'lSis' );
INSERT INTO Personas (IdPersona, Nombre, Rol, CodCarrera ) VALUES (100, 'Freud', 1, 'lpsi' );
INSERT INTO Personas (IdPersona, Nombre, Rol, CodCarrera ) VALUES (101, 'Frankl Viktor', 1, 'lpsi' );










