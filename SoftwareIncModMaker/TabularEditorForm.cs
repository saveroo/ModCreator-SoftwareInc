using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EnvDTE;
using SoftwareIncModMaker.Class;
using SoftwareIncModMaker.Properties.DataSources;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using RestSharp.Extensions;


namespace SoftwareIncModMaker
{
    public partial class TabularEditorForm : Form
    {
        private SoftwareTypeModel selectedSoftware;
        public TabularEditorForm()
        {
            InitializeComponent();
            
            timer1.Enabled = true;
            timer1.Start();

            var mainCtx = new SoftwareTypeModel2Container();

            listBox1.DataSource = mainCtx.SoftwareTypeModels.ToList();
            listBox2.DataSource = (
                from x in mainCtx.FeatureModels
                where x.Id == x.SoftwareTypeModel.Id
                select x).ToList();
        }

        public SoftwareTypeModel2Container ModelContext()
        {
            try
            {
                SoftwareTypeModel2Container xxx = new SoftwareTypeModel2Container();
                    return xxx;
            }
            catch (Exception e)
            {
               MessageBox.Show(e.ToString());
               throw;
            }
        }

        private void TabularEditorForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'modCreatorDataSet.SoftwareTypeModels' table. You can move, or remove it, as needed.
            this.softwareTypeModelsTableAdapter.Fill(this.modCreatorDataSet.SoftwareTypeModels);
            selectedSoftware = listBox1.SelectedItem as SoftwareTypeModel;

            timer1.Start();
            
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

        private Feature instanceOfFeature(int index, ListView st)
        {
            if (st.SelectedItems.Count > 0)
            {
                return (Feature)st.SelectedItems[index].Tag;
            }
            return null;
        }

        private void ftSubmitButton_Click(object sender, EventArgs e)
        {

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
                

            FeatureModel newFt = new FeatureModel();

            if (ftAttrForced.BoolValue == false
                && ftAttrVital.BoolValue == false
                && ftAttrFrom.Text == String.Empty
                && ftAttrResearch.BoolValue == false)
            {
                newFt.SubFeatureName = ftName.Text;
                newFt.SubFeatureDescription = ftDescription.Text;
                newFt.SubFeatureUnlock = ftUnlockBox.Value;
                newFt.SubFeatureDevTime = ftDevTimeBox.Value;
                newFt.SubFeatureInnovation = ftInnovationBox.Value;
                newFt.SubFeatureUsability = ftUsabilityBox.Value;
                newFt.SubFeatureStability = ftStabilityBox.Value;
                newFt.SubFeatureCodeArt = ftCodeArtBox.Value;
                newFt.SubFeatureServer = ftServerBox.Value;
            }
            else
            {
//                var newAttr = new FeatureAttributes()
//                {
//                    AttributeFrom = ftAttrFrom.Text,
//                    AttributeForced = ftAttrForced.BoolValue,
//                    AttributeVital = ftAttrVital.BoolValue,
//                    AttributeResearch = ftAttrResearch.BoolValue,
//                    FKFeatureModel_Id = newFt.Id,
//                    FKFeatureName = ftName.Text
//                };

                newFt.SubFeatureName = ftName.Text;
                newFt.SubFeatureDescription = ftDescription.Text;
                newFt.SubFeatureUnlock = ftUnlockBox.Value;
                newFt.SubFeatureDevTime = ftDevTimeBox.Value;
                newFt.SubFeatureInnovation = ftInnovationBox.Value;
                newFt.SubFeatureUsability = ftUsabilityBox.Value;
                newFt.SubFeatureStability = ftStabilityBox.Value;
                newFt.SubFeatureCodeArt = ftCodeArtBox.Value;
                newFt.SubFeatureServer = ftServerBox.Value;
                newFt.FeatureAttributes = new FeatureAttributes()
                {
                    AttributeFrom = ftAttrFrom.Text,
                    AttributeForced = ftAttrForced.BoolValue,
                    AttributeVital = ftAttrVital.BoolValue,
                    AttributeResearch = ftAttrResearch.BoolValue,
                    FKFeatureModel_Id = newFt.Id,
                    FKFeatureName = ftName.Text
                };
            }
                
            if (listBox1.SelectedItem != null)
            {
                using (SoftwareTypeModel2Container b = new SoftwareTypeModel2Container())
                {
                    b.SoftwareTypeModels
                        .Find((listBox1.SelectedItem as SoftwareTypeModel).Id)
                        .FeatureModels.Add(newFt);
                    ActionMemo.addLines(
                        "Feature: "
                        +newFt.SubFeatureName+
                        " Is Added To Software: "+ 
                        (listBox1.SelectedItem as SoftwareTypeModel).RootName, true, Color.Green);
                    b.SaveChanges();
                }
            }
            else
            {
                ActionHistory.Information = "Select the Software from the list before adding new feature";
            }
        }
        private void ctButtonSubmit_Click(object sender, EventArgs e)
        {

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
            var instance = ModelContext();
            instance.SoftwareTypeModels.Add(softwareTypeData);
            instance.SaveChanges();
            ActionMemo.addLines("Software: [" + softwareTypeData.RootName + "] Is Added");

            listBox1.DataSource = a.SoftwareTypeModels.ToList();
            listBox1.DisplayMember = "RootName";

        }

        private void allGenerate_Click(object sender, EventArgs e)
        {
            listView1.Groups.Add(new ListViewGroup(stNameTextBox.Text, HorizontalAlignment.Left));
     
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
            

        }

        private void editControl1_Load(object sender, EventArgs e)
        {

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
            SoftwareTypeModel2Container instance = new SoftwareTypeModel2Container();
            var a = listBox1.SelectedItem as SoftwareTypeModel;
            ActionMemo.addLines("Software: [" + a.RootName + "] Is Selected");
            ActionMemo.addLines("Software: [" + a.RootName + "] Features:", instance.SoftwareTypeModels.Find(a.Id).FeatureModels.Any());
            instance.SoftwareTypeModels.Find(a.Id).FeatureModels.ToList().ForEach(s => ActionMemo.addLines("Feature: "+s.SubFeatureName, instance.SoftwareTypeModels.Find(a.Id).FeatureModels.Any()));

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
//            if (SoftwareType.getActiveInstance() == 0)
//            {
//                ftSubmit.Enabled = false;
//                ftSubmitButton.Enabled = false;
//            }
//            else
//            {
//                ftSubmit.Enabled = true;
//                ftSubmitButton.Enabled = true;
//            }
//            if (SoftwareType.getActiveInstance() == 0)
//            {
//                ctButtonSubmit.Enabled = false;
//            }
//            else
//            {
//                ctButtonSubmit.Enabled = true;
//            }
//            tabPage6.Text = SoftwareType.getActiveInstance().ToString();
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

        private void refreshListBox<T>(ListBox lb, List<T> ctx, String displayMember)
        {
            lb.DataSource = ctx;
            lb.DisplayMember = "";
            lb.DisplayMember = displayMember;
        }

        private void DeleteSTList_Click(object sender, EventArgs e)
        {
            selectedSoftware = listBox1.SelectedItem as SoftwareTypeModel;
            using (SoftwareTypeModel2Container instance = new SoftwareTypeModel2Container())
            {
                SoftwareTypeModel selected = new SoftwareTypeModel() { Id = selectedSoftware.Id };

                bool saveFailed;
                do
                {
                    saveFailed = false;
                    try
                    {

                        var parent = instance.SoftwareTypeModels.Include(p => p.FeatureModels)
                                    .SingleOrDefault(p => p.Id == selected.Id);
                        if (parent != null)
                        {
                            foreach (var child in parent.FeatureModels.ToList())
                            {
                                var fatId = instance.FeatureAttributes.Find(child.FeatureAttributes.Id);
                                instance.FeatureModels.Remove(child);
                                ActionMemo.addLines(
                                    "Feature: [" 
                                    + child.Id + ". "
                                    + child.SubFeatureName + "] is Removed", true, Color.Red);
                                if (child.FeatureAttributes != null)
                                {
                                    instance.FeatureAttributes.Remove(fatId);

                                }
                                instance.Entry(instance.FeatureAttributes.Find(fatId.Id)).State = EntityState.Deleted;
                                instance.SaveChanges();
                            }
                        }
                        //SoftwareType Delete
                        var st = instance.SoftwareTypeModels.Find(selected.Id);
                        instance.SoftwareTypeModels.Remove(st);
                        instance.Entry(st).State = EntityState.Deleted;
                        ActionMemo.addLines("Software: ["+st.RootName+"] Is Removed", true, Color.DarkRed);
                        instance.SaveChanges();

                        refreshListBox(listBox1, ModelContext().SoftwareTypeModels.ToList(), "RootName");
                    }
                    catch (DbUpdateConcurrencyException exception)
                    {
                        saveFailed = true;
                        exception.Entries.Single().Reload();
                    }
                } while (saveFailed);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_BindingContextChanged(object sender, EventArgs e)
        {
            ActionMemo.addLines("BindingContext is changed");
        }
    }
}
