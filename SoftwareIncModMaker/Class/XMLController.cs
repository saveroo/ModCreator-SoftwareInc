namespace SoftwareIncModMaker
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Xml;

    internal class XmlController
    {
        public static List<SoftwareTypeClassBackup> IterateFromXml(string datasrc)
        {
            var listSoftwareType = new List<SoftwareTypeClassBackup>();

            // Use the XML DOM to read data from the employees XML data file
            var xmldoc = new XmlDocument();
            xmldoc.Load(datasrc);
            if (xmldoc.DocumentElement.HasChildNodes)
            {
                var softwareTypeNodeChild = xmldoc.DocumentElement.ChildNodes;
                for (var i = 0; i < softwareTypeNodeChild.Count; i++)
                {
                    // Create an Employee instance to represent each employee
                    var softwareTypeField = new SoftwareTypeClassBackup();
                    var listFeature = new SoftwareTypeClassBackup();

                    var softwareTypeNode = softwareTypeNodeChild[i];
                    var softwareTypeChildNodeDataList = softwareTypeNode.ChildNodes;
                    var enumChildNodeData = softwareTypeChildNodeDataList.GetEnumerator();
                    enumChildNodeData.Reset();

                    while (enumChildNodeData.MoveNext())
                    {
                        var node = enumChildNodeData.Current as XmlNode;
                        switch (node.Name)
                        {
                            case "Features":
                                softwareTypeField.ParentFeatures = node.InnerXml;
                                MessageBox.Show(softwareTypeField.ParentFeatures);
                                break;
                            case "Feature":
                                listFeature.SubFeature = node.InnerXml;
                                node = enumChildNodeData.Current as XmlNode;
                                if (node.HasChildNodes)
                                {
                                    var t = node.ChildNodes.GetEnumerator();
                                    t.Reset();
                                    while (t.MoveNext())
                                    {
                                        var dchild = t.Current as XmlNode;
                                        switch (dchild.Name)
                                        {
                                            case "Name":
                                                listFeature.SubFeatureName = dchild.InnerText;
                                                break;
                                            case "Description":
                                                listFeature.SubFeatureDescription = dchild.Name;
                                                break;
                                            case "DevTime":
                                                listFeature.SubFeatureDevtime = int.Parse(dchild.InnerText);
                                                listFeature.SubCategory += Environment.NewLine + dchild.InnerText;
                                                break;
                                            case "Innovation":
                                                listFeature.SubFeatureInnovation = int.Parse(dchild.InnerText);
                                                break;
                                        }
                                    }
                                }

                                break;
                        }
                    }

                    listSoftwareType.Add(softwareTypeField);
                }
            }

            return listSoftwareType;
        }
    }
}