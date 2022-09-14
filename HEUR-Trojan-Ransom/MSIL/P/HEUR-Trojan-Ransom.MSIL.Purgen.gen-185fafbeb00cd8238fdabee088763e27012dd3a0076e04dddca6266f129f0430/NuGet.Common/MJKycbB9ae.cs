using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace NuGet.Common;

public static class MJKycbB9ae
{
	[CompilerGenerated]
	private sealed class _9WeieefwXT
	{
		public string ahqlGEKx3j;

		internal Task<int> TVIIibzKbU(CancellationToken _5Z1DrpkBbK)
		{
			_36bo7aBW4A(ahqlGEKx3j);
			return Task.FromResult(0);
		}
	}

	[CompilerGenerated]
	private sealed class OF4VLJY0ee
	{
		public Action<string> Cv4610zTxz;

		public string PG5e1CDT0i;

		internal Task<int> _1LnZBOK3G9(CancellationToken JLytWoxL3G)
		{
			LxJmObn666(Cv4610zTxz, PG5e1CDT0i);
			return Task.FromResult(0);
		}
	}

	public static readonly int YKV96UT4bk = 3;

	public static readonly FileShare BgOhL0zzh4 = FileShare.ReadWrite | FileShare.Delete;

	public static string _2PKA7eM7LR(string hZPYtwc848)
	{
		string path = $"{Guid.NewGuid()}.tmp".ToLowerInvariant();
		return Path.GetFullPath(Path.Combine(hZPYtwc848, path));
	}

	[AsyncStateMachine(typeof(_003CDeleteWithLock_003Ed__3))]
	public static Task elb2KbZd7d(string cSES2TQYse)
	{
		CNP8E5zkhi stateMachine = default(CNP8E5zkhi);
		stateMachine.F8kPkjCqFo = cSES2TQYse;
		stateMachine.MulS4XnVAJ = AsyncTaskMethodBuilder.Create();
		stateMachine.Xu1sMuxwdk = -1;
		AsyncTaskMethodBuilder mulS4XnVAJ = stateMachine.MulS4XnVAJ;
		mulS4XnVAJ.Start(ref stateMachine);
		return stateMachine.MulS4XnVAJ.Task;
	}

	[AsyncStateMachine(typeof(_003CReplaceWithLock_003Ed__4))]
	public static Task L8OHwz8RSt(Action<string> _6xfmSakOXw, string ripzicdNcd)
	{
		_2lfi3WRp7V stateMachine = default(_2lfi3WRp7V);
		stateMachine.KvUgD6Zbe9 = _6xfmSakOXw;
		stateMachine.oGcD6KoAlW = ripzicdNcd;
		stateMachine.b6E0NdF3uQ = AsyncTaskMethodBuilder.Create();
		stateMachine.b6CVIDcQ81 = -1;
		AsyncTaskMethodBuilder b6E0NdF3uQ = stateMachine.b6E0NdF3uQ;
		b6E0NdF3uQ.Start(ref stateMachine);
		return stateMachine.b6E0NdF3uQ.Task;
	}

	public static void LxJmObn666(Action<string> jS11aCaewd, string Cgi6aM2vkB)
	{
		if (jS11aCaewd == null)
		{
			throw new ArgumentNullException("writeSourceFile");
		}
		if (Cgi6aM2vkB == null)
		{
			throw new ArgumentNullException("destFilePath");
		}
		string text = _2PKA7eM7LR(Path.GetDirectoryName(Cgi6aM2vkB));
		try
		{
			jS11aCaewd(text);
			IaRma9rJaK(text, Cgi6aM2vkB);
		}
		catch
		{
			_36bo7aBW4A(text);
			throw;
		}
	}

	[AsyncStateMachine(typeof(_003CReplaceAsync_003Ed__6))]
	public static Task hIihKmvvvP(Func<string, Task> mJRPCunaK8, string RApG5Xs3UM)
	{
		T84rfyzVPB stateMachine = default(T84rfyzVPB);
		stateMachine.oeMm1fnVaC = mJRPCunaK8;
		stateMachine.hLqk6nEeg3 = RApG5Xs3UM;
		stateMachine.xyoK5XAU9F = AsyncTaskMethodBuilder.Create();
		stateMachine._9CAmeeqmm9 = -1;
		AsyncTaskMethodBuilder xyoK5XAU9F = stateMachine.xyoK5XAU9F;
		xyoK5XAU9F.Start(ref stateMachine);
		return stateMachine.xyoK5XAU9F.Task;
	}

	public static void IaRma9rJaK(string _5mLWLk2mN7, string BoE4vTfOYU)
	{
		_36bo7aBW4A(BoE4vTfOYU);
		sdJN1N5iqs(_5mLWLk2mN7, BoE4vTfOYU);
	}

	public static void sdJN1N5iqs(string My1F4OpkTh, string GoqEiRfBrU)
	{
		if (My1F4OpkTh == null)
		{
			throw new ArgumentNullException("sourceFileName");
		}
		if (GoqEiRfBrU == null)
		{
			throw new ArgumentNullException("destFileName");
		}
		for (int i = 0; i < YKV96UT4bk; i++)
		{
			try
			{
				File.Move(My1F4OpkTh, GoqEiRfBrU);
				break;
			}
			catch (Exception ex) when (i < YKV96UT4bk - 1 && (ex is UnauthorizedAccessException || ex is IOException))
			{
				yuRrvc27iR(100);
			}
		}
	}

	public static void _36bo7aBW4A(string Y8SFN4rCzQ)
	{
		if (Y8SFN4rCzQ == null)
		{
			throw new ArgumentNullException("path");
		}
		for (int i = 0; i < YKV96UT4bk; i++)
		{
			try
			{
				if (File.Exists(Y8SFN4rCzQ))
				{
					File.Delete(Y8SFN4rCzQ);
				}
				break;
			}
			catch (Exception ex) when (i < YKV96UT4bk - 1 && (ex is UnauthorizedAccessException || ex is IOException))
			{
				yuRrvc27iR(100);
			}
		}
	}

	public static T _26W25i5RaW<T>(string l77b9Ngh5B, Func<FileStream, string, T> QJ8aMFa4cq)
	{
		int yKV96UT4bk = YKV96UT4bk;
		for (int i = 1; i <= yKV96UT4bk; i++)
		{
			try
			{
				using FileStream arg = new FileStream(l77b9Ngh5B, FileMode.Open, FileAccess.Read, BgOhL0zzh4);
				return QJ8aMFa4cq(arg, l77b9Ngh5B);
			}
			catch (Exception ex) when (i < yKV96UT4bk && (ex is UnauthorizedAccessException || ex is IOException))
			{
				yuRrvc27iR(100);
			}
		}
		return default(T);
	}

	[AsyncStateMachine(typeof(_003CSafeReadAsync_003Ed__11<>))]
	public static Task<T> jRjbIao1q4<T>(string AWKtOCyJiu, Func<FileStream, string, Task<T>> M6OilHv7DO)
	{
		_8AMfLxbLQ1<T> stateMachine = default(_8AMfLxbLQ1<T>);
		stateMachine.filePath = AWKtOCyJiu;
		stateMachine.read = M6OilHv7DO;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<T>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<T> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private static void yuRrvc27iR(int hbnibMLmXY)
	{
		Thread.Sleep(hbnibMLmXY);
	}
}
