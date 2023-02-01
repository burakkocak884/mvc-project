

namespace mvc_project.Models
{
    public class ServiceRecordHistory
    {
        public int Id {get; set;}
        public string Date {get; set;}
        public int Year {get;set;}
        public string Make {get;set;}
        public string Model {get;set;}
        public int Mileage {get; set;}
        public string Description {get; set;}
        
        public int EstimateCost{ get; set;}

    }
}