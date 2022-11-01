using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace com.poweriwb.PowerDesk;

public static class FunctionExtention
{
	public static void PerformClick(this Button ThisButton)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		if (((UIElement)ThisButton).get_IsEnabled())
		{
			((UIElement)ThisButton).RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
		}
	}

	public static T DeepCopy<T>(this T obj)
	{
		using MemoryStream memoryStream = new MemoryStream();
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.Serialize(memoryStream, obj);
		memoryStream.Position = 0L;
		return (T)binaryFormatter.Deserialize(memoryStream);
	}
}
