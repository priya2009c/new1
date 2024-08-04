CREATE PROCEDURE [dbo].[register_crud1]
	@action varchar(100),
	@id int=null,
	@name varchar(100)=null,
	@email varchar(100)=null,
	@pass varchar(100)=null,
	@dept_id int=null,
	@dept_name varchar(100)=null,
	@course_id int=null,
	@course_name varchar(100)=null

AS
BEGIN
	IF @action='dd_dept'
	BEGIN
	SELECT * FROM tbl_dept
	END

	IF @action='dd_course'
	BEGIN
	SELECT * FROM tbl_course WHERE dept_id=@dept_id
	END

	IF @action='INSERT'
	BEGIN
	INSERT INTO tbl_student(stud_name,email,pass,dept_id,course_id) VALUES(@name,@email,@pass,@course_id,@dept_id);
	END

	IF @action='LOGIN'
	BEGIN
	SELECT COUNT(*) FROM tbl_student WHERE email=@email AND pass=@pass
	END

	IF @action='SELECT'
	BEGIN
	SELECT * FROM tbl_student
	END
END