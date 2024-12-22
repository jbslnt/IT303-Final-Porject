-- Step 1: Create the database
CREATE DATABASE QwizzlerDB;

-- Step 2: Switch to the new database
USE QwizzlerDB;

-- Step 3: Create the Questions table
CREATE TABLE Questions
(
    ID INT IDENTITY(1,1) PRIMARY KEY, 
    QSet VARCHAR(100) NOT NULL,         
    QNumber VARCHAR(50) NOT NULL,
    Question VARCHAR(500) NOT NULL,     
    OptionA VARCHAR(250) NOT NULL,     
    OptionB VARCHAR(250) NOT NULL,      
    OptionC VARCHAR(250) NOT NULL,      
    OptionD VARCHAR(250) NOT NULL,     
    Answer CHAR(1) NOT NULL,           
    CONSTRAINT CK_Answer CHECK (Answer IN ('A', 'B', 'C', 'D'))  
);

-- (Optional) Insert sample data to test the SELECT queries
INSERT INTO Questions (QSet, QNumber, Question, OptionA, OptionB, OptionC, OptionD, Answer)
VALUES ('1', '001', 'Sample Question 1', 'Option A', 'Option B', 'Option C', 'Option D', 'A'),
       ('1', '002', 'Sample Question 2', 'Option A', 'Option B', 'Option C', 'Option D', 'B'),
       ('2', '001', 'Sample Question 3', 'Option A', 'Option B', 'Option C', 'Option D', 'C');

-- Step 4: Run the SELECT queries
SELECT * FROM Questions;

SELECT MAX(QSet) FROM Questions;

SELECT MAX(QNumber) FROM Questions WHERE QSet = '1';

SELECT DISTINCT QSet FROM Questions;
