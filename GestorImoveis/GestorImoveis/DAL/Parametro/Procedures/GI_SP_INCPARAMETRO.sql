﻿
CREATE PROCEDURE GI_SP_INCPARAMETRO

 @TPSIST  VARCHAR(2)
,@TPCATEG VARCHAR(60)
,@TPPARAM  VARCHAR(10)
,@TPCONTEUDO VARCHAR(MAX)
,@TPDESC VARCHAR(200)
,@TPDTALT DATETIME
,@TPUSU VARCHAR(60)

AS

INSERT INTO TPARAM 
(
 TPSIST  
,TPCATEG 
,TPPARAM  
,TPCONTEUDO 
,TPDESC 
,TPDTALT 
,TPUSU 
)
VALUES
(
 @TPSIST  
,@TPCATEG 
,@TPPARAM  
,@TPCONTEUDO 
,@TPDESC 
,@TPDTALT 
,@TPUSU 

)