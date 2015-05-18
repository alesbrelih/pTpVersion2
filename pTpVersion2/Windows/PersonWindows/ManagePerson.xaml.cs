using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using pTpVersion2.Data.DatabaseModels.ViewModels;
using pTpVersion2.ViewModels.PersonWindowsViewModels;
using ManageType=pTpVersion2.Data.Enums.Enums.ManageType;

namespace pTpVersion2.Windows.PersonWindows
{
    /// <summary>
    /// Interaction logic for ManagePerson.xaml
    /// </summary>
    public partial class ManagePerson : Window
    {
        private ManagePersonViewModel _viewModel;
        public ManagePerson(PersonView person = null,ManageType manageType = ManageType.Create)
        {
            _viewModel = new ManagePersonViewModel(person,manageType);
            this.DataContext = _viewModel;
            InitializeComponent();
        }

        private void BtnContinue_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SaveChanges(this);
        }
    }
}
