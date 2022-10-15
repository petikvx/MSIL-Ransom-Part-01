using System;

namespace Ionic.Zip;

public class SelfExtractorSaveOptions
{
	public SelfExtractorFlavor Flavor { get; set; }

	public string PostExtractCommandLine { get; set; }

	public string DefaultExtractDirectory { get; set; }

	public string IconFile { get; set; }

	public bool Quiet { get; set; }

	public ExtractExistingFileAction ExtractExistingFile { get; set; }

	public bool RemoveUnpackedFilesAfterExecute { get; set; }

	public Version FileVersion { get; set; }

	public string ProductVersion { get; set; }

	public string Copyright { get; set; }

	public string Description { get; set; }

	public string ProductName { get; set; }

	public string SfxExeWindowTitle { get; set; }

	public string AdditionalCompilerSwitches { get; set; }
}
