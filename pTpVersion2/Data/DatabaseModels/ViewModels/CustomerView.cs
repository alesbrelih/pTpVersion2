using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using pTpVersion2.DbCommunication;

namespace pTpVersion2.Data.DatabaseModels.ViewModels
{
    public class CustomerView:DependencyObject
    {
        #region dependencyProperties

        private static readonly DependencyProperty CustomerIdProperty = DependencyProperty.Register("CustomerId", typeof (int),
            typeof (CustomerView), new PropertyMetadata(-1));

        private static readonly DependencyProperty PersonIdProperty = DependencyProperty.Register("PersonId",
            typeof (int?), typeof (CustomerView), new PropertyMetadata(null,
                delegate(DependencyObject o, DependencyPropertyChangedEventArgs args)
                {
                    var dpP = o as CustomerView;
                    dpP.Person = ManagePersons.FindPerson((int?) args.NewValue);
                } ));

        private static readonly DependencyProperty PersonProperty = DependencyProperty.Register("Person",
            typeof (PersonView), typeof (CustomerView), null);
        
        
        
        
        
        
        private static readonly DependencyProperty FirmIdProperty = DependencyProperty.Register("FirmId", typeof (int?),
            typeof (CustomerView), new PropertyMetadata(-1,
                delegate(DependencyObject o, DependencyPropertyChangedEventArgs args)
                {
                    var dpP = o as CustomerView;
                    dpP.Firm = ManageFirms.ReturnFirm((int) args.NewValue);
                }));

        private static readonly DependencyProperty FirmProperty = DependencyProperty.Register("Firm", typeof (FirmView),
            typeof (CustomerView), null );

        public int CustomerId { get { return (int) GetValue(CustomerIdProperty); } set{SetValue(CustomerIdProperty,value);} }

        public int? PersonId { get { return (int?) GetValue(PersonIdProperty); } set{SetValue(PersonIdProperty,value);} }

        public PersonView Person { get { return (PersonView) GetValue(PersonProperty); } set{SetValue(PersonProperty,value);} }
        
        public int? FirmId { get { return (int) GetValue(FirmIdProperty); } set{SetValue(FirmIdProperty,value);} }

        public FirmView Firm {
            get
            {
                return (FirmView) GetValue(FirmProperty);
                
            }
            set
                {
                    SetValue(FirmProperty, value);
                }
        } 
        #endregion



    }
}
