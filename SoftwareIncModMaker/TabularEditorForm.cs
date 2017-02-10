using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EnvDTE;
using SoftwareIncModMaker.Class;
using SoftwareIncModMaker.Properties.DataSources;
using System.Data.Entity;
using RestSharp.Extensions;


namespace SoftwareIncModMaker
{
    public partial class TabularEditorForm : Form
    {
        public static BindingList<SoftwareType> test1DList = new BindingList<SoftwareType>();
        public static BindingList<Feature> featureBindingList = new BindingList<Feature>();
        public static List<List<List<SoftwareTypeClassBackup>>> test3DList = new List<List<List<SoftwareTypeClassBackup>>>();
        public static List<List<SoftwareTypeClassBackup>> test2DList = new List<List<SoftwareTypeClassBackup>>();
        //public static BindingList<BindingList<Feature>> groupBinding = new BindingList<BindingList<Feature>>();
        //        BindingList<BindingList<Feature>> groupBinding = new BindingList<BindingList<Feature>>();
        //        BindingList<Feature> bindingOfFeature = new BindingList<Feature>();
        public SoftwareTypeModel2Container SoftwareTypeContext = new SoftwareTypeModel2Container();


        BindingList<SoftwareTypeClassBackup> testBindingList = new BindingList<SoftwareTypeClassBackup>();
       // public static SoftwareType st = new SoftwareType();
       // public static Feature ft = new Feature();
        //public static Category ct = new Category();
        

        BindingSource softwareTypeBindingSource = new BindingSource();
        BindingSource featureBindingSource = new BindingSource();


        public TabularEditorForm()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();

////            softwareTypeBindingSource.DataSource = test1DList;
//            listBox1.DisplayMember = "RootName";
//            listBox1.ValueMember = "RootDescription";
//            listBox1.DataSource = softwareTypeBS;
//
////            featureBindingSource.DataSource = featureBindingList;
//            listBox2.DisplayMember = "subFeatureName";
//            listBox2.ValueMember = "RootName";
//            listBox2.DataSource = childFeaturesBS;
        }

        private void TabularEditorForm_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            
            //XMLController.IterateFromXML(@"C:\\Games\\Steam\\steamapps\\common\\Software Inc\test.xml");
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

        private int instanceOfFeature()
        {
            var a = (listBox1.SelectedItem as SoftwareType);
            if (a.ChildrenFeatures != null)
            {
                return a.ChildrenFeatures.Count;
            }
            return 0;
        }

//        private Feature instanceOfFeature(SoftwareType st)
//        {
//            var a = (listBox1.SelectedItem as SoftwareType);
//            if (a.ChildrenFeatures != null)
//            {
//                foreach (BindingList<Feature> bf in st.ChildrenFeatures)
//                {
//                    foreach (Feature ft in bf)
//                    {
//                        return ft
//                    }
//                }
//            }
//        }
        private Feature instanceOfFeature(int index, ListView st)
        {
            if (st.SelectedItems.Count > 0)
            {
                return (Feature)st.SelectedItems[index].Tag;
            }
            return null;
        }

//        private Feature instanceListFromFeature(SoftwareType st)
//        {
////            var a = (listBox1.SelectedItem as SoftwareType);
////            if (a.ChildrenFeatures != null)
////            {
////                foreach (BindingList<Feature> bf in st.ChildrenFeatures)
////                {
////                    if (bf != null)
////                    {
////                        foreach (Feature ft in bf)
////                        {
////                            return ft;
////                        }
////                    }
////                }
////            }
////            return null;
//        }
        private void ftSubmitButton_Click(object sender, EventArgs e)
        {
            //            var currentInstance = (BindingList<BindingList<Feature>>)softwareTypeBindingSource.GetItemProperties(null)["RootName"].GetValue(softwareTypeBindingSource.Current);
            var selectedInstance = softwareTypeBS.Current;
            if (selectedInstance != null)
            {
                MessageBox.Show("selectedinstance is not null");
                Feature newFeature = new Feature(
                    listBox1.SelectedItem as SoftwareType,
                    ftAttrFrom.Text,
                    ftAttrForced.BoolValue,
                    ftAttrVital.BoolValue,
                    ftAttrResearch.BoolValue,
                    ftName.Text,
                    ftDescription.Text,
                    ftCategory.Text,
                    ftUnlockBox.Value,
                    ftDevTimeBox.Value,
                    ftInnovationBox.Value,
                    ftUsabilityBox.Value,
                    ftStabilityBox.Value,
                    ftCodeArtBox.Value,
                    ftDependencyFeature.Text,
                    ftServerBox.Value,
                    ftCategory.Text,
                    ftAttrVital.Text
                 );
               var a = (SoftwareType)softwareTypeBS.Current;
                a.addFeature(newFeature);
                childFeaturesBS.Add(newFeature);
                MessageBox.Show(a.ChildrenFeatures.Count.ToString());
//                var x = new FeatureModel();
                

            }
//            if (selectedInstance != null)
//            {
//                Feature newFeature = new Feature(
//                    listBox1.SelectedItem as SoftwareType,
//                    ftAttrFrom.Text,
//                    ftAttrForced.BoolValue,
//                    ftAttrVital.BoolValue,
//                    ftAttrResearch.BoolValue,
//                    ftName.Text,
//                    ftDescription.Text,
//                    ftCategory.Text,
//                    ftUnlockBox.Value,
//                    ftDevTimeBox.Value,
//                    ftInnovationBox.Value,
//                    ftUsabilityBox.Value,
//                    ftStabilityBox.Value,
//                    ftCodeArtBox.Value,
//                    ftDependencyFeature.Text,
//                    ftServerBox.Value,
//                    ftCategory.Text,
//                    ftAttrVital.Text
//                );
//                BindingList<BindingList<Feature>> groupBinding = new BindingList<BindingList<Feature>>();
//                BindingList<Feature> bindingOfFeature = new BindingList<Feature>();
//                bindingOfFeature.Add(newFeature);
//                var objectList = (listBox1.SelectedItem as SoftwareType);
//                groupBinding.Add(bindingOfFeature);
//                if (objectList.ChildrenFeatures != null)
//                {
//                    var objNew = (listBox1.SelectedItem as SoftwareType);
//                    objNew.ChildrenFeatures.Add(bindingOfFeature);
//                    MessageBox.Show(instanceOfFeature().ToString());
//
//                }
//                if (objectList != null && objectList.ChildrenFeatures == null)
//                {
//                    objectList.ChildrenFeatures = groupBinding;
//                    MessageBox.Show(instanceOfFeature().ToString());
//                }
//            }

            //            var currentInstance = (BindingList<BindingList<Feature>>)softwareTypeBindingSource.GetItemProperties(null)["ChildrenFeatures"].GetValue(softwareTypeBindingSource.Current);
            //            currentInstance.Where()
            //            MessageBox.Show(currentInstance.Count.ToString());


            //            Feature newFeature = new Feature(
            //                listBox1.SelectedItem as SoftwareType,
            //                ftAttrFrom.Text,
            //                ftAttrForced.BoolValue,
            //                ftAttrVital.BoolValue,
            //                ftAttrResearch.BoolValue,
            //                ftName.Text,
            //                ftDescription.Text,
            //                ftCategory.Text,
            //                ftUnlockBox.Value,
            //                ftDevTimeBox.Value,
            //                ftInnovationBox.Value,
            //                ftUsabilityBox.Value,
            //                ftStabilityBox.Value,
            //                ftCodeArtBox.Value,
            //                ftDependencyFeature.Text,
            //                ftServerBox.Value,
            //                ftCategory.Text,
            //                ftAttrVital.Text
            //                );
            //            BindingList<BindingList<Feature>> groupBinding = new BindingList<BindingList<Feature>>();
            //            BindingList<Feature> bindingOfFeature = new BindingList<Feature>();
            //            bindingOfFeature.Add(newFeature);
            //
            //            var ax = (softwareTypeBindingSource.Current as SoftwareType).ChildrenFeatures;
            //            SoftwareType a = listBox1.SelectedItem as SoftwareType;
            //            MessageBox.Show(softwareTypeBindingSource.Current.ToString());
            //            for (int i = 0; i < instanceOfFeature(); i++)
            //            {
            //                BindingList<BindingList<Feature>> groupBinding = new BindingList<BindingList<Feature>>();
            //                groupBinding.Add(bindingOfFeature);
            //            }
            //            //softwareTypeBindingSource.Add(newFeature);
            //            if (listBox1.SelectedItem != null)
            //            {
            //                a.ChildrenFeatures = groupBinding;
            //
            //            }

        }
        private void ctButtonSubmit_Click(object sender, EventArgs e)
        {
//            listView1.Groups.Add(new ListViewGroup("testhgroup"));
//            listView1.Groups.Add(new ListViewGroup("adasd"));

//            listView1.Groups[0].Header = stClass().RootName;
//            listView1.Groups[1].Header = stClass().RootName;


            iterateCategory();
        }
        private void stSubmitButton_Click(object sender, EventArgs e)
        {
            
            listView1.Clear();
            SoftwareType stForm = new SoftwareType(
                stNameTextBox.Text,
                stUnlock.Value,
                stRandom.Value,
                stPopularity.Value,
                stRetention.Value,
                stIterativeBox.Value,
                stDescriptionTextBox.Text,
                stOSSpecific.Checked,
                stOneClient.Checked,
                stInHouse.Checked,
                stOSLimit.Text);
            //SoftwareTypeClassBackup a = new SoftwareType(stNameTextBox.Text, stDescriptionTextBox.Text);
            // CreateListViewItem(listView1, a);
            //AddToListBox(listBox1, a);
            var softwareTypeData = new SoftwareTypeModel
            {
                RootName = stNameTextBox.Text,
                RootUnlock = stUnlock.Value,
                RootRandom = stRandom.Value,
                RootPopularity = stPopularity.Value,
                RootRetention = stRetention.Value,
                RootIterative = stIterativeBox.Value,
                RootDescription = stDescriptionTextBox.Text,
                RootOSSpecific = stOSSpecific.Checked,
                RootOneClient = stOneClient.Checked,
                RootInHouse = stInHouse.Checked,
                RootOSLimit = stOSLimit.Text
            };
            var a = new SoftwareTypeModel2Container();

                SoftwareTypeContext.SoftwareTypeModels.Add(softwareTypeData);
                SoftwareTypeContext.SaveChanges();
            

//            a.SoftwareTypeModels.Add(softwareTypeData);
            listBox1.DataSource = a.SoftwareTypeModels.ToList();
            listBox1.DisplayMember = "RootName";
            //softwareTypeBS.Add(softwareTypeData);
                //AddTo1DList(stForm);

            //tabPage6.Text = SoftwareType.getActiveInstance().ToString();


        }

        private void allGenerate_Click(object sender, EventArgs e)
        {
            listView1.Groups.Add(new ListViewGroup(stNameTextBox.Text, HorizontalAlignment.Left));
            //listView1.Items[0].Group = listView1.Groups[0];
            

            List<List<SoftwareTypeClassBackup>> groupList = new List<List<SoftwareTypeClassBackup>>();
        }


        private SoftwareTypeClassBackup ctClass()
        {
            
            SoftwareTypeClassBackup ct = new SoftwareTypeClassBackup();

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

        private List<SoftwareTypeClassBackup> iterateCategory()
        {

            List<SoftwareTypeClassBackup> categoryList = new List<SoftwareTypeClassBackup>();
            categoryList.Add(ctClass());
            return categoryList;
        }

        public dynamic stClass()
        {
//            BindingList<SoftwareType> st = new BindingList<SoftwareType>();

            //            st.RootName = stNameTextBox.Text;
            //            st.RootUnlock = stUnlock.Value;
            //            st.RootRandom = stRandom.Value;
            //            st.RootPopularity = stPopularity.Value;
            //            st.RootRetention = stRetention.Value;
            //            st.RootIterative = stIterativeBox.Value;
            //            st.RootDescription = stDescriptionTextBox.Text;
            //            st.RootOSSpecific = stOSSpecific.Checked;
            //            st.RootOneClient = stOneClient.Checked;
            //            st.RootInHouse = stInHouse.Checked;
            //            st.RootOSLimit = stOSLimit.Text;

      
//                st.RootName = stNameTextBox.Text;
//                st.RootUnlock = stUnlock.Value;
//                st.RootRandom = stRandom.Value;
//                st.RootPopularity = stPopularity.Value;
//                st.RootRetention = stRetention.Value;
//                st.RootIterative = stIterativeBox.Value;
//                st.RootDescription = stDescriptionTextBox.Text;
//                st.RootOSSpecific = stOSSpecific.Checked;
//                st.RootOneClient = stOneClient.Checked;
//                st.RootInHouse = stInHouse.Checked;
//                st.RootOSLimit = stOSLimit.Text;
//                return st;
            return null;
        }

        private List<SoftwareType> iterateSoftwareType()
        {
           
            List<SoftwareType> SoftwareTypeList = new List<SoftwareType>();
            SoftwareTypeList.Add(stClass());
            return SoftwareTypeList;
        }

        private SoftwareTypeClassBackup ftClass()
        {
            SoftwareTypeClassBackup ft = new SoftwareTypeClassBackup();

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

        private List<SoftwareTypeClassBackup> iterateFeature()
        {

            List<SoftwareTypeClassBackup> featureList = new List<SoftwareTypeClassBackup>();
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

        private void AddTo1DList(SoftwareType boom)
        {
            test1DList.Add(boom);
        }
        private void AddToListBox(ListBox box, SoftwareType obj)
        {
            ListBox item = new ListBox();
            item.Text = obj.RootName;
            item.Tag = obj;

            
            //box.Items.Add(item);
        }
        private void CreateListViewItem(ListView listView, Feature obj)
        {
            ListViewItem item = new ListViewItem();
            item.Text = obj.SubFeatureName;
            item.Tag = obj;

            listView.Items.Add(item);
        }
        private void CreateListViewItem(ListView listView, SoftwareType obj)
        {
            ListViewItem item = new ListViewItem();
            item.Text = obj.RootName;
            item.Tag = obj;

            listView.Items.Add(item);
        }
        private void CreateListViewItem(ListView listView, Category obj)
        {
            ListViewItem item = new ListViewItem();
            item.Text = obj.RootName;
            item.Tag = obj;

            listView.Items.Add(item);
        }

        private void addTo1D(SoftwareType boom)
        {
            test1DList.Add(boom);
        }

        private void addTo2D(List<SoftwareTypeClassBackup> boom)
        {
            test2DList.Add(boom);
           
        }
        private void addTo3D(List<List<SoftwareTypeClassBackup>> boom)
        {
            test3DList.Add(boom);           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
           
            MessageBox.Show(instanceOfFeature(e.Item.Index, listView1).SubFeatureDescription);
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
            listView1.Clear();
            var aa = (listBox1.SelectedItem as SoftwareType);
//            var rawSelectedItemAsSoftwareType = listBox1.SelectedItem as SoftwareType;

            if (aa != null)
            {
                if (aa.ChildrenFeatures != null)
                {
                    for (int i = 0; i < aa.ChildrenFeatures.Count; i++)
                    {
                        var bb = aa.ChildrenFeatures[i];
                        if (bb != null)
                        {
                            //listView1.Items.Add(bb[0].SubFeatureName);
//                        CreateListViewItem(listView1, bb[0]);
//                        featureBindingSource.DataSource = instanceListFromFeature(rawSelectedItemAsSoftwareType);
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SoftwareType.getActiveInstance() == 0)
            {
                ftSubmit.Enabled = false;
                ftSubmitButton.Enabled = false;
            }
            else
            {
                ftSubmit.Enabled = true;
                ftSubmitButton.Enabled = true;
            }
            if (SoftwareType.getActiveInstance() == 0)
            {
                ctButtonSubmit.Enabled = false;
            }
            else
            {
                ctButtonSubmit.Enabled = true;
            }
            tabPage6.Text = SoftwareType.getActiveInstance().ToString();
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

        private void softwareTypeClassBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Current item Edited");
        }

        private void softwareTypeClassBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            MessageBox.Show(e.ListChangedType.ToString());
        }

        private void childrenFeaturesBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void tabularFormContextMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tabularFormContextMenu_Click(object sender, EventArgs e)
        {

        }

        private void tabularFormContextMenu_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                tabularFormContextMenu.Show(Cursor.Position);
                tabularFormContextMenu.Visible = true;
            }
            else
            {
                tabularFormContextMenu.Visible = false;
            }
        }

        private void EditSTList_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSTList_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(listBox1.SelectedItem.ToString());
            var selected = new SoftwareTypeModel{Id=listBox1.SelectedIndex};
            SoftwareTypeContext.SoftwareTypeModels.Attach(selected);
            SoftwareTypeContext.SoftwareTypeModels.Remove(selected);
            SoftwareTypeContext.SaveChanges();

        }
    }
}
