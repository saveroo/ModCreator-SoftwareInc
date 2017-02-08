using System.Collections.Generic;
using AutocompleteMenuNS;
using System.Text.RegularExpressions;

namespace SoftwareIncModMaker
{
    public static class ScintillaSnippet
    {
        
        private static string[] softwareTypeFeatureSnippets()
        {
            string featureForcedSnippet =
               "\t<Name>Test feat 1</Name>\n" +
               "\t<Description>This feature will always be selected unless superseded by a feature with this as \"From\".</Description>\n" +
               "\t<DevTime>2</DevTime>\n" +
               "\t<Innovation>0</Innovation>\n" +
               "\t<Usability>1</Usability>\n" +
               "\t<Stability>1</Stability>\n" +
               "\t<CodeArt>1</CodeArt>\n";

            string featureDependencySnippet =
                "\t<Name>Test feat 1</Name>\n" +
                "\t<Description>This feature will always be selected unless superseded by a feature with this as \"From\".</Description>\n" +
                "\t<DevTime>2</DevTime>\n" +
                "\t<Innovation>0</Innovation>\n" +
                "\t<Usability>1</Usability>\n" +
                "\t<Stability>1</Stability>\n" +
                "\t<CodeArt>1</CodeArt>\n" +
                "\t<Dependency Software=\"Visual Tool\">Image viewing</Dependency>\n";

            string featureStandaloneSnippet =
                "\t<Name>Test feat 1</Name>\n" +
                "\t<Description>This feature will always be selected unless superseded by a feature with this as \"From\".</Description>\n" +
                "\t<DevTime>2</DevTime>\n" +
                "\t<Innovation>0</Innovation>\n" +
                "\t<Usability>1</Usability>\n" +
                "\t<Stability>1</Stability>\n" +
                "\t<CodeArt>1</CodeArt>\n" +
                "\t<Dependency Software=\"Test Software\">Test feat 2</Dependency>\n" +
                "\t<SoftwareCategory Category=\"Test category\">1983</SoftwareCategory>\n";

            string[] categoryFeatureSnippet = {
                "<Feature>\n"+featureStandaloneSnippet+"</Feature>",
                "<Feature From=\"^\">\n"+featureDependencySnippet+"</Feature>",
                "<Feature Forced=\"^\">\n"+featureForcedSnippet+"</Feature>",
            };

            return categoryFeatureSnippet;
        }

        public static string[] softwareTypeOneLineSnippets()
        {
            string[] oneLineSnippets = {
                "<Description>^</Description>",
                "<Random>^</Random>",
                "<Category>^</Category>",
                "<OneClient>^</OneClient>",
                "<InHouse>^</InHouse>",
                "<Name>^</Name>"
            };

            return oneLineSnippets;
        }

        public static string[] softwareTypeCategorySnippets()
        {

            string categorySnippet =
                "\t<Description>This is a test category</Description>\n" +
                "\t<Popularity> 0.5 </Popularity>\n" +
                "\t<Retention>0.5</Retention>\n" +
                "\t<TimeScale>1</TimeScale>\n" +
                "\t<Iterative>0.75</Iterative>\n" +
                "\t<NameGenerator>testgen</NameGenerator>\n";
            string[] snippetWrapper = { "<Category Name=\"^\">\n" + categorySnippet + "</Category>" };
            return snippetWrapper;
        }

        public static void BuildAutocompleteMenu(AutocompleteMenu Form)
        {


            var items = new List<AutocompleteItem>();

            //iterate thru snippet method and add to List<>
            foreach (var item in softwareTypeOneLineSnippets())
                items.Add(new softwareTypeSnippet(item) { ImageIndex = 1 });
            foreach (var item in softwareTypeCategorySnippets())
                items.Add(new softwareTypeSnippet(item) { ImageIndex = 1 });
            foreach (var item in softwareTypeFeatureSnippets())
                items.Add(new softwareTypeSnippet(item) { ImageIndex = 1 });

            //set as autocomplete source
            Form.SetAutocompleteItems(items);
        }

    }

    internal class softwareTypeSnippet : SnippetAutocompleteItem
    {
        public static string RegexSpecSymbolsPattern = @"[\^\$\[\]\(\)\.\\\*\+\|\?\{\}]";

        public softwareTypeSnippet(string softwareTypeTag) : base(softwareTypeTag)
        {
            ImageIndex = 0;
            ToolTipTitle = "Insert Tag";
            ToolTipText = softwareTypeTag;
        }

        public override CompareResult Compare(string fragmentText)
        {
            var pattern = Regex.Replace(fragmentText, RegexSpecSymbolsPattern, "\\$0");
            if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
                return CompareResult.Visible;
            return CompareResult.Hidden;
        }
    }
}
