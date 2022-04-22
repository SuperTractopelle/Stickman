Public Class Form1

    Dim Counter As Int16 = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False 'on n'affiche rien dans la taskbar
        Me.TopMost = True 'affichage par dessus tout obligatoire
        Application.DoEvents()
        Me.Activate() 'on passe par dessus les autres fenêtres
        Me.StartPosition = FormStartPosition.Manual 'positionnement libre
        Me.Location = New Point(-170, 0) 'emplacement de départ
        Timer1.Start() 'on démarre le deplacement
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Location = New Point(Me.Location.X + 100, Me.Location.Y + 10)
        If Counter = 0 Then
            Counter += 1
            Me.BackgroundImage = My.Resources._1
        ElseIf Counter = 1 Then
            Counter += 1
            Me.BackgroundImage = My.Resources._2
        ElseIf Counter = 2 Then
            Counter += 1
            Me.BackgroundImage = My.Resources._3
        ElseIf Counter = 3 Then
            Counter += 1
            Me.BackgroundImage = My.Resources._4
        ElseIf Counter = 4 Then
            Counter += 1
            Me.BackgroundImage = My.Resources._5
        ElseIf Counter = 5 Then
            Counter = 0
            Me.BackgroundImage = My.Resources._6
        End If
        If Me.Location.X >= 3800 Then
            Me.Close()
        End If
        Me.Activate()
    End Sub
End Class
