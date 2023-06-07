namespace MAUIPilotApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count += 10;
        ResetBtn.Text = $"Reset Count";

        if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
        SemanticScreenReader.Announce(ResetBtn.Text);
    }

    private void OnResetClicked(object sender, EventArgs e)
	{
		count = 0;
		CounterBtn.Text = $"Click me";
		ResetBtn.Text = $"Click Count has Been Reset";

		SemanticScreenReader.Announce(CounterBtn.Text);
		SemanticScreenReader.Announce(ResetBtn.Text);
	}
}

