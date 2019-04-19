using System;
//using Fennec.Model.Data.FennecDataSetTableAdapters;

namespace Fennec.Watchers
{
    class SessionLockWatcher
    {
        public SessionLockWatcher()
        {
            Microsoft.Win32.SystemEvents.SessionSwitch += new Microsoft.Win32.SessionSwitchEventHandler(SystemEvents_SessionSwitch);
        }

        private void SystemEvents_SessionSwitch(object sender, Microsoft.Win32.SessionSwitchEventArgs e)
        {
            //tblTimeStampsTableAdapter tblOut = new tblTimeStampsTableAdapter();

            //tblOut.Insert(0, !(e.Reason == Microsoft.Win32.SessionSwitchReason.SessionLock), DateTime.Now);
        }
    }
}