namespace swc_lab2.ViewModel;

public class EmployeeViewModel : ViewModelBase
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

    private string _firstName;
    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            OnPropertyChanged(nameof(FirstName));
        }
    }

    private string _lastName;
    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            OnPropertyChanged(nameof(LastName));
        }
    }

	private string _email;
    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            OnPropertyChanged(nameof(Email));
        }
    }
    
    private int _salary;
    public int Salary
    {
        get => _salary;
        set
        {
            _salary = value;
            OnPropertyChanged(nameof(Salary));
        }
    }

    private bool _isAtRegister;
    public bool IsAtRegister
    {
        get => _isAtRegister;
        set
        {
            _isAtRegister = value;
            OnPropertyChanged(nameof(IsAtRegister));
        }
    }
}