CREATE PROCEDURE [dbo].[GI_SP_ObterUltCodContrato]

AS
BEGIN
	SELECT CODCONTR FROM CCONTRATOS
	ORDER BY DTCADCONTR DESC
END
GO