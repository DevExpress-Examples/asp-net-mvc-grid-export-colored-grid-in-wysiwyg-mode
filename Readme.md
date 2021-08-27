<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128551496/14.2.11%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T334596)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Controllers/HomeController.vb))
* [Model.cs](./CS/Models/Model.cs) (VB: [Model.vb](./VB/Models/Model.vb))
* [GridViewPartialProducts.cshtml](./CS/Views/Home/GridViewPartialProducts.cshtml)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to export colored GridView
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t334596/)**
<!-- run online end -->


<strong>UPDATED:</strong><br><br>Starting with version v2015 vol 2 (v15.2), this functionality is available out of the box. Use <a href="https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.GridViewSettings-1.FormatConditions?p=netframework">GridViewSettings.FormatConditions</a> rules to define conditional formatting in Browse Mode and keep the applied appearance in the Exported Document. Please refer to the <a href="https://community.devexpress.com/blogs/aspnet/archive/2015/11/10/asp-net-grid-view-data-range-filter-adaptivity-and-more-coming-soon-in-v15-2.aspx">ASP.NET Grid View - Data Range Filter, Adaptivity and More (Coming soon in v15.2)</a> blog post and the <a href="http://demos.devexpress.com/MVCxGridViewDemos/Exporting/ExportWithFormatConditions">Export with Format Conditions</a> demo for more information.<br>If you have version v15.2+ available, consider using the built-in functionality instead of the approach detailed below.<br><br>If you need to apply custom appearance in the Exported Document only or define fine tuned complex appearance (for instance, based on some runtime calculated values, custom business rules, etc.), use the <a href="https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.MVCxGridViewExportSettings.RenderBrick?p=netframework">GridViewSettings.SettingsExport.RenderBrick</a> event in the <strong>WYSIWYG</strong> export mode.<br><br><strong>See Also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/E4098">E4098: How to export a colored grid when the Data Aware export mode is used</a>

<br/>


