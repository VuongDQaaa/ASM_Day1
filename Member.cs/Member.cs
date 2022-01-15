using System;
namespace ASM_day1
{
    internal class Members
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get { return DateOfBirth.Year - DateTime.Now.Year; } }
        public bool IsGraduated { get; set; }
    }
}