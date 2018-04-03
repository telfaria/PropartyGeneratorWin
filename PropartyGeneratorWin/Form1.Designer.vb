<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtGenerateResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkIsCreateNew = New System.Windows.Forms.CheckBox()
        Me.btnCopyToClipBoard = New System.Windows.Forms.Button()
        Me.chkAddLINQtoCSVAttribute = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(350, 70)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(139, 35)
        Me.btnGenerate.TabIndex = 6
        Me.btnGenerate.Text = "Generate!"
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Location = New System.Drawing.Point(44, 49)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(24, 12)
        Me.lblFilename.TabIndex = 1
        Me.lblFilename.Text = "File"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(74, 46)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(162, 19)
        Me.txtFileName.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(242, 44)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(102, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtGenerateResult
        '
        Me.txtGenerateResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGenerateResult.Location = New System.Drawing.Point(0, 151)
        Me.txtGenerateResult.Multiline = True
        Me.txtGenerateResult.Name = "txtGenerateResult"
        Me.txtGenerateResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtGenerateResult.Size = New System.Drawing.Size(501, 169)
        Me.txtGenerateResult.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Property Generator for VB.NET"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAddLINQtoCSVAttribute)
        Me.GroupBox1.Controls.Add(Me.chkIsCreateNew)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 64)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'chkIsCreateNew
        '
        Me.chkIsCreateNew.AutoSize = True
        Me.chkIsCreateNew.Location = New System.Drawing.Point(6, 18)
        Me.chkIsCreateNew.Name = "chkIsCreateNew"
        Me.chkIsCreateNew.Size = New System.Drawing.Size(184, 16)
        Me.chkIsCreateNew.TabIndex = 0
        Me.chkIsCreateNew.Text = "Create with 'sub New()' method"
        Me.chkIsCreateNew.UseVisualStyleBackColor = True
        '
        'btnCopyToClipBoard
        '
        Me.btnCopyToClipBoard.Location = New System.Drawing.Point(350, 111)
        Me.btnCopyToClipBoard.Name = "btnCopyToClipBoard"
        Me.btnCopyToClipBoard.Size = New System.Drawing.Size(139, 34)
        Me.btnCopyToClipBoard.TabIndex = 8
        Me.btnCopyToClipBoard.Text = "↓Copy To ClipBoard"
        Me.btnCopyToClipBoard.UseVisualStyleBackColor = True
        '
        'chkAddLINQtoCSVAttribute
        '
        Me.chkAddLINQtoCSVAttribute.AutoSize = True
        Me.chkAddLINQtoCSVAttribute.Location = New System.Drawing.Point(6, 40)
        Me.chkAddLINQtoCSVAttribute.Name = "chkAddLINQtoCSVAttribute"
        Me.chkAddLINQtoCSVAttribute.Size = New System.Drawing.Size(242, 16)
        Me.chkAddLINQtoCSVAttribute.TabIndex = 1
        Me.chkAddLINQtoCSVAttribute.Text = "Add '<CsvColumn(fieldindex:=n)>' Attribute"
        Me.chkAddLINQtoCSVAttribute.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 320)
        Me.Controls.Add(Me.btnCopyToClipBoard)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGenerateResult)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.lblFilename)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "Form1"
        Me.Text = "Proparty Generator for VB.NET"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lblFilename As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtGenerateResult As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkIsCreateNew As System.Windows.Forms.CheckBox
    Friend WithEvents btnCopyToClipBoard As System.Windows.Forms.Button
    Friend WithEvents chkAddLINQtoCSVAttribute As System.Windows.Forms.CheckBox

End Class
