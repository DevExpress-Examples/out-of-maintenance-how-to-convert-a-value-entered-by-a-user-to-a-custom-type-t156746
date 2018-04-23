Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace WpfApplication57
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            propertyGrid.SelectedObject = New Item() With { _
                .ID = 1, .Value = New Customer() With {.Name = "CustomerOne"} _
            }
        End Sub
    End Class

    Public Class Item
        Public Property ID() As Integer

        <TypeConverter(GetType(MyTypeConverter))> _
        Public Property Value() As Customer
    End Class

    Public Class Customer
        Public Property Name() As String

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
    Public Class MyTypeConverter
        Inherits TypeConverter

        Public Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As Type) As Boolean
            If sourceType Is GetType(String) Then
                Return True
            End If
            Return MyBase.CanConvertFrom(context, sourceType)
        End Function
        Public Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
            If TypeOf value Is String Then
                Return New Customer() With {.Name = TryCast(value, String)}
            End If
            Return MyBase.ConvertFrom(context, culture, value)
        End Function
    End Class
End Namespace
