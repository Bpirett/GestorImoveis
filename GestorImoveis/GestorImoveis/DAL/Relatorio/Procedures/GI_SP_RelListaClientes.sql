﻿CREATE PROCEDURE GI_SP_RelListaClientes

@FILTRO VARCHAR(100),
@VALOR  VARCHAR(100) 

AS

IF(@FILTRO = 'Codigo')
BEGIN
 SELECT 
  CODCLI
      ,CPFCLI
      ,NOMECLI
      ,TELEFCLI
      ,CELCLI
      ,EMAILCLI
      ,TIPOCLI
      ,DATACADCLI
      , CASE ATIVOCLI WHEN 'A' THEN 'ATIVO'
	  WHEN 'I' THEN 'INATIVO' END as ATIVOCLI
      ,CEPCLI
      ,ENDCLI
      ,NUMIMOVCLI
      ,BAIRROCLI
      ,CIDADECLI
      ,UFCLI
      ,COMPLCLI
      ,COMPL2CLI
      ,DTULTALTCLI
 FROM CCLIENTES
 WHERE CODCLI = @VALOR
END
ELSE IF(@FILTRO = 'Tipo Cliente')
BEGIN
 SELECT 
  CODCLI
      ,CPFCLI
      ,NOMECLI
      ,TELEFCLI
      ,CELCLI
      ,EMAILCLI
      ,TIPOCLI
      ,DATACADCLI
      ,CASE ATIVOCLI WHEN 'A' THEN 'ATIVO'
	  WHEN 'I' THEN 'INATIVO' END as ATIVOCLI
      ,CEPCLI
      ,ENDCLI
      ,NUMIMOVCLI
      ,BAIRROCLI
      ,CIDADECLI
      ,UFCLI
      ,COMPLCLI
      ,COMPL2CLI
      ,DTULTALTCLI
 FROM CCLIENTES
 WHERE TIPOCLI = @VALOR
 END
 ELSE IF(@FILTRO = 'Nome')
BEGIN
 SELECT 
  CODCLI
      ,CPFCLI
      ,NOMECLI
      ,TELEFCLI
      ,CELCLI
      ,EMAILCLI
      ,TIPOCLI
      ,DATACADCLI
      ,CASE ATIVOCLI WHEN 'A' THEN 'ATIVO'
	  WHEN 'I' THEN 'INATIVO' END as ATIVOCLI
      ,CEPCLI
      ,ENDCLI
      ,NUMIMOVCLI
      ,BAIRROCLI
      ,CIDADECLI
      ,UFCLI
      ,COMPLCLI
      ,COMPL2CLI
      ,DTULTALTCLI
 FROM CCLIENTES
 WHERE NOMECLI = @VALOR
 END
  ELSE IF(@FILTRO = 'Tipo de imovel')
BEGIN
 SELECT 
  CODCLI
      ,CPFCLI
      ,NOMECLI
      ,TELEFCLI
      ,CELCLI
      ,EMAILCLI
      ,TIPOCLI
      ,DATACADCLI
      ,CASE ATIVOCLI WHEN 'A' THEN 'ATIVO'
	  WHEN 'I' THEN 'INATIVO' END as ATIVOCLI
      ,CEPCLI
      ,ENDCLI
      ,NUMIMOVCLI
      ,BAIRROCLI
      ,CIDADECLI
      ,UFCLI
      ,COMPLCLI
      ,COMPL2CLI
      ,DTULTALTCLI
 FROM CCLIENTES
 WHERE TIPOCLI = @VALOR
 END
   ELSE IF(@FILTRO = 'CPF')
BEGIN
 SELECT 
  CODCLI
      ,CPFCLI
      ,NOMECLI
      ,TELEFCLI
      ,CELCLI
      ,EMAILCLI
      ,TIPOCLI
      ,DATACADCLI
      ,CASE ATIVOCLI WHEN 'A' THEN 'ATIVO'
	  WHEN 'I' THEN 'INATIVO' END as ATIVOCLI
      ,CEPCLI
      ,ENDCLI
      ,NUMIMOVCLI
      ,BAIRROCLI
      ,CIDADECLI
      ,UFCLI
      ,COMPLCLI
      ,COMPL2CLI
      ,DTULTALTCLI
 FROM CCLIENTES
 WHERE CPFCLI = @VALOR
 END
 ELSE
BEGIN
 SELECT 
  CODCLI
      ,CPFCLI
      ,NOMECLI
      ,TELEFCLI
      ,CELCLI
      ,EMAILCLI
      ,TIPOCLI
      ,DATACADCLI
      ,CASE ATIVOCLI WHEN 'A' THEN 'ATIVO'
	  WHEN 'I' THEN 'INATIVO' END as ATIVOCLI
      ,CEPCLI
      ,ENDCLI
      ,NUMIMOVCLI
      ,BAIRROCLI
      ,CIDADECLI
      ,UFCLI
      ,COMPLCLI
      ,COMPL2CLI
      ,DTULTALTCLI
 FROM CCLIENTES
 END
GO


