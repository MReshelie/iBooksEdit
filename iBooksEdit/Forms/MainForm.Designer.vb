
Partial Public Class MainForm
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
        Me.documentManagerMain = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.windowsUIViewMain = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
        Me.TileContainerStart = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(Me.components)
        Me.docLoginTile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
        Me.docLogin = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.userControlLoginFlyout = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(Me.components)
        Me.ucLoginDocument = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
        Me.closeAppFlyout = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(Me.components)
        CType(Me.documentManagerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.windowsUIViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileContainerStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.docLoginTile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.docLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userControlLoginFlyout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucLoginDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeAppFlyout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'documentManagerMain
        '
        Me.documentManagerMain.ContainerControl = Me
        Me.documentManagerMain.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.[False]
        Me.documentManagerMain.View = Me.windowsUIViewMain
        Me.documentManagerMain.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.windowsUIViewMain})
        '
        'windowsUIViewMain
        '
        Me.windowsUIViewMain.Caption = "Интерактивный учебник"
        Me.windowsUIViewMain.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() {Me.TileContainerStart, Me.userControlLoginFlyout, Me.closeAppFlyout})
        Me.windowsUIViewMain.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.docLogin, Me.ucLoginDocument})
        Me.windowsUIViewMain.SplashScreenProperties.Image = Global.iBooksEdit.My.Resources.Resources.books_256
        Me.windowsUIViewMain.Tiles.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() {Me.docLoginTile})
        '
        'TileContainerStart
        '
        Me.TileContainerStart.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() {Me.docLoginTile})
        Me.TileContainerStart.Name = "TileContainerStart"
        '
        'docLoginTile
        '
        Me.docLoginTile.Document = Me.docLogin
        Me.docLoginTile.Name = "docLoginTile"
        '
        'docLogin
        '
        Me.docLogin.Caption = "Логин"
        Me.docLogin.ControlName = "docLogin"
        '
        'userControlLoginFlyout
        '
        Me.userControlLoginFlyout.Document = Me.ucLoginDocument
        Me.userControlLoginFlyout.FlyoutButtons = System.Windows.Forms.MessageBoxButtons.OKCancel
        Me.userControlLoginFlyout.Name = "userControlLoginFlyout"
        '
        'ucLoginDocument
        '
        Me.ucLoginDocument.Caption = "ucLogin"
        Me.ucLoginDocument.ControlName = "ucLogin"
        Me.ucLoginDocument.ControlTypeName = "iBooksEdit.ucLogin"
        '
        'closeAppFlyout
        '
        Me.closeAppFlyout.Name = "closeAppFlyout"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 423)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.documentManagerMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.windowsUIViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileContainerStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.docLoginTile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.docLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userControlLoginFlyout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucLoginDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeAppFlyout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents documentManagerMain As DevExpress.XtraBars.Docking2010.DocumentManager
    Private WithEvents windowsUIViewMain As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView
    Friend WithEvents docLogin As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents TileContainerStart As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer
    Friend WithEvents docLoginTile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
    Friend WithEvents userControlLoginFlyout As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout
    Friend WithEvents ucLoginDocument As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
    Friend WithEvents closeAppFlyout As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout
End Class
