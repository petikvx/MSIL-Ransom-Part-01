namespace Gecko;

[ContractID("@mozilla.org/prompter;1")]
internal class PromptFactoryFactory : GenericOneClassNsFactory<PromptFactoryFactory, PromptFactory>
{
	public const string ContractID = "@mozilla.org/prompter;1";

	public static void Init()
	{
		DefaultPromptFactory.Init();
		BaseNsFactory<PromptFactoryFactory>.Register();
	}

	public static void Shutdown()
	{
		DefaultPromptFactory.Shutdown();
	}
}
