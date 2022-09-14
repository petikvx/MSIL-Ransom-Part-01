using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NuGet.Common;

public static class Zx9YvjHhO9
{
	private const int V7c5WTxEWM = 3000;

	private static readonly TimeSpan rudXTTxX9z = TimeSpan.FromMilliseconds(10.0);

	private static string PxaHaT0lZy;

	private static string sh0qO8Dr4e
	{
		get
		{
			if (PxaHaT0lZy != null)
			{
				return PxaHaT0lZy;
			}
			PxaHaT0lZy = Path.Combine(hE1biszR17.SX1Br5Fk1Y(YeXhnQPbgq.Temp), "lock");
			_9Cinr8QmyZ._84vHHOeo02(PxaHaT0lZy);
			return PxaHaT0lZy;
		}
	}

	[AsyncStateMachine(typeof(_003CExecuteWithFileLockedAsync_003Ed__2<>))]
	public static Task<T> ycbKN2LAc5<T>(string rsstKyZVWk, Func<CancellationToken, Task<T>> AEQhP7qY92, CancellationToken sninzMaHKY)
	{
		v0dHNzCXlo<T> stateMachine = default(v0dHNzCXlo<T>);
		stateMachine.filePath = rsstKyZVWk;
		stateMachine.action = AEQhP7qY92;
		stateMachine.token = sninzMaHKY;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<T>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<T> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public static void vczsbTySdP(string GCtuRhYLWU, Action _0xNnx35hUK)
	{
		if (string.IsNullOrEmpty(GCtuRhYLWU))
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
					text = Jw59aJXrug(GCtuRhYLWU);
					fileStream = aRukTKQtQ1(text);
				}
				catch (DirectoryNotFoundException)
				{
					throw;
				}
				catch (PathTooLongException)
				{
					throw;
				}
				catch (UnauthorizedAccessException)
				{
					if (num < 1)
					{
						if (string.IsNullOrEmpty(text))
						{
							text = sh0qO8Dr4e;
						}
						throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, vK4KTOtZYy._8izEXGEPhm, text, GCtuRhYLWU));
					}
					num--;
					Thread.Sleep(rudXTTxX9z);
					goto end_IL_0021;
				}
				catch (IOException)
				{
					Thread.Sleep(rudXTTxX9z);
					goto end_IL_0021;
				}
				_0xNnx35hUK();
				break;
				end_IL_0021:;
			}
			finally
			{
				fileStream?.Dispose();
			}
		}
	}

	private static FileStream aRukTKQtQ1(string Er0gt1beZJ)
	{
		FileOptions options = (l6BkPTcFbv.ooEPhgvzVK ? FileOptions.DeleteOnClose : FileOptions.None);
		return new FileStream(Er0gt1beZJ, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None, 32, options);
	}

	private static string Jw59aJXrug(string nPUih2Dvz4)
	{
		_9Cinr8QmyZ._84vHHOeo02(sh0qO8Dr4e);
		return Path.Combine(sh0qO8Dr4e, X5bmHvVxqa(nPUih2Dvz4));
	}

	private static string X5bmHvVxqa(string Aw8bIdexH2)
	{
		using SHA1 sHA = SHA1.Create();
		string s = (Path.IsPathRooted(Aw8bIdexH2) ? Path.GetFullPath(Aw8bIdexH2) : Aw8bIdexH2).ToUpperInvariant();
		return rZXfaQFYbD(sHA.ComputeHash(Encoding.UTF32.GetBytes(s)));
	}

	private static string rZXfaQFYbD(byte[] VONk1KSeTu)
	{
		char[] array = new char[VONk1KSeTu.Length * 2];
		int i = 0;
		int num = 0;
		for (; i < VONk1KSeTu.Length; i++)
		{
			array[num++] = IlPJju8Wby(VONk1KSeTu[i] >> 4);
			array[num++] = IlPJju8Wby(VONk1KSeTu[i] & 0xF);
		}
		return new string(array);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static char IlPJju8Wby(int ZsuVl2fmdD)
	{
		if (ZsuVl2fmdD > 9)
		{
			return (char)(ZsuVl2fmdD + 87);
		}
		return (char)(ZsuVl2fmdD + 48);
	}
}
