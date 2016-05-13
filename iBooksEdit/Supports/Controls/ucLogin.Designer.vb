<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucLogin
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucLogin))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ImageSlider = New DevExpress.XtraEditors.Controls.ImageSlider()
        Me.ImageCollectionSlider = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ComboBoxEditPerson = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEditPassport = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.StyleControllerLogin = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.TimerSlider = New System.Windows.Forms.Timer(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ImageSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollectionSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEditPerson.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditPassport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleControllerLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LabelControl1)
        Me.LayoutControl1.Controls.Add(Me.ImageSlider)
        Me.LayoutControl1.Controls.Add(Me.ComboBoxEditPerson)
        Me.LayoutControl1.Controls.Add(Me.TextEditPassport)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2737, 236, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(795, 198)
        Me.LayoutControl1.StyleController = Me.StyleControllerLogin
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ImageSlider
        '
        Me.ImageSlider.CurrentImageIndex = 0
        Me.ImageSlider.ImageList = Me.ImageCollectionSlider
        Me.ImageSlider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch
        Me.ImageSlider.Location = New System.Drawing.Point(12, 39)
        Me.ImageSlider.Name = "ImageSlider"
        Me.ImageSlider.Size = New System.Drawing.Size(195, 147)
        Me.ImageSlider.StyleController = Me.LayoutControl1
        Me.ImageSlider.TabIndex = 6
        Me.ImageSlider.Text = "ImageSlider1"
        Me.ImageSlider.UseDisabledStatePainter = True
        '
        'ImageCollectionSlider
        '
        Me.ImageCollectionSlider.ImageSize = New System.Drawing.Size(500, 500)
        Me.ImageCollectionSlider.ImageStream = CType(resources.GetObject("ImageCollectionSlider.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollectionSlider.InsertImage(Global.iBooksEdit.My.Resources.Resources.graduated, "graduated", GetType(Global.iBooksEdit.My.Resources.Resources), 0)
        Me.ImageCollectionSlider.Images.SetKeyName(0, "graduated")
        Me.ImageCollectionSlider.InsertImage(Global.iBooksEdit.My.Resources.Resources.laboratory, "laboratory", GetType(Global.iBooksEdit.My.Resources.Resources), 1)
        Me.ImageCollectionSlider.Images.SetKeyName(1, "laboratory")
        Me.ImageCollectionSlider.InsertImage(Global.iBooksEdit.My.Resources.Resources.music, "music", GetType(Global.iBooksEdit.My.Resources.Resources), 2)
        Me.ImageCollectionSlider.Images.SetKeyName(2, "music")
        Me.ImageCollectionSlider.InsertImage(Global.iBooksEdit.My.Resources.Resources.physical_sciences, "physical_sciences", GetType(Global.iBooksEdit.My.Resources.Resources), 3)
        Me.ImageCollectionSlider.Images.SetKeyName(3, "physical_sciences")
        Me.ImageCollectionSlider.InsertImage(Global.iBooksEdit.My.Resources.Resources.teacher, "teacher", GetType(Global.iBooksEdit.My.Resources.Resources), 4)
        Me.ImageCollectionSlider.Images.SetKeyName(4, "teacher")
        Me.ImageCollectionSlider.InsertImage(Global.iBooksEdit.My.Resources.Resources.technology, "technology", GetType(Global.iBooksEdit.My.Resources.Resources), 5)
        Me.ImageCollectionSlider.Images.SetKeyName(5, "technology")
        '
        'ComboBoxEditPerson
        '
        Me.ComboBoxEditPerson.Location = New System.Drawing.Point(344, 60)
        Me.ComboBoxEditPerson.Name = "ComboBoxEditPerson"
        Me.ComboBoxEditPerson.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEditPerson.Size = New System.Drawing.Size(439, 30)
        Me.ComboBoxEditPerson.StyleController = Me.LayoutControl1
        Me.ComboBoxEditPerson.TabIndex = 4
        '
        'TextEditPassport
        '
        Me.TextEditPassport.Location = New System.Drawing.Point(344, 131)
        Me.TextEditPassport.Name = "TextEditPassport"
        Me.TextEditPassport.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextEditPassport.Size = New System.Drawing.Size(439, 30)
        Me.TextEditPassport.StyleController = Me.LayoutControl1
        Me.TextEditPassport.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem4, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(795, 198)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem1.Control = Me.ComboBoxEditPerson
        Me.LayoutControlItem1.Location = New System.Drawing.Point(199, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(576, 34)
        Me.LayoutControlItem1.Text = "Пользователь:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(130, 23)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.TextEditPassport
        Me.LayoutControlItem2.Location = New System.Drawing.Point(199, 119)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(576, 34)
        Me.LayoutControlItem2.Text = "Пароль:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(130, 23)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(199, 82)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(576, 37)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(199, 27)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(576, 21)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(199, 153)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(576, 25)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ImageSlider
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 27)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(54, 20)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(199, 151)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'StyleControllerLogin
        '
        Me.StyleControllerLogin.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StyleControllerLogin.Appearance.Options.UseFont = True
        Me.StyleControllerLogin.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.StyleControllerLogin.AppearanceDropDown.Options.UseFont = True
        '
        'TimerSlider
        '
        Me.TimerSlider.Interval = 10000
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(771, 23)
        Me.LabelControl1.StyleController = Me.LayoutControl1
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Идентификация пользователя:"
        Me.LabelControl1.UseMnemonic = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.LabelControl1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(279, 27)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(775, 27)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'ucLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ucLogin"
        Me.Size = New System.Drawing.Size(795, 198)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ImageSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollectionSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEditPerson.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditPassport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleControllerLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents ComboBoxEditPerson As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents StyleControllerLogin As DevExpress.XtraEditors.StyleController
    Friend WithEvents ImageSlider As DevExpress.XtraEditors.Controls.ImageSlider
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ImageCollectionSlider As DevExpress.Utils.ImageCollection
    Friend WithEvents TimerSlider As Timer
    Friend WithEvents TextEditPassport As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
