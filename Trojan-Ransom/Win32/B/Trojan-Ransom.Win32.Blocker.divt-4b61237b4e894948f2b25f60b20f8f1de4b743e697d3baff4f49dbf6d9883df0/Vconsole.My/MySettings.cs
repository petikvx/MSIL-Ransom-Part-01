using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using dUXD5iWMiCHnmuDtck;

namespace Vconsole.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)N9J5dZPfX26dXsuXfP5(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			_ = 1;
			object object_ = default(object);
			if (!nxo8u6PLxPVPaC7xD6M())
			{
				if (nxo8u6PLxPVPaC7xD6M())
				{
				}
				switch (2)
				{
				case 0:
				case 2:
					if (!addedHandler)
					{
						goto case 3;
					}
					goto IL_0091;
				case 3:
					object_ = addedHandlerLockObject;
					goto case 5;
				case 5:
					w6i5BlP9heEI4vePmbF(object_);
					goto default;
				default:
					pgF9srPZaM77eWh0Fc3(object_);
					break;
				case 4:
				case 6:
					break;
				case 7:
				{
					MySettings result = default(MySettings);
					return result;
				}
				}
			}
			try
			{
				if (!addedHandler)
				{
					((WindowsFormsApplicationBase)xIQeRDPwkZjuAhtQcpm()).add_Shutdown((ShutdownEventHandler)delegate
					{
						if (NMkA6QPFOv0MxjRcZwB(xIQeRDPwkZjuAhtQcpm()))
						{
							ir7xHmPlEJPCghctVMq(JE4OFWPvl8FLjLYVMdC());
						}
					});
					_ = 1;
					if (!nxo8u6PLxPVPaC7xD6M())
					{
						addedHandler = true;
					}
				}
			}
			finally
			{
				NGuaxOPc8ECmeNYxttO(object_);
			}
			goto IL_0091;
			IL_0091:
			return defaultInstance;
		}
	}

	public MySettings()
	{
		HJIFb3P2K3LIYFpjLjU(this);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (NMkA6QPFOv0MxjRcZwB(xIQeRDPwkZjuAhtQcpm()))
		{
			ir7xHmPlEJPCghctVMq(JE4OFWPvl8FLjLYVMdC());
		}
	}

	internal static object N9J5dZPfX26dXsuXfP5(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}

	internal static bool oDdNeUPtnTMk67NfnIw()
	{
		return true;
	}

	internal static bool nxo8u6PLxPVPaC7xD6M()
	{
		return false;
	}

	internal static void HJIFb3P2K3LIYFpjLjU(object object_0)
	{
		((ApplicationSettingsBase)object_0)._002Ector();
	}

	internal static object xIQeRDPwkZjuAhtQcpm()
	{
		return gPsI3QxoND13P74IaN.koSqMXqqI;
	}

	internal static bool NMkA6QPFOv0MxjRcZwB(object object_0)
	{
		return ((WindowsFormsApplicationBase)object_0).get_SaveMySettingsOnExit();
	}

	internal static object JE4OFWPvl8FLjLYVMdC()
	{
		return MySettingsProperty.Settings;
	}

	internal static void ir7xHmPlEJPCghctVMq(object object_0)
	{
		((ApplicationSettingsBase)object_0).Save();
	}

	internal static void w6i5BlP9heEI4vePmbF(object object_0)
	{
		ObjectFlowControl.CheckForSyncLockOnValueType(object_0);
	}

	internal static void pgF9srPZaM77eWh0Fc3(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static void NGuaxOPc8ECmeNYxttO(object object_0)
	{
		Monitor.Exit(object_0);
	}
}
