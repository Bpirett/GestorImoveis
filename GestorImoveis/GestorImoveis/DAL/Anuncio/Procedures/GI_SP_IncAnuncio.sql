﻿CREATE PROCEDURE GI_SP_IncAnuncio

     @CODANUNC varchar(6)  
	,@ENDANUNC varchar(160) 
	,@TIPOIMOVANUNC varchar(60) 
	,@NOMEPROPANUNC varchar(100) 
	,@VALORANUNC decimal(18) 
	,@VLRIPTUANUNC decimal(18) 
	,@DTCADANUNC date 
	,@NEGANUNC varchar(60) 
	,@REGANUNC varchar(60) 
	,@DORMANUNC int 
	,@SUITEANUNC int 
	,@VAGASANUNC int 
	,@AREAANUNC int 
	,@CIDADEANUNC varchar(60) 
	,@BAIRROANUNC varchar(60) 
	,@OBSANUNC varchar(180) 
	,@PERMUTAANUNC bit 
	,@CHURRASQUEIRANUNC bit 
	,@PISCINAANUNC bit 
	,@BRINQUEDOTECAANUNC bit 
	,@PLAYGROUDANUNC bit 
	,@QUADRAANUNC bit 
	,@SGINASTICAANUNC bit 
	,@SFESTAANUNC bit 
	,@SJOGOSNUNC bit 
	,@ATIVOANUNC char(1) 

AS

INSERT INTO CANUNCIOS
(
     CODANUNC
	,ENDANUNC
	,TIPOIMOVANUNC  
	,NOMEPROPANUNC 
	,VALORANUNC 
	,VLRIPTUANUNC 
	,DTCADANUNC  
	,NEGANUNC 
	,REGANUNC 
	,DORMANUNC  
	,SUITEANUNC  
	,VAGASANUNC 
	,AREAANUNC  
	,CIDADEANUNC
	,BAIRROANUNC 
	,OBSANUNC
	,PERMUTAANUNC  
	,CHURRASQUEIRANUNC 
	,PISCINAANUNC  
	,BRINQUEDOTECAANUNC 
	,PLAYGROUDANUNC 
	,QUADRAANUNC 
	,SGINASTICAANUNC
	,SFESTAANUNC 
	,SJOGOSNUNC  
	,ATIVOANUNC 
)
Values
(
     @CODANUNC
	,@ENDANUNC
	,@TIPOIMOVANUNC  
	,@NOMEPROPANUNC 
	,@VALORANUNC 
	,@VLRIPTUANUNC 
	,@DTCADANUNC  
	,@NEGANUNC 
	,@REGANUNC 
	,@DORMANUNC  
	,@SUITEANUNC  
	,@VAGASANUNC 
	,@AREAANUNC  
	,@CIDADEANUNC
	,@BAIRROANUNC 
	,@OBSANUNC
	,@PERMUTAANUNC  
	,@CHURRASQUEIRANUNC 
	,@PISCINAANUNC  
	,@BRINQUEDOTECAANUNC
	,@PLAYGROUDANUNC 
	,@QUADRAANUNC 
	,@SGINASTICAANUNC
	,@SFESTAANUNC 
	,@SJOGOSNUNC  
	,@ATIVOANUNC 
)
