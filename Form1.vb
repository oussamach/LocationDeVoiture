Public Class Form1

    Private Sub MAJClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAJClientToolStripMenuItem.Click
        client.MdiParent = Me
        client.Show()
    End Sub

    Private Sub MAJVoitureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAJVoitureToolStripMenuItem.Click
        voiture.MdiParent = Me
        voiture.Show()
    End Sub

    Private Sub LIsteVoitureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIsteVoitureToolStripMenuItem.Click
        liste_voiture.MdiParent = Me
        liste_voiture.Show()
    End Sub
End Class
