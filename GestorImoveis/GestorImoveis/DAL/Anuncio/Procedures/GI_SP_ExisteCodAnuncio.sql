﻿CREATE PROCEDURE GI_SP_ExisteCodAnuncio

@CODANUNC VARCHAR(10)

AS
BEGIN
	SELECT * FROM CANUNCIOS
	WHERE CODANUNC = @CODANUNC
END
GO