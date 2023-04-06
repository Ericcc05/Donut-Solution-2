Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblsubtotal As Double
        Dim dblsalestax As Double
        Dim dbltotal As Double

        If radGlazed.Checked Then
            dblsubtotal = dblsubtotal + 1.05
            If radChoco.Checked Then
                dblsubtotal = dblsubtotal + 1.25
                If radFill.Checked Then
                    dblsubtotal = dblsubtotal + 1.5
                    If radSugar.Checked Then
                        dblsubtotal = 1.05
                    End If
                End If
            End If
        End If
        If radReg.Checked Then
            dblsubtotal = dblsubtotal + 1.5

        End If


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
