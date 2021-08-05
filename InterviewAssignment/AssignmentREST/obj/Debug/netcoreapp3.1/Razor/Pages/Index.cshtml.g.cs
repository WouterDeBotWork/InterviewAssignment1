#pragma checksum "C:\Project\InterviewAssignment1\InterviewAssignment\AssignmentREST\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77892bed0f8689779fb44f44b61e9796759b1afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77892bed0f8689779fb44f44b61e9796759b1afe", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div>

    <h1>Interview Assignment</h1>
    <h3>Please provide the required info in order to start the calculation.</h3>

</div>

<div>
    <!--Input fields-->

    <h4>Age:</h4><input type=""number"" id=""age"" size=""5"" />
    <h4>Length (cm):</h4><input type=""number"" id=""length"" size=""5"" />
</div>

<div>
    <!--Start button that should be unclickable until all client side validation has succeeded-->

    <input type=""button"" value=""Start"" onclick=""start();"" />
    <p id=""statusobject"" />
</div>


<div>
    <!--Progress visual will be placed here, div will remain invisible until the calculation has been started-->
    
</div>
<script src=""https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.3.min.js""></script>
<script>


    function formatItem(item) {
        return 'GUID:'+ item.guid + ' Status: ' + item.status + ' Progress: ' + item.progress + ' Result: ' + item.result;
    }

    function start() {
        var age = $('#age').val();
        var length = $('#length').val()");
            WriteLiteral(@";
        //Remove hardcode
        var uri = 'api/calculation/' + age + '/' + length;
        $.getJSON(uri)
            .done(function (data) {
                $('#statusobject').text(formatItem(data));
            })
            .fail(function (jqXHR, textStatus, err) {
                $('#statusobject').text('Error: ' + err);
            });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AssignmentInterview.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AssignmentInterview.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AssignmentInterview.Pages.IndexModel>)PageContext?.ViewData;
        public AssignmentInterview.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
