using System.Windows.Input;
using ReactiveUI;

namespace AvaloniaApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int count;

        public int Count
        {
            get => count;
            set => this.RaiseAndSetIfChanged(ref count, value);
        }

        public ICommand CountCommand { get; private set; }


        public MainWindowViewModel()
        {
            CountCommand = ReactiveCommand.Create((() => { Count++; }));
        }
    }
}
