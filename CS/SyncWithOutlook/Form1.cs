using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Exchange;
using DevExpress.XtraScheduler.Outlook;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SyncWithOutlook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        // Specify the name of the property of the custom object (or the name of the data field in the data record if the scheduler storage is bound to the data source)
        // containing ID of the foreign object - in this example it is the Outlook entry ID.
        // In this example the custom object is the CustomAppointment instance that have the OutlookID property.
        // This name is also specified for the AppointmentSynchronizer.ForeignIdFieldName property.
        // The value of the field with that name can be obtained using the Appointment.GetValue method.
        private const string OutlookEntryIDFieldName = "OutlookID";

        SyncronizationOptionForm optionsForm = new SyncronizationOptionForm();
        public static Random RandomInstance = new Random();
        private BindingList<CustomAppointment> CustomEventList = new BindingList<CustomAppointment>();

        private void Form1_Load(object sender, EventArgs e) {
            InitAppointments();
            schedulerControl1.Start = DateTime.Now;
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            schedulerControl1.ActiveViewType = SchedulerViewType.Day;

            // Obtain the names of MS Outlook calendars. 
            comboBoxEdit1.Properties.Items.AddRange(OutlookExchangeHelper.GetOutlookCalendarPaths());

            SyncronizationOptionForm.AllowCreateAppointmentInOutlook = true;
            SyncronizationOptionForm.AllowCreateAppointmentInScheduler = true;
            SyncronizationOptionForm.AllowRemoveAppointmentInOutlook = true;
            SyncronizationOptionForm.AllowRemoveAppointmentInScheduler = true;
            SyncronizationOptionForm.AllowUpdateAppointmentInOutlook = true;
            SyncronizationOptionForm.AllowUpdateAppointmentInScheduler = true;
        }

        // Scheduler --> Outlook
        private void btnSchedulerOutlook_Click(object sender, EventArgs e) {
            if(comboBoxEdit1.EditValue != null)
            {
                #region #scheduler->outlook
                AppointmentExportSynchronizer synchronizer = schedulerControl1.Storage.CreateOutlookExportSynchronizer();
                // Specify the field that contains appointment identifier used by a third-party application.
                synchronizer.ForeignIdFieldName = OutlookEntryIDFieldName;
                // The AppointmentSynchronizing event allows you to control the operation for an individual appointment.
                synchronizer.AppointmentSynchronizing += new AppointmentSynchronizingEventHandler(exportSynchronizer_AppointmentSynchronizing);
                // The AppointmentSynchronized event indicates that the operation for a particular appointment is complete.
                synchronizer.AppointmentSynchronized += new AppointmentSynchronizedEventHandler(exportSynchronizer_AppointmentSynchronized);
                // Specify MS Outlook calendar path.
                ((ISupportCalendarFolders)synchronizer).CalendarFolderName = comboBoxEdit1.EditValue.ToString();
                // Perform the operation.
                synchronizer.Synchronize();
                #endregion #scheduler->outlook
                memoEdit1.Text += "\r\n Export is done.\r\n\r\n";
            }
            else {
                MessageBox.Show("Please select an Outlook folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        void exportSynchronizer_AppointmentSynchronizing(object sender, AppointmentSynchronizingEventArgs e)
        {
            AnalyzeAndHandleCurrentOperation(e as DevExpress.XtraScheduler.Outlook.OutlookAppointmentSynchronizingEventArgs, false);
        }
 
        // Outlook --> Scheduler
        private void btnOutlookScheduler_Click(object sender, EventArgs e) {
            if(comboBoxEdit1.EditValue != null)
            {
                #region #outlook->scheduler
                AppointmentImportSynchronizer synchronizer = schedulerControl1.Storage.CreateOutlookImportSynchronizer();
                // Specify the field that contains appointment identifier used by a third-party application.
                synchronizer.ForeignIdFieldName = OutlookEntryIDFieldName;
                // The AppointmentSynchronizing event allows you to control the operation for an individual appointment.
                synchronizer.AppointmentSynchronizing += new AppointmentSynchronizingEventHandler(importSynchronizer_AppointmentSynchronizing);
                // The AppointmentSynchronized event indicates that the operation for a particular appointment is complete.
                synchronizer.AppointmentSynchronized += new AppointmentSynchronizedEventHandler(importSynchronizer_AppointmentSynchronized);
                // Specify MS Outlook calendar path.
                ((ISupportCalendarFolders)synchronizer).CalendarFolderName = comboBoxEdit1.EditValue.ToString();
                // Perform the operation.
                synchronizer.Synchronize();
                #endregion #outlook->scheduler
                memoEdit1.Text += "\r\n Import is done.\r\n\r\n";
            }
            else {
                MessageBox.Show("Please select an Outlook folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);            
            }
        }

        void importSynchronizer_AppointmentSynchronized(object sender, AppointmentSynchronizedEventArgs e) {
          // Your code here.  
        }

        void importSynchronizer_AppointmentSynchronizing(object sender, AppointmentSynchronizingEventArgs e) {
            AnalyzeAndHandleCurrentOperation(e as DevExpress.XtraScheduler.Outlook.OutlookAppointmentSynchronizingEventArgs, true);
        }

        void exportSynchronizer_AppointmentSynchronized(object sender, AppointmentSynchronizedEventArgs e) {
            // Your code here.  
        }

        void AnalyzeAndHandleCurrentOperation(DevExpress.XtraScheduler.Outlook.OutlookAppointmentSynchronizingEventArgs eventArgs, bool toScheduler) {
            string logInfo = "";
            string appointmentInfoScheduler = "";
            string appointmentInfoOutlook = "";

            if (eventArgs.Appointment != null)
                appointmentInfoScheduler = String.Format("Subject: {0}, Start: {1}, End: {2}, ForeignID: {3}",
                    eventArgs.Appointment.Subject, eventArgs.Appointment.Start.ToString(), eventArgs.Appointment.End.ToString(),
                    eventArgs.Appointment.GetValue(this.schedulerStorage1, OutlookEntryIDFieldName));
            else
                appointmentInfoScheduler = "<No information>";

            if (eventArgs.OutlookAppointment != null)
                appointmentInfoOutlook = String.Format("Subject: {0}, Start: {1}, End: {2}, ID:{3}",
                    eventArgs.OutlookAppointment.Subject, eventArgs.OutlookAppointment.Start.ToString(), eventArgs.OutlookAppointment.End.ToString(),
                    eventArgs.OutlookAppointment.EntryID);
            else
                appointmentInfoOutlook = "<No information>";

            switch(eventArgs.Operation) {
                case SynchronizeOperation.Create:
                    logInfo += (toScheduler ? "->Scheduler (Creating)" : "->Outlook (Creating)");
                    logInfo += "\r\n";
                    logInfo += String.Format("({0}) appointment - {1}", "Scheduler", appointmentInfoScheduler);
                    logInfo += "\r\n";
                    logInfo += String.Format("({0}) appointment - {1}", "Outlook   ", appointmentInfoOutlook);
                    // Decide whether to perform an operation.
                    if((toScheduler && !SyncronizationOptionForm.AllowCreateAppointmentInScheduler) || (!toScheduler && !SyncronizationOptionForm.AllowCreateAppointmentInOutlook)) {
                        eventArgs.Cancel = true;
                        logInfo += " (Operation canceled)";
                    }
                    break;
                case SynchronizeOperation.Delete:
                    logInfo += (toScheduler ? "->Scheduler (Deleting)" : "->Outlook (Deleting)");
                    logInfo += "\r\n";
                    logInfo += String.Format("({0}) appointment - {1}", "Scheduler", appointmentInfoScheduler);
                    logInfo += "\r\n";
                    logInfo += String.Format("({0}) appointment - {1}", "Outlook    ", appointmentInfoOutlook);
                    // Decide whether to perform an operation.
                    if((toScheduler && !SyncronizationOptionForm.AllowRemoveAppointmentInScheduler) || (!toScheduler && !SyncronizationOptionForm.AllowRemoveAppointmentInOutlook)) {
                        eventArgs.Cancel = true;
                        logInfo += " (Operation canceled)";                        
                    }
                    break;
                case SynchronizeOperation.Replace:
                    logInfo += (toScheduler ? "->Scheduler (Updating)" : "->Outlook (Updating)");
                    logInfo += "\r\n";
                    logInfo += String.Format("({0}) appointment - {1}", "Scheduler", appointmentInfoScheduler);
                    logInfo += "\r\n";
                    logInfo += String.Format("({0}) appointment - {1}", "Outlook   ", appointmentInfoOutlook);
                    // Decide whether to perform an operation.
                    if((toScheduler && !SyncronizationOptionForm.AllowUpdateAppointmentInScheduler) || (!toScheduler && !SyncronizationOptionForm.AllowUpdateAppointmentInOutlook)) {
                        eventArgs.Cancel = true;
                        logInfo += " (Operation canceled)";                        
                    }
                    break;
                default:
                    break;
            }
            memoEdit1.Text += logInfo + "\r\n";
        }

        private void btnOptions_Click(object sender, EventArgs e) {
            optionsForm.ShowDialog();
        }


        #region Initialization
        private void InitAppointments()
        {
            AppointmentMappingInfo aptmappings = this.schedulerStorage1.Appointments.Mappings;
            aptmappings.Start = "StartTime";
            aptmappings.End = "EndTime";
            aptmappings.Subject = "Subject";
            aptmappings.AllDay = "AllDay";
            aptmappings.Description = "Description";
            aptmappings.Label = "Label";
            aptmappings.Location = "Location";
            aptmappings.RecurrenceInfo = "RecurrenceInfo";
            aptmappings.ReminderInfo = "ReminderInfo";
            aptmappings.Status = "Status";
            aptmappings.Type = "EventType";
            aptmappings.ResourceId = "OwnerId";

            ResourceMappingInfo resmappings = this.schedulerStorage1.Resources.Mappings;
            resmappings.Id = "ResID";
            resmappings.Caption = "Name";
            resmappings.Color = "ResColor";

            GenerateResources(3);
            GenerateEvents(CustomEventList);
            this.schedulerStorage1.Appointments.DataSource = CustomEventList;
        }

        private void GenerateResources(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Resource res = schedulerStorage1.CreateResource(i, String.Format("Resource {0}", i));
                schedulerStorage1.Resources.Add(res);
            }
        }

        private void GenerateEvents(BindingList<CustomAppointment> eventList)
        {

            string subjPrefix = "Max Fowler's ";
            eventList.Add(CreateEvent(subjPrefix + "meeting", 1, 2, 5));
        }
        private CustomAppointment CreateEvent(string subject, object resourceId, int status, int label)
        {
            CustomAppointment apt = new CustomAppointment();
            apt.Subject = subject;
            apt.OwnerId = resourceId;
            Random rnd = RandomInstance;
            int rangeInMinutes = 60 * 24;
            apt.StartTime = DateTime.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes));
            apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes / 4));
            apt.Status = status;
            apt.Label = label;
            return apt;
        }
        #endregion Initialization
    }
}
