﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RotateFilter.cs" company="">
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
//   The rotate filter.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DynamicImageHandler.Filters
{
	#region Using

	using System.Drawing;
	using System.Globalization;
	using System.Web;

	#endregion

	/// <summary>
	/// 	The rotate filter.
	/// </summary>
	internal class RotateFilter : IImageFilter
	{
		#region Public Methods

		/// <summary>
		/// 	The process.
		/// </summary>
		/// <param name="parameters">
		/// 	The parameters.
		/// </param>
		/// <param name="context">
		/// 	The context.
		/// </param>
		/// <param name="bitmap">
		/// 	The bitmap.
		/// </param>
		/// <returns>
		/// 	The process.
		/// </returns>
		public bool Process(IImageParameters parameters, HttpContext context, ref Bitmap bitmap)
		{
			if (parameters.Parameters.ContainsKey("rotate"))
			{
				string rotateParameter = parameters.Parameters["rotate"];

				float angle;
				if (float.TryParse(rotateParameter, NumberStyles.Float, CultureInfo.InvariantCulture, out angle))
				{
					IImageTool imageTool = Factory.GetImageTool();
					bitmap = imageTool.Rotate(bitmap, angle);
					return true;
				}
			}

			return false;
		}

		#endregion
	}
}