using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using NCDRxx4R49CZy0gNBsi;
using Q0ObqKLEPKsj4AfDfmw;

namespace OjQPE41Th8uBQ4640W;

internal sealed class NSMwbWB6oiBcoo1OhZ
{
	private static Assembly LxZ2VLevZZ;

	private static string[] Lnv271XU9k;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void BCv2FFkEH2()
	{
		try
		{
			try
			{
				AppDomain.CurrentDomain.ResourceResolve += qEq2lYQJ1V;
			}
			catch (Exception)
			{
			}
		}
		catch (Exception ex2)
		{
			pptnOHLG0SvOsuFuFDn.i0gTDRVccZ(ex2);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Assembly qEq2lYQJ1V(object _0020, object _0020)
	{
		//Discarded unreachable code: IL_003e
		string[] lnv271XU9k = default(string[]);
		string name = default(string);
		int i = default(int);
		try
		{
			if ((object)LxZ2VLevZZ == null)
			{
				Monitor.Enter(lnv271XU9k = Lnv271XU9k);
				try
				{
					LxZ2VLevZZ = Assembly.Load("{4e083271-e2f3-4fcd-9cd4-16552709e736}, PublicKeyToken=3e56350693f7355e");
					int num = 2;
					while (true)
					{
						switch (num)
						{
						case 0:
						case 2:
							if ((object)LxZ2VLevZZ != null)
							{
								break;
							}
							goto end_IL_004b;
						default:
							goto IL_0060;
						case 1:
						case 3:
							break;
						}
						Lnv271XU9k = LxZ2VLevZZ.GetManifestResourceNames();
						break;
						IL_0060:
						num = 3;
						continue;
						end_IL_004b:
						break;
					}
				}
				finally
				{
					Monitor.Exit(lnv271XU9k);
				}
			}
			name = ((ResolveEventArgs)_0020).Name;
			for (i = 0; i < Lnv271XU9k.Length; i++)
			{
				if (Lnv271XU9k[i] == name)
				{
					if (!Irv2jbSrVa())
					{
						return null;
					}
					return LxZ2VLevZZ;
				}
			}
			return null;
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.akITQBYJ2K(ex, name, i, lnv271XU9k, _0020, _0020);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool Irv2jbSrVa()
	{
		StackFrame[] frames = default(StackFrame[]);
		int i = default(int);
		StackFrame stackFrame = default(StackFrame);
		bool flag = default(bool);
		try
		{
			try
			{
				frames = new StackTrace().GetFrames();
				for (i = 2; i < frames.Length; i++)
				{
					stackFrame = frames[i];
					if ((object)stackFrame.GetMethod()!.Module.Assembly == Assembly.GetExecutingAssembly())
					{
						flag = true;
						return flag;
					}
				}
				flag = false;
				return flag;
			}
			catch
			{
				flag = true;
				return flag;
			}
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.xQCTA4LbeV(ex, frames, i, stackFrame, flag);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NSMwbWB6oiBcoo1OhZ()
	{
		QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
		base._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static NSMwbWB6oiBcoo1OhZ()
	{
		QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
		try
		{
			LxZ2VLevZZ = null;
			Lnv271XU9k = new string[0];
		}
		catch (Exception ex)
		{
			pptnOHLG0SvOsuFuFDn.i0gTDRVccZ(ex);
			throw;
		}
	}

	internal static bool An78ijYqS67WoKbKHF()
	{
		return true;
	}

	internal static bool DW4gEMb8J8gi039VCJ()
	{
		return false;
	}
}
