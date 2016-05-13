Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class ucLogin
    Private iSlade As Integer = 1

    Public Sub New()
        InitializeComponent()

        Using dbEF = New iBooksEntities()
            Try
                dbEF.Connection.Open()
                Call Persons(True, dbEF)
                dbEF.Connection.Close()
            Catch ex As Exception
                Call Persons(False, dbEF)
            End Try
        End Using
    End Sub

    Private Sub ucLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TimerSlider.Enabled = True
    End Sub

    Private Sub TimerSlider_Tick(sender As Object, e As EventArgs) Handles TimerSlider.Tick
        If iSlade = Me.ImageCollectionSlider.Images.Count Then
            Me.ImageSlider.SlideFirst()
            iSlade = 1
        Else
            Me.ImageSlider.SlideNext()
            iSlade += 1
        End If
    End Sub

    Private Sub ucLogin_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        Me.TimerSlider.Enabled = False
    End Sub

#Region "Пользовательские процедуры и функции"
    ''' <summary>
    ''' Получение данных о пользователях для заполнения combobox
    ''' </summary>
    ''' <param name="_flag"></param>
    ''' <param name="_dbEF"></param>
    Private Sub Persons(ByVal _flag As Boolean, ByVal _dbEF As iBooksEntities)
        Dim cbPerson As ComboBoxEdit = Me.ComboBoxEditPerson

        cbPerson.Properties.Items.BeginUpdate()

        Try
            cbPerson.Properties.Items.Add(New PersonInfo("Администратор", "системы", , "Полный доступ"))

            If _flag And _dbEF.Сотрудник.Count > 0 Then
                PersonsCB(cbPerson, From dE In _dbEF.Сотрудник Order By dE.Фамилия
                                    Select New With {dE.Фамилия, dE.Имя, dE.Отчество, dE.Степень.Аббревиатура, dE.Должность.Наименование})
            End If
        Finally
            cbPerson.SelectedIndex = 0
            cbPerson.Properties.Items.EndUpdate()
        End Try
    End Sub

    ''' <summary>
    ''' Заполнение combobox данными о пользователях
    ''' </summary>
    ''' <param name="cbPerson"></param>
    ''' <param name="qR"></param>
    Private Shared Sub PersonsCB(ByVal cbPerson As ComboBoxEdit, ByVal qR As Object)
        Dim _str As String

        For Each rec In qR
            If IsNothing(rec.Аббревиатура) And IsNothing(rec.Наименование) Then
                _str = Nothing
            ElseIf IsNothing(rec.Аббревиатура) And Not IsNothing(rec.Наименование) Then
                _str = CType(String.Format("{0}", LCase(rec.Наименование)), String)
            ElseIf Not IsNothing(rec.Аббревиатура) And IsNothing(rec.Наименование) Then
                _str = CType(String.Format("{0}", LCase(rec.Аббревиатура)), String)
            Else
                _str = CType(String.Format("{0}, {1}", LCase(rec.Аббревиатура), LCase(rec.Наименование)), String)
            End If

            If Not IsNothing(_str) Then
                cbPerson.Properties.Items.Add(New PersonInfo(rec.Фамилия, Mid(rec.Имя, 1, 1) & ".", CType(IIf(IsNothing(rec.Отчество), Nothing, Mid(rec.Отчество, 1, 1) & "."), String), _str))
            Else
                cbPerson.Properties.Items.Add(New PersonInfo(rec.Фамилия, Mid(rec.Имя, 1, 1) & ".", CType(IIf(IsNothing(rec.Отчество), Nothing, Mid(rec.Отчество, 1, 1) & "."), String)))
            End If
        Next
    End Sub
#End Region
End Class
