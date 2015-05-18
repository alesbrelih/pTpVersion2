using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using pTpVersion2.Data.DatabaseModels;
using pTpVersion2.Data.DatabaseModels.ViewModels;
using pTpVersion2.Data.Enums;
using pTpVersion2.DbCommunication;
using pTpVersion2.Windows.DialogWindows;
using pTpVersion2.Windows.FirmWindows;
using pTpVersion2.Windows.PersonWindows;
using SelectionType=pTpVersion2.Data.Enums.Enums.SelectionType;
using ManageType=pTpVersion2.Data.Enums.Enums.ManageType;
using AppAction=pTpVersion2.Data.Enums.Enums.AppAction;
using AppObject=pTpVersion2.Data.Enums.Enums.AppObject;

namespace pTpVersion2.ViewModels.MainWindowViewModels
{
    public class PtpMainWindowViewModel:DependencyObject
    {
        #region dependencyProperties
        #region personTab
        private static readonly DependencyProperty SelectedPersonProperty = DependencyProperty.Register(
            "SelectedPerson", typeof (PersonView), typeof (PtpMainWindowViewModel), null);

        private static readonly DependencyProperty PersonsProperty = DependencyProperty.Register("Persons",
            typeof (ObservableCollection<PersonView>), typeof (PtpMainWindowViewModel),null);

        private static readonly DependencyProperty SelectedPersonIndexProperty =
            DependencyProperty.Register("SelectedPersonIndex", typeof(int), typeof(PtpMainWindowViewModel), null);
        #endregion
        #region firmTab

        private static readonly DependencyProperty CustomersProperty = DependencyProperty.Register("Customers",
            typeof (IList), typeof (PtpMainWindowViewModel), null);

        private static readonly DependencyProperty FirmsProperty = DependencyProperty.Register("Firms", typeof (List<CustomerView>),
            typeof (PtpMainWindowViewModel), null);
        #endregion
        private static readonly DependencyProperty SelectionTypeProperty = DependencyProperty.Register("SelectionType",
            typeof (SelectionType), typeof (PtpMainWindowViewModel), new PropertyMetadata(SelectionType.All));
        #endregion

        private static readonly DependencyProperty SelectedFirmProperty = DependencyProperty.Register("SelectedFirm",
            typeof (CustomerView), typeof (PtpMainWindowViewModel), null);
        public SelectionType SelectionType { get { return (SelectionType) GetValue(SelectionTypeProperty); } set{SetValue(SelectionTypeProperty,value);} }

        public ObservableCollection<PersonView> Persons { get { return (ObservableCollection<PersonView>)GetValue(PersonsProperty); } set{SetValue(PersonsProperty,value);} }

        public PersonView SelectedPerson { get { return (PersonView) GetValue(SelectedPersonProperty); } set{SetValue(SelectedPersonProperty,value);} }

        public int SelectedPersonIndex { get { return (int) GetValue(SelectedPersonIndexProperty); } set{SetValue(SelectedPersonIndexProperty,value);} }

        public CustomerView SelectedFirm { get { return (CustomerView) GetValue(SelectedFirmProperty); } set{SetValue(SelectedFirmProperty,value);} }

        public List<CustomerView> Firms { get { return (List<CustomerView>) GetValue(FirmsProperty); } set{SetValue(FirmsProperty,value);} }    

        public IList Customers { get { return (IList) GetValue(CustomersProperty); } set
        {
            SetValue(CustomersProperty, value);
        } }


        public PtpMainWindowViewModel()
        {
            FillPersons();
            //FillCustomers();
            FillFirms();

        }

        private void FillFirms()
        {
            Firms = ManageFirms.ReturnFirms();
        }

        private void FillCustomers()
        {
            Customers = ManageCustomers.ReturnCustomers();
        }

        //fills persons
        private void FillPersons()
        {
            Persons = ManagePersons.ReturnPersons();
        }

        internal void AddNewEntry()
        {
            switch (SelectionType)
            {
                case SelectionType.All:
                    break;
                case SelectionType.Bussinesses:
                    var newFirm = new ManageFirm();
                    newFirm.ShowDialog();
                    break;
                case SelectionType.Persons:
                    //add new person
                    var newPerson = new ManagePerson();
                    newPerson.ShowDialog();
                    Persons = ManagePersons.ReturnPersons();
                    break;
            }
            }
            

        //tab changed
        internal void TabChanged(int tabIndex)
        {
            switch (tabIndex)
            {
                case 0:
                    SelectionType=SelectionType.All;
                    break;
                case 1:
                    SelectionType = SelectionType.Bussinesses;
                    break;
                case 2:
                    SelectionType=SelectionType.PotencialCustomerers;
                    break;
                case 3:
                    SelectionType=SelectionType.Persons;
                    break;
            }
        }

        internal void EditEntry()
        {
            switch (SelectionType)
            {
                case SelectionType.Persons:
                    var editPerson = new ManagePerson(SelectedPerson,ManageType.Edit);
                    editPerson.ShowDialog();
                    break;
            }
        }

        internal void DeleteEntry()
        {
            switch (SelectionType)
            {
                case SelectionType.Persons:
                    var confirmationWindow = new DialogWindow(Enums.DialogType.YesNo,AppAction.Delete,AppObject.Person);
                    confirmationWindow.ShowDialog();
                    if (confirmationWindow.DialogAction == Enums.DialogAction.Yes)
                    {
                        
                        ManagePersons.DeletePerson(SelectedPerson);
                        SelectedPersonIndex = -1;
                        Persons = ManagePersons.ReturnPersons();
                        SelectedPerson = null;
                    }
                    break;
            }
        }
    }
}
