<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655146/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T156746)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication57/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication57/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/WpfApplication57/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication57/MainWindow.xaml.vb))**
<!-- default file list end -->
# How to: Convert a Value Entered by a User to a Custom Type


Let’s assume that you have a property of a custom type and want to edit it in the PropertyGridControl. To be able to convert a value entered by a user (for example, this may be a string value) to the custom type, use a <a href="https://msdn.microsoft.com/en-us/library/system.componentmodel.typeconverter%28v=vs.110%29.aspx">TypeConverter</a> class descendant. It can be applied using the <a href="https://msdn.microsoft.com/en-us/library/system.componentmodel.typeconverterattribute%28v=vs.110%29.aspx">TypeConverterAttribute</a> attribute:


```cs
[TypeConverter(typeof(MyTypeConverter))]
public Customer Value
{
    get;
    set;
}
```



<br/>


