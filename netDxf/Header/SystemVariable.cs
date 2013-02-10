#region netDxf, Copyright(C) 2013 Daniel Carvajal, Licensed under LGPL.

//                        netDxf library
// Copyright (C) 2013 Daniel Carvajal (haplokuon@gmail.com)
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE. 

#endregion

namespace netDxf.Header
{
    /// <summary>
    /// Strings system variables
    /// </summary>
    public static class SystemVariable
    {
        /// <summary>
        /// The AutoCAD drawing database version number.
        /// </summary>
        public const string DatabaseVersion = "$ACADVER";

        /// <summary>
        /// Next available handle (this variable must be present in the header section).
        /// </summary>
        public const string HandSeed = "$HANDSEED";

        /// <summary>
        /// Angle 0 direction.
        /// </summary>
        public const string Angbase = "$ANGBASE";

        /// <summary>
        /// 1 = Clockwise angles, 0 = Counterclockwise.
        /// </summary>
        public const string Angdir = "$ANGDIR";

        /// <summary>
        /// Drawing code page; set to the system code page when a new drawing is created, but not otherwise maintained by AutoCAD.
        /// </summary>
        public const string DwgCodePage = "$DWGCODEPAGE";

        /// <summary>
        /// Controls symbol table naming.
        /// </summary>
        public const string Extnames = "$EXTNAMES";

        /// <summary>
        /// Default drawing units for AutoCAD DesignCenter blocks.
        /// Also applies to raster image units, eventhought they have the RasterVariables object and units in ImageDef.
        /// </summary>
        public const string Insunits = "$INSUNITS";

        /// <summary>
        /// Controls the display of lineweights on the Model or Layout tab:
        /// 0 = Lineweight is not displayed
        /// 1 = Lineweight is displayed
        /// </summary>
        public const string LwDisplay = "$LWDISPLAY";

        /// <summary>
        /// Global linetype scale.
        /// </summary>
        public const string LtScale = "$LTSCALE";

        /// <summary>
        /// Controls the <see cref="PointShape">shape</see> to draw a point entity.
        /// </summary>
        public const string PdMode = "$PDMODE";

        /// <summary>
        /// Controls the size of the point figures, except for PDMODE values 0 (Dot) and 1 (Empty).
        /// A setting of 0 generates the point at 5 percent of the drawing area height.
        /// A positive PDSIZE value specifies an absolute size for the point figures.
        /// A negative value is interpreted as a percentage of the viewport size. 
        /// </summary>
        public const string PdSize = "$PDSIZE";
    }
}