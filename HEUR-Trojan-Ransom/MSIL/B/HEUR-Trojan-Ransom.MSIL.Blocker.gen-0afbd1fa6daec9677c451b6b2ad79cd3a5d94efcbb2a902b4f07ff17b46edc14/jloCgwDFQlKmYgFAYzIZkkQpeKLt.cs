using System;
using System.ComponentModel;
using System.IO;
using System.Media;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Threading;

public class jloCgwDFQlKmYgFAYzIZkkQpeKLt : Component, ISerializable
{
	private sealed class XYZWJfEJQZYSZweLpwttyxsLNxtM
	{
		private static volatile CodeAccessPermission m_ohKBQGsjtXQkRqZQFrieFHuuPFCM;

		internal static CodeAccessPermission ohKBQGsjtXQkRqZQFrieFHuuPFCM
		{
			get
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				if (jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.m_ohKBQGsjtXQkRqZQFrieFHuuPFCM == null)
				{
					jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.m_ohKBQGsjtXQkRqZQFrieFHuuPFCM = (CodeAccessPermission)new UIPermission((UIPermissionWindow)1);
				}
				return jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.m_ohKBQGsjtXQkRqZQFrieFHuuPFCM;
			}
		}

		private XYZWJfEJQZYSZweLpwttyxsLNxtM()
		{
		}
	}

	private sealed class XYZWJfEJQZYSZweLpwttyxsLNxtM
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal sealed class WhQfsUiOsWFfdxhMINTcQmIpcFnG
		{
			internal int ohKBQGsjtXQkRqZQFrieFHuuPFCM;

			internal int ohKBQGsjtXQkRqZQFrieFHuuPFCM;

			internal int ohKBQGsjtXQkRqZQFrieFHuuPFCM;

			internal int ohKBQGsjtXQkRqZQFrieFHuuPFCM;

			internal int ohKBQGsjtXQkRqZQFrieFHuuPFCM;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		internal sealed class WhQfsUiOsWFfdxhMINTcQmIpcFnG
		{
			internal short ohKBQGsjtXQkRqZQFrieFHuuPFCM;

			internal short ohKBQGsjtXQkRqZQFrieFHuuPFCM;

			internal int ohKBQGsjtXQkRqZQFrieFHuuPFCM;

			internal int ohKBQGsjtXQkRqZQFrieFHuuPFCM;

			internal short ohKBQGsjtXQkRqZQFrieFHuuPFCM;

			internal short ohKBQGsjtXQkRqZQFrieFHuuPFCM;

			internal short ohKBQGsjtXQkRqZQFrieFHuuPFCM;
		}

		internal const int ohKBQGsjtXQkRqZQFrieFHuuPFCM = 1;

		internal const int ohKBQGsjtXQkRqZQFrieFHuuPFCM = 2;

		internal const int ohKBQGsjtXQkRqZQFrieFHuuPFCM = 3;

		internal const int ohKBQGsjtXQkRqZQFrieFHuuPFCM = 0;

		internal const int ohKBQGsjtXQkRqZQFrieFHuuPFCM = 65536;

		internal const int ohKBQGsjtXQkRqZQFrieFHuuPFCM = 32;

		internal const int ohKBQGsjtXQkRqZQFrieFHuuPFCM = 0;

		internal const int ohKBQGsjtXQkRqZQFrieFHuuPFCM = 1;

		internal const int ohKBQGsjtXQkRqZQFrieFHuuPFCM = 2;

		internal const int ohKBQGsjtXQkRqZQFrieFHuuPFCM = 4;

		internal const int XnutSWmVhOrZFXsTkqCFWNIxTlmE = 8;

		internal const int XnutSWmVhOrZFXsTkqCFWNIxTlmE = 64;

		internal const int XnutSWmVhOrZFXsTkqCFWNIxTlmE = 131072;

		internal const int XnutSWmVhOrZFXsTkqCFWNIxTlmE = 16;

		private XYZWJfEJQZYSZweLpwttyxsLNxtM()
		{
		}
	}

	private sealed class XYZWJfEJQZYSZweLpwttyxsLNxtM
	{
		private XYZWJfEJQZYSZweLpwttyxsLNxtM()
		{
		}

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern bool PlaySound([MarshalAs(UnmanagedType.LPWStr)] string string_0, IntPtr intptr_0, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto, EntryPoint = "PlaySound")]
		internal static extern bool PlaySound_1(byte[] byte_0, IntPtr intptr_0, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern IntPtr mmioOpen(string string_0, IntPtr intptr_0, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioAscend(IntPtr intptr_0, jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.WhQfsUiOsWFfdxhMINTcQmIpcFnG whQfsUiOsWFfdxhMINTcQmIpcFnG_0, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioDescend(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStruct)] jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.WhQfsUiOsWFfdxhMINTcQmIpcFnG whQfsUiOsWFfdxhMINTcQmIpcFnG_0, [MarshalAs(UnmanagedType.LPStruct)] jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.WhQfsUiOsWFfdxhMINTcQmIpcFnG whQfsUiOsWFfdxhMINTcQmIpcFnG_1, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioRead(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_0);

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		internal static extern int mmioClose(IntPtr intptr_0, int int_0);
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class NOdRgiERokdBlrgzydgKzWPxJMKo
	{
		public static readonly NOdRgiERokdBlrgzydgKzWPxJMKo _003C_003E9 = new NOdRgiERokdBlrgzydgKzWPxJMKo();

		public static ResolveEventHandler _003C_003E9__48_0;

		internal Assembly method_0(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			if (egsZAGIPSMLBiOJMXzFgaJVubQtD.smethod_0(object_0, resolveEventArgs_0, out var assembly_))
			{
				return assembly_;
			}
			return null;
		}
	}

	private static readonly object GdcWbSVqTtJDTIpPhJHDvQDzLcJM = new object();

	private static readonly object vTzaRVJxeTOZNeFXroioajrGGZciB = new object();

	private static readonly object yUXwMnXgIbDORWfEPwKWefWYuiLs = new object();

	private string luhAOPgAyNCUoKrGYSLXOAQosORt = string.Empty;

	private int QVHTvOwwgZJZCvQxNXUnKYXxWByd = 10000;

	private ManualResetEvent bOhIjutCHjQTnWhlJgQOBXGfBtPLA = new ManualResetEvent(initialState: true);

	private const int bHzVBZknhaHmcvqugglDyQMyrvMK = 1024;

	private const int CPsjiGVAfGFBGHCzCRoMyBHVNUgG = 10000;

	private Uri nfvkTfmkLZxJLikXQltwDFFEYdrs;

	private object ttPVQJRbiuABFZYqDKeKKOAoulXv;

	private Thread KluOQScjrPuGhtbWqyxHEJDurYti;

	private int VutwFPjbfoiaYfHMWpCiaOwOwPJjA;

	private bool QwhAzaMkhqzoNJUnwhExynCmaxYj;

	private byte[] TkWVJDlRALwimfVYifbMOLnBhzsw;

	private AsyncOperation YkZJULkJihiGtXxLgdRcRPlceQEB;

	private readonly SendOrPostCallback RANhLOsBRoGRvZUBChhcbbqpfwKi;

	internal Stream ohKBQGsjtXQkRqZQFrieFHuuPFCM;

	internal bool ohKBQGsjtXQkRqZQFrieFHuuPFCM;

	internal Exception ohKBQGsjtXQkRqZQFrieFHuuPFCM;

	public int VxZZHltSOFVhXEIehSUFJMFVrQHJ
	{
		get
		{
			return QVHTvOwwgZJZCvQxNXUnKYXxWByd;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("");
			}
			QVHTvOwwgZJZCvQxNXUnKYXxWByd = value;
		}
	}

	public string jDcuGnxUwMiwjpKMNIxjCXBPrgWV
	{
		get
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			if (nfvkTfmkLZxJLikXQltwDFFEYdrs != null && nfvkTfmkLZxJLikXQltwDFFEYdrs.IsFile)
			{
				FileIOPermission val = new FileIOPermission(PermissionState.None);
				val.set_AllFiles((FileIOPermissionAccess)8);
				((CodeAccessPermission)val).Demand();
			}
			return luhAOPgAyNCUoKrGYSLXOAQosORt;
		}
		set
		{
			if (value == null)
			{
				value = string.Empty;
			}
			if (!luhAOPgAyNCUoKrGYSLXOAQosORt.Equals(value))
			{
				method_10(value);
				vmethod_1(EventArgs.Empty);
			}
		}
	}

	public Stream YbsEDFafagONIWWEjzARqKGFajnzA
	{
		get
		{
			if (nfvkTfmkLZxJLikXQltwDFFEYdrs != null)
			{
				return null;
			}
			return this.ohKBQGsjtXQkRqZQFrieFHuuPFCM;
		}
		set
		{
			if (this.ohKBQGsjtXQkRqZQFrieFHuuPFCM != value)
			{
				method_11(value);
				vmethod_2(EventArgs.Empty);
			}
		}
	}

	public bool exxVajnBTKEAvgDhHBzYDqSlvpIqA => this.ohKBQGsjtXQkRqZQFrieFHuuPFCM;

	public object jCZqDbZCyvzyVNjSUNDUeHtPtDTv
	{
		get
		{
			return ttPVQJRbiuABFZYqDKeKKOAoulXv;
		}
		set
		{
			ttPVQJRbiuABFZYqDKeKKOAoulXv = value;
		}
	}

	public event AsyncCompletedEventHandler ylFRTgeFPNQCAfNbqjFDbuKAemho
	{
		add
		{
			base.Events.AddHandler(GdcWbSVqTtJDTIpPhJHDvQDzLcJM, value);
		}
		remove
		{
			base.Events.RemoveHandler(GdcWbSVqTtJDTIpPhJHDvQDzLcJM, value);
		}
	}

	public event EventHandler zguEJOXdHVujInIMPHqVAydvGQAiA
	{
		add
		{
			base.Events.AddHandler(vTzaRVJxeTOZNeFXroioajrGGZciB, value);
		}
		remove
		{
			base.Events.RemoveHandler(vTzaRVJxeTOZNeFXroioajrGGZciB, value);
		}
	}

	public event EventHandler LgTXvDeXkamwizndlGZjlwgAxDzh
	{
		add
		{
			base.Events.AddHandler(yUXwMnXgIbDORWfEPwKWefWYuiLs, value);
		}
		remove
		{
			base.Events.RemoveHandler(yUXwMnXgIbDORWfEPwKWefWYuiLs, value);
		}
	}

	public jloCgwDFQlKmYgFAYzIZkkQpeKLt()
	{
		RANhLOsBRoGRvZUBChhcbbqpfwKi = method_1;
	}

	public jloCgwDFQlKmYgFAYzIZkkQpeKLt(string string_0)
		: this()
	{
		if (string_0 == null)
		{
			string_0 = string.Empty;
		}
		method_10(string_0);
	}

	public jloCgwDFQlKmYgFAYzIZkkQpeKLt(Stream stream_0)
		: this()
	{
		Stream stream = (this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = stream_0);
	}

	protected jloCgwDFQlKmYgFAYzIZkkQpeKLt(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		SerializationInfoEnumerator enumerator = serializationInfo_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SerializationEntry current = enumerator.Current;
			switch (current.Name)
			{
			case "LoadTimeout":
				VxZZHltSOFVhXEIehSUFJMFVrQHJ = (int)current.Value;
				break;
			case "Stream":
			{
				Stream stream = (this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = (Stream)current.Value);
				if (this.ohKBQGsjtXQkRqZQFrieFHuuPFCM.CanSeek)
				{
					this.ohKBQGsjtXQkRqZQFrieFHuuPFCM.Seek(0L, SeekOrigin.Begin);
				}
				break;
			}
			case "SoundLocation":
				method_10((string)current.Value);
				break;
			}
		}
	}

	public void method_0()
	{
		if (nfvkTfmkLZxJLikXQltwDFFEYdrs != null && nfvkTfmkLZxJLikXQltwDFFEYdrs.IsFile)
		{
			this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = true;
			if (!new FileInfo(nfvkTfmkLZxJLikXQltwDFFEYdrs.LocalPath).Exists)
			{
				throw new FileNotFoundException("");
			}
			vmethod_0(new AsyncCompletedEventArgs(null, cancelled: false, null));
		}
		else if (KluOQScjrPuGhtbWqyxHEJDurYti == null || KluOQScjrPuGhtbWqyxHEJDurYti.ThreadState != 0)
		{
			this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = false;
			TkWVJDlRALwimfVYifbMOLnBhzsw = null;
			VutwFPjbfoiaYfHMWpCiaOwOwPJjA = 0;
			YkZJULkJihiGtXxLgdRcRPlceQEB = AsyncOperationManager.CreateOperation(null);
			method_6(bool_0: false);
		}
	}

	private void method_1(object object_0)
	{
		vmethod_0((AsyncCompletedEventArgs)object_0);
	}

	private void method_2()
	{
		VutwFPjbfoiaYfHMWpCiaOwOwPJjA = 0;
		TkWVJDlRALwimfVYifbMOLnBhzsw = null;
		this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = false;
		Exception ex = (ohKBQGsjtXQkRqZQFrieFHuuPFCM = null);
		QwhAzaMkhqzoNJUnwhExynCmaxYj = false;
		KluOQScjrPuGhtbWqyxHEJDurYti = null;
		bOhIjutCHjQTnWhlJgQOBXGfBtPLA.Set();
	}

	public void method_3()
	{
		if (nfvkTfmkLZxJLikXQltwDFFEYdrs != null && nfvkTfmkLZxJLikXQltwDFFEYdrs.IsFile)
		{
			if (!new FileInfo(nfvkTfmkLZxJLikXQltwDFFEYdrs.LocalPath).Exists)
			{
				throw new FileNotFoundException("");
			}
			this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = true;
			vmethod_0(new AsyncCompletedEventArgs(null, cancelled: false, null));
		}
		else
		{
			method_5();
		}
	}

	private void method_4(int int_0)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(luhAOPgAyNCUoKrGYSLXOAQosORt) && this.ohKBQGsjtXQkRqZQFrieFHuuPFCM == null)
		{
			SystemSounds.get_Beep().Play();
			return;
		}
		if (nfvkTfmkLZxJLikXQltwDFFEYdrs != null && nfvkTfmkLZxJLikXQltwDFFEYdrs.IsFile)
		{
			string localPath = nfvkTfmkLZxJLikXQltwDFFEYdrs.LocalPath;
			((CodeAccessPermission)new FileIOPermission((FileIOPermissionAccess)1, localPath)).Demand();
			this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = true;
			jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.ohKBQGsjtXQkRqZQFrieFHuuPFCM.Demand();
			try
			{
				method_14(localPath);
				jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.PlaySound(localPath, IntPtr.Zero, 2 | int_0);
				return;
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
		}
		method_5();
		smethod_2(TkWVJDlRALwimfVYifbMOLnBhzsw);
		jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.ohKBQGsjtXQkRqZQFrieFHuuPFCM.Demand();
		try
		{
			jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.PlaySound_1(TkWVJDlRALwimfVYifbMOLnBhzsw, IntPtr.Zero, 6 | int_0);
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}

	private void method_5()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!bOhIjutCHjQTnWhlJgQOBXGfBtPLA.WaitOne(VxZZHltSOFVhXEIehSUFJMFVrQHJ, exitContext: false))
		{
			if (KluOQScjrPuGhtbWqyxHEJDurYti != null)
			{
				KluOQScjrPuGhtbWqyxHEJDurYti.Abort();
			}
			method_2();
			throw new TimeoutException("");
		}
		if (TkWVJDlRALwimfVYifbMOLnBhzsw != null)
		{
			return;
		}
		if (nfvkTfmkLZxJLikXQltwDFFEYdrs != null && !nfvkTfmkLZxJLikXQltwDFFEYdrs.IsFile && this.ohKBQGsjtXQkRqZQFrieFHuuPFCM == null)
		{
			((CodeAccessPermission)new WebPermission((NetworkAccess)64, nfvkTfmkLZxJLikXQltwDFFEYdrs.AbsolutePath)).Demand();
			WebRequest webRequest = WebRequest.Create(nfvkTfmkLZxJLikXQltwDFFEYdrs);
			webRequest.Timeout = VxZZHltSOFVhXEIehSUFJMFVrQHJ;
			Stream stream = (this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = webRequest.GetResponse().GetResponseStream());
		}
		if (this.ohKBQGsjtXQkRqZQFrieFHuuPFCM.CanSeek)
		{
			method_6(bool_0: true);
		}
		else
		{
			QwhAzaMkhqzoNJUnwhExynCmaxYj = true;
			method_6(bool_0: false);
			if (!bOhIjutCHjQTnWhlJgQOBXGfBtPLA.WaitOne(VxZZHltSOFVhXEIehSUFJMFVrQHJ, exitContext: false))
			{
				if (KluOQScjrPuGhtbWqyxHEJDurYti != null)
				{
					KluOQScjrPuGhtbWqyxHEJDurYti.Abort();
				}
				method_2();
				throw new TimeoutException("");
			}
			QwhAzaMkhqzoNJUnwhExynCmaxYj = false;
			if (ohKBQGsjtXQkRqZQFrieFHuuPFCM != null)
			{
				throw ohKBQGsjtXQkRqZQFrieFHuuPFCM;
			}
		}
		KluOQScjrPuGhtbWqyxHEJDurYti = null;
	}

	private void method_6(bool bool_0)
	{
		if (bool_0 && this.ohKBQGsjtXQkRqZQFrieFHuuPFCM.CanSeek)
		{
			int num = (int)this.ohKBQGsjtXQkRqZQFrieFHuuPFCM.Length;
			VutwFPjbfoiaYfHMWpCiaOwOwPJjA = 0;
			TkWVJDlRALwimfVYifbMOLnBhzsw = new byte[num];
			this.ohKBQGsjtXQkRqZQFrieFHuuPFCM.Read(TkWVJDlRALwimfVYifbMOLnBhzsw, 0, num);
			this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = true;
			vmethod_0(new AsyncCompletedEventArgs(null, cancelled: false, null));
		}
		else
		{
			bOhIjutCHjQTnWhlJgQOBXGfBtPLA.Reset();
			KluOQScjrPuGhtbWqyxHEJDurYti = new Thread(method_13);
			KluOQScjrPuGhtbWqyxHEJDurYti.Start();
		}
	}

	public void method_7()
	{
		method_4(1);
	}

	public void method_8()
	{
		method_4(0);
	}

	public void method_9()
	{
		method_4(9);
	}

	private static Uri smethod_0(string string_0)
	{
		Uri uri = null;
		try
		{
			uri = new Uri(string_0);
		}
		catch (UriFormatException)
		{
		}
		if (uri == null)
		{
			try
			{
				uri = new Uri(Path.GetFullPath(string_0));
				return uri;
			}
			catch (UriFormatException)
			{
				return uri;
			}
		}
		return uri;
	}

	internal static void smethod_1()
	{
		AppDomain.CurrentDomain.AssemblyResolve += (object object_0, ResolveEventArgs resolveEventArgs_0) => egsZAGIPSMLBiOJMXzFgaJVubQtD.smethod_0(object_0, resolveEventArgs_0, out var assembly_) ? assembly_ : null;
	}

	private void method_10(string string_0)
	{
		if (KluOQScjrPuGhtbWqyxHEJDurYti != null)
		{
			KluOQScjrPuGhtbWqyxHEJDurYti.Abort();
			method_2();
		}
		nfvkTfmkLZxJLikXQltwDFFEYdrs = smethod_0(string_0);
		luhAOPgAyNCUoKrGYSLXOAQosORt = string_0;
		Stream stream = (this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = null);
		if (nfvkTfmkLZxJLikXQltwDFFEYdrs == null)
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				throw new UriFormatException("");
			}
		}
		else if (!nfvkTfmkLZxJLikXQltwDFFEYdrs.IsFile)
		{
			TkWVJDlRALwimfVYifbMOLnBhzsw = null;
			VutwFPjbfoiaYfHMWpCiaOwOwPJjA = 0;
			this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = false;
		}
	}

	private void method_11(Stream stream_0)
	{
		if (KluOQScjrPuGhtbWqyxHEJDurYti != null)
		{
			KluOQScjrPuGhtbWqyxHEJDurYti.Abort();
			method_2();
		}
		Stream stream = (this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = stream_0);
		luhAOPgAyNCUoKrGYSLXOAQosORt = string.Empty;
		TkWVJDlRALwimfVYifbMOLnBhzsw = null;
		VutwFPjbfoiaYfHMWpCiaOwOwPJjA = 0;
		this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = false;
		if (stream_0 != null)
		{
			nfvkTfmkLZxJLikXQltwDFFEYdrs = null;
		}
	}

	public void method_12()
	{
		jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.ohKBQGsjtXQkRqZQFrieFHuuPFCM.Demand();
		jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.PlaySound_1(null, IntPtr.Zero, 64);
	}

	protected virtual void vmethod_0(AsyncCompletedEventArgs asyncCompletedEventArgs_0)
	{
		((AsyncCompletedEventHandler)base.Events[GdcWbSVqTtJDTIpPhJHDvQDzLcJM])?.Invoke(this, asyncCompletedEventArgs_0);
	}

	protected virtual void vmethod_1(EventArgs eventArgs_0)
	{
		((EventHandler)base.Events[vTzaRVJxeTOZNeFXroioajrGGZciB])?.Invoke(this, eventArgs_0);
	}

	protected virtual void vmethod_2(EventArgs eventArgs_0)
	{
		((EventHandler)base.Events[yUXwMnXgIbDORWfEPwKWefWYuiLs])?.Invoke(this, eventArgs_0);
	}

	private void method_13()
	{
		try
		{
			if (nfvkTfmkLZxJLikXQltwDFFEYdrs != null && !nfvkTfmkLZxJLikXQltwDFFEYdrs.IsFile && this.ohKBQGsjtXQkRqZQFrieFHuuPFCM == null)
			{
				Stream stream = (this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = WebRequest.Create(nfvkTfmkLZxJLikXQltwDFFEYdrs).GetResponse().GetResponseStream());
			}
			TkWVJDlRALwimfVYifbMOLnBhzsw = new byte[1024];
			int num = this.ohKBQGsjtXQkRqZQFrieFHuuPFCM.Read(TkWVJDlRALwimfVYifbMOLnBhzsw, VutwFPjbfoiaYfHMWpCiaOwOwPJjA, 1024);
			int num2 = num;
			while (num > 0)
			{
				VutwFPjbfoiaYfHMWpCiaOwOwPJjA += num;
				if (TkWVJDlRALwimfVYifbMOLnBhzsw.Length < VutwFPjbfoiaYfHMWpCiaOwOwPJjA + 1024)
				{
					byte[] array = new byte[TkWVJDlRALwimfVYifbMOLnBhzsw.Length * 2];
					Array.Copy(TkWVJDlRALwimfVYifbMOLnBhzsw, array, TkWVJDlRALwimfVYifbMOLnBhzsw.Length);
					TkWVJDlRALwimfVYifbMOLnBhzsw = array;
				}
				num = this.ohKBQGsjtXQkRqZQFrieFHuuPFCM.Read(TkWVJDlRALwimfVYifbMOLnBhzsw, VutwFPjbfoiaYfHMWpCiaOwOwPJjA, 1024);
				num2 += num;
			}
			Exception ex = (ohKBQGsjtXQkRqZQFrieFHuuPFCM = null);
		}
		catch (Exception ex2)
		{
			Exception ex3 = (ohKBQGsjtXQkRqZQFrieFHuuPFCM = ex2);
		}
		if (!QwhAzaMkhqzoNJUnwhExynCmaxYj)
		{
			YkZJULkJihiGtXxLgdRcRPlceQEB.PostOperationCompleted(RANhLOsBRoGRvZUBChhcbbqpfwKi, new AsyncCompletedEventArgs(ohKBQGsjtXQkRqZQFrieFHuuPFCM, cancelled: false, null));
		}
		this.ohKBQGsjtXQkRqZQFrieFHuuPFCM = true;
		bOhIjutCHjQTnWhlJgQOBXGfBtPLA.Set();
	}

	private unsafe void method_14(string string_0)
	{
		jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.WhQfsUiOsWFfdxhMINTcQmIpcFnG whQfsUiOsWFfdxhMINTcQmIpcFnG = new jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.WhQfsUiOsWFfdxhMINTcQmIpcFnG();
		jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.WhQfsUiOsWFfdxhMINTcQmIpcFnG whQfsUiOsWFfdxhMINTcQmIpcFnG2 = new jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.WhQfsUiOsWFfdxhMINTcQmIpcFnG();
		jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.WhQfsUiOsWFfdxhMINTcQmIpcFnG whQfsUiOsWFfdxhMINTcQmIpcFnG3 = null;
		IntPtr intPtr = jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.mmioOpen(string_0, IntPtr.Zero, 65536);
		try
		{
			whQfsUiOsWFfdxhMINTcQmIpcFnG.ohKBQGsjtXQkRqZQFrieFHuuPFCM = smethod_4('W', 'A', 'V', 'E');
			while (true)
			{
				if (jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.mmioDescend(intPtr, whQfsUiOsWFfdxhMINTcQmIpcFnG2, whQfsUiOsWFfdxhMINTcQmIpcFnG, 0) == 0)
				{
					if (whQfsUiOsWFfdxhMINTcQmIpcFnG2.ohKBQGsjtXQkRqZQFrieFHuuPFCM + whQfsUiOsWFfdxhMINTcQmIpcFnG2.ohKBQGsjtXQkRqZQFrieFHuuPFCM <= whQfsUiOsWFfdxhMINTcQmIpcFnG.ohKBQGsjtXQkRqZQFrieFHuuPFCM + whQfsUiOsWFfdxhMINTcQmIpcFnG.ohKBQGsjtXQkRqZQFrieFHuuPFCM)
					{
						if (whQfsUiOsWFfdxhMINTcQmIpcFnG2.ohKBQGsjtXQkRqZQFrieFHuuPFCM == smethod_4('f', 'm', 't', ' ') && whQfsUiOsWFfdxhMINTcQmIpcFnG3 == null)
						{
							int num = whQfsUiOsWFfdxhMINTcQmIpcFnG2.ohKBQGsjtXQkRqZQFrieFHuuPFCM;
							if (num < Marshal.SizeOf(typeof(jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.WhQfsUiOsWFfdxhMINTcQmIpcFnG)))
							{
								num = Marshal.SizeOf(typeof(jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.WhQfsUiOsWFfdxhMINTcQmIpcFnG));
							}
							whQfsUiOsWFfdxhMINTcQmIpcFnG3 = new jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.WhQfsUiOsWFfdxhMINTcQmIpcFnG();
							byte[] array = new byte[num];
							try
							{
								fixed (byte* ptr = array)
								{
									Marshal.PtrToStructure((IntPtr)ptr, (object)whQfsUiOsWFfdxhMINTcQmIpcFnG3);
								}
							}
							finally
							{
							}
						}
						jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.mmioAscend(intPtr, whQfsUiOsWFfdxhMINTcQmIpcFnG2, 0);
						continue;
					}
					throw new InvalidOperationException("");
				}
				if (whQfsUiOsWFfdxhMINTcQmIpcFnG3 == null)
				{
					throw new InvalidOperationException("");
				}
				if (whQfsUiOsWFfdxhMINTcQmIpcFnG3.ohKBQGsjtXQkRqZQFrieFHuuPFCM != 1 && whQfsUiOsWFfdxhMINTcQmIpcFnG3.ohKBQGsjtXQkRqZQFrieFHuuPFCM != 2 && whQfsUiOsWFfdxhMINTcQmIpcFnG3.ohKBQGsjtXQkRqZQFrieFHuuPFCM != 3)
				{
					throw new InvalidOperationException("");
				}
				break;
			}
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				jloCgwDFQlKmYgFAYzIZkkQpeKLt.XYZWJfEJQZYSZweLpwttyxsLNxtM.mmioClose(intPtr, 0);
			}
		}
	}

	private static void smethod_2(byte[] byte_0)
	{
		short num = -1;
		bool flag = false;
		int num2 = 12;
		int num3 = byte_0.Length;
		while (!flag && num2 < num3 - 8)
		{
			if (byte_0[num2] == 102 && byte_0[num2 + 1] == 109 && byte_0[num2 + 2] == 116 && byte_0[num2 + 3] == 32)
			{
				flag = true;
				int num4 = DMRKVPmVQCOLNJagOiYpJEo5VxfOeburP65D9kWz8vVrD41993jUIteMrczD5dN7MudeZZNIeH1wZntQX3RYpLq0lyf47X0UZ4TeRGGBgbCw9789a9IefQNIizWMGEPfsT6N(byte_0[num2 + 7], byte_0[num2 + 6], byte_0[num2 + 5], byte_0[num2 + 4]);
				if (num4 != 16)
				{
					int num5 = 18;
					if (num3 < num2 + 8 + 18 - 1)
					{
						throw new InvalidOperationException("");
					}
					if (smethod_3(byte_0[num2 + 8 + num5 - 1], byte_0[num2 + 8 + num5 - 2]) + num5 != num4)
					{
						throw new InvalidOperationException("");
					}
				}
				if (num3 < num2 + 9)
				{
					throw new InvalidOperationException("");
				}
				num = smethod_3(byte_0[num2 + 9], byte_0[num2 + 8]);
				num2 += num4 + 8;
			}
			else
			{
				num2 += 8 + DMRKVPmVQCOLNJagOiYpJEo5VxfOeburP65D9kWz8vVrD41993jUIteMrczD5dN7MudeZZNIeH1wZntQX3RYpLq0lyf47X0UZ4TeRGGBgbCw9789a9IefQNIizWMGEPfsT6N(byte_0[num2 + 7], byte_0[num2 + 6], byte_0[num2 + 5], byte_0[num2 + 4]);
			}
		}
		if (!flag)
		{
			throw new InvalidOperationException("");
		}
		if (num != 1 && num != 2 && num != 3)
		{
			throw new InvalidOperationException("");
		}
	}

	private static short smethod_3(byte byte_0, byte byte_1)
	{
		return (short)(byte_1 | (byte_0 << 8));
	}

	private static int DMRKVPmVQCOLNJagOiYpJEo5VxfOeburP65D9kWz8vVrD41993jUIteMrczD5dN7MudeZZNIeH1wZntQX3RYpLq0lyf47X0UZ4TeRGGBgbCw9789a9IefQNIizWMGEPfsT6N(byte byte_0, byte byte_1, byte byte_2, byte byte_3)
	{
		return smethod_4((char)byte_3, (char)byte_2, (char)byte_1, (char)byte_0);
	}

	private static int smethod_4(char char_0, char char_1, char char_2, char char_3)
	{
		return 0 | char_0 | (int)((uint)char_1 << 8) | (int)((uint)char_2 << 16) | (int)((uint)char_3 << 24);
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (!string.IsNullOrEmpty(luhAOPgAyNCUoKrGYSLXOAQosORt))
		{
			info.AddValue("SoundLocation", luhAOPgAyNCUoKrGYSLXOAQosORt);
		}
		if (this.ohKBQGsjtXQkRqZQFrieFHuuPFCM != null)
		{
			info.AddValue("Stream", this.ohKBQGsjtXQkRqZQFrieFHuuPFCM);
		}
		info.AddValue("LoadTimeout", QVHTvOwwgZJZCvQxNXUnKYXxWByd);
	}
}
