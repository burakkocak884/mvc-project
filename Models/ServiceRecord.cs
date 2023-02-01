namespace mvc_project.Models
{
    public class ServiceRecord
    {
        public int Id{get; set;}
        public string Date{get; set;}
        public int Mileage{get; set;}
        public string Description{get; set;}
        public int  EstimateCost {get; set;}
        public int UserId {get; set;}

        public int VehicleId {get; set;}

    }
}