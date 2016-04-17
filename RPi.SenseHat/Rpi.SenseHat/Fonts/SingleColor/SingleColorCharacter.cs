////////////////////////////////////////////////////////////////////////////
//
//  This file is part of Rpi.SenseHat
//
//  Copyright (c) 2016, Mattias Larsson
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy of 
//  this software and associated documentation files (the "Software"), to deal in 
//  the Software without restriction, including without limitation the rights to use, 
//  copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
//  Software, and to permit persons to whom the Software is furnished to do so, 
//  subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all 
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
//  INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
//  PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
//  HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION 
//  OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
//  SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Emmellsoft.IoT.Rpi.SenseHat.Fonts.SingleColor
{
	/// <summary>
	/// A single color font character.
	/// </summary>
	public class SingleColorCharacter : Character
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="symbol">The unicode character.</param>
		/// <param name="columns">The pixel columns. One column=one byte where each bit represents a pixel (on=1 or off=0) where the LSB is the topmost pixel.</param>
		public SingleColorCharacter(char symbol, byte[] columns)
			: base(symbol, columns.Length)
		{
			Columns = columns;
		}

		/// <summary>
		/// The pixel columns.
		/// One column=one byte where each bit represents a pixel (on=1 or off=0)
		/// where the LSB is the topmost pixel.
		/// </summary>
		public byte[] Columns
		{ get; }
	}
}