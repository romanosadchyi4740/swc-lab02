namespace swc_lab2.model;

public class DataModel
{
    public IEnumerable<Book> Books { get; set; }
    public IEnumerable<Employee> Employees { get; set; }
    public int MoneyAmount { get; set; }

    public DataModel()
    {
		Books = new List<Book>
        {
			new() { Id = 1, Title = "Some title", Author = "Some author", SellingPrice = 120, PurchasePrice = 100 },
        };
        Employees = new List<Employee>
        {
			new() { Id = 1, FirstName = "Firstname", LastName = "Lastname", Email = "user@gmail.com", Salary = 349 },
        };
    }

    public static DataModel Load()
    {
        return new DataModel();
    }
}