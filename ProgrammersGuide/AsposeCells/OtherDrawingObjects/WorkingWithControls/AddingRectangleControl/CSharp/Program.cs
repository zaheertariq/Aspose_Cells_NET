//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Cells. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Cells;
using Aspose.Cells.Drawing;
using System.Drawing;

namespace AddingRectangleControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate a new Workbook.
            Workbook excelbook = new Workbook();

            //Add a rectangle control.
            Aspose.Cells.Drawing.RectangleShape rectangle = excelbook.Worksheets[0].Shapes.AddRectangle(3, 0, 2, 0, 70, 130);

            //Set the placement of the rectangle.
            rectangle.Placement = PlacementType.FreeFloating;

            //Set the fill format.
            rectangle.FillFormat.ForeColor = Color.Azure;

            //Set the line style.
            rectangle.LineFormat.Style = MsoLineStyle.ThickThin;

            //Set the line weight.
            rectangle.LineFormat.Weight = 4;

            //Set the color of the line.
            rectangle.LineFormat.ForeColor = Color.Blue;

            //Set the dash style of the rectangle.
            rectangle.LineFormat.DashStyle = MsoLineDashStyle.Solid;

            //Save the excel file.
            excelbook.Save(dataDir + "book1.xls");

        }
    }
}