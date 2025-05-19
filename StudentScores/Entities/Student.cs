namespace StudentScores.Entities
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} - {this.Grade} - {this.Department}";
        }
    }
}
