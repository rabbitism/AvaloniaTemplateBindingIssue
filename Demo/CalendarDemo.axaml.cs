using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Demo;

public partial class CalendarDemo : UserControl
{
    public CalendarDemo()
    {
        InitializeComponent();
    }

    public static readonly StyledProperty<DateTime?> DateProperty = AvaloniaProperty.Register<CalendarDemo, DateTime?>(
        "Date");

    public DateTime? Date
    {
        get => GetValue(DateProperty);
        set => SetValue(DateProperty, value);
    }
    
}