create or replace NONEDITIONABLE PROCEDURE KURUM_GERI_AL

(x1 IN NVARCHAR2 )  AS 
BEGIN
UPDATE kurum_faturalar� SET odend�_b�lg�s�='�denmedi',odend�g�_saat=null,odend�g�_tar�h=null WHERE saat=X1 ;
END;