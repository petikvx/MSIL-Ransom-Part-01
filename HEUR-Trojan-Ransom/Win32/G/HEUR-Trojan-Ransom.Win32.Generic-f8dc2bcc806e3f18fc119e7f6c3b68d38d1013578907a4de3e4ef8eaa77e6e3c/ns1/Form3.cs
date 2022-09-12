using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[DesignerGenerated]
public class Form3 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	internal virtual WebBrowser WebBrowser1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			WebBrowserDocumentCompletedEventHandler val = new WebBrowserDocumentCompletedEventHandler(WebBrowser1_DocumentCompleted);
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.remove_DocumentCompleted(val);
			}
			_WebBrowser1 = value;
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.add_DocumentCompleted(val);
			}
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Form3()
	{
		((Form)this).add_Load((EventHandler)Form3_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
		WebBrowser1 = new WebBrowser();
		PictureBox1 = new PictureBox();
		Button1 = new Button();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		WebBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		WebBrowser webBrowser = WebBrowser1;
		Point location = new Point(2, 2);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		Size minimumSize = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(minimumSize);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		WebBrowser webBrowser3 = WebBrowser1;
		minimumSize = new Size(291, 258);
		((Control)webBrowser3).set_Size(minimumSize);
		((Control)WebBrowser1).set_TabIndex(8);
		WebBrowser1.set_Url(new Uri("http://teknoamiral.com/siteler/Burhan/burhanR/hit2/sayfaveri.php", UriKind.Absolute));
		((Control)PictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)PictureBox1).set_Enabled(false);
		PictureBox pictureBox = PictureBox1;
		location = new Point(-5, -21);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		minimumSize = new Size(298, 281);
		((Control)pictureBox2).set_Size(minimumSize);
		PictureBox1.set_TabIndex(9);
		PictureBox1.set_TabStop(false);
		((Control)Button1).set_Enabled(false);
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		Button button = Button1;
		location = new Point(95, 217);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		minimumSize = new Size(87, 23);
		((Control)button2).set_Size(minimumSize);
		((Control)Button1).set_TabIndex(10);
		((ButtonBase)Button1).set_Text("Tıkla Kazan");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		minimumSize = new Size(284, 262);
		((Form)this).set_ClientSize(minimumSize);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		minimumSize = new Size(290, 286);
		((Form)this).set_MaximumSize(minimumSize);
		((Form)this).set_MinimizeBox(false);
		minimumSize = new Size(290, 286);
		((Form)this).set_MinimumSize(minimumSize);
		((Control)this).set_Name("Form3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Sponsor");
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		WebBrowser1.Navigate(WebBrowser1.get_Document().GetElementById("1").get_InnerText());
	}

	private void Form3_Load(object sender, EventArgs e)
	{
	}
}
