namespace SoftwareIncModMaker
{
    using System.ComponentModel;
    using System.Threading;

    public class SoftwareTypeClassBackup
    {
        public static SoftwareTypeClassBackup StaticSoftwareType = new SoftwareTypeClassBackup();

        private static int instances;

        private bool attributeForced;

        private string attributeFrom = string.Empty;

        private bool attributeResearch;

        private bool attributeVital;

        private string attrName = string.Empty;

        private string parentCategories = string.Empty;

        private string parentFeatures = string.Empty;

        private string parentSoftwareType = string.Empty;

        private string rootDelete = string.Empty;

        private string rootDescription = string.Empty;

        private bool rootInHouse;

        private decimal rootIterative;

        private string rootName = string.Empty;

        private bool rootOneClient;

        private string rootOsLimit = string.Empty;

        private bool rootOsSpecific;

        private decimal rootPopularity;

        private decimal rootRandom;

        private string rootRetention = string.Empty;

        private decimal rootUnlock;

        private string subAttrCategory = string.Empty;

        private string subCategory = string.Empty;

        private string subCategoryDescription = string.Empty;

        private decimal subCategoryIterative = 0;

        private string subCategoryNameGenerator = string.Empty;

        private decimal subCategoryPopularity = 0;

        private decimal subCategoryRetention = 0;

        private decimal subCategoryTimeScale = 0;

        private decimal subCategoryUnlock = 0;

        private string subFeature = string.Empty;

        private string subFeatureArtCategory = string.Empty;

        private decimal subFeatureCodeArt;

        private string subFeatureDependency = string.Empty;

        private string subFeatureDescription = string.Empty;

        private decimal subFeatureDevtime;

        private decimal subFeatureInnovation;

        private string subFeatureName = string.Empty;

        private decimal subFeatureServer;

        private string subFeatureSoftwareCategory = string.Empty;

        private decimal subFeatureStability;

        private decimal subFeatureUnlock;

        private decimal subFeatureUsability;

        // private BindingList<SoftwareTypeClassBackup> FeatureList;
        public SoftwareTypeClassBackup()
        {
            Interlocked.Increment(ref instances);
        }

        public SoftwareTypeClassBackup(
            string attrName,
            string parentCategories,
            string subCategory,
            string subCategoryDescription,
            decimal subCategoryUnlock,
            decimal subCategoryPopularity,
            decimal subCategoryTimeScale,
            decimal subCategoryRetention,
            decimal subCategoryIterative,
            string subCategoryNameGenerator)
        {
            this.AttrName = attrName;
            this.ParentCategories = parentCategories;
            this.SubCategory = subCategory;
            this.SubCategoryDescription = subCategoryDescription;
            this.SubCategoryUnlock = subCategoryUnlock;
            this.SubCategoryPopularity = subCategoryPopularity;
            this.SubCategoryTimeScale = subCategoryTimeScale;
            this.SubCategoryRetention = subCategoryRetention;
            this.SubCategoryIterative = subCategoryIterative;
            this.SubCategoryNameGenerator = subCategoryNameGenerator;
        }

        public SoftwareTypeClassBackup(
            string parentSoftwareType,
            string rootName,
            string rootDelete,
            decimal rootUnlock,
            decimal rootRandom,
            decimal rootPopularity,
            string rootRetention,
            decimal rootIterative,
            bool rootOsSpecific,
            bool rootOneClient,
            bool rootInHouse,
            string rootOsLimit)
        {
            this.ParentSoftwareType = parentSoftwareType;
            this.RootName = rootName;
            this.RootDelete = rootDelete;
            this.RootUnlock = rootUnlock;
            this.RootRandom = rootRandom;
            this.RootPopularity = rootPopularity;
            this.RootRetention = rootRetention;
            this.RootIterative = rootIterative;
            this.RootOsSpecific = rootOsSpecific;
            this.RootOneClient = rootOneClient;
            this.RootInHouse = rootInHouse;
            this.RootOsLimit = rootOsLimit;
        }

        public SoftwareTypeClassBackup(
            string attributeFrom,
            bool attributeForced,
            bool attributeVital,
            bool attributeResearch,
            string parentFeatures,
            string subFeature,
            string subFeatureName,
            string subFeatureDescription,
            string subFeatureArtCategory,
            decimal subFeatureUnlock,
            decimal subFeatureDevtime,
            decimal subFeatureInnovation,
            decimal subFeatureUsability,
            decimal subFeatureStability,
            decimal subFeatureCodeArt,
            string subFeatureDependency,
            decimal subFeatureServer,
            string subFeatureSoftwareCategory)
        {
            this.AttributeFrom = attributeFrom;
            this.AttributeForced = attributeForced;
            this.AttributeVital = attributeVital;
            this.AttributeResearch = attributeResearch;
            this.ParentFeatures = parentFeatures;
            this.SubFeature = subFeature;
            this.SubFeatureName = subFeatureName;
            this.SubFeatureDescription = subFeatureDescription;
            this.SubFeatureArtCategory = subFeatureArtCategory;
            this.SubFeatureUnlock = subFeatureUnlock;
            this.SubFeatureDevtime = subFeatureDevtime;
            this.SubFeatureInnovation = subFeatureInnovation;
            this.SubFeatureUsability = subFeatureUsability;
            this.SubFeatureStability = subFeatureStability;
            this.SubFeatureCodeArt = subFeatureCodeArt;
            this.SubFeatureDependency = subFeatureDependency;
            this.SubFeatureServer = subFeatureServer;
            this.SubFeatureSoftwareCategory = subFeatureSoftwareCategory;
        }

        public SoftwareTypeClassBackup(
            string parentSoftwareType,
            string rootName,
            string rootDelete,
            decimal rootUnlock,
            decimal rootRandom,
            decimal rootPopularity,
            string rootRetention,
            decimal rootIterative,
            bool rootOsSpecific,
            bool rootOneClient,
            bool rootInHouse,
            string rootOsLimit,
            string attributeFrom,
            bool attributeForced,
            bool attributeVital,
            bool attributeResearch,
            string parentFeatures,
            string subFeature,
            string subFeatureName,
            string subFeatureDescription,
            string subFeatureArtCategory,
            decimal subFeatureUnlock,
            decimal subFeatureDevtime,
            decimal subFeatureInnovation,
            decimal subFeatureUsability,
            decimal subFeatureStability,
            decimal subFeatureCodeArt,
            string subFeatureDependency,
            decimal subFeatureServer,
            string subFeatureSoftwareCategory,
            string attrName,
            string parentCategories,
            string subCategory,
            string subCategoryDescription,
            decimal subCategoryUnlock,
            decimal subCategoryPopularity,
            decimal subCategoryTimeScale,
            decimal subCategoryRetention,
            decimal subCategoryIterative,
            string subCategoryNameGenerator)
        {
            this.ParentSoftwareType = parentSoftwareType;
            this.RootName = rootName;
            this.RootDelete = rootDelete;
            this.RootUnlock = rootUnlock;
            this.RootRandom = rootRandom;
            this.RootPopularity = rootPopularity;
            this.RootRetention = rootRetention;
            this.RootIterative = rootIterative;
            this.RootOsSpecific = rootOsSpecific;
            this.RootOneClient = rootOneClient;
            this.RootInHouse = rootInHouse;
            this.RootOsLimit = rootOsLimit;
            this.AttributeFrom = attributeFrom;
            this.AttributeForced = attributeForced;
            this.AttributeVital = attributeVital;
            this.AttributeResearch = attributeResearch;
            this.ParentFeatures = parentFeatures;
            this.SubFeature = subFeature;
            this.SubFeatureName = subFeatureName;
            this.SubFeatureDescription = subFeatureDescription;
            this.SubFeatureArtCategory = subFeatureArtCategory;
            this.SubFeatureUnlock = subFeatureUnlock;
            this.SubFeatureDevtime = subFeatureDevtime;
            this.SubFeatureInnovation = subFeatureInnovation;
            this.SubFeatureUsability = subFeatureUsability;
            this.SubFeatureStability = subFeatureStability;
            this.SubFeatureCodeArt = subFeatureCodeArt;
            this.SubFeatureDependency = subFeatureDependency;
            this.SubFeatureServer = subFeatureServer;
            this.SubFeatureSoftwareCategory = subFeatureSoftwareCategory;
            this.AttrName = attrName;
            this.ParentCategories = parentCategories;
            this.SubCategory = subCategory;
            this.SubCategoryDescription = subCategoryDescription;
            this.SubCategoryUnlock = subCategoryUnlock;
            this.SubCategoryPopularity = subCategoryPopularity;
            this.SubCategoryTimeScale = subCategoryTimeScale;
            this.SubCategoryRetention = subCategoryRetention;
            this.SubCategoryIterative = subCategoryIterative;
            this.SubCategoryNameGenerator = subCategoryNameGenerator;
        }

        public SoftwareTypeClassBackup(
            string atFr,
            bool atFo,
            bool atVi,
            bool atRe,
            string name,
            string desc,
            string artCategory,
            decimal unlock,
            decimal devtime,
            decimal innovation,
            decimal usability,
            decimal stability,
            decimal codeart,
            string dependency,
            decimal server,
            string softwareCategory,
            string attrcategory)
            : this()
        {
            // BindingList<T> testBindingList = new BindingList<T>();
            // testBindingList.Add(attrName);
            this.attributeFrom = atFr;
            this.attributeForced = atFo;
            this.attributeVital = atVi;
            this.attributeResearch = atRe;
            this.subFeatureName = name;
            this.subFeatureDescription = desc;
            this.subFeatureArtCategory = artCategory;
            this.subFeatureUnlock = unlock;
            this.subFeatureDevtime = devtime;
            this.subFeatureInnovation = innovation;
            this.subFeatureUsability = usability;
            this.subFeatureStability = stability;
            this.subFeatureCodeArt = codeart;
            this.subFeatureDependency = dependency;
            this.subFeatureServer = server;
            this.subFeatureSoftwareCategory = softwareCategory;
            this.subAttrCategory = attrcategory;
        }

        public SoftwareTypeClassBackup(string a, string b)
        {
            this.RootName = a;
            this.RootDescription = b;
        }

        ~SoftwareTypeClassBackup()
        {
            Interlocked.Decrement(ref instances);
        }

        public bool AttributeForced { get => attributeForced; set => attributeForced = value; }

        public string AttributeFrom { get => attributeFrom; set => attributeFrom = value; }

        public bool AttributeResearch { get => attributeResearch; set => attributeResearch = value; }

        public bool AttributeVital { get => attributeVital; set => attributeVital = value; }

        public string AttrName { get => attrName; set => attrName = value; }

        public string ParentCategories { get => parentCategories; set => parentCategories = value; }

        public string ParentFeatures { get => parentFeatures; set => parentFeatures = value; }

        public string ParentSoftwareType { get => parentSoftwareType; set => parentSoftwareType = value; }

        public string RootDelete { get => rootDelete; set => rootDelete = value; }

        public string RootDescription { get => rootDescription; set => rootDescription = value; }

        public bool RootInHouse { get => rootInHouse; set => rootInHouse = value; }

        public decimal RootIterative { get => rootIterative; set => rootIterative = value; }

        public string RootName { get => rootName; set => rootName = value; }

        public bool RootOneClient { get => rootOneClient; set => rootOneClient = value; }

        public string RootOsLimit { get => rootOSLimit; set => rootOSLimit = value; }

        public bool RootOsSpecific { get => rootOSSpecific; set => rootOSSpecific = value; }

        public decimal RootPopularity { get => rootPopularity; set => rootPopularity = value; }

        public decimal RootRandom { get => rootRandom; set => rootRandom = value; }

        public string RootRetention { get => rootRetention; set => rootRetention = value; }

        public decimal RootUnlock { get => rootUnlock; set => rootUnlock = value; }

        public string SubAttrCategory { get => subAttrCategory; set => subAttrCategory = value; }

        public string SubCategory { get => subCategory; set => subCategory = value; }

        public string SubCategoryDescription { get => subCategoryDescription; set => subCategoryDescription = value;
        }

        public decimal SubCategoryIterative { get => subCategoryIterative; set => subCategoryIterative = value; }

        public string SubCategoryNameGenerator { get => subCategoryNameGenerator; set => subCategoryNameGenerator =
            value; }

        public decimal SubCategoryPopularity { get => subCategoryPopularity; set => subCategoryPopularity = value; }

        public decimal SubCategoryRetention { get => subCategoryRetention; set => subCategoryRetention = value; }

        public decimal SubCategoryTimeScale { get => subCategoryTimeScale; set => subCategoryTimeScale = value; }

        public decimal SubCategoryUnlock { get => subCategoryUnlock; set => subCategoryUnlock = value; }

        public string SubFeature { get => subFeature; set => subFeature = value; }

        public string SubFeatureArtCategory { get => subFeatureArtCategory; set => subFeatureArtCategory = value; }

        public decimal SubFeatureCodeArt { get => subFeatureCodeArt; set => subFeatureCodeArt = value; }

        public string SubFeatureDependency { get => subFeatureDependency; set => subFeatureDependency = value; }

        public string SubFeatureDescription { get => subFeatureDescription; set => subFeatureDescription = value; }

        public decimal SubFeatureDevtime { get => subFeatureDevtime; set => subFeatureDevtime = value; }

        public decimal SubFeatureInnovation { get => subFeatureInnovation; set => subFeatureInnovation = value; }

        public string SubFeatureName { get => subFeatureName; set => subFeatureName = value; }

        public decimal SubFeatureServer { get => subFeatureServer; set => subFeatureServer = value; }

        public string SubFeatureSoftwareCategory { get => subFeatureSoftwareCategory; set =>
            subFeatureSoftwareCategory = value; }

        public decimal SubFeatureStability { get => subFeatureStability; set => subFeatureStability = value; }

        public decimal SubFeatureUnlock { get => subFeatureUnlock; set => subFeatureUnlock = value; }

        public decimal SubFeatureUsability { get => subFeatureUsability; set => subFeatureUsability = value; }

        public static int GetActiveInstance()
        {
            return instances;
        }

        public void AddFeature(
            string attributeFrom,
            bool attributeForced,
            bool attributeVital,
            bool attributeResearch,
            string parentFeatures,
            string subFeature,
            string subFeatureName,
            string subFeatureDescription,
            string subFeatureArtCategory,
            decimal subFeatureUnlock,
            decimal subFeatureDevtime,
            decimal subFeatureInnovation,
            decimal subFeatureUsability,
            decimal subFeatureStability,
            decimal subFeatureCodeArt,
            string subFeatureDependency,
            decimal subFeatureServer,
            string subFeatureSoftwareCategory,
            string subAttrCategory)
        {
            this.attributeFrom = attributeFrom;
            this.attributeForced = attributeForced;
            this.attributeVital = attributeVital;
            this.attributeResearch = attributeResearch;
            this.parentFeatures = parentFeatures;
            this.subFeature = subFeature;
            this.subFeatureName = subFeatureName;
            this.subFeatureDescription = subFeatureDescription;
            this.subFeatureArtCategory = subFeatureArtCategory;
            this.subFeatureUnlock = subFeatureUnlock;
            this.subFeatureDevtime = subFeatureDevtime;
            this.subFeatureInnovation = subFeatureInnovation;
            this.subFeatureUsability = subFeatureUsability;
            this.subFeatureStability = subFeatureStability;
            this.subFeatureCodeArt = subFeatureCodeArt;
            this.subFeatureDependency = subFeatureDependency;
            this.subFeatureServer = subFeatureServer;
            this.subFeatureSoftwareCategory = subFeatureSoftwareCategory;
            this.subAttrCategory = subAttrCategory;
        }

        public void AddRoot(
            string rootName,
            string rootDelete,
            decimal rootUnlock,
            decimal rootRandom,
            decimal rootPopularity,
            string rootRetention,
            decimal rootIterative,
            string rootDescription,
            bool rootOsSpecific,
            bool rootOneClient,
            bool rootInHouse,
            string rootOsLimit)
        {
            this.rootName = rootName;
            this.rootDelete = rootDelete;
            this.rootUnlock = rootUnlock;
            this.rootRandom = rootRandom;
            this.rootPopularity = rootPopularity;
            this.rootRetention = rootRetention;
            this.rootIterative = rootIterative;
            this.rootDescription = rootDescription;
            this.rootOsSpecific = rootOsSpecific;
            this.rootOneClient = rootOneClient;
            this.rootInHouse = rootInHouse;
            this.rootOsLimit = rootOsLimit;
        }
    }

    public class BaseSoftwareType
    {
        private static int instances;

        public BaseSoftwareType()
        {
            Interlocked.Increment(ref instances);
        }

        ~BaseSoftwareType()
        {
            Interlocked.Decrement(ref instances);
        }

        public static int GetActiveInstance()
        {
            return instances;
        }
    }

    public class SoftwareType : BaseSoftwareType
    {
        // ,IEnumerable<SoftwareType>
        public static SoftwareTypeClassBackup StaticSoftwareType = new SoftwareTypeClassBackup();

        public BindingList<Category> ChildrenCategories;

        private BindingList<Feature> newCollection = new BindingList<Feature>();

        // private BindingList<SoftwareType> softwareType;
        private BindingList<BindingList<Feature>> newCollectionOfCollection =
            new BindingList<BindingList<Feature>>();

        private string rootDelete = string.Empty;

        private BindingList<BindingList<Feature>> childrenFeatures;

        private string parentSoftwareType = string.Empty;

        private string rootDescription = string.Empty;

        private bool rootInHouse = false;

        private decimal rootIterative = 0;

        private string rootName = string.Empty;

        private bool rootOneClient = false;

        private string rootOsLimit = string.Empty;

        private bool rootOsSpecific = false;

        private decimal rootPopularity = 0;

        private decimal rootRandom = 0;

        private decimal rootRetention = 0;

        private decimal rootUnlock = 0;

        public SoftwareType()
        {
        }

        public SoftwareType(SoftwareType c)
        {
        }

        // public IEnumerator<SoftwareType> GetEnumerator()
        // {
        // foreach (var contact in softwareType)
        // yield return contact;
        // }
        // IEnumerator IEnumerable.GetEnumerator()
        // {
        // return GetEnumerator();
        // }
        public SoftwareType(
            string rootName,
            decimal rootUnlock,
            decimal rootRandom,
            decimal rootPopularity,
            decimal rootRetention,
            decimal rootIterative,
            string rootDescription,
            bool rootOsSpecific,
            bool rootOneClient,
            bool rootInHouse,
            string rootOsLimit)
        {
            this.RootName = rootName;
            this.RootDelete = this.rootDelete;
            this.RootUnlock = rootUnlock;
            this.RootRandom = rootRandom;
            this.RootPopularity = rootPopularity;
            this.RootRetention = rootRetention;
            this.RootIterative = rootIterative;
            this.RootDescription = rootDescription;
            this.RootOsSpecific = rootOsSpecific;
            this.RootOneClient = rootOneClient;
            this.RootInHouse = rootInHouse;
            this.RootOsLimit = rootOsLimit;
        }

        public BindingList<BindingList<Feature>> ChildrenFeatures { get => childrenFeatures; set =>
            childrenFeatures = value; }

        public string ParentSoftwareType { get => parentSoftwareType; set => parentSoftwareType = value; }

        public string RootDelete { get => rootDelete; set => rootDelete = value; }

        public string RootDescription { get => rootDescription; set => rootDescription = value; }

        public bool RootInHouse { get => rootInHouse; set => rootInHouse = value; }

        public decimal RootIterative { get => rootIterative; set => rootIterative = value; }

        public string RootName { get => rootName; set => rootName = value; }

        public bool RootOneClient { get => rootOneClient; set => rootOneClient = value; }

        public string RootOsLimit { get => rootOSLimit; set => rootOSLimit = value; }

        public bool RootOsSpecific { get => rootOSSpecific; set => rootOSSpecific = value; }

        public decimal RootPopularity { get => rootPopularity; set => rootPopularity = value; }

        public decimal RootRandom { get => rootRandom; set => rootRandom = value; }

        public decimal RootRetention { get => rootRetention; set => rootRetention = value; }

        public decimal RootUnlock { get => rootUnlock; set => rootUnlock = value; }

        public void AddFeature(Feature listFeature)
        {
            this.newCollection.Add(listFeature);
            this.newCollectionOfCollection.Add(this.newCollection);
            this.ChildrenFeatures = this.newCollectionOfCollection;
        }
    }

    public class Feature : SoftwareType
    {
        private bool attributeForced;

        private string attributeFrom = string.Empty;

        private bool attributeResearch;

        private bool attributeVital;

        private SoftwareType belongsTo;

        private string subAttrCategory = string.Empty;

        private string subFeatureArtCategory = string.Empty;

        private decimal subFeatureCodeArt;

        private string subFeatureDependency = string.Empty;

        private string subFeatureDescription = string.Empty;

        private decimal subFeatureDevtime;

        private decimal subFeatureInnovation;

        // private String parentFeatures = String.Empty;
        // private String subFeature = String.Empty;
        private string subFeatureName = string.Empty;

        private decimal subFeatureServer;

        private string subFeatureSoftwareCategory = string.Empty;

        private decimal subFeatureStability;

        private decimal subFeatureUnlock;

        private decimal subFeatureUsability;

        public Feature()
        {
        }

        public Feature(SoftwareType belongsTo)
        {
        }

        public Feature(
            SoftwareType belongsTo,
            string attributeFrom,
            bool attributeForced,
            bool attributeVital,
            bool attributeResearch,
            string subFeatureName,
            string subFeatureDescription,
            string subFeatureArtCategory,
            decimal subFeatureUnlock,
            decimal subFeatureDevtime,
            decimal subFeatureInnovation,
            decimal subFeatureUsability,
            decimal subFeatureStability,
            decimal subFeatureCodeArt,
            string subFeatureDependency,
            decimal subFeatureServer,
            string subFeatureSoftwareCategory,
            string subAttrCategory)
        {
            this.attributeFrom = attributeFrom;
            this.attributeForced = attributeForced;
            this.attributeVital = attributeVital;
            this.attributeResearch = attributeResearch;
            this.subFeatureName = subFeatureName;
            this.subFeatureDescription = subFeatureDescription;
            this.subFeatureArtCategory = subFeatureArtCategory;
            this.subFeatureUnlock = subFeatureUnlock;
            this.subFeatureDevtime = subFeatureDevtime;
            this.subFeatureInnovation = subFeatureInnovation;
            this.subFeatureUsability = subFeatureUsability;
            this.subFeatureStability = subFeatureStability;
            this.subFeatureCodeArt = subFeatureCodeArt;
            this.subFeatureDependency = subFeatureDependency;
            this.subFeatureServer = subFeatureServer;
            this.subFeatureSoftwareCategory = subFeatureSoftwareCategory;
            this.subAttrCategory = subAttrCategory;
            this.BelongsTo = belongsTo;
        }

        public bool AttributeForced { get => attributeForced; set => attributeForced = value; }

        public string AttributeFrom { get => attributeFrom; set => attributeFrom = value; }

        public bool AttributeResearch { get => attributeResearch; set => attributeResearch = value; }

        public bool AttributeVital { get => attributeVital; set => attributeVital = value; }

        public SoftwareType BelongsTo { get => belongsTo; set => belongsTo = value; }

        public string SubAttrCategory { get => subAttrCategory; set => subAttrCategory = value; }

        public string SubFeatureArtCategory { get => subFeatureArtCategory; set => subFeatureArtCategory = value; }

        public decimal SubFeatureCodeArt { get => subFeatureCodeArt; set => subFeatureCodeArt = value; }

        public string SubFeatureDependency { get => subFeatureDependency; set => subFeatureDependency = value; }

        public string SubFeatureDescription { get => subFeatureDescription; set => subFeatureDescription = value; }

        public decimal SubFeatureDevtime { get => subFeatureDevtime; set => subFeatureDevtime = value; }

        public decimal SubFeatureInnovation { get => subFeatureInnovation; set => subFeatureInnovation = value; }

        public string SubFeatureName { get => subFeatureName; set => subFeatureName = value; }

        public decimal SubFeatureServer { get => subFeatureServer; set => subFeatureServer = value; }

        public string SubFeatureSoftwareCategory { get => subFeatureSoftwareCategory; set =>
            subFeatureSoftwareCategory = value; }

        public decimal SubFeatureStability { get => subFeatureStability; set => subFeatureStability = value; }

        public decimal SubFeatureUnlock { get => subFeatureUnlock; set => subFeatureUnlock = value; }

        public decimal SubFeatureUsability { get => subFeatureUsability; set => subFeatureUsability = value; }

        public Feature GetInstance()
        {
            return this;
        }
    }

    public class Category : SoftwareType
    {
        private string attrName = string.Empty;

        // private String parentCategories = String.Empty;
        private SoftwareType belongsTo;

        private string subCategory = string.Empty;

        private string subCategoryDescription = string.Empty;

        private decimal subCategoryIterative = 0;

        private string subCategoryNameGenerator = string.Empty;

        private decimal subCategoryPopularity = 0;

        private decimal subCategoryRetention = 0;

        private decimal subCategoryTimeScale = 0;

        private decimal subCategoryUnlock = 0;

        public Category()
        {
        }

        public Category(
            SoftwareType belongsTo,
            string attrName,
            string subCategory,
            string subCategoryDescription,
            decimal subCategoryUnlock,
            decimal subCategoryPopularity,
            decimal subCategoryTimeScale,
            decimal subCategoryRetention,
            decimal subCategoryIterative,
            string subCategoryNameGenerator)
        {
            this.BelongsTo = belongsTo;
            this.AttrName = attrName;
            this.SubCategory = subCategory;
            this.SubCategoryDescription = subCategoryDescription;
            this.SubCategoryUnlock = subCategoryUnlock;
            this.SubCategoryPopularity = subCategoryPopularity;
            this.SubCategoryTimeScale = subCategoryTimeScale;
            this.SubCategoryRetention = subCategoryRetention;
            this.SubCategoryIterative = subCategoryIterative;
            this.SubCategoryNameGenerator = subCategoryNameGenerator;
        }

        public string AttrName { get => attrName; set => attrName = value; }

        public SoftwareType BelongsTo { get => belongsTo; set => belongsTo = value; }

        public string SubCategory { get => subCategory; set => subCategory = value; }

        public string SubCategoryDescription { get => subCategoryDescription; set => subCategoryDescription = value;
        }

        public decimal SubCategoryIterative { get => subCategoryIterative; set => subCategoryIterative = value; }

        public string SubCategoryNameGenerator { get => subCategoryNameGenerator; set => subCategoryNameGenerator =
            value; }

        public decimal SubCategoryPopularity { get => subCategoryPopularity; set => subCategoryPopularity = value; }

        public decimal SubCategoryRetention { get => subCategoryRetention; set => subCategoryRetention = value; }

        public decimal SubCategoryTimeScale { get => subCategoryTimeScale; set => subCategoryTimeScale = value; }

        public decimal SubCategoryUnlock { get => subCategoryUnlock; set => subCategoryUnlock = value; }
    }
}