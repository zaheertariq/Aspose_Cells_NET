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

Namespace AddingComboBoxControl
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Create a new Workbook.
			Dim workbook As New Workbook()

			'Get the first worksheet.
			Dim sheet As Worksheet = workbook.Worksheets(0)

			'Get the worksheet cells collection.
			Dim cells As Cells = sheet.Cells

			'Input a value.
			cells("B3").PutValue("Employee:")

			'Set it bold.
			cells("B3").GetStyle().Font.IsBold = True

			'Input some values that denote the input range
			'for the combo box.
			cells("A2").PutValue("Emp001")
			cells("A3").PutValue("Emp002")
			cells("A4").PutValue("Emp003")
			cells("A5").PutValue("Emp004")
			cells("A6").PutValue("Emp005")
			cells("A7").PutValue("Emp006")

			'Add a new combo box.
			Dim comboBox As Aspose.Cells.Drawing.ComboBox = sheet.Shapes.AddComboBox(2, 0, 2, 0, 22, 100)

			'Set the linked cell;
			comboBox.LinkedCell = "A1"

			'Set the input range.
			comboBox.InputRange = "A2:A7"

			'Set no. of list lines displayed in the combo
			'box's list portion.
			comboBox.DropDownLines = 5

			'Set the combo box with 3-D shading.
			comboBox.Shadow = True

			'AutoFit Columns
			sheet.AutoFitColumns()

			'Saves the file.
			workbook.Save(dataDir & "book1.xls")

		End Sub
	End Class
End Namespace