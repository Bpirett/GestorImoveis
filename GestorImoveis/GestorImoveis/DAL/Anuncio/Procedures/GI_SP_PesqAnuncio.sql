﻿
CREATE PROCEDURE GI_SP_PesqAnuncio

@FILTRO VARCHAR(100) = null,
@VALOR  VARCHAR(100) = null

AS

IF(@FILTRO = 'Codigo')
BEGIN
 SELECT 
CODANUNC,
TIPOIMOVANUNC ,
NOMEPROPANUNC ,
VALORANUNC ,
NEGANUNC ,
REGANUNC, 
DTULTALTANUNC ,
CIDADEANUNC ,
BAIRROANUNC ,
ATIVOANUNC 
 FROM CANUNCIOS
 WHERE CODANUNC = @VALOR
END
ELSE IF(@FILTRO = 'Prop')
BEGIN
 SELECT 
CODANUNC,
TIPOIMOVANUNC ,
NOMEPROPANUNC ,
VALORANUNC ,
NEGANUNC ,
REGANUNC, 
DTULTALTANUNC ,
CIDADEANUNC ,
BAIRROANUNC ,
ATIVOANUNC 
 FROM CANUNCIOS
 WHERE NOMEPROPANUNC = @VALOR
 END
ELSE IF(@FILTRO = 'Região')
BEGIN
 SELECT 
CODANUNC,
TIPOIMOVANUNC ,
NOMEPROPANUNC ,
VALORANUNC ,
NEGANUNC ,
REGANUNC, 
DTULTALTANUNC ,
CIDADEANUNC ,
BAIRROANUNC ,
ATIVOANUNC 
 FROM CANUNCIOS
 WHERE REGANUNC = @VALOR
 END
ELSE
BEGIN
 SELECT 
CODANUNC,
TIPOIMOVANUNC ,
NOMEPROPANUNC ,
VALORANUNC ,
NEGANUNC ,
REGANUNC, 
DTULTALTANUNC ,
CIDADEANUNC ,
BAIRROANUNC ,
ATIVOANUNC 
 FROM CANUNCIOS
 END
GO

