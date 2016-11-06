using Models.Generics;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Finale
 {
     //Aggregate Root
     public class StudyYear
     { 
        public class Deanship
    {
         public PlainText name { get; set; }
         public Credits credits { get; set; }
         public Proportion activityProportion { get; set; }
         public EvaluationType evaluation { get; set; }
         public Professor.Professor professor { get; set; }

    }
         public void Deanship(PlainText name, Credits credits,Proportion activityProportion, EvaluationType evaluation, , Professor.professor professor)
         {
             name=name;
             credits = credits;
             activityProportion=activityProportion;
             evalution=evaluation;
             professor= professor;
         }


         private List<Subject.Subject> _definedSubjects;
         public ReadOnlyCollection<Subject.Subject> Subjects { get { return _definedSubjects.AsReadOnly(); } }
 
         public StudyYear()
         {
             Anul I 
             Anul II 
             Anul III
             Anul IV
 
         }

         public StudyYear(List<Subject.Subject> definedSubjects)
         {
             _definedSubjects = definedSubjects;
         }
 
         public void DefineSubject(PlainText subjectName, Credits credits, EvaluationType type, Proportion activity)
         {
             _definedSubjects.Add(new Subject.Subject(new SubjectInformation(subjectName, credits, type, activity)));
         }
 
         public void DefineSubject(PlainText subjectName, Credits credits, EvaluationType type, Proportion activity, Professor.professor Professor)
         {
             _definedSubjects.Add(new Subject.Subject(new SubjectInformation(subjectName, credits, type, activity, professor)));
          }
 
         public void SignUpStudentToSubject(PlainText subjectName, Student.Student student)
         {
             _definedSubjects.Find(d => d.SubjectInfo.Name == subjectName).SignUpStudent(student);
         }
 
         public Grade CalculateStudentAverage(PlainText subjectName, RegistrationNumber regNumber)
         {
             return _definedSubjects.Find(d => d.SubjectInfo.Name == subjectName).GetAverageForStudent(regNumber);
         }
 
         public void PublishGradeReports(IReportPublisher publisher)
         {
 
         }
     }
 }

