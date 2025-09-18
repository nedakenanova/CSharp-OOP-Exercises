internal class Student
{
    private int _id;
    private string _firstName;
    private string _lastName;
    private string _email;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public string Email
    {
        get => _email;
        set => _email = value;
    }

    public string FullName => $"{FirstName} {LastName}";

    public Student(int id, string firstName, string lastName, string email)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public override string ToString() => $"#{Id} {FullName} <{Email}>";
}
