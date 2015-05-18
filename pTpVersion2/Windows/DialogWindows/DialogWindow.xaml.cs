using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using pTpVersion2.Controls;
using pTpVersion2.ViewModels.DialogWindowViewModels;
using DialogType=pTpVersion2.Data.Enums.Enums.DialogType;
using AppAction = pTpVersion2.Data.Enums.Enums.AppAction;
using AppObject=pTpVersion2.Data.Enums.Enums.AppObject;

namespace pTpVersion2.Windows.DialogWindows
{
    /// <summary>
    /// Interaction logic for DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : CustomDialogWindow
    {
        private DialogWindowViewModel viewModel;
        public DialogWindow(DialogType dialogType = DialogType.YesNoCancel,AppAction appAction = AppAction.Exit,AppObject appObject = AppObject.Application)
        {
            viewModel = new DialogWindowViewModel(dialogType,appAction,appObject);
            this.DataContext = viewModel;


            InitializeComponent();
        }


        private void BtnYes_OnClick(object sender, RoutedEventArgs e)
        {
            //user clicks yes
            viewModel.ClickedYes(this);
        }

        private void BtnNo_OnClick(object sender, RoutedEventArgs e)
        {
            //user clicks no
            viewModel.ClickedNo(this);
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            viewModel.ClickedCancel(this);
        }
    }
}
