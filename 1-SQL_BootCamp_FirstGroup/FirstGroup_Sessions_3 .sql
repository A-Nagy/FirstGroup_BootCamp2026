

/*
=====================================================
Data Manipulation Language (DML) in SQL Server
=====================================================
Main Comands : insert     upadete     Delete 

1. INSERT:
----------
Used to add new records to a table.

Syntax:
    INSERT INTO table_name (column1, column2, ...)
				    VALUES (value1 , value2 , ...);
2. UPDATE:
----------
Used to modify existing records.

Syntax:
    UPDATE table_name
    SET column1 = value1, column2 = value2, ...
    WHERE condition;

3. DELETE:
----------
Used to remove one or more records.

Syntax:
    DELETE FROM table_name
    WHERE condition;


*/
insert into mydeptss(dept_id , dept_name )
			  values( 1       , 'It'     )

insert into mydeptss(dept_id  , dept_name  ) --pk 
			  values( 1       , 'FullStack')

insert into mydeptss(dept_id  )--not null 
			  values( 3       )

insert into my_empss(emp_id , emp_name , salary )
			 values ( 1     , 'ahmad'     , 4500)

insert into my_empss( salary, emp_name , emp_id )
			 values ( 5000  , 'ahmad'  , 1      )

insert into my_empss( salary, emp_name , emp_id  , hire_date)
			 values ( 5000  , 'ahmad'  , 1       , '2026-07-18' )

--------------------------------------------------------

update my_empss 
    set  salary = 4000  , dept_id = 1
   where salary <4000

update mydeptss
 set dept_name = 'CS'
 where dept_id = 2

--------------------------------------------------------
 delete from my_empss

 delete from mydeptss
 where dept_id = 2

-- update Myemps 
--set hire_date = '2025-07-16', salary = 13000, Dept_ID = 3,Emp_name = 'Ahmed'
--where Emp_ID = 1

--insert into my_emp (emp_id,emp_name, salary, dept_id) values (101, 'ali',8000 ,1);
--select * from my_emp

--insert into MyEmps (Emp_ID,Emp_name,salary,hire_date,Dept_ID)
--            values (44    ,'Omar'  ,15000 ,NULL     , 1     )



select * from MyEmps
select *  from MyDeptss
select *  from my_empss