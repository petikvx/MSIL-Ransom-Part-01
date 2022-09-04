using System;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;
using TechLifePlanner.BaseFunctions.FunctionC;

namespace TechLifePlanner;

public class GetImages
{
	[DebuggerNonUserCode]
	public GetImages()
	{
	}

	public static byte[] ParseBitmaps()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		try
		{
			Bitmap data = (Bitmap)CR.PRM.GetObject("Cataclysm");
			return CP.ReversePixels(data);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			byte[] result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
