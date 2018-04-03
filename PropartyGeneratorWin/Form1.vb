Public Class Form1

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        Dim ofd As New OpenFileDialog()

        ofd.CheckFileExists = True
        ofd.Multiselect = False
        ofd.CheckPathExists = True
        ofd.ShowDialog()

        If ofd.FileName = "" Then Exit Sub

        If IO.File.Exists(ofd.FileName) Then
            txtFileName.Text = ofd.FileName
        End If

    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        If txtFileName.Text = "" Then Exit Sub
        txtGenerateResult.Clear()

        Dim util As New cUtils()

        Dim Alldata As String = util.ReadAllText(txtFileName.Text)
        Dim rows() As String = util.ReadAllRows(Alldata)
        Dim CsvColumn As Integer = 1
        'Generate!
        For Each row In rows
            If row = "" Then Exit For
            Dim PropName As String = Split(row, ",")(0)
            Dim PropType As String = Split(row, ",")(1)

            txtGenerateResult.AppendText("private _" & PropName & " as " & PropType & vbCrLf)
            If chkAddLINQtoCSVAttribute.Checked Then
                txtGenerateResult.AppendText("<CsvColumn(FieldIndex:=" & CsvColumn & ")>" & vbCrLf)
            End If
            txtGenerateResult.AppendText("Public Property " & PropName & "() as " & PropType & vbCrLf)
            txtGenerateResult.AppendText("Get" & vbCrLf)
            txtGenerateResult.AppendText("return _" & PropName & vbCrLf)
            txtGenerateResult.AppendText("End Get" & vbCrLf)
            txtGenerateResult.AppendText("Set(ByVal value As String)" & vbCrLf)
            txtGenerateResult.AppendText("_" & PropName & "= value" & vbCrLf)
            txtGenerateResult.AppendText("End Set" & vbCrLf)
            txtGenerateResult.AppendText("End Property" & vbCrLf)
            txtGenerateResult.AppendText(vbCrLf)

            CsvColumn += 1
        Next

        If chkIsCreateNew.Checked Then
            txtGenerateResult.AppendText("sub new()" & vbCrLf)
            For Each row In rows

                If row = "" Then Exit For
                Dim PropName As String = Split(row, ",")(0)
                Dim PropType As String = Split(row, ",")(1)

                Select Case PropType.Trim.ToLower
                    Case "string"
                        txtGenerateResult.AppendText(PropName & " = " & """""" & vbCrLf)
                    Case "integer"
                        txtGenerateResult.AppendText(PropName & " = " & "0" & vbCrLf)
                    Case Else
                        txtGenerateResult.AppendText(PropName & " = " & "0" & vbCrLf)

                End Select
            Next

            txtGenerateResult.AppendText("end sub" & vbCrLf)

        End If


    End Sub



    Private Sub btnCopyToClipBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyToClipBoard.Click
        My.Computer.Clipboard.SetText(txtGenerateResult.Text)
        MessageBox.Show("Clipboard Copy Complete.")
    End Sub
End Class
Public Class cUtils

    Sub New()

    End Sub

    Public Function ReadAllText(ByVal filename As String) As String

        Return My.Computer.FileSystem.ReadAllText(filename, System.Text.Encoding.GetEncoding("Shift-JIS"))
    End Function

    Public Function ReadAllRows(ByVal Datas As String) As String()

        Return Split(Datas, vbCrLf)
    End Function

End Class