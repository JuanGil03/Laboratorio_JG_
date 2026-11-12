create database db_laboratorio
go
use db_laboratorio
go


create table Habitaciones(
                    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
                [NumPersonas] int not null,
            [Ubicacion] NVARCHAR(20) NOT NULL,
            [TipoHabitacion] NVARCHAR(20) NOT NULL,
             [PrecioNoche] decimal not null
        )
