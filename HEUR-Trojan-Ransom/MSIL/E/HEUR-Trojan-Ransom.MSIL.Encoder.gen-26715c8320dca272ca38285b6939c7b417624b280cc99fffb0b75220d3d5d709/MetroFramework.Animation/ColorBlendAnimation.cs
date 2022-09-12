using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MetroFramework.Animation;

public sealed class ColorBlendAnimation : AnimationBase
{
	private double percent = 1.0;

	public void Start(Control control, string property, Color targetColor, int duration)
	{
		if (duration == 0)
		{
			duration = 1;
		}
		Start(control, transitionType, 2 * duration, delegate
		{
			Color propertyValue2 = GetPropertyValue(property, control);
			Color color = DoColorBlend(propertyValue2, targetColor, 0.1 * (percent / 2.0));
			PropertyInfo property2 = ((object)control).GetType().GetProperty(property);
			MethodInfo setMethod = property2.GetSetMethod(nonPublic: true);
			setMethod.Invoke(control, new object[1] { color });
		}, delegate
		{
			Color propertyValue = GetPropertyValue(property, control);
			return (propertyValue.A.Equals(targetColor.A) && propertyValue.R.Equals(targetColor.R) && propertyValue.G.Equals(targetColor.G) && propertyValue.B.Equals(targetColor.B)) ? true : false;
		});
	}

	private Color DoColorBlend(Color startColor, Color targetColor, double ratio)
	{
		percent += 0.2;
		int alpha = (int)Math.Round((double)(int)startColor.A * (1.0 - ratio) + (double)(int)targetColor.A * ratio);
		int red = (int)Math.Round((double)(int)startColor.R * (1.0 - ratio) + (double)(int)targetColor.R * ratio);
		int green = (int)Math.Round((double)(int)startColor.G * (1.0 - ratio) + (double)(int)targetColor.G * ratio);
		int blue = (int)Math.Round((double)(int)startColor.B * (1.0 - ratio) + (double)(int)targetColor.B * ratio);
		return Color.FromArgb(alpha, red, green, blue);
	}

	private Color GetPropertyValue(string pName, Control control)
	{
		Type type = ((object)control).GetType();
		Binder binder = null;
		object[] args = null;
		object obj = type.InvokeMember(pName, BindingFlags.GetProperty, binder, control, args);
		return (Color)obj;
	}
}
