using System;
using Gecko.Interop;

namespace Gecko.Images;

public sealed class ImgContainer
{
	public enum Animation : ushort
	{
		Normal,
		DontAnimate,
		LoopOnce
	}

	public sealed class Locker : IDisposable
	{
		private ImgContainer _container;

		internal Locker(ImgContainer container)
		{
			_container = container;
			_container.LockImage();
		}

		~Locker()
		{
			Free();
		}

		public void Dispose()
		{
			Free();
			GC.SuppressFinalize(this);
		}

		private void Free()
		{
			if (_container != null)
			{
				_container.UnlockImage();
				_container = null;
			}
		}
	}

	private ComPtr<imgIContainer> _container;

	public bool Animated => _container.Instance.GetAnimatedAttribute();

	public Animation AnimationMode
	{
		get
		{
			return (Animation)_container.Instance.GetAnimationModeAttribute();
		}
		set
		{
			_container.Instance.SetAnimationModeAttribute((ushort)value);
		}
	}

	public int Height => _container.Instance.GetHeightAttribute();

	public uint Type => _container.Instance.GetTypeAttribute();

	public int Width => _container.Instance.GetWidthAttribute();

	public ImgContainer()
	{
		_container = Xpcom.CreateInstance2<imgIContainer>("@mozilla.org/image/container;1");
	}

	internal ImgContainer(imgIContainer container)
	{
		_container = new ComPtr<imgIContainer>(container);
	}

	public void Draw(gfxContext context, gfxGraphicsFilter filter, gfxMatrix matrix, gfxRect fill, nsIntRect subImage, uint viewportSize, IntPtr aSVGContext, uint aWhichFrame, uint flags)
	{
		throw new NotImplementedException("Need to implement for gecko 45");
	}

	public IntPtr GetFrame(uint whichFrame, uint flags)
	{
		return _container.Instance.GetFrame(whichFrame, flags);
	}

	public void LockImage()
	{
		_container.Instance.LockImage();
	}

	public void RequestDiscard()
	{
	}

	public void RequestRefresh(ulong time)
	{
		_container.Instance.RequestRefresh(time);
	}

	public void ResetAnimation()
	{
		_container.Instance.ResetAnimation();
	}

	public void UnlockImage()
	{
		_container.Instance.UnlockImage();
	}

	public Locker Lock()
	{
		return new Locker(this);
	}
}
