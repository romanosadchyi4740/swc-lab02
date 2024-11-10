using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace swc_lab2.ViewModel;

public class DataViewModel : ViewModelBase
{
    public DataViewModel()
    {
        SetControlVisibility = new Command(ControlVisibility);
        EmployeeConsultingCommand = new Command(EmployeeConsulting);
        EmployeeAtRegisterCommand = new Command(EmployeeAtRegister);
        BuyCommand = new Command(Buy);
        SellCommand = new Command(Sell);
    }
    
    private string _visibleControl = "Books";
    public string VisibleControl
    {
        get => _visibleControl;
        set
        {
            _visibleControl = value;
            OnPropertyChanged(nameof(VisibleControl));
        }
    }

    private EmployeeViewModel _selectedEmployee;
    public EmployeeViewModel SelectedEmployee
    {
        get => _selectedEmployee;
        set
        {
            _selectedEmployee = value;
            OnPropertyChanged(nameof(SelectedEmployee));
        }
    }

	private BookViewModel _selectedBook;
	public BookViewModel SelectedBook
	{
		get => _selectedBook;
		set
		{
			_selectedBook = value;
			OnPropertyChanged(nameof(SelectedBook));
		}
	}

	public ICommand SetControlVisibility { get; set; }
    
    public void ControlVisibility(object args)
    {
        VisibleControl = args.ToString();
    }

    public ICommand EmployeeConsultingCommand { get; set; }

    public void EmployeeConsulting(object args)
    {
        SelectedEmployee.IsAtRegister = false;
    }

	public ICommand EmployeeAtRegisterCommand { get; set; }

	public void EmployeeAtRegister(object args)
	{
		SelectedEmployee.IsAtRegister = true;
	}

    public ICommand BuyCommand { get; set; }

    public void Buy(object args)
    {
        MoneyAmount -= MoneyAmount >= SelectedBook.PurchasePrice ? SelectedBook.PurchasePrice : 0;
    }

	public ICommand SellCommand { get; set; }

	public void Sell(object args)
	{
		MoneyAmount += SelectedBook.SellingPrice;
	}

	private EmployeeViewModel _selectedResponse;
    public EmployeeViewModel SelectedResponse
    {
        get => _selectedResponse;
        set
        {
            _selectedResponse = value;
            OnPropertyChanged(nameof(SelectedResponse));
        }
    }

    private ObservableCollection<BookViewModel> _books;
    public ObservableCollection<BookViewModel> Books
    {
        get => _books;
        set
        {
            _books = value;
            OnPropertyChanged(nameof(Books));
        }
    }
    
    private ObservableCollection<EmployeeViewModel> _employees;
    public ObservableCollection<EmployeeViewModel> Employees
    {
        get => _employees;
        set
        {
            _employees = value;
            OnPropertyChanged(nameof(Employees));
        }
    }

    private int _moneyAmount;
    public int MoneyAmount
    {
        get => _moneyAmount;
        set
        {
            _moneyAmount = value;
            OnPropertyChanged(nameof(MoneyAmount));
        }
    }
}