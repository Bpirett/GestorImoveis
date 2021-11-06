﻿CREATE PROCEDURE GI_SP_CountClientes
@TIPOCLIENTE varchar(60)  = NULL
AS
IF(@TIPOCLIENTE = 'Locatario')
BEGIN 
	SELECT COUNT(CODCLI) as QUANTIDADE  FROM CCLIENTES
	WHERE TIPOCLI = 'Locatario'
END 
ELSE IF( @TIPOCLIENTE = 'Locador')
BEGIN 
	SELECT COUNT(CODCLI) as QUANTIDADE  FROM CCLIENTES
	WHERE TIPOCLI = 'Locador'
END 
ELSE
BEGIN 
	SELECT COUNT(CODCLI) as QUANTIDADE  FROM CCLIENTES
END 
GO
