using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreMvcHelpers.Helpers.Tags
{
    [HtmlTargetElement("bootstrap-button")]
    public class ButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.Add("class", "btn btn-primary");
        }
    }
}
