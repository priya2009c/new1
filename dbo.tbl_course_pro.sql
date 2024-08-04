CREATE TABLE [dbo].[tbl_course] (
    [course_id]   INT          IDENTITY (1, 1) NOT NULL,
    [course_name] VARCHAR (50) NOT NULL,
    [dept_id]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([course_id] ASC),
    CONSTRAINT [FK_tbl_course_ToTable] FOREIGN KEY ([dept_id]) REFERENCES [dbo].[tbl_dept] ([dept_id])
);

