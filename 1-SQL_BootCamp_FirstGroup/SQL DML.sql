
/*
=====================================================
Data Manipulation Language (DML) in SQL Server
=====================================================

1. INSERT:
----------
Used to add new records to a table.

Syntax:
    INSERT INTO table_name (column1, column2, ...)
    VALUES (value1, value2, ...);

Example:
    -- Insert into Courses table
    INSERT INTO Courses (Course_ID, Course_Title, Price, Duration)
    VALUES (101, 'SQL Basics', 1500, 60);

    -- Insert into Projects table
    INSERT INTO Projects (Project_ID, Project_Name, Client_Name, Hour_Rate)
    VALUES (1, 'Website Development', 'ABC Corp', 50.00);

    -- Insert into Tasks table
    INSERT INTO Tasks (Task_ID, Description, Start_Date, End_Date, Project_ID)
    VALUES (10, 'Design UI mockups', '2024-09-01', '2024-09-05', 1);


2. UPDATE:
----------
Used to modify existing records.

Syntax:
    UPDATE table_name
    SET column1 = value1, column2 = value2, ...
    WHERE condition;

Example:
    -- Update price in Courses table
    UPDATE Courses
    SET Price = 1800
    WHERE Course_ID = 101;

    -- Update client name in Projects table
    UPDATE Projects
    SET Client_Name = 'XYZ Ltd.'
    WHERE Project_ID = 1;


3. DELETE:
----------
Used to remove one or more records.

Syntax:
    DELETE FROM table_name
    WHERE condition;

Example:
    -- Delete from Tasks table
    DELETE FROM Tasks
    WHERE Task_ID = 10;

    -- Delete from Courses table
    DELETE FROM Courses
    WHERE Course_ID = 101;

NOTE:
- Always use WHERE clause in UPDATE and DELETE to avoid affecting all records unintentionally.
=====================================================
*/



--           INSERT, UPDATE and DELETE Practice
-- -------------------- Tables Structure --------------------

-- * books table:
--   book_id => pk
--   book_title => not null
--   author_name => not null
--   price => between 50 and 1000
--   publish_date => date
--   available_copies => between 0 and 100


-- * members table:
--   member_id => pk
--   member_name => not null
--   email => unique and not null
--   phone => max char 15
--   join_date => default value current date
--   membership_type => only Basic, Premium or VIP


-- * borrowings table:
--   borrowing_id => pk
--   borrow_date => default value current date
--   return_date => greater than borrow_date
--   status => only Borrowed, Returned or Late
--   book_id => foreign key
--   member_id => foreign key

-- ========================================================
--                    INSERT Questions
-- =========================================================
-- -------------------- Question 1 --------------------------
-- * Insert one book into books table as follow:
--   book_id => 1
--   book_title => SQL Server Fundamentals
--   author_name => Ahmed Ali
--   price => 250
--   publish_date => 2024-01-15
--   available_copies => 10
INSERT INTO Books
(
    book_id,
    book_title,
    author_name,
    price,
    publish_date,
    available_copies
)
VALUES
(
    1,
    'SQL Server Fundamentals',
    'Ahmed Ali',
    250,
    '2024-01-15',
    10
);
-- -------------------- Question 2 --------------------------
-- * Insert four additional books using one INSERT statement.
-- * The total number of books should become 5 records.
INSERT INTO Books
(
    book_id,
    book_title,
    author_name,
    price,
    publish_date,
    available_copies
)
VALUES
    (2, 'Database Design', 'Sara Hassan', 300, '2023-06-20', 8),
    (3, 'Advanced SQL Queries', 'Mohamed Adel', 450, '2025-02-10', 5),
    (4, 'Power BI Basics', 'Mona Samir', 350, '2024-09-01', 12),
    (5, 'Python for Data Analysis', 'Omar Khaled', 500, '2025-01-05', 7);
-- -------------------- Question 3 --------------------------
-- * Insert one member into members table as follow:
--   member_id => 101
--   member_name => Ali Mahmoud
--   email => ali@gmail.com
--   phone => 01012345678
--   join_date => use default value
--   membership_type => Basic
INSERT INTO Members
(
    member_id,
    member_name,
    email,
    phone,
    membership_type
)
VALUES
(
    101,
    'Ali Mahmoud',
    'ali@gmail.com',
    '01012345678',
    'Basic'
);
-- -------------------- Question 4 --------------------------
-- * Insert four additional members using one INSERT statement.
-- * Do not insert join_date.
-- * SQL Server should use the default value.
INSERT INTO Members
(
    member_id,
    member_name,
    email,
    phone,
    membership_type
)
VALUES
    (102, 'Sara Ahmed', 'sara@gmail.com', '01123456789', 'Premium'),
    (103, 'Omar Hassan', 'omar@gmail.com', '01234567890', 'VIP'),
    (104, 'Mona Adel', 'mona@gmail.com', NULL, 'Basic'),
    (105, 'Khaled Samir', 'khaled@gmail.com', '01512345678', 'Premium');
-- -------------------- Question 5 --------------------------
-- * Insert one borrowing record as follow:
--   borrowing_id => 1001
--   borrow_date => use default value
--   return_date => 7 days after current date
--   status => Borrowed
--   book_id => 1
--   member_id => 101
INSERT INTO Borrowings
(
    borrowing_id,
    return_date,
    status,
    book_id,
    member_id
)
VALUES
(
    1001,
    DATEADD(DAY, 7, CAST(GETDATE() AS DATE)),
    'Borrowed',
    1,
    101
);
-- -------------------- Question 6 --------------------------
-- * Insert four additional borrowing records.
-- * Each book_id must exist in books table.
-- * Each member_id must exist in members table.
-- * return_date must be greater than borrow_date.
INSERT INTO Borrowings
(
    borrowing_id,
    borrow_date,
    return_date,
    status,
    book_id,
    member_id
)
VALUES
    (1002, '2026-07-01', '2026-07-10', 'Returned', 2, 102),
    (1003, '2026-07-05', '2026-07-15', 'Late',     3, 103),
    (1004, '2026-07-10', '2026-07-20', 'Borrowed', 4, 104),
    (1005, '2026-07-12', '2026-07-22', 'Borrowed', 5, 105);
=============================================================
--                    UPDATE Questions
-- =========================================================
-- -------------------- Question 7--------------------------
-- * Update the price of book_id 1 to 275.
UPDATE Books
SET price = 275
WHERE book_id = 1;
-- -------------------- Question 8 -------------------------
-- * Update available_copies of book_id 2 to 15.
UPDATE Books
SET available_copies = 15
WHERE book_id = 2;
-- -------------------- Question 9-------------------------
-- * Update the phone number of member_id 104.
UPDATE Members
SET phone = '01099998888'
WHERE member_id = 104;
-- -------------------- Question 10 -------------------------
-- * Update membership_type of member_id 101
--   from Basic to Premium.
UPDATE Members
SET membership_type = 'Premium'
WHERE member_id = 101;
-- -------------------- Question 11 -------------------------
-- * Increase the price of all books whose price
--   is less than 350 by 50.
UPDATE Books
SET price = price + 50
WHERE price < 350;
-- -------------------- Question 12 -------------------------
-- * Increase the price of all books by 10 percent.
-- * Update only books whose new price will not exceed 1000.
UPDATE Books
SET price = price * 1.10
WHERE price * 1.10 <= 1000;
-- -------------------- Question 13 -------------------------
-- * Update all members whose phone is NULL.
-- * Set their phone value to Not Available.
UPDATE Members
SET phone = 'Not Available'
WHERE phone IS NULL;
-- -------------------- Question 14 -------------------------
-- * Update borrowing_id 1004.
-- * Change its status to Returned.
UPDATE Borrowings
SET status = 'Returned'
WHERE borrowing_id = 1004;
- -------------------- Question 15 -------------------------
-- * Update borrowing_id 1005.
-- * Add 5 days to its return_date.
UPDATE Borrowings
SET return_date = DATEADD(DAY, 5, return_date)
WHERE borrowing_id = 1005;
-- -------------------- Question 17 -------------------------
-- * Update all borrowing records with status Borrowed.
-- * Add 3 days to their return_date.
UPDATE Borrowings
SET return_date = DATEADD(DAY, 3, return_date)
WHERE status = 'Borrowed';
-- -------------------- Question 18 -------------------------
-- * Change all borrowing records whose return_date
--   is before the current date to Late.
-- * Do not update records that are already Returned.
UPDATE Borrowings
SET status = 'Late'
WHERE return_date < CAST(GETDATE() AS DATE)
  AND status <> 'Returned';
-- -------------------- Question 19 -------------------------
-- * Update available_copies of book_id 1.
-- * Decrease the number of available copies by 1.
-- * Do not allow the value to become less than zero.
UPDATE Books
SET available_copies = available_copies - 1
WHERE book_id = 1
  AND available_copies > 0;
--                   DELETE Questions
-- =========================================================
-- ------------------- Question 20 -------------------------
-- * Delete borrowing_id 1006.
DELETE FROM Borrowings
WHERE borrowing_id = 1006;
-- -------------------- Question 21 -------------------------
-- * Delete all borrowing records whose status is Returned.
DELETE FROM Borrowings
WHERE status = 'Returned';
-- -------------------- Question 22 -------------------------
-- * Delete all borrowing records whose return_date
--   is before 2026-07-10.
DELETE FROM Borrowings
WHERE return_date < '2026-07-10';
-- -------------------- Question 23 -------------------------
-- * Delete all borrowing records related to member_id 105.
DELETE FROM Borrowings
WHERE member_id = 105;
-- -------------------- Question 24 -------------------------
-- * Delete book_id 5 after deleting its related
--   borrowing records first.

DELETE FROM Borrowings
WHERE book_id = 5;

DELETE FROM Books
WHERE book_id = 5;




