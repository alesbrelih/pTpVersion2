using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using pTpVersion2.Data.DatabaseModels.ViewModels;
using pTpVersion2.Data.Enums;
using pTpVersion2.DbCommunication;
using ManageType=pTpVersion2.Data.Enums.Enums.ManageType;

namespace pTpVersion2.ViewModels.PersonWindowsViewModels
{
    public class ManagePersonViewModel:DependencyObject
    {
        private static readonly DependencyProperty PersonProperty = DependencyProperty.Register(
            "Person", typeof (PersonView), typeof (ManagePersonViewModel), null);

        private static readonly DependencyProperty ManageTypeProperty = DependencyProperty.Register("ManageType",
            typeof (ManageType), typeof (ManagePersonViewModel), null);



        public ManageType ManageType
        {
            get
            {
                return (ManageType) GetValue(ManageTypeProperty);
            }
            set
            {
                SetValue(ManageTypeProperty,value);
            }
        }

        public PersonView Person
        {
            get { return (PersonView) GetValue(PersonProperty); }
            set { SetValue(PersonProperty, value); }
        }

        public ObservableCollection<PersonView> Persons { get; set; }
        public ManagePersonViewModel(PersonView person, ManageType manageType)
        {
            if (person == null)
            {
                Person = new PersonView();
            }
            else
            {
                Person = person;
            }

            ManageType = manageType;  //set manage type
        }

        internal void SaveChanges(Windows.PersonWindows.ManagePerson managePerson)
        {
            switch (ManageType)
            {
                case ManageType.Create:
                    ManagePersons.AddPerson(Person);
                    break;
                case ManageType.Edit:
                    ManagePersons.EditPerson(Person);
                    break;
            }
            managePerson.Close();
            
        }
    }
}
