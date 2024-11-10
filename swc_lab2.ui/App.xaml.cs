using AutoMapper;
using swc_lab2.model;
using swc_lab2.ViewModel;
using System.Configuration;
using System.Data;
using System.Windows;
using swc_lab2.Mapping;

namespace swc_lab2;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private DataModel _model;
    private DataViewModel _viewModel;

    public App()
    {
        new MyMapper().Create();

        _model = DataModel.Load();
        _viewModel = Mapper.Map<DataModel, DataViewModel>(_model);

        var window = new MainWindow() { DataContext = _viewModel };
        window.Show();
    }
}