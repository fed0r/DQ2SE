<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LoadFileBtn = New System.Windows.Forms.Button()
        Me.PlayerProfiles = New System.Windows.Forms.ListBox()
        Me.AddGoldBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PotsButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Difficulty = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DifficultyBtn = New System.Windows.Forms.Button()
        Me.DiffHC = New System.Windows.Forms.RadioButton()
        Me.DiffNormal = New System.Windows.Forms.RadioButton()
        Me.DiffEasy = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LoadFileBtn)
        Me.GroupBox1.Controls.Add(Me.PlayerProfiles)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 220)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Load data"
        '
        'LoadFileBtn
        '
        Me.LoadFileBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadFileBtn.ForeColor = System.Drawing.Color.Red
        Me.LoadFileBtn.Location = New System.Drawing.Point(194, 19)
        Me.LoadFileBtn.Name = "LoadFileBtn"
        Me.LoadFileBtn.Size = New System.Drawing.Size(128, 43)
        Me.LoadFileBtn.TabIndex = 4
        Me.LoadFileBtn.Text = "Load file"
        Me.LoadFileBtn.UseVisualStyleBackColor = True
        '
        'PlayerProfiles
        '
        Me.PlayerProfiles.FormattingEnabled = True
        Me.PlayerProfiles.Location = New System.Drawing.Point(6, 19)
        Me.PlayerProfiles.Name = "PlayerProfiles"
        Me.PlayerProfiles.Size = New System.Drawing.Size(170, 43)
        Me.PlayerProfiles.TabIndex = 3
        '
        'AddGoldBtn
        '
        Me.AddGoldBtn.Enabled = False
        Me.AddGoldBtn.Location = New System.Drawing.Point(6, 19)
        Me.AddGoldBtn.Name = "AddGoldBtn"
        Me.AddGoldBtn.Size = New System.Drawing.Size(171, 27)
        Me.AddGoldBtn.TabIndex = 2
        Me.AddGoldBtn.Text = "Add Gold"
        Me.ToolTip1.SetToolTip(Me.AddGoldBtn, "Push this button for massive amount of gold!")
        Me.AddGoldBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.PotsButton)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.AddGoldBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 373)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editor"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DQ2SE.My.Resources.Resources.nice1
        Me.PictureBox1.Location = New System.Drawing.Point(183, 161)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PotsButton
        '
        Me.PotsButton.Enabled = False
        Me.PotsButton.Location = New System.Drawing.Point(6, 55)
        Me.PotsButton.Name = "PotsButton"
        Me.PotsButton.Size = New System.Drawing.Size(170, 27)
        Me.PotsButton.TabIndex = 5
        Me.PotsButton.Text = "Add Magic Pots"
        Me.ToolTip1.SetToolTip(Me.PotsButton, "Push this button for massive amount of gold!")
        Me.PotsButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Difficulty)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.DifficultyBtn)
        Me.GroupBox3.Controls.Add(Me.DiffHC)
        Me.GroupBox3.Controls.Add(Me.DiffNormal)
        Me.GroupBox3.Controls.Add(Me.DiffEasy)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(183, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(152, 145)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Difficulty"
        '
        'Difficulty
        '
        Me.Difficulty.AutoSize = True
        Me.Difficulty.Location = New System.Drawing.Point(132, 16)
        Me.Difficulty.Name = "Difficulty"
        Me.Difficulty.Size = New System.Drawing.Size(14, 13)
        Me.Difficulty.TabIndex = 7
        Me.Difficulty.Text = "0"
        Me.Difficulty.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Too easy or too hard?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Change difficulty!"
        '
        'DifficultyBtn
        '
        Me.DifficultyBtn.Enabled = False
        Me.DifficultyBtn.Location = New System.Drawing.Point(6, 116)
        Me.DifficultyBtn.Name = "DifficultyBtn"
        Me.DifficultyBtn.Size = New System.Drawing.Size(140, 23)
        Me.DifficultyBtn.TabIndex = 5
        Me.DifficultyBtn.Text = "Change"
        Me.DifficultyBtn.UseVisualStyleBackColor = True
        '
        'DiffHC
        '
        Me.DiffHC.AutoSize = True
        Me.DiffHC.Enabled = False
        Me.DiffHC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffHC.Location = New System.Drawing.Point(6, 93)
        Me.DiffHC.Name = "DiffHC"
        Me.DiffHC.Size = New System.Drawing.Size(69, 17)
        Me.DiffHC.TabIndex = 2
        Me.DiffHC.TabStop = True
        Me.DiffHC.Text = "Hardcore"
        Me.DiffHC.UseVisualStyleBackColor = True
        '
        'DiffNormal
        '
        Me.DiffNormal.AutoSize = True
        Me.DiffNormal.Enabled = False
        Me.DiffNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffNormal.Location = New System.Drawing.Point(6, 70)
        Me.DiffNormal.Name = "DiffNormal"
        Me.DiffNormal.Size = New System.Drawing.Size(58, 17)
        Me.DiffNormal.TabIndex = 1
        Me.DiffNormal.TabStop = True
        Me.DiffNormal.Text = "Normal"
        Me.DiffNormal.UseVisualStyleBackColor = True
        '
        'DiffEasy
        '
        Me.DiffEasy.AutoSize = True
        Me.DiffEasy.Enabled = False
        Me.DiffEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiffEasy.Location = New System.Drawing.Point(6, 46)
        Me.DiffEasy.Name = "DiffEasy"
        Me.DiffEasy.Size = New System.Drawing.Size(48, 17)
        Me.DiffEasy.TabIndex = 0
        Me.DiffEasy.TabStop = True
        Me.DiffEasy.Text = "Easy"
        Me.DiffEasy.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 395)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(354, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(59, 17)
        Me.StatusLabel.Text = "Standby..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 417)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "DQ2SE - Dark Quest II Save Editor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AddGoldBtn As Button
    Friend WithEvents PlayerProfiles As ListBox
    Friend WithEvents LoadFileBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DiffHC As RadioButton
    Friend WithEvents DiffNormal As RadioButton
    Friend WithEvents DiffEasy As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DifficultyBtn As Button
    Friend WithEvents PotsButton As Button
    Friend WithEvents Difficulty As Label
End Class
