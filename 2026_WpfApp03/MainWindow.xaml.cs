using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _2026_WpfApp03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color strokeColor = Colors.Black;
        Color fillColor = Colors.Transparent;
        int strokeThickness = 1;
        string shapeType = "Line";
        public MainWindow()
        {
            InitializeComponent();
            StrokeColorPicker.SelectedColor = strokeColor;
            FillColorPicker.SelectedColor = fillColor;
        }

        private void ShapeButton_Checked(object sender, RoutedEventArgs e)
        {
            var targetShapeButton = sender as RadioButton;
            shapeType = targetShapeButton.Tag.ToString();
            DisplayStatus();
        }
        private void StrokeColorPicker_SelectColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            strokeColor = (Color)StrokeColorPicker.SelectedColor;
            DisplayStatus();
        }

        private void FillColorPicker_SelectColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            fillColor = (Color)FillColorPicker.SelectedColor;
            DisplayStatus();
        }
        private void DisplayStatus()
        {
            if (ColorLabel != null) ColorLabel.Content = $"筆刷色彩：{strokeColor} 填充色彩：{fillColor} 筆刷粗細：{strokeThickness}";
            if (ColorLabel != null) ShapeLabel.Content = $"形狀：{shapeType}";
        }

        private void ThicknessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            strokeThickness = (int)ThicknessSlider.Value;
            DisplayStatus();
        }
    }
}