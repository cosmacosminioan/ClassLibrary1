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
    [Table("Professor")]
    public partial class Professor : IEntity
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }

    public class ProfessorRepository : IRepository<Professor>
    {
        Model1 _professorContext;

        public ProfessorRepository()
        {
            _professorContext= new Model1();
        }
        public IEnumerable<Professor> List 
        {
            get 
            {
                return _professorContext.Professor;
            }
        }
        public void Add(Professor entity)
        {
            _professorContext.Professor.Add(entity);
            _professorContext.SaveChanges();
        }
        public void Delete(Professor entity)
        {
            _professorContext.Professor.Remove(entity);
            _professorContext.SaveChanges();
        }
        public void Update(Professor entity)
        {
            _professorContext.Entity(entity).State= System.Data.Entity.EntityState.Modified;

            _professorContext.SaveChanges();
        }
        public Professor FindByID(int ID)
        {
            var result = (from r in _professorContext.Professor where r.ID == ID select r).FirstOrDefault();
            return result;
        }
        IRepository<Professor> repository = new ProfessorRepository();
        var result=IRepository.List;
        foreach (var r in result)
    {
        Console.WriteLine(r.professorname);
    }
}



