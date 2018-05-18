Public Class You_spin_my_head_right_round
    Dim pX, pY, pXs, pYs As Integer
    Dim x As Byte
    Dim color1 As Color
    Dim screenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)

    Private Sub You_spin_my_head_right_round_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer4.Start()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        pXs = Me.Location.X + 10 + 25
        pYs = Me.Location.Y + 35 + 25
        positionLabel.Text = "X: " & pXs.ToString & ", Y: " & pYs.ToString

        Me.Visible = False
        System.Threading.Thread.Sleep(1000)
        screenSize = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)

        Using screenGrab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)

            Using g As Graphics = Graphics.FromImage(screenGrab)

                g.CopyFromScreen(New Point(pX, pY), New Point(pX, pY), screenSize)

                color1 = screenGrab.GetPixel(pX, pY)
                color1Label.BackColor = color1

            End Using

        End Using
        status.Text = "ready..."
        Me.Visible = True
        Me.SetDesktopLocation(Me.Location.X + 100, Me.Location.Y)
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        pX = Me.Location.X + 10 + 25
        pY = Me.Location.Y + 35 + 25
        currpos.Text = "X: " & pX.ToString & vbCrLf & "Y: " & pY.ToString

        Dim rect As Rectangle = New Rectangle(pXs - 3, pYs - 3, 6, 6)
        Using g As Graphics = Graphics.FromHwnd(IntPtr.Zero)
            Using lgb As New Drawing2D.LinearGradientBrush(rect, Color.Red, Color.Orange, 90, True)
                g.DrawRectangle(Pens.Red, rect)
            End Using
        End Using


    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        status.Text = "waiting..."

        Using screenGrab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)

            Using g As Graphics = Graphics.FromImage(screenGrab)

                g.CopyFromScreen(New Point(pXs, pYs), New Point(pXs, pYs), screenSize)

                Dim currentcolor As Color = screenGrab.GetPixel(pXs, pYs)

                If Not currentcolor.ToString.Equals(color1.ToString) Then
                    Timer2.Stop()
                    SendSerialData(RichTextBox1.Text)

                End If

            End Using

        End Using
    End Sub

    Sub SendSerialData(ByVal data As String)

        Try
            ' Send strings to a serial port.
            Using com As IO.Ports.SerialPort =
                    My.Computer.Ports.OpenSerialPort(TextboxPort.Text)
                com.WriteLine(data)
            End Using
            status.Text = "send! :)"


        Catch ex As Exception
            status.Text = "failed."
        End Try

        x = 0
        Timer3.Start()

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer2.Start()
        Button4.Visible = False
        Button1.Visible = True
    End Sub


    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        status.Text = "sleep " & x - 10
        x = x + 1
        If x = 10 Then
            Timer2.Start()
            Timer3.Stop()
        End If


    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Using screenGrab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)

            Using g As Graphics = Graphics.FromImage(screenGrab)

                g.CopyFromScreen(New Point(pX, pY), New Point(pX, pY), screenSize)
                cColor.BackColor = screenGrab.GetPixel(pX, pY)

            End Using
        End Using
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button4.Visible = True
        Button1.Visible = False
        Timer2.Stop()
        status.Text = "stoped."
    End Sub
End Class
