/*
 9. Working with Collections
Question: Create a List<Student> where each student has Name and Grade properties. 
Sort the list by grade in descending order and display the result. 
Also, filter students whose grade is above 80.
 */

List<string> studentFirstNames = "Isaac|Earnest|Marie|Grace|Albert|William|Michael|James|Ada".Split('|').ToList();
List<string> studentLastNames = "Newton|Rutherford|Curie|Hopper|Einstein|Shockley|Faraday|Watt|Lovelace".Split('|').ToList();
List<Student> testStudents = [];
var rnd = new Random();

for(int i =  0; i < 100; i++)
{
    testStudents.Add(new Student { Grade = rnd.Next(0, 100), Name = $"{studentFirstNames[rnd.Next(studentFirstNames.Count() -1)]} {studentLastNames[rnd.Next(studentLastNames.Count() - 1)]}" });
}

var res = testStudents.Where(s => s.Grade > 80).OrderByDescending(s => s.Grade).ToList();
Log.PrintCollectionInColumns<Student>(res);

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}