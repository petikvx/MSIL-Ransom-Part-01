namespace ModuleNameSpace;

internal interface MainAppInterface
{
	bool ShouldExit { get; set; }

	int ExitCode { get; set; }
}
