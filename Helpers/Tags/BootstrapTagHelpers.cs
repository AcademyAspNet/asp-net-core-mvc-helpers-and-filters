using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreMvcHelpers.Helpers.Tags
{
    [HtmlTargetElement("submit")]
    public class BootstrapTagHelpers : TagHelper
    {
        public string? Icon { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.Add("class", "btn btn-primary");

            output.Content.Append("Отправить");

            if (Icon is not null)
            {
                TagBuilder icon = new TagBuilder("i");
                icon.Attributes.Add("class", $"bi {Icon} ms-2");
                output.Content.AppendHtml(icon);
            }
        }
    }
}
