-- -------------------- Questions ------------------------

-- ==================== INSERT Questions ====================
-- * Insert 5 records into courses table.
--   Do not insert start_date, so SQL Server uses the default value.
--   All prices must be between 800 and 3000.
--   All durations must be between 12 and 120.

-- * Insert the following course:
--   cours_id => 1
--   course_title => SQL Server
--   price => 1200
--   start_date => use default value
--   duration => 40

-- * Insert 4 additional courses using one INSERT statement.
--   The total number of records in courses table must be 5 records only.

-- * Try to insert a course with price = 500.
--   Check if SQL Server accepts or rejects the record.

-- * Try to insert a course with duration = 150.
--   Check the constraint that prevents the insertion.

-- * Insert 5 records into projects table.
--   project_name must not be null.
--   hour_rate must be greater than 1.

-- * Insert a project where client_name is NULL.

-- * Insert the following project:
--   project_id => 101
--   project_name => Hospital System
--   client_name => Al-Shifa Hospital
--   hour_rate => 150

-- * Insert 4 additional projects using one INSERT statement.
--   The total number of projects must be 5 records only.

-- * Try to insert a project with hour_rate = 1.
--   Check if SQL Server accepts or rejects the record.

-- * Insert 5 records into tasks table.
--   Each project_id must already exist in projects table.
--   end_date must be greater than start_date.

-- * Insert the following task:
--   task_id => 1001
--   description => Analyze project requirements
--   start_date => 2026-08-01
--   end_date => 2026-08-05
--   project_id => 101

-- * Insert 4 additional tasks using one INSERT statement.
--   The total number of tasks must be 5 records only.

-- * Try to insert a task where end_date is before start_date.
--   Check the constraint that prevents the insertion.

-- * Try to insert a task with project_id = 999.
--   Assume that project_id 999 does not exist in projects table.
--   Check the foreign key error.

-- ==================== UPDATE Questions ====================
-- * Update the price of the course with cours_id = 1 to 1500.

-- * Update the duration of the course named SQL Server to 50.

-- * Increase the price of all courses by 100.

-- * Increase the price of courses whose price is less than 1500 by 10 percent.

-- * Update the course_title of cours_id = 2 to Advanced SQL Server.

-- * Update the start_date of cours_id = 3 to the current date.

-- * Try to update a course price to 4000.
--   Check if SQL Server accepts or rejects the update.

-- * Try to update a course duration to 5.
--   Check the CHECK constraint.

-- * Update the client_name of the project with project_id = 101.

-- * Update all projects where client_name is NULL.
--   Set client_name to Unknown Client.

-- * Increase hour_rate by 20 for the project with project_id = 102.

-- * Increase hour_rate by 10 percent for all projects
--   where hour_rate is less than 150.

-- * Try to update hour_rate to 0.
--   Check if SQL Server accepts or rejects the update.

-- * Update the description of task_id = 1001.

-- * Update the end_date of task_id = 1001
--   by adding 3 days to its current end_date.

-- * Update all tasks related to project_id = 101.
--   Add 7 days to their end_date.

-- * Change project_id of task_id = 1002
--   to another existing project_id.

-- * Try to update project_id of task_id = 1003 to 999.
--   Assume project_id 999 does not exist.

-- * Try to update end_date so that it becomes
--   less than or equal to start_date.

-- ==================== DELETE Questions ====================
-- * Delete the course with cours_id = 5.

-- * Delete the course named SQL Server.

-- * Delete all courses whose price is less than 1000.

-- * Delete all courses whose duration is greater than 60.

-- * Delete the task with task_id = 1005.

-- * Delete all tasks related to project_id = 101.

-- * Delete all tasks whose end_date is before the current date.

-- * Try to delete project_id = 101
--   while it still has related tasks.
--   Check the foreign key error.

-- * Delete all tasks related to project_id = 101 first.
--   Then delete project_id = 101.

-- * Delete all projects where client_name is NULL
--   and the project does not have any related tasks.

-- * Delete the project with the lowest hour_rate.

-- * Delete all tasks related to projects
--   where hour_rate is less than 100.

-- ==================== Advanced Questions ====================
-- * Insert one project and two related tasks
--   using a transaction.

-- * If all INSERT statements succeed, use COMMIT.
--   If an error occurs, use ROLLBACK.

-- * Update the price of all courses by 15 percent,
--   but do not allow any price to exceed 3000.

-- * Delete a project and all its related tasks
--   inside a transaction.

-- * Use ROLLBACK after deleting the project
--   to restore the deleted records.

-- * Use OUTPUT with UPDATE to display:
--   cours_id
--   old price
--   new price

-- * Use OUTPUT with DELETE to display
--   the deleted task records.

-- * Write an INSERT statement that adds a new course
--   only when the courses table contains fewer than 10 records.

-- * Write an INSERT statement that adds a new project
--   only when the projects table contains fewer than 10 records.

-- * Write an INSERT statement that adds a new task
--   only when the tasks table contains fewer than 10 records.
-- ==================== Review Questions ====================
-- * Display all records from courses table.

-- * Display all records from projects table.

-- * Display all records from tasks table.

-- * Display the number of records in courses table.

-- * Display the number of records in projects table.

-- * Display the number of records in tasks table.

-- * Display courses ordered by price from highest to lowest.

-- * Display projects ordered by hour_rate from highest to lowest.

-- * Display tasks ordered by start_date from oldest to newest.

-- * Explain what happens when UPDATE is used without WHERE.

-- * Explain what happens when DELETE is used without WHERE.
