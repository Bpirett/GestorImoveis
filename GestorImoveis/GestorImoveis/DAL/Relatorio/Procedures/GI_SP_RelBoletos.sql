﻿CREATE PROCEDURE GI_SP_RelBoletos

@CODCONTRATO VARCHAR(10)

AS

BEGIN
 SELECT 
  CODBOL
 ,NUMBOL
 ,DTINIBOL
 ,DTFIMBOL
 ,DTVCTBOL
 ,PAGBOL
 FROM CBOLETOS
 WHERE CODCONTRBOL = @CODCONTRATO
END