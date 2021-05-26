Imports WMPLib

Public Class Form1
    Private player As New WMPLib.WindowsMediaPlayer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '開剁
        Button1.Enabled = False
        Button1.Visible = False
        Timer1.Enabled = True
        Timer2.Enabled = True
        Label4.Text = 30
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '先別剁
        Button1.Enabled = True
        Button1.Visible = True
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Timer1.Enabled = False
        Timer2.Enabled = False
        Label2.Text = 0
        Label4.Text = 30
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '國動亂跳
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        Randomize()
        PictureBox1.Left = Int(20 + Rnd() * (Me.Width - 40 + PictureBox1.Left - 0 + 1))
        Randomize()
        PictureBox2.Left = Int(20 + Rnd() * (Me.Width - 40 + PictureBox1.Left - 0 + 1))
        Randomize()
        PictureBox3.Left = Int(20 + Rnd() * (Me.Width - 40 + PictureBox1.Left - 0 + 1))
        Randomize()
        PictureBox4.Left = Int(20 + Rnd() * (Me.Width - 40 + PictureBox1.Left - 0 + 1))
        PictureBox1.Enabled = True
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        '國動加分
        Label2.Text += 1
        PictureBox1.Enabled = False
        PictureBox1.Visible = False
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        '國動加分
        Label2.Text += 1
        PictureBox2.Enabled = False
        PictureBox2.Visible = False
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        '國動加分
        Label2.Text += 1
        PictureBox3.Enabled = False
        PictureBox3.Visible = False
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        '國動加分
        Label2.Text += 1
        PictureBox4.Enabled = False
        PictureBox4.Visible = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '時間倒數
        Label4.Text -= 1
        If Label4.Text < 0 Then   '當時間結束
            Button1.Enabled = True
            Button1.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            Timer1.Enabled = False
            Timer2.Enabled = False
            Label4.Text = 30
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        '宣告成績
        Button1.Enabled = False
        Button2.Enabled = False
        Label5.Visible = True
        Label6.Visible = True
        Label6.Text = Label2.Text
        Label2.Text = 0
        Timer3.Enabled = False
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label5.Visible = False
        Label6.Visible = False
        Button1.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player.URL = My.Application.Info.DirectoryPath & "\BackMusic123.wav"
        player.settings.setMode("loop", True)
        player.settings.volume = 5
    End Sub
End Class
