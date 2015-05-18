using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace pTpVersion2.Data.DatabaseModels.ViewModels
{
    public class PersonView:DependencyObject
    {
        #region dependencyProperty

        private static readonly DependencyProperty PersonIdProperty = DependencyProperty.Register("PersonId",
            typeof (long), typeof (PersonView), null);
        private static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name", typeof (string),
            typeof (PersonView), new PropertyMetadata("/",
                delegate(DependencyObject o, DependencyPropertyChangedEventArgs args)
                {
                    var dpP = o as PersonView;
                    dpP.DisplayName = args.NewValue + " " + dpP.Surname;
                }));

        private static readonly DependencyProperty SurnameProperty = DependencyProperty.Register("Surname",
            typeof (string), typeof (PersonView), new PropertyMetadata("/",
                delegate(DependencyObject o, DependencyPropertyChangedEventArgs args)
                {
                    var dpP = o as PersonView;
                    dpP.DisplayName = dpP.Name + " " + args.NewValue;
                }));

        private static readonly DependencyProperty DisplayNameProperty = DependencyProperty.Register("DisplayName",
            typeof (string), typeof (PersonView), null);

        private static readonly DependencyProperty EmailProperty = DependencyProperty.Register("Email", typeof (string),
            typeof (PersonView), new PropertyMetadata("/"));

        private static readonly DependencyProperty TelephoneProperty = DependencyProperty.Register("Telephone",
            typeof (string), typeof (PersonView), new PropertyMetadata("/"));

        private static readonly DependencyProperty ForeignerProperty = DependencyProperty.Register("Foreigner",
            typeof (bool), typeof (PersonView), new PropertyMetadata(false,
                delegate(DependencyObject o, DependencyPropertyChangedEventArgs args)
                {
                    var dpO = o as PersonView;
                    dpO.ForeignerDisplay = ((bool)args.NewValue) ? "Da" : "Ne";
                }));


        private static readonly DependencyProperty ForeignerDisplayProperty =
            DependencyProperty.Register("ForeignerDisplay", typeof(string), typeof(PersonView),
                new PropertyMetadata("/"));


        #endregion

        #region props

        public long PersonId
        {
            get { return (long) GetValue(PersonIdProperty); }
            set { SetValue(PersonIdProperty,value);}
        }

        public string Name { get { return (string) GetValue(NameProperty); } set{SetValue(NameProperty,value);} }

        public string Surname { get { return (string) GetValue(SurnameProperty); } set{SetValue(SurnameProperty,value);} }

        public string DisplayName { get { return (string) GetValue(DisplayNameProperty); } set{SetValue(DisplayNameProperty,value);} }

        public string Email { get { return (string) GetValue(EmailProperty); } set{SetValue(EmailProperty,value);} }

        public string Telephone { get { return (string) GetValue(TelephoneProperty); } set{SetValue(TelephoneProperty,value);} }

        public bool Foreigner { get { return (bool) GetValue(ForeignerProperty); } set{SetValue(ForeignerProperty,value);} }

        public string ForeignerDisplay { get { return (string) GetValue(ForeignerDisplayProperty); } set{SetValue(ForeignerDisplayProperty,value);} }

        #endregion

        public PersonView()
        {
            
        }
    }
}
