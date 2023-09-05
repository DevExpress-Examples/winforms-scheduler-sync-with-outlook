Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace SyncWithOutlook

    Public Partial Class SyncronizationOptionForm
        Inherits Form

        Public Shared AllowCreateAppointmentInScheduler As Boolean

        Public Shared AllowUpdateAppointmentInScheduler As Boolean

        Public Shared AllowRemoveAppointmentInScheduler As Boolean

        Public Shared AllowCreateAppointmentInOutlook As Boolean

        Public Shared AllowUpdateAppointmentInOutlook As Boolean

        Public Shared AllowRemoveAppointmentInOutlook As Boolean

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub SyncronizationOptionForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            checkEditAllowCreateOutllok.EditValue = AllowCreateAppointmentInOutlook
            checkEditAllowCreateScheduler.EditValue = AllowCreateAppointmentInScheduler
            checkEditAllowRemoveOutlook.EditValue = AllowRemoveAppointmentInOutlook
            checkEditAllowRemoveScheduler.EditValue = AllowRemoveAppointmentInScheduler
            checkEditAllowUpdateOutlook.EditValue = AllowUpdateAppointmentInOutlook
            checkEditAllowUpdateScheduler.EditValue = AllowUpdateAppointmentInScheduler
        End Sub

        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            AllowCreateAppointmentInOutlook = CBool(checkEditAllowCreateOutllok.EditValue)
            AllowCreateAppointmentInScheduler = CBool(checkEditAllowCreateScheduler.EditValue)
            AllowRemoveAppointmentInOutlook = CBool(checkEditAllowRemoveOutlook.EditValue)
            AllowRemoveAppointmentInScheduler = CBool(checkEditAllowRemoveScheduler.EditValue)
            AllowUpdateAppointmentInOutlook = CBool(checkEditAllowUpdateOutlook.EditValue)
            AllowUpdateAppointmentInScheduler = CBool(checkEditAllowUpdateScheduler.EditValue)
            MyBase.OnClosing(e)
        End Sub
    End Class
End Namespace
