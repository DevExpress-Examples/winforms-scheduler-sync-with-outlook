Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Exchange
Imports DevExpress.XtraScheduler.Outlook
Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace SyncWithOutlook
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        ' Specify the name of the property of the custom object (or the name of the data field in the data record if the scheduler storage is bound to the data source)
        ' containing ID of the foreign object - in this example it is the Outlook entry ID.
        ' In this example the custom object is the CustomAppointment instance that have the OutlookID property.
        ' This name is also specified for the AppointmentSynchronizer.ForeignIdFieldName property.
        ' The value of the field with that name can be obtained using the Appointment.GetValue method.
        Private Const OutlookEntryIDFieldName As String = "OutlookID"

        Private optionsForm As New SyncronizationOptionForm()
        Public Shared RandomInstance As New Random()
        Private CustomEventList As New BindingList(Of CustomAppointment)()

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitAppointments()
            schedulerControl1.Start = Date.Now
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            schedulerControl1.ActiveViewType = SchedulerViewType.Day

            ' Obtain the names of MS Outlook calendars. 
            comboBoxEdit1.Properties.Items.AddRange(OutlookExchangeHelper.GetOutlookCalendarPaths())

            SyncronizationOptionForm.AllowCreateAppointmentInOutlook = True
            SyncronizationOptionForm.AllowCreateAppointmentInScheduler = True
            SyncronizationOptionForm.AllowRemoveAppointmentInOutlook = True
            SyncronizationOptionForm.AllowRemoveAppointmentInScheduler = True
            SyncronizationOptionForm.AllowUpdateAppointmentInOutlook = True
            SyncronizationOptionForm.AllowUpdateAppointmentInScheduler = True
        End Sub

        ' Scheduler --> Outlook
        Private Sub btnSchedulerOutlook_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSchedulerOutlook.Click
            If comboBoxEdit1.EditValue IsNot Nothing Then
'                #Region "#scheduler->outlook"
                Dim synchronizer As AppointmentExportSynchronizer = schedulerControl1.Storage.CreateOutlookExportSynchronizer()
                ' Specify the field that contains appointment identifier used by a third-party application.
                synchronizer.ForeignIdFieldName = OutlookEntryIDFieldName
                ' The AppointmentSynchronizing event allows you to control the operation for an individual appointment.
                AddHandler synchronizer.AppointmentSynchronizing, AddressOf exportSynchronizer_AppointmentSynchronizing
                ' The AppointmentSynchronized event indicates that the operation for a particular appointment is complete.
                AddHandler synchronizer.AppointmentSynchronized, AddressOf exportSynchronizer_AppointmentSynchronized
                ' Specify MS Outlook calendar path.
                DirectCast(synchronizer, ISupportCalendarFolders).CalendarFolderName = comboBoxEdit1.EditValue.ToString()
                ' Perform the operation.
                synchronizer.Synchronize()
'                #End Region ' #scheduler->outlook
                memoEdit1.Text += ControlChars.CrLf & " Export is done." & ControlChars.CrLf & ControlChars.CrLf
            Else
                MessageBox.Show("Please select an Outlook folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        End Sub

        Private Sub exportSynchronizer_AppointmentSynchronizing(ByVal sender As Object, ByVal e As AppointmentSynchronizingEventArgs)
            AnalyzeAndHandleCurrentOperation(TryCast(e, DevExpress.XtraScheduler.Outlook.OutlookAppointmentSynchronizingEventArgs), False)
        End Sub

        ' Outlook --> Scheduler
        Private Sub btnOutlookScheduler_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOutlookScheduler.Click
            If comboBoxEdit1.EditValue IsNot Nothing Then
'                #Region "#outlook->scheduler"
                Dim synchronizer As AppointmentImportSynchronizer = schedulerControl1.Storage.CreateOutlookImportSynchronizer()
                ' Specify the field that contains appointment identifier used by a third-party application.
                synchronizer.ForeignIdFieldName = OutlookEntryIDFieldName
                ' The AppointmentSynchronizing event allows you to control the operation for an individual appointment.
                AddHandler synchronizer.AppointmentSynchronizing, AddressOf importSynchronizer_AppointmentSynchronizing
                ' The AppointmentSynchronized event indicates that the operation for a particular appointment is complete.
                AddHandler synchronizer.AppointmentSynchronized, AddressOf importSynchronizer_AppointmentSynchronized
                ' Specify MS Outlook calendar path.
                DirectCast(synchronizer, ISupportCalendarFolders).CalendarFolderName = comboBoxEdit1.EditValue.ToString()
                ' Perform the operation.
                synchronizer.Synchronize()
'                #End Region ' #outlook->scheduler
                memoEdit1.Text += ControlChars.CrLf & " Import is done." & ControlChars.CrLf & ControlChars.CrLf
            Else
                MessageBox.Show("Please select an Outlook folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub importSynchronizer_AppointmentSynchronized(ByVal sender As Object, ByVal e As AppointmentSynchronizedEventArgs)
          ' Your code here.  
        End Sub

        Private Sub importSynchronizer_AppointmentSynchronizing(ByVal sender As Object, ByVal e As AppointmentSynchronizingEventArgs)
            AnalyzeAndHandleCurrentOperation(TryCast(e, DevExpress.XtraScheduler.Outlook.OutlookAppointmentSynchronizingEventArgs), True)
        End Sub

        Private Sub exportSynchronizer_AppointmentSynchronized(ByVal sender As Object, ByVal e As AppointmentSynchronizedEventArgs)
            ' Your code here.  
        End Sub

        Private Sub AnalyzeAndHandleCurrentOperation(ByVal eventArgs As DevExpress.XtraScheduler.Outlook.OutlookAppointmentSynchronizingEventArgs, ByVal toScheduler As Boolean)
            Dim logInfo As String = ""
            Dim appointmentInfoScheduler As String = ""
            Dim appointmentInfoOutlook As String = ""

            If eventArgs.Appointment IsNot Nothing Then
                appointmentInfoScheduler = String.Format("Subject: {0}, Start: {1}, End: {2}, ForeignID: {3}", eventArgs.Appointment.Subject, eventArgs.Appointment.Start.ToString(), eventArgs.Appointment.End.ToString(), eventArgs.Appointment.GetValue(Me.schedulerStorage1, OutlookEntryIDFieldName))
            Else
                appointmentInfoScheduler = "<No information>"
            End If

            If eventArgs.OutlookAppointment IsNot Nothing Then
                appointmentInfoOutlook = String.Format("Subject: {0}, Start: {1}, End: {2}, ID:{3}", eventArgs.OutlookAppointment.Subject, eventArgs.OutlookAppointment.Start.ToString(), eventArgs.OutlookAppointment.End.ToString(), eventArgs.OutlookAppointment.EntryID)
            Else
                appointmentInfoOutlook = "<No information>"
            End If

            Select Case eventArgs.Operation
                Case SynchronizeOperation.Create
                    logInfo &= (If(toScheduler, "->Scheduler (Creating)", "->Outlook (Creating)"))
                    logInfo &= ControlChars.CrLf
                    logInfo &= String.Format("({0}) appointment - {1}", "Scheduler", appointmentInfoScheduler)
                    logInfo &= ControlChars.CrLf
                    logInfo &= String.Format("({0}) appointment - {1}", "Outlook   ", appointmentInfoOutlook)
                    ' Decide whether to perform an operation.
                    If (toScheduler AndAlso (Not SyncronizationOptionForm.AllowCreateAppointmentInScheduler)) OrElse ((Not toScheduler) AndAlso (Not SyncronizationOptionForm.AllowCreateAppointmentInOutlook)) Then
                        eventArgs.Cancel = True
                        logInfo &= " (Operation canceled)"
                    End If
                Case SynchronizeOperation.Delete
                    logInfo &= (If(toScheduler, "->Scheduler (Deleting)", "->Outlook (Deleting)"))
                    logInfo &= ControlChars.CrLf
                    logInfo &= String.Format("({0}) appointment - {1}", "Scheduler", appointmentInfoScheduler)
                    logInfo &= ControlChars.CrLf
                    logInfo &= String.Format("({0}) appointment - {1}", "Outlook    ", appointmentInfoOutlook)
                    ' Decide whether to perform an operation.
                    If (toScheduler AndAlso (Not SyncronizationOptionForm.AllowRemoveAppointmentInScheduler)) OrElse ((Not toScheduler) AndAlso (Not SyncronizationOptionForm.AllowRemoveAppointmentInOutlook)) Then
                        eventArgs.Cancel = True
                        logInfo &= " (Operation canceled)"
                    End If
                Case SynchronizeOperation.Replace
                    logInfo &= (If(toScheduler, "->Scheduler (Updating)", "->Outlook (Updating)"))
                    logInfo &= ControlChars.CrLf
                    logInfo &= String.Format("({0}) appointment - {1}", "Scheduler", appointmentInfoScheduler)
                    logInfo &= ControlChars.CrLf
                    logInfo &= String.Format("({0}) appointment - {1}", "Outlook   ", appointmentInfoOutlook)
                    ' Decide whether to perform an operation.
                    If (toScheduler AndAlso (Not SyncronizationOptionForm.AllowUpdateAppointmentInScheduler)) OrElse ((Not toScheduler) AndAlso (Not SyncronizationOptionForm.AllowUpdateAppointmentInOutlook)) Then
                        eventArgs.Cancel = True
                        logInfo &= " (Operation canceled)"
                    End If
                Case Else
            End Select
            memoEdit1.Text += logInfo & ControlChars.CrLf
        End Sub

        Private Sub btnOptions_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOptions.Click
            optionsForm.ShowDialog()
        End Sub


        #Region "Initialization"
        Private Sub InitAppointments()
            Dim aptmappings As AppointmentMappingInfo = Me.schedulerStorage1.Appointments.Mappings
            aptmappings.Start = "StartTime"
            aptmappings.End = "EndTime"
            aptmappings.Subject = "Subject"
            aptmappings.AllDay = "AllDay"
            aptmappings.Description = "Description"
            aptmappings.Label = "Label"
            aptmappings.Location = "Location"
            aptmappings.RecurrenceInfo = "RecurrenceInfo"
            aptmappings.ReminderInfo = "ReminderInfo"
            aptmappings.Status = "Status"
            aptmappings.Type = "EventType"
            aptmappings.ResourceId = "OwnerId"

            Dim resmappings As ResourceMappingInfo = Me.schedulerStorage1.Resources.Mappings
            resmappings.Id = "ResID"
            resmappings.Caption = "Name"
            resmappings.Color = "ResColor"

            GenerateResources(3)
            GenerateEvents(CustomEventList)
            Me.schedulerStorage1.Appointments.DataSource = CustomEventList
        End Sub

        Private Sub GenerateResources(ByVal number As Integer)
            For i As Integer = 1 To number
                Dim res As Resource = schedulerStorage1.CreateResource(i, String.Format("Resource {0}", i))
                schedulerStorage1.Resources.Add(res)
            Next i
        End Sub

        Private Sub GenerateEvents(ByVal eventList As BindingList(Of CustomAppointment))

            Dim subjPrefix As String = "Max Fowler's "
            eventList.Add(CreateEvent(subjPrefix & "meeting", 1, 2, 5))
        End Sub
        Private Function CreateEvent(ByVal subject As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer) As CustomAppointment
            Dim apt As New CustomAppointment()
            apt.Subject = subject
            apt.OwnerId = resourceId
            Dim rnd As Random = RandomInstance
            Dim rangeInMinutes As Integer = 60 * 24
            apt.StartTime = Date.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes))
            apt.EndTime = apt.StartTime.Add(TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes \ 4)))
            apt.Status = status
            apt.Label = label
            Return apt
        End Function
        #End Region ' Initialization
    End Class
End Namespace
