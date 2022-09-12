using System;

namespace Gecko.WebIDL;

public class WebGLRenderingContext : WebIDLBase
{
	public WebIDLUnion<nsIDOMHTMLCanvasElement, nsISupports> Canvas => GetProperty<WebIDLUnion<nsIDOMHTMLCanvasElement, nsISupports>>("canvas");

	public int DrawingBufferWidth => GetProperty<int>("drawingBufferWidth");

	public int DrawingBufferHeight => GetProperty<int>("drawingBufferHeight");

	public WebGLRenderingContext(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object GetContextAttributes()
	{
		return CallMethod<object>("getContextAttributes", new object[0]);
	}

	public bool IsContextLost()
	{
		return CallMethod<bool>("isContextLost", new object[0]);
	}

	public string[] GetSupportedExtensions()
	{
		return CallMethod<string[]>("getSupportedExtensions", new object[0]);
	}

	public object GetExtension(string name)
	{
		return CallMethod<object>("getExtension", new object[1] { name });
	}

	public void ActiveTexture(uint texture)
	{
		CallVoidMethod("activeTexture", texture);
	}

	public void AttachShader(nsISupports program, nsISupports shader)
	{
		CallVoidMethod("attachShader", program, shader);
	}

	public void BindAttribLocation(nsISupports program, uint index, string name)
	{
		CallVoidMethod("bindAttribLocation", program, index, name);
	}

	public void BindBuffer(uint target, nsISupports buffer)
	{
		CallVoidMethod("bindBuffer", target, buffer);
	}

	public void BindFramebuffer(uint target, nsISupports framebuffer)
	{
		CallVoidMethod("bindFramebuffer", target, framebuffer);
	}

	public void BindRenderbuffer(uint target, nsISupports renderbuffer)
	{
		CallVoidMethod("bindRenderbuffer", target, renderbuffer);
	}

	public void BindTexture(uint target, nsISupports texture)
	{
		CallVoidMethod("bindTexture", target, texture);
	}

	public void BlendColor(float red, float green, float blue, float alpha)
	{
		CallVoidMethod("blendColor", red, green, blue, alpha);
	}

	public void BlendEquation(uint mode)
	{
		CallVoidMethod("blendEquation", mode);
	}

	public void BlendEquationSeparate(uint modeRGB, uint modeAlpha)
	{
		CallVoidMethod("blendEquationSeparate", modeRGB, modeAlpha);
	}

	public void BlendFunc(uint sfactor, uint dfactor)
	{
		CallVoidMethod("blendFunc", sfactor, dfactor);
	}

	public void BlendFuncSeparate(uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha)
	{
		CallVoidMethod("blendFuncSeparate", srcRGB, dstRGB, srcAlpha, dstAlpha);
	}

	public void BufferData(uint target, long size, uint usage)
	{
		CallVoidMethod("bufferData", target, size, usage);
	}

	public void BufferData(uint target, IntPtr data, uint usage)
	{
		CallVoidMethod("bufferData", target, data, usage);
	}

	public void BufferData(uint target, SharedArrayBuffer data, uint usage)
	{
		CallVoidMethod("bufferData", target, data, usage);
	}

	public void BufferSubData(uint target, long offset, IntPtr data)
	{
		CallVoidMethod("bufferSubData", target, offset, data);
	}

	public void BufferSubData(uint target, long offset, SharedArrayBuffer data)
	{
		CallVoidMethod("bufferSubData", target, offset, data);
	}

	public uint CheckFramebufferStatus(uint target)
	{
		return CallMethod<uint>("checkFramebufferStatus", new object[1] { target });
	}

	public void Clear(uint mask)
	{
		CallVoidMethod("clear", mask);
	}

	public void ClearColor(float red, float green, float blue, float alpha)
	{
		CallVoidMethod("clearColor", red, green, blue, alpha);
	}

	public void ClearDepth(float depth)
	{
		CallVoidMethod("clearDepth", depth);
	}

	public void ClearStencil(int s)
	{
		CallVoidMethod("clearStencil", s);
	}

	public void ColorMask(bool red, bool green, bool blue, bool alpha)
	{
		CallVoidMethod("colorMask", red, green, blue, alpha);
	}

	public void CompileShader(nsISupports shader)
	{
		CallVoidMethod("compileShader", shader);
	}

	public void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, IntPtr data)
	{
		CallVoidMethod("compressedTexImage2D", target, level, internalformat, width, height, border, data);
	}

	public void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, IntPtr data)
	{
		CallVoidMethod("compressedTexSubImage2D", target, level, xoffset, yoffset, width, height, format, data);
	}

	public void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border)
	{
		CallVoidMethod("copyTexImage2D", target, level, internalformat, x, y, width, height, border);
	}

	public void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
	{
		CallVoidMethod("copyTexSubImage2D", target, level, xoffset, yoffset, x, y, width, height);
	}

	public nsISupports CreateBuffer()
	{
		return CallMethod<nsISupports>("createBuffer", new object[0]);
	}

	public nsISupports CreateFramebuffer()
	{
		return CallMethod<nsISupports>("createFramebuffer", new object[0]);
	}

	public nsISupports CreateProgram()
	{
		return CallMethod<nsISupports>("createProgram", new object[0]);
	}

	public nsISupports CreateRenderbuffer()
	{
		return CallMethod<nsISupports>("createRenderbuffer", new object[0]);
	}

	public nsISupports CreateShader(uint type)
	{
		return CallMethod<nsISupports>("createShader", new object[1] { type });
	}

	public nsISupports CreateTexture()
	{
		return CallMethod<nsISupports>("createTexture", new object[0]);
	}

	public void CullFace(uint mode)
	{
		CallVoidMethod("cullFace", mode);
	}

	public void DeleteBuffer(nsISupports buffer)
	{
		CallVoidMethod("deleteBuffer", buffer);
	}

	public void DeleteFramebuffer(nsISupports framebuffer)
	{
		CallVoidMethod("deleteFramebuffer", framebuffer);
	}

	public void DeleteProgram(nsISupports program)
	{
		CallVoidMethod("deleteProgram", program);
	}

	public void DeleteRenderbuffer(nsISupports renderbuffer)
	{
		CallVoidMethod("deleteRenderbuffer", renderbuffer);
	}

	public void DeleteShader(nsISupports shader)
	{
		CallVoidMethod("deleteShader", shader);
	}

	public void DeleteTexture(nsISupports texture)
	{
		CallVoidMethod("deleteTexture", texture);
	}

	public void DepthFunc(uint func)
	{
		CallVoidMethod("depthFunc", func);
	}

	public void DepthMask(bool flag)
	{
		CallVoidMethod("depthMask", flag);
	}

	public void DepthRange(float zNear, float zFar)
	{
		CallVoidMethod("depthRange", zNear, zFar);
	}

	public void DetachShader(nsISupports program, nsISupports shader)
	{
		CallVoidMethod("detachShader", program, shader);
	}

	public void Disable(uint cap)
	{
		CallVoidMethod("disable", cap);
	}

	public void DisableVertexAttribArray(uint index)
	{
		CallVoidMethod("disableVertexAttribArray", index);
	}

	public void DrawArrays(uint mode, int first, int count)
	{
		CallVoidMethod("drawArrays", mode, first, count);
	}

	public void DrawElements(uint mode, int count, uint type, long offset)
	{
		CallVoidMethod("drawElements", mode, count, type, offset);
	}

	public void Enable(uint cap)
	{
		CallVoidMethod("enable", cap);
	}

	public void EnableVertexAttribArray(uint index)
	{
		CallVoidMethod("enableVertexAttribArray", index);
	}

	public void Finish()
	{
		CallVoidMethod("finish");
	}

	public void Flush()
	{
		CallVoidMethod("flush");
	}

	public void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, nsISupports renderbuffer)
	{
		CallVoidMethod("framebufferRenderbuffer", target, attachment, renderbuffertarget, renderbuffer);
	}

	public void FramebufferTexture2D(uint target, uint attachment, uint textarget, nsISupports texture, int level)
	{
		CallVoidMethod("framebufferTexture2D", target, attachment, textarget, texture, level);
	}

	public void FrontFace(uint mode)
	{
		CallVoidMethod("frontFace", mode);
	}

	public void GenerateMipmap(uint target)
	{
		CallVoidMethod("generateMipmap", target);
	}

	public nsISupports GetActiveAttrib(nsISupports program, uint index)
	{
		return CallMethod<nsISupports>("getActiveAttrib", new object[2] { program, index });
	}

	public nsISupports GetActiveUniform(nsISupports program, uint index)
	{
		return CallMethod<nsISupports>("getActiveUniform", new object[2] { program, index });
	}

	public nsISupports[] GetAttachedShaders(nsISupports program)
	{
		return CallMethod<nsISupports[]>("getAttachedShaders", new object[1] { program });
	}

	public int GetAttribLocation(nsISupports program, string name)
	{
		return CallMethod<int>("getAttribLocation", new object[2] { program, name });
	}

	public object GetBufferParameter(uint target, uint pname)
	{
		return CallMethod<object>("getBufferParameter", new object[2] { target, pname });
	}

	public object GetParameter(uint pname)
	{
		return CallMethod<object>("getParameter", new object[1] { pname });
	}

	public uint GetError()
	{
		return CallMethod<uint>("getError", new object[0]);
	}

	public object GetFramebufferAttachmentParameter(uint target, uint attachment, uint pname)
	{
		return CallMethod<object>("getFramebufferAttachmentParameter", new object[3] { target, attachment, pname });
	}

	public object GetProgramParameter(nsISupports program, uint pname)
	{
		return CallMethod<object>("getProgramParameter", new object[2] { program, pname });
	}

	public string GetProgramInfoLog(nsISupports program)
	{
		return CallMethod<string>("getProgramInfoLog", new object[1] { program });
	}

	public object GetRenderbufferParameter(uint target, uint pname)
	{
		return CallMethod<object>("getRenderbufferParameter", new object[2] { target, pname });
	}

	public object GetShaderParameter(nsISupports shader, uint pname)
	{
		return CallMethod<object>("getShaderParameter", new object[2] { shader, pname });
	}

	public nsISupports GetShaderPrecisionFormat(uint shadertype, uint precisiontype)
	{
		return CallMethod<nsISupports>("getShaderPrecisionFormat", new object[2] { shadertype, precisiontype });
	}

	public string GetShaderInfoLog(nsISupports shader)
	{
		return CallMethod<string>("getShaderInfoLog", new object[1] { shader });
	}

	public string GetShaderSource(nsISupports shader)
	{
		return CallMethod<string>("getShaderSource", new object[1] { shader });
	}

	public object GetTexParameter(uint target, uint pname)
	{
		return CallMethod<object>("getTexParameter", new object[2] { target, pname });
	}

	public object GetUniform(nsISupports program, nsISupports location)
	{
		return CallMethod<object>("getUniform", new object[2] { program, location });
	}

	public nsISupports GetUniformLocation(nsISupports program, string name)
	{
		return CallMethod<nsISupports>("getUniformLocation", new object[2] { program, name });
	}

	public object GetVertexAttrib(uint index, uint pname)
	{
		return CallMethod<object>("getVertexAttrib", new object[2] { index, pname });
	}

	public long GetVertexAttribOffset(uint index, uint pname)
	{
		return CallMethod<long>("getVertexAttribOffset", new object[2] { index, pname });
	}

	public void Hint(uint target, uint mode)
	{
		CallVoidMethod("hint", target, mode);
	}

	public bool IsBuffer(nsISupports buffer)
	{
		return CallMethod<bool>("isBuffer", new object[1] { buffer });
	}

	public bool IsEnabled(uint cap)
	{
		return CallMethod<bool>("isEnabled", new object[1] { cap });
	}

	public bool IsFramebuffer(nsISupports framebuffer)
	{
		return CallMethod<bool>("isFramebuffer", new object[1] { framebuffer });
	}

	public bool IsProgram(nsISupports program)
	{
		return CallMethod<bool>("isProgram", new object[1] { program });
	}

	public bool IsRenderbuffer(nsISupports renderbuffer)
	{
		return CallMethod<bool>("isRenderbuffer", new object[1] { renderbuffer });
	}

	public bool IsShader(nsISupports shader)
	{
		return CallMethod<bool>("isShader", new object[1] { shader });
	}

	public bool IsTexture(nsISupports texture)
	{
		return CallMethod<bool>("isTexture", new object[1] { texture });
	}

	public void LineWidth(float width)
	{
		CallVoidMethod("lineWidth", width);
	}

	public void LinkProgram(nsISupports program)
	{
		CallVoidMethod("linkProgram", program);
	}

	public void PixelStorei(uint pname, int param)
	{
		CallVoidMethod("pixelStorei", pname, param);
	}

	public void PolygonOffset(float factor, float units)
	{
		CallVoidMethod("polygonOffset", factor, units);
	}

	public void ReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels)
	{
		CallVoidMethod("readPixels", x, y, width, height, format, type, pixels);
	}

	public void RenderbufferStorage(uint target, uint internalformat, int width, int height)
	{
		CallVoidMethod("renderbufferStorage", target, internalformat, width, height);
	}

	public void SampleCoverage(float value, bool invert)
	{
		CallVoidMethod("sampleCoverage", value, invert);
	}

	public void Scissor(int x, int y, int width, int height)
	{
		CallVoidMethod("scissor", x, y, width, height);
	}

	public void ShaderSource(nsISupports shader, string source)
	{
		CallVoidMethod("shaderSource", shader, source);
	}

	public void StencilFunc(uint func, int @ref, uint mask)
	{
		CallVoidMethod("stencilFunc", func, @ref, mask);
	}

	public void StencilFuncSeparate(uint face, uint func, int @ref, uint mask)
	{
		CallVoidMethod("stencilFuncSeparate", face, func, @ref, mask);
	}

	public void StencilMask(uint mask)
	{
		CallVoidMethod("stencilMask", mask);
	}

	public void StencilMaskSeparate(uint face, uint mask)
	{
		CallVoidMethod("stencilMaskSeparate", face, mask);
	}

	public void StencilOp(uint fail, uint zfail, uint zpass)
	{
		CallVoidMethod("stencilOp", fail, zfail, zpass);
	}

	public void StencilOpSeparate(uint face, uint fail, uint zfail, uint zpass)
	{
		CallVoidMethod("stencilOpSeparate", face, fail, zfail, zpass);
	}

	public void TexImage2D(uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels)
	{
		CallVoidMethod("texImage2D", target, level, internalformat, width, height, border, format, type, pixels);
	}

	public void TexImage2D(uint target, int level, uint internalformat, uint format, uint type, nsISupports pixels)
	{
		CallVoidMethod("texImage2D", target, level, internalformat, format, type, pixels);
	}

	public void TexImage2D(uint target, int level, uint internalformat, uint format, uint type, nsIDOMHTMLImageElement image)
	{
		CallVoidMethod("texImage2D", target, level, internalformat, format, type, image);
	}

	public void TexImage2D(uint target, int level, uint internalformat, uint format, uint type, nsIDOMHTMLCanvasElement canvas)
	{
		CallVoidMethod("texImage2D", target, level, internalformat, format, type, canvas);
	}

	public void TexParameterf(uint target, uint pname, float param)
	{
		CallVoidMethod("texParameterf", target, pname, param);
	}

	public void TexParameteri(uint target, uint pname, int param)
	{
		CallVoidMethod("texParameteri", target, pname, param);
	}

	public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels)
	{
		CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, width, height, format, type, pixels);
	}

	public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, uint format, uint type, nsISupports pixels)
	{
		CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, format, type, pixels);
	}

	public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, uint format, uint type, nsIDOMHTMLImageElement image)
	{
		CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, format, type, image);
	}

	public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, uint format, uint type, nsIDOMHTMLCanvasElement canvas)
	{
		CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, format, type, canvas);
	}

	public void Uniform1f(nsISupports location, float x)
	{
		CallVoidMethod("uniform1f", location, x);
	}

	public void Uniform1fv(nsISupports location, IntPtr v)
	{
		CallVoidMethod("uniform1fv", location, v);
	}

	public void Uniform1fv(nsISupports location, float[] v)
	{
		CallVoidMethod("uniform1fv", location, v);
	}

	public void Uniform1i(nsISupports location, int x)
	{
		CallVoidMethod("uniform1i", location, x);
	}

	public void Uniform1iv(nsISupports location, IntPtr v)
	{
		CallVoidMethod("uniform1iv", location, v);
	}

	public void Uniform1iv(nsISupports location, int[] v)
	{
		CallVoidMethod("uniform1iv", location, v);
	}

	public void Uniform2f(nsISupports location, float x, float y)
	{
		CallVoidMethod("uniform2f", location, x, y);
	}

	public void Uniform2fv(nsISupports location, IntPtr v)
	{
		CallVoidMethod("uniform2fv", location, v);
	}

	public void Uniform2fv(nsISupports location, float[] v)
	{
		CallVoidMethod("uniform2fv", location, v);
	}

	public void Uniform2i(nsISupports location, int x, int y)
	{
		CallVoidMethod("uniform2i", location, x, y);
	}

	public void Uniform2iv(nsISupports location, IntPtr v)
	{
		CallVoidMethod("uniform2iv", location, v);
	}

	public void Uniform2iv(nsISupports location, int[] v)
	{
		CallVoidMethod("uniform2iv", location, v);
	}

	public void Uniform3f(nsISupports location, float x, float y, float z)
	{
		CallVoidMethod("uniform3f", location, x, y, z);
	}

	public void Uniform3fv(nsISupports location, IntPtr v)
	{
		CallVoidMethod("uniform3fv", location, v);
	}

	public void Uniform3fv(nsISupports location, float[] v)
	{
		CallVoidMethod("uniform3fv", location, v);
	}

	public void Uniform3i(nsISupports location, int x, int y, int z)
	{
		CallVoidMethod("uniform3i", location, x, y, z);
	}

	public void Uniform3iv(nsISupports location, IntPtr v)
	{
		CallVoidMethod("uniform3iv", location, v);
	}

	public void Uniform3iv(nsISupports location, int[] v)
	{
		CallVoidMethod("uniform3iv", location, v);
	}

	public void Uniform4f(nsISupports location, float x, float y, float z, float w)
	{
		CallVoidMethod("uniform4f", location, x, y, z, w);
	}

	public void Uniform4fv(nsISupports location, IntPtr v)
	{
		CallVoidMethod("uniform4fv", location, v);
	}

	public void Uniform4fv(nsISupports location, float[] v)
	{
		CallVoidMethod("uniform4fv", location, v);
	}

	public void Uniform4i(nsISupports location, int x, int y, int z, int w)
	{
		CallVoidMethod("uniform4i", location, x, y, z, w);
	}

	public void Uniform4iv(nsISupports location, IntPtr v)
	{
		CallVoidMethod("uniform4iv", location, v);
	}

	public void Uniform4iv(nsISupports location, int[] v)
	{
		CallVoidMethod("uniform4iv", location, v);
	}

	public void UniformMatrix2fv(nsISupports location, bool transpose, IntPtr value)
	{
		CallVoidMethod("uniformMatrix2fv", location, transpose, value);
	}

	public void UniformMatrix2fv(nsISupports location, bool transpose, float[] value)
	{
		CallVoidMethod("uniformMatrix2fv", location, transpose, value);
	}

	public void UniformMatrix3fv(nsISupports location, bool transpose, IntPtr value)
	{
		CallVoidMethod("uniformMatrix3fv", location, transpose, value);
	}

	public void UniformMatrix3fv(nsISupports location, bool transpose, float[] value)
	{
		CallVoidMethod("uniformMatrix3fv", location, transpose, value);
	}

	public void UniformMatrix4fv(nsISupports location, bool transpose, IntPtr value)
	{
		CallVoidMethod("uniformMatrix4fv", location, transpose, value);
	}

	public void UniformMatrix4fv(nsISupports location, bool transpose, float[] value)
	{
		CallVoidMethod("uniformMatrix4fv", location, transpose, value);
	}

	public void UseProgram(nsISupports program)
	{
		CallVoidMethod("useProgram", program);
	}

	public void ValidateProgram(nsISupports program)
	{
		CallVoidMethod("validateProgram", program);
	}

	public void VertexAttrib1f(uint indx, float x)
	{
		CallVoidMethod("vertexAttrib1f", indx, x);
	}

	public void VertexAttrib1fv(uint indx, IntPtr values)
	{
		CallVoidMethod("vertexAttrib1fv", indx, values);
	}

	public void VertexAttrib1fv(uint indx, float[] values)
	{
		CallVoidMethod("vertexAttrib1fv", indx, values);
	}

	public void VertexAttrib2f(uint indx, float x, float y)
	{
		CallVoidMethod("vertexAttrib2f", indx, x, y);
	}

	public void VertexAttrib2fv(uint indx, IntPtr values)
	{
		CallVoidMethod("vertexAttrib2fv", indx, values);
	}

	public void VertexAttrib2fv(uint indx, float[] values)
	{
		CallVoidMethod("vertexAttrib2fv", indx, values);
	}

	public void VertexAttrib3f(uint indx, float x, float y, float z)
	{
		CallVoidMethod("vertexAttrib3f", indx, x, y, z);
	}

	public void VertexAttrib3fv(uint indx, IntPtr values)
	{
		CallVoidMethod("vertexAttrib3fv", indx, values);
	}

	public void VertexAttrib3fv(uint indx, float[] values)
	{
		CallVoidMethod("vertexAttrib3fv", indx, values);
	}

	public void VertexAttrib4f(uint indx, float x, float y, float z, float w)
	{
		CallVoidMethod("vertexAttrib4f", indx, x, y, z, w);
	}

	public void VertexAttrib4fv(uint indx, IntPtr values)
	{
		CallVoidMethod("vertexAttrib4fv", indx, values);
	}

	public void VertexAttrib4fv(uint indx, float[] values)
	{
		CallVoidMethod("vertexAttrib4fv", indx, values);
	}

	public void VertexAttribPointer(uint indx, int size, uint type, bool normalized, int stride, long offset)
	{
		CallVoidMethod("vertexAttribPointer", indx, size, type, normalized, stride, offset);
	}

	public void Viewport(int x, int y, int width, int height)
	{
		CallVoidMethod("viewport", x, y, width, height);
	}

	public void Commit()
	{
		CallVoidMethod("commit");
	}
}
