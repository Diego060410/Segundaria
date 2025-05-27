-- ========================================
-- Insertar datos en tabla Courses
-- ========================================
INSERT INTO [dbo].[Courses] (Id, Name, Credits, GradeLevel, Active) VALUES
(NEWID(), 'Matemáticas', 5, 'Primero', 1),
(NEWID(), 'Comunicación', 4, 'Primero', 1),
(NEWID(), 'Ciencias', 4, 'Segundo', 1),
(NEWID(), 'Historia', 3, 'Segundo', 1);

-- ========================================
-- Insertar datos en tabla Sections
-- ========================================
DECLARE @SectionId1 UNIQUEIDENTIFIER = NEWID();
DECLARE @SectionId2 UNIQUEIDENTIFIER = NEWID();

INSERT INTO [dbo].[Sections] (Id, Name, GradeId) VALUES
(@SectionId1, 'A1', NEWID()),
(@SectionId2, 'B1', NEWID());

-- ========================================
-- Insertar datos en tabla Teachers
-- ========================================
INSERT INTO [dbo].[Teachers] (Id, Names, LastName, Specialty, Phone, Email) VALUES
(NEWID(), 'Luis', 'Gonzales', 'Matemáticas', '987654321', 'luis@colegio.edu'),
(NEWID(), 'Ana', 'Pérez', 'Ciencias', '986543210', 'ana@colegio.edu');

-- ========================================
-- Insertar estudiantes, padres, matrícula y grados
-- ========================================
DECLARE @PeriodId UNIQUEIDENTIFIER = NEWID();
DECLARE @CourseId UNIQUEIDENTIFIER = (SELECT TOP 1 Id FROM [dbo].[Courses]); -- Usa uno de los cursos ya insertados

DECLARE @i INT = 1;

WHILE @i <= 10
BEGIN
    DECLARE @StudentId UNIQUEIDENTIFIER = NEWID();
    DECLARE @ParentId UNIQUEIDENTIFIER = NEWID();
    DECLARE @TuitionId UNIQUEIDENTIFIER = NEWID();
    DECLARE @DegreeId UNIQUEIDENTIFIER = NEWID();

    -- Estudiante
    INSERT INTO [dbo].[Students] (Id, DNI, Names, LastName, BirthDate, Gender, Address, Phone, BloodLevel, State)
    VALUES (
        @StudentId,
        CONCAT('7400000', @i),
        CONCAT('Estudiante', @i),
        CONCAT('Apellido', @i),
        DATEADD(YEAR, -13, GETDATE()),
        CASE WHEN @i % 2 = 0 THEN 'Femenino' ELSE 'Masculino' END,
        CONCAT('Calle Falsa ', @i),
        '98765432' + CAST(@i AS NVARCHAR),
        'O+',
        'Activo'
    );

    -- Padre
    INSERT INTO [dbo].[Parents] (Id, Names, LastName, Phone, Address, Relationship, StudentId)
    VALUES (
        @ParentId,
        CONCAT('Padre', @i),
        CONCAT('ApellidoPadre', @i),
        '91234567' + CAST(@i AS NVARCHAR),
        CONCAT('Av. Padres ', @i),
        'Padre',
        @StudentId
    );

    -- Matrícula
    INSERT INTO [dbo].[Tuitions] (Id, StudentId, SectionId, PeriodId, DateTuition, State)
    VALUES (
        @TuitionId,
        @StudentId,
        CASE WHEN @i <= 5 THEN @SectionId1 ELSE @SectionId2 END,
        @PeriodId,
        GETDATE(),
        'Matriculado'
    );

    -- Grado/Nota final
    INSERT INTO [dbo].[Degrees] (Id, StudentId, CourseId, PeriodId, FinalNote, State)
    VALUES (
        @DegreeId,
        @StudentId,
        @CourseId,
        @PeriodId,
        12 + (@i % 6),
        CASE WHEN @i % 3 = 0 THEN 'Desaprobado' ELSE 'Aprobado' END
    );

    SET @i += 1;
END;

-- ========================================
-- Insertar usuarios
-- ========================================
INSERT INTO [dbo].[Users] (UserId, Name, Email, Password, Role) VALUES
(NEWID(), 'admin', 'admin@colegio.edu', 'clave123', 'Administrador'),
(NEWID(), 'docente1', 'doc1@colegio.edu', 'clave123', 'Docente'),
(NEWID(), 'secretaria', 'sec@colegio.edu', 'clave123', 'Secretaría');
