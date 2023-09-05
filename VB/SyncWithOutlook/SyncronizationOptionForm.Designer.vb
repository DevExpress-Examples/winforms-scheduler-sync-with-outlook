Namespace SyncWithOutlook

    Partial Class SyncronizationOptionForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.checkEditAllowCreateScheduler = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.checkEditAllowUpdateScheduler = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.checkEditAllowRemoveScheduler = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.checkEditAllowCreateOutllok = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.checkEditAllowUpdateOutlook = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.checkEditAllowRemoveOutlook = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAllowCreateScheduler.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAllowUpdateScheduler.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAllowRemoveScheduler.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAllowCreateOutllok.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAllowUpdateOutlook.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAllowRemoveOutlook.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            Me.layoutControl1.Controls.Add(Me.checkEditAllowRemoveOutlook)
            Me.layoutControl1.Controls.Add(Me.checkEditAllowUpdateOutlook)
            Me.layoutControl1.Controls.Add(Me.checkEditAllowCreateOutllok)
            Me.layoutControl1.Controls.Add(Me.checkEditAllowRemoveScheduler)
            Me.layoutControl1.Controls.Add(Me.checkEditAllowUpdateScheduler)
            Me.layoutControl1.Controls.Add(Me.checkEditAllowCreateScheduler)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(464, 47, 535, 660)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(406, 274)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7, Me.layoutControlGroup2, Me.layoutControlGroup3, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(406, 274)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' checkEditAllowCreateScheduler
            ' 
            Me.checkEditAllowCreateScheduler.Location = New System.Drawing.Point(24, 43)
            Me.checkEditAllowCreateScheduler.Name = "checkEditAllowCreateScheduler"
            Me.checkEditAllowCreateScheduler.Properties.Caption = "Allow create appointments"
            Me.checkEditAllowCreateScheduler.Size = New System.Drawing.Size(358, 19)
            Me.checkEditAllowCreateScheduler.StyleController = Me.layoutControl1
            Me.checkEditAllowCreateScheduler.TabIndex = 4
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.checkEditAllowCreateScheduler
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(362, 23)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' checkEditAllowUpdateScheduler
            ' 
            Me.checkEditAllowUpdateScheduler.Location = New System.Drawing.Point(24, 66)
            Me.checkEditAllowUpdateScheduler.Name = "checkEditAllowUpdateScheduler"
            Me.checkEditAllowUpdateScheduler.Properties.Caption = "Allow update appointments"
            Me.checkEditAllowUpdateScheduler.Size = New System.Drawing.Size(358, 19)
            Me.checkEditAllowUpdateScheduler.StyleController = Me.layoutControl1
            Me.checkEditAllowUpdateScheduler.TabIndex = 5
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.checkEditAllowUpdateScheduler
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(362, 23)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' checkEditAllowRemoveScheduler
            ' 
            Me.checkEditAllowRemoveScheduler.Location = New System.Drawing.Point(24, 89)
            Me.checkEditAllowRemoveScheduler.Name = "checkEditAllowRemoveScheduler"
            Me.checkEditAllowRemoveScheduler.Properties.Caption = "Allow remove appointments"
            Me.checkEditAllowRemoveScheduler.Size = New System.Drawing.Size(358, 19)
            Me.checkEditAllowRemoveScheduler.StyleController = Me.layoutControl1
            Me.checkEditAllowRemoveScheduler.TabIndex = 6
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.checkEditAllowRemoveScheduler
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 46)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(362, 23)
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' checkEditAllowCreateOutllok
            ' 
            Me.checkEditAllowCreateOutllok.Location = New System.Drawing.Point(24, 155)
            Me.checkEditAllowCreateOutllok.Name = "checkEditAllowCreateOutllok"
            Me.checkEditAllowCreateOutllok.Properties.Caption = "Allow create appointments"
            Me.checkEditAllowCreateOutllok.Size = New System.Drawing.Size(358, 19)
            Me.checkEditAllowCreateOutllok.StyleController = Me.layoutControl1
            Me.checkEditAllowCreateOutllok.TabIndex = 7
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.checkEditAllowCreateOutllok
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(362, 23)
            Me.layoutControlItem4.Text = "layoutControlItem4"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextToControlDistance = 0
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' checkEditAllowUpdateOutlook
            ' 
            Me.checkEditAllowUpdateOutlook.Location = New System.Drawing.Point(24, 178)
            Me.checkEditAllowUpdateOutlook.Name = "checkEditAllowUpdateOutlook"
            Me.checkEditAllowUpdateOutlook.Properties.Caption = "Allow update appointments"
            Me.checkEditAllowUpdateOutlook.Size = New System.Drawing.Size(358, 19)
            Me.checkEditAllowUpdateOutlook.StyleController = Me.layoutControl1
            Me.checkEditAllowUpdateOutlook.TabIndex = 8
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.checkEditAllowUpdateOutlook
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(362, 23)
            Me.layoutControlItem5.Text = "layoutControlItem5"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextToControlDistance = 0
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' checkEditAllowRemoveOutlook
            ' 
            Me.checkEditAllowRemoveOutlook.Location = New System.Drawing.Point(24, 201)
            Me.checkEditAllowRemoveOutlook.Name = "checkEditAllowRemoveOutlook"
            Me.checkEditAllowRemoveOutlook.Properties.Caption = "Allow remove appointments"
            Me.checkEditAllowRemoveOutlook.Size = New System.Drawing.Size(358, 19)
            Me.checkEditAllowRemoveOutlook.StyleController = Me.layoutControl1
            Me.checkEditAllowRemoveOutlook.TabIndex = 9
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.checkEditAllowRemoveOutlook
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 46)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(362, 23)
            Me.layoutControlItem6.Text = "layoutControlItem6"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextToControlDistance = 0
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(12, 236)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(175, 22)
            Me.simpleButton1.StyleController = Me.layoutControl1
            Me.simpleButton1.TabIndex = 10
            Me.simpleButton1.Text = "Close"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.simpleButton1
            Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 224)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(179, 30)
            Me.layoutControlItem7.Text = "layoutControlItem7"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextToControlDistance = 0
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CustomizationFormText = "Allowed operations in Scheduler"
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(386, 112)
            Me.layoutControlGroup2.Text = "Allowed operations in Scheduler"
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.CustomizationFormText = "Allowed operations in Outlook"
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 112)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(386, 112)
            Me.layoutControlGroup3.Text = "Allowed operations in Outlook"
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(179, 224)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(207, 30)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' SyncronizationOptionForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(406, 274)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "SyncronizationOptionForm"
            Me.Text = "SyncronizationOptionForm"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.SyncronizationOptionForm_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAllowCreateScheduler.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAllowUpdateScheduler.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAllowRemoveScheduler.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAllowCreateOutllok.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAllowUpdateOutlook.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAllowRemoveOutlook.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private checkEditAllowRemoveOutlook As DevExpress.XtraEditors.CheckEdit

        Private checkEditAllowUpdateOutlook As DevExpress.XtraEditors.CheckEdit

        Private checkEditAllowCreateOutllok As DevExpress.XtraEditors.CheckEdit

        Private checkEditAllowRemoveScheduler As DevExpress.XtraEditors.CheckEdit

        Private checkEditAllowUpdateScheduler As DevExpress.XtraEditors.CheckEdit

        Private checkEditAllowCreateScheduler As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
