using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Demo;

public partial class StringDemo : UserControl
{
    public StringDemo()
    {
        InitializeComponent();
    }

    public static readonly StyledProperty<string?> ValueProperty = AvaloniaProperty.Register<StringDemo, string?>(
        "Value");

    public string? Value
    {
        get => GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }
}