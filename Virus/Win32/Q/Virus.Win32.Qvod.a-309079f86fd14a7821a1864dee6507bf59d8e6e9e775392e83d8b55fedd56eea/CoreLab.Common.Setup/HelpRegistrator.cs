using System;
using System.Collections;
using System.IO;

namespace CoreLab.Common.Setup;

public class HelpRegistrator
{
	[STAThread]
	private static void Main(string[] args)
	{
		bool flag = true;
		string text = null;
		string text2 = null;
		string text3 = null;
		string text4 = null;
		string text5 = null;
		string text6 = null;
		string text7 = null;
		bool merge = false;
		bool filter = true;
		try
		{
			for (int i = 0; i < args.Length; i++)
			{
				string text8 = args[i].ToLower();
				switch (text8)
				{
				case "/u":
				case "/r":
					flag = text8[1] == 'r';
					break;
				case "/ns":
				case "/namespace":
					text = args[++i];
					break;
				case "/descr":
				case "/description":
					text2 = args[++i];
					break;
				case "/fn":
				case "/filename":
					text3 = args[++i];
					break;
				case "/ide":
				case "/idelist":
					text4 = args[++i];
					break;
				case "/hdir":
				case "/helpdir":
					text5 = args[++i];
					break;
				case "/product":
				case "/productname":
					text6 = args[++i];
					break;
				case "/idir":
				case "/installdir":
					text7 = args[++i];
					break;
				case "/m":
				case "/merge":
					merge = true;
					break;
				case "/nf":
				case "/nofilter":
					filter = false;
					break;
				}
			}
			if (text != null && text2 != null && text3 != null && text4 != null && text5 != null)
			{
				if (!Directory.Exists(text5))
				{
					throw new Exception("Directory does not exists: " + text5);
				}
				InnovaHxReg innovaHxReg = new InnovaHxReg(text5, text7, text4, text6);
				if (GetHelpCollections(text4, out var helpCollections))
				{
					if (flag)
					{
						innovaHxReg.RegisterProduct(text, text2, text3, helpCollections, merge, filter);
					}
					else
					{
						innovaHxReg.UnregisterProduct(text, text3, helpCollections, merge);
					}
				}
			}
			else
			{
				string exception = "Argument list is not properly specified.";
				if (text6 == null || text6 == "")
				{
					text6 = "Unknown product";
				}
				CustomActionUtils.ShowMessage(exception, text7 != null, text6);
			}
		}
		catch (CustomActionException ex)
		{
			bool logSaved;
			if (logSaved = text7 != null)
			{
				logSaved = CustomActionUtils.WriteError(text7, "HelpReg", ex);
			}
			if (text4.ToUpper().Trim() != "NOIDE")
			{
				CustomActionUtils.ShowMessage(ex.Hypothesis, logSaved, text6);
			}
		}
		catch (Exception ex2)
		{
			bool logSaved2;
			if (logSaved2 = text7 != null)
			{
				logSaved2 = CustomActionUtils.WriteError(text7, "HelpReg", ex2);
			}
			if (text4.ToUpper().Trim() != "NOIDE")
			{
				CustomActionUtils.ShowMessage("Exception message: " + ex2.Message, logSaved2, text6);
			}
		}
	}

	private static bool GetHelpCollections(string ideList, out string[] helpCollections)
	{
		string[] array = ideList.ToUpper().Split(new char[1] { ',' });
		ArrayList arrayList = new ArrayList();
		string[] array2 = array;
		foreach (string text in array2)
		{
			switch (text.Trim())
			{
			case "VS70":
				if (CustomActionUtils.CheckIdeExists("Software\\Microsoft\\VisualStudio\\7.0", "InstallDir"))
				{
					arrayList.Add("MS.VSCC");
				}
				break;
			case "VS71":
				if (CustomActionUtils.CheckIdeExists("Software\\Microsoft\\VisualStudio\\7.1", "InstallDir"))
				{
					arrayList.Add("MS.VSCC.2003");
				}
				break;
			case "VS80":
				if (CustomActionUtils.CheckIdeExists("Software\\Microsoft\\VisualStudio\\8.0", "InstallDir"))
				{
					arrayList.Add("MS.VSCC.V80");
				}
				break;
			case "VS80Expr":
				if (CustomActionUtils.CheckIdeExists("LOCAL_MACHINE\\SOFTWARE\\Microsoft\\VWDExpress\\8.0", "InstallDir") || CustomActionUtils.CheckIdeExists("LOCAL_MACHINE\\SOFTWARE\\Microsoft\\VCSExpress\\8.0", "InstallDir") || CustomActionUtils.CheckIdeExists("LOCAL_MACHINE\\SOFTWARE\\Microsoft\\VCPPExpress\\8.0", "InstallDir") || CustomActionUtils.CheckIdeExists("LOCAL_MACHINE\\SOFTWARE\\Microsoft\\VBExpress\\8.0", "InstallDir"))
				{
					arrayList.Add("MS.VSExpressCC.V80");
				}
				break;
			case "BDS1":
				if (CustomActionUtils.CheckIdeExists("Software\\Borland\\Bds\\1.0", "RootDir"))
				{
					arrayList.Add("BORLAND.BDS");
				}
				break;
			case "BDS2":
				if (CustomActionUtils.CheckIdeExists("Software\\Borland\\Bds\\2.0", "RootDir"))
				{
					arrayList.Add("BORLAND.BDS2");
				}
				break;
			case "BDS3":
				if (CustomActionUtils.CheckIdeExists("Software\\Borland\\Bds\\3.0", "RootDir"))
				{
					arrayList.Add("BORLAND.BDS3");
				}
				break;
			case "BDS4":
				if (CustomActionUtils.CheckIdeExists("Software\\Borland\\Bds\\4.0", "RootDir"))
				{
					arrayList.Add("BORLAND.BDS4");
				}
				break;
			case "BDS5s":
			case "BDS5":
				if (CustomActionUtils.CheckIdeExists("Software\\Borland\\Bds\\5.0", "RootDir"))
				{
					arrayList.Add("BORLAND.BDS5");
				}
				break;
			case "NOIDE":
				helpCollections = new string[0];
				return true;
			}
		}
		helpCollections = new string[arrayList.Count];
		arrayList.CopyTo(helpCollections);
		return helpCollections.Length != 0;
	}
}
