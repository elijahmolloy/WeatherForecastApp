using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WeatherForecastApp.ViewModels.Base;

public abstract class BaseViewModel : ObservableObject, INotifyPropertyChanged, INotifyPropertyChanging
{

}
