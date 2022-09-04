using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace VI_Theme_Dll_By_xVenoxi;

[StandardModule]
public sealed class ThemeShare
{
	public delegate void AnimationDelegate(bool invalidate);

	private static int Frames;

	private static bool Invalidate;

	public static PrecisionTimer ThemeTimer = new PrecisionTimer();

	private const int FPS = 50;

	private const int Rate = 10;

	private static List<AnimationDelegate> Callbacks = new List<AnimationDelegate>();

	private static void HandleCallbacks(IntPtr state, bool reserve)
	{
		Invalidate = Frames >= 50;
		if (Invalidate)
		{
			Frames = 0;
		}
		checked
		{
			lock (Callbacks)
			{
				int num = Callbacks.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						Callbacks[num2](Invalidate);
						num2++;
						continue;
					}
					break;
				}
			}
			Frames += 10;
		}
	}

	private static void InvalidateThemeTimer()
	{
		if (Callbacks.Count == 0)
		{
			ThemeTimer.Delete();
		}
		else
		{
			ThemeTimer.Create(0u, 10u, HandleCallbacks);
		}
	}

	public static void AddAnimationCallback(AnimationDelegate callback)
	{
		lock (Callbacks)
		{
			if (!Callbacks.Contains(callback))
			{
				Callbacks.Add(callback);
				InvalidateThemeTimer();
			}
		}
	}

	public static void RemoveAnimationCallback(AnimationDelegate callback)
	{
		lock (Callbacks)
		{
			if (Callbacks.Contains(callback))
			{
				Callbacks.Remove(callback);
				InvalidateThemeTimer();
			}
		}
	}
}
