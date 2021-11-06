﻿ CREATE PROCEDURE [dbo].[GI_SP_ObterLocatario]
 
 @CODCLI varchar(14)

AS

IF(ISNULL(@CODCLI, '') != '')
BEGIN
 SELECT 
 NOMECLI
 FROM CCLIENTES
 WHERE CODCLI = @CODCLI AND TIPOCLI = 'Locatario'
END
ELSE
BEGIN
 SELECT 
 NOMECLI
 FROM CCLIENTES
 WHERE TIPOCLI = 'Locatario'
END
GO

