-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.
--Column 1: Id          Column 2: Name       Column 3: EmployerId
--DataType: int AI PK   DataType: longtext   Datatype: int

--Part 2: Write a query to list the names of the employers in St. Louis City.
--Select Name 
--FROM techjobs.employers
--WHERE (Location = 'St. Louis');

--Part 3: Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.
    --If a skill does not have a job listed, it should not be included in the results of this query.
--SELECT skills.SkillName
--FROM skills
--JOIN jobskills ON skills.ID = jobskills.SkillsId
--JOIN jobs ON jobskills.jobsId = jobs.Id
--WHERE jobs.Id IS NOT NULL
--ORDER BY skills.SkillName ASC;
