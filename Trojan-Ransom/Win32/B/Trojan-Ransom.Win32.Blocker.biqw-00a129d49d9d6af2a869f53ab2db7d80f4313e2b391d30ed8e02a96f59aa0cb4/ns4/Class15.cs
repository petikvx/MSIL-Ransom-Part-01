using System;
using System.Diagnostics;
using System.Reflection;

namespace ns4;

internal class Class15
{
	private static Assembly assembly_0 = null;

	private static string[] string_0 = new string[0];

	internal static void smethod_0()
	{
		try
		{
			AppDomain.CurrentDomain.ResourceResolve += smethod_1;
		}
		catch (Exception)
		{
		}
	}

	private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if ((object)assembly_0 == null)
		{
			lock (string_0)
			{
				assembly_0 = Assembly.Load(GClass4.smethod_0("<ħɲͽСջٷܣ\u085dओ\u0a0b\u0b0d\u0c02൘ด༌\u1056ᄄሌጙᐊᕗᘆ\u1754᠂᥋ᨕᬝ\u1c4aᵏḑἚ‖ℑ∔⌜␓╟☍✀⡏⥫⩿⭰Ⱳ\u2d79⹒⽽のㅂ㉺㍿㑶㕼㘬㜣㡪㤻㨻㬿㰾㴺㸿㼱䀴䅠䈲䌷䐶䔷䙤"));
				if ((object)assembly_0 != null)
				{
					string_0 = assembly_0.GetManifestResourceNames();
				}
			}
		}
		string name = resolveEventArgs_0.Name;
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		if (!smethod_2())
		{
			return null;
		}
		return assembly_0;
	}

	private static bool smethod_2()
	{
		try
		{
			StackFrame[] frames = new StackTrace().GetFrames();
			int num = 2;
			while (true)
			{
				if (num < frames.Length)
				{
					StackFrame stackFrame = frames[num];
					if ((object)stackFrame.GetMethod()!.Module.Assembly == Assembly.GetExecutingAssembly())
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}
		catch
		{
			return true;
		}
	}
}
