using System.ServiceModel.Install;

namespace Microsoft.Tools.ServiceModel;

internal class ActionItem
{
	private ServiceModelInstallComponent component;

	private InstallAction action;

	private OutputLevel outputLevel;

	internal ServiceModelInstallComponent Component => component;

	internal InstallAction Action => action;

	internal OutputLevel OutputLevel => outputLevel;

	internal ActionItem(ServiceModelInstallComponent component, InstallAction action, OutputLevel outputLevel)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		this.component = component;
		this.action = action;
		this.outputLevel = outputLevel;
	}
}
