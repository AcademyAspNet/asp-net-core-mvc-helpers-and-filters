using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;

namespace AspNetCoreMvcHelpers.Helpers.Html
{
    public static class BootstrapHtmlHelpers
    {
        public static IHtmlContent BootstrapLabelFor<TModel, TValue>(
            this IHtmlHelper<TModel> htmlHelper, 
            Expression<Func<TModel, TValue>> expression
        )
        {
            return htmlHelper.LabelFor(expression, htmlAttributes: new { @class = "form-label" });
        }

        public static IHtmlContent BootstrapValidationMessageFor<TModel, TValue>(
            this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TValue>> expression
        )
        {
            return htmlHelper.ValidationMessageFor(expression, string.Empty, new { @class = "text-danger" });
        }

        public static IHtmlContent BootstrapSubmit(
            this IHtmlHelper htmlHelper,
            string buttonText = "Отправить",
            string iconId = "bi-send"
        )
        {
            TagBuilder button = new TagBuilder("button");
            button.Attributes.Add("class", "btn btn-primary");
            button.Attributes.Add("type", "submit");

            TagBuilder icon = new TagBuilder("i");
            icon.Attributes.Add("class", $"bi {iconId} me-2");
            button.InnerHtml.AppendHtml(icon);

            TagBuilder span = new TagBuilder("span");
            span.InnerHtml.Append(buttonText);
            button.InnerHtml.AppendHtml(span);

            return button;
        }
    }
}
