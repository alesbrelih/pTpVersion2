using System.Windows;
using System.Windows.Controls;
using pTpVersion2.Data.Enums;
using pTpVersion2.ViewModels.MainWindowViewModels;
using pTpVersion2.Windows.DialogWindows;

namespace pTpVersion2.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PtpMainWindowViewModel _viewModel;
        public MainWindow()
        {
            _viewModel = new PtpMainWindowViewModel();
            this.DataContext = _viewModel;
            InitializeComponent();
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            var neki = new DialogWindow(Enums.DialogType.YesNo);
            neki.ShowDialog();
            switch (neki.DialogAction)
            {
                    case Enums.DialogAction.Yes:
                    this.Close();
                    break;
                    
            }
        }

        private void BtnCreate_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.AddNewEntry();
        }


        private void TControlDataDisplay_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.TabChanged(TControlDataDisplay.SelectedIndex);
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.EditEntry();
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.DeleteEntry();
        }
    }
}
