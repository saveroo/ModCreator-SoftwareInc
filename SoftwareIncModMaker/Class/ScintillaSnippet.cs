namespace SoftwareIncModMaker
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    using AutocompleteMenuNS;

    public static class ScintillaSnippet
    {
        public static void BuildAutocompleteMenu(AutocompleteMenu form)
        {
            var items = new List<AutocompleteItem>();

            // iterate thru snippet method and add to List<>
            foreach (var item in SoftwareTypeOneLineSnippets()) items.Add(new SoftwareTypeSnippet(item) { ImageIndex = 1 });
            foreach (var item in SoftwareTypeCategorySnippets()) items.Add(new SoftwareTypeSnippet(item) { ImageIndex = 1 });
            foreach (var item in SoftwareTypeFeatureSnippets()) items.Add(new SoftwareTypeSnippet(item) { ImageIndex = 1 });

            // set as autocomplete source
            form.SetAutocompleteItems(items);
        }

        public static string[] SoftwareTypeCategorySnippets()
        {
            var categorySnippet = "\t<Description>This is a test category</Description>\n"
                                  + "\t<Popularity> 0.5 </Popularity>\n" + "\t<Retention>0.5</Retention>\n"
                                  + "\t<TimeScale>1</TimeScale>\n" + "\t<Iterative>0.75</Iterative>\n"
                                  + "\t<NameGenerator>testgen</NameGenerator>\n";
            string[] snippetWrapper = { "<Category Name=\"^\">\n" + categorySnippet + "</Category>" };
            return snippetWrapper;
        }

        public static string[] SoftwareTypeOneLineSnippets()
        {
            string[] oneLineSnippets =
                {
                    "<Description>^</Description>", "<Random>^</Random>", "<Category>^</Category>",
                    "<OneClient>^</OneClient>", "<InHouse>^</InHouse>", "<Name>^</Name>"
                };

            return oneLineSnippets;
        }

        private static string[] SoftwareTypeFeatureSnippets()
        {
            var featureForcedSnippet = "\t<Name>Test feat 1</Name>\n"
                                       + "\t<Description>This feature will always be selected unless superseded by a feature with this as \"From\".</Description>\n"
                                       + "\t<DevTime>2</DevTime>\n" + "\t<Innovation>0</Innovation>\n"
                                       + "\t<Usability>1</Usability>\n" + "\t<Stability>1</Stability>\n"
                                       + "\t<CodeArt>1</CodeArt>\n";

            var featureDependencySnippet = "\t<Name>Test feat 1</Name>\n"
                                           + "\t<Description>This feature will always be selected unless superseded by a feature with this as \"From\".</Description>\n"
                                           + "\t<DevTime>2</DevTime>\n" + "\t<Innovation>0</Innovation>\n"
                                           + "\t<Usability>1</Usability>\n" + "\t<Stability>1</Stability>\n"
                                           + "\t<CodeArt>1</CodeArt>\n"
                                           + "\t<Dependency Software=\"Visual Tool\">Image viewing</Dependency>\n";

            var featureStandaloneSnippet = "\t<Name>Test feat 1</Name>\n"
                                           + "\t<Description>This feature will always be selected unless superseded by a feature with this as \"From\".</Description>\n"
                                           + "\t<DevTime>2</DevTime>\n" + "\t<Innovation>0</Innovation>\n"
                                           + "\t<Usability>1</Usability>\n" + "\t<Stability>1</Stability>\n"
                                           + "\t<CodeArt>1</CodeArt>\n"
                                           + "\t<Dependency Software=\"Test Software\">Test feat 2</Dependency>\n"
                                           + "\t<SoftwareCategory Category=\"Test category\">1983</SoftwareCategory>\n";

            string[] categoryFeatureSnippet =
                {
                    "<Feature>\n" + featureStandaloneSnippet + "</Feature>",
                    "<Feature From=\"^\">\n" + featureDependencySnippet + "</Feature>",
                    "<Feature Forced=\"^\">\n" + featureForcedSnippet + "</Feature>"
                };

            return categoryFeatureSnippet;
        }
    }

    /// <summary>
    ///     The software type snippet.
    /// </summary>
    internal sealed class SoftwareTypeSnippet : SnippetAutocompleteItem
    {
        public static string RegexSpecSymbolsPattern = @"[\^\$\[\]\(\)\.\\\*\+\|\?\{\}]";

        public SoftwareTypeSnippet(string softwareTypeTag)
            : base(softwareTypeTag)
        {
            this.ImageIndex = 0;
            this.ToolTipTitle = "Insert Tag";
            this.ToolTipText = softwareTypeTag;
        }

        public override CompareResult Compare(string fragmentText)
        {
            var pattern = Regex.Replace(fragmentText, RegexSpecSymbolsPattern, "\\$0");
            if (Regex.IsMatch(this.Text, "\\b" + pattern, RegexOptions.IgnoreCase)) return CompareResult.Visible;
            return CompareResult.Hidden;
        }
    }
}