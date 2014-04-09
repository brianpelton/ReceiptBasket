using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ReceiptBasket.ViewModel
{
    public abstract class ViewModelBase : NotifyPropertyChangedBase
    {
        #region [ Logging ]

        private static readonly log4net.ILog Log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        #region [ Constructors ]

        protected ViewModelBase()
        {
            BusyNames = new List<string>();
        }

        #endregion

        #region [ Properties ]

        protected List<string> BusyNames { get; set; }


        public bool IsBusy
        {
            get { return BusyNames.Count != 0; }
        }

        #endregion

        #region [ Public Methods ]

        public void Busy([CallerMemberName] string name = null)
        {
            BusyBy(name);
        }

        public void BusyBy(string name = null)
        {
            if (BusyNames.Contains(name))
            {
                Log.DebugFormat("IsBusyBy: {0} (dup)", name);
                return;
            }

            Log.DebugFormat("IsBusyBy: {0}", name);
            BusyNames.Add(name);
            RaisePropertyChangedFor("IsBusy");
        }

        public void NotBusy([CallerMemberName] string name = null)
        {
            NotBusyBy(name);
        }

        public void NotBusyBy(string name)
        {
            if (!BusyNames.Contains(name))
            {
                Log.WarnFormat("NotBusyBy: {0} (Wasn't marked as using view model.)", name);
                return;
            }

            Log.DebugFormat("NotBusyBy: {0}", name);
            BusyNames.Remove(name);
            RaisePropertyChangedFor("IsBusy");
        }

        #endregion
    }
}