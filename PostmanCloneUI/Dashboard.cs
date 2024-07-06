namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        // validate the API URL


        try
        {
            systemStatus.Text = "Calling API...";

            //sampe code - replace with the actual API call
            await Task.Delay(2000);

            systemStatus.Text = "Ready";

        }
        catch (Exception ex)
        {
            resultsTextbox.Text = "Error: " + ex.Message;
            systemStatus.Text = "Ready";

        }

    }
}
