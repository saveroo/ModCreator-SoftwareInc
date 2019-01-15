//TODO: REFACTOR

namespace SoftwareIncModMaker
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    using SoftwareIncModMaker.Properties.DataSources;

    using Syncfusion.Windows.Forms.Grid;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// The tabular editor form.
    /// </summary>
    public partial class TabularEditorForm : Form
    {
        private SoftwareTypeModel selectedSoftware;

        public TabularEditorForm()
        {
            this.InitializeComponent();
            this.timer1.Enabled = true;
            this.timer1.Start();

            var mainCtx = new SoftwareTypeModel2Container();

            this.listBox1.DataSource = mainCtx.SoftwareTypeModels.ToList();
        }

        public SoftwareTypeModel2Container ModelContext()
        {
            try
            {
                var xxx = new SoftwareTypeModel2Container();
                return xxx;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }
        }

        public void ShowCategoryIntoListView(ListView listView, SoftwareTypeModel modelInstance)
        {
            foreach (var xx in modelInstance.CategoryModels)
            {
                var item = new ListViewItem();
                item.Text = xx.STCategoryName;
                item.Tag = xx;
                listView.Items.Add(item);
            }
        }

        public void ShowIntoListBox(ListBox listBox, SoftwareTypeModel modelInstance)
        {
            this.listBox2.DisplayMember = "SubFeatureName";
            this.listBox2.DataSource = modelInstance.FeatureModels.ToList();
        }

        public void ShowIntoListView(ListView listView, SoftwareTypeModel modelInstance)
        {
            foreach (var xx in modelInstance.FeatureModels)
            {
                var item = new ListViewItem();
                item.Text = xx.SubFeatureName;
                item.Tag = xx;
                listView.Items.Add(item);
            }
        }

        private void AddToDependencyComboListClick(object sender, EventArgs e)
        {
            if (this.listBox3.SelectedItem != null)
            {
                var instance = new SoftwareTypeModel2Container();
                var castedItem = this.listBox3.SelectedItem as DependenciesList;
                if (instance.DependenciesLists.Find(castedItem.Id) != null)
                {
                    MessageBox.Show(castedItem.DependencySoftware + " Already exist in the list");
                }
                else
                {
                    var newDependencies = new DependenciesList { DependencySoftware = this.addToDependencyList.Text };
                    instance.DependenciesLists.Add(newDependencies);
                    instance.SaveChanges();
                }
            }
            else
            {
                var instance = new SoftwareTypeModel2Container();
                var newDependencies = new DependenciesList { DependencySoftware = this.addToDependencyList.Text };
                instance.DependenciesLists.Add(newDependencies);
                instance.SaveChanges();
            }

            using (var instance = new SoftwareTypeModel2Container())
            {
                this.RefreshListBox(this.listBox3, instance.DependenciesLists.ToList(), "DependencySoftware");
            }
        }

        private void AddToDependencyListTextChanged(object sender, EventArgs e)
        {
        }

        private void AutoLabel1Click(object sender, EventArgs e)
        {
        }

        private void AutoLabel7Click(object sender, EventArgs e)
        {
        }

        private void CheckBoxAdv1CheckStateChanged(object sender, EventArgs e)
        {
        }

        private void CheckBoxAdv2CheckStateChanged(object sender, EventArgs e)
        {
        }


        private void CtButtonSubmitClick(object sender, EventArgs e)
        {
            var categoryData = new CategoryModel
                                   {
                                       STCategoryName = this.ctNameTextBox.Text,
                                       STCategoryDescription = this.ctDescriptionTextBox.Text,
                                       STUnlock = this.ctUnlockBox.Value,
                                       STIterative = this.ctIterativeBox.Value,
                                       STPopularity = this.ctPopularityBox.Value,
                                       STRetention = this.ctRetentionBox.Value,
                                       STTimeScale = this.ctTimeScaleBox.Value,
                                       STNameGenerator = this.ctNameGenerator.Text
                                   };
            var castedListbox = this.listBox1.SelectedItem as SoftwareTypeModel;

            if (castedListbox != null)
            {
                var instance = new SoftwareTypeModel2Container();
                instance.SoftwareTypeModels.Find(castedListbox.Id).CategoryModels.Add(categoryData);
                instance.SaveChanges();
                ActionMemo.AddLines(
                    "Category: " + categoryData.STCategoryName + " Added to " + categoryData.SoftwareTypeModel.RootName);
            }
        }


        private void DeleteStListClick(object sender, EventArgs e)
        {
            this.selectedSoftware = this.listBox1.SelectedItem as SoftwareTypeModel;
            using (var instance = new SoftwareTypeModel2Container())
            {
                var selected = new SoftwareTypeModel { Id = this.selectedSoftware.Id };

                bool saveFailed;
                do
                {
                    saveFailed = false;
                    try
                    {
                        // FeatureDelete
                        var parent =
                            instance.SoftwareTypeModels.Include(p => p.FeatureModels)
                                .SingleOrDefault(p => p.Id == selected.Id);
                        if (parent != null)
                            foreach (var child in parent.FeatureModels.ToList())
                            {
                                var x = child.FeatureDependencies.ToList();
                                foreach (var xx in x)
                                {
                                    var c = xx;
                                    var featureDependenciesId = instance.FeatureDependencies.Find(c.Id);
                                    ActionMemo.AddLines(
                                        "Dependency: [" + c.Id + ". " + c.DependenciesList.DependencySoftware
                                        + "] is Removed",
                                        true,
                                        Color.Red);
                                    instance.FeatureDependencies.Remove(c);
                                    instance.Entry(instance.FeatureDependencies.Find(c.Id)).State = EntityState.Deleted;
                                    instance.SaveChanges();
                                }

                                var fatId = instance.FeatureAttributes.Find(child.FeatureAttributes.Id);
                                instance.FeatureModels.Remove(child);

                                ActionMemo.AddLines(
                                    "Feature: [" + child.Id + ". " + child.SubFeatureName + "] is Removed",
                                    true,
                                    Color.Red);
                                if (child.FeatureAttributes != null) instance.FeatureAttributes.Remove(fatId);
                                instance.Entry(instance.FeatureAttributes.Find(fatId.Id)).State = EntityState.Deleted;
                                instance.SaveChanges();
                            }

                        // Override delete
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

                        // Category Delete
                        if (st.CategoryModels != null)
                        {
                            var categoryModel =
                                instance.SoftwareTypeModels.Include(p => p.CategoryModels)
                                    .SingleOrDefault(p => p.Id == selected.Id);
                            foreach (var v in categoryModel.CategoryModels.ToList())
                                if (v != null)
                                {
                                    ActionMemo.AddLines(
                                        "Category: [" + v.Id + ". " + v.STCategoryName + "] is Removed",
                                        true,
                                        Color.Red);
                                    instance.CategoryModels.Remove(v);
                                    instance.Entry(v).State = EntityState.Deleted;
                                    instance.SaveChanges();
                                }
                        }

                        // SoftwareType Delete
                        instance.SoftwareTypeModels.Remove(st);
                        instance.Entry(st).State = EntityState.Deleted;
                        ActionMemo.AddLines("Software: [" + st.RootName + "] Is Removed", true, Color.DarkRed);
                        instance.SaveChanges();

                        this.RefreshListBox(this.listBox1, this.ModelContext().SoftwareTypeModels.ToList(), "RootName");
                        this.listBox2.DataSource = null;
                        this.listBox2.Items.Clear();
                    }
                    catch (DbUpdateConcurrencyException exception)
                    {
                        saveFailed = true;
                        exception.Entries.Single().Reload();
                    }
                }
                while (saveFailed);
            }
        }


        private void EditStListClick(object sender, EventArgs e)
        {
        }

        private void FtDependencyComboBoxDropDown(object sender, EventArgs e)
        {
        }

        private void FtDependencySubmitClick(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedItem != null && this.ftDependencyComboBox.SelectedItem != null)
            {
                var castedFeature = this.listBox2.SelectedItem as FeatureModel;
                if (castedFeature != null)
                {
                    var castedDependencies = this.ftDependencyComboBox.SelectedItem as DependenciesList;
                    if (castedDependencies != null)
                        using (var instance = new SoftwareTypeModel2Container())
                        {
                            var newDependency = new FeatureDependency
                                                    {
                                                        DependencyFeature =
                                                            this.ftDependencyFeature.Text,
                                                        DependenciesListId = castedDependencies.Id,
                                                        FeatureModelId = castedFeature.Id
                                                    };
                            instance.FeatureDependencies.Attach(newDependency);
                            instance.FeatureDependencies.Add(newDependency);
                            instance.SaveChanges();
                            ActionMemo.AddLines(
                                "Dependency: [" + castedDependencies.DependencySoftware + "] " + "added to Feature: ["
                                + castedFeature.SubFeatureName + "]",
                                true,
                                Color.Orange);
                            this.RefreshListBox(
                                this.listBox3,
                                instance.FeatureDependencies.ToList(),
                                "DependencyFeature");
                        }
                }
            }
        }

        private void FtSubmitButtonClick(object sender, EventArgs e)
        {

            var newFt = new FeatureModel();

            if (this.ftAttrForced.BoolValue == false && this.ftAttrVital.BoolValue == false
                && this.ftAttrFrom.Text == string.Empty && this.ftAttrResearch.BoolValue == false)
            {
                newFt.SubFeatureName = this.ftName.Text;
                newFt.SubFeatureDescription = this.ftDescription.Text;
                newFt.SubFeatureUnlock = this.ftUnlockBox.Value;
                newFt.SubFeatureDevTime = this.ftDevTimeBox.Value;
                newFt.SubFeatureInnovation = this.ftInnovationBox.Value;
                newFt.SubFeatureUsability = this.ftUsabilityBox.Value;
                newFt.SubFeatureStability = this.ftStabilityBox.Value;
                newFt.SubFeatureCodeArt = this.ftCodeArtBox.Value;
                newFt.SubFeatureServer = this.ftServerBox.Value;
            }
            else
            {

                newFt.SubFeatureName = this.ftName.Text;
                newFt.SubFeatureDescription = this.ftDescription.Text;
                newFt.SubFeatureUnlock = this.ftUnlockBox.Value;
                newFt.SubFeatureDevTime = this.ftDevTimeBox.Value;
                newFt.SubFeatureInnovation = this.ftInnovationBox.Value;
                newFt.SubFeatureUsability = this.ftUsabilityBox.Value;
                newFt.SubFeatureStability = this.ftStabilityBox.Value;
                newFt.SubFeatureCodeArt = this.ftCodeArtBox.Value;
                newFt.SubFeatureServer = this.ftServerBox.Value;
                newFt.FeatureAttributes = new FeatureAttributes
                                              {
                                                  AttributeFrom = this.ftAttrFrom.Text,
                                                  AttributeForced = this.ftAttrForced.BoolValue,
                                                  AttributeVital = this.ftAttrVital.BoolValue,
                                                  AttributeResearch = this.ftAttrResearch.BoolValue,
                                                  FKFeatureModel_Id = newFt.Id,
                                                  FKFeatureName = this.ftName.Text
                                              };
            }

            if (this.listBox1.SelectedItem != null)
            {
                using (var b = new SoftwareTypeModel2Container())
                {
                    b.SoftwareTypeModels.Find((this.listBox1.SelectedItem as SoftwareTypeModel).Id)
                        .FeatureModels.Add(newFt);
                    ActionMemo.AddLines(
                        "Feature: " + newFt.SubFeatureName + " Is Added To Software: "
                        + (this.listBox1.SelectedItem as SoftwareTypeModel).RootName,
                        true,
                        Color.Green);
                    b.SaveChanges();
                }
            }
            else
            {
                ActionHistory.Information = "Select the Software from the list before adding new feature";
            }
        }

        private void GenerateToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO: serialize approach instead ?
            var instance = new SoftwareTypeModel2Container();
            var castedListbox = this.listBox1.SelectedItem as SoftwareTypeModel;
            var xList = new List<string>();

            if (castedListbox.SoftwareTypeMAttribute != null)
                if (castedListbox.SoftwareTypeMAttribute.Override == true) xList.Add("<SoftwareType Override=\"True\">");
                else xList.Add("<SoftwareType>");
            xList.Add("<Name>" + castedListbox.RootName + "</Name>");
            if (castedListbox.RootNameGenerator.Length > 0) xList.Add("<NameGenerator>" + castedListbox.RootNameGenerator + "</NameGenerator>");
            xList.Add("<Category>" + castedListbox.RootCategory + "</Category>");
            xList.Add("<Description>" + castedListbox.RootDescription + "</Description>");
            xList.Add("<Random>" + castedListbox.RootRandom + "</Random>");

            // Start Adding Category
            if (castedListbox.CategoryModels.Any()) xList.Add("<Categories>");
            foreach (var category in castedListbox.CategoryModels)
            {
                xList.Add("\t<Category Name=" + category.STCategoryName + ">");
                xList.Add("\t\t<Description>" + category.STCategoryDescription + "</Description>");
                xList.Add("\t\t<Popularity>" + category.STPopularity + "</Popularity>");
                xList.Add("\t\t<Retention>" + category.STRetention + "</Retention>");
                xList.Add("\t\t<TimeScale>" + category.STTimeScale + "</TimeScale>");
                xList.Add("\t\t<Iterative>" + category.STIterative + "</Iterative>");
                xList.Add("\t\t<NameGenerator>" + category.STNameGenerator + "</NameGenerator>");
                xList.Add("\t</Category>");
            }

            if (castedListbox.CategoryModels.Any()) xList.Add("</Categories>");

            // End
            xList.Add("<OSSpecific>" + castedListbox.RootOSSpecific + "</OSSpecific>");
            xList.Add("<OneClient>" + castedListbox.RootOneClient + "</OneClient>");
            xList.Add("<InHouse>" + castedListbox.RootInHouse + "</InHouse>");

            // Feature
            xList.Add("<Features>");
            foreach (var feature in castedListbox.FeatureModels)
            {
                if (feature.FeatureAttributes.AttributeForced == true) xList.Add("\t<Feature Forced=TRUE>");
                else if (feature.FeatureAttributes.AttributeFrom != string.Empty) xList.Add("\t<Feature From=" + feature.FeatureAttributes.AttributeFrom + ">");
                else if (feature.FeatureAttributes.AttributeVital == true) xList.Add("\t<Feature Vital=TRUE>");
                else if (feature.FeatureAttributes.AttributeResearch == true) xList.Add("\t<Feature Research=TRUE>");
                else xList.Add("\t<Feature>");
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

            // Save to XML, CreateDirectory already have conditional check
            Directory.CreateDirectory("SoftwareMod");
            File.WriteAllLines("SoftwareMod/" + castedListbox.RootName + ".xml", xList);
        }

        private void ListBox1BindingContextChanged(object sender, EventArgs e)
        {
            // ActionMemo.addLines("BindingContext is changed");
        }

        private void ListBox1MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = this.listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                this.tabularFormContextMenu.Show(Cursor.Position);
                this.tabularFormContextMenu.Visible = true;
            }
            else
            {
                this.tabularFormContextMenu.Visible = false;
            }
        }

        private void ListBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            // Define Dependency
            var instance = new SoftwareTypeModel2Container();
            var castedListbox = this.listBox1.SelectedItem as SoftwareTypeModel;

            // Add to memo
            ActionMemo.AddLines("Software: [" + castedListbox.RootName + "] Is Selected");
            ActionMemo.AddLines(
                "Software: [" + castedListbox.RootName + "] Features:",
                instance.SoftwareTypeModels.Find(castedListbox.Id).FeatureModels.Any());
            instance.SoftwareTypeModels.Find(castedListbox.Id)
                .FeatureModels.ToList()
                .ForEach(
                    s =>
                        ActionMemo.AddLines(
                            "Feature: " + s.SubFeatureName,
                            instance.SoftwareTypeModels.Find(castedListbox.Id).FeatureModels.Any()));

            // Populate current software category if exist
            this.listView2.Clear();
            this.ShowCategoryIntoListView(this.listView2, instance.SoftwareTypeModels.Find(castedListbox.Id));

            // Populate belonged feature model to listview
            this.listBox2.DataSource = null;
            this.listBox2.Items.Clear();
            this.RefreshListBox(
                this.listBox2,
                instance.SoftwareTypeModels.Find(castedListbox.Id).FeatureModels.ToList(),
                "SubFeatureName");

            // refreshBoxes(listBox2);

            // ShowIntoListView(listView1,instance.SoftwareTypeModels.Find(castedListbox.Id));

            // Populate combo box in feature FROM
            this.ftAttrFrom.Items.Clear();
            instance.SoftwareTypeModels.Find(castedListbox.Id)
                .FeatureModels.ToList()
                .ForEach(s => this.ftAttrFrom.Items.Add(s.SubFeatureName));

        }

        private void ListBox2SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ListBox2SelectedIndexChanged1(object sender, EventArgs e)
        {
            var a = this.listBox2.SelectedItem as FeatureModel;
            if (a != null)
            {
                this.listBox3.DataSource = null;
                if (this.listBox2.SelectedItem != null)
                    this.RefreshListBox(
                        this.listBox3,
                        (this.listBox2.SelectedItem as FeatureModel).FeatureDependencies.ToList(),
                        "DependencyFeature");
                ActionMemo.AddLines(
                    "Feature: [" + a.SubFeatureName + "] from " + "Software: [" + a.SoftwareTypeModel.RootName
                    + "] are Selected");
                if (a.FeatureAttributes.AttributeFrom != string.Empty)
                    ActionMemo.AddLines(
                        "Feature: [" + a.SubFeatureName + "] " + "Are Derived From Feature ["
                        + a.FeatureAttributes.AttributeFrom + "]",
                        true,
                        Color.DarkBlue);
                ActionMemo.AddLines(
                    "Feature: [" + a.SubFeatureName + "] " + "is Forced Feature",
                    a.FeatureAttributes.AttributeForced,
                    Color.DarkBlue);
                ActionMemo.AddLines(
                    "Feature: [" + a.SubFeatureName + "] " + "is Researchable Feature",
                    a.FeatureAttributes.AttributeResearch,
                    Color.DarkBlue);
                ActionMemo.AddLines(
                    "Feature: [" + a.SubFeatureName + "] " + "is Vital Feature",
                    a.FeatureAttributes.AttributeVital,
                    Color.DarkBlue);
                ActionMemo.AddLines(
                    "Feature: [" + a.SubFeatureName + "] " + "Have " + a.FeatureDependencies.Count + " Dependency",
                    a.FeatureAttributes.AttributeVital,
                    Color.DarkBlue);
            }
        }

        private void ListView1ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var a = e.Item.Tag as FeatureModel;
            if (a != null)
            {
                ActionMemo.AddLines(
                    "Feature: [" + a.SubFeatureName + "] from " + "Software: [" + a.SoftwareTypeModel.RootName
                    + "] are Selected");
                if (a.FeatureAttributes.AttributeFrom != string.Empty)
                    ActionMemo.AddLines(
                        "Feature: [" + a.SubFeatureName + "] " + "Are Derived From Feature ["
                        + a.FeatureAttributes.AttributeFrom + "]",
                        true,
                        Color.DarkBlue);
                ActionMemo.AddLines(
                    "Feature: [" + a.SubFeatureName + "] " + "is Forced Feature",
                    a.FeatureAttributes.AttributeForced,
                    Color.DarkBlue);
                ActionMemo.AddLines(
                    "Feature: [" + a.SubFeatureName + "] " + "is Researchable Feature",
                    a.FeatureAttributes.AttributeResearch,
                    Color.DarkBlue);
                ActionMemo.AddLines(
                    "Feature: [" + a.SubFeatureName + "] " + "is Vital Feature",
                    a.FeatureAttributes.AttributeVital,
                    Color.DarkBlue);
            }
        }

        private void ListView1SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void MenuStrip1ItemClicked1(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void RefreshListBox<T>(ListBox lb, List<T> ctx, string displayMember)
        {
            lb.DataSource = ctx;
            lb.DisplayMember = string.Empty;
            lb.DisplayMember = displayMember;
        }

        private void StSubmitButtonClick(object sender, EventArgs e)
        {
            SoftwareTypeModel softwareTypeData;
            if (this.RootOverride.BoolValue)
                softwareTypeData = new SoftwareTypeModel
                                       {
                                           RootName = this.stNameTextBox.Text,
                                           RootUnlock = this.stUnlock.Value,
                                           RootRandom = this.stRandom.Value,
                                           RootPopularity = this.stPopularity.Value,
                                           RootRetention = this.stRetention.Value,
                                           RootIterative = this.stIterativeBox.Value,
                                           RootDescription = this.stDescriptionTextBox.Text,
                                           RootOSSpecific = this.stOSSpecific.Checked,
                                           RootOneClient = this.stOneClient.Checked,
                                           RootInHouse = this.stInHouse.Checked,
                                           RootOSLimit = this.stOSLimit.Text,
                                           SoftwareTypeMAttribute =
                                               new SoftwareTypeMAttribute
                                                   {
                                                       Override =
                                                           this.RootOverride
                                                               .BoolValue
                                                   }
                                       };
            else
                softwareTypeData = new SoftwareTypeModel
                                       {
                                           RootName = this.stNameTextBox.Text,
                                           RootUnlock = this.stUnlock.Value,
                                           RootRandom = this.stRandom.Value,
                                           RootPopularity = this.stPopularity.Value,
                                           RootRetention = this.stRetention.Value,
                                           RootIterative = this.stIterativeBox.Value,
                                           RootDescription = this.stDescriptionTextBox.Text,
                                           RootOSSpecific = this.stOSSpecific.Checked,
                                           RootOneClient = this.stOneClient.Checked,
                                           RootInHouse = this.stInHouse.Checked,
                                           RootOSLimit = this.stOSLimit.Text
                                       };

            var a = new SoftwareTypeModel2Container();
            var instance = this.ModelContext();
            instance.SoftwareTypeModels.Add(softwareTypeData);
            instance.SaveChanges();
            ActionMemo.AddLines("Software: [" + softwareTypeData.RootName + "] Is Added");

            this.listBox1.DataSource = a.SoftwareTypeModels.ToList();
            this.listBox1.DisplayMember = "RootName";
        }

        private void TabPage4Click(object sender, EventArgs e)
        {
        }

        private void TabularEditorFormDoubleClick(object sender, EventArgs e)
        {
        }

        private void TabularEditorFormLoad(object sender, EventArgs e)
        {
            using (var instance = new SoftwareTypeModel2Container())
            {
                this.ftDependencyComboBox.DisplayMember = "DependencySoftware";
                this.ftDependencyComboBox.DataSource = instance.DependenciesLists.ToList();
            }

            this.treeNavigator1.DataBindings.Add(
                new Binding("Text", this.modCreatorDataSet, "SoftwareTypeModels.RootName"));

            // TODO: This line of code loads data into the 'modCreatorDataSet.SoftwareTypeModels' table. You can move, or remove it, as needed.
            this.softwareTypeModelsTableAdapter.Fill(this.modCreatorDataSet.SoftwareTypeModels);
            this.selectedSoftware = this.listBox1.SelectedItem as SoftwareTypeModel;

            this.timer1.Start();
        }

        private void TabularFormContextMenuClick(object sender, EventArgs e)
        {
        }

        private void TabularFormContextMenuMouseDown(object sender, MouseEventArgs e)
        {
        }

        private void TabularFormContextMenuOpening(object sender, CancelEventArgs e)
        {
        }

        private void TestToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void TextBoxExt1TextChanged(object sender, EventArgs e)
        {
        }

        private void Timer1Tick(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex == -1)
            {
                // ftSubmit.Enabled = false;
                this.ftSubmitButton.Enabled = false;
                this.ctSubmitButton.Enabled = false;
            }
            else
            {
                // ftSubmit.Enabled = true;
                this.ftSubmitButton.Enabled = true;
                this.ctSubmitButton.Enabled = true;
            }
        }

        private void TreeNavigator1MouseEnter(object sender, EventArgs e)
        {
            var instance = new SoftwareTypeModel2Container();

            // var castedListbox = treeNavigator1.SelectedItem.Tag as SoftwareTypeModel;
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

                this.treeNavigator1.Items.Add(newTreeItem);
            }
        }
    }
}