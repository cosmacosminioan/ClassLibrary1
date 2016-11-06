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
    [Table("GradeReport")]
    public partial class GradeReport : IEntity
    {
        public int ID { get; set; }

        [Required]
        public string gradeReport { get; set; }
    }

    public class GradeReportRepository : IRepository<Student>
    {
        Model1 _gradereportContext;

        public GradeReportRepository()
        {
            _gradereportContext= new Model1();
        }
        public IEnumerable<GradeReport> List 
        {
            get 
            {
                return _gradereportContext.GradeReport;
            }
        }
        public void Add(GradeReport entity)
        {
            _studentContext.Student.Add(entity);
            _studentContext.SaveChanges();
        }
        public void Delete(Student entity)
        {
            _gradereportContext.GradeReport.Remove(entity);
            _gradereportContext.SaveChanges();
        }
        public void Update(GradeReport entity)
        {
            _gradereportContext.Entity(entity).State= System.Data.Entity.EntityState.Modified;

            _gradereportContext.SaveChanges();
        }
        public GradeReport FindByID(int ID)
        {
            var result = (from r in _gradereportContext.GradeReport where r.ID == ID select r).FirstOrDefault();
            return result;
        }
        IRepository<GradeReport> repository = new GradeReportRepository();
        var result=IRepository.List;
        foreach (var r in result)
    {
        Console.WriteLine(r.gradereport);
    }
}