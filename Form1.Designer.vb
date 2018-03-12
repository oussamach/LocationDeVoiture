<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MAJClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MAJVoitureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LIsteVoitureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CategorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LOcationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MAJClientToolStripMenuItem, Me.MAJVoitureToolStripMenuItem, Me.LIsteVoitureToolStripMenuItem, Me.CategorieToolStripMenuItem, Me.LOcationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(647, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MAJClientToolStripMenuItem
        '
        Me.MAJClientToolStripMenuItem.Name = "MAJClientToolStripMenuItem"
        Me.MAJClientToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.MAJClientToolStripMenuItem.Text = "MAJ Client"
        '
        'MAJVoitureToolStripMenuItem
        '
        Me.MAJVoitureToolStripMenuItem.Name = "MAJVoitureToolStripMenuItem"
        Me.MAJVoitureToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MAJVoitureToolStripMenuItem.Text = "MAJ voiture"
        '
        'LIsteVoitureToolStripMenuItem
        '
        Me.LIsteVoitureToolStripMenuItem.Name = "LIsteVoitureToolStripMenuItem"
        Me.LIsteVoitureToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.LIsteVoitureToolStripMenuItem.Text = "LIste voiture"
        '
        'CategorieToolStripMenuItem
        '
        Me.CategorieToolStripMenuItem.Name = "CategorieToolStripMenuItem"
        Me.CategorieToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.CategorieToolStripMenuItem.Text = "Categorie"
        '
        'LOcationToolStripMenuItem
        '
        Me.LOcationToolStripMenuItem.Name = "LOcationToolStripMenuItem"
        Me.LOcationToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.LOcationToolStripMenuItem.Text = "LOcation"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 543)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MAJClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MAJVoitureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LIsteVoitureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategorieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOcationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
