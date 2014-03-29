Imports Microsoft.VisualBasic
Public Class Form1
    Dim filear As New ArrayList
    Dim t, n As Double

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        EnTi("rd")
    End Sub


    Private Sub 選擇檔案FToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 選擇檔案FToolStripMenuItem.Click
        OFD1.ShowDialog()
        If OFD1.FileNames.Length = 0 Then Exit Sub
        slad(OFD1.FileNames)
    End Sub


    Private Sub Form1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim sFile() As String = CType(e.Data.GetData(DataFormats.FileDrop), Array)
        Dim str As String = ""
        slad(sFile)
        ' For i As Integer = 0 To sFile.Length - 1
        'str &= sFile(i) & vbCrLf
        'Next
        'MessageBox.Show(str)

    End Sub

    Private Sub Form1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        e.Effect = DragDropEffects.All
    End Sub

    REM slad程序 Selection Lsit Add
    '判斷是否為資料夾，若是將資料夾內的檔案名稱取出
    Sub slad(ByVal FileNames() As String)

        For j = 0 To FileNames.Length - 1
            If My.Computer.FileSystem.DirectoryExists(FileNames(j)) = True Then
                For Each filetmp As String In My.Computer.FileSystem.GetFiles(FileNames(j), FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                    filear.Add(filetmp)
                Next
                ProgressBar1.Visible = True
                t = filear.Count - 1

                For y = 0 To filear.Count - 1
                    lsad(filear(y))
                    n = y
                    ProgressBar1.Value = Int((n / t) * 100)
                    EnTi("busy", ProgressBar1.Value)
                Next
                ProgressBar1.Value = 0
                ProgressBar1.Visible = False
                EnTi("rd")
            Else
                lsad(FileNames(j))
            End If
        Next
    End Sub
    '將資料增新到各種LIST物件
    Sub lsad(ByVal Filename$)
        ListView1.Items.Add(Filename.ToString)
        CheckedListBox1.Items.Add(Filename.ToString)
        ListBox1.Items.Add(Filename.ToString)
    End Sub
    Sub EnTi(ByVal Title As String, ByVal Progress%)
        Select Case Title
            Case "busy"
                Me.Text = "Visual ReNamer .NET [Busy] 進度：" & Progress & "%"
            Case "ld"
                Me.Text = "Visual ReNamer .NET [Loading Data]"
            Case "rn"
                Me.Text = "Visual ReNamer .NET [Re-Naming]"
            Case "rd"
                Me.Text = "Visual ReNamer .NET [Ready]"
            Case Else
                Me.Text = Title
        End Select
    End Sub
    Sub EnTi(ByVal Title As String)
        Select Case Title
            Case "busy"
                Me.Text = "Visual ReNamer .NET [Busy]"
            Case "ld"
                Me.Text = "Visual ReNamer .NET [Loading Data]"
            Case "rn"
                Me.Text = "Visual ReNamer .NET [Re-Naming]"
            Case "rd"
                Me.Text = "Visual ReNamer .NET [Ready]"
            Case Else
                Me.Text = Title
        End Select
    End Sub

End Class
