'█▀▀█ █▀▀▄ █▀▀█ █▀▀▄ █▀▀   █▀▀ █▀▀█ █▀▀▄ █▀▀▄ █▀▀ █▀▀ ▀▀█▀▀   █▀▀▄ █▀▀█ ▀▀█▀▀'
'█▄▄█ █░░█ █░░█ █▀▀▄ █▀▀   █░░ █░░█ █░░█ █░░█ █▀▀ █░░ ░░█░░   █▀▀▄ █░░█ ░░█░░'
'▀░░▀ ▀▀▀░ ▀▀▀▀ ▀▀▀░ ▀▀▀   ▀▀▀ ▀▀▀▀ ▀░░▀ ▀░░▀ ▀▀▀ ▀▀▀ ░░▀░░   ▀▀▀░ ▀▀▀▀ ░░▀░░'

'What is this?'
'Adobe connect bot is a bot made using VB.NET. It can recognize text from an adobe connect session and it can respond automatically.'

'How do I use this?'
'Simply start the project. Then, go to your adobe connect session and increase the text size to "24" (what I found worked best)
'and then drag the window to the chat and make sure you can see the chat through the transparent box.
'Then, set the trigger and response. For example, if you want someone to say bpizza and then you to respond automatically, put the trigger as
'bpizza and put the response as whatever you want the bot to respond as

'Support for this bot has sadly ended, but I may update it at times.
'This bot is made in VB.NET which I hate, but I didn't know how to make an OCR engine in C#
'THIS BOT IS 100% MADE BY FROZEN3547/FROZENPVPS

Imports Emgu.CV
Imports Emgu.Util
Imports Emgu.CV.OCR
Imports Emgu.CV.Structure
Public Class Form1
    Dim OCRz As Tesseract = New Tesseract("tessdata", "eng", Tesseract.OcrEngineMode.OEM_DEFAULT)
    Dim pic As Bitmap = New Bitmap(270, 100)
    Dim gfx As Graphics = Graphics.FromImage(pic)
    'All this code does is loads the OCR and sets it to recognize the characters in the picturebox.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Made by FrozenPvPs/Frozen3547")
        'This just shows a messagebox with credits when the Form loads
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        gfx.CopyFromScreen(New Point(Me.Location.X + PictureBox1.Location.X + 4, Me.Location.Y + PictureBox1.Location.Y + 30), New Point(0, 0), pic.Size)
        PictureBox1.Image = pic
        PictureBox1.Image = Nothing
        'This code just gives a signal to the OCR scanner to recognize the characters
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer3.Start()
        'Starts a timer
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Stop()
        'Starts a timer
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        TopMost = False
        'TopMost button
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        OCRz.Recognize(New Image(Of Bgr, Byte)(pic))
        TextBox1.Text = OCRz.GetText
        If TextBox4.Text = "" Then
        Else
            If InStr(TextBox1.Text, TextBox4.Text) Then
                SendKeys.Send(TextBox5.Text)
                SendKeys.Send("{ENTER}")
            End If
        End If
        If TextBox7.Text = "" Then
        Else
            If InStr(TextBox1.Text, TextBox7.Text) Then
                SendKeys.Send(TextBox6.Text)
                SendKeys.Send("{ENTER}")
            End If
        End If
        If TextBox9.Text = "" Then
        Else
            If InStr(TextBox1.Text, TextBox9.Text) Then
                SendKeys.Send(TextBox8.Text)
                SendKeys.Send("{ENTER}")
            End If
        End If
        If TextBox11.Text = "" Then
        Else
            If InStr(TextBox1.Text, TextBox11.Text) Then
                SendKeys.Send(TextBox10.Text)
                SendKeys.Send("{ENTER}")
            End If
        End If
        If TextBox13.Text = "" Then
        Else
            If InStr(TextBox1.Text, TextBox13.Text) Then
                SendKeys.Send(TextBox12.Text)
                SendKeys.Send("{ENTER}")
            End If
        End If
        If TextBox15.Text = "" Then
        Else
            If InStr(TextBox1.Text, TextBox15.Text) Then
                SendKeys.Send(TextBox14.Text)
                SendKeys.Send("{ENTER}")
            End If
        End If
        If TextBox17.Text = "" Then
        Else
            If InStr(TextBox1.Text, TextBox17.Text) Then
                SendKeys.Send(TextBox16.Text)
                SendKeys.Send("{ENTER}")
            End If
        End If
        If TextBox19.Text = "" Then
        Else
            If InStr(TextBox1.Text, TextBox19.Text) Then
                SendKeys.Send(TextBox18.Text)
                SendKeys.Send("{ENTER}")
            End If
        End If
        'What this code does is it reads the trigger + the response and see's if the text in the little invisible section is correct.
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Interval = TextBox3.Text

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TopMost = True
        Else
        TopMost = False
        End If
        'TopMost checkbox
    End Sub

    Private Sub Timer3_Tick_1(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer2.Start()
        Timer3.Stop()
        'Starts/Stops a function
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer3.Interval = TextBox20.Text
        'Sets the interval for when the OCR scans
    End Sub
End Class
