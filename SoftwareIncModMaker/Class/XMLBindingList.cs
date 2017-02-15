#region Copyright Syncfusion Inc. 2001 - 2016

// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 

#endregion

using System.Collections;

/// <summary>
///     Summary description for XMLBinding
/// </summary>
public class XmlBindinglist
{
    public XmlBindinglist()
    {
    }

    public XmlBindinglist(string name, string id, string designation)
    {
        this.EmployeeName = name;
        this.EmployeeId = id;
        this.Designation = designation;
    }

    public XmlBindinglist(string name, string id, string designation, string managerid)
    {
        this.EmployeeName = name;
        this.EmployeeId = id;
        this.Designation = designation;
        this.ManagerId = managerid;
    }

    public string Designation { get; set; } = string.Empty;

    public string EmployeeId { get; set; } = string.Empty;

    public string EmployeeName { get; set; } = string.Empty;

    public string ManagerId { get; set; } = string.Empty;

    public ArrayList SubEmployees { get; } = new ArrayList();
}