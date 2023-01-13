using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace CalculatorGUI;

public partial class MainWindow : Window
{

    static string? numberOne;
    static string? numberTwo;
    static double result;
    
    static bool sum = true;
    static bool minus = false;
    static bool mult = false;
    static bool divis = false;
    
    public MainWindow()
    {
        InitializeComponent();
    }

    public void buttonPlus_Click(object sender, RoutedEventArgs e)
    {
        sum = true;
        minus = false;
        mult = false;
        divis = false;
    }

    public void buttonMinus_Click(object sender, RoutedEventArgs e)
    {
       sum = false;
       minus = true;
       mult = false;
       divis = false;
    }

    public void buttonMult_Click(object sender, RoutedEventArgs e)
    {
        sum = false;
        minus = false;
        mult = true;
        divis = false;
    }

    public void buttonDivis_Click(object sender, RoutedEventArgs e)
    {
        sum = false;
        minus = false;
        mult = false;
        divis = true;
    }



    public void resultButton_Click(object sender, RoutedEventArgs e)
    {

        numberOne = textboxA.Text;
        numberTwo = textboxB.Text;

        try
        {

        if (sum) { result = Double.Parse(numberOne) + Double.Parse(numberTwo); }
        if (minus) { result = Double.Parse(numberOne) - Double.Parse(numberTwo); }
        if (mult) {  result = Double.Parse(numberOne) * Double.Parse(numberTwo); }
        if (divis) { result = Double.Parse(numberOne) / Double.Parse(numberTwo); }

        textboxC.Text=result.ToString();
        }
        catch(System.ArgumentNullException) { textboxC.Text="Enter A Number!"; }
        catch(System.FormatException) { textboxC.Text="Enter A Valid Type!"; }
        
    }


}