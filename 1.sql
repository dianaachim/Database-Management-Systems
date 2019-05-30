--create database ProjectManagement
/*
create table Developer (
	did int primary key identity(1,1),
	dname varchar(20),
	age int,
	yoe int)

create table Category (
	cid int primary key identity(1,1),
	description varchar(50))

create table Project (
	pid int primary key identity(1,1),
	pname varchar(20),
	cid int foreign key references Category(cid))

create table ProjectTeam (
	pdate date,
	did int foreign key references Developer(did),
	pid int foreign key references Project(pid),
	primary key (did, pid))


create table Task (
	tid int primary key identity(1,1),
	descr varchar(50),
	duedate date,
	did int foreign key references Developer(did))

create table Feature (
	fid int primary key identity(1,1),
	fname varchar(20),
	estimation int,
	tid int foreign key references Task(tid))
	*/

	insert into Developer Values ('ana', 12, 1), ('ion', 19, 3)
	insert into Task values ('fdgrgh', '10/10/10', 1)
	
	