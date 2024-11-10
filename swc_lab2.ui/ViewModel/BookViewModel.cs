namespace swc_lab2.ViewModel;

public class BookViewModel : ViewModelBase
{
	private int _id;
    public int Id
    {
        get => _id;
        set
        {
            _id = value;
            OnPropertyChanged(nameof(Id));
        }
    }

    private string _title;
    public string Title
    {
        get => _title;
        set
        {
            _title = value;
			OnPropertyChanged(nameof(Title));
        }
    }

    private string _author;
    public string Author
    {
        get => _author;
        set
        {
            _author = value;
			OnPropertyChanged(nameof(Author));
        }
    }
    
    private int _sellingPrice;
    public int SellingPrice
    {
        get => _sellingPrice;
        set
        {
            _sellingPrice = value;
			OnPropertyChanged(nameof(SellingPrice));
        }
    }
    
    private int _purchasePrice;
    public int PurchasePrice
    {
        get => _purchasePrice;
        set
        {
            _purchasePrice = value;
			OnPropertyChanged(nameof(PurchasePrice));
        }
    }
}