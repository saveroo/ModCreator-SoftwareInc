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
public class XMLBindinglist
{
    public XMLBindinglist()
    {
    }

    public XMLBindinglist(string name, string id, string Designation)
    {
        this.EmployeeName = name;
        this.EmployeeID = id;
        this.Designation = Designation;
    }

    public XMLBindinglist(string name, string id, string Designation, string managerid)
    {
        this.EmployeeName = name;
        this.EmployeeID = id;
        this.Designation = Designation;
        this.ManagerID = managerid;
    }

    public string Designation { get; set; } = string.Empty;

    public string EmployeeID { get; set; } = string.Empty;

    public string EmployeeName { get; set; } = string.Empty;

    public string ManagerID { get; set; } = string.Empty;

    public ArrayList SubEmployees { get; } = new ArrayList();
}