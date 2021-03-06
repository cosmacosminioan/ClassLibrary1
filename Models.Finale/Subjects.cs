﻿using Models.Generics;
using System.Collections.Generic;


namespace Models.Professor
 {
     //Aggregate Root
     public class Subjects
     {
         private List<Subject.Subject> _subjects;
 
         public Subjects(List<Subject.Subject> subjects)
         {
             _subjects = subjects;
         }
 
         public void AddExamGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
         {
             _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                 .GetSituationForStudent(regNumber)
                 .AddExamGrade(grade);
         }
 
         public void AddActivityGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
         {
             _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                 .GetSituationForStudent(regNumber)
                 .AddActivityGrade(grade);
         }
 
         public void AddAttendance(PlainText subjectName, RegistrationNumber regNumber, Attendance attendance)
         {
             _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                 .GetSituationForStudent(regNumber)
                 .AddAttendance(attendance);
         }
 
         public void SetActivityProportion(PlainText subjectName, Proportion proportion)
         {
             _subjects.Find(d => d.SubjectInfo.Name == subjectName).SubjectInfo.SetActivityProportion(proportion);
         }
     }
 }