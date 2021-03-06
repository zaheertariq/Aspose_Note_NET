'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Note. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Note

Namespace SaveToImageDefaultOptions
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Load the document into Aspose.Note.
			Dim oneFile As New Document(dataDir & "Aspose.one")

			' Save the document as Gif.
			oneFile.Save(dataDir & "Output.gif", SaveFormat.Gif)
		End Sub
	End Class
End Namespace