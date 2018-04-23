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


