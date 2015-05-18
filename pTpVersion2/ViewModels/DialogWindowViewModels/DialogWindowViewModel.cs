using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using pTpVersion2.Data.Enums;
using AppAction=pTpVersion2.Data.Enums.Enums.AppAction;
using AppObject=pTpVersion2.Data.Enums.Enums.AppObject;
using DialogType=pTpVersion2.Data.Enums.Enums.DialogType;
using DialogAction = pTpVersion2.Data.Enums.Enums.DialogAction;

namespace pTpVersion2.ViewModels.DialogWindowViewModels
{
    public class DialogWindowViewModel:DependencyObject
    {
        #region dependencyProperties
        //dialog messages
        private static readonly DependencyProperty HeaderLabelProperty = DependencyProperty.Register("HeaderLabel",
            typeof (string), typeof (DialogWindowViewModel), null);

        private static readonly DependencyProperty MessageLabelProperty = DependencyProperty.Register("MessageLabel",
            typeof (string), typeof (DialogWindowViewModel), null);


        //buttons visibility
        private static readonly DependencyProperty BtnYesVisibilityProperty = DependencyProperty.Register("BtnYesVisibility",
            typeof (Visibility), typeof (DialogWindowViewModel), new PropertyMetadata(Visibility.Visible));

        private static readonly DependencyProperty BtnNoVisibilityProperty =
            DependencyProperty.Register("BtnNoVisibility", typeof(Visibility), typeof(DialogWindowViewModel), new PropertyMetadata(Visibility.Visible));

        private static readonly DependencyProperty BtnCancelVisibilityProperty =
            DependencyProperty.Register("BtnCancelVisibility", typeof(Visibility), typeof(DialogWindowViewModel), new PropertyMetadata(Visibility.Visible));


        #endregion

        #region props
        //dialog messages
        public string HeaderLabel { get { return (string) GetValue(HeaderLabelProperty); } set{SetValue(HeaderLabelProperty,value);} }
        public string MessageLabel { get { return (string) GetValue(MessageLabelProperty); } set{SetValue(MessageLabelProperty,value);} }

        //buttons visiblity
        public Visibility BtnYesVisibility { get { return (Visibility) GetValue(BtnYesVisibilityProperty); } set{SetValue(BtnYesVisibilityProperty,value);} }
        public Visibility BtnNoVisibility { get { return (Visibility) GetValue(BtnNoVisibilityProperty); } set{SetValue(BtnNoVisibilityProperty,value);} }
        public Visibility BtnCancelVisibility { get { return (Visibility) GetValue(BtnCancelVisibilityProperty); } set{SetValue(BtnCancelVisibilityProperty,value);} }
        #endregion

        #region constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dialogType">yesnocancel dialog, yes no dialog...</param>
        /// <param name="appAction">exit,delete,...</param>
        /// <param name="appObject">application,person,...</param>
        public DialogWindowViewModel(DialogType dialogType,AppAction appAction, AppObject appObject)
        {
            SwitchDialogType(dialogType);

            if (appAction == AppAction.Exit)
            {
                if (appObject == AppObject.Application)
                {
                    HeaderLabel = "Izhod";
                    MessageLabel = "Ali želite zapustiti program?";
                }
            }
            if (appAction == AppAction.Delete)
            {
                if (appObject == AppObject.Person)
                {
                    HeaderLabel = "Brisanje";
                    MessageLabel = "Ali želite izbrisati izbrano osebo?";
                }
            }
        }

       

        private void SwitchDialogType(DialogType dialogType)
        {
            switch (dialogType)
            {
                case DialogType.YesNo:
                    BtnCancelVisibility = Visibility.Collapsed;
                    break;
            }
        }

        #endregion


        internal void ClickedYes(Windows.DialogWindows.DialogWindow dialogWindow)
        {
            dialogWindow.DialogAction = DialogAction.Yes;
            dialogWindow.Close();
        }

        internal void ClickedNo(Windows.DialogWindows.DialogWindow dialogWindow)
        {
            dialogWindow.DialogAction = DialogAction.No;
            dialogWindow.Close();
        }

        internal void ClickedCancel(Windows.DialogWindows.DialogWindow dialogWindow)
        {
            dialogWindow.DialogAction = DialogAction.Cancel;
            dialogWindow.Close();
        }
    }
}
