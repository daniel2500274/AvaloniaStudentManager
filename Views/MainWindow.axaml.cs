using Avalonia.Controls;
using System.Linq;
namespace AvaloniaStudentManager.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Careers.ItemsSource = new string[]
                {"Ing. Sistemas" , "Arquitectura", "Derecho"}.OrderBy(x => x);
    }
}