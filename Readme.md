<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128636840/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T158895)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Synchronization with MS Outlook  - a demonstration example


In v23.1+, Scheduler Control supports new APIs and allows you to synchronize user appointments with Microsoft 365 calendars (bi-directionally). Please refer to the [Synchronization with Microsoft 365 Calendars](https://docs.devexpress.com/WindowsForms/404317/controls-and-libraries/scheduler/import-and-export/synchronization-with-outlook-365-calendars) help topic for details.

You can also use the build-in [DXGoogleCalendarSync](https://docs.devexpress.com/WindowsForms/DevExpress.XtraScheduler.GoogleCalendar.DXGoogleCalendarSync) component to set up the synchronization between a Scheduler Control and a Google Calendar: [Google Calendars](https://docs.devexpress.com/WindowsForms/120605/controls-and-libraries/scheduler/import-and-export/google-calendars).

If the build-in synchronization functionality doesn't meet your requirements, this example allows you to examine the operation of <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressXtraSchedulerExchangeAppointmentExportSynchronizertopic">AppointmentExportSynchronizer</a> and <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressXtraSchedulerExchangeAppointmentImportSynchronizertopic">AppointmentImportSynchronizer</a> objects which enable you to implement your own synchronization method.<br><br><u><strong>WARNING: When you run this example, you can delete all data in your MS Outlook calendar. We suggest that you backup your data prior to running the example.</strong></u>
_____
See also:
[Import and Export](https://docs.devexpress.com/WindowsForms/117342/controls-and-libraries/scheduler/import-and-export)
