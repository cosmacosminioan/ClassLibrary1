using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Finale 
{
    class IReportStrategy
    {
        public interface IReport 
            PlainText GenerateReport(List<Student.Student> students);
    }
        public interface IReportPublicher
        {
            void Publish(IReportStrategy strategy);
        }
}
}
