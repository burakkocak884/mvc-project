using System.Collections.Generic;
namespace mvc_project.Models
{
    public class Car
    {
        public int Id {get; set;}
        public string VIN {get; set;}
        public int Year {get; set;}
        public string Make {get; set;}
        public string Model {get; set;} 
        public string Trim {get; set;}
        public string EngineSize {get; set;}
        public string DriveTrain {get; set;}
        public string Color {get; set;}
        public string BodyStyle {get ; set;}
        public int UserId {get; set;}
    }
}