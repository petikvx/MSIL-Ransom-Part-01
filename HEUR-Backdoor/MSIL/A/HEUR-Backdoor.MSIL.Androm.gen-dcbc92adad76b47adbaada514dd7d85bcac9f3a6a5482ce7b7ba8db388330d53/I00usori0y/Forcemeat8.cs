using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Chol2tes;
using L5gicize;
using S0ueezing;
using ns10;
using ns12;

namespace I00usori0y;

public static class Forcemeat8
{
	private const int Fa5nesses = 3000;

	private static readonly TimeSpan Virolo4ic = TimeSpan.FromMilliseconds(10.0);

	private static string Do8ees;

	private static string Sublat5d
	{
		get
		{
			if (Do8ees != null)
			{
				return Do8ees;
			}
			Do8ees = Path.Combine(Ph3l3nges.Accred6ted(GEnum0.Temp), "lock");
			Outstr1tch1d.Tro5l5sm(Do8ees);
			return Do8ees;
		}
	}

	public static async Task<T> smethod_0<T>(string Doo7sayers, Func<CancellationToken, Task<T>> Boi2offs, CancellationToken Tumbl1s1ts)
	{
		if (string.IsNullOrEmpty(Doo7sayers))
		{
			throw new ArgumentNullException("filePath");
		}
		int unauthorizedAttemptsLeft = 3000;
		while (true)
		{
			FileStream fs = null;
			string text = string.Empty;
			try
			{
				try
				{
					text = Focalizatio0s(Doo7sayers);
					fs = Dogf1ghts(text);
				}
				catch (DirectoryNotFoundException)
				{
					throw;
				}
				catch (UnauthorizedAccessException)
				{
					Tumbl1s1ts.ThrowIfCancellationRequested();
					if (unauthorizedAttemptsLeft < 1)
					{
						if (string.IsNullOrEmpty(text))
						{
							text = Sublat5d;
						}
						throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Strings.UnauthorizedLockFail, text, Doo7sayers));
					}
					unauthorizedAttemptsLeft--;
					await Task.Delay(Virolo4ic);
					goto end_IL_0046;
				}
				catch (IOException)
				{
					Tumbl1s1ts.ThrowIfCancellationRequested();
					await Task.Delay(Virolo4ic);
					goto end_IL_0046;
				}
				return await Boi2offs(Tumbl1s1ts);
				end_IL_0046:;
			}
			finally
			{
				fs?.Dispose();
			}
		}
	}

	public static void Tran7mountain(string Be1ge1es, Action Aes8he8ics)
	{
		if (string.IsNullOrEmpty(Be1ge1es))
		{
			throw new ArgumentNullException("filePath");
		}
		int num = 3000;
		while (true)
		{
			FileStream fileStream = null;
			string text = string.Empty;
			try
			{
				try
				{
					text = Focalizatio0s(Be1ge1es);
					fileStream = Dogf1ghts(text);
				}
				catch (DirectoryNotFoundException)
				{
					throw;
				}
				catch (UnauthorizedAccessException)
				{
					if (num < 1)
					{
						if (string.IsNullOrEmpty(text))
						{
							text = Sublat5d;
						}
						throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Strings.UnauthorizedLockFail, text, Be1ge1es));
					}
					num--;
					Thread.Sleep(Virolo4ic);
					goto end_IL_001b;
				}
				catch (IOException)
				{
					Thread.Sleep(Virolo4ic);
					goto end_IL_001b;
				}
				Aes8he8ics();
				break;
				end_IL_001b:;
			}
			finally
			{
				fileStream?.Dispose();
			}
		}
	}

	private static FileStream Dogf1ghts(string Tra8doors)
	{
		FileOptions options = (Unst0ck.Oli1odendrocyte ? FileOptions.DeleteOnClose : FileOptions.None);
		return new FileStream(Tra8doors, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None, 32, options);
	}

	private static string Focalizatio0s(string Over2radin2)
	{
		Outstr1tch1d.Tro5l5sm(Sublat5d);
		return Path.Combine(Sublat5d, Fo4ti4as(Over2radin2));
	}

	private static string Fo4ti4as(string Anima2)
	{
		using SHA1 sHA = SHA1.Create();
		string s = (Path.IsPathRooted(Anima2) ? Path.GetFullPath(Anima2) : Anima2).ToUpperInvariant();
		return Hoo5ooe5(sHA.ComputeHash(Encoding.UTF32.GetBytes(s)));
	}

	private static string Hoo5ooe5(byte[] Foresho7k)
	{
		char[] array = new char[Foresho7k.Length * 2];
		int i = 0;
		int num = 0;
		for (; i < Foresho7k.Length; i++)
		{
			array[num++] = Iso5roterenols(Foresho7k[i] >> 4);
			array[num++] = Iso5roterenols(Foresho7k[i] & 0xF);
		}
		return new string(array);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static char Iso5roterenols(int Wat6rcours6s)
	{
		if (Wat6rcours6s > 9)
		{
			return (char)(Wat6rcours6s + 87);
		}
		return (char)(Wat6rcours6s + 48);
	}
}
