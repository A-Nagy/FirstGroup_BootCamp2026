--SQL ---DDl ---DML ---DQl 
--data definition Lang
-- Create   Alter    Drop 
/*
1. CREATE TABLE:
----------------
Syntax:
    CREATE TABLE table_name (
        column_name datatype [CONSTRAINT constraint_name constraint_type],
        ...,   
        [CONSTRAINT constraint_name constraint_type]
    );

Naming Rules:
    - Maximum 128 characters.
    - Can include A-Z, a-z, 0-9, _
    - Must begin with a letter.
    - Must not be a reserved keyword.

Common Datatypes in SQL Server:
    - Numeric: INT, BIGINT, SMALLINT, DECIMAL(p,s), FLOAT, REAL  -- decimal(6,1) 9999.99
    - Text: CHAR(n), VARCHAR(n), TEXT
    - Date/Time: DATE, DATETIME, SMALLDATETIME, TIME
    - Other: BIT, MONEY, UNIQUEIDENTIFIER, VARBINARY(MAX)

Constraint Types:
    - PRIMARY KEY
    - UNIQUE
    - NOT NULL
    - CHECK (condition)
    - FOREIGN KEY REFERENCES other_table(column)

2. ALTER TABLE:     ADD     Modify      Drop  :   column
					ADD                 Drop  :   constraint 
---------------
Syntax Overview:
ALTER TABLE table_name
					   ADD column_name datatype [contraint Statement ];

             -- Modify column datatype or nullability
					   ALTER COLUMN column_name new_datatype ;
			
					   Drop  COLUMN column_name ; 

			  -- Add a constraint
			   ADD CONSTRAINT constraint_name constraint_type;
			  -- Drop a constraint
			   DROP CONSTRAINT constraint_name;

3. DROP TABLE:
--------------
Syntax:
    DROP TABLE table_name;
Example:
    DROP TABLE Employees;

Note:
    - SQL Server automatically removes constraints and Data with the table.

*/
create table emp1(
emp_id   int , 
emp_name varchar(200)
);

create table emp2(
emp_id   int          primary key , 
emp_name varchar(200) not null    ,
phone    char(12)     unique        
);

create table emp3(
emp_id   int          constraint emp3_emp_id_pk    primary key , 
emp_name varchar(200) constraint emp3_emp_name_nk  not null ,
phone    char(12)     constraint emp3_emp_phone_uk unique       
);

create table emp4(
emp_id   int                                                , 
emp_name varchar(200) constraint emp4_emp_name_nk  not null ,
phone    char(12)                                           ,
manager  int         
constraint emp4_emp_id_pk    primary key(emp_id)            ,
constraint emp4_emp_phone_uk unique(phone)
);

create table travels(
trvel_num  int          ,
trvel_date date         ,
destantion varchar(20)  , 
constraint pk_travels primary Key ( trvel_num,trvel_date)
)

create table travel_tikits(
Tikit_Number  int       primary key    ,
Tikit_date   date          ,
tikit_type varchar(20)     , 
trvel_num  int             ,
trvel_date date            , 
constraint fk_Tikit foreign key (trvel_num,trvel_date) references travels ( trvel_num,trvel_date) 
)

create table emp_Omar(
emp_id   int                                                  ,
emp_name varchar(200) constraint  empOmar_emp_name_nk not null,
phone    char(12)                                             ,
constraint empOmar_emp_id_pk primary key(emp_id),
constraint empOmar_phone_uk  unique (phone)
);

alter table emp1 add email varchar(100) ;
alter table emp2 add email varchar(100) not null  ;
alter table emp3 add email varchar(100) constraint emp3_emp_email_nk not null  ;
alter table emp4 add phone varchar(20) ;
--------------------------------------------------------------
alter table emp1 alter column email varchar(150) ;
alter table emp2 alter column email varchar(100) null   ;
alter table emp3 Alter column email varchar(200) not null ;
--------------------------------------------------------------
alter table emp1 Drop column email  ;
alter table emp2 Drop column email  ;
alter table emp3 Drop column email  ;
alter table emp4 Drop column phone  ;
--------------------------------------------------------------
Alter Table emp4 Add  Constraint  emp4_emp_phone_uk unique(phone)
--------------------------------------------------------------
Alter table emp4 Drop constraint  emp4_emp_phone_uk ;
--------------------------------------------------------------
Drop table emp1;
Drop table emp2;
Drop table emp3;
Drop table emp4;

exec sp_helpconstraint 'emp4'
-- ===========================
-- My_Depts and My_Emps Setup
-- ===========================

--Q1 : Create Table MyDepts As Following : 
   --	Dept_ID   int          --> primary Key
	--	Dept_name varchar(100) --> not Null 
create table MyDeptss( 
Dept_ID   int          constraint dept_emp_id   primary key ,
Dept_name varchar(200) constraint dept_emp_name not null 
) ;

--Q2 : Create Table MyEmps As Following : 
	    --	Emp_ID    int           --> primary K
		--Emp_name  varchar(150)  --> not Null 
		--Salary    Deciml(8,2)   --> Check(salar
		--hire_date Date 
		--Dept_ID   int           --> Foreign key
create table my_empss(
	emp_id    int,
	emp_name  varchar(100) constraint name_cons not null         ,
	salary    decimal(8,2) check( salary between 4000 and 10000) ,
	hire_date date default GetDate(),
	dept_id   int,
	constraint fk_emp foreign key(dept_id) references MyDeptss(dept_id)
);

-- -------------------- Questions ------------------------
-- * create courses table as follow:
--   cours_id => pk
--   course_title => not null
--   price => between 800 and 3000
--   start_date => default value the date after 7 days
--   duration => btw 12 and 120

-- * create a projects table 
--   project_id => pk
--   project_name => not null
--   client_name => 
--   hour_rate => positive greater than 1

-- * create a tasks table
--   task_id => pk
--   description => max char 255
--   start_date => date
--   end_date => greater than start_date
--   project_id => foreign key

