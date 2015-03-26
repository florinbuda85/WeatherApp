<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Weather
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonFetchData = New System.Windows.Forms.Button()
        Me.TextBoxCountryCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCityName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBoxImage = New System.Windows.Forms.PictureBox()
        Me.LabelCityName = New System.Windows.Forms.Label()
        Me.LabelTemperature = New System.Windows.Forms.Label()
        Me.LabelWeatherDescription = New System.Windows.Forms.Label()
        Me.PanelWeatherInfo = New System.Windows.Forms.Panel()
        CType(Me.PictureBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelWeatherInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonFetchData
        '
        Me.ButtonFetchData.Location = New System.Drawing.Point(169, 129)
        Me.ButtonFetchData.Name = "ButtonFetchData"
        Me.ButtonFetchData.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFetchData.TabIndex = 4
        Me.ButtonFetchData.Text = "Fetch Data"
        Me.ButtonFetchData.UseVisualStyleBackColor = True
        '
        'TextBoxCountryCode
        '
        Me.TextBoxCountryCode.Location = New System.Drawing.Point(15, 94)
        Me.TextBoxCountryCode.Name = "TextBoxCountryCode"
        Me.TextBoxCountryCode.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxCountryCode.TabIndex = 3
        Me.TextBoxCountryCode.Text = "ro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Country Code"
        '
        'TextBoxCityName
        '
        Me.TextBoxCityName.Location = New System.Drawing.Point(15, 50)
        Me.TextBoxCityName.Name = "TextBoxCityName"
        Me.TextBoxCityName.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxCityName.TabIndex = 1
        Me.TextBoxCityName.Text = "Baia Mare"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "City Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Type city and country code to find the weather"
        '
        'PictureBoxImage
        '
        Me.PictureBoxImage.Image = Global.WindowsApplication1.My.Resources.Resources._50n
        Me.PictureBoxImage.InitialImage = Global.WindowsApplication1.My.Resources.Resources._50n
        Me.PictureBoxImage.Location = New System.Drawing.Point(9, 15)
        Me.PictureBoxImage.Name = "PictureBoxImage"
        Me.PictureBoxImage.Size = New System.Drawing.Size(50, 50)
        Me.PictureBoxImage.TabIndex = 6
        Me.PictureBoxImage.TabStop = False
        '
        'LabelCityName
        '
        Me.LabelCityName.AutoSize = True
        Me.LabelCityName.Location = New System.Drawing.Point(65, 15)
        Me.LabelCityName.Name = "LabelCityName"
        Me.LabelCityName.Size = New System.Drawing.Size(24, 13)
        Me.LabelCityName.TabIndex = 7
        Me.LabelCityName.Text = "City"
        '
        'LabelTemperature
        '
        Me.LabelTemperature.AutoSize = True
        Me.LabelTemperature.Location = New System.Drawing.Point(65, 28)
        Me.LabelTemperature.Name = "LabelTemperature"
        Me.LabelTemperature.Size = New System.Drawing.Size(67, 13)
        Me.LabelTemperature.TabIndex = 8
        Me.LabelTemperature.Text = "Temperature"
        '
        'LabelWeatherDescription
        '
        Me.LabelWeatherDescription.AutoSize = True
        Me.LabelWeatherDescription.Location = New System.Drawing.Point(65, 41)
        Me.LabelWeatherDescription.Name = "LabelWeatherDescription"
        Me.LabelWeatherDescription.Size = New System.Drawing.Size(102, 13)
        Me.LabelWeatherDescription.TabIndex = 9
        Me.LabelWeatherDescription.Text = "Weather description"
        '
        'PanelWeatherInfo
        '
        Me.PanelWeatherInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelWeatherInfo.Controls.Add(Me.LabelWeatherDescription)
        Me.PanelWeatherInfo.Controls.Add(Me.PictureBoxImage)
        Me.PanelWeatherInfo.Controls.Add(Me.LabelTemperature)
        Me.PanelWeatherInfo.Controls.Add(Me.LabelCityName)
        Me.PanelWeatherInfo.Location = New System.Drawing.Point(18, 172)
        Me.PanelWeatherInfo.Name = "PanelWeatherInfo"
        Me.PanelWeatherInfo.Size = New System.Drawing.Size(226, 81)
        Me.PanelWeatherInfo.TabIndex = 10
        '
        'Weather
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 272)
        Me.Controls.Add(Me.PanelWeatherInfo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonFetchData)
        Me.Controls.Add(Me.TextBoxCountryCode)
        Me.Controls.Add(Me.TextBoxCityName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Weather"
        Me.Text = "Weather"
        CType(Me.PictureBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelWeatherInfo.ResumeLayout(False)
        Me.PanelWeatherInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonFetchData As System.Windows.Forms.Button
    Friend WithEvents TextBoxCountryCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCityName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxImage As System.Windows.Forms.PictureBox
    Friend WithEvents LabelCityName As System.Windows.Forms.Label
    Friend WithEvents LabelTemperature As System.Windows.Forms.Label
    Friend WithEvents LabelWeatherDescription As System.Windows.Forms.Label
    Friend WithEvents PanelWeatherInfo As System.Windows.Forms.Panel

End Class
