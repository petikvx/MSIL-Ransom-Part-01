using System;
using System.Collections;
using System.Reflection.Emit;

internal class CompilerOptions
{
	public bool autoRef;

	public bool fDebug;

	public bool fFast;

	public bool fNoStdlib;

	public PEFileKinds PEFileKind;

	public bool fTreatWarningsAsErrors;

	public bool fVersionSafe;

	public bool fPrint;

	public int nWarningLevel;

	public string strOutputFileName;

	public ArrayList SourceFileNames;

	public ArrayList ImportFileNames;

	public Hashtable ManagedResourceFileNames;

	public Hashtable ManagedResources;

	public string Win32Resource;

	public int codepage;

	public bool fForceCodepage;

	public Version versionInfo;

	public string libpath;

	public Hashtable Defines;

	public bool autoRefSetExplicitly;

	public bool fTargetSpecified;

	public bool fPrintSetExplicitly;

	public CompilerOptions()
	{
		autoRef = true;
		PEFileKind = PEFileKinds.ConsoleApplication;
		fFast = true;
		fPrint = true;
		nWarningLevel = 4;
		SourceFileNames = new ArrayList();
		ImportFileNames = new ArrayList();
		ManagedResourceFileNames = new Hashtable(10);
		ManagedResources = new Hashtable(10);
		Defines = new Hashtable();
		string environmentVariable = Environment.GetEnvironmentVariable("LIB");
		if (environmentVariable != null)
		{
			libpath = environmentVariable;
		}
		else
		{
			libpath = "";
		}
	}
}
