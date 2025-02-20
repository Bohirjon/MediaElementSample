namespace MediaElement9;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        MyMediaElement.Stop();

        MyMediaElement.Source = "https://storage.googleapis.com/gtv-videos-bucket/sample/ForBiggerMeltdowns.mp4";

        MyMediaElement.Play();
    }
}