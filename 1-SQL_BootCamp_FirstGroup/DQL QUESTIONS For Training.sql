------------------------------------------------------------
-- 🔰 BEGINNER LEVEL TASKS
------------------------------------------------------------

-- Task 1: Retrieve all employee data

-- Task 2: Select specific columns

-- Task 3: Calculate annual salary

-- Task 4: String concatenation

-- Task 5: DISTINCT and filtering

-- Task 6: Use BETWEEN, IN, and LIKE

-- Task 7: NULL and NOT NULL filtering

-- Task 8: Use ORDER BY to sort data

-- Task 9: Use alias and expressions in ORDER BY

------------------------------------------------------------
-- 🟡 INTERMEDIATE LEVEL TASKS
------------------------------------------------------------

-- Task 10: Use variables in a query

-- Task 11: Use BETWEEN with variables

-- Task 12: Use string functions

-- Task 13: Use GROUP BY

-- Task 14: Use HAVING to filter groups

-- Task 15: Use CASE to categorize results

-- Task 16: Use date functions

-- Task 17: Use CAST and CONVERT

-- Task 18: Use IIF for conditional output

-- Task 18.1: Apply IIF on commission_pct

------------------------------------------------------------
-- 🔴 ADVANCED LEVEL TASKS (JOINS & MULTI-TABLE)
------------------------------------------------------------

-- Task 19: Use INNER JOIN to combine employees with departments

-- Task 20: Use CROSS JOIN to show all employee-job combinations

-- Task 21: Use JOIN with three tables

-- Task 22: Use SELF JOIN to show employees with their managers

-- Task 23: Use LEFT, RIGHT, FULL OUTER JOINs

-- Task 24: Use WHERE with complex logic (AND/OR)

------------------------------------------------------------
-- 🧠 QUESTIONS & EXERCISES – BEGINNER LEVEL
------------------------------------------------------------

-- Q1: Show full name and salary of each employee

-- Q2: Show job ID and salary > 5000 for IT_PROG

-- Q3: Show employees hired after 2007, sorted by hire date desc

------------------------------------------------------------
-- 🧠 QUESTIONS & EXERCISES – INTERMEDIATE LEVEL
------------------------------------------------------------

-- Q4: Show department ID and avg salary for depts with avg > 6000

-- Q5: Show job ID and count of employees per job

-- Q6: Categorize salary levels using CASE (High, Medium, Low)

------------------------------------------------------------
-- 🧠 QUESTIONS & EXERCISES – ADVANCED LEVEL (JOINS)
------------------------------------------------------------

-- Q1: Show employees with their department names

-- Q2: Show employees with their manager names

-- Q3: Show departments that have no employees

-- Q4: Show employees with department name and city

-- Q5: Use CROSS JOIN to show all employee-job combinations

-- Q6: Show employees working in city ‘Toronto’

-- Q7: Show employees with salary > 12000

-- Q8: Show employees with salary NOT BETWEEN 5000 AND 12000

-- Q9: Show employees in certain jobs, excluding some salaries

-- Q10: Show last names starting with J, A, or M (uppercase + length)

-- Q11: Show department address details using LOCATIONS

------------------------------------------------------------
-- ✅ END OF COURSE (WITHOUT SOLUTIONS)
------------------------------------------------------------
--🔍 Task:
--Write a SQL query to retrieve, for each job title, 
--the job ID, the number of employees in that job, 
--the total salary, the highest salary, the lowest salary, and the average salary.
--The query should only consider jobs with IDs in the
-- list: 'IT_PROG', 'SA_MAN', 'FI_ACCOUNT', 'HR_REP', and 'AD_VP'. 
-- Additionally, include only those job titles where the total salary exceeds 5,000. 
--Finally, the result should be sorted in ascending order based on the total salary.


--* Using the CASE function, write a query that displays the grade of all
--employees based on the value of the JOB_ID column, using the following data:
--Job 				Grade
--AD_PRES 			A
--ST_MAN 				B
--IT_PROG 			C
--SA_REP 				D
--ST_CLERK 			E
--None of the above 	0
