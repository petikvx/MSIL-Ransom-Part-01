namespace InPatient_Monitoring_Automation.Classes;

internal class CreateSummary
{
	public Log CreateSummaryFile()
	{
		new Log();
		string user_def_path = global_variable.user_def_path;
		return new Processing().SummaryCreation(user_def_path);
	}
}
