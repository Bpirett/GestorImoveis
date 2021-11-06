﻿CREATE PROCEDURE GI_SP_IncContratos


 @CODCONTR varchar(10)
,@SITCONTR varchar(3)
,@TIPOIMOVCONTR varchar(60)
,@NOMELOCASCONTR varchar(60)
,@NOMELOCATCONTR varchar(60)
,@DTENTRADACONTR datetime
,@QTAMESESCONTR int
,@DTSAIDACONTR datetime
,@DIAPAGCONTR int
,@VALORCONTR decimal
,@VLRIPTUCONTR decimal
,@DTCADCONTR datetime
,@CEPCONTR varchar(8)
,@ENDCONTR varchar(160)
,@NUMIMOVCONTR int
,@BAIRROCONTR varchar(60)
,@CIDADECONTR varchar(60)
,@UFCONTR char(2)
,@COMPLCONTR varchar(60)
,@COMPL2CONTR varchar(60)

AS

INSERT INTO CCONTRATOS
(
 CODCONTR 
,SITCONTR 
,TIPOIMOVCONTR 
,NOMELOCASCONTR 
,NOMELOCATCONTR 
,DTENTRADACONTR 
,QTAMESESCONTR 
,DTSAIDACONTR 
,DIAPAGCONTR 
,VALORCONTR 
,VLRIPTUCONTR 
,DTCADCONTR 
,CEPCONTR 
,ENDCONTR 
,NUMIMOVCONTR 
,BAIRROCONTR 
,CIDADECONTR 
,UFCONTR 
,COMPLCONTR 
,COMPL2CONTR 

)
Values
(
 @CODCONTR 
,@SITCONTR 
,@TIPOIMOVCONTR 
,@NOMELOCASCONTR 
,@NOMELOCATCONTR 
,@DTENTRADACONTR 
,@QTAMESESCONTR 
,@DTSAIDACONTR 
,@DIAPAGCONTR 
,@VALORCONTR 
,@VLRIPTUCONTR 
,@DTCADCONTR 
,@CEPCONTR 
,@ENDCONTR 
,@NUMIMOVCONTR 
,@BAIRROCONTR 
,@CIDADECONTR 
,@UFCONTR 
,@COMPLCONTR 
,@COMPL2CONTR 
)
