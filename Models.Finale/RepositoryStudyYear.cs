using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Finale
{
    public class IEntity 
    {
        public string ID;

    }
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindByID(int ID);
    }
    [Table("Student")]
    public partial class Student : IEntity
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }

    public class StudentRepository : IRepository<Student>
    {
        Model1 _studentContext;

        public StudentRepository()
        {
            _studentContext= new Model1();
        }
        public IEnumerable<Student> List 
        {
            get 
            {
                return _studentContext.Student;
            }
        }
        public void Add(Student entity)
        {
            _studentContext.Student.Add(entity);
            _studentContext.SaveChanges();
        }
        public void Delete(Student entity)
        {
            _studentContext.Student.Remove(entity);
            _studentContext.SaveChanges();
        }
        public void Update(Student entity)
        {
            _studentContext.Entity(entity).State= System.Data.Entity.EntityState.Modified;

            _studentContext.SaveChanges();
        }
        public Student FindByID(int ID)
        {
            var result = (from r in _studentContext.Student where r.ID == ID select r).FirstOrDefault();
            return result;
        }
        IRepository<Student> repository = new StudentRepository();
        var result=IRepository.List;
        foreach (var r in result)
    {
        Console.WriteLine(r.studentname);
    }
}

