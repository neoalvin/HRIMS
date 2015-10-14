use HRIMS
go
create view V_Typenum
as
select typename,COUNT(Room.typenum) as roomnum
from Room right outer join Type on(Room.typenum=Type.typenum)
group by Room.typenum,typename;