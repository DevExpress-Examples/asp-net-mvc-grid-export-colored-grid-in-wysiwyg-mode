Imports System
Imports System.IO
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.Web.Mvc
Imports CS.Model
Imports DevExpress.Web

Namespace CS.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View(New MyViewModel With {.Products = MyModel.GetProducts()})
        End Function

        Public Function GridViewPartialProducts() As ActionResult
            Return PartialView(MyModel.GetProducts())
        End Function

        Public Function ExportTo() As ActionResult
            Dim exportOptions As New XlsxExportOptionsEx()
            exportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG
            Return GridViewExtension.ExportToXlsx(GridViewHelper.ExportGridViewSettings, MyModel.GetProducts(), exportOptions)
        End Function

    End Class

End Namespace
Public NotInheritable Class GridViewHelper

    Private Sub New()
    End Sub

    Private Shared exportGridViewSettings_Renamed As GridViewSettings

    Public Shared ReadOnly Property ExportGridViewSettings() As GridViewSettings
        Get
            If exportGridViewSettings_Renamed Is Nothing Then
                exportGridViewSettings_Renamed = CreateExportGridViewSettings()
            End If
            Return exportGridViewSettings_Renamed
        End Get
    End Property

    Private Shared Function CreateExportGridViewSettings() As GridViewSettings
        Dim settings As New GridViewSettings()

        settings.Name = "gvProducts"
        settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartialProducts"}

        settings.KeyFieldName = "ProductID"
        settings.Settings.ShowFilterRow = True

        settings.Columns.Add("ProductID")
        settings.Columns.Add("ProductName")
        settings.Columns.Add("UnitPrice")

        settings.SettingsExport.RenderBrick = Sub(sender, e)
            If e.RowType <> GridViewRowType.Data Then
                Return
            End If
            If (TryCast(e.Column, GridViewDataColumn)).FieldName = "UnitPrice" AndAlso e.RowType <> GridViewRowType.Header Then
                If Convert.ToInt32(e.TextValue) > 15 Then
                    e.BrickStyle.BackColor = System.Drawing.Color.Yellow
                Else
                    e.BrickStyle.BackColor = System.Drawing.Color.Green
                End If
            End If
        End Sub

        Return settings
    End Function
End Class
