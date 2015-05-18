using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using pTpVersion2.Data.Enums;
using DialogAction = pTpVersion2.Data.Enums.Enums.DialogAction;

namespace pTpVersion2.Controls
{
    public class CustomDialogWindow : Window
    {
        private static readonly DependencyProperty DialogActionProperty =
            DependencyProperty.Register("DialogAction", typeof (DialogAction), typeof (CustomDialogWindow), null);

        public DialogAction DialogAction
        {
            get { return (DialogAction) GetValue(DialogActionProperty); }
            set { SetValue(DialogActionProperty, value); }
        }
    }
}
