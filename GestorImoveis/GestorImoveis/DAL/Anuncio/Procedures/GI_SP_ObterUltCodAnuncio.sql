﻿CREATE PROCEDURE GI_SP_ObterUltCodAnuncio

@NEG Varchar(60)

AS
BEGIN
	SELECT CODANUNC FROM CANUNCIOS
	WHERE NEGANUNC = @NEG
	ORDER BY DTCADANUNC DESC
END
GO
