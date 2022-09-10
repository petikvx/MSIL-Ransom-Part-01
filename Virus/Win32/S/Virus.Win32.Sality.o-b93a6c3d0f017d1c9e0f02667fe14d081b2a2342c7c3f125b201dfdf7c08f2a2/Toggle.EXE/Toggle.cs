using System;
using System.Drawing;
using System.Windows.Forms;
using ATI.ACE.ACE.Graphics.DisplaysManager.Shared;
using ATI.ACE.CLI.Caste.Graphics.Shared;
using ATI.ACE.CLI.Foundation;
using ATI.ACE.LOG.Foundation;

namespace Toggle.EXE;

internal class Toggle
{
	private const string FORM_NAME = "Toggle";

	private const string RUNTIME_NAME = "Runtime";

	[STAThread]
	private static void Main(string[] args)
	{
		Services.DefaultDomainInitialize(false, "Toggle", (ShellType)2);
		IMBRO obj = Services.ConnectToObject("Runtime");
		IComponent val = (IComponent)(object)((obj is IComponent) ? obj : null);
		if (val == null)
		{
			return;
		}
		val.Detect();
		SCaste sCaste = val.GetSCaste(SGraphicsCaste.CasteName);
		if (sCaste == null)
		{
			return;
		}
		ICaste iCaste = sCaste.iCaste;
		if (iCaste == null)
		{
			return;
		}
		IGraphicsCaste val2 = (IGraphicsCaste)(object)((iCaste is IGraphicsCaste) ? iCaste : null);
		if (val2 == null)
		{
			return;
		}
		int mousePositionAdapterIndex = GetMousePositionAdapterIndex(val2);
		if (-1 != mousePositionAdapterIndex)
		{
			SAdapter sAdapter = ((ICaste)val2).GetSAdapter(mousePositionAdapterIndex);
			SGraphicsAdapter val3 = (SGraphicsAdapter)(object)((sAdapter is SGraphicsAdapter) ? sAdapter : null);
			if (val3 != null)
			{
				DMHotkeysHandling.TogglePossibleModes(val2, val3, val);
			}
		}
	}

	private static int GetMousePositionAdapterIndex(IGraphicsCaste igc)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Invalid comparison between Unknown and I4
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Invalid comparison between Unknown and I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		Point mousePosition = Control.get_MousePosition();
		int result = -1;
		SAdapter[] sAdapters = ((ICaste)igc).GetSAdapters();
		SAdapter[] array = sAdapters;
		foreach (SAdapter val in array)
		{
			SGraphicsAdapter val2 = (SGraphicsAdapter)(object)((val is SGraphicsAdapter) ? val : null);
			if (!((SAdapter)val2).get_active())
			{
				continue;
			}
			int xPos = ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C().xPos;
			int yPos = ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C().yPos;
			int num = 0;
			int num2 = 0;
			ANGLES orientation = ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C().orientation;
			if ((int)orientation <= 90)
			{
				if ((int)orientation != 0 && (int)orientation == 90)
				{
					goto IL_00b6;
				}
			}
			else if ((int)orientation != 180 && (int)orientation == 270)
			{
				goto IL_00b6;
			}
			num = ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C().xRes;
			num2 = ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C().yRes;
			goto IL_012c;
			IL_012c:
			if (mousePosition.X >= xPos && mousePosition.X < xPos + num && mousePosition.Y >= yPos && mousePosition.Y < yPos + num2)
			{
				result = ((SAdapter)val2).index;
				break;
			}
			continue;
			IL_00b6:
			num = ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C().yRes;
			num2 = ((SPropertySetting_MODEINFO)val2.displaysManagerInfo.mode.Control).get_C().xRes;
			goto IL_012c;
		}
		return result;
	}
}
