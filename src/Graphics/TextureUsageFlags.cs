using System;

namespace Microsoft.Xna.Framework.Graphics
{
	/// <summary>
	/// Specifies how a texture is intended to be used by the client.
	/// <remarks>doc => https://wiki.libsdl.org/SDL3/SDL_GPUTextureUsageFlags</remarks>
	/// </summary>
	[Flags]
	public enum TextureUsageFlags
	{
		SAMPLER = (1 << 0),
		COLOR_TARGET = (1 << 1),
		DEPTH_STENCIL_TARGET = (1 << 2),
		GRAPHICS_STORAGE_READ = (1 << 3),
		COMPUTE_STORAGE_READ = (1 << 4),
		COMPUTE_STORAGE_WRITE = (1 << 5),
		COMPUTE_STORAGE_SIMULTANEOUS_READ_WRITE = (1 << 6)
	}
}
