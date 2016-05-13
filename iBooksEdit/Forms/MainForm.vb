Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors


Partial Public Class MainForm
    Inherits XtraForm

    Private ucLoginAction As FlyoutAction = New FlyoutAction()
    Private clAppAction As FlyoutAction = New FlyoutAction()
    Dim _ucLogin As New ucLogin()

    Public Sub New()
        InitializeComponent()

        Me.windowsUIViewMain.AddDocument(_ucLogin)
        ucLoginAction.Caption = "Идентификация пользователя :"
        ucLoginAction.Commands.Add(FlyoutCommand.OK)
        ucLoginAction.Commands.Add(FlyoutCommand.Cancel)
        clAppAction.Caption = "Приложение..."
        clAppAction.Description = "Завершение выполнения приложения."
        closeAppFlyout.FlyoutButtons = MessageBoxButtons.OK
        closeAppFlyout.Action = clAppAction
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.windowsUIViewMain.ActivateContainer(userControlLoginFlyout)
    End Sub

    Private Sub windowsUIViewMain_FlyoutHidden(sender As Object, e As FlyoutResultEventArgs) Handles windowsUIViewMain.FlyoutHidden
        If e.Result = System.Windows.Forms.DialogResult.OK Then
            XtraMessageBox.Show(String.Format("Проверка пользователя :{0}_ucLogin.ComboBoxEditPerson.Text = {1}, _ucLogin.TextEditPassport.Text = {2}",
                                 Chr(13), _ucLogin.ComboBoxEditPerson.Text, _ucLogin.TextEditPassport.Text))
            If Trim(_ucLogin.ComboBoxEditPerson.Text).Split(" ")(0) = "Администратор" AndAlso Trim(_ucLogin.TextEditPassport.Text) = "sandozik" Then
                XtraMessageBox.Show("Административный режим")
            End If
        Else
                Application.Exit()
        End If
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        windowsUIViewMain.ShowFlyoutDialog(closeAppFlyout)
    End Sub

#Region "Пользовательские процедуры и функции"
#End Region
End Class
