using System;

namespace Publisher.Track;

public class Trackys
{
	private string tag;

	private string Prices;

	public Trackys(string tag, string Prices)
	{
		ia74xuNOwkPgZWORUIc();
		if (COAR8SN3TOg2NYEdkFT())
		{
			OUCepfNkb66v6IJBFCo(this);
			this.tag = tag;
		}
		this.Prices = Prices;
	}

	public void sendtrack(string operation, string status)
	{
		try
		{
			Sender object_ = new Sender((string)gHHwKaN8LdGtTZZ5FFq(tag, "_", operation), status, Prices);
			_ = 1;
			if (!ia74xuNOwkPgZWORUIc())
			{
				F0KUlVNPqGslnpHUqwf(object_);
			}
		}
		catch (Exception object_2)
		{
			FdeXxKNRSgrFAQbT3r1(DyI4inNpcRG33bmaeu6(object_2));
		}
	}

	internal static void OUCepfNkb66v6IJBFCo(object object_0)
	{
		object_0._002Ector();
	}

	internal static bool COAR8SN3TOg2NYEdkFT()
	{
		return true;
	}

	internal static bool ia74xuNOwkPgZWORUIc()
	{
		return false;
	}

	internal static object gHHwKaN8LdGtTZZ5FFq(object object_0, object object_1, object object_2)
	{
		return (string?)object_0 + (string?)object_1 + (string?)object_2;
	}

	internal static object F0KUlVNPqGslnpHUqwf(object object_0)
	{
		return ((Sender)object_0).getResponse();
	}

	internal static object DyI4inNpcRG33bmaeu6(object object_0)
	{
		return ((Exception)object_0).Message;
	}

	internal static void FdeXxKNRSgrFAQbT3r1(object object_0)
	{
		Console.WriteLine((string?)object_0);
	}
}
