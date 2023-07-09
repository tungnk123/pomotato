using pomotato.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace pomotato.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand CountDownCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void CountDown(object obj) => CurrentView = new CountDownVM();

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            CountDownCommand = new RelayCommand(CountDown);

            // Startup Page
            CurrentView = new HomeVM();
        }
    }
}
