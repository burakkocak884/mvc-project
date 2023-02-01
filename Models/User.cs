namespace mvc_project.Models
{
    public class User
    {
        public int Id {get; set;}
        public string EmailAddress {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Password {get;set;}
        public string SecretQuestionFirst {get; set;}
        public string SecretQuestionSecond {get; set;}        
    }
}