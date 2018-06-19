using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
  public class Person : IComparable
  {
    private string identifier;
    private int id;
    private string title;
    private string name;
    private string surname;
    private string schedule;
    private string gender;
    private DateTime dateOfBirth;
    public List<Person> persons = new List<Person>();
    private static DataHandler dh;

    public string Identifier { get => identifier; set => identifier = (value ?? string.Empty).Trim(); }
    public int Id { get => id; set => id = value; }
    public string Title { get => title; set => title = (value ?? string.Empty).Trim(); }
    public string Name { get => name; set => name = (value ?? string.Empty).Trim(); }
    public string Surname { get => surname; set => surname = (value ?? string.Empty).Trim(); }
    public string Schedule { get => schedule; set => schedule = (value ?? string.Empty).Trim(); }
    public string Gender { get => gender; set => gender = (value ?? string.Empty).Trim(); }
    public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

    static Person()
    {
      dh = new DataHandler();
      
    }

    public Person(int id, string identifier, string title, string name, string surname, string schedule, string gender, DateTime dateOfBirth)
    {
      this.Id = id;
      this.Identifier = identifier;
      this.Title = title;
      this.Name = name;
      this.Surname = surname;
      this.Schedule = schedule;
      this.Gender = gender;
      this.DateOfBirth = dateOfBirth;
    }

    public Person() : this("tblPerson")
    {

    }

    private Person(string table) : base()
    {
      foreach (DataRow item in dh.GetData(table).Rows)
      {
        persons.Add(new Person((int)item["PersonId"],
            item["identifier"].ToString(),
            item["title"].ToString(),
            item["name"].ToString(),
            item["surname"].ToString(),
            item["schedule"].ToString(),
            item["gender"].ToString(),
            (DateTime)item["dateOfBirth"]));
      }
    }

    public int CompareTo(object obj)
    {
      Person person = (Person)obj;
      if (this.Identifier.Equals(person.Identifier))
      {
        return this.Id.CompareTo(person.Id);
      }
      return this.Identifier.CompareTo(person.Identifier);
    }
    public bool Insert()
    {
      return dh.Insert(new Dictionary<string, object>
            {
                {"identifier", Identifier },
                {"title", Title },
                {"name", Name },
                {"surname",  Surname},
                {"schedule", Schedule },
                {"gender", Gender },
                {"dateOfBirth", DateOfBirth }
            }, "tblPerson");
    }
    public bool Update(Person person)
    {
      return dh.Update(new Dictionary<string, object>
            {
                {"title", person.Title },
                {"name", person.Name },
                {"surname",  person.Surname},
                {"schedule", person.Schedule },
                {"gender", person.Gender },
                {"dateOfBirth", person.DateOfBirth }
            }, "tblPerson", person.Id.ToString());
    }
    public bool Delete()
    {
      return dh.Delete("tblPerson", Id.ToString());
    }
  }
}
