Imports Bwl.Hardware.SimplSerial

Public Class TeaMachine
    Public Property SS As New SimplSerialBus

    Public Sub Open()
        SS.SerialDevice.DeviceAddress = IO.Ports.SerialPort.GetPortNames(0)
        SS.SerialDevice.DeviceSpeed = 9600
        SS.Connect()
    End Sub

    Public Sub SetHeater(value As Byte)
        _SS.Request(New SSRequest(0, 21, {value}))
    End Sub

    Public Sub SetPumps(main As Byte, cleaner As Byte)
        _SS.Request(New SSRequest(0, 22, {main, cleaner}))
    End Sub

    Public Sub Flipper(steps() As Byte)
        _SS.Request(New SSRequest(0, 23, steps))
    End Sub

    Public Sub Container(index As Byte, time As Byte)
        _SS.Request(New SSRequest(0, 24, {index, time}))
    End Sub
End Class
