using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace SoftwareIncModMaker
{
    public class SoftwareTypeClassBackup
    {
        public static readonly SoftwareTypeClassBackup staticSoftwareType = new SoftwareTypeClassBackup();
        public string ParentSoftwareType { get => parentSoftwareType; set => parentSoftwareType = value; }
        public string RootName { get => rootName; set => rootName = value; }
        public string RootDelete { get => rootDelete; set => rootDelete = value; }
        public decimal RootUnlock { get => rootUnlock; set => rootUnlock = value; }
        public decimal RootRandom { get => rootRandom; set => rootRandom = value; }
        public decimal RootPopularity { get => rootPopularity; set => rootPopularity = value; }
        public string RootRetention { get => rootRetention; set => rootRetention = value; }
        public decimal RootIterative { get => rootIterative; set => rootIterative = value; }
        public bool RootOSSpecific { get => rootOSSpecific; set => rootOSSpecific = value; }
        public bool RootOneClient { get => rootOneClient; set => rootOneClient = value; }
        public bool RootInHouse { get => rootInHouse; set => rootInHouse = value; }
        public string RootOSLimit { get => rootOSLimit; set => rootOSLimit = value; }
        public string AttributeFrom { get => attributeFrom; set => attributeFrom = value; }
        public bool AttributeForced { get => attributeForced; set => attributeForced = value; }
        public bool AttributeVital { get => attributeVital; set => attributeVital = value; }
        public bool AttributeResearch { get => attributeResearch; set => attributeResearch = value; }
        public string ParentFeatures { get => parentFeatures; set => parentFeatures = value; }
        public string SubFeature { get => subFeature; set => subFeature = value; }
        public string SubFeatureName { get => subFeatureName; set => subFeatureName = value; }
        public string SubFeatureDescription { get => subFeatureDescription; set => subFeatureDescription = value; }
        public string SubFeatureArtCategory { get => subFeatureArtCategory; set => subFeatureArtCategory = value; }
        public decimal SubFeatureUnlock { get => subFeatureUnlock; set => subFeatureUnlock = value; }
        public decimal SubFeatureDevtime { get => subFeatureDevtime; set => subFeatureDevtime = value; }
        public decimal SubFeatureInnovation { get => subFeatureInnovation; set => subFeatureInnovation = value; }
        public decimal SubFeatureUsability { get => subFeatureUsability; set => subFeatureUsability = value; }
        public decimal SubFeatureStability { get => subFeatureStability; set => subFeatureStability = value; }
        public decimal SubFeatureCodeArt { get => subFeatureCodeArt; set => subFeatureCodeArt = value; }
        public string SubFeatureDependency { get => subFeatureDependency; set => subFeatureDependency = value; }
        public decimal SubFeatureServer { get => subFeatureServer; set => subFeatureServer = value; }
        public string SubFeatureSoftwareCategory { get => subFeatureSoftwareCategory; set => subFeatureSoftwareCategory = value; }
        public string AttrName { get => attrName; set => attrName = value; }
        public string ParentCategories { get => parentCategories; set => parentCategories = value; }
        public string SubCategory { get => subCategory; set => subCategory = value; }
        public string SubCategoryDescription { get => subCategoryDescription; set => subCategoryDescription = value; }
        public decimal SubCategoryUnlock { get => subCategoryUnlock; set => subCategoryUnlock = value; }
        public decimal SubCategoryPopularity { get => subCategoryPopularity; set => subCategoryPopularity = value; }
        public decimal SubCategoryTimeScale { get => subCategoryTimeScale; set => subCategoryTimeScale = value; }
        public decimal SubCategoryRetention { get => subCategoryRetention; set => subCategoryRetention = value; }
        public decimal SubCategoryIterative { get => subCategoryIterative; set => subCategoryIterative = value; }
        public string SubCategoryNameGenerator { get => subCategoryNameGenerator; set => subCategoryNameGenerator = value; }
        public string SubAttrCategory { get => subAttrCategory; set => subAttrCategory = value; }
        public string RootDescription { get => rootDescription; set => rootDescription = value; }

        private String parentSoftwareType = String.Empty;
        private String rootName = String.Empty;
        private String rootDelete = String.Empty;
        private decimal rootUnlock = 0;
        private decimal rootRandom = 0;
        private decimal rootPopularity = 0;
        private String rootRetention = String.Empty;
        private decimal rootIterative = 0;
        private String rootDescription = String.Empty;
        private bool rootOSSpecific = false;
        private bool rootOneClient = false;
        private bool rootInHouse = false;
        private String rootOSLimit = String.Empty;

        private String attributeFrom = String.Empty;
        private bool attributeForced = false;
        private bool attributeVital = false;
        private bool attributeResearch = false;
        private String parentFeatures = String.Empty;
            private String subFeature = String.Empty;
                private String subFeatureName = String.Empty;
                private String subFeatureDescription = String.Empty;
                private String subFeatureArtCategory = String.Empty;
                private decimal subFeatureUnlock = 0;
                private decimal subFeatureDevtime = 0;
                private decimal subFeatureInnovation   = 0;
                private decimal subFeatureUsability    = 0;
                private decimal subFeatureStability    = 0;
                private decimal subFeatureCodeArt = 0;
                private String subFeatureDependency = String.Empty;
                private decimal subFeatureServer = 0;
                private String subFeatureSoftwareCategory = String.Empty;
                private String subAttrCategory = String.Empty;

        private String attrName = String.Empty;
        private String parentCategories = String.Empty;
            private String subCategory = String.Empty;
                private String subCategoryDescription = String.Empty;
                private decimal subCategoryUnlock    =0;
                private decimal subCategoryPopularity=0;
                private decimal subCategoryTimeScale =0;
                private decimal subCategoryRetention =0;
                private decimal subCategoryIterative = 0;
                private String subCategoryNameGenerator = String.Empty;

        private static int _instances = 0; 

        private BindingList<SoftwareTypeClassBackup> FeatureList;

        public SoftwareTypeClassBackup()
        {
            Interlocked.Increment(ref _instances);
        }

        ~SoftwareTypeClassBackup()
        {
            Interlocked.Decrement(ref _instances);
        }

        public SoftwareTypeClassBackup(string attrName, string parentCategories, string subCategory, string subCategoryDescription, decimal subCategoryUnlock, decimal subCategoryPopularity, decimal subCategoryTimeScale, decimal subCategoryRetention, decimal subCategoryIterative, string subCategoryNameGenerator)
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

        public SoftwareTypeClassBackup(string parentSoftwareType, string rootName, string rootDelete, decimal rootUnlock, decimal rootRandom, decimal rootPopularity, string rootRetention, decimal rootIterative, bool rootOSSpecific, bool rootOneClient, bool rootInHouse, string rootOSLimit)
        {
            this.ParentSoftwareType = parentSoftwareType;
            this.RootName = rootName;
            this.RootDelete = rootDelete;
            this.RootUnlock = rootUnlock;
            this.RootRandom = rootRandom;
            this.RootPopularity = rootPopularity;
            this.RootRetention = rootRetention;
            this.RootIterative = rootIterative;
            this.RootOSSpecific = rootOSSpecific;
            this.RootOneClient = rootOneClient;
            this.RootInHouse = rootInHouse;
            this.RootOSLimit = rootOSLimit;
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
            decimal subFeatureStability, decimal subFeatureCodeArt, string subFeatureDependency, decimal subFeatureServer, string subFeatureSoftwareCategory)
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

        public SoftwareTypeClassBackup(string parentSoftwareType, string rootName, string rootDelete, decimal rootUnlock, decimal rootRandom, decimal rootPopularity, string rootRetention, decimal rootIterative, bool rootOSSpecific, bool rootOneClient, bool rootInHouse, string rootOSLimit, string attributeFrom, bool attributeForced, bool attributeVital, bool attributeResearch, string parentFeatures, string subFeature, string subFeatureName, string subFeatureDescription, string subFeatureArtCategory, decimal subFeatureUnlock, decimal subFeatureDevtime, decimal subFeatureInnovation, decimal subFeatureUsability, decimal subFeatureStability, decimal subFeatureCodeArt, string subFeatureDependency, decimal subFeatureServer, string subFeatureSoftwareCategory, string attrName, string parentCategories, string subCategory, string subCategoryDescription, decimal subCategoryUnlock, decimal subCategoryPopularity, decimal subCategoryTimeScale, decimal subCategoryRetention, decimal subCategoryIterative, string subCategoryNameGenerator)
        {
            this.ParentSoftwareType = parentSoftwareType;
            this.RootName = rootName;
            this.RootDelete = rootDelete;
            this.RootUnlock = rootUnlock;
            this.RootRandom = rootRandom;
            this.RootPopularity = rootPopularity;
            this.RootRetention = rootRetention;
            this.RootIterative = rootIterative;
            this.RootOSSpecific = rootOSSpecific;
            this.RootOneClient = rootOneClient;
            this.RootInHouse = rootInHouse;
            this.RootOSLimit = rootOSLimit;
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
            String name, 
            String desc, 
            String ArtCategory, 
            decimal unlock,
            decimal devtime,
            decimal innovation,
            decimal usability,
            decimal stability,
            decimal codeart,
            String dependency,
            decimal server,
            String softwareCategory,
            String attrcategory) : this()
        {
           // BindingList<T> testBindingList = new BindingList<T>();
           // testBindingList.Add(attrName);
            attributeFrom = atFr;
            attributeForced = atFo;
            attributeVital = atVi;
            attributeResearch = atRe;
            subFeatureName = name;
            subFeatureDescription = desc;
            subFeatureArtCategory = ArtCategory;
            subFeatureUnlock = unlock;
            subFeatureDevtime = devtime;
            subFeatureInnovation = innovation;
            subFeatureUsability = usability;
            subFeatureStability = stability;
            subFeatureCodeArt = codeart;
            subFeatureDependency = dependency;
            subFeatureServer = server;
            subFeatureSoftwareCategory = softwareCategory;
            subAttrCategory = attrcategory;
        }

        public void AddFeature(string attributeFrom, bool attributeForced, bool attributeVital, bool attributeResearch, string parentFeatures, string subFeature, string subFeatureName, string subFeatureDescription, string subFeatureArtCategory, decimal subFeatureUnlock, decimal subFeatureDevtime, decimal subFeatureInnovation, decimal subFeatureUsability, decimal subFeatureStability, decimal subFeatureCodeArt, string subFeatureDependency, decimal subFeatureServer, string subFeatureSoftwareCategory, string subAttrCategory)
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

        public static int getActiveInstance() { return _instances; }

        public void AddRoot(string rootName, string rootDelete, decimal rootUnlock, decimal rootRandom, decimal rootPopularity, string rootRetention, decimal rootIterative, string rootDescription, bool rootOSSpecific, bool rootOneClient, bool rootInHouse, string rootOSLimit)
        {
            this.rootName = rootName;
            this.rootDelete = rootDelete;
            this.rootUnlock = rootUnlock;
            this.rootRandom = rootRandom;
            this.rootPopularity = rootPopularity;
            this.rootRetention = rootRetention;
            this.rootIterative = rootIterative;
            this.rootDescription = rootDescription;
            this.rootOSSpecific = rootOSSpecific;
            this.rootOneClient = rootOneClient;
            this.rootInHouse = rootInHouse;
            this.rootOSLimit = rootOSLimit;
        }

        public SoftwareTypeClassBackup(string a, string b)
        {
            this.RootName = a;
            this.RootDescription = b;
        }

    }

    public class BaseSoftwareType
    {

        private static int _instances = 0;

        public BaseSoftwareType()
        {

            Interlocked.Increment(ref _instances);
        }

        ~BaseSoftwareType()
        {
            Interlocked.Decrement(ref _instances);
        }

        public static int getActiveInstance() { return _instances; }


    }



    public class SoftwareType : BaseSoftwareType
        //,IEnumerable<SoftwareType>
    {
        public static readonly SoftwareTypeClassBackup staticSoftwareType = new SoftwareTypeClassBackup();

        private String parentSoftwareType = String.Empty;
        private String rootName = String.Empty;
        private String rootDelete = String.Empty;
        private decimal rootUnlock = 0;
        private decimal rootRandom = 0;
        private decimal rootPopularity = 0;
        private decimal rootRetention = 0;
        private decimal rootIterative = 0;
        private String rootDescription = String.Empty;
        private bool rootOSSpecific = false;
        private bool rootOneClient = false;
        private bool rootInHouse = false;
        private String rootOSLimit = String.Empty;
        public BindingList<Category> childrenCategories;
        private BindingList<BindingList<Feature>> childrenFeatures;
        //        private BindingList<SoftwareType> softwareType;
        BindingList<BindingList<Feature>> newCollectionOfCollection = new BindingList<BindingList<Feature>>();
        BindingList<Feature> newCollection = new BindingList<Feature>();

        public SoftwareType() : base()
        {
            
        }

        public SoftwareType(SoftwareType c) : base()
        {
            
        }

        public void addFeature(Feature listFeature)
        {
            
            newCollection.Add(listFeature);
            newCollectionOfCollection.Add(newCollection);
            ChildrenFeatures = newCollectionOfCollection;
        }

//        public IEnumerator<SoftwareType> GetEnumerator()
//        {
//            foreach (var contact in softwareType)
//                yield return contact;
//        }
//
//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }

        public SoftwareType(string rootName, decimal rootUnlock,
            decimal rootRandom, decimal rootPopularity, decimal rootRetention, decimal rootIterative,
            string rootDescription, bool rootOSSpecific, bool rootOneClient, bool rootInHouse, string rootOSLimit)
            
        {
            this.RootName = rootName;
            this.RootDelete = rootDelete;
            this.RootUnlock = rootUnlock;
            this.RootRandom = rootRandom;
            this.RootPopularity = rootPopularity;
            this.RootRetention = rootRetention;
            this.RootIterative = rootIterative;
            this.RootDescription = rootDescription;
            this.RootOSSpecific = rootOSSpecific;
            this.RootOneClient = rootOneClient;
            this.RootInHouse = rootInHouse;
            this.RootOSLimit = rootOSLimit;
        }

        public string ParentSoftwareType { get => parentSoftwareType; set => parentSoftwareType = value; }
        public string RootName { get => rootName; set => rootName = value; }
        public string RootDelete { get => rootDelete; set => rootDelete = value; }
        public decimal RootUnlock { get => rootUnlock; set => rootUnlock = value; }
        public decimal RootRandom { get => rootRandom; set => rootRandom = value; }
        public decimal RootPopularity { get => rootPopularity; set => rootPopularity = value; }
        public decimal RootRetention { get => rootRetention; set => rootRetention = value; }
        public decimal RootIterative { get => rootIterative; set => rootIterative = value; }
        public string RootDescription { get => rootDescription; set => rootDescription = value; }
        public bool RootOSSpecific { get => rootOSSpecific; set => rootOSSpecific = value; }
        public bool RootOneClient { get => rootOneClient; set => rootOneClient = value; }
        public bool RootInHouse { get => rootInHouse; set => rootInHouse = value; }
        public string RootOSLimit { get => rootOSLimit; set => rootOSLimit = value; }
        public BindingList<BindingList<Feature>> ChildrenFeatures { get => childrenFeatures; set => childrenFeatures = value; }
    }

    public class Feature : SoftwareType
    {
        private SoftwareType belongsTo;
        private String attributeFrom = String.Empty;
        private bool attributeForced = false;
        private bool attributeVital = false;
        private bool attributeResearch = false;
        //private String parentFeatures = String.Empty;
        //private String subFeature = String.Empty;
        private String subFeatureName = String.Empty;
        private String subFeatureDescription = String.Empty;
        private String subFeatureArtCategory = String.Empty;
        private decimal subFeatureUnlock = 0;
        private decimal subFeatureDevtime = 0;
        private decimal subFeatureInnovation = 0;
        private decimal subFeatureUsability = 0;
        private decimal subFeatureStability = 0;
        private decimal subFeatureCodeArt = 0;
        private String subFeatureDependency = String.Empty;
        private decimal subFeatureServer = 0;
        private String subFeatureSoftwareCategory = String.Empty;
        private String subAttrCategory = String.Empty;

        public Feature() : base()
        {
            
        }

        public Feature(SoftwareType belongsTo) : base()
        {

        }

        public Feature getInstance()
        {
            return this;
        }

        public Feature(SoftwareType belongsTo, string attributeFrom, bool attributeForced, bool attributeVital, bool attributeResearch, string subFeatureName, string subFeatureDescription, string subFeatureArtCategory, decimal subFeatureUnlock, decimal subFeatureDevtime, decimal subFeatureInnovation, decimal subFeatureUsability, decimal subFeatureStability, decimal subFeatureCodeArt, string subFeatureDependency, decimal subFeatureServer, string subFeatureSoftwareCategory, string subAttrCategory)
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

        public string AttributeFrom { get => attributeFrom; set => attributeFrom = value; }
        public bool AttributeForced { get => attributeForced; set => attributeForced = value; }
        public bool AttributeVital { get => attributeVital; set => attributeVital = value; }
        public bool AttributeResearch { get => attributeResearch; set => attributeResearch = value; }
        public string SubFeatureName { get => subFeatureName; set => subFeatureName = value; }
        public string SubFeatureDescription { get => subFeatureDescription; set => subFeatureDescription = value; }
        public string SubFeatureArtCategory { get => subFeatureArtCategory; set => subFeatureArtCategory = value; }
        public decimal SubFeatureUnlock { get => subFeatureUnlock; set => subFeatureUnlock = value; }
        public decimal SubFeatureDevtime { get => subFeatureDevtime; set => subFeatureDevtime = value; }
        public decimal SubFeatureInnovation { get => subFeatureInnovation; set => subFeatureInnovation = value; }
        public decimal SubFeatureUsability { get => subFeatureUsability; set => subFeatureUsability = value; }
        public decimal SubFeatureStability { get => subFeatureStability; set => subFeatureStability = value; }
        public decimal SubFeatureCodeArt { get => subFeatureCodeArt; set => subFeatureCodeArt = value; }
        public string SubFeatureDependency { get => subFeatureDependency; set => subFeatureDependency = value; }
        public decimal SubFeatureServer { get => subFeatureServer; set => subFeatureServer = value; }
        public string SubFeatureSoftwareCategory { get => subFeatureSoftwareCategory; set => subFeatureSoftwareCategory = value; }
        public string SubAttrCategory { get => subAttrCategory; set => subAttrCategory = value; }
        public SoftwareType BelongsTo { get => belongsTo; set => belongsTo = value; }
    }

    public class Category : SoftwareType
    {
        //private String parentCategories = String.Empty;
        private SoftwareType belongsTo;


        private String attrName = String.Empty;
        private String subCategory = String.Empty;
        private String subCategoryDescription = String.Empty;
        private decimal subCategoryUnlock = 0;
        private decimal subCategoryPopularity = 0;
        private decimal subCategoryTimeScale = 0;
        private decimal subCategoryRetention = 0;
        private decimal subCategoryIterative = 0;
        private String subCategoryNameGenerator = String.Empty;

        public Category() : base()
        {
            
        }

        public Category(SoftwareType belongsTo, string attrName, string subCategory, string subCategoryDescription, decimal subCategoryUnlock, decimal subCategoryPopularity, decimal subCategoryTimeScale, decimal subCategoryRetention, decimal subCategoryIterative, string subCategoryNameGenerator)
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

        public SoftwareType BelongsTo { get => belongsTo; set => belongsTo = value; }
        public string AttrName { get => attrName; set => attrName = value; }
        public string SubCategory { get => subCategory; set => subCategory = value; }
        public string SubCategoryDescription { get => subCategoryDescription; set => subCategoryDescription = value; }
        public decimal SubCategoryUnlock { get => subCategoryUnlock; set => subCategoryUnlock = value; }
        public decimal SubCategoryPopularity { get => subCategoryPopularity; set => subCategoryPopularity = value; }
        public decimal SubCategoryTimeScale { get => subCategoryTimeScale; set => subCategoryTimeScale = value; }
        public decimal SubCategoryRetention { get => subCategoryRetention; set => subCategoryRetention = value; }
        public decimal SubCategoryIterative { get => subCategoryIterative; set => subCategoryIterative = value; }
        public string SubCategoryNameGenerator { get => subCategoryNameGenerator; set => subCategoryNameGenerator = value; }
    }
}
