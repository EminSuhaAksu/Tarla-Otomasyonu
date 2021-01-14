create or replace NONEDITIONABLE PROCEDURE KURUM_GERI_AL

(x1 IN NVARCHAR2 )  AS 
BEGIN
UPDATE kurum_faturalarý SET odendý_býlgýsý='Ödenmedi',odendýgý_saat=null,odendýgý_tarýh=null WHERE saat=X1 ;
END;