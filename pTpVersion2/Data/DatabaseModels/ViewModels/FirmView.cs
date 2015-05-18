using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using pTpVersion2.DbCommunication;

namespace pTpVersion2.Data.DatabaseModels.ViewModels
{
    public class FirmView:DependencyObject
    {
        #region dependencyProperties

        private static readonly DependencyProperty FirmIdProperty = DependencyProperty.Register("FirmId", typeof (int),
            typeof (FirmView), null);

        private static readonly DependencyProperty FirmNameProperty = DependencyProperty.Register("FirmName",
            typeof (string), typeof (FirmView), null);

        private static readonly DependencyProperty PersonIdProperty = DependencyProperty.Register("PersonId",
            typeof (int), typeof (FirmView), new PropertyMetadata(null,
                delegate(DependencyObject o, DependencyPropertyChangedEventArgs args)
                {
                    var dpP = o as FirmView;
                    dpP.Person = ManagePersons.FindPerson((int)args.NewValue);
                }));

        private static readonly DependencyProperty PersonProperty = DependencyProperty.Register("Person",
            typeof (PersonView), typeof (FirmView), null);



        #endregion
        #region props

        public int FirmId { get { return (int) GetValue(FirmIdProperty); } set{SetValue(FirmIdProperty,value);}}

        public string FirmName { get { return ((string) GetValue(FirmNameProperty)); } set{SetValue(FirmNameProperty,value);} }

        public int PersonId { get { return ((int) GetValue(PersonIdProperty)); } set{SetValue(PersonIdProperty,value);} }

        public PersonView Person { get {return ((PersonView) GetValue(PersonProperty)); } set{SetValue(PersonProperty,value);} }

        #endregion
    }
}
