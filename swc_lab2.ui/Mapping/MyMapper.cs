using AutoMapper;
using swc_lab2.model;
using swc_lab2.ViewModel;

namespace swc_lab2.Mapping;

public class MyMapper
{
    public void Create()
    {
        Mapper.CreateMap<DataModel, DataViewModel>();
        Mapper.CreateMap<DataViewModel, DataModel>();

        Mapper.CreateMap<Book, BookViewModel>();
        Mapper.CreateMap<BookViewModel, Book>();

        Mapper.CreateMap<Employee, EmployeeViewModel>();
        Mapper.CreateMap<EmployeeViewModel, Employee>();
    }
}