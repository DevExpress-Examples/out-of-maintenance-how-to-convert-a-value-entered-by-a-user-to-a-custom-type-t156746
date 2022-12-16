Imports System
Imports System.ComponentModel
Imports System.Windows
Imports System.Windows.Controls

Namespace WpfApplication57

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.propertyGrid.SelectedObject = New Item() With {.ID = 1, .Value = New Customer() With {.Name = "CustomerOne"}}
        End Sub
    End Class

    Public Class Item

        Public Property ID As Integer

        <TypeConverter(GetType(MyTypeConverter))>
        Public Property Value As Customer
    End Class

    Public Class Customer

        Public Property Name As String

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Public Class MyTypeConverter
        Inherits TypeConverter

        Public Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As Type) As Boolean
            If sourceType Is GetType(String) Then Return True
            Return MyBase.CanConvertFrom(context, sourceType)
        End Function

        Public Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As Globalization.CultureInfo, ByVal value As Object) As Object
            If TypeOf value Is String Then
                Return New Customer() With {.Name = TryCast(value, String)}
            End If

            Return MyBase.ConvertFrom(context, culture, value)
        End Function
    End Class
End Namespace
