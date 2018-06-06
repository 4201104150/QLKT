create view vQuanLyNQL
as
select nt.IDNGUOIQUANLY, nt.HOTEN,nt.CMND,nt.NGAYSINH,nt.SDT,pt.TENKHUTRO
from NGUOIQUANLY nt,KHUTRO pt
where nt.IDKHUTRO=pt.IDKHUTRO
