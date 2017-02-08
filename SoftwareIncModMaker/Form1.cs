﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using Syncfusion.SVG.IO;
using System.Xml;
using System.Collections;
using System.Reflection;

namespace SoftwareIncModMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "SoftwareIncModMaker.web.html";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                DiagramAppearance();
                InitializeDiagramFromXMLData(@"C:\Games\Steam\SteamApps\common\Software Inc\test.xml");

            }
            diagram1.BeginUpdate();

        }
        protected void InitializeDiagramFromXMLData(string datasrcpath)
        {

            //C:\Users\senthilkumarm\AppData\Local\Syncfusion\EssentialStudio\10.2.0.56\Common\Data\Diagram
            // Read data from the XML data file and populate a Hashtable using the employee ID as the key
            System.Collections.Generic.List<XMLBindinglist> lstEmployees = this.ReadEmployeeDataFromXMLFile(datasrcpath);
            IterCreateEmployeeSymbol(lstEmployees);

        }
        private void DiagramAppearance()
        {
            this.diagram1.Model.LineStyle.LineColor = Color.LightGray;
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.View.SelectionList.Clear();
        }
        protected System.Collections.Generic.List<XMLBindinglist> ReadEmployeeDataFromXMLFile(string datasrc)
        {
            System.Collections.Generic.List<XMLBindinglist> lstEmployee = new System.Collections.Generic.List<XMLBindinglist>();

            // Use the XML DOM to read data from the employees XML data file
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(datasrc);
            if (xmldoc.DocumentElement.HasChildNodes)
            {
                XmlNodeList employeelist = xmldoc.DocumentElement.ChildNodes;
                for (int i = 0; i < employeelist.Count; i++)
                {
                    // Create an Employee instance to represent each employee
                    XMLBindinglist emply = new XMLBindinglist();

                    XmlNode employeenode = employeelist[i];
                    XmlNodeList employeedatalist = employeenode.ChildNodes;
                    IEnumerator employeedata = employeedatalist.GetEnumerator();
                    employeedata.Reset();
                    
                    while (employeedata.MoveNext())
                    {
                        XmlNode dataelement = employeedata.Current as XmlNode;
                        switch (dataelement.Name)
                        {
                            case "SoftwareType":
                                emply.EmployeeName = dataelement.Name;
                                break;
                            case "Feature":
                                emply.EmployeeName =  dataelement.Name + " @"+ dataelement.InnerText;
                                break;
                            case "Features":
                                emply.EmployeeID = dataelement.InnerText;
                                break;
                            case "Categories":
                                emply.Designation = dataelement.InnerText;
                                emply.EmployeeName += System.Environment.NewLine +  dataelement.InnerText;
                                break;
                            case "ManagerID":
                                emply.ManagerID = dataelement.InnerText;
                                break;
                        }
                    }
                    lstEmployee.Add(emply);
                }
            }

            return lstEmployee;
        }
        protected void IterCreateEmployeeSymbol(List<XMLBindinglist> emply)
        {
            foreach (XMLBindinglist subemply in emply)
            {

                Syncfusion.Windows.Forms.Diagram.Rectangle rect = new Syncfusion.Windows.Forms.Diagram.Rectangle(200, 0, 150, 60);
                rect.Name = subemply.EmployeeID;
                rect.FillStyle.Color = System.Drawing.Color.FromArgb(240, 242, 240);
                rect.FillStyle.ForeColor = System.Drawing.Color.White;
                rect.FillStyle.Type = FillStyleType.LinearGradient;
                rect.LineStyle.LineColor = System.Drawing.Color.Black;
                this.diagram1.Model.AppendChild(rect);
                Syncfusion.Windows.Forms.Diagram.Label label = new Syncfusion.Windows.Forms.Diagram.Label();
                label.Container = rect;
                label.Text = subemply.EmployeeName;
                label.Position = Syncfusion.Windows.Forms.Diagram.Position.Center;
                label.FontStyle.Family = "Segoe UI";
                label.FontStyle.Size = 8;
                rect.Labels.Add(label);

                if (!string.IsNullOrEmpty(subemply.ManagerID))
                {

                    //OrthogonalConnector conn = new OrthogonalConnector(PointF.Empty, new PointF(0, 1));
                    OrgLineConnector conn = new OrgLineConnector(System.Drawing.PointF.Empty, new System.Drawing.PointF(0, 1), MeasureUnits.Pixel);
                    conn.LineStyle.LineColor = System.Drawing.Color.Black;
                    Decorator decor = conn.HeadDecorator;
                    decor.DecoratorShape = DecoratorShape.Filled45Arrow;
                    decor.Size = new System.Drawing.SizeF(10, 10);
                    decor.FillStyle.Color = System.Drawing.Color.Black;
                    decor.LineStyle.LineColor = System.Drawing.Color.Black;
                    conn.VerticalDistance = 50;
                    Syncfusion.Windows.Forms.Diagram.Rectangle rect1 = diagram1.Model.Nodes.FindNodeByName(subemply.ManagerID) as Syncfusion.Windows.Forms.Diagram.Rectangle;

                    rect1.CentralPort.TryConnect(conn.TailEndPoint);
                    rect.CentralPort.TryConnect(conn.HeadEndPoint);
                    this.diagram1.Model.AppendChild(conn);
                    // this.diagram1.Model.BringToFront(rect1);
                }
                //orgLayoutMgr.Nodes.Clear();
                //orgLayoutMgr.Nodes.AddRange(this.diagram1.Model.Nodes);
                //orgLayoutMgr.UpdateLayout(null);

            }

        }
    }
}
