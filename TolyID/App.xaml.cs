using TolyID.MVVM.View;
namespace TolyID
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabPageFicha();
        }
    }
}
