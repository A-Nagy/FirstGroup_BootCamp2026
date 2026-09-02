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

------------------------------------------------------------------

-- -------------------- Questions ------------------------

-- * create books table as follow:
--   book_id => pk
--   book_title => not null
--   author_name => not null
--   price => between 50 and 1000
--   publish_date => date
--   available_copies => between 0 and 100


-- * create members table as follow:
--   member_id => pk
--   member_name => not null
--   email => unique and not null
--   phone => max char 15
--   join_date => default value current date
--   membership_type => only Basic, Premium or VIP


-- * create borrowings table as follow:
--   borrowing_id => pk
--   borrow_date => default value current date
--   return_date => greater than borrow_date
--   status => only Borrowed, Returned or Late
--   book_id => foreign key
--   member_id => foreign key
```
