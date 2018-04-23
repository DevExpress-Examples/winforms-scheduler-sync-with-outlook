Namespace SyncWithOutlook
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler4 As New DevExpress.XtraScheduler.TimeRuler()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.btnOptions = New DevExpress.XtraEditors.SimpleButton()
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.btnOutlookScheduler = New DevExpress.XtraEditors.SimpleButton()
            Me.btnSchedulerOutlook = New DevExpress.XtraEditors.SimpleButton()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.btnOptions)
            Me.layoutControl1.Controls.Add(Me.comboBoxEdit1)
            Me.layoutControl1.Controls.Add(Me.btnOutlookScheduler)
            Me.layoutControl1.Controls.Add(Me.btnSchedulerOutlook)
            Me.layoutControl1.Controls.Add(Me.memoEdit1)
            Me.layoutControl1.Controls.Add(Me.dateNavigator1)
            Me.layoutControl1.Controls.Add(Me.schedulerControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(991, 355, 250, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(929, 698)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' btnOptions
            ' 
            Me.btnOptions.Location = New System.Drawing.Point(708, 664)
            Me.btnOptions.Name = "btnOptions"
            Me.btnOptions.Size = New System.Drawing.Size(209, 22)
            Me.btnOptions.StyleController = Me.layoutControl1
            Me.btnOptions.TabIndex = 10
            Me.btnOptions.Text = "Options..."
            ' 
            ' comboBoxEdit1
            ' 
            Me.comboBoxEdit1.Location = New System.Drawing.Point(708, 468)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Size = New System.Drawing.Size(209, 20)
            Me.comboBoxEdit1.StyleController = Me.layoutControl1
            Me.comboBoxEdit1.TabIndex = 9
            ' 
            ' btnOutlookScheduler
            ' 
            Me.btnOutlookScheduler.Appearance.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold)
            Me.btnOutlookScheduler.Appearance.Options.UseFont = True
            Me.btnOutlookScheduler.Location = New System.Drawing.Point(708, 522)
            Me.btnOutlookScheduler.Name = "btnOutlookScheduler"
            Me.btnOutlookScheduler.Size = New System.Drawing.Size(209, 26)
            Me.btnOutlookScheduler.StyleController = Me.layoutControl1
            Me.btnOutlookScheduler.TabIndex = 8
            Me.btnOutlookScheduler.Text = "Outlook -- > Scheduler"
            ' 
            ' btnSchedulerOutlook
            ' 
            Me.btnSchedulerOutlook.Appearance.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold)
            Me.btnSchedulerOutlook.Appearance.Options.UseFont = True
            Me.btnSchedulerOutlook.Location = New System.Drawing.Point(708, 492)
            Me.btnSchedulerOutlook.Name = "btnSchedulerOutlook"
            Me.btnSchedulerOutlook.Size = New System.Drawing.Size(209, 26)
            Me.btnSchedulerOutlook.StyleController = Me.layoutControl1
            Me.btnSchedulerOutlook.TabIndex = 7
            Me.btnSchedulerOutlook.Text = "Scheduler --> Outlook"
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Location = New System.Drawing.Point(12, 468)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(692, 218)
            Me.memoEdit1.StyleController = Me.layoutControl1
            Me.memoEdit1.TabIndex = 6
            ' 
            ' dateNavigator1
            ' 
            Me.dateNavigator1.Location = New System.Drawing.Point(708, 12)
            Me.dateNavigator1.Name = "dateNavigator1"
        Me.dateNavigator1.CellPadding = New System.Windows.Forms.Padding(2)
            Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
            Me.dateNavigator1.Size = New System.Drawing.Size(209, 436)
            Me.dateNavigator1.TabIndex = 5
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Location = New System.Drawing.Point(12, 12)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(692, 436)
            Me.schedulerControl1.Start = New Date(2013, 9, 2, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 4
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler3)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler4)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem1, Me.layoutControlItem7})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(929, 698)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.memoEdit1
            Me.layoutControlItem3.CustomizationFormText = "Operation log:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 440)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(696, 238)
            Me.layoutControlItem3.Text = "Operation log:"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(104, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.btnSchedulerOutlook
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(696, 480)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(213, 30)
            Me.layoutControlItem4.Text = "layoutControlItem4"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextToControlDistance = 0
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.btnOutlookScheduler
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(696, 510)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(213, 30)
            Me.layoutControlItem5.Text = "layoutControlItem5"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextToControlDistance = 0
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.comboBoxEdit1
            Me.layoutControlItem6.CustomizationFormText = "Outllok folder:"
            Me.layoutControlItem6.Location = New System.Drawing.Point(696, 440)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(213, 40)
            Me.layoutControlItem6.Text = "Select Outlook folder:"
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(104, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.schedulerControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(696, 440)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.dateNavigator1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(696, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(213, 440)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(696, 540)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(213, 112)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.btnOptions
            Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
            Me.layoutControlItem7.Location = New System.Drawing.Point(696, 652)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(213, 26)
            Me.layoutControlItem7.Text = "layoutControlItem7"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextToControlDistance = 0
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(929, 698)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
        Private WithEvents btnOutlookScheduler As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnSchedulerOutlook As DevExpress.XtraEditors.SimpleButton
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private WithEvents btnOptions As DevExpress.XtraEditors.SimpleButton
        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

