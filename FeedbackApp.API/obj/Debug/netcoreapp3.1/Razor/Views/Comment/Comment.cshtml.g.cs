#pragma checksum "C:\Users\Pavav\Downloads\FeedbackApp\FeedbackApp\FeedbackApp.API\Views\Comment\Comment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53517a15e545c2425b78da004ec03deccb010360"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_Comment), @"mvc.1.0.view", @"/Views/Comment/Comment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53517a15e545c2425b78da004ec03deccb010360", @"/Views/Comment/Comment.cshtml")]
    public class Views_Comment_Comment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FeedbackApp.BLL.VMs.Comment.CreateComment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2>Оставить комментарий</h2>
<form method=""post"" asp-controller=""Comment"" asp-action=""Leave a commment"">
    <div asp-validation-summary=""ModelOnly""></div>
    <div>
        <label asp-for=""AuthorName""></label><br />
        <input asp-for=""AuthorName"" />
        <span asp-validation-for=""AuthorName""></span>
    </div>
    <div>
        <label asp-for=""Text""></label><br />
        <input asp-for=""Text"" />
        <span asp-validation-for=""Text""></span>
    </div>
    <div>
        <p>Время создания отзыва: <time datetime=""YYYY-MM-DDThh:mm""></time></p>
    </div>
    <div>
        <input type=""submit"" value=""Добавить"" />
    </div>
</form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeedbackApp.BLL.VMs.Comment.CreateComment> Html { get; private set; }
    }
}
#pragma warning restore 1591