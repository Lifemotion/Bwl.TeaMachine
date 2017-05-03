Imports Bwl.Hardware.SimplSerial

Public Class App
    Private _tea As New TeaMachine

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _tea.Open()
        Catch ex As Exception
            _logger.AddWarning("TeaMachine Open: " + ex.Message)
        End Try

        Try
            tbProgram.Text = IO.File.ReadAllText(IO.Path.Combine(AppBase.DataFolder, "prog1.txt"))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SSTool_Click(sender As Object, e As EventArgs) Handles SSTool.Click
        Dim tool As New SimplSerialTool(_tea.SS)
        tool.Show()
    End Sub

    Private Sub bHeaterOn_Click(sender As Object, e As EventArgs) Handles bHeaterOn.Click
        _tea.SetHeater(255)
    End Sub

    Private Sub bHeaterOff_Click(sender As Object, e As EventArgs) Handles bHeaterOff.Click
        _tea.SetHeater(0)
    End Sub

    Private Sub bFlipper_Click(sender As Object, e As EventArgs) Handles bFlipper.Click
        _tea.Flipper({100, 100, 255})
    End Sub

    Private Sub bContainer1_Click(sender As Object, e As EventArgs) Handles bContainer1.Click
        _tea.Container(1, Val(tbContainerTime.Text))
    End Sub

    Private Sub bPumpMain_Click(sender As Object, e As EventArgs) Handles bPumpMain.Click
        _tea.SetPumps(Val(tbPumpMain.Text), 0)
    End Sub

    Private Sub bPumpClean_Click(sender As Object, e As EventArgs) Handles bPumpClean.Click
        _tea.SetPumps(0, Val(tbPumpClean.Text))
    End Sub

    Private Sub bPumpCleanOff_Click(sender As Object, e As EventArgs) Handles bPumpCleanOff.Click, bPumpMainOff.Click
        _tea.SetPumps(0, 0)
    End Sub

    Private Sub bRun_Click(sender As Object, e As EventArgs) Handles bRun.Click
        IO.File.WriteAllText(IO.Path.Combine(AppBase.DataFolder, "prog1.txt"), tbProgram.Text)

        Dim lines = tbProgram.Lines
        For Each line In lines
            line = line
            Dim parts = line.Split(" ")
            Try
                Select Case parts(0).ToUpper
                    Case "HEATER"
                        _tea.SetHeater(Val(parts(1)))
                    Case "FLIPPER"
                        Dim list As New List(Of Byte)
                        For i = 1 To parts.Length - 1
                            list.Add(Val(parts(i)))
                        Next
                        _tea.Flipper(list.ToArray)
                    Case "PUMPS"
                        _tea.SetPumps(Val(parts(1)), Val(parts(2)))
                    Case "CONTAINER"
                        _tea.Container(Val(parts(1)), Val(parts(2)))
                    Case "PAUSE"
                        Threading.Thread.Sleep(1000 * Val(parts(1)))
                End Select
            Catch ex As Exception

            End Try
        Next
    End Sub
End Class
