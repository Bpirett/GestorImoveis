﻿CREATE PROCEDURE GI_SP_IncCliente


@CODCLI varchar(14),
@CPFCLI varchar(14) ,
@NOMECLI varchar(60) ,
@TELEFCLI varchar(11) ,
@CELCLI varchar(12) ,
@EMAILCLI varchar(60) ,
@TIPOCLI varchar(30) ,
@DATACADCLI datetime ,
@ATIVOCLI char(1) ,
@CEPCLI varchar(8) ,
@ENDCLI varchar(160) ,
@NUMIMOVCLI int ,
@BAIRROCLI varchar(60) ,
@CIDADECLI varchar(60) ,
@UFCLI char(1) ,
@COMPLCLI varchar(60) ,
@COMPL2CLI varchar(60) 

AS

INSERT INTO CCLIENTES
(
CODCLI,
CPFCLI ,
NOMECLI ,
TELEFCLI ,
CELCLI ,
EMAILCLI, 
TIPOCLI ,
DATACADCLI, 
ATIVOCLI ,
CEPCLI ,
ENDCLI ,
NUMIMOVCLI ,
BAIRROCLI ,
CIDADECLI ,
UFCLI ,
COMPLCLI, 
COMPL2CLI
)
Values
(
@CODCLI,
@CPFCLI ,
@NOMECLI ,
@TELEFCLI ,
@CELCLI ,
@EMAILCLI, 
@TIPOCLI ,
@DATACADCLI, 
@ATIVOCLI ,
@CEPCLI ,
@ENDCLI ,
@NUMIMOVCLI ,
@BAIRROCLI ,
@CIDADECLI ,
@UFCLI ,
@COMPLCLI, 
@COMPL2CLI
)
