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

Namespace SetWidthAllColumns
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

		   ' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Creating a file stream containing the Excel file to be opened
			Dim fstream As New FileStream(dataDir & "book1.xls", FileMode.Open)

			'Instantiating a Workbook object
			'Opening the Excel file through the file stream
			Dim workbook As New Workbook(fstream)

			'Accessing the first worksheet in the Excel file
			Dim worksheet As Worksheet = workbook.Worksheets(0)

			'Setting the width of all columns in the worksheet to 20.5
			worksheet.Cells.StandardWidth = 20.5

			'Saving the modified Excel file
			workbook.Save(dataDir & "output.xls")

			'Closing the file stream to free all resources
			fstream.Close()
		End Sub
	End Class
End Namespace