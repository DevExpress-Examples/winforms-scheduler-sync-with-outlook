Namespace SyncWithOutlook

'#Region "#customappointment"
    Public Class CustomAppointment

        Public Property StartTime As Date

        Public Property EndTime As Date

        Public Property Subject As String

        Public Property Status As Integer

        Public Property Description As String

        Public Property Label As Integer

        Public Property Location As String

        Public Property AllDay As Boolean

        Public Property EventType As Integer

        Public Property RecurrenceInfo As String

        Public Property ReminderInfo As String

        Public Property OwnerId As Object

        Public Property OutlookID As Object

        Public Sub New()
        End Sub
    End Class

'#End Region  ' #customappointment
'#Region "#customresource"
    Public Class CustomResource

        Public Property Name As String

        Public Property ResID As Integer

        Public Property ResColor As System.Drawing.Color

        Public Sub New()
        End Sub
    End Class
'#End Region  ' #customresource
End Namespace
