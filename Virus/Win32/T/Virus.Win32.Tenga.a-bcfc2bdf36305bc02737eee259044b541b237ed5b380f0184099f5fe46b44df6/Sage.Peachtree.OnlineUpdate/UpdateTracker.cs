namespace Sage.Peachtree.OnlineUpdate;

internal class UpdateTracker
{
	private const string ProductNameString = "Peachtree";

	private string m_Flavor;

	private string m_BuildNumber;

	private string m_UpdateProgram;

	public UpdateTracker(string flavor, string buildNumber, string updateProgram)
	{
		m_Flavor = flavor;
		m_BuildNumber = buildNumber;
		m_UpdateProgram = updateProgram;
	}

	private void PostUpdateProgramInformation(DeploymentEvent deploymentEvent)
	{
		OnlineUpdateNotification onlineUpdateNotification = new OnlineUpdateNotification();
		onlineUpdateNotification.ProductUpdateNotification("Peachtree", m_Flavor, m_BuildNumber, m_UpdateProgram, deploymentEvent);
	}

	public void PostUpdateProgramDownloadSuccessfull()
	{
		PostUpdateProgramInformation(DeploymentEvent.SuccessfulDownload);
	}

	public void PostUpdateProgramDownloadFailed()
	{
		PostUpdateProgramInformation(DeploymentEvent.FailedDownload);
	}

	public void PostUpdateProgramInstallSuccessfull()
	{
		PostUpdateProgramInformation(DeploymentEvent.SuccessfulInstall);
	}

	public void PostUpdateProgramInstallFailed()
	{
		PostUpdateProgramInformation(DeploymentEvent.FailedInstall);
	}
}
