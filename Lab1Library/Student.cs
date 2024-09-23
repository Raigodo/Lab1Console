namespace Lab1Library;

[Serializable]
public class Student
{

    /// <summary>
    /// Studenta apliecības numurs.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Studenta vārds.
    /// </summary>
    /* Vizuālā programmēšana, G. Alksnis, 2015, r162 */ /* 12 */
    public string Name { get; set; }

    /// <summary>
    /// Studenta uzvārds.
    /// </summary>
    public string Surname { get; set; }

    public string Group { get; set; }
    public string Email { get; set; }
    /// <summary>
    /// Konstruktors, kas nepieciešams atribūtam [Serializable]
    /// </summary>
    private Student() { }
    /// <summary>
    /// Konstruktors, kas inicializē klases īpašības.
    /// </summary>
    public Student(string name, string surname, string email, string id, string group)
    {
        //ja kāds no parametriem ir tukša virkne, izraisīt izņēmumu
        if (name.Length == 0 || surname.Length == 0 || id.Length == 0)
            throw new Exception("Invalid student data !");
        this.Name = name;
        this.Surname = surname;
        Email = email;
        this.Id = id;
        Group = group;
    }
    /// <summary>
    // Teksta virknes formā atgriež klases īpašību vērtības.
    /// </summary>
    public override string ToString()
    {
        return $"{Id} : {Name} {Surname} {Email} {Group}";
    }
}