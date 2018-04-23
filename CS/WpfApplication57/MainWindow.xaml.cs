using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication57
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            propertyGrid.SelectedObject = new Item() { ID = 1, Value = new Customer() { Name = "CustomerOne" } };
        }
    }

    public class Item
    {
        public int ID
        {
            get;
            set;
        }

        [TypeConverter(typeof(MyTypeConverter))]
        public Customer Value
        {
            get;
            set;
        }
    }

    public class Customer
    {
        public string Name
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    public class MyTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            return base.CanConvertFrom(context, sourceType);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                return new Customer() { Name = value as string };
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
