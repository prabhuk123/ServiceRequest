#pragma checksum "C:\PRABU\HomeServiceAssignment\ServiceRequestApp\ServiceRequestApp\Views\Home\ServiceList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff4930d37ccd317183d80d9ee831b182783e7d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ServiceList), @"mvc.1.0.view", @"/Views/Home/ServiceList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ServiceList.cshtml", typeof(AspNetCore.Views_Home_ServiceList))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\PRABU\HomeServiceAssignment\ServiceRequestApp\ServiceRequestApp\Views\_ViewImports.cshtml"
using HomeServiceApp;

#line default
#line hidden
#line 2 "C:\PRABU\HomeServiceAssignment\ServiceRequestApp\ServiceRequestApp\Views\_ViewImports.cshtml"
using HomeServiceApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff4930d37ccd317183d80d9ee831b182783e7d3", @"/Views/Home/ServiceList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"465107e9fd76346d53f6064fc3b23333fadc8041", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ServiceList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\PRABU\HomeServiceAssignment\ServiceRequestApp\ServiceRequestApp\Views\Home\ServiceList.cshtml"
  
    ViewData["Title"] = "Service List";

#line default
#line hidden
            BeginContext(45, 369, true);
            WriteLiteral(@"


<table id=""tbl_serviceList"" class=""table"" style=""width:100%"">
    <thead class=""thead-light"">
        <tr>
            <th scope=""row"">Name</th>
            <th scope=""row"">Product</th>
            <th scope=""row"">Product Type</th>
            <th scope=""row"">Product Service</th>
            <th scope=""row"">Service Timing</th>
        </tr>
    </thead>
</table>

");
            EndContext();
            BeginContext(414, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93885a12f32d45d583620718c6ea4732", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(465, 4078, true);
            WriteLiteral(@"
<script type=""text/javascript"">

    $(document).ready(function () {

        var categories = [];
        $.ajax({
            url: ""http://localhost:61804/api/HomeService/GetCategories"",
            type: 'GET',
            dataType: 'json',
            async: false,
            contentType: ""application/json"",
            success: function (responsive) {
                if (responsive != null) {
                    categories = responsive;
                }
            }
        });

        var ProductTypes = [];
        $.ajax({
            url: ""http://localhost:61804/api/HomeService/GetProductTypes"",
            type: 'GET',
            dataType: 'json',
            async: false,
            contentType: ""application/json"",
            success: function (responsive) {
                if (responsive != null) {
                    productTypes = responsive;
                }
            }
        });

        var ProductServices = [];
        $.ajax({
            url: ""http://localhost:61804/api/HomeSer");
            WriteLiteral(@"vice/GetProductService"",
            type: 'GET',
            dataType: 'json',
            async: false,
            contentType: ""application/json"",
            success: function (responsive) {
                if (responsive != null) {
                    productServices = responsive;
                }
            }
        });


        var serviceRequest = null;
        $.ajax({
            url: ""http://localhost:61804/api/HomeService/GetServiceRequests"",
            type: 'GET',
            dataType: 'json',
            async: false,
            contentType: ""application/json"",
            success: function (responsive) {
                if (responsive != null) {
                    serviceRequest = responsive;
                }
            }
        });


        $('#tbl_serviceList').DataTable({
            data: serviceRequest ? serviceRequest : """",
            columns: [
                { data: 'name' },
                {
                    data: null, render: function (data, type, row, meta) {
    ");
            WriteLiteral(@"                    var ProductName = """";
                        var filterdata = categories.filter(function (item) {
                            return item.productId == data.productId;
                        });
                        if (filterdata != null && filterdata.length > 0) {
                            ProductName = filterdata[0].productName;
                        }
                        return ProductName;
                    }
                },
                {
                    data: null, render: function (data, type, row, meta) {
                        var ProductTypeName = """";
                        var filterdata = productTypes.filter(function (item) {
                            return item.productTypeId == data.productTypeId;
                        });
                        if (filterdata != null && filterdata.length > 0) {
                            ProductTypeName = filterdata[0].productTypeName;
                        }
                        return ProductTypeName;
");
            WriteLiteral(@"                    }
                },
                {
                    data: null, render: function (data, type, row, meta) {
                        var ProductServiceName = """";
                        var filterdata = productServices.filter(function (item) {
                            return item.productServiceId == data.productServiceId;
                        });
                        if (filterdata != null && filterdata.length > 0) {
                            ProductServiceName = filterdata[0].productServiceName;
                        }
                        return ProductServiceName;
                    }
                },
                { data: 'serviceTiming' }
            ],
            deferRender: true,
            ""bPaginate"": false,
            ""bLengthChange"": false,
            ""bFilter"": false,
            ""bInfo"": false,
            ""bAutoWidth"": false,
            ""language"": {
                ""infoEmpty"": "" ""
            }

        });
    });
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
