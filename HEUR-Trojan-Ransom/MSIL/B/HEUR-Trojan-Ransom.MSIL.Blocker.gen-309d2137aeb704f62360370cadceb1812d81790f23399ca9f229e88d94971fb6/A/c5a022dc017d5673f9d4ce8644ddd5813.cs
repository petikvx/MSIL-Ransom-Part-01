using System;
using System.IO;
using System.Reflection;

namespace A;

internal class c5a022dc017d5673f9d4ce8644ddd5813
{
	private static readonly Assembly cb553ff1adab1e29174ed39d38ad9037e;

	static c5a022dc017d5673f9d4ce8644ddd5813()
	{
		c6606794939bfcacdf62351c5a3b3fc09.c77162f228f13a3506cf10e6c077c680d(cd997b6fb826255b4f4315e441fffc0d8.cdb5846019249e32f391691c01d390d78(), ce899b0294e546ed64c73134296e24267);
		c8520c751f34ca47b74f8bde0511778c1.c77162f228f13a3506cf10e6c077c680d(cd997b6fb826255b4f4315e441fffc0d8.cdb5846019249e32f391691c01d390d78(), c44240d8472ddb0d19138d46d5011b49a);
		Assembly assembly = c991dec4139a9f6d287bd699f90d764f8.cdb5846019249e32f391691c01d390d78();
		string text = c9a15b06ee32a27aa226e1f0a5b98e617(assembly);
		cb553ff1adab1e29174ed39d38ad9037e = c81bf5e1293173680e14dfd31e254ac9e.cdb5846019249e32f391691c01d390d78(text);
	}

	internal static void c41708ac600edd21aad277842a35b54e4()
	{
	}

	private static Assembly c44240d8472ddb0d19138d46d5011b49a(object P_0, ResolveEventArgs P_1)
	{
		Assembly assembly = c991dec4139a9f6d287bd699f90d764f8.cdb5846019249e32f391691c01d390d78();
		string text = c9a15b06ee32a27aa226e1f0a5b98e617(assembly);
		if (c9a9f86421ca0e42b9b9bb418cd912f37.c77162f228f13a3506cf10e6c077c680d(c95337686619457067581f578b8d0ca68.c77162f228f13a3506cf10e6c077c680d(P_1), text))
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					break;
				default:
				{
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					Stream stream = c2cf89a990bd73ce650c8302fd458368d.c77162f228f13a3506cf10e6c077c680d(assembly, text);
					byte[] array = caaa9892e55af57ca7802d20b2cd5be85.c7e8eb5a938e48808a26d839d10c2ffcf(97L, stream);
					return c26b29d00376d1935aa1c542a956a4acb.cdb5846019249e32f391691c01d390d78(array);
				}
				}
			}
		}
		return null;
	}

	private static string c9a15b06ee32a27aa226e1f0a5b98e617(Assembly P_0)
	{
		string text = cef980ccee7a8d051a201b885cb91853b.c77162f228f13a3506cf10e6c077c680d(P_0);
		int num = c1765ff1947f0f416b7c40cd857e90c93.c77162f228f13a3506cf10e6c077c680d(text, ',');
		if (num >= 0)
		{
			while (true)
			{
				switch (4)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			text = cf6b87a55e8fdb40f2dbe1f784968ef4f.c77162f228f13a3506cf10e6c077c680d(text, 0, num);
		}
		return c77163b847e3258fba64e5fd489672ea2.cdb5846019249e32f391691c01d390d78(text, '&');
	}

	private static Assembly ce899b0294e546ed64c73134296e24267(object P_0, ResolveEventArgs P_1)
	{
		if ((object)cb553ff1adab1e29174ed39d38ad9037e != null)
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					break;
				default:
				{
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					string[] array = cc2af8b9af425fcb3c1d1b20fa6a7164f.c77162f228f13a3506cf10e6c077c680d(cb553ff1adab1e29174ed39d38ad9037e);
					for (int i = 0; i < (int)(nuint)c0f6b8c8e8a46398ab044b5602e547a06.ce52fc13bd0b1cfec401eb6a87239469b(array); i++)
					{
						string text = array[i];
						if (c8031f0915e3f9fea66238f7a89a7092b.cdb5846019249e32f391691c01d390d78(text, c95337686619457067581f578b8d0ca68.c77162f228f13a3506cf10e6c077c680d(P_1)))
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									break;
								default:
									return cb553ff1adab1e29174ed39d38ad9037e;
								}
							}
						}
					}
					while (true)
					{
						switch (1)
						{
						case 0:
							break;
						default:
							return null;
						}
					}
				}
				}
			}
		}
		return cb553ff1adab1e29174ed39d38ad9037e;
	}
}
