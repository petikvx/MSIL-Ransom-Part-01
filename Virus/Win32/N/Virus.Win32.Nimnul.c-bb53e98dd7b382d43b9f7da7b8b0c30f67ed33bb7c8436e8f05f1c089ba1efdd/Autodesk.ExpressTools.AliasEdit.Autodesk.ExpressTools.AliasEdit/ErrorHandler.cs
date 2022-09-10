using System.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Autodesk.ExpressTools.AliasEdit.Autodesk.ExpressTools.AliasEdit;

[StandardModule]
internal sealed class ErrorHandler
{
	private static ResourceManager resManager = frmAlias.DefInstance.resManager;

	public static short FileErrors(ref int errVal)
	{
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		short num = 48;
		string @string;
		switch (errVal)
		{
		case 54:
			@string = resManager.GetString("ERRHAND_7");
			num = 50;
			break;
		case 55:
			@string = resManager.GetString("ERRHAND_8");
			break;
		case 57:
			@string = resManager.GetString("ERRHAND_3");
			num = 53;
			break;
		case 61:
			@string = resManager.GetString("ERRHAND_4");
			num = 50;
			break;
		case 62:
			@string = resManager.GetString("ERRHAND_9");
			break;
		case 52:
		case 64:
			@string = resManager.GetString("ERRHAND_5");
			break;
		case 68:
			@string = resManager.GetString("ERRHAND_1");
			num = 53;
			break;
		case 71:
			@string = resManager.GetString("ERRHAND_2");
			num = 53;
			break;
		default:
			return 3;
		case 76:
			@string = resManager.GetString("ERRHAND_6");
			break;
		}
		switch (checked((short)Interaction.MsgBox((object)@string, (MsgBoxStyle)num, (object)resManager.GetString("ERRHAND_TITLE"))))
		{
		default:
			return 3;
		case 1:
		case 2:
		case 3:
			return 2;
		case 4:
			return 0;
		case 5:
			return 1;
		}
	}

	public static void ShowError()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		string text = resManager.GetString("ERRHAND_10") + "\r\n\r\n";
		text = text + Information.Err().get_Description() + "\r\n";
		text = text + resManager.GetString("ERRHAND_10") + Conversions.ToString(Information.Err().get_Number());
		Interaction.Beep();
		Interaction.MsgBox((object)text, (MsgBoxStyle)64, (object)Information.Err().get_Description());
	}
}
