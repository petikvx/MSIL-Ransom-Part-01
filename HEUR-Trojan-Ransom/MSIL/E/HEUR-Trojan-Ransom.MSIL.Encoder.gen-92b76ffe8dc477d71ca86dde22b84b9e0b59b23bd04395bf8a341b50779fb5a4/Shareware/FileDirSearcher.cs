using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Shareware;

public sealed class FileDirSearcher
{
	public static IEnumerable<FileInfo> GetFiles(string dirPath, SearchOption searchOption, IEnumerable<string> fileNamePatterns = null, IEnumerable<string> fileExtPatterns = null, bool ignoreCase = true, bool throwOnError = false)
	{
		AnalyzePath(ref dirPath);
		if (!Directory.Exists(dirPath))
		{
			throw new ArgumentException($"Directory doesn't exists: '{dirPath}'", "dirPath");
		}
		if (searchOption != 0 && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentException($"Value of '{Conversions.ToString((int)searchOption)}' is not valid enumeration value.", "searchOption");
		}
		ConcurrentQueue<FileInfo> concurrentQueue = new ConcurrentQueue<FileInfo>();
		CollectFiles(concurrentQueue, dirPath, searchOption, fileNamePatterns, fileExtPatterns, ignoreCase, throwOnError);
		return concurrentQueue.AsEnumerable();
	}

	public static IEnumerable<string> GetFilePaths(string dirPath, SearchOption searchOption, IEnumerable<string> fileNamePatterns = null, IEnumerable<string> fileExtPatterns = null, bool ignoreCase = true, bool throwOnError = false)
	{
		AnalyzePath(ref dirPath);
		if (!Directory.Exists(dirPath))
		{
			throw new ArgumentException($"Directory doesn't exists: '{dirPath}'", "dirPath");
		}
		if (searchOption != 0 && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentException($"Value of '{Conversions.ToString((int)searchOption)}' is not valid enumeration value.", "searchOption");
		}
		ConcurrentQueue<string> concurrentQueue = new ConcurrentQueue<string>();
		CollectFilePaths(concurrentQueue, dirPath, searchOption, fileNamePatterns, fileExtPatterns, ignoreCase, throwOnError);
		return concurrentQueue.AsEnumerable();
	}

	public static IEnumerable<DirectoryInfo> GetDirs(string dirPath, SearchOption searchOption, IEnumerable<string> dirPathPatterns = null, IEnumerable<string> dirNamePatterns = null, bool ignoreCase = true, bool throwOnError = false)
	{
		AnalyzePath(ref dirPath);
		if (!Directory.Exists(dirPath))
		{
			throw new ArgumentException($"Directory doesn't exists: '{dirPath}'", "dirPath");
		}
		if (searchOption != 0 && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentException($"Value of '{Conversions.ToString((int)searchOption)}' is not valid enumeration value.", "searchOption");
		}
		ConcurrentQueue<DirectoryInfo> concurrentQueue = new ConcurrentQueue<DirectoryInfo>();
		CollectDirs(concurrentQueue, dirPath, searchOption, dirPathPatterns, dirNamePatterns, ignoreCase, throwOnError);
		return concurrentQueue.AsEnumerable();
	}

	public static IEnumerable<string> GetDirPaths(string dirPath, SearchOption searchOption, IEnumerable<string> dirPathPatterns = null, IEnumerable<string> dirNamePatterns = null, bool ignoreCase = true, bool throwOnError = false)
	{
		AnalyzePath(ref dirPath);
		if (!Directory.Exists(dirPath))
		{
			throw new ArgumentException($"Directory doesn't exists: '{dirPath}'", "dirPath");
		}
		if (searchOption != 0 && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentException($"Value of '{Conversions.ToString((int)searchOption)}' is not valid enumeration value.", "searchOption");
		}
		ConcurrentQueue<string> concurrentQueue = new ConcurrentQueue<string>();
		CollectDirPaths(concurrentQueue, dirPath, searchOption, dirPathPatterns, dirNamePatterns, ignoreCase, throwOnError);
		return concurrentQueue.AsEnumerable();
	}

	private static void AnalyzePath(ref string dirPath)
	{
		if (!string.IsNullOrEmpty(dirPath) && !string.IsNullOrWhiteSpace(dirPath))
		{
			dirPath = dirPath.TrimStart(new char[1] { ' ' }).TrimEnd(new char[1] { ' ' });
			if (Path.IsPathRooted(dirPath))
			{
				dirPath = Conversions.ToString(char.ToUpper(dirPath.First())) + dirPath.Substring(1);
			}
			if (!dirPath.EndsWith("\\"))
			{
				dirPath = dirPath.Insert(dirPath.Length, "\\");
			}
			return;
		}
		throw new ArgumentNullException("dirPath", "Value is null, empty, or white-spaced.");
	}

	private static void CollectFiles(ConcurrentQueue<FileInfo> queue, string dirPath, SearchOption searchOption, IEnumerable<string> fileNamePatterns, IEnumerable<string> fileExtPatterns, bool ignoreCase, bool throwOnError)
	{
		DirectoryInfo directoryInfo = null;
		IEnumerable<FileInfo> enumerable = null;
		try
		{
			directoryInfo = new DirectoryInfo(dirPath);
		}
		catch (ArgumentNullException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (ArgumentException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (SecurityException projectError3)
		{
			ProjectData.SetProjectError((Exception)projectError3);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (PathTooLongException projectError4)
		{
			ProjectData.SetProjectError((Exception)projectError4);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		try
		{
			enumerable = ((fileExtPatterns == null) ? directoryInfo.GetFiles("*", SearchOption.TopDirectoryOnly) : directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly));
		}
		catch (UnauthorizedAccessException projectError5)
		{
			ProjectData.SetProjectError((Exception)projectError5);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError6)
		{
			ProjectData.SetProjectError((Exception)projectError6);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		if (enumerable != null)
		{
			foreach (FileInfo item in enumerable)
			{
				bool flag = false;
				bool flag2 = false;
				if (fileNamePatterns != null)
				{
					foreach (string fileNamePattern in fileNamePatterns)
					{
						if (!fileNamePattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (ignoreCase)
							{
								if (LikeOperator.LikeString(item.get_Name().ToLower(), fileNamePattern.ToLower(), (CompareMethod)0))
								{
									flag = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(item.get_Name(), fileNamePattern, (CompareMethod)0))
							{
								flag = true;
								break;
							}
							continue;
						}
						flag = true;
						break;
					}
				}
				else
				{
					flag = true;
				}
				if (fileExtPatterns != null)
				{
					foreach (string fileExtPattern in fileExtPatterns)
					{
						if (!fileExtPattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (ignoreCase)
							{
								if (LikeOperator.LikeString(item.Extension.ToLower(), fileExtPattern.ToLower(), (CompareMethod)0))
								{
									flag2 = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(item.Extension, fileExtPattern, (CompareMethod)0))
							{
								flag2 = true;
								break;
							}
							continue;
						}
						flag2 = true;
						break;
					}
				}
				else
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					queue.Enqueue(item);
				}
			}
		}
		if (searchOption != SearchOption.AllDirectories)
		{
			return;
		}
		try
		{
			Task.WaitAll((from dir in directoryInfo.GetDirectories()
				select Task.Factory.StartNew(delegate
				{
					CollectFiles(queue, dir.FullName, SearchOption.AllDirectories, fileNamePatterns, fileExtPatterns, ignoreCase, throwOnError);
				})).ToArray());
		}
		catch (UnauthorizedAccessException projectError8)
		{
			ProjectData.SetProjectError((Exception)projectError8);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError9)
		{
			ProjectData.SetProjectError((Exception)projectError9);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
	}

	private static void CollectFilePaths(ConcurrentQueue<string> queue, string dirPath, SearchOption searchOption, IEnumerable<string> fileNamePatterns, IEnumerable<string> fileExtPatterns, bool ignoreCase, bool throwOnError)
	{
		IEnumerable<string> enumerable = null;
		try
		{
			enumerable = ((fileExtPatterns == null) ? Directory.GetFiles(dirPath, "*", SearchOption.TopDirectoryOnly) : Directory.GetFiles(dirPath, "*.*", SearchOption.TopDirectoryOnly));
		}
		catch (UnauthorizedAccessException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		if (enumerable != null)
		{
			foreach (string item in enumerable)
			{
				bool flag = false;
				bool flag2 = false;
				if (fileNamePatterns != null)
				{
					foreach (string fileNamePattern in fileNamePatterns)
					{
						if (!fileNamePattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (ignoreCase)
							{
								if (LikeOperator.LikeString(Path.GetFileNameWithoutExtension(item)!.ToLower(), fileNamePattern.ToLower(), (CompareMethod)0))
								{
									flag = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(Path.GetFileNameWithoutExtension(item), fileNamePattern, (CompareMethod)0))
							{
								flag = true;
								break;
							}
							continue;
						}
						flag = true;
						break;
					}
				}
				else
				{
					flag = true;
				}
				if (fileExtPatterns != null)
				{
					foreach (string fileExtPattern in fileExtPatterns)
					{
						if (!fileExtPattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (ignoreCase)
							{
								if (LikeOperator.LikeString(Path.GetExtension(item)!.ToLower(), fileExtPattern.ToLower(), (CompareMethod)0))
								{
									flag2 = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(Path.GetExtension(item), fileExtPattern, (CompareMethod)0))
							{
								flag2 = true;
								break;
							}
							continue;
						}
						flag2 = true;
						break;
					}
				}
				else
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					queue.Enqueue(item);
				}
			}
		}
		if (searchOption != SearchOption.AllDirectories)
		{
			return;
		}
		try
		{
			Task.WaitAll((from dir in new DirectoryInfo(dirPath).GetDirectories()
				select Task.Factory.StartNew(delegate
				{
					CollectFilePaths(queue, dir.FullName, SearchOption.AllDirectories, fileNamePatterns, fileExtPatterns, ignoreCase, throwOnError);
				})).ToArray());
		}
		catch (UnauthorizedAccessException projectError4)
		{
			ProjectData.SetProjectError((Exception)projectError4);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError5)
		{
			ProjectData.SetProjectError((Exception)projectError5);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
	}

	private static void CollectDirs(ConcurrentQueue<DirectoryInfo> queue, string dirPath, SearchOption searchOption, IEnumerable<string> dirPathPatterns, IEnumerable<string> dirNamePatterns, bool ignoreCase, bool throwOnError)
	{
		DirectoryInfo directoryInfo = null;
		IEnumerable<DirectoryInfo> enumerable = null;
		try
		{
			directoryInfo = new DirectoryInfo(dirPath);
		}
		catch (ArgumentNullException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (ArgumentException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (SecurityException projectError3)
		{
			ProjectData.SetProjectError((Exception)projectError3);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (PathTooLongException projectError4)
		{
			ProjectData.SetProjectError((Exception)projectError4);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		try
		{
			enumerable = directoryInfo.GetDirectories("*", SearchOption.TopDirectoryOnly);
		}
		catch (UnauthorizedAccessException projectError5)
		{
			ProjectData.SetProjectError((Exception)projectError5);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError6)
		{
			ProjectData.SetProjectError((Exception)projectError6);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		if (enumerable != null)
		{
			foreach (DirectoryInfo item in enumerable)
			{
				bool flag = false;
				bool flag2 = false;
				if (dirPathPatterns != null)
				{
					foreach (string dirPathPattern in dirPathPatterns)
					{
						if (!dirPathPattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (ignoreCase)
							{
								if (LikeOperator.LikeString(item.FullName.ToLower(), dirPathPattern.ToLower(), (CompareMethod)0))
								{
									flag = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(item.FullName, dirPathPattern, (CompareMethod)0))
							{
								flag = true;
								break;
							}
							continue;
						}
						flag = true;
						break;
					}
				}
				else
				{
					flag = true;
				}
				if (dirNamePatterns != null)
				{
					foreach (string dirNamePattern in dirNamePatterns)
					{
						if (!dirNamePattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (ignoreCase)
							{
								if (LikeOperator.LikeString(item.get_Name().ToLower(), dirNamePattern.ToLower(), (CompareMethod)0))
								{
									flag2 = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(item.get_Name(), dirNamePattern, (CompareMethod)0))
							{
								flag2 = true;
								break;
							}
							continue;
						}
						flag2 = true;
						break;
					}
				}
				else
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					queue.Enqueue(item);
				}
			}
		}
		if (searchOption != SearchOption.AllDirectories)
		{
			return;
		}
		try
		{
			Task.WaitAll((from dir in directoryInfo.GetDirectories()
				select Task.Factory.StartNew(delegate
				{
					CollectDirs(queue, dir.FullName, SearchOption.AllDirectories, dirPathPatterns, dirNamePatterns, ignoreCase, throwOnError);
				})).ToArray());
		}
		catch (UnauthorizedAccessException projectError8)
		{
			ProjectData.SetProjectError((Exception)projectError8);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError9)
		{
			ProjectData.SetProjectError((Exception)projectError9);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
	}

	private static void CollectDirPaths(ConcurrentQueue<string> queue, string dirPath, SearchOption searchOption, IEnumerable<string> dirPathPatterns, IEnumerable<string> dirNamePatterns, bool ignoreCase, bool throwOnError)
	{
		IEnumerable<string> enumerable = null;
		try
		{
			enumerable = Directory.GetDirectories(dirPath, "*", SearchOption.TopDirectoryOnly);
		}
		catch (UnauthorizedAccessException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		if (enumerable != null)
		{
			foreach (string item in enumerable)
			{
				bool flag = false;
				bool flag2 = false;
				if (dirPathPatterns != null)
				{
					foreach (string dirPathPattern in dirPathPatterns)
					{
						if (!dirPathPattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (ignoreCase)
							{
								if (LikeOperator.LikeString(item.ToLower(), dirPathPattern.ToLower(), (CompareMethod)0))
								{
									flag = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(item, dirPathPattern, (CompareMethod)0))
							{
								flag = true;
								break;
							}
							continue;
						}
						flag = true;
						break;
					}
				}
				else
				{
					flag = true;
				}
				if (dirNamePatterns != null)
				{
					foreach (string dirNamePattern in dirNamePatterns)
					{
						if (!dirNamePattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (ignoreCase)
							{
								if (LikeOperator.LikeString(Path.GetFileName(item)!.ToLower(), dirNamePattern.ToLower(), (CompareMethod)0))
								{
									flag2 = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(Path.GetFileName(item), dirNamePattern, (CompareMethod)0))
							{
								flag2 = true;
								break;
							}
							continue;
						}
						flag2 = true;
						break;
					}
				}
				else
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					queue.Enqueue(item);
				}
			}
		}
		if (searchOption != SearchOption.AllDirectories)
		{
			return;
		}
		try
		{
			Task.WaitAll((from dir in new DirectoryInfo(dirPath).GetDirectories()
				select Task.Factory.StartNew(delegate
				{
					CollectDirPaths(queue, dir.FullName, SearchOption.AllDirectories, dirPathPatterns, dirNamePatterns, ignoreCase, throwOnError);
				})).ToArray());
		}
		catch (UnauthorizedAccessException projectError4)
		{
			ProjectData.SetProjectError((Exception)projectError4);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError5)
		{
			ProjectData.SetProjectError((Exception)projectError5);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			if (throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
	}
}
