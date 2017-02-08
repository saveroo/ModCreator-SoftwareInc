using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SoftwareIncModMaker
{
    class XMLController
    {
        public static List<SoftwareTypeClass> IterateFromXML(string datasrc)
        {
            List<SoftwareTypeClass> listSoftwareType = new List<SoftwareTypeClass>();

            // Use the XML DOM to read data from the employees XML data file
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(datasrc);
            if (xmldoc.DocumentElement.HasChildNodes)
            {
                XmlNodeList softwareTypeNodeChild = xmldoc.DocumentElement.ChildNodes;
                for (int i = 0; i < softwareTypeNodeChild.Count; i++)
                {
                    // Create an Employee instance to represent each employee
                    SoftwareTypeClass softwareTypeField = new SoftwareTypeClass();
                    SoftwareTypeClass listFeature = new SoftwareTypeClass();


                    XmlNode softwareTypeNode = softwareTypeNodeChild[i];
                    XmlNodeList softwareTypeChildNodeDataList = softwareTypeNode.ChildNodes;
                    IEnumerator enumChildNodeData = softwareTypeChildNodeDataList.GetEnumerator();
                    enumChildNodeData.Reset();

                    while (enumChildNodeData.MoveNext())
                    {
                        XmlNode node = enumChildNodeData.Current as XmlNode;
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
                                IEnumerator t = node.ChildNodes.GetEnumerator();
                                t.Reset();
                                while (t.MoveNext())
                                {
                                    XmlNode dchild = t.Current as XmlNode;
                                    switch (dchild.Name)
                                    {
                                        case "Name":
                                            listFeature.SubFeatureName = dchild.InnerText;
                                            break;
                                        case "Description":
                                            listFeature.SubFeatureDescription = dchild.Name;
                                            break;
                                        case "DevTime":
                                            listFeature.SubFeatureDevtime = Int32.Parse(dchild.InnerText);
                                            listFeature.SubCategory += System.Environment.NewLine + dchild.InnerText;
                                            break;
                                        case "Innovation":
                                            listFeature.SubFeatureInnovation = Int32.Parse(dchild.InnerText);
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
