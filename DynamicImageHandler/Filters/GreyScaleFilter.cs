﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GreyScaleFilter.cs" company="">
// Copyright (c) 2009-2010 Esben Carlsen
// Forked by Jaben Cargman
//	
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.

// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
// </copyright>
// <summary>
//   The grey scale filter.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DynamicImageHandler.Filters
{
	using System.Drawing;
	using System.Web;

	/// <summary>
	/// The grey scale filter.
	/// </summary>
	internal class GreyScaleFilter : IImageFilter
	{
		#region Public Methods

		/// <summary>
		/// The process.
		/// </summary>
		/// <param name="parameters">
		/// The parameters.
		/// </param>
		/// <param name="context">
		/// The context.
		/// </param>
		/// <param name="bitmap">
		/// The bitmap.
		/// </param>
		/// <returns>
		/// The process.
		/// </returns>
		public bool Process(IImageParameters parameters, HttpContext context, ref Bitmap bitmap)
		{
			if (parameters.Parameters.ContainsKey("greyscale"))
			{
				string greyScaleParameter = parameters.Parameters["greyscale"];
				if (string.IsNullOrEmpty(greyScaleParameter))
				{
					return false;
				}

				IImageTool imageTool = Factory.GetImageTool();
				bitmap = imageTool.ToGreyScale(bitmap);
				return true;
			}

			return false;
		}

		#endregion
	}
}