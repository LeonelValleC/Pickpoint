create database vaygersndb

use vaygersndb

create table tb_Client(id_client int primary key identity(1,1), client varchar(255))

create table tb_PN(id_pn int primary key identity(1,1), pn varchar(255), rev varchar(50))

create table tb_WO(id_wo int primary key identity(1,1), wo varchar(255) unique, qty int, qtyReq int, totalUsed int, dateReg date, id_pn int, id_client int, id_location int, 
foreign key (id_pn) references tb_PN(id_pn),
foreign key (id_client) references tb_Client(id_client),
foreign key (id_location) references tb_location(id_location))

create table tb_Consecutive(id_cons int primary key identity(1,1), type varchar(10), consecutive int)

create table tb_Inprocess(id_inprocess int primary key identity(1,1), SerialNumber varchar(255) unique, RegSN datetime, id_wo int, id_user int,
foreign key (id_wo) references tb_WO(id_wo),
foreign key (id_user) references tb_User(id_user))

create table tb_location(id_location int primary key identity(1,1), location varchar(255), id int)

create table tb_User(id_user int primary key identity(1,1), name varchar(100), nemploy int, users varchar(100), password varchar(100), id_level int,
foreign key (id_level) references tb_level(id_level))

create table tb_level(id_level int primary key identity(1,1), level varchar(50))
select * from tb_Consecutive
select left(pn,2) from tb_PN where id_pn  = 1
select * from tb_WO
select pn from tb_WO wo join tb_PN pn on wo.id_pn = pn.id_pn where id_wo = 2
select * from tb_Inprocess
select count(*) from tb_Inprocess where Printed is null and id_wo = 2

select top 1 id_inprocess, SerialNumber from tb_Inprocess where Printed is null and id_wo = 2 ORDER BY id_inprocess ASC
update tb_Inprocess set SerialNumber = '' where id_inprocess = ''

select * from tb_Inprocess
select top 1 SerialNumber from tb_Inprocess where Printed is null and id_wo = 2 ORDER BY id_inprocess ASC

select SerialNumber, wo.wo, RegSN from tb_Inprocess inp join tb_WO wo on inp.id_wo = wo.id_wo

select REPLACE(STR(consecutive,6),' ', '0') from tb_Consecutive where id_cons = 2

select SerialNumber, wo.wo, RegSN, replace(Printed,1,'Printed') from tb_Inprocess inp join tb_WO wo on inp.id_wo = wo.id_wo where wo.id_wo = 2


select case len(consecutive)
			when 1 then REPLACE(STR(consecutive,6),' ', '0') 
			when 2 then REPLACE(STR(consecutive,6),' ', '0') 
			when 3 then REPLACE(STR(consecutive,6),' ', '0') 
			when 4 then REPLACE(STR(consecutive,6),' ', '0') 
			when 5 then REPLACE(STR(consecutive,6),' ', '0') 
			when 6 then REPLACE(STR(consecutive,6),' ', '0') 
			end as consecutive
			from tb_Consecutive where nom = (select left(pn,2) from tb_PN where id_pn  = 1)



GO
create proc [dbo].[sp_SnLabels](
@WO varchar(255),
@top int,
@format varchar(100),
@id_user int
)
as begin
declare @count int
declare @letter varchar(5)
declare @id_pn int
declare @location int
declare @SN varchar(255)
declare @Consecutive int 
declare @id_wo int

set @id_wo = (select id_wo from tb_WO where wo = @WO)
set @id_pn = (select id_pn from tb_WO where id_wo = @id_wo)
set @letter = (select type from tb_Consecutive where nom = (select left(pn,2) from tb_PN where id_pn  = @id_pn))
set @location = (select id from tb_location where id_location = 1)
set @count = 0

while @count <= @top
begin
	Begin
		set 
		set @SN = CONCAT(@format , @location , @letter , @Consecutive)
		insert into tb_Inprocess(SerialNumber, RegSN, id_wo, id_user) values(@SN, GETDATE(), @id_wo, @id_user)
		
		set @count = @count+1
		set @Consecutive = @Consecutive + 1
		update tb_Consecutive set consecutive = @Consecutive where nom = (select left(pn,2) from tb_PN where id_pn  = @id_pn)

	end
end

end
