//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftwareIncModMaker.Properties.DataSources
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeatureModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FeatureModel()
        {
            this.FeatureDependencies = new HashSet<FeatureDependency>();
        }
    
        public int Id { get; set; }
        public string SubFeatureName { get; set; }
        public string SubFeatureDescription { get; set; }
        public string SubFeatureSoftwareCategory { get; set; }
        public Nullable<decimal> SubFeatureUnlock { get; set; }
        public Nullable<decimal> SubFeatureUsability { get; set; }
        public Nullable<decimal> SubFeatureInnovation { get; set; }
        public Nullable<decimal> SubFeatureDevTime { get; set; }
        public Nullable<decimal> SubFeatureCodeArt { get; set; }
        public string SubFeatureDepedency { get; set; }
    
        public virtual SoftwareTypeModel SoftwareTypeModel { get; set; }
        public virtual FeatureAttributes FeatureAttributes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeatureDependency> FeatureDependencies { get; set; }
        public virtual FeatureSoftwareCategory FeatureSoftwareCategories { get; set; }
    }
}
