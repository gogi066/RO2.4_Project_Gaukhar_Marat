namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private int _checkCount = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCheckClicked(object sender, EventArgs e)
    {
        _checkCount++;
        StatusLabel.Text = $"Button clicked: {_checkCount} times";
    }
}