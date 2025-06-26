using System.ComponentModel.DataAnnotations;

namespace Kickstart.Models.Pages
{
    [ContentType(
        DisplayName = "Metadata Head",
        Description = "Metadata Head",
        GroupName = "Metadata",
        GUID = "770F8F5C-E55C-44C8-BFBE-9BC70CC01813")]
    public class MetadataHead : PageData
    {
        [Display(
            Name = "Page Title",
            GroupName = "SEO",
            Order = 10)]
        public virtual string? PageTitle { get; set; }
        [Display(
            Name = "Meta Description",
            GroupName = "SEO",
            Order = 20)]
        public virtual string? MetaDescription { get; set; }
        [Display(
            Name = "Keywords",
            GroupName = "SEO",
            Order = 30)]
        public virtual string? Keywords { get; set; }
    }
}
