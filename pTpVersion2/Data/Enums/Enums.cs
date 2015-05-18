using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pTpVersion2.Data.Enums
{
    public class Enums
    {
        public enum AppAction
        {
            Exit,
            Delete
        }

        public enum AppObject
        {
            Application,
            Person
        }

        public enum DialogType
        {
            Ok,
            YesNo,
            YesNoCancel
        }

        public enum DialogAction
        {
            Yes,
            No,
            Cancel
        }

        public enum SelectionType
        {
            All,
            Bussinesses,
            PotencialCustomerers,
            Persons

        }

        public enum ManageType
        {
            Create,
            Edit,
            Delete
        }
    }
}
