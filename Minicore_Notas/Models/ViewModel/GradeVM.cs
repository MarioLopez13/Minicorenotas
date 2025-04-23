using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Minicore_Notas.Data;

namespace Minicore_Notas.Models.ViewModel
{
    public class GradeVM
    {
        public Dictionary<int, double[]> Promedios { get; set; }
        public Grade Grade { get; set; }
        public Student Student { get; set; }
        public Period Period { get; set; }

        [ValidateNever]
        public List<Grade> GradesList { get; set; }

        [ValidateNever]
        public List<Student> StudentsList { get; set; }

        [ValidateNever]
        public List<Period> PeriodsList { get; set; }

        public DateTime Start { get; set; } = new DateTime(2023, 9, 27);
        public DateTime End { get; set; } = new DateTime(2024, 1, 30);
    }

}
