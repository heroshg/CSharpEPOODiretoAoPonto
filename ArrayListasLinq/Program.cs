#region LINQ
var students = new List<Student>
{
  new Student(1, "Luís", "12312312312", 100),
  new Student(2, "Roberto", "49853945932", 35),
  new Student(3, "Bianca", "79537295828", 85),
  new Student(4, "Helena", "32421431415", 70),
  new Student(5, "Luís", "32432424244", 75)
};

var any = students.Any();
var any100 = students.Any(s => s.Grade == 100);

var single = students.Single(s => s.Id == 1);
var singleOrDefault = students.SingleOrDefault(s => s.Grade == 0);

var first = students.First(s => s.FullName == "Luís");

var firstOrDefault = students.FirstOrDefault(s => s.Grade == 0);

var orderByGrade = students.OrderBy(s => s.Grade);
var orderedByGradeDescending = students.OrderByDescending(s => s.Grade);

var approvedStudents = students.Where(s => s.Grade >= 70);

var grades = students.Select(s => s.Grade);
var phoneNumber = students.SelectMany(s => s.PhoneNumbers);

var sum = students.Sum(s => s.Grade);
var min = students.Min(s => s.Grade);
var max = students.Max(s => s.Grade);

var count = students.Count();

#endregion

public class Student
{
    public Student(int id, string fullName, string document, int grade)
    {
        Id = id;
        FullName = fullName;
        Document = document;
        Grade = grade;

        PhoneNumbers = new List<string> { "123415636", "523455830", "821435860" };
    }

    public int Id { get; set; }
    public string FullName { get; set; }
    public string Document {  get; set; }
    public int Grade { get; set; }
    public List<string> PhoneNumbers { get; set; }
}