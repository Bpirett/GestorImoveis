﻿CREATE PROCEDURE GI_SP_ExisteCpfCli

@CPFCLI VARCHAR(14)

AS
BEGIN
	SELECT * FROM CCLIENTES
	WHERE CPFCLI = @CPFCLI
END
GO

