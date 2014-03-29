<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.檔案FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.選擇檔案FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.選擇資料夾DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.執行EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OFD1
        '
        Me.OFD1.Multiselect = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.檔案FToolStripMenuItem, Me.執行EToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1429, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '檔案FToolStripMenuItem
        '
        Me.檔案FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.選擇檔案FToolStripMenuItem, Me.選擇資料夾DToolStripMenuItem})
        Me.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem"
        Me.檔案FToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.檔案FToolStripMenuItem.Text = "檔案(&F)"
        '
        '選擇檔案FToolStripMenuItem
        '
        Me.選擇檔案FToolStripMenuItem.Name = "選擇檔案FToolStripMenuItem"
        Me.選擇檔案FToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.選擇檔案FToolStripMenuItem.Text = "選擇檔案(&F)"
        '
        '選擇資料夾DToolStripMenuItem
        '
        Me.選擇資料夾DToolStripMenuItem.Name = "選擇資料夾DToolStripMenuItem"
        Me.選擇資料夾DToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.選擇資料夾DToolStripMenuItem.Text = "選擇資料夾(&D)"
        '
        '執行EToolStripMenuItem
        '
        Me.執行EToolStripMenuItem.Name = "執行EToolStripMenuItem"
        Me.執行EToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.執行EToolStripMenuItem.Text = "執行(&E)"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.AllowDrop = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(0, 27)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(408, 446)
        Me.CheckedListBox1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.Location = New System.Drawing.Point(423, 27)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(434, 448)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.SmallIcon
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(863, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(488, 448)
        Me.ListBox1.TabIndex = 4
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 533)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1223, 23)
        Me.ProgressBar1.TabIndex = 5
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1429, 568)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Visual ReNamer .NET"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OFD1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 檔案FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 選擇檔案FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 選擇資料夾DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 執行EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
