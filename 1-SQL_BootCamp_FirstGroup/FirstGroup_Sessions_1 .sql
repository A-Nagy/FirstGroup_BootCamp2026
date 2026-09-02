-------------------------------------------------------
-- 🔰 BEGINNER LEVEL TASKS
-------------------------------------------------------
-- Task 1: Retrieve all employee data
		select *
		from employees
-- Task 2: Select specific columns
		select last_name , salary , department_id
		from employees
-- Task 3: Calculate annual salary
		select last_name , salary , salary * 12 as Annual_Salary
		from employees 
-- Task 4: String concatenation ( جمع نصين )
		select First_name +' '+ last_Name 
		from employees
-- Task 5: DISTINCT and filtering
		select last_name , job_id , department_id 
		from employees

		select Distinct job_id  
		from employees

		select Distinct department_id  
		from employees
-- Task 6: Use BETWEEN, IN, and LIKE
			select * 
			from employees 
			where salary >=5000 and salary<=7000

		    select * 
			from employees 
			where salary between 5000 and 7000 
			 
			select * 
			from employees 
			where salary between 5000 and 7000
					     and department_id = 80

			--select all employee data whose work in department_id 30 or 60 or 90
			select * 
			from employees
			where  department_id = 30 
				or department_id = 60
				or department_id = 90

			select * 
			from employees
			where  department_id in (30,60,90)

			select last_name , email , phone_number 
			from employees
			where last_name = 'king'

		    select last_name , email , phone_number 
			from employees
			where last_name like 'K%'
-- Task 7: NULL and NOT NULL filtering
			select last_name ,  department_id 
			from employees
			where department_id is  null
-- Task 8: Use ORDER BY to sort data
			select * 
			from employees
			where  department_id = 30 
				or department_id = 60
				or department_id = 90
			order by department_id desc,last_name
-- Task 9: Use alias and expressions in ORDER BY
		select last_name , salary , salary * 12 as Annual_Salary
		from employees
		order by  salary * 12
-------------------------------------------------------
-- 🟡 INTERMEDIATE LEVEL TASKS
-------------------------------------------------------
-- Task 10: Use variables in a query
			Declare @job nVArchar(20) = 'IT_PROG'
			select last_name , Job_id 
			from employees
			where job_id = @job
			---------
 


-- Task 11: Use BETWEEN with variables

declare @low_salary int  =  5000
declare @high_salary int  = 7000
select * 
from hr.dbo.employees
where salary between @low_salary and @high_salary
order by salary  

-- Task 12: Use string functions
select last_name , upper(last_name ) as Capital_Case ,
				   lower(last_name ) as small_Case,
				   len(last_name)    as Letters_Count
from employees
where department_id = 30 

select last_name ,  job_id , lower(job_id) as small_Case
from employees
where lower(job_id)='it_prog' 

-- Task 13: Use GROUP BY
select * 
from employees
order by department_id

select count(*) 
from employees
where department_id = 40

select department_id ,  count(employee_id) as Count_Of_Employees
from employees
group by department_id

select department_id ,  count(*) as Count_Of_Employees, 
						max(salary ) as 'اعلي راتب بالقسم ', 
						min(salary ) as 'اقل راتب بالقسم ' ,
						sum(salary ) as 'مجموع الرواتب للقسم ',
						avg(salary)  as avrage_salary
from employees
group by department_id
 
-- Task 14: Use HAVING to filter groups
select department_id ,  count(employee_id) as Count_Of_Employees
from employees
group by department_id

--الاقسام التي يتجاوز عدد الموظفين فيها 10 افراد 
select department_id , COUNT(employee_id) as No_Of_Employees,
					   MAX(salary) as Maximum_s ,
                       MIN(salary) as Minmum_s ,
					   suM(salary) as Sum_s ,
					   AVG(salary) as avg_s 

from employees
group by department_id
having  COUNT(employee_id)>10

select department_id , COUNT(employee_id) as No_Of_Employees,
					   MAX(salary) as Maximum_s ,
                       MIN(salary) as Minmum_s ,
					   suM(salary) as Sum_s ,
					   AVG(salary) as avg_s 

from employees
--where  salary>=5000
group by department_id
having  COUNT(employee_id)>10
 
select department_id , COUNT(employee_id) as No_Of_Employees
from employees 
where salary>=10000
group by department_id
having  COUNT(employee_id) >=3

-- Task 15: Use CASE to categorize results
     select last_name , case 
							when salary between 10000 and 12000 then 'high_salary'
							when salary between 12001 and 14000 then 'very high salary '
							else 'ex highSalary '
						 end as Salary_Level 
	  
	 from employees
	 where salary >10000
	 order by salary

-- Task 16: Use date functions
select last_name ,year( hire_date) as Hire_Year  , DATEDIFF(year,hire_date, GetDate()) as worked_year 
from employees
where hire_date between '2000-01-04'and '2000-04-21'
order by hire_date
-- Task 17: Use CAST and CONVERT
select last_name , salary,cast(salary as varchar) + ' $' as Salary_text ,
						  DATEDIFF(year,hire_date, GetDate()) as worked_year , 
						  Convert(varchar(10),hire_date,103) as formatted_date
from Employees 
order By salary
-- Task 18: Use IIF for conditional output
 select last_name ,  iif(salary >=10000, 'high_salary ','Normal salary ') as salary_level
 from employees
 where salary >10000
 order by salary
-- Task 18.1: Apply IIF on commission_pct
--select employee name and commision status if has commission or no using is not null 

select concat(first_name ,' ',last_name) as full_name ,salary ,commission_pct, 
		iif(commission_pct is not null ,'has','no has') as commission_stat 
from hr.dbo.employees

select last_name, IIF(commission_pct is not null , 'Have Commision','No Commision') as Commision
from employees
order by commission_pct


--------------------------------------------------
select * from employees
select * from departments
select * from Locations
select * from jobs


select e.last_name , d.department_name,l.street_address, l.city
from   employees e ,departments d,Locations l
where e.department_id = d.department_id
and   d.location_id = l.location_id

select e.last_name , d.department_name,l.street_address, l.city
from employees e cross join departments d
			     cross join locations l
where e.department_id = d.department_id
and   d.location_id = l.location_id


select e.last_name , d.department_name,l.street_address, l.city
from employees e join departments d on e.department_id = d.department_id
	       inner join locations l   on d.location_id   = l.location_id 
 
 select e.last_name , d.department_name
from employees e left join departments d on e.department_id = d.department_id
 
select e.last_name , d.department_name
from employees e right join departments d on e.department_id = d.department_id
	
select e.last_name , d.department_name
from employees e Full outer join departments d on e.department_id = d.department_id
	
	
