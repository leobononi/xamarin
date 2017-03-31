using MvvmCross.Core.ViewModels;

namespace MobileApp.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private string _firsName;

        private readonly IMvxCommand _goAnotherActivity;

        public FirstViewModel()
        {
            this._goAnotherActivity = new MvxCommand(this.ExecuteGoAnotherActivityCommand, this.CanExecuteGoAnotherActivityCommand);
        }

        public IMvxCommand GoAnotherActivity
        {
            get { return this._goAnotherActivity; }
        }

        private void ExecuteGoAnotherActivityCommand() => ShowViewModel<CalcViewModel>();

        private bool CanExecuteGoAnotherActivityCommand() => FirstName != string.Empty && LastName != string.Empty ;

        public string FirstName
        {
            get { return _firsName; }
            private set
            {
                _firsName = value;
                RaisePropertyChanged(() => FirstName);
                RaisePropertyChanged(() => FullName);
                GoAnotherActivity.RaiseCanExecuteChanged();
            }
        }

        private string _lastName;
         
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                RaisePropertyChanged(() => LastName);
                RaisePropertyChanged(() => FullName);
                GoAnotherActivity.RaiseCanExecuteChanged();
            }
        }

        public string FullName
        {
            get { return ($"String Full name: {FirstName} {LastName}"); }
        }
    }
}
