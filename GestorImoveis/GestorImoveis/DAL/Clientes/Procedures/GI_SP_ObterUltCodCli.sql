﻿CREATE PROCEDURE [dbo].[GI_SP_ObterUltCodCli]

AS
BEGIN
	SELECT CODCLI FROM CCLIENTES
	ORDER BY DATACADCLI DESC
END
GO

