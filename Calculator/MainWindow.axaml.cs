using Avalonia.Controls;
using Avalonia.Interactivity;
using MathEvaluation.Extensions;

namespace Calculator;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonDigit_OnClick(object? sender, RoutedEventArgs e)
    {
        Input.Text += (sender as Button)?.Content;
    }

    private void ButtonArithmetic_OnClick(object? sender, RoutedEventArgs e)
    {
        Input.Text += $" {(sender as Button)?.Content} ";
    }

    private void ButtonEqual_OnClick(object? sender, RoutedEventArgs e)
    {
        var result = Input.Text!.Evaluate();
        Output.Text += $"{Input.Text} = {result}\n";

        Input.Clear();
    }

    private void ButtonAllClear_OnClick(object? sender, RoutedEventArgs e)
    {
        Input.Clear();
        Output.Text = string.Empty;
    }
    private void ButtonClear_OnClick(object? sender, RoutedEventArgs e)
    {
        Input.Clear();
    }
}
