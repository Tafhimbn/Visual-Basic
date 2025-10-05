Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_iphone17_properties.Click

        ' Data Types in VB.NET

        Dim brand As String
        Dim model As String
        Dim storageCapacity As Integer
        Dim is5GCapable As Boolean
        Dim price As Decimal
        Dim releaseDate As Date
        Dim features As String()
        Dim dimensions As (height As Decimal, width As Decimal, depth As Decimal)
        Dim weight As Single
        Dim colorOptions As List(Of String)
        Dim warrantyPeriod As TimeSpan
        Dim batteryLife As Double
        Dim cameraSpecs As Dictionary(Of String, String)
        Dim operatingSystem As String
        Dim simType As Char
        Dim screenSize As Double
        Dim refreshRate As Integer
        Dim ram As Integer
        Dim processor As String
        Dim gpu As String
        Dim connectivityOptions As List(Of String)
        Dim sensors As String()
        Dim audioFeatures As String


        brand = "Apple"
        model = "iPhone 17"
        storageCapacity = 256 ' in GB
        is5GCapable = True
        price = 999.99D ' in USD
        releaseDate = New Date(2024, 9, 20)
        features = New String() {"Face ID", "Wireless Charging", "Water Resistant"}
        dimensions = (height:=146.7D, width:=71.5D, depth:=7.4D) ' in mm
        weight = 174.0F ' in grams
        colorOptions = New List(Of String) From {"Black", "White", "Red", "Blue", "Green"}
        warrantyPeriod = TimeSpan.FromDays(365) ' 1 year
        batteryLife = 20.0 ' in hours
        cameraSpecs = New Dictionary(Of String, String) From {
            {"Rear", "48MP + 12MP + 12MP"},
            {"Front", "12MP"}
        }
        operatingSystem = "iOS 18"
        simType = "N"c ' Nano-SIM
        screenSize = 6.7 ' in inches
        refreshRate = 120 ' in Hz
        ram = 8 ' in GB
        processor = "A18 Bionic"
        gpu = "Apple GPU"
        connectivityOptions = New List(Of String) From {"Wi-Fi 6E", "Bluetooth 5.2", "NFC", "Ultra-Wideband"}
        sensors = New String() {"Face ID", "LiDAR Scanner", "Accelerometer", "Gyroscope", "Proximity Sensor", "Ambient Light Sensor", "Barometer"}
        audioFeatures = "Spatial Audio, Dolby Atmos"

        ' Displaying the properties in a message box

        MsgBox("Brand: " & brand & vbCrLf &                                   ' vbCrLf is used for new line
               "Model: " & model & vbCrLf &
               "Storage Capacity: " & storageCapacity & " GB" & vbCrLf &
               "5G Capable: " & is5GCapable.ToString() & vbCrLf &             '.ToString() converts Boolean to String
               "Price: $" & price.ToString("F2") & vbCrLf &
               "Release Date: " & releaseDate.ToShortDateString() & vbCrLf &  'ToShortDateString() formats date
               "Features: " & String.Join(", ", features) & vbCrLf &          ' String.Join() joins array elements into a single string
               "Dimensions (H x W x D): " & dimensions.height & "mm x " & dimensions.width & "mm x " & dimensions.depth & "mm" & vbCrLf &
               "Weight: " & weight & " grams" & vbCrLf &
               "Color Options: " & String.Join(", ", colorOptions) & vbCrLf &
               "Warranty Period: " & warrantyPeriod.Days & " days" & vbCrLf & '.Days gets the number of days from TimeSpan
               "Battery Life: " & batteryLife & " hours" & vbCrLf &
               "Camera Specs: Rear - " & cameraSpecs("Rear") & ", Front - " & cameraSpecs("Front") & vbCrLf & 'cameraSpecs("key") accesses dictionary values
               "Operating System: " & operatingSystem & vbCrLf &
               "SIM Type: " & simType & vbCrLf &
               "Screen Size: " & screenSize & " inches" & vbCrLf &
               "Refresh Rate: " & refreshRate & " Hz" & vbCrLf &
               "RAM: " & ram & " GB" & vbCrLf &
               "Processor: " & processor & vbCrLf &
               "GPU: " & gpu & vbCrLf &
               "Connectivity Options: " & String.Join(", ", connectivityOptions) & vbCrLf &
               "Sensors: " & String.Join(", ", sensors) & vbCrLf &
               "Audio Features: " & audioFeatures)



    End Sub
End Class
