public class Book : Author
{
    string? _name;
    Author _author;
    double _price;
    int _qty;
    public Book (string name, string email, char gender, string bookname, Author author, double price, int qty ):base(name,email,gender)
    {
        _name = bookname;
        _author = author;
        _price = price;
        _qty = qty;
    }
    public string GetName()
    {
        return _name;
    }
    public Author GetAuthor()
    {
        return _author;
    }
    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
    public int GetQty()
    {
        return _qty;
    }
    public void SetQty(int qty)
    {
        _qty = qty;
    }
    public override string ToString()
    {
        return $"\'{_name}\' by {base.ToString()}";
    }
}