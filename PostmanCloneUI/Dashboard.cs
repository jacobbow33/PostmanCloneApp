using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly  IApiAccess api = new ApiAccess();

    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling Api...";
        resultsTextbox.Text = "";
        
        // validate the API URL
        if (api.IsValidUrl(apiTextBox.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        try
        {

            resultsTextbox.Text = await api.CallApiAsync(apiTextBox.Text, true);

            systemStatus.Text = "Ready";

        }
        catch (Exception ex)
        {
            resultsTextbox.Text = "Error: " + ex.Message;
            systemStatus.Text = "Ready";

        }

    }
}
