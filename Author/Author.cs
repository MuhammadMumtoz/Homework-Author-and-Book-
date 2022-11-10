public class Author
{
    string? _name;
    string? _email;
    char _gender;
    public Author(string name, string email, char gender)
    {
        _name = name;
        _email = email;
        _gender = gender;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetEmail()
    {
        return _email;
    }
    public void SetEmail(string email)
    {
        _email = email;
    }
    public char GetGender()
    {
        return _gender;
    }
    public override string ToString()
    {
        return $"{_name} ({_gender}) at {_email}";
    }

}