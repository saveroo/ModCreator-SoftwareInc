using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SoftwareIncModMaker.Properties.DataSources;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using Syncfusion.Windows.Forms.Tools;

//TODO: REFACTOR
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
//            listBox2.DataSource = (
//                from x in mainCtx.FeatureModels
//                where x.Id == x.SoftwareTypeModel.Id
//                select x).ToList();
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
            using (var instance = new SoftwareTypeModel2Container())
            {
                ftDependencyComboBox.DisplayMember = "DependencySoftware";
                ftDependencyComboBox.DataSource = instance.DependenciesLists.ToList();
            }
            treeNavigator1.DataBindings.Add(new Binding("Text", modCreatorDataSet, "SoftwareTypeModels.RootName"));

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
            CategoryModel categoryData = new CategoryModel()
            {
               STCategoryName = ctNameTextBox.Text,
               STCategoryDescription = ctDescriptionTextBox.Text,
               STUnlock = ctUnlockBox.Value,
               STIterative = ctIterativeBox.Value,
               STPopularity = ctPopularityBox.Value,
               STRetention = ctRetentionBox.Value,
               STTimeScale = ctTimeScaleBox.Value,
               STNameGenerator = ctNameGenerator.Text,
            };
            var castedListbox = listBox1.SelectedItem as SoftwareTypeModel;

            if (castedListbox != null)
            {
                var instance = new SoftwareTypeModel2Container();
                instance.SoftwareTypeModels
                    .Find(castedListbox.Id)
                    .CategoryModels
                    .Add(categoryData);
                instance.SaveChanges();
                ActionMemo.addLines("Category: "+categoryData.STCategoryName
                    +" Added to "+
                    categoryData.SoftwareTypeModel.RootName);
            }
        }
        private void stSubmitButton_Click(object sender, EventArgs e)
        {
            SoftwareTypeModel softwareTypeData;
            if (RootOverride.BoolValue != false)
            {
                softwareTypeData = new SoftwareTypeModel
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
                    RootOSLimit = stOSLimit.Text,
                    SoftwareTypeMAttribute = new SoftwareTypeMAttribute()
                    {
                        Override = RootOverride.BoolValue
                    }
                };
            }
            else
            {
                softwareTypeData = new SoftwareTypeModel
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
                    RootOSLimit = stOSLimit.Text,
                };
            }

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
            var a = e.Item.Tag as FeatureModel;
            if (a != null)
            {
                ActionMemo.addLines("Feature: [" + a.SubFeatureName + "] from " +
                                    "Software: [" + a.SoftwareTypeModel.RootName + "] are Selected");
                if (a.FeatureAttributes.AttributeFrom != String.Empty)
                {
                    ActionMemo.addLines("Feature: [" + a.SubFeatureName + "] " +
                                        "Are Derived From Feature [" + a.FeatureAttributes.AttributeFrom + "]"
                        , true, Color.DarkBlue);
                }
                ActionMemo.addLines("Feature: [" + a.SubFeatureName + "] " +
                                    "is Forced Feature",
                    a.FeatureAttributes.AttributeForced,
                    Color.DarkBlue);
                ActionMemo.addLines("Feature: [" + a.SubFeatureName + "] " +
                                    "is Researchable Feature",
                    a.FeatureAttributes.AttributeResearch,
                    Color.DarkBlue);
                ActionMemo.addLines("Feature: [" + a.SubFeatureName + "] " +
                                    "is Vital Feature",
                    a.FeatureAttributes.AttributeVital,
                    Color.DarkBlue);
            }
            else
            {
                //Do Nothing
            }

        }

        private void btnSubmitToList_Click(object sender, EventArgs e)
        {
   
            // Do nothing
        }

        private void gridDataBoundGrid1_CellClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void ShowIntoListView(ListView listView, SoftwareTypeModel modelInstance) 
        {
            foreach (var xx in modelInstance.FeatureModels)
            {
                ListViewItem item = new ListViewItem();
                item.Text = xx.SubFeatureName;
                item.Tag = xx;
                listView.Items.Add(item);
            }
        }
        public void ShowCategoryIntoListView(ListView listView, SoftwareTypeModel modelInstance)
        {
            foreach (var xx in modelInstance.CategoryModels)
            {
                ListViewItem item = new ListViewItem();
                item.Text = xx.STCategoryName;
                item.Tag = xx;
                listView.Items.Add(item);
            }
        }
        public void ShowIntoListBox(ListBox listBox, SoftwareTypeModel modelInstance)
        {
            listBox2.DisplayMember = "SubFeatureName";
            listBox2.DataSource = modelInstance.FeatureModels.ToList();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Define Dependency
            SoftwareTypeModel2Container instance = new SoftwareTypeModel2Container();
            var castedListbox = listBox1.SelectedItem as SoftwareTypeModel;

            //Add to memo
            ActionMemo.addLines("Software: [" + castedListbox.RootName + "] Is Selected");
            ActionMemo.addLines("Software: [" + castedListbox.RootName + "] Features:", instance.SoftwareTypeModels.Find(castedListbox.Id).FeatureModels.Any());
            instance.SoftwareTypeModels.Find(castedListbox.Id).FeatureModels.ToList().ForEach(s => ActionMemo.addLines("Feature: "+s.SubFeatureName, instance.SoftwareTypeModels.Find(castedListbox.Id).FeatureModels.Any()));

            //Populate current software category if exist
            listView2.Clear();
            ShowCategoryIntoListView(listView2, instance.SoftwareTypeModels.Find(castedListbox.Id));

            //Populate belonged feature model to listview
            listBox2.DataSource = null;
            listBox2.Items.Clear();
            refreshListBox(listBox2, instance.SoftwareTypeModels.Find(castedListbox.Id).FeatureModels.ToList(), "SubFeatureName");
            //refreshBoxes(listBox2);

            //ShowIntoListView(listView1,instance.SoftwareTypeModels.Find(castedListbox.Id));

            //Populate combo box in feature FROM
            ftAttrFrom.Items.Clear();
            instance.SoftwareTypeModels.Find(castedListbox.Id).FeatureModels.ToList().ForEach(s => ftAttrFrom.Items.Add(s.SubFeatureName));

            var aa = (listBox1.SelectedItem as SoftwareType);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
//                ftSubmit.Enabled = false;
                ftSubmitButton.Enabled = false;
                ctSubmitButton.Enabled = false;
            }
            else
            {
//                ftSubmit.Enabled = true;
                ftSubmitButton.Enabled = true;
                ctSubmitButton.Enabled = true;
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void addToDependencyList_TextChanged(object sender, EventArgs e)
        {

        }

        private void addToDependencyComboList_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                var instance = new SoftwareTypeModel2Container();
                var castedItem = listBox3.SelectedItem as DependenciesList;
                if (instance.DependenciesLists.Find(castedItem.Id) != null)
                {
                    MessageBox.Show(castedItem.DependencySoftware + " Already exist in the list");
                }
                else
                {
                    var newDependencies = new DependenciesList()
                    {
                        DependencySoftware = addToDependencyList.Text
                    };
                    instance.DependenciesLists.Add(newDependencies);
                    instance.SaveChanges();
                }
            }
            else
            {
                var instance = new SoftwareTypeModel2Container();
                var newDependencies = new DependenciesList()
                {
                    DependencySoftware = addToDependencyList.Text
                };
                instance.DependenciesLists.Add(newDependencies);
                instance.SaveChanges();
            }
            using (var instance = new SoftwareTypeModel2Container())
            {
                refreshListBox(listBox3, instance.DependenciesLists.ToList(), "DependencySoftware");
            }
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
                        //FeatureDelete
                        var parent = instance.SoftwareTypeModels.Include(p => p.FeatureModels)
                                    .SingleOrDefault(p => p.Id == selected.Id);
                        if (parent != null)
                        {
                            foreach (var child in parent.FeatureModels.ToList())
                            {
                                var x = child.FeatureDependencies.ToList();
                                foreach(var xx in x)
                                {
                                    var c = xx as FeatureDependency;
                                    var featureDependenciesID = instance.FeatureDependencies.Find(c.Id);
                                    ActionMemo.addLines(
                                    "Dependency: ["
                                    + c.Id + ". "
                                    + c.DependenciesList.DependencySoftware + "] is Removed", true, Color.Red);
                                    instance.FeatureDependencies.Remove(c);
                                    instance.Entry(instance.FeatureDependencies.Find(c.Id)).State = EntityState.Deleted;
                                    instance.SaveChanges();
                                }

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
                        //Override delete
                        var st = instance.SoftwareTypeModels.Find(selected.Id);
                        if (st.SoftwareTypeMAttribute != null)
                        {
                            var sa = instance.SoftwareTypeMAttributes.Find(st.SoftwareTypeMAttribute.Id);
                            if (sa != null)
                            {
                                instance.SoftwareTypeMAttributes.Remove(sa);
                                instance.Entry(sa).State = EntityState.Deleted;
                            }
                        }
                        //Category Delete
                        if (st.CategoryModels != null)
                        {
                            var categoryModel = instance.SoftwareTypeModels
                                .Include(p => p.CategoryModels)
                                .SingleOrDefault(p => p.Id == selected.Id);
                            foreach (var v in categoryModel.CategoryModels.ToList())
                            {
                                if (v != null)
                                {
                                    ActionMemo.addLines(
                                   "Category: ["
                                   + v.Id + ". "
                                   + v.STCategoryName + "] is Removed", true, Color.Red);
                                    instance.CategoryModels.Remove(v);
                                    instance.Entry(v).State = EntityState.Deleted;
                                    instance.SaveChanges();
                                }
                            }                            
                        }
                        //SoftwareType Delete
                        instance.SoftwareTypeModels.Remove(st);
                        instance.Entry(st).State = EntityState.Deleted;
                        ActionMemo.addLines("Software: ["+st.RootName+"] Is Removed", true, Color.DarkRed);
                        instance.SaveChanges();

                        refreshListBox(listBox1, ModelContext().SoftwareTypeModels.ToList(), "RootName");
                        listBox2.DataSource = null;
                        listBox2.Items.Clear();

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
            //ActionMemo.addLines("BindingContext is changed");
        }

        private void treeNavigator1_MouseEnter(object sender, EventArgs e)
        {
            var instance = new SoftwareTypeModel2Container();
//            var castedListbox = treeNavigator1.SelectedItem.Tag as SoftwareTypeModel;
            foreach (var software in instance.SoftwareTypeModels.ToList())
            {

                var newTreeItem = new TreeMenuItem();
                    newTreeItem.Text = software.RootName;
                    newTreeItem.Tag = software;
                var newTreeItemChild = new TreeMenuItem();
                foreach (var feature in software.FeatureModels)
                {
                    newTreeItemChild.Tag = feature;
                    newTreeItemChild.Text = feature.SubFeatureName;
                    newTreeItem.Items.Add(newTreeItemChild);
                }
                    treeNavigator1.Items.Add(newTreeItem);
            }
        }
        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: serialize approach instead ?
            var instance = new SoftwareTypeModel2Container();
            var castedListbox = listBox1.SelectedItem as SoftwareTypeModel;
            var xList = new List<string>();

            if (castedListbox.SoftwareTypeMAttribute != null)
                if(castedListbox.SoftwareTypeMAttribute.Override == true)
                    xList.Add("<SoftwareType Override=\"True\">");
            else
                xList.Add("<SoftwareType>");
            xList.Add("<Name>"+ castedListbox.RootName +"</Name>"); 
            if(castedListbox.RootNameGenerator.Length > 0)
                xList.Add("<NameGenerator>"+ castedListbox.RootNameGenerator + "</NameGenerator>"); 
            xList.Add("<Category>"+ castedListbox.RootCategory + "</Category>"); 
            xList.Add("<Description>"+ castedListbox.RootDescription + "</Description>"); 
            xList.Add("<Random>"+ castedListbox.RootRandom + "</Random>");
            //Start Adding Category
            if (castedListbox.CategoryModels.Any())
                xList.Add("<Categories>");
            foreach (var category in castedListbox.CategoryModels)
            {
                xList.Add("\t<Category Name=" + category.STCategoryName+ ">");
                xList.Add("\t\t<Description>"+category.STCategoryDescription+"</Description>");
                xList.Add("\t\t<Popularity>"+category.STPopularity+ "</Popularity>");
                xList.Add("\t\t<Retention>"+category.STRetention+ "</Retention>");
                xList.Add("\t\t<TimeScale>"+category.STTimeScale+ "</TimeScale>");
                xList.Add("\t\t<Iterative>"+category.STIterative+ "</Iterative>");
                xList.Add("\t\t<NameGenerator>"+category.STNameGenerator+ "</NameGenerator>");
                xList.Add("\t</Category>");
            }
            if (castedListbox.CategoryModels.Any())
                xList.Add("</Categories>");
            //End
            xList.Add("<OSSpecific>"+ castedListbox.RootOSSpecific + "</OSSpecific>"); 
            xList.Add("<OneClient>"+ castedListbox.RootOneClient + "</OneClient>"); 
            xList.Add("<InHouse>"+ castedListbox.RootInHouse + "</InHouse>");
            //Feature
            xList.Add("<Features>");
            foreach (var feature in castedListbox.FeatureModels)
            {
                if (feature.FeatureAttributes.AttributeForced == true)
                    xList.Add("\t<Feature Forced=TRUE>");
                else if (feature.FeatureAttributes.AttributeFrom != String.Empty)
                    xList.Add("\t<Feature From="+feature.FeatureAttributes.AttributeFrom+">");
                else if (feature.FeatureAttributes.AttributeVital == true)
                    xList.Add("\t<Feature Vital=TRUE>");
                else if (feature.FeatureAttributes.AttributeResearch == true)
                    xList.Add("\t<Feature Research=TRUE>");
                else
                    xList.Add("\t<Feature>");
                xList.Add("\t\t<Name>" + feature.SubFeatureName + "</Name>");
                xList.Add("\t\t<Description>" + feature.SubFeatureDescription + "</Description>");
                xList.Add("\t\t<DevTime>" + feature.SubFeatureDescription + "</Description>");
                xList.Add("\t\t<Innovation>" + feature.SubFeatureInnovation + "</Innovation>");
                xList.Add("\t\t<Usability>" + feature.SubFeatureUsability + "</Usability>");
                xList.Add("\t\t<Stability>" + feature.SubFeatureStability + "</Stability>");
                xList.Add("\t\t<CodeArt>" + feature.SubFeatureCodeArt + "</CodeArt>");
                xList.Add("\t<Feature>");
            }
            xList.Add("</Features>");
            xList.Add("</SoftwareType>");

            //Save to XML, CreateDirectory already have conditional check
            Directory.CreateDirectory("SoftwareMod");
            File.WriteAllLines("SoftwareMod/" + castedListbox.RootName + ".xml", xList);
        }

        private void TabularEditorForm_DoubleClick(object sender, EventArgs e)
        {
        }

        private void ftDependencySubmit_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null && (ftDependencyComboBox.SelectedItem != null))
            {
                var castedFeature = listBox2.SelectedItem as FeatureModel;
                if (castedFeature != null)
                {
                    var castedDependencies = ftDependencyComboBox.SelectedItem as DependenciesList;
                    if (castedDependencies != null)
                    {
                        using (var instance = new SoftwareTypeModel2Container())
                        {
                            var newDependency = new FeatureDependency()
                            {
                                DependencyFeature = ftDependencyFeature.Text,
                                DependenciesListId = castedDependencies.Id,
                                FeatureModelId = castedFeature.Id
                            };
                            instance.FeatureDependencies.Attach(newDependency);
                            instance.FeatureDependencies.Add(newDependency);
                            instance.SaveChanges();
                            ActionMemo.addLines("Dependency: [" + castedDependencies.DependencySoftware + "] " +
                                "added to Feature: ["+castedFeature.SubFeatureName+"]", true, Color.Orange);
                            refreshListBox(listBox3, instance.FeatureDependencies.ToList(), "DependencyFeature");
                        }
                    }
                }
            }
        }

        private void ftDependencyComboBox_DropDown(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            var a = this.listBox2.SelectedItem as FeatureModel;
            if (a != null)
            {
                this.listBox3.DataSource = null;
                if (listBox2.SelectedItem != null)
                {
                    refreshListBox(listBox3, (listBox2.SelectedItem as FeatureModel).FeatureDependencies.ToList(), "DependencyFeature");
                }
                ActionMemo.addLines("Feature: [" + a.SubFeatureName + "] from " +
                                    "Software: [" + a.SoftwareTypeModel.RootName + "] are Selected");
                if (a.FeatureAttributes.AttributeFrom != String.Empty)
                {
                    ActionMemo.addLines("Feature: [" + a.SubFeatureName + "] " +
                                        "Are Derived From Feature [" + a.FeatureAttributes.AttributeFrom + "]"
                        , true, Color.DarkBlue);
                }
                ActionMemo.addLines("Feature: [" + a.SubFeatureName + "] " +
                                    "is Forced Feature",
                    a.FeatureAttributes.AttributeForced,
                    Color.DarkBlue);
                ActionMemo.addLines("Feature: [" + a.SubFeatureName + "] " +
                                    "is Researchable Feature",
                    a.FeatureAttributes.AttributeResearch,
                    Color.DarkBlue);
                ActionMemo.addLines("Feature: [" + a.SubFeatureName + "] " +
                                    "is Vital Feature",
                    a.FeatureAttributes.AttributeVital,
                    Color.DarkBlue);
                ActionMemo.addLines("Feature: [" + a.SubFeatureName + "] " +
                                   "Have "+a.FeatureDependencies.Count+" Dependency",
                   a.FeatureAttributes.AttributeVital,
                   Color.DarkBlue);
            }
            else
            {
                //Do nothing
            }
        }
    }
}
