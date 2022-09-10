using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.Zip;

namespace MakeExeZip;

internal class Program
{
	public static void UpdateResources(string fileNameStub, string fileToAttach, string outputPath)
	{
		bool flag = false;
		IntPtr intPtr = IntPtr.Zero;
		File.Copy(fileNameStub, outputPath);
		try
		{
			intPtr = NativeMethods.BeginUpdateResource(outputPath, deleteExistingResource: false);
			if (intPtr != IntPtr.Zero)
			{
				int num = 0;
				byte[] array = null;
				using (FileStream fileStream = File.OpenRead(fileToAttach))
				{
					num = (int)fileStream.Length;
					array = new byte[num];
					fileStream.Read(array, 0, num);
				}
				NativeMethods.UpdateResource(intPtr, 42, "ZIPDATA", 0, array, num);
			}
		}
		catch
		{
			NativeMethods.EndUpdateResource(intPtr, fDiscard: true);
			flag = true;
			throw;
		}
		finally
		{
			if (!flag)
			{
				NativeMethods.EndUpdateResource(intPtr, fDiscard: false);
			}
		}
	}

	private static string Banner()
	{
		string banner = Resource1.banner;
		banner = banner.Replace("\\n", "\n");
		banner = banner.Replace("\\r", "\r");
		return banner.Replace("\\t", "\t");
	}

	private static string MassageUsage()
	{
		string usage = Resource1.usage;
		usage = usage.Replace("\\n", "\n");
		usage = usage.Replace("\\r", "\r");
		return usage.Replace("\\t", "\t");
	}

	private static int Main(string[] args)
	{
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		try
		{
			Console.WriteLine(Banner());
			bool flag = false;
			string text = "";
			string text2 = "";
			if (args.Length == 0)
			{
				Console.WriteLine(MassageUsage());
				return 1;
			}
			foreach (string text3 in args)
			{
				if (text3.CompareTo("-?") != 0)
				{
					if (text3.ToLower().StartsWith("-zipfile:"))
					{
						text = text3.Substring("-zipfile:".Length);
						continue;
					}
					if (text3.ToLower().StartsWith("-output:"))
					{
						text2 = text3.Substring("-output:".Length);
						continue;
					}
					if (text3.ToLower().StartsWith("-overwrite"))
					{
						flag = true;
						continue;
					}
					Console.WriteLine(string.Format(Resource1.unknownArg, text3));
					return 1;
				}
				Console.WriteLine(MassageUsage());
				return 0;
			}
			if (string.IsNullOrEmpty(text))
			{
				Console.WriteLine(Resource1.noZipFileSpecified);
				return 1;
			}
			if (!File.Exists(text))
			{
				Console.WriteLine(string.Format(Resource1.inputFileNotFound, text));
				return 1;
			}
			if (string.IsNullOrEmpty(text2))
			{
				string text4 = Path.ChangeExtension(text, ".exe");
				text2 = text4;
			}
			if (File.Exists(text2))
			{
				if (!flag)
				{
					Console.WriteLine(Resource1.noOutputPath);
					return 1;
				}
				File.Delete(text2);
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string location = executingAssembly.Location;
			location = Path.GetDirectoryName(location);
			location = Path.Combine(location, "ZipExeStub.exe");
			if (!File.Exists(location))
			{
				Console.WriteLine(Resource1.couldNotFindStubExe);
				return 1;
			}
			try
			{
				new ZipFileDecompressor(text);
			}
			catch (ZipException val)
			{
				ZipException val2 = val;
				Console.WriteLine(string.Format(Resource1.errorReadingZipFile, text, ((Exception)(object)val2).Message));
				return 1;
			}
			UpdateResources(location, text, text2);
			Console.WriteLine(Resource1.success);
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(Resource1.failed, ex.Message));
			return 1;
		}
		return 0;
	}
}
