#pragma checksum "D:\progs\asp core\miniProjet1\Pages\View\Presence\TauxAbs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da942a6356ee85946bb5460f7360628aa476d8ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(miniProjet1.Pages.View.Presence.Pages_View_Presence_TauxAbs), @"mvc.1.0.razor-page", @"/Pages/View/Presence/TauxAbs.cshtml")]
namespace miniProjet1.Pages.View.Presence
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\progs\asp core\miniProjet1\Pages\_ViewImports.cshtml"
using miniProjet1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\progs\asp core\miniProjet1\Pages\View\Presence\TauxAbs.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da942a6356ee85946bb5460f7360628aa476d8ce", @"/Pages/View/Presence/TauxAbs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b0a2eb6e552234c76d5df8cde0078de210eba36", @"/Pages/_ViewImports.cshtml")]
    public class Pages_View_Presence_TauxAbs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("_MAT"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\progs\asp core\miniProjet1\Pages\View\Presence\TauxAbs.cshtml"
  
    var XLabels = Newtonsoft.Json.JsonConvert.SerializeObject( Model.Presence.Select( x => x.etat ).ToList() );  
    var YValues = Newtonsoft.Json.JsonConvert.SerializeObject( Model.Presence.Select( x => x.nbr ).ToList() );  
   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br/><br/>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.bundle.min.js""></script>    
<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>
<h1>Taux d'Absence</h1>
<hr/>

<div class=""container"">
  <div class=""row"">
    <div class=""col-sm-3"">
        <!--LEFT SIDE--------------------------------------->
<div class=""card"" style=""width: 15rem;"">
  <ul class=""list-group list-group-flush"">
    <a href=""ListePr"" class=""list-group-item list-group-item-action "">Liste de Presence</a>
    <a href=""ListeAbs"" class=""list-group-item list-group-item-action "">Liste d'Absence</a>
<a href=""TauxAbs"" class=""list-group-item list-group-item-action active"">Taux d'Absence par Matiere</a>
     <a href=""TauxAbsE"" class=""list-group-item list-group-item-action "">Taux d'Absence par Etudiant</a>


  </ul>
</div>
    </div>
    <div class=""col-sm-9"">
        <!--RIGHT SIDE--------------------------------------->
        <div  class=""col-4"">

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da942a6356ee85946bb5460f7360628aa476d8ce6533", async() => {
                WriteLiteral("\r\n         ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da942a6356ee85946bb5460f7360628aa476d8ce6800", async() => {
                    WriteLiteral("\r\n             ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da942a6356ee85946bb5460f7360628aa476d8ce7081", async() => {
                        WriteLiteral("Matieres");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\progs\asp core\miniProjet1\Pages\View\Presence\TauxAbs.cshtml"
                     foreach (var item in @Model.SL)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da942a6356ee85946bb5460f7360628aa476d8ce9326", async() => {
#nullable restore
#line 39 "D:\progs\asp core\miniProjet1\Pages\View\Presence\TauxAbs.cshtml"
                                                        Write(item.matiere.nom);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "D:\progs\asp core\miniProjet1\Pages\View\Presence\TauxAbs.cshtml"
                           WriteLiteral(item.matiere.id_mat);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 40 "D:\progs\asp core\miniProjet1\Pages\View\Presence\TauxAbs.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 35 "D:\progs\asp core\miniProjet1\Pages\View\Presence\TauxAbs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Mid);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>


<div  class=""col-10"">

<div class=""box-body"">  
  
        <div class=""chart-container"">  
            <canvas id=""chart"" style=""width:100%; height:500px""></canvas>  
        </div>  
    </div>  
</div>
    </div>
  </div>
  <script type=""text/javascript"">  
        $(function () {  
    var chartName = ""chart"";  
        var ctx = document.getElementById(chartName).getContext('2d');  
        var data = {  
                labels: ");
#nullable restore
#line 62 "D:\progs\asp core\miniProjet1\Pages\View\Presence\TauxAbs.cshtml"
                   Write(Html.Raw(XLabels));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",  
                datasets: [{  
                    label: ""Presence Chart"",  
                    backgroundColor: [  
                        'rgba(255, 99, 132, 0.2)',  
                        'rgba(54, 162, 235, 0.2)',  
                        'rgba(255, 206, 86, 0.2)',  
                        'rgba(75, 192, 192, 0.2)',  
                        'rgba(153, 102, 255, 0.2)',  
                        'rgba(255, 159, 64, 0.2)',  
                        'rgba(255, 0, 0)',  
                        'rgba(0, 255, 0)',  
                        'rgba(0, 0, 255)',  
                        'rgba(192, 192, 192)',  
                        'rgba(255, 255, 0)',  
                        'rgba(255, 0, 255)'  
                    ],  
                    borderColor: [  
                        'rgba(255,99,132,1)',  
                        'rgba(54, 162, 235, 1)',  
                        'rgba(255, 206, 86, 1)',  
                        'rgba(75, 192, 192, 1)',  
                    ");
            WriteLiteral(@"    'rgba(153, 102, 255, 1)',  
                        'rgba(255, 159, 64, 1)',  
                        'rgba(255, 0, 0)',  
                        'rgba(0, 255, 0)',  
                        'rgba(0, 0, 255)',  
                        'rgba(192, 192, 192)',  
                        'rgba(255, 255, 0)',  
                        'rgba(255, 0, 255)'  
                    ],  
                    borderWidth: 1,  
                    data: ");
#nullable restore
#line 94 "D:\progs\asp core\miniProjet1\Pages\View\Presence\TauxAbs.cshtml"
                     Write(Html.Raw(YValues));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
    }]  
            };  
  
var options = { 
    responsive: true,
    legend: {
      position: 'left',
    },
    title: {
      display: true,
      text: '                                 Taux d\'Absence par Matiere'
    },
    animation: {
      animateScale: true,
      animateRotate: true
    },
    tooltips: {
      callbacks: {
        label: function(tooltipItem, data) {
        	var dataset = data.datasets[tooltipItem.datasetIndex];
          var total = dataset.data.reduce(function(previousValue, currentValue, currentIndex, array) {
            return previousValue + currentValue;
          });
          var currentValue = dataset.data[tooltipItem.index];
          var percentage = Math.floor(((currentValue/total) * 100)+0.5);         
          return percentage + ""%"";
        }
      }
    }  
            };  

            
  
       var myChart = new  Chart(ctx, {  
                options: options,  
                data: data,  
                type:'p");
            WriteLiteral("ie\'  \r\n  \r\n            });  \r\n        });  \r\n</script>  \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<miniProjet1.Pages.TauxAbsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<miniProjet1.Pages.TauxAbsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<miniProjet1.Pages.TauxAbsModel>)PageContext?.ViewData;
        public miniProjet1.Pages.TauxAbsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
