namespace HtmlCreater
{
    public enum HtmlTagType
    {
        DIV,
        BODY,
        BUTTON
    }
    public class HtmlTag
    {
        private const string divFormat = "<div class=\"{2}\" style=\"{3}\">{0}{1}</div>";
        public HtmlTagType TagType { get; set; }
        public string Value { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public string InnerHtml { get; set; }
        public List<HtmlTag> InsideTag { get; set; } = new List<HtmlTag>();

        public HtmlTag AddChildren(HtmlTag htmlTag)
        {
            InsideTag.Add(htmlTag);
            return this;
        }

        public string GetTextHtml()
        {
            return string.Format(divFormat, Value, GetChildrenHtml(), Class, Style);
        }

        private string GetChildrenHtml()
        {
            var result = string.Empty;
            if (InsideTag.Count > 0)
            {
                foreach (HtmlTag htmlTag in InsideTag)
                {
                    result += htmlTag.GetTextHtml();
                }
            }
            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var html = new HtmlTag()
            {
                Class = "my-class",
                TagType = HtmlTagType.DIV,
                Style = "display:flex;"
            }.AddChildren(
                new HtmlTag()
                {
                    Style = "display:flex;"
                }
                .AddChildren(new HtmlTag()
                {
                    Value = "InsideTag blue",
                    Style = "background:blue;"
                })
                .AddChildren(new HtmlTag()
                {
                    Value = "next inside green",
                    Style = "background:green;"
                }
                ))
              .AddChildren(new HtmlTag() { Value = "next inside tag", Style = "background:red;" });

            var text = html.GetTextHtml();
        }
    }
}