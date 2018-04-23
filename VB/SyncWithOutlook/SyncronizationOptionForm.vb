Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace SyncWithOutlook
    Partial Public Class SyncronizationOptionForm
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

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            Me.Close()
        End Sub

        Private Sub SyncronizationOptionForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            checkEditAllowCreateOutllok.EditValue = SyncronizationOptionForm.AllowCreateAppointmentInOutlook
            checkEditAllowCreateScheduler.EditValue = SyncronizationOptionForm.AllowCreateAppointmentInScheduler
            checkEditAllowRemoveOutlook.EditValue = SyncronizationOptionForm.AllowRemoveAppointmentInOutlook
            checkEditAllowRemoveScheduler.EditValue = SyncronizationOptionForm.AllowRemoveAppointmentInScheduler
            checkEditAllowUpdateOutlook.EditValue = SyncronizationOptionForm.AllowUpdateAppointmentInOutlook
            checkEditAllowUpdateScheduler.EditValue = SyncronizationOptionForm.AllowUpdateAppointmentInScheduler
        End Sub

        Protected Overrides Sub OnClosing(ByVal e As CancelEventArgs)
            SyncronizationOptionForm.AllowCreateAppointmentInOutlook = CBool(checkEditAllowCreateOutllok.EditValue)
            SyncronizationOptionForm.AllowCreateAppointmentInScheduler = CBool(checkEditAllowCreateScheduler.EditValue)
            SyncronizationOptionForm.AllowRemoveAppointmentInOutlook = CBool(checkEditAllowRemoveOutlook.EditValue)
            SyncronizationOptionForm.AllowRemoveAppointmentInScheduler = CBool(checkEditAllowRemoveScheduler.EditValue)
            SyncronizationOptionForm.AllowUpdateAppointmentInOutlook = CBool(checkEditAllowUpdateOutlook.EditValue)
            SyncronizationOptionForm.AllowUpdateAppointmentInScheduler = CBool(checkEditAllowUpdateScheduler.EditValue)
            MyBase.OnClosing(e)
        End Sub
    End Class
End Namespace
