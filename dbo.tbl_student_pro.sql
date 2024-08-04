CREATE TABLE [dbo].[tbl_student] (
    [stud_id]   INT          IDENTITY (1, 1) NOT NULL,
    [stud_name] VARCHAR (50) NOT NULL,
    [email]     VARCHAR (50) NOT NULL,
    [pass]      VARCHAR (50) NOT NULL,
    [dept_id]   INT          NOT NULL,
    [course_id] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([stud_id] ASC),
    CONSTRAINT [FK_tbl_student_ToTable] FOREIGN KEY ([dept_id]) REFERENCES [dbo].[tbl_dept] ([dept_id]),
    CONSTRAINT [FK_tbl_student_ToTable_1] FOREIGN KEY ([course_id]) REFERENCES [dbo].[tbl_course] ([course_id])
);

