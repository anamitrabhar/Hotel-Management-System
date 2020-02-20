
Public Class HomeForm


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Application.Exit()


    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        LoginForm.Show()


    End Sub
    Private Sub btncheckin_Click(sender As Object, e As EventArgs) Handles btncheckin.Click
        If Not Panel3.Controls.Contains(CheckinForm.Instance) Then
            Panel3.Controls.Add(CheckinForm.Instance)
            CheckinForm.Instance.Dock = DockStyle.Fill
            CheckinForm.Instance.BringToFront()
            CheckinForm.Instance().Visible = True

        End If
        CheckinForm.Instance.BringToFront()
        CheckinForm.Instance.Visible = True



    End Sub

    Private Sub btncheckinlist_Click(sender As Object, e As EventArgs) Handles btncheckinlist.Click
        If Not Panel3.Controls.Contains(CheckinListForm.Instance) Then
            Panel3.Controls.Add(CheckinListForm.Instance)
            CheckinListForm.Instance.Dock = DockStyle.Fill
            CheckinListForm.Instance.BringToFront()
            CheckinListForm.Instance().Visible = True

        End If
        CheckinListForm.Instance.BringToFront()
        CheckinListForm.Instance.Visible = True
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Panel3.Controls.Contains(GuestForm.Instance) Then
            Panel3.Controls.Add(GuestForm.Instance)
            GuestForm.Instance.Dock = DockStyle.Fill
            GuestForm.Instance.BringToFront()
            GuestForm.Instance().Visible = True

        End If
        GuestForm.Instance.BringToFront()
        GuestForm.Instance.Visible = True
    End Sub

    Private Sub btnguestlist_Click(sender As Object, e As EventArgs) Handles btnguestlist.Click
        If Not Panel3.Controls.Contains(GuestListForm.Instance) Then
            Panel3.Controls.Add(GuestListForm.Instance)
            GuestListForm.Instance.Dock = DockStyle.Fill
            GuestListForm.Instance.BringToFront()
            GuestListForm.Instance().Visible = True

        End If
        GuestListForm.Instance.BringToFront()
        GuestListForm.Instance.Visible = True
    End Sub

    Private Sub btnroom_Click(sender As Object, e As EventArgs) Handles btnroom.Click
        If Not Panel3.Controls.Contains(RoomForm.Instance) Then
            Panel3.Controls.Add(RoomForm.Instance)
            RoomForm.Instance.Dock = DockStyle.Fill
            RoomForm.Instance.BringToFront()
            RoomForm.Instance().Visible = True

        End If
        RoomForm.Instance.BringToFront()
        RoomForm.Instance.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not Panel3.Controls.Contains(RoomListForm.Instance) Then
            Panel3.Controls.Add(RoomListForm.Instance)
            RoomListForm.Instance.Dock = DockStyle.Fill
            RoomListForm.Instance.BringToFront()
            RoomListForm.Instance().Visible = True

        End If
        RoomListForm.Instance.BringToFront()
        RoomListForm.Instance.Visible = True
    End Sub

    Private Sub btnreservation_Click(sender As Object, e As EventArgs) Handles btnreservation.Click
        If Not Panel3.Controls.Contains(CheckoutForm.Instance) Then
            Panel3.Controls.Add(CheckoutForm.Instance)
            CheckoutForm.Instance.Dock = DockStyle.Fill
            CheckoutForm.Instance.BringToFront()
            CheckoutForm.Instance().Visible = True

        End If
        CheckoutForm.Instance.BringToFront()
        CheckoutForm.Instance.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not Panel3.Controls.Contains(CheckoutListForm.Instance) Then
            Panel3.Controls.Add(CheckoutListForm.Instance)
            CheckoutListForm.Instance.Dock = DockStyle.Fill
            CheckoutListForm.Instance.BringToFront()
            CheckoutListForm.Instance().Visible = True

        End If
        CheckoutListForm.Instance.BringToFront()
        CheckoutListForm.Instance.Visible = True
    End Sub

    Private Sub btndiscount_Click(sender As Object, e As EventArgs) Handles btndiscount.Click
        If Not Panel3.Controls.Contains(DiscountForm.Instance) Then
            Panel3.Controls.Add(DiscountForm.Instance)
            DiscountForm.Instance.Dock = DockStyle.Fill
            DiscountForm.Instance.BringToFront()
            DiscountForm.Instance().Visible = True

        End If
        DiscountForm.Instance.BringToFront()
        DiscountForm.Instance.Visible = True
    End Sub
End Class
