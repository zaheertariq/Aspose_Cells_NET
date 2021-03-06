'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace AbsolutePositioning
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiating a Workbook object
			Dim workbook As New Workbook()

			'Adding a new worksheet to the Workbook object
			Dim sheetIndex As Integer = workbook.Worksheets.Add()

			'Obtaining the reference of the newly added worksheet by passing its sheet index
			Dim worksheet As Worksheet = workbook.Worksheets(sheetIndex)

			'Adding a picture at the location of a cell whose row and column indices
			'are 5 in the worksheet. It is "F6" cell
			Dim pictureIndex As Integer = worksheet.Pictures.Add(5, 5, dataDir & "logo.jpg")

			'Accessing the newly added picture
			Dim picture As Aspose.Cells.Drawing.Picture = worksheet.Pictures(pictureIndex)

			'Absolute positioning of the picture in unit of pixels
			picture.Left = 60
			picture.Top = 10

			'Saving the Excel file
			workbook.Save(dataDir & "book1.xls")

		End Sub
	End Class
End Namespace