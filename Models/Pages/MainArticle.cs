using System.ComponentModel.DataAnnotations;

namespace Kickstart.Models.Pages
{
    [ContentType(
        DisplayName = "Main Article",
        Description = "Main Article",
        GroupName = "Main Article",
        GUID = "E82E046E-E515-4E11-8E7F-3C8F6E53273A"
        )]
    public class MainArticle : MetadataHead
    {
        [Display(
            Name = "Headline",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? Headline { get; set; }
    }
}
