<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class App
    Inherits Bwl.Framework.FormAppBase

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SSTool = New System.Windows.Forms.Button()
        Me.bHeaterOn = New System.Windows.Forms.Button()
        Me.bHeaterOff = New System.Windows.Forms.Button()
        Me.bContainer1 = New System.Windows.Forms.Button()
        Me.bFlipper = New System.Windows.Forms.Button()
        Me.tbPumpMain = New System.Windows.Forms.TextBox()
        Me.bPumpMain = New System.Windows.Forms.Button()
        Me.bPumpMainOff = New System.Windows.Forms.Button()
        Me.bPumpCleanOff = New System.Windows.Forms.Button()
        Me.bPumpClean = New System.Windows.Forms.Button()
        Me.tbPumpClean = New System.Windows.Forms.TextBox()
        Me.tbContainerTime = New System.Windows.Forms.TextBox()
        Me.tbProgram = New System.Windows.Forms.TextBox()
        Me.bRun = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'logWriter
        '
        Me.logWriter.Location = New System.Drawing.Point(2, 357)
        Me.logWriter.Size = New System.Drawing.Size(1039, 203)
        '
        'SSTool
        '
        Me.SSTool.Location = New System.Drawing.Point(12, 27)
        Me.SSTool.Name = "SSTool"
        Me.SSTool.Size = New System.Drawing.Size(75, 23)
        Me.SSTool.TabIndex = 2
        Me.SSTool.Text = "SSTool"
        Me.SSTool.UseVisualStyleBackColor = True
        '
        'bHeaterOn
        '
        Me.bHeaterOn.Location = New System.Drawing.Point(93, 27)
        Me.bHeaterOn.Name = "bHeaterOn"
        Me.bHeaterOn.Size = New System.Drawing.Size(75, 23)
        Me.bHeaterOn.TabIndex = 3
        Me.bHeaterOn.Text = "Heater On"
        Me.bHeaterOn.UseVisualStyleBackColor = True
        '
        'bHeaterOff
        '
        Me.bHeaterOff.Location = New System.Drawing.Point(174, 27)
        Me.bHeaterOff.Name = "bHeaterOff"
        Me.bHeaterOff.Size = New System.Drawing.Size(75, 23)
        Me.bHeaterOff.TabIndex = 4
        Me.bHeaterOff.Text = "Heater Off"
        Me.bHeaterOff.UseVisualStyleBackColor = True
        '
        'bContainer1
        '
        Me.bContainer1.Location = New System.Drawing.Point(93, 85)
        Me.bContainer1.Name = "bContainer1"
        Me.bContainer1.Size = New System.Drawing.Size(75, 23)
        Me.bContainer1.TabIndex = 5
        Me.bContainer1.Text = "Container 1"
        Me.bContainer1.UseVisualStyleBackColor = True
        '
        'bFlipper
        '
        Me.bFlipper.Location = New System.Drawing.Point(93, 56)
        Me.bFlipper.Name = "bFlipper"
        Me.bFlipper.Size = New System.Drawing.Size(75, 23)
        Me.bFlipper.TabIndex = 6
        Me.bFlipper.Text = "Flipper"
        Me.bFlipper.UseVisualStyleBackColor = True
        '
        'tbPumpMain
        '
        Me.tbPumpMain.Location = New System.Drawing.Point(174, 114)
        Me.tbPumpMain.Name = "tbPumpMain"
        Me.tbPumpMain.Size = New System.Drawing.Size(75, 20)
        Me.tbPumpMain.TabIndex = 7
        Me.tbPumpMain.Text = "100"
        '
        'bPumpMain
        '
        Me.bPumpMain.Location = New System.Drawing.Point(93, 114)
        Me.bPumpMain.Name = "bPumpMain"
        Me.bPumpMain.Size = New System.Drawing.Size(75, 23)
        Me.bPumpMain.TabIndex = 8
        Me.bPumpMain.Text = "Pump Main"
        Me.bPumpMain.UseVisualStyleBackColor = True
        '
        'bPumpMainOff
        '
        Me.bPumpMainOff.Location = New System.Drawing.Point(255, 114)
        Me.bPumpMainOff.Name = "bPumpMainOff"
        Me.bPumpMainOff.Size = New System.Drawing.Size(75, 23)
        Me.bPumpMainOff.TabIndex = 9
        Me.bPumpMainOff.Text = " Off"
        Me.bPumpMainOff.UseVisualStyleBackColor = True
        '
        'bPumpCleanOff
        '
        Me.bPumpCleanOff.Location = New System.Drawing.Point(255, 143)
        Me.bPumpCleanOff.Name = "bPumpCleanOff"
        Me.bPumpCleanOff.Size = New System.Drawing.Size(75, 23)
        Me.bPumpCleanOff.TabIndex = 12
        Me.bPumpCleanOff.Text = "Off"
        Me.bPumpCleanOff.UseVisualStyleBackColor = True
        '
        'bPumpClean
        '
        Me.bPumpClean.Location = New System.Drawing.Point(93, 143)
        Me.bPumpClean.Name = "bPumpClean"
        Me.bPumpClean.Size = New System.Drawing.Size(75, 23)
        Me.bPumpClean.TabIndex = 11
        Me.bPumpClean.Text = "Pump Clean"
        Me.bPumpClean.UseVisualStyleBackColor = True
        '
        'tbPumpClean
        '
        Me.tbPumpClean.Location = New System.Drawing.Point(174, 143)
        Me.tbPumpClean.Name = "tbPumpClean"
        Me.tbPumpClean.Size = New System.Drawing.Size(75, 20)
        Me.tbPumpClean.TabIndex = 10
        Me.tbPumpClean.Text = "100"
        '
        'tbContainerTime
        '
        Me.tbContainerTime.Location = New System.Drawing.Point(174, 87)
        Me.tbContainerTime.Name = "tbContainerTime"
        Me.tbContainerTime.Size = New System.Drawing.Size(75, 20)
        Me.tbContainerTime.TabIndex = 13
        Me.tbContainerTime.Text = "100"
        '
        'tbProgram
        '
        Me.tbProgram.Location = New System.Drawing.Point(367, 27)
        Me.tbProgram.Multiline = True
        Me.tbProgram.Name = "tbProgram"
        Me.tbProgram.Size = New System.Drawing.Size(352, 327)
        Me.tbProgram.TabIndex = 14
        Me.tbProgram.Text = "100"
        '
        'bRun
        '
        Me.bRun.Location = New System.Drawing.Point(725, 331)
        Me.bRun.Name = "bRun"
        Me.bRun.Size = New System.Drawing.Size(75, 23)
        Me.bRun.TabIndex = 15
        Me.bRun.Text = "Run"
        Me.bRun.UseVisualStyleBackColor = True
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 561)
        Me.Controls.Add(Me.bRun)
        Me.Controls.Add(Me.tbProgram)
        Me.Controls.Add(Me.tbContainerTime)
        Me.Controls.Add(Me.bPumpCleanOff)
        Me.Controls.Add(Me.bPumpClean)
        Me.Controls.Add(Me.tbPumpClean)
        Me.Controls.Add(Me.bPumpMainOff)
        Me.Controls.Add(Me.bPumpMain)
        Me.Controls.Add(Me.tbPumpMain)
        Me.Controls.Add(Me.bFlipper)
        Me.Controls.Add(Me.bContainer1)
        Me.Controls.Add(Me.bHeaterOff)
        Me.Controls.Add(Me.bHeaterOn)
        Me.Controls.Add(Me.SSTool)
        Me.Name = "App"
        Me.Text = "Bwl.TeaMachine"
        Me.Controls.SetChildIndex(Me.logWriter, 0)
        Me.Controls.SetChildIndex(Me.SSTool, 0)
        Me.Controls.SetChildIndex(Me.bHeaterOn, 0)
        Me.Controls.SetChildIndex(Me.bHeaterOff, 0)
        Me.Controls.SetChildIndex(Me.bContainer1, 0)
        Me.Controls.SetChildIndex(Me.bFlipper, 0)
        Me.Controls.SetChildIndex(Me.tbPumpMain, 0)
        Me.Controls.SetChildIndex(Me.bPumpMain, 0)
        Me.Controls.SetChildIndex(Me.bPumpMainOff, 0)
        Me.Controls.SetChildIndex(Me.tbPumpClean, 0)
        Me.Controls.SetChildIndex(Me.bPumpClean, 0)
        Me.Controls.SetChildIndex(Me.bPumpCleanOff, 0)
        Me.Controls.SetChildIndex(Me.tbContainerTime, 0)
        Me.Controls.SetChildIndex(Me.tbProgram, 0)
        Me.Controls.SetChildIndex(Me.bRun, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SSTool As Button
    Friend WithEvents bHeaterOn As Button
    Friend WithEvents bHeaterOff As Button
    Friend WithEvents bContainer1 As Button
    Friend WithEvents bFlipper As Button
    Friend WithEvents tbPumpMain As TextBox
    Friend WithEvents bPumpMain As Button
    Friend WithEvents bPumpMainOff As Button
    Friend WithEvents bPumpCleanOff As Button
    Friend WithEvents bPumpClean As Button
    Friend WithEvents tbPumpClean As TextBox
    Friend WithEvents tbContainerTime As TextBox
    Friend WithEvents tbProgram As TextBox
    Friend WithEvents bRun As Button
End Class
