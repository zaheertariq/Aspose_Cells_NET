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

Namespace CreatingSubtotals
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate a new workbook
			'Open the template file
			Dim workbook As New Workbook(dataDir & "book1.xls")

			'Get the Cells collection in the first worksheet
			Dim cells As Cells = workbook.Worksheets(0).Cells

			'Create a cellarea i.e.., B3:C19
			Dim ca As New CellArea()
			ca.StartRow = 2
			ca.StartColumn = 1
			ca.EndRow = 18
			ca.EndColumn = 2

			'Apply subtotal, the consolidation function is Sum and it will applied to
			'Second column (C) in the list
			cells.Subtotal(ca, 0, ConsolidationFunction.Sum, New Integer() { 1 })

			'Save the excel file
			workbook.Save(dataDir & "output.xls")

		End Sub
	End Class
End Namespace