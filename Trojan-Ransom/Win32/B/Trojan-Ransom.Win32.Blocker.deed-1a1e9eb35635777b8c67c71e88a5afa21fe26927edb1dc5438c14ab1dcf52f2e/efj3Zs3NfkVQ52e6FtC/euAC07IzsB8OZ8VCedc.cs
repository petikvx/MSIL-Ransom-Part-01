using System;
using System.Net;
using System.Web.Services.Protocols;
using eC98jAqdnPLlDITmK6;
using eEE0sjI4GGwwj1C248V;
using eipOOZIdvaMZFu2hMDO;
using emvVksISXYhwWWuY3kr;
using etKNQTu9kgqwCqmIAv;

namespace efj3Zs3NfkVQ52e6FtC;

internal class euAC07IzsB8OZ8VCedc
{
	internal static readonly string eeN1kpseb;

	private string elN6Gg9Qb;

	private string eKyrTQhVp;

	private IWebProxy euXHswL8F;

	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk eo2Gig6Qf;

	public void eulODlten(IWebProxy iwebProxy_0)
	{
		euXHswL8F = iwebProxy_0;
	}

	public void ecs0D1Zdd(erlryuIVq3hNWkBNk9q erlryuIVq3hNWkBNk9q_0)
	{
		_ = 0;
		if (ekLnmHfD5l6Kbw5P6ko())
		{
			int num = 3;
		}
		else
		{
			int num = 2;
			if (e1PvjKfvBUp7GWwlAi6())
			{
				goto IL_0056;
			}
			while (true)
			{
				switch (num)
				{
				default:
					num = 4;
					if (!e1PvjKfvBUp7GWwlAi6())
					{
						continue;
					}
					goto IL_0056;
				case 0:
				case 3:
					break;
				case 1:
				case 2:
					goto IL_0056;
				case 4:
					return;
				}
				break;
			}
		}
		if (eKyrTQhVp == null)
		{
			goto IL_0056;
		}
		goto IL_0100;
		IL_0100:
		e6MWKJfGKXyDLjkiIJM(erlryuIVq3hNWkBNk9q_0, eAwrqrftTvTqnQMCKEK(eKyrTQhVp, eo2Gig6Qf(23095)) ? eKyrTQhVp : eo2Gig6Qf(23037));
		return;
		IL_0056:
		try
		{
			eugpB2ICX7B27crxYe4 object_ = new eugpB2ICX7B27crxYe4();
			if (euXHswL8F != null)
			{
				eLTMGIfpnF8yJL0hIgB(object_, euXHswL8F);
			}
			eKyrTQhVp = (string)emmPlYf8clqrGWqAvlF(object_, elN6Gg9Qb);
			e1PvjKfvBUp7GWwlAi6();
			if (!ekLnmHfD5l6Kbw5P6ko())
			{
				goto IL_00d0;
			}
			if (eeQlydfwo73vi9II6fx(eKyrTQhVp) == 0)
			{
				throw new ApplicationException(eo2Gig6Qf(25516));
			}
			if (e3NQ2gf4SmtI7FXxA5b(eKyrTQhVp, eo2Gig6Qf(25557)))
			{
				goto IL_00d0;
			}
			goto end_IL_0056;
			IL_00d0:
			eKyrTQhVp = eeN1kpseb;
			end_IL_0056:;
		}
		catch (Exception object_2)
		{
			e6MWKJfGKXyDLjkiIJM(erlryuIVq3hNWkBNk9q_0, evMojSfTLgOodiFE4YV(eo2Gig6Qf(25566), eAEleLfVgIcct6JvFLQ(object_2)));
			return;
		}
		goto IL_0100;
	}

	public void e9jslfSvk(byte[] byte_0, string string_0, string string_1, string string_2, erlryuIVq3hNWkBNk9q erlryuIVq3hNWkBNk9q_0)
	{
		try
		{
			eRhjhFIWQOMQdR6djyS eRhjhFIWQOMQdR6djyS = new eRhjhFIWQOMQdR6djyS(eKyrTQhVp);
			if (euXHswL8F != null)
			{
				_ = 0;
				if (ekLnmHfD5l6Kbw5P6ko())
				{
					eLTMGIfpnF8yJL0hIgB(eRhjhFIWQOMQdR6djyS, euXHswL8F);
				}
			}
			e6MWKJfGKXyDLjkiIJM(erlryuIVq3hNWkBNk9q_0, eRhjhFIWQOMQdR6djyS.UploadReport2(elN6Gg9Qb, byte_0, string_0, string_1, string_2));
		}
		catch (Exception object_)
		{
			e6MWKJfGKXyDLjkiIJM(erlryuIVq3hNWkBNk9q_0, evMojSfTLgOodiFE4YV(eo2Gig6Qf(25583), eAEleLfVgIcct6JvFLQ(object_)));
		}
	}

	public euAC07IzsB8OZ8VCedc(string string_0)
	{
		esBhuxf1fOg5vN3phel(this);
		elN6Gg9Qb = string_0;
	}

	static euAC07IzsB8OZ8VCedc()
	{
		enBcoPfqJ6NiVGDFiiA(ekRWhJfRXyNE2LYNxqD(typeof(euAC07IzsB8OZ8VCedc).TypeHandle));
		eeN1kpseb = eo2Gig6Qf(25600);
	}

	internal static bool ekLnmHfD5l6Kbw5P6ko()
	{
		return true;
	}

	internal static bool e1PvjKfvBUp7GWwlAi6()
	{
		return false;
	}

	internal static object emmPlYf8clqrGWqAvlF(object object_0, object object_1)
	{
		return ((eugpB2ICX7B27crxYe4)object_0).GetServerURL((string)object_1);
	}

	internal static int eeQlydfwo73vi9II6fx(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static bool e3NQ2gf4SmtI7FXxA5b(object object_0, object object_1)
	{
		return (string?)object_0 == (string?)object_1;
	}

	internal static void eLTMGIfpnF8yJL0hIgB(object object_0, object object_1)
	{
		((HttpWebClientProtocol)object_0).set_Proxy((IWebProxy)object_1);
	}

	internal static object eAEleLfVgIcct6JvFLQ(object object_0)
	{
		return ((Exception)object_0).Message;
	}

	internal static object evMojSfTLgOodiFE4YV(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static void e6MWKJfGKXyDLjkiIJM(object object_0, object object_1)
	{
		object_0((string)object_1);
	}

	internal static bool eAwrqrftTvTqnQMCKEK(object object_0, object object_1)
	{
		return ((string)object_0).StartsWith((string)object_1);
	}

	internal static void esBhuxf1fOg5vN3phel(object object_0)
	{
		object_0._002Ector();
	}

	internal static Type ekRWhJfRXyNE2LYNxqD(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void enBcoPfqJ6NiVGDFiiA(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
