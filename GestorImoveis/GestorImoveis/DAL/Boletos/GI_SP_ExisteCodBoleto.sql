﻿CREATE PROCEDURE GI_SP_ExisteCodBoleto

@CODBOL VARCHAR(10)

AS
BEGIN
	SELECT * FROM CBOLETOS
	WHERE CODBOL = @CODBOL
END
GO