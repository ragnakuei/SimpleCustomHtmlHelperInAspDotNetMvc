using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomHtmlHelper1.Models
{
    public class TestViewModel
    {
        [DisplayName("Name in TestViewModel")]
        public string Name { get; set; }
    }
}