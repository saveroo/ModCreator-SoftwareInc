using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SoftwareIncModMaker
{
    public partial class TabularEditorForm : Form
    {
        public static BindingList<SoftwareTypeClass> test1DList = new BindingList<SoftwareTypeClass>();
        public static List<List<List<SoftwareTypeClass>>> test3DList = new List<List<List<SoftwareTypeClass>>>();
        public static List<List<SoftwareTypeClass>> test2DList = new List<List<SoftwareTypeClass>>();

        BindingList<SoftwareTypeClass> testBindingList = new BindingList<SoftwareTypeClass>();
        public static SoftwareTypeClass st = new SoftwareTypeClass();
        public static SoftwareTypeClass ft = new SoftwareTypeClass();
        public static SoftwareTypeClass ct = new SoftwareTypeClass();

        BindingSource bs = new BindingSource();


        public TabularEditorForm()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            bs.DataSource = test1DList;
            listBox1.DisplayMember = "RootName";
            listBox1.ValueMember = "RootDescription";
            listBox1.DataSource = bs;
        }

        private void TabularEditorForm_Load(object sender, EventArgs e)
        {
            
            //XMLController.IterateFromXML(@"C:\\Games\\Steam\\steamapps\\common\\Software Inc\test.xml");
        }

        private void createNewSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void autoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void autoLabel7_Click(object sender, EventArgs e)
        {

        }

        private void ctPopularityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxExt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ftSubmitButton_Click(object sender, EventArgs e)
        {

            iterateFeature().ForEach(item => listView1.Items.Add(new ListViewItem(item.SubFeatureName)));
            //iterateFeature().ForEach(item => ];
            //var a = listView1.Items[listView1.Items.IndexOfKey().Text;
        }
        private void ctButtonSubmit_Click(object sender, EventArgs e)
        {
            listView1.Groups.Add(new ListViewGroup("testhgroup"));
            listView1.Groups.Add(new ListViewGroup("adasd"));

            listView1.Groups[0].Header = stClass().RootName;
            listView1.Groups[1].Header = stClass().RootName;


            iterateCategory();
        }
        private void stSubmitButton_Click(object sender, EventArgs e)
        {
     
            string[] arr = new String[2];
            arr[0] = stClass().RootName;
            arr[1] = stClass().RootDescription;

            SoftwareTypeClass a = new SoftwareTypeClass(stNameTextBox.Text, stDescriptionTextBox.Text);
            // CreateListViewItem(listView1, a);
            //AddToListBox(listBox1, a);
            bs.Add(a);
            AddTo1DList(a);
            SoftwareTypeClass C = new SoftwareTypeClass();
            SoftwareTypeClass cC = new SoftwareTypeClass();
            
            tabPage6.Text = SoftwareTypeClass.getActiveInstance().ToString();


        }

        private void allGenerate_Click(object sender, EventArgs e)
        {
            listView1.Groups.Add(new ListViewGroup(stNameTextBox.Text, HorizontalAlignment.Left));
            //listView1.Items[0].Group = listView1.Groups[0];
            

            List<List<SoftwareTypeClass>> groupList = new List<List<SoftwareTypeClass>>();
        }


        private SoftwareTypeClass ctClass()
        {
            
            SoftwareTypeClass ct = new SoftwareTypeClass();

            ct.ParentCategories = "Categories";
            ct.SubCategory = "Category";
            ct.SubCategoryDescription = ctDescriptionTextBox.Text;
            ct.AttrName = ctNameTextBox.Text;
            ct.SubCategoryNameGenerator = ctNameGenerator.Text;
            ct.SubCategoryIterative = ctIterativeBox.Value;
            ct.SubCategoryPopularity = ctPopularityBox.Value;
            ct.SubCategoryRetention = ctRetentionBox.Value;
            ct.SubCategoryTimeScale = ctTimeScaleBox.Value;
            ct.SubCategoryUnlock = ctUnlockBox.Value;
            return ct;
        }

        private List<SoftwareTypeClass> iterateCategory()
        {

            List<SoftwareTypeClass> categoryList = new List<SoftwareTypeClass>();
            categoryList.Add(ctClass());
            return categoryList;
        }

        private SoftwareTypeClass stClass()
        {
            //SoftwareTypeClass st = new SoftwareTypeClass();

            st.RootName = stNameTextBox.Text;
            st.RootDescription = stDescriptionTextBox.Text;
            st.RootOneClient = stOneClient.Checked;
            st.RootInHouse = stInHouse.Checked;
            st.RootIterative = stIterativeBox.Value;
            st.RootOSSpecific = stOSSpecific.Checked;
            st.RootPopularity = stPopularity.Value;
            st.RootOSLimit = stOSLimit.Text;
            return st;
        }

        private List<SoftwareTypeClass> iterateSoftwareType()
        {
           
            List<SoftwareTypeClass> SoftwareTypeList = new List<SoftwareTypeClass>();
            SoftwareTypeList.Add(stClass());
            return SoftwareTypeList;
        }

        private SoftwareTypeClass ftClass()
        {
            SoftwareTypeClass ft = new SoftwareTypeClass();

            //attribute
            ft.AttributeForced = ftAttrForced.Checked;
            ft.AttributeResearch = ftAttrResearch.Checked;
            ft.AttributeVital = ftAttrVital.Checked;
            ft.AttributeFrom = ftAttrFrom.Text;

            ft.SubFeatureName = ftName.Text;
            ft.SubFeatureServer = ftServerBox.Value;
            ft.SubFeatureInnovation = ftInnovationBox.Value;
            //ft.SubFeatureDependency  = 
            ft.SubFeatureCodeArt = ftCodeArtBox.Value;
            ft.SubFeatureStability = ftStabilityBox.Value;
            ft.SubFeatureUsability = ftUsabilityBox.Value;
            ft.SubFeatureDevtime = ftDevTimeBox.Value;
            ft.SubFeatureUnlock = ftUnlockBox.Value;
            return ft;
        }

        private List<SoftwareTypeClass> iterateFeature()
        {

            List<SoftwareTypeClass> featureList = new List<SoftwareTypeClass>();
            featureList.Add(ftClass());
            return featureList;
        }

        public void AddFeatureToBindingList(
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
           String attrcategory)
        {

           // testBindingList.Add(attrName);

//            attributeFrom = atFr;
//            attributeForced = atFo;
//            attributeVital = atVi;
//            attributeResearch = false;
//            subFeatureName = name;
//            subFeatureDescription = desc;
//            subFeatureArtCategory = ArtCategory;
//            subFeatureUnlock = unlock;
//            subFeatureDevtime = devtime;
//            subFeatureInnovation = innovation;
//            subFeatureUsability = usability;
//            subFeatureStability = stability;
//            subFeatureCodeArt = codeart;
//            subFeatureDependency = dependency;
//            subFeatureServer = server;
//            subFeatureSoftwareCategory = softwareCategory;
//            subAttrCategory = attrcategory;
        }

        private void editControl1_Load(object sender, EventArgs e)
        {

        }

        private void AddTo1DList(SoftwareTypeClass boom)
        {
            test1DList.Add(boom);
        }
        private void AddToListBox(ListBox box, SoftwareTypeClass obj)
        {
            ListBox item = new ListBox();
            item.Text = obj.RootName;
            item.Tag = obj;

            
            //box.Items.Add(item);
        }
        private void CreateListViewItem(ListView listView, SoftwareTypeClass obj)
        {
            ListViewItem item = new ListViewItem();
            item.Text = obj.RootName;
            item.Tag = obj;

            listView.Items.Add(item);
        }

        private void addTo1D(SoftwareTypeClass boom)
        {
            test1DList.Add(boom);
        }

        private void addTo2D(List<SoftwareTypeClass> boom)
        {
            test2DList.Add(boom);
           
        }
        private void addTo3D(List<List<SoftwareTypeClass>> boom)
        {
            test3DList.Add(boom);           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void btnSubmitToList_Click(object sender, EventArgs e)
        {
            listView1.Columns.Add("Software Name", 100);
            string[] arr = new String[2];
            arr[0] = stClass().RootName;
            //arr[1] = stClass().RootDescription;
            
            listView1.Columns.Add("Description", 100);
            listView1.Items.Add(new ListViewItem(arr));
        }

        private void gridDataBoundGrid1_CellClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Add(listBox1.SelectedValue.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tabPage6.Text = SoftwareTypeClass.getActiveInstance().ToString();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void addToDependencyList_TextChanged(object sender, EventArgs e)
        {

        }

        private void addToDependencyComboList_Click(object sender, EventArgs e)
        {
            ftDependencyComboBox.Items.Add(addToDependencyList.Text);
        }
    }
}
