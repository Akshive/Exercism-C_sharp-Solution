using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    List<Student> students = new List<Student>();
    public void Add(string student, int grade)
    {
        students.Add(new Student(student, grade));
    }

    public IEnumerable<string> Roster()
    {
        students.Sort();
        var res = students.Select(student => student.name);
        return res;
    }

    public IEnumerable<string> Grade(int grade)
    {
        students.Sort();
        var res = students.Where(student => student.std == grade).Select(student => student.name);
        return res;
    }
}

public class Student : IComparable<Student>
{
    public string name
    {get; set;}
    public int std
    {get; set;}
    public Student(string name, int std)
    {
        this.name = name;
        this.std = std;
    }
    public int CompareTo(Student s)
    {
        if(this.std < s.std)return -1;
        else if(this.std == s.std)
        {
            if(string.Compare(this.name, s.name) < 0)return -1;
        }
        return 1;
    }
}