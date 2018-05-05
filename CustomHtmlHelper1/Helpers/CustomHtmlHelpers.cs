using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace CustomHtmlHelper1.Helpers
{
    public static class CustomHtmlHelpers
    {
        public static MvcHtmlString CustomLabelFor<TModel, TValue>(this HtmlHelper<TModel> html, 
                                                                        Expression<Func<TModel, TValue>> expression, 
                                                                        object htmlAttributes = null)
        {
            return html.LabelFor(expression, null, htmlAttributes);
        }
    }
}