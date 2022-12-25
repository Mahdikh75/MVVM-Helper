# MVVM-Helper
Tools WPF for Pattern MVVM (BaseViewModel &amp; RelayCommand)

// BaseViewModel (Abstract Class / Method Main ---> SetPropertyChange())

 public class MainViewModel : BaseViewModel
 {
  public int ProgressBarValue
   {
       get { return progress_bar; }
       set { progress_bar = value; SetPropertyChange(); }
   }
 }

// RelayCmmand

  private ICommand close;
  public ICommand Close
  {
      get
      {
          if (close == null)
              close = new RelayCommand(MethodClose, CanMethodClose);
          return close;
      }
  }
  private void MethodClose(object obj)
  {
      (obj as Window).Close();
  }
  private bool CanMethodClose(object obj)
  {
      return true;
  }
