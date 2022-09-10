using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.JScript;
using Microsoft.JScript.Vsa;
using Microsoft.Vsa;

internal class JScriptCompiler : MarshalByRefObject
{
	private bool fPrintBanner;

	private bool fBannerPrinted;

	private bool fPrintTargets;

	private int exitCode;

	private bool fHelp;

	private bool fUtf8Output;

	private ArrayList targets;

	private CompilerOptions currentTarget;

	private int codeItemCounter = 0;

	internal static readonly string ContextStringDelimiter = ";;";

	private static int LCID = CultureInfo.CurrentCulture.LCID;

	private static readonly ResourceManager resourceManager = new ResourceManager("JSC", typeof(JScriptCompiler).Module.Assembly);

	public int Run(string[] args)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		exitCode = 0;
		try
		{
			fPrintBanner = true;
			fBannerPrinted = false;
			fPrintTargets = false;
			fHelp = false;
			fUtf8Output = false;
			targets = new ArrayList();
			currentTarget = null;
			if (args.Length == 0)
			{
				PrintUsage();
				return 0;
			}
			ParseArguments(args, fromResponseFile: false);
			if (fUtf8Output)
			{
				Stream stream = Console.OpenStandardOutput();
				StreamWriter streamWriter = new StreamWriter(stream, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
				streamWriter.AutoFlush = true;
				Console.SetOut(TextWriter.Synchronized(streamWriter));
			}
			if (fHelp)
			{
				PrintUsage();
				return 0;
			}
			foreach (CompilerOptions target in targets)
			{
				if (target.SourceFileNames.Count == 0)
				{
					throw new CmdLineException((CmdLineError)2026, GetCultureInfo());
				}
			}
			if (targets.Count > 1)
			{
				fPrintTargets = true;
			}
			PrintBanner();
			foreach (CompilerOptions target2 in targets)
			{
				if (!target2.fForceCodepage)
				{
					target2.codepage = GetCultureInfo().TextInfo.ANSICodePage;
				}
				if (target2.strOutputFileName == null)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension((string)target2.SourceFileNames[0]);
					target2.strOutputFileName = fileNameWithoutExtension + ((target2.PEFileKind == PEFileKinds.Dll) ? ".dll" : ".exe");
				}
				if (!Compile(target2))
				{
					exitCode = 10;
				}
			}
		}
		catch (CmdLineException val)
		{
			CmdLineException val2 = val;
			PrintBanner();
			Console.WriteLine(((Exception)(object)val2).Message);
			exitCode = 10;
		}
		catch (Exception ex)
		{
			PrintBanner();
			Console.WriteLine("fatal error JS2999: " + ex.Message);
			exitCode = 10;
		}
		return exitCode;
	}

	private void ParseArguments(string[] args, bool fromResponseFile)
	{
		int num = 0;
		while (num < args.Length)
		{
			if (currentTarget == null)
			{
				currentTarget = new CompilerOptions();
			}
			num = ParseOptions(args, num, fromResponseFile);
			num = ParseSources(args, num);
			if (!fromResponseFile || num < args.Length - 1)
			{
				targets.Add(currentTarget);
				currentTarget = null;
			}
		}
	}

	private int ParseOptions(string[] args, int start, bool fromResponseFile)
	{
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		int i;
		for (i = start; i < args.Length; i++)
		{
			string text = args[i];
			if (text == null || text.Length == 0)
			{
				continue;
			}
			string text2;
			if ('@' == text[0])
			{
				if (!fromResponseFile)
				{
					text2 = text.Substring(1);
					if (text2.Length != 0)
					{
						if (File.Exists(text2))
						{
							string[] array = ReadResponseFile(text2);
							if (array != null)
							{
								ParseArguments(array, fromResponseFile: true);
							}
							continue;
						}
						throw new CmdLineException((CmdLineError)2035, text2, GetCultureInfo());
					}
					throw new CmdLineException((CmdLineError)2025, args[i], GetCultureInfo());
				}
				throw new CmdLineException((CmdLineError)2023, GetCultureInfo());
			}
			if ('-' != text[0] && '/' != text[0])
			{
				break;
			}
			text2 = text.Substring(1);
			if (text2.Length >= 1)
			{
				switch (text2[0])
				{
				case 'A':
				case 'a':
				{
					object obj = CmdLineOptionParser.IsBooleanOption(text2, "autoref");
					if (obj != null)
					{
						if ((bool)obj)
						{
							currentTarget.autoRef = true;
							currentTarget.autoRefSetExplicitly = true;
						}
						else
						{
							currentTarget.autoRef = false;
						}
						continue;
					}
					obj = CmdLineOptionParser.IsArgumentOption(text2, "a.version", "assembly.version");
					if (obj == null)
					{
						break;
					}
					if (((string)obj).Length != 0)
					{
						try
						{
							currentTarget.versionInfo = new Version((string)obj);
						}
						catch (Exception)
						{
							throw new CmdLineException((CmdLineError)2031, (string)obj, GetCultureInfo());
						}
						continue;
					}
					throw new CmdLineException((CmdLineError)2021, GetCultureInfo());
				}
				case 'C':
				case 'c':
				{
					object obj = CmdLineOptionParser.IsArgumentOption(text2, "codepage");
					if (obj == null)
					{
						break;
					}
					if (((string)obj).Length != 0)
					{
						try
						{
							currentTarget.codepage = int.Parse((string)obj, CultureInfo.InvariantCulture);
							currentTarget.fForceCodepage = true;
						}
						catch (Exception)
						{
							throw new CmdLineException((CmdLineError)2010, (string)obj, GetCultureInfo());
						}
						continue;
					}
					throw new CmdLineException((CmdLineError)2024, args[i], GetCultureInfo());
				}
				case 'D':
				case 'd':
				{
					object obj = CmdLineOptionParser.IsBooleanOption(text2, "debug");
					if (obj != null)
					{
						currentTarget.fDebug = (bool)obj;
						continue;
					}
					obj = CmdLineOptionParser.IsArgumentOption(text2, "d", "define");
					if (obj != null)
					{
						Hashtable allDefines = GetAllDefines((string)obj);
						IDictionaryEnumerator enumerator3 = allDefines.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DictionaryEntry dictionaryEntry = (DictionaryEntry)enumerator3.Current;
							currentTarget.Defines[dictionaryEntry.Key] = dictionaryEntry.Value;
						}
						continue;
					}
					break;
				}
				case 'F':
				case 'f':
				{
					object obj = CmdLineOptionParser.IsBooleanOption(text2, "fast");
					if (obj != null)
					{
						currentTarget.fFast = (bool)obj;
						continue;
					}
					break;
				}
				case '?':
				case 'H':
				case 'h':
					if (CmdLineOptionParser.IsSimpleOption(text2, "?") || CmdLineOptionParser.IsSimpleOption(text2, "help"))
					{
						fHelp = true;
						continue;
					}
					break;
				case 'L':
				case 'l':
				{
					object obj = CmdLineOptionParser.IsArgumentOption(text2, "lcid");
					if (obj != null)
					{
						if (((string)obj).Length != 0)
						{
							try
							{
								int num = int.Parse((string)obj, CultureInfo.InvariantCulture);
								new CultureInfo(num);
								LCID = num;
							}
							catch (Exception)
							{
								throw new CmdLineException((CmdLineError)2012, (string)obj, GetCultureInfo());
							}
							continue;
						}
						throw new CmdLineException((CmdLineError)2027, args[i], GetCultureInfo());
					}
					obj = CmdLineOptionParser.IsArgumentOption(text2, "lib");
					if (obj != null)
					{
						string text4 = (string)obj;
						if (text4.Length != 0)
						{
							text4 = text4.Replace(',', Path.PathSeparator);
							currentTarget.libpath = text4 + Path.PathSeparator + currentTarget.libpath;
							continue;
						}
						throw new CmdLineException((CmdLineError)2020, GetCultureInfo());
					}
					obj = CmdLineOptionParser.IsArgumentOption(text2, "linkres", "linkresource");
					if (obj != null)
					{
						ResInfo resinfo2 = new ResInfo((string)obj, true);
						AddResourceFile(resinfo2);
						continue;
					}
					break;
				}
				case 'N':
				case 'n':
				{
					if (CmdLineOptionParser.IsSimpleOption(text2, "nologo"))
					{
						fPrintBanner = false;
						continue;
					}
					object obj = CmdLineOptionParser.IsBooleanOption(text2, "nostdlib");
					if (obj != null)
					{
						currentTarget.fNoStdlib = (bool)obj;
						if ((bool)obj && !currentTarget.autoRefSetExplicitly)
						{
							currentTarget.autoRef = false;
						}
						continue;
					}
					break;
				}
				case 'O':
				case 'o':
				{
					object obj = CmdLineOptionParser.IsArgumentOption(text2, "out");
					if (obj == null)
					{
						break;
					}
					try
					{
						if (Path.GetFileName((string)obj) == "")
						{
							throw new CmdLineException((CmdLineError)2025, args[i], GetCultureInfo());
						}
					}
					catch (ArgumentException)
					{
						throw new CmdLineException((CmdLineError)2025, args[i], GetCultureInfo());
					}
					if (!(Path.GetExtension((string)obj) == ""))
					{
						if (currentTarget.strOutputFileName == null)
						{
							currentTarget.strOutputFileName = (string)obj;
							continue;
						}
						throw new CmdLineException((CmdLineError)2016, GetCultureInfo());
					}
					throw new CmdLineException((CmdLineError)2019, args[i], GetCultureInfo());
				}
				case 'P':
				case 'p':
				{
					object obj = CmdLineOptionParser.IsBooleanOption(text2, "print");
					if (obj != null)
					{
						currentTarget.fPrint = (bool)obj;
						currentTarget.fPrintSetExplicitly = (bool)obj;
						continue;
					}
					break;
				}
				case 'R':
				case 'r':
				{
					object obj = CmdLineOptionParser.IsArgumentOption(text2, "r", "reference");
					if (obj != null)
					{
						if (((string)obj).Length != 0)
						{
							StringEnumerator enumerator = GetAllReferences((string)obj).GetEnumerator();
							while (enumerator.MoveNext())
							{
								string current = enumerator.Current;
								bool flag = false;
								foreach (string importFileName in currentTarget.ImportFileNames)
								{
									if (string.Compare(importFileName, current, ignoreCase: true, CultureInfo.InvariantCulture) == 0)
									{
										flag = true;
										break;
									}
								}
								if (!flag)
								{
									currentTarget.ImportFileNames.Add(current);
								}
							}
							continue;
						}
						throw new CmdLineException((CmdLineError)2025, args[i], GetCultureInfo());
					}
					obj = CmdLineOptionParser.IsArgumentOption(text2, "res", "resource");
					if (obj != null)
					{
						ResInfo resinfo = new ResInfo((string)obj, false);
						AddResourceFile(resinfo);
						continue;
					}
					break;
				}
				case 'T':
				case 't':
				{
					object obj = CmdLineOptionParser.IsArgumentOption(text2, "t", "target");
					if (obj == null)
					{
						break;
					}
					if (!currentTarget.fTargetSpecified)
					{
						if (string.Compare((string)obj, "exe", ignoreCase: true, CultureInfo.InvariantCulture) == 0)
						{
							currentTarget.fTargetSpecified = true;
							currentTarget.PEFileKind = PEFileKinds.ConsoleApplication;
							continue;
						}
						if (string.Compare((string)obj, "winexe", ignoreCase: true, CultureInfo.InvariantCulture) == 0)
						{
							currentTarget.fTargetSpecified = true;
							currentTarget.PEFileKind = PEFileKinds.WindowApplication;
							currentTarget.fPrint = currentTarget.fPrintSetExplicitly;
							continue;
						}
						if (string.Compare((string)obj, "library", ignoreCase: true, CultureInfo.InvariantCulture) == 0)
						{
							currentTarget.fTargetSpecified = true;
							currentTarget.PEFileKind = PEFileKinds.Dll;
							continue;
						}
						throw new CmdLineException((CmdLineError)2013, (string)obj, GetCultureInfo());
					}
					throw new CmdLineException((CmdLineError)2017, GetCultureInfo());
				}
				case 'U':
				case 'u':
				{
					object obj = CmdLineOptionParser.IsBooleanOption(text2, "utf8output");
					if (obj != null)
					{
						fUtf8Output = (bool)obj;
						continue;
					}
					break;
				}
				case 'V':
				case 'v':
				{
					object obj = CmdLineOptionParser.IsBooleanOption(text2, "VersionSafe");
					if (obj != null)
					{
						currentTarget.fVersionSafe = (bool)obj;
						continue;
					}
					break;
				}
				case 'W':
				case 'w':
				{
					object obj = CmdLineOptionParser.IsArgumentOption(text2, "w", "warn");
					if (obj != null)
					{
						if (((string)obj).Length != 0)
						{
							if (1 == ((string)obj).Length)
							{
								switch (((string)obj)[0])
								{
								case '0':
									currentTarget.nWarningLevel = 0;
									continue;
								case '1':
									currentTarget.nWarningLevel = 1;
									continue;
								case '2':
									currentTarget.nWarningLevel = 2;
									continue;
								case '3':
									currentTarget.nWarningLevel = 3;
									continue;
								case '4':
									currentTarget.nWarningLevel = 4;
									continue;
								}
							}
							throw new CmdLineException((CmdLineError)2015, args[i], GetCultureInfo());
						}
						throw new CmdLineException((CmdLineError)2028, args[i], GetCultureInfo());
					}
					obj = CmdLineOptionParser.IsBooleanOption(text2, "warnaserror");
					if (obj != null)
					{
						currentTarget.fTreatWarningsAsErrors = (bool)obj;
						continue;
					}
					obj = CmdLineOptionParser.IsArgumentOption(text2, "win32res");
					if (obj != null)
					{
						string text3 = (string)obj;
						if (text3.Length != 0)
						{
							if (File.Exists(text3))
							{
								if (currentTarget.Win32Resource == null)
								{
									currentTarget.Win32Resource = text3;
									continue;
								}
								throw new CmdLineException((CmdLineError)2033, GetCultureInfo());
							}
							throw new CmdLineException((CmdLineError)2029, args[i], GetCultureInfo());
						}
						throw new CmdLineException((CmdLineError)2025, args[i], GetCultureInfo());
					}
					break;
				}
				}
			}
			throw new CmdLineException((CmdLineError)2030, args[i], GetCultureInfo());
		}
		return i;
	}

	private int ParseSources(string[] args, int start)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		int i;
		for (i = start; i < args.Length; i++)
		{
			if (args[i].Length == 0)
			{
				continue;
			}
			if ('-' == args[i][0] || '/' == args[i][0])
			{
				break;
			}
			try
			{
				if (Path.GetFileName(args[i]) == "")
				{
					throw new CmdLineException((CmdLineError)2014, args[i], GetCultureInfo());
				}
			}
			catch (ArgumentException)
			{
				throw new CmdLineException((CmdLineError)2014, args[i], GetCultureInfo());
			}
			foreach (string importFileName in currentTarget.ImportFileNames)
			{
				if (string.Compare(importFileName, args[i], ignoreCase: true, CultureInfo.InvariantCulture) == 0)
				{
					throw new CmdLineException((CmdLineError)2004, args[i], GetCultureInfo());
				}
			}
			foreach (string sourceFileName in currentTarget.SourceFileNames)
			{
				if (string.Compare(sourceFileName, args[i], ignoreCase: true, CultureInfo.InvariantCulture) == 0)
				{
					throw new CmdLineException((CmdLineError)2007, args[i], GetCultureInfo());
				}
			}
			currentTarget.SourceFileNames.Add(args[i]);
		}
		return i;
	}

	private bool Compile(CompilerOptions options)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Invalid comparison between Unknown and I4
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Invalid comparison between Unknown and I4
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Invalid comparison between Unknown and I4
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		if (fPrintTargets)
		{
			Console.WriteLine(Localize("Compiling", options.strOutputFileName));
		}
		VsaEngine val = new VsaEngine();
		if (val == null)
		{
			throw new CmdLineException((CmdLineError)2002, GetCultureInfo());
		}
		val.InitVsaEngine("JSC://Microsoft.JScript.Vsa.VsaEngine", (IVsaSite)(object)new EngineSite(options));
		((BaseVsaEngine)val).set_LCID(LCID);
		((BaseVsaEngine)val).set_GenerateDebugInfo(options.fDebug);
		((BaseVsaEngine)val).SetOption("AutoRef", (object)options.autoRef);
		((BaseVsaEngine)val).SetOption("fast", (object)options.fFast);
		((BaseVsaEngine)val).SetOption("output", (object)options.strOutputFileName);
		((BaseVsaEngine)val).SetOption("PEFileKind", (object)options.PEFileKind);
		((BaseVsaEngine)val).SetOption("print", (object)options.fPrint);
		((BaseVsaEngine)val).SetOption("libpath", (object)options.libpath);
		if (options.versionInfo != null)
		{
			((BaseVsaEngine)val).SetOption("version", (object)options.versionInfo);
		}
		((BaseVsaEngine)val).SetOption("VersionSafe", (object)options.fVersionSafe);
		((BaseVsaEngine)val).SetOption("defines", (object)options.Defines);
		((BaseVsaEngine)val).SetOption("warnaserror", (object)options.fTreatWarningsAsErrors);
		((BaseVsaEngine)val).SetOption("WarningLevel", (object)options.nWarningLevel);
		if (options.Win32Resource != null)
		{
			((BaseVsaEngine)val).SetOption("win32resource", (object)options.Win32Resource);
		}
		if (options.ManagedResources.Count > 0)
		{
			((BaseVsaEngine)val).SetOption("managedResources", (object)options.ManagedResources.Values);
		}
		bool flag = false;
		bool flag2 = false;
		foreach (string importFileName in options.ImportFileNames)
		{
			AddAssemblyReference((IVsaEngine)(object)val, importFileName);
			string fileName = Path.GetFileName(importFileName);
			if (string.Compare(fileName, "mscorlib.dll", ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				flag = true;
			}
			else if (string.Compare(fileName, "System.Windows.Forms.dll", ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				flag2 = true;
			}
		}
		if (!options.fNoStdlib && !flag)
		{
			AddAssemblyReference((IVsaEngine)(object)val, "mscorlib.dll");
		}
		if (options.PEFileKind == PEFileKinds.WindowApplication && !options.fNoStdlib && !flag2)
		{
			AddAssemblyReference((IVsaEngine)(object)val, "System.Windows.Forms.dll");
		}
		for (int i = 0; i < options.SourceFileNames.Count; i++)
		{
			AddSourceFile((IVsaEngine)(object)val, (string)options.SourceFileNames[i], options.codepage, options.fForceCodepage);
		}
		bool flag3 = false;
		try
		{
			return ((BaseVsaEngine)val).Compile();
		}
		catch (VsaException val2)
		{
			VsaException val3 = val2;
			if ((int)val3.get_ErrorCode() == -2146226172)
			{
				if (((Exception)(object)val3).InnerException != null && ((Exception)(object)val3).InnerException is BadImageFormatException)
				{
					CmdLineException val4 = new CmdLineException((CmdLineError)2009, ((Exception)(object)val3).Message, GetCultureInfo());
					Console.WriteLine(((Exception)(object)val4).Message);
				}
				else if (((Exception)(object)val3).InnerException != null && (((Exception)(object)val3).InnerException is FileNotFoundException || ((Exception)(object)val3).InnerException is FileLoadException))
				{
					CmdLineException val5 = new CmdLineException((CmdLineError)2001, ((Exception)(object)val3).Message, GetCultureInfo());
					Console.WriteLine(((Exception)(object)val5).Message);
				}
				else
				{
					CmdLineException val6 = new CmdLineException((CmdLineError)2009, GetCultureInfo());
					Console.WriteLine(((Exception)(object)val6).Message);
				}
			}
			else if ((int)val3.get_ErrorCode() == -2146226123)
			{
				CmdLineException val7 = new CmdLineException((CmdLineError)2008, ((Exception)(object)val3).Message, GetCultureInfo());
				Console.WriteLine(((Exception)(object)val7).Message);
			}
			else if ((int)val3.get_ErrorCode() == -2146226171 && ((Exception)(object)val3).InnerException != null)
			{
				CmdLineException val8 = new CmdLineException((CmdLineError)2036, ((Exception)(object)val3).Message, GetCultureInfo());
				Console.WriteLine(((Exception)(object)val8).Message);
			}
			else
			{
				Console.WriteLine(Localize("INTERNAL COMPILER ERROR"));
				Console.WriteLine(val3);
			}
			return false;
		}
		catch (Exception value)
		{
			Console.WriteLine(Localize("INTERNAL COMPILER ERROR"));
			Console.WriteLine(value);
			return false;
		}
	}

	private void AddAssemblyReference(IVsaEngine engine, string fileName)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		IVsaReferenceItem val = (IVsaReferenceItem)engine.get_Items().CreateItem(fileName, (VsaItemType)0, (VsaItemFlag)0);
		val.set_AssemblyName(fileName);
	}

	private void AddSourceFile(IVsaEngine engine, string fileName, int codepage, bool fForceCodepage)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		string text = "$SourceFile_" + codeItemCounter++;
		IVsaCodeItem val = (IVsaCodeItem)engine.get_Items().CreateItem(text, (VsaItemType)2, (VsaItemFlag)0);
		((IVsaItem)val).SetOption("codebase", (object)fileName);
		val.set_SourceText(ReadFile(fileName, codepage, fForceCodepage));
	}

	private void AddResourceFile(ResInfo resinfo)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists(resinfo.fullpath))
		{
			throw new CmdLineException((CmdLineError)2022, resinfo.filename, GetCultureInfo());
		}
		if (currentTarget.ManagedResourceFileNames[resinfo.fullpath] != null)
		{
			throw new CmdLineException((CmdLineError)2005, resinfo.filename, GetCultureInfo());
		}
		if (currentTarget.ManagedResources[resinfo.name] != null)
		{
			throw new CmdLineException((CmdLineError)2006, resinfo.name, GetCultureInfo());
		}
		currentTarget.ManagedResources[resinfo.name] = resinfo;
		currentTarget.ManagedResourceFileNames[resinfo.fullpath] = resinfo;
	}

	internal void PrintBanner()
	{
		PrintBanner(null);
	}

	internal void PrintBanner(CultureInfo culture)
	{
		if (!fBannerPrinted && fPrintBanner)
		{
			string arg = 7 + "." + 0.ToString(CultureInfo.InvariantCulture).PadLeft(2, '0') + "." + 9951.ToString(CultureInfo.InvariantCulture).PadLeft(4, '0');
			Version version = Environment.Version;
			string arg2 = version.Major + "." + version.Minor.ToString(CultureInfo.InvariantCulture).PadLeft(2, '0') + "." + version.Build.ToString(CultureInfo.InvariantCulture).PadLeft(4, '0');
			fBannerPrinted = true;
			Console.WriteLine(string.Format(Localize("Banner line 1", culture), arg));
			Console.WriteLine(string.Format(Localize("Banner line 2", culture), arg2));
			Console.WriteLine(Localize("Banner line 3", culture) + "\r\n");
		}
	}

	internal void PrintUsage()
	{
		CultureInfo cultureInfo = GetCultureInfo();
		PrintBanner(cultureInfo);
		Console.WriteLine(Localize("Usage format", cultureInfo));
		Console.WriteLine();
		Console.Write("                         ");
		Console.WriteLine(Localize("Usage options", cultureInfo));
		Console.WriteLine("");
		Console.Write("                           ");
		Console.WriteLine(Localize("Output Files", cultureInfo));
		Console.Write("  /out:<file>              ");
		Console.WriteLine(Localize("Usage /out", cultureInfo));
		Console.Write("  /t[arget]:exe            ");
		Console.WriteLine(Localize("Usage /t:exe", cultureInfo));
		Console.Write("  /t[arget]:winexe         ");
		Console.WriteLine(Localize("Usage /t:winexe", cultureInfo));
		Console.Write("  /t[arget]:library        ");
		Console.WriteLine(Localize("Usage /t:library", cultureInfo));
		Console.WriteLine();
		Console.Write("                           ");
		Console.WriteLine(Localize("Input Files", cultureInfo));
		Console.Write("  /autoref[+|-]            ");
		Console.WriteLine(Localize("Usage /autoref", cultureInfo));
		Console.Write("  /lib:<path>              ");
		Console.WriteLine(Localize("Usage /lib", cultureInfo));
		Console.Write("  /r[eference]:<file list> ");
		Console.WriteLine(Localize("Usage /reference", cultureInfo));
		Console.Write("                           ");
		Console.WriteLine("<file list>: <assembly name>[;<assembly name>...]");
		Console.WriteLine();
		Console.Write("                           ");
		Console.WriteLine(Localize("Resources", cultureInfo));
		Console.Write("  /win32res:<file>         ");
		Console.WriteLine(Localize("Usage /win32res", cultureInfo));
		Console.Write("  /res[ource]:<info>       ");
		Console.WriteLine(Localize("Usage /resource", cultureInfo));
		Console.WriteLine("                           <info>: <filename>[,<name>[,public|private]]");
		Console.Write("  /linkres[ource]:<info>   ");
		Console.WriteLine(Localize("Usage /linkresource", cultureInfo));
		Console.WriteLine("                           <info>: <filename>[,<name>[,public|private]]");
		Console.WriteLine();
		Console.Write("                           ");
		Console.WriteLine(Localize("Code Generation", cultureInfo));
		Console.Write("  /debug[+|-]              ");
		Console.WriteLine(Localize("Usage /debug", cultureInfo));
		Console.Write("  /fast[+|-]               ");
		Console.WriteLine(Localize("Usage /fast", cultureInfo));
		Console.Write("  /warnaserror[+|-]        ");
		Console.WriteLine(Localize("Usage /warnaserror", cultureInfo));
		Console.Write("  /w[arn]:<level>          ");
		Console.WriteLine(Localize("Usage /warn", cultureInfo));
		Console.WriteLine();
		Console.Write("                           ");
		Console.WriteLine(Localize("Miscellaneous", cultureInfo));
		Console.Write("  @<filename>              ");
		Console.WriteLine(Localize("Usage @file", cultureInfo));
		Console.Write("  /?                       ");
		Console.WriteLine(Localize("Usage /?", cultureInfo));
		Console.Write("  /help                    ");
		Console.WriteLine(Localize("Usage /?", cultureInfo));
		Console.Write("  /d[efine]:<symbols>      ");
		Console.WriteLine(Localize("Usage /define", cultureInfo));
		Console.Write("  /nologo                  ");
		Console.WriteLine(Localize("Usage /nologo", cultureInfo));
		Console.Write("  /print[+|-]              ");
		Console.WriteLine(Localize("Usage /print", cultureInfo));
		Console.WriteLine();
		Console.Write("                           ");
		Console.WriteLine(Localize("Advanced", cultureInfo));
		Console.Write("  /codepage:<id>           ");
		Console.WriteLine(Localize("Usage /codepage", cultureInfo));
		Console.Write("  /lcid:<id>               ");
		Console.WriteLine(Localize("Usage /lcid", cultureInfo));
		Console.Write("  /nostdlib[+|-]           ");
		Console.WriteLine(Localize("Usage /nostdlib", cultureInfo));
		Console.Write("  /utf8output[+|-]         ");
		Console.WriteLine(Localize("Usage /utf8output", cultureInfo));
		Console.Write("  /versionsafe[+|-]        ");
		Console.WriteLine(Localize("Usage /versionsafe", cultureInfo));
		Console.WriteLine();
	}

	internal static void PrintError(string sourceFile, int line, int column, bool fIsWarning, int number, string message)
	{
		string text = (10000 + (number & 0xFFFF)).ToString(CultureInfo.InvariantCulture).Substring(1);
		if (string.Compare(sourceFile, "no source") != 0)
		{
			Console.Write(sourceFile + "(" + line + "," + column + ") : ");
		}
		Console.WriteLine((fIsWarning ? "warning JS" : "error JS") + text + ": " + message);
	}

	private int GetArgumentSeparatorIndex(string argList, int startIndex)
	{
		int num = argList.IndexOf(",", startIndex);
		int num2 = argList.IndexOf(";", startIndex);
		if (num == -1)
		{
			return num2;
		}
		if (num2 == -1)
		{
			return num;
		}
		if (num < num2)
		{
			return num;
		}
		return num2;
	}

	private Hashtable GetAllDefines(string definitionList)
	{
		Hashtable hashtable = new Hashtable();
		int num = 0;
		int argumentSeparatorIndex;
		do
		{
			argumentSeparatorIndex = GetArgumentSeparatorIndex(definitionList, num);
			string def = ((argumentSeparatorIndex == -1) ? definitionList.Substring(num) : definitionList.Substring(num, argumentSeparatorIndex - num));
			AddDefinition(def, hashtable);
			num = argumentSeparatorIndex + 1;
		}
		while (argumentSeparatorIndex > -1);
		return hashtable;
	}

	private StringCollection GetAllReferences(string fileList)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		StringCollection stringCollection = new StringCollection();
		int num = 0;
		int argumentSeparatorIndex;
		do
		{
			argumentSeparatorIndex = GetArgumentSeparatorIndex(fileList, num);
			string text = ((argumentSeparatorIndex == -1) ? fileList.Substring(num).Trim() : fileList.Substring(num, argumentSeparatorIndex - num).Trim());
			if (text.Length != 0)
			{
				stringCollection.Add(text);
				num = argumentSeparatorIndex + 1;
				continue;
			}
			throw new CmdLineException((CmdLineError)2034, fileList, GetCultureInfo());
		}
		while (argumentSeparatorIndex > -1);
		return stringCollection;
	}

	private void AddDefinition(string def, Hashtable definitions)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		int num = def.IndexOf("=");
		object obj = null;
		string text;
		if (num == -1)
		{
			text = def.Trim();
			obj = true;
		}
		else
		{
			text = def.Substring(0, num).Trim();
			string text2 = def.Substring(num + 1).Trim();
			if (string.Compare(text2, "true", ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				obj = true;
			}
			else if (string.Compare(text2, "false", ignoreCase: true, CultureInfo.InvariantCulture) == 0)
			{
				obj = false;
			}
			else
			{
				try
				{
					obj = int.Parse(text2, CultureInfo.InvariantCulture);
				}
				catch (Exception)
				{
					throw new CmdLineException((CmdLineError)2011, text, GetCultureInfo());
				}
			}
		}
		if (text.Length == 0)
		{
			throw new CmdLineException((CmdLineError)2018, GetCultureInfo());
		}
		if (text[0] == '_' && (text.CompareTo("_debug") == 0 || text.CompareTo("_fast") == 0 || text.CompareTo("_jscript") == 0 || text.CompareTo("_jscript_build") == 0 || text.CompareTo("_jscript_version") == 0 || text.CompareTo("_microsoft") == 0 || text.CompareTo("_win32") == 0 || text.CompareTo("_x86") == 0))
		{
			throw new CmdLineException((CmdLineError)2003, text, GetCultureInfo());
		}
		definitions[text] = obj;
	}

	internal string ReadFile(string fileName, int codepage, bool fForceCodepage)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		FileStream fileStream;
		try
		{
			fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		}
		catch (ArgumentException)
		{
			throw new CmdLineException((CmdLineError)2036, fileName, GetCultureInfo());
		}
		catch (DirectoryNotFoundException)
		{
			throw new CmdLineException((CmdLineError)2035, fileName, GetCultureInfo());
		}
		catch (FileNotFoundException)
		{
			throw new CmdLineException((CmdLineError)2035, fileName, GetCultureInfo());
		}
		long length = fileStream.Length;
		if (length == 0L)
		{
			return "";
		}
		Encoding encoding = null;
		try
		{
			encoding = Encoding.GetEncoding(codepage);
		}
		catch (ArgumentException)
		{
			throw new CmdLineException((CmdLineError)2010, codepage.ToString(CultureInfo.InvariantCulture), GetCultureInfo());
		}
		StreamReader streamReader = new StreamReader(fileStream, encoding, detectEncodingFromByteOrderMarks: true);
		if (length > 2147483647L)
		{
			throw new CmdLineException((CmdLineError)2032, GetCultureInfo());
		}
		return streamReader.ReadToEnd();
	}

	private string[] ReadResponseFile(string strFileName)
	{
		FileStream fileStream = new FileStream(strFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		long length = fileStream.Length;
		if (length == 0L)
		{
			return null;
		}
		StreamReader streamReader = new StreamReader(fileStream);
		string text = streamReader.ReadLine();
		string pattern = "\\s*([^\\s\\\"]|(\\\"[^\\\"\\n]*\\\"))+";
		Regex regex = new Regex(pattern);
		StringCollection stringCollection = new StringCollection();
		while (text != null)
		{
			if (!text.Trim().StartsWith("#"))
			{
				MatchCollection matchCollection = regex.Matches(text);
				if (matchCollection != null && matchCollection.Count != 0)
				{
					foreach (Match item in matchCollection)
					{
						string text2 = item.ToString().Trim();
						int num = 0;
						while ((num = text2.IndexOf("\"", num)) != -1)
						{
							if (num == 0)
							{
								text2 = text2.Substring(1);
							}
							else if (text2[num - 1] == '\\')
							{
								num++;
							}
							else
							{
								text2 = text2.Remove(num, 1);
							}
						}
						stringCollection.Add(text2);
					}
				}
			}
			text = streamReader.ReadLine();
		}
		if (stringCollection.Count == 0)
		{
			return null;
		}
		string[] array = new string[checked((uint)stringCollection.Count)];
		stringCollection.CopyTo(array, 0);
		return array;
	}

	internal static string Localize(string s)
	{
		return Localize(s, null, null);
	}

	internal static string Localize(string s, string context)
	{
		return Localize(s, context, null);
	}

	internal static string Localize(string s, CultureInfo culture)
	{
		return Localize(s, null, culture);
	}

	internal static string Localize(string s, string context, CultureInfo culture)
	{
		try
		{
			if (culture == null)
			{
				culture = GetCultureInfo();
			}
			string @string = resourceManager.GetString(s, culture);
			if (@string != null)
			{
				int num = @string.IndexOf(ContextStringDelimiter);
				if (num == -1)
				{
					return @string;
				}
				if (context != null)
				{
					return string.Format(@string.Substring(num + 2), context);
				}
				return @string.Substring(0, num);
			}
			return s;
		}
		catch (MissingManifestResourceException)
		{
			return s;
		}
	}

	internal static CultureInfo GetCultureInfo()
	{
		CultureInfo cultureInfo = null;
		try
		{
			cultureInfo = new CultureInfo(LCID);
		}
		catch (ArgumentException)
		{
		}
		if (cultureInfo != null)
		{
			return cultureInfo;
		}
		return Thread.CurrentThread.CurrentCulture;
	}
}
