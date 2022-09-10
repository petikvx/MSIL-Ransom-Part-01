using System;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using com.sap.bi.et.Communication;
using com.sap.bi.et.common.BExControls;

namespace com.sap.bi.et.QueryDesigner.QDStarter;

public class QDStartup
{
	private static bool ShowSplashScreen = true;

	private const string mcApolloBeta = "40";

	[AccessedThroughProperty("mQueryDesigner")]
	private static QDbQueryDesigner _mQueryDesigner;

	private static string TestLayout = "";

	private static bool AlternativeOpen = false;

	private static bool AlternativeSave = false;

	private static bool DefaultTexts = false;

	private static bool IsTestCase = false;

	private static QDbQueryDesigner mQueryDesigner
	{
		[DebuggerNonUserCode]
		get
		{
			return _mQueryDesigner;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			if (_mQueryDesigner != null)
			{
				_mQueryDesigner.remove_Initialized(new InitializedEventHandler(InitializedHandler));
			}
			_mQueryDesigner = value;
			if (_mQueryDesigner != null)
			{
				_mQueryDesigner.add_Initialized(new InitializedEventHandler(InitializedHandler));
			}
		}
	}

	[DebuggerNonUserCode]
	public QDStartup()
	{
	}

	[STAThread]
	public static void Main()
	{
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		if (ConfigurationSettings.get_AppSettings()["Splashscreen"] != null)
		{
			ShowSplashScreen = Convert.ToBoolean(ConfigurationSettings.get_AppSettings()["Splashscreen"]);
		}
		if (ConfigurationSettings.get_AppSettings()["AlternativeOpen"] != null)
		{
			AlternativeOpen = Convert.ToBoolean(ConfigurationSettings.get_AppSettings()["AlternativeOpen"]);
		}
		if (ConfigurationSettings.get_AppSettings()["AlternativeSave"] != null)
		{
			AlternativeSave = Convert.ToBoolean(ConfigurationSettings.get_AppSettings()["AlternativeSave"]);
		}
		if (ConfigurationSettings.get_AppSettings()["DefaultTexts"] != null)
		{
			DefaultTexts = Convert.ToBoolean(ConfigurationSettings.get_AppSettings()["DefaultTexts"]);
		}
		if (ConfigurationSettings.get_AppSettings()["IsTestCase"] != null)
		{
			IsTestCase = Convert.ToBoolean(ConfigurationSettings.get_AppSettings()["IsTestCase"]);
		}
		if (ConfigurationSettings.get_AppSettings()["TestLayout"] != null)
		{
			TestLayout = Convert.ToString(ConfigurationSettings.get_AppSettings()["TestLayout"]);
		}
		Assembly assembly = Assembly.GetAssembly(typeof(QDbQueryDesigner));
		FileVersionInfo fileVersionInfo = null;
		if ((object)assembly != null)
		{
			fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
		}
		if (Logon())
		{
			if (BExSystemProperties.CheckCTOAndGuiAttached((Form)null))
			{
				if (QDbQueryDesigner.VersionCheck())
				{
					if (ShowSplashScreen)
					{
						BExSplashScreen.ShowSplashScreen((BExApps)2, fileVersionInfo, "");
					}
					if (Operators.CompareString(CommunicationFactory.get_SAPConnection().get_ServerVersion(), "40", false) < 0)
					{
						if (ShowSplashScreen)
						{
							BExSplashScreen.HideSplashScreen();
						}
						MessageBox.Show("The standalone Query Designer currently works not with pre BW 7.0 Systems!");
					}
					else
					{
						mQueryDesigner = new QDbQueryDesigner();
						_mQueryDesigner.SetOptions(TestLayout, DefaultTexts, AlternativeOpen, AlternativeSave, IsTestCase);
						_mQueryDesigner.Run(true);
					}
				}
			}
			else
			{
				CommunicationFactory.get_Connected();
			}
		}
		if (ShowSplashScreen)
		{
			BExSplashScreen.HideSplashScreen();
		}
	}

	private static bool Logon()
	{
		IntPtr intPtr = new IntPtr(0);
		CommunicationFactory.LogOn(intPtr);
		return CommunicationFactory.get_Connected();
	}

	private static void InitializedHandler(object sender, EventArgs e)
	{
		if (ShowSplashScreen)
		{
			BExSplashScreen.HideSplashScreen();
			ShowSplashScreen = false;
		}
	}
}
