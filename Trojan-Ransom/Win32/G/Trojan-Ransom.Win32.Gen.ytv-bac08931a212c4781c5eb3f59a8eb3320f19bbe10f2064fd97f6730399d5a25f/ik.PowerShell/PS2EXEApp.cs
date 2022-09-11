namespace ik.PowerShell;

internal interface PS2EXEApp
{
	bool ShouldExit { get; set; }

	int ExitCode { get; set; }
}
