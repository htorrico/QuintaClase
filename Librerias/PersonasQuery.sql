
CREATE TABLE [dbo].[Personas](
	[IdPerson] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[FechaNacimiento] [datetime] NULL,
	[FechaIngreso] [datetime] NULL
) ON [PRIMARY]
GO


CREATE PROC USP_BuscarPersonas  
@Nombres VARCHAR(50)='',  
@Apellidos VARCHAR(50)=''  
AS  
BEGIN  
SELECT  * FROM PERSONAS  
WHERE   
(NOMBRES LIKE '%'+@Nombres+'%' OR @Nombres='')  
AND (Apellidos LIKE '%'+@Apellidos+'%' OR @Apellidos='')  
  
END  

CREATE PROC USP_InsertarPersonas  
@Nombres VARCHAR(50),  
@Apellidos VARCHAR(50),  
@FechaNacimiento DATETIME,  
@FechaIngreso DATETIME  
AS  
BEGIN  
INSERT INTO Personas VALUES   
(@Nombres,@Apellidos, @FechaNacimiento,@FechaIngreso)  
END