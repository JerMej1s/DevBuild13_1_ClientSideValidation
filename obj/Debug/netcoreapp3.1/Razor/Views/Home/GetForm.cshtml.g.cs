#pragma checksum "C:\DevBuild\Week13\Week13\Lab13_1_ClientSideValidation\Views\Home\GetForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "939b9502eb26302d1e602ddc1e34bbd4d3af6f80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetForm), @"mvc.1.0.view", @"/Views/Home/GetForm.cshtml")]
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
#nullable restore
#line 1 "C:\DevBuild\Week13\Week13\Lab13_1_ClientSideValidation\Views\_ViewImports.cshtml"
using Lab13_1_ClientSideValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DevBuild\Week13\Week13\Lab13_1_ClientSideValidation\Views\_ViewImports.cshtml"
using Lab13_1_ClientSideValidation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"939b9502eb26302d1e602ddc1e34bbd4d3af6f80", @"/Views/Home/GetForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4be00024d350fc9aea9dc24f5dd86cfeb89adeb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("MyForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UseForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\DevBuild\Week13\Week13\Lab13_1_ClientSideValidation\Views\Home\GetForm.cshtml"
  
    ViewData["Title"] = "GetForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetForm</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "939b9502eb26302d1e602ddc1e34bbd4d3af6f804460", async() => {
                WriteLiteral(@"
    <fieldset>
        <legend>Please complete this form.</legend>
        <div>
            <label for=""FirstName"">First name:</label>
            <input type=""text"" name=""FirstName"" id=""FirstName"" />
            <span class=""text-warning"" id=""FirstNameInvalid""></span>
        </div>
        <div>
            <label for=""LastName"">Last name:</label>
            <input type=""text"" name=""LastName"" id=""LastName"" />
            <span class=""text-warning"" id=""LastNameInvalid""></span>
        </div>
        <div>
            <label for=""Email"">Email:</label>
            <input type=""text"" name=""Email"" id=""Email"" />
            <span class=""text-warning"" id=""EmailInvalid""></span>
        </div>
        <div>
            <label for=""Password"">Password:</label>
            <input type=""text"" name=""Password"" id=""Password"" />
            <span class=""text-warning"" id=""PasswordInvalid""></span>
        </div>
        <div>
            <label for=""ConfirmPassword"">Confirm password:</label>
      ");
                WriteLiteral(@"      <input type=""text"" name=""ConfirmPassword"" id=""ConfirmPassword"" />
            <span class=""text-warning"" id=""ConfirmPasswordInvalid""></span>
        </div>
        <div>
            <input type=""submit"" value=""Submit"" />
        </div>
    </fieldset>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
//const { isNumeric } = require(""jquery"");

//const { isNumeric } = require(""jquery"");

    let myForm = document.querySelector('#MyForm');

    function validateForm() {
        let firstName = document.querySelector('#FirstName').value;
        let lastName = document.querySelector('#LastName').value;
        let email = document.querySelector('#Email').value;
        let password = document.querySelector('#Password').value;
        let confirmPassword = document.querySelector('#ConfirmPassword').value;

        let result = true;

        // Check first name
        if (firstName.length < 2) {
            document.querySelector('#FirstNameInvalid').innerHTML = 'First name must contain at least two characters.';
            result = false;
        }

        // Check last name
        if (lastName.length < 2) {
            document.querySelector('#LastNameInvalid').innerHTML = 'Last name must contain at least two characters.';
            result = false;
        }

 ");
            WriteLiteral("       // Check email\r\n        if (email.indexOf(\'.\') == -1 || email.indexOf(\'");
            WriteLiteral(@"@') == -1) {
            document.querySelector('#EmailInvalid').innerHTML = 'Please enter a valid email address.';
            result = false;
        }

        // Check password
        let upperCaseCount = 0;
        let lowerCaseCount = 0;
        let numericCount = 0;
        let symbolCount = 0;

        for (let i = 0; i < password.length; i++) {
            character = password.charAt(i);

            if (character == character.toUpperCase()) {
                upperCaseCount++;
            }

            if (character == character.toLowerCase()) {
                lowerCaseCount++;
            }

            if (character >= 0 && character <= 9) {
                numericCount++;
            }

            let symbols = /[!");
            WriteLiteral(@"@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]+/;
            if (symbols.test(character)) {
                symbolCount++;
            }
        }
        
        if (upperCaseCount == 0 || lowerCaseCount == 0 || numericCount == 0 || symbolCount == 0) {
            document.querySelector('#PasswordInvalid').innerHTML = 'Password must contain at least one: uppercase letter, lowercase letter, number, and symbol.'
            result = false;
        }

        // Check confirm password
        if (password != confirmPassword) {
            document.querySelector('#ConfirmPasswordInvalid').innerHTML = 'Passwords must match.'
            result = false;
        }

        return result;
    }

    myForm.addEventListener('submit', function (ev) {
        if (!validateForm()) {
            console.log('Validation failed, skipping submit.');
            ev.preventDefault();
        }
    });
</script>");
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
