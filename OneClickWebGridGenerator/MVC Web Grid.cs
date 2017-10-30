using OneClickWebGridGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCWebGridScriptGenerator
{
    public partial class frmMainForm : Form
    {
        WebGridData myGrid;
        string SelectedColumnName;
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            string columnName = txtColumnName.Text;

            if (!string.IsNullOrEmpty(columnName))
            {
                if (IsColumnNameValid(columnName))
                {
                    if (!lstbColumns.Items.Contains(columnName))
                    {
                        ColumnRequirement clm = new ColumnRequirement();
                        clm.ColumnName = columnName;
                        clm.CoumnHeader = columnName;
                        clm.DataType = cmbColDataType.SelectedItem.ToString();
                        clm.ColumnWidth = txtColWidth.Text;
                        lstbColumns.Items.Add(columnName);
                        myGrid.ColumnsInformation.Add(clm);

                        if (lstbColumns.Items.Count == 1)
                        {
                            SelectedColumnName = lstbColumns.Items[0].ToString();
                        }
                        txtColumnName.Text = "";
                        if (lstbColumns.Items.Count > 0)
                        {
                            EnableColumnProperties();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Column Name Already Exist", "Can Not Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Column Name", "Column Name Should Be Characters Only", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Column Name", "Column Name is Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtColumnName.Focus();
        }

        private bool IsColumnNameValid(string columnName)
        {
            bool ValidCol = true;

            //Special Characters found
            //Regex RgxUrl = new Regex("[^a-z0-9]");
            Regex RgxUrl = new Regex(@"[^a-zA-Z0-9-_]+");
            var foundSpecialCharacters = RgxUrl.IsMatch(columnName);
            if (foundSpecialCharacters == true)
            {
                ValidCol = false;
            }

            var numberPresent = Regex.Match(txtColumnName.Text, @"\d+").Value;
            if (!string.IsNullOrEmpty(numberPresent))
            {
                ValidCol = false;
            }

            return ValidCol;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myGrid = new WebGridData();
            myGrid.ColumnsInformation = new List<ColumnRequirement>();

            GridDefaultPropertyValues();
            SetDefaultValues();
            DisableColumnProperties();

        }

        private void SetDefaultValues()
        {
            cmbPagingMode.SelectedIndex = 0;
            myGrid.PagingMode = cmbPagingMode.SelectedItem.ToString();
            myGrid.RowsPerPage = Convert.ToInt32(numRowsPerPage.Value);
            myGrid.HeaderBackColor = txtHeaderColor.Text;
            myGrid.FooterBackColor = txtFooterColor.Text;
            myGrid.RowBackColor = txtRowColor.Text;
            myGrid.ForeColor = txtGridTextColor.Text;
            myGrid.AlternativeRowColor = txtAltRowColor.Text;
            myGrid.GridWidth = txtGridWidth.Text;
        }

        private void DisableColumnProperties()
        {
            cmbColDataType.Enabled = false;
            chkEditable.Enabled = false;
            chkCanSort.Enabled = false;
            chkDefaultSort.Enabled = false;
            txtHeader.Enabled = false;
            chkHeader.Enabled = false;
            chkPrimaryKey.Enabled = false;

            chkEditable.Checked = false;
            chkDefaultSort.Checked = false;
            chkPrimaryKey.Checked = false;
            chkCanSort.Checked = false;
            chkHeader.Checked = false;
        }
        private void EnableColumnProperties()
        {
            cmbColDataType.Enabled = true;
            chkEditable.Enabled = true;
            chkCanSort.Enabled = true;
            chkDefaultSort.Enabled = true;
            txtHeader.Enabled = true;
            chkHeader.Enabled = true;
            chkPrimaryKey.Enabled = true;
            txtColWidth.Enabled = true;
        }


        private void btnGenerateScript_Click(object sender, EventArgs e)
        {
            if (lstbColumns.Items.Count > 0)
            {
                try
                {
                    btnGenerateScriptMy();
                    MessageBox.Show("Grid Generated Successfully. Generated Files present at path @" + txtSavePath.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong. Check path, colums you have added propertly");
                }

            }
            else
            {
                MessageBox.Show("There should be atleast one column for grid", "No Columns", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateScriptMy()
        {
            string line1 = @"@model MvcApplication9.Models.GridInfoSuhas  //Change Namespace according to your solution name";
            string line2 = "@{";
            string line3 = " Layout = null;";
            string line4 = " WebGrid grid = new WebGrid(rowsPerPage: " + myGrid.RowsPerPage + ", ajaxUpdateContainerId: \"grid\", fieldNamePrefix: \"g1\", pageFieldName: \"p1\");";
            string line5 = "grid.Bind(Model.ListOfCustomer); }";

            string GridSyle1, GridSyle2, GridSyle3, GridSyle4, GridSyle5, GridSyle6;
            GridCSSHTML(out GridSyle1, out GridSyle2, out GridSyle3, out GridSyle4, out GridSyle5, out GridSyle6, myGrid);


            string JqueryScript1, JqueryScript2, JqueryScript3;
            JqueryHtml(out JqueryScript1, out JqueryScript2, out JqueryScript3);

            #region JavaScript CRUD Operations

            string gridScriptStart = "<script type=\"text/javascript\">";
            string AddRowJavaScript = JavaScriptProvider.GetAddRowJavaScript(myGrid); ;
            string iCancelRowJavaScript = JavaScriptProvider.GetiCancelRowJavaScript(myGrid);
            string EditRowJavaScript = JavaScriptProvider.GetEditRowJavaScript(myGrid);
            string SaveRowJavaScript = JavaScriptProvider.GetSaveRowJavaScript(myGrid);
            string UpdateRowJavaScript = JavaScriptProvider.GetUpdateRowJavaScript(myGrid);
            string DeleteRowJavaScript = JavaScriptProvider.GetDeleteRowJavaScript(myGrid);
            string CancelRowJavaScript = JavaScriptProvider.GetCancelRowJavaScript(myGrid);
            string gridScriptEnd = "</script>";

            #endregion

            string AddNewFunctionlityHtml = "<div id=\"divmsg\" style=\"color: green; font-weight: bold\"></div><a href=\"#\" class=\"add button\">Add New Record</a><br/><br />";

            string grdLine1 = "@grid.GetHtml(";
            string grdLine2 = "htmlAttributes: new { id = \"grid\" },";
            grdLine2 = grdLine2 + "\r\n tableStyle: \"mytable\",";
            grdLine2 = grdLine2 + "\r\n rowStyle: \"myRowStyle\",";
            grdLine2 = grdLine2 + "alternatingRowStyle: \"myalternatingRowStyle\",";
            string grdLine3 = "fillEmptyRows:" + myGrid.FillEmptyRows + ",";
            grdLine3 = grdLine3.Replace("True", "true");
            grdLine3 = grdLine3.Replace("False", "false");

            string grdLine4 = "mode: WebGridPagerModes." + myGrid.PagingMode + ",";
            //firstText: "<< First",
            //previousText: "< Prev",
            //nextText: "Next >",
            //lastText: "Last >>",
            // rowStyle:"AlretNate",
            string grdLine5 = "columns: new[] {";
            string ColumnHTML = "";
            int firstColumn = 0;
            string PK_ColName = "";
            string PK_ColName_dataType = "";
            try
            {
                PK_ColName = myGrid.ColumnsInformation.Find(item => item.PrimaryKeyColumn.Equals("true")).ColumnName;
                PK_ColName_dataType = myGrid.ColumnsInformation.Find(item => item.PrimaryKeyColumn.Equals("true")).DataType;
            }
            catch (Exception)
            {
                MessageBox.Show("Atleast One Column Should be Primary Key");
            }


            int i = 1;
            foreach (var item in myGrid.ColumnsInformation)
            {
                if (firstColumn > 0)
                {
                    ColumnHTML = ColumnHTML + ",\r\n";
                }


                if (item.IsEditable == false)
                {
                    ColumnHTML = ColumnHTML + "grid.Column(\"" + item.ColumnName + "\", style:\"" + item.ColumnName + "Style\",  header: \"" + item.CoumnHeader + "\", canSort:" + item.IsSortable + ")";
                }
                if (item.IsEditable)
                {

                    ColumnHTML = ColumnHTML + "grid.Column(\"" + item.ColumnName + "\", style:\"" + item.ColumnName + "Style\", header: \"" + item.CoumnHeader + "\", canSort: " + item.IsSortable + ",format: @<span> <span id=\"span" + item.ColumnName + "_" + "@item." + PK_ColName + "\">@item." + item.ColumnName + "</span> @Html.TextBox(\"" + item.ColumnName + "_\"+(" + PK_ColName_dataType + ")item." + PK_ColName + ",(" + item.DataType + ") item." + item.ColumnName + ",new{@style=\"display:none\"})</span>)";

                }

                firstColumn++;
                i++;

            }
            ColumnHTML = ColumnHTML.Replace("True", "true");
            ColumnHTML = ColumnHTML.Replace("False", "false");



            string actionColumnStart = "\r\n grid.Column(header: \"Action\", style:\"ActionStyle\", canSort: true,format:@<text>";

            string editLink = "\r\n <a href=\"#\" id=\"Edit_@item." + PK_ColName + "\" style=\"margin-right:10px; margin-left:10px;  color:" + myGrid.ForeColor + "\" class=\"edit\">Edit</a>";
            string UpdateLink = "\r\n <a href=\"#\" id=\"Update_@item." + PK_ColName + "\" style=\"display:none;margin-left:10px;margin-right:10px; color:" + myGrid.ForeColor + "\" class=\"update\">Update</a>";
            string CancelLink = "\r\n <a href=\"#\" id=\"Cancel_@item." + PK_ColName + "\" style=\"display:none; margin-left:10px; margin-right:10px; color:" + myGrid.ForeColor + "\"  class=\"cancel\">Cancel</a>";
            string DeteteLink = "\r\n <a href=\"#\" id=\"Delete_@item." + PK_ColName + "\"  class=\"delete\" style=\"margin-left:10px;margin-right:10px; color:" + myGrid.ForeColor + "\">Delete</a>";

            string actionColumnEnd = "</text>)";

            try
            {
                var searchAnyColumnIsEditable = myGrid.ColumnsInformation.Find(item => item.IsEditable).IsEditable;
                if (searchAnyColumnIsEditable == true)
                {
                    //Actions Column creation
                    ColumnHTML = ColumnHTML + "," + actionColumnStart + editLink + UpdateLink + CancelLink + DeteteLink + actionColumnEnd;
                }
            }
            catch (Exception)
            {

            }

            string grdLine6 = "})";

            //1.  Write View to File
            WriteView(line1, line2, line3, line4, line5, GridSyle1, GridSyle2, GridSyle3, GridSyle4, GridSyle5, GridSyle6, JqueryScript1, JqueryScript2, JqueryScript3, AddRowJavaScript, iCancelRowJavaScript, gridScriptStart, EditRowJavaScript, SaveRowJavaScript, UpdateRowJavaScript, DeleteRowJavaScript, CancelRowJavaScript, gridScriptEnd, AddNewFunctionlityHtml, grdLine1, grdLine2, grdLine3, grdLine4, grdLine5, ColumnHTML, grdLine6);

            //2.  Write Model to File
            WriteModel();

            //3.  Write Controller to File
            WriteController();
        }

        private void WriteController()
        {

            string NameSpaces = "using MvcApplication9.Models; //Change Namespace according to your solution name \r\n using System;\r\n using System.Collections.Generic;\r\n using System.Web;\r\n using System.Linq;\r\n using System.Web;\r\n using System.Web.Mvc;";
            string NameSpaces1 = "namespace MvcApplication9.Controllers //Change Namespace according to your solution name \r\n { \r\n public class TestController : Controller \r\n { \r\npublic static bool isAdded = false;";

            string IndexActionCode = ControllerActionsProvider.GetIndexAction(myGrid);
            string SaveActionCode = ControllerActionsProvider.SaveAction(myGrid);
            string UpdateActionCode = ControllerActionsProvider.UpdateAction(myGrid);
            string DeleteActionCode = ControllerActionsProvider.DeleteAction(myGrid);
            string endClassNamespace = "\r\n } \r\n }";

            

            Directory.CreateDirectory(txtSavePath.Text + @"\Controllers");
            //Directory.CreateDirectory(@"C:\MVCSampleGrid\Controllers");
            string path = txtSavePath.Text + @"\Controllers\TestController.cs";
            File.Create(path).Close();

            using (TextWriter writer = File.CreateText(path))
            {
                writer.WriteLine(NameSpaces);
                writer.WriteLine(NameSpaces1);
                writer.WriteLine(IndexActionCode);
                writer.WriteLine(SaveActionCode);
                writer.WriteLine(UpdateActionCode);
                writer.WriteLine(DeleteActionCode);
                writer.WriteLine(endClassNamespace);

            }
        }


        private void WriteModel()
        {
            

            Directory.CreateDirectory(txtSavePath.Text + @"\Models");
            string path = txtSavePath.Text + @"\Models\GridInfoSuhas.cs";
            File.Create(path).Close();
            using (TextWriter writer = File.CreateText(path))
            {

                string NameSpaces = "using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Web;\r\n";
                string NameSpaces1 = "namespace MvcApplication9.Models //Change Namespace according to your solution name \r\n { \r\n public class RowModel \r\n {";
                writer.WriteLine(NameSpaces);
                writer.WriteLine(NameSpaces1);

                foreach (var item in myGrid.ColumnsInformation)
                {
                    string rowProperty = "public " + item.DataType + " " + item.ColumnName + "  { get; set; }";
                    writer.WriteLine(rowProperty);
                }
                writer.WriteLine("\r\n }");


                string gridClass = "public class GridInfoSuhas \r\n {";
                string gridClass1 = "public List<RowModel> ListOfCustomer { get; set; } ";

                writer.WriteLine(gridClass);
                writer.WriteLine(gridClass1);

                writer.WriteLine("\r\n } \r\n}");
            }
        }

        private void WriteView(string line1, string line2, string line3, string line4, string line5, string GridSyle1, string GridSyle2, string GridSyle3, string GridSyle4, string GridSyle5, string GridSyle6, string JqueryScript1, string JqueryScript2, string JqueryScript3, string AddRowJavaScript, string iCancelRowJavaScript, string gridScriptStart, string EditRowJavaScript, string SaveRowJavaScript, string UpdateRowJavaScript, string DeleteRowJavaScript, string CancelRowJavaScript, string gridScriptEnd, string AddNewFunctionlityHtml, string grdLine1, string grdLine2, string grdLine3, string grdLine4, string grdLine5, string ColumnHTML, string grdLine6)
        {
            
            string path = txtSavePath.Text + @"\Views\Test\Index.cshtml";

            Directory.CreateDirectory(txtSavePath.Text + @"\Views\Test");
            File.Create(path).Close();

            using (TextWriter writer = File.CreateText(path))
            {

                writer.WriteLine(line1);
                writer.WriteLine(line2);
                writer.WriteLine(line3);
                writer.WriteLine(line4);
                writer.WriteLine(line5);

                writer.WriteLine(GridSyle1);
                writer.WriteLine(GridSyle2);
                writer.WriteLine(GridSyle3);
                writer.WriteLine(GridSyle4);
                writer.WriteLine(GridSyle5);
                writer.WriteLine(GridSyle6);


                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine(JqueryScript1);
                writer.WriteLine(JqueryScript2);
                writer.WriteLine(JqueryScript3);
                writer.WriteLine("");
                writer.WriteLine("");
                writer.WriteLine(gridScriptStart);
                if (myGrid.AddRowFunctionality)
                {
                    writer.WriteLine(AddRowJavaScript);
                }
                writer.WriteLine(iCancelRowJavaScript);
                writer.WriteLine(EditRowJavaScript);
                writer.WriteLine(SaveRowJavaScript);
                writer.WriteLine(UpdateRowJavaScript);
                writer.WriteLine(DeleteRowJavaScript);
                writer.WriteLine(CancelRowJavaScript);



                writer.WriteLine(gridScriptEnd);


                if (myGrid.AddRowFunctionality)
                {
                    writer.WriteLine(AddNewFunctionlityHtml);

                }
                writer.WriteLine(grdLine1);
                writer.WriteLine(grdLine2);
                writer.WriteLine(grdLine3);
                writer.WriteLine(grdLine4);
                writer.WriteLine(grdLine5);

                writer.WriteLine(ColumnHTML);

                writer.WriteLine(grdLine6);
            }
        }

        private static void GridCSSHTML(out string GridSyle1, out string GridSyle2, out string GridSyle3, out string GridSyle4, out string GridSyle5, out string GridSyle6, WebGridData mygrid)
        {
            GridSyle1 = "<style type=\"text/css\">";
            //GridSyle2 = "#grid { clear: both; width: 1200px; margin: 0px; overflow: auto; color:" + mygrid.ForeColor + ";/*border: 1px solid #c7c5c7;*/    }";
            //GridSyle3 = "#grid thead { text-align: left; font-weight: bold; height: 15px; color: #000; background-color:" + mygrid.HeaderBackColor + ";  /*border-bottom: 1px solid #e2e2e2;*/ } \r\n\n";
            //GridSyle3 = GridSyle3 + "#grid tfoot td { text-align: left; font-weight: bold; height: 15px; color: #000; background-color: " + mygrid.FooterBackColor + ";  /*border-bottom: 1px solid #e2e2e2;*/ }";
            //GridSyle4 = "#grid td {/*padding: 4px 6px 0px 4px;*/ vertical-align: top;  background-color: " + mygrid.RowBackColor + "; /*border-bottom: 1px solid #e2e2e2;*/     }";
            //GridSyle5 = "input {border: 1px solid #e2e2e2; background: #fff; color: #333;   font-size: 15px;    /*margin: 2px 0 2px 0px;*/   padding: 2px; width: 150px;}";



            GridSyle2 = "\r\n input { border: 1px solid #e2e2e2; background: #fff;  color: #333;  font-size: 15px; width: 90%; height: 28px; }";
            GridSyle2 = GridSyle2 + "body {font-family: \"Candara\"; font-size: 12px; line-height: 1.42857143;  color: #333; background-color: #808080;  }";
            GridSyle3 = "\r\n .mytable { width: " + mygrid.GridWidth + ";  padding: 30px; border: 1px solid #c0c0c0;   border-spacing: 0;     border-collapse: collapse;  color:" + mygrid.ForeColor + " ;}";
            GridSyle3 = GridSyle3 + "\r\n .mytable td { padding: 8px; border-top: 1px solid #c0c0c0;   text-align: center;    }";
            GridSyle3 = GridSyle3 + "\r\n .mytable th {padding: 8px; border-bottom: 4px solid #c0c0c0; font-weight: bold;  text-align: center;  background-color:" + mygrid.HeaderBackColor + "; line-height: 1.4285; color:black}";

            GridSyle3 = GridSyle3 + "\r\n .mytable th a { text-decoration: none; font-weight: bold;  color: black;  }";

            GridSyle3 = GridSyle3 + "\r\n .mytable tfoot td {padding: 8px;  text-align: center;    background-color: " + mygrid.FooterBackColor + ";  line-height: 1.4285;  border-top: 4px solid #c0c0c0;    }";

            GridSyle4 = "\r\n .myRowStyle { background-color:" + mygrid.RowBackColor + ";  vertical-align: central;  }";
            GridSyle5 = "\r\n .myalternatingRowStyle {  background-color: " + mygrid.AlternativeRowColor + ";    vertical-align: central;    }";
            GridSyle5 = GridSyle5 + "\r\n .button { font: bold 11px Arial;  text-decoration: none;   background-color: #EEEEEE;    color: #333333;  padding: 5px 15px 8px 12px;   border-top: 1px solid #CCCCCC;    border-right: 1px solid #333333;    border-bottom: 1px solid #333333;    border-left: 1px solid #CCCCCC;   }";


            string colWidthCss = "\r\n";

            foreach (var item in mygrid.ColumnsInformation)
            {
                colWidthCss = colWidthCss + "\r\n ." + item.ColumnName + "Style {  width: " + item.ColumnWidth + ";   }";
            }
            GridSyle5 = GridSyle5 + colWidthCss;
            GridSyle5 = GridSyle5 + ".ActionStyle {width: 35%;   }";
            GridSyle6 = "\r\n </style>";
        }

        private static void JqueryHtml(out string JqueryScript1, out string JqueryScript2, out string JqueryScript3)
        {
            JqueryScript1 = "<script src=\"~/Scripts/jquery-1.11.0.min.js\"></script>";
            JqueryScript2 = "<script src=\"~/Scripts/jquery.unobtrusive-ajax.min.js\"></script>";
            JqueryScript3 = "<script src=\"~/Scripts/jquery-migrate-1.2.1.js\"></script>";
        }



        private void chkPaging_Click(object sender, EventArgs e)
        {
            if (chkPaging.Checked)
            {
                myGrid.EnablePaging = true;
            }
            else
            {
                myGrid.EnablePaging = false;
            }

        }

        private void numRowsPerPage_ValueChanged(object sender, EventArgs e)
        {
            myGrid.RowsPerPage = Convert.ToInt32(numRowsPerPage.Value);
        }

        private void chkFillEmptyRows_Click(object sender, EventArgs e)
        {
            if (chkFillEmptyRows.Checked)
            {
                myGrid.FillEmptyRows = true;
            }
            else
            {
                myGrid.FillEmptyRows = false;
            }
        }

        private void chkAddNewRowFunc_Click(object sender, EventArgs e)
        {
            if (chkAddNewRowFunc.Checked)
            {
                myGrid.AddRowFunctionality = true;
            }
            else
            {
                myGrid.AddRowFunctionality = false;
            }

        }

        private void cmbPagingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            myGrid.PagingMode = cmbPagingMode.SelectedItem.ToString();

        }

        private void lstbColumns_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lstbColumns_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstbColumns.IndexFromPoint(e.Location);
            try
            {
                // Remove the item in the List.

                string colName = lstbColumns.Items[index].ToString();

                myGrid.ColumnsInformation.RemoveAll(x => x.ColumnName == colName);

                if (lstbColumns.Items.Contains(colName))
                {
                    //remove selected item
                    List<string> tempList = new List<string>();
                    foreach (var item in lstbColumns.Items)
                    {
                        if (item.ToString() != colName)
                        {
                            tempList.Add(item.ToString());
                        }
                    }

                    lstbColumns.Items.Clear();
                    foreach (var item in tempList)
                    {
                        lstbColumns.Items.Add(item);
                    }
                }
                //disable if no columns available
                if (lstbColumns.Items.Count <= 0)
                {
                    DisableColumnProperties();
                }

            }
            catch
            {
            }
        }

        private void lstbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbColumns.SelectedItem != null)
            {
                SelectedColumnName = lstbColumns.SelectedItem.ToString();

                var column = myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName));

                if (column != null)
                {
                    chkEditable.Checked = column.IsEditable;
                    chkCanSort.Checked = column.IsSortable;
                    chkDefaultSort.Checked = column.DefaultSortCoulmn;
                    chkHeader.Checked = column.IsColumnHeader;
                    txtHeader.Text = column.CoumnHeader;
                    if (column.PrimaryKeyColumn == "true")
                    {
                        chkPrimaryKey.Checked = true;
                    }
                    else
                    {
                        chkPrimaryKey.Checked = false;

                    }

                    cmbColDataType.SelectedIndex = cmbColDataType.FindStringExact(column.DataType);
                    txtColWidth.Text = column.ColumnWidth;


                }

                txtColumnName.Text = "";
            }

        }

        private void chkEditable_Click(object sender, EventArgs e)
        {
            if (chkEditable.Checked)
            {
                myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName)).IsEditable = true;

            }
            else
            {
                myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName)).IsEditable = false;

            }

        }

        private void chkCanSort_Click(object sender, EventArgs e)
        {
            if (chkCanSort.Checked)
            {
                myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName)).IsSortable = true;

            }
            else
            {
                myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName)).IsSortable = false;

            }

        }

        private void chkDefaultSort_Click(object sender, EventArgs e)
        {
            foreach (var item in myGrid.ColumnsInformation)
            {
                item.DefaultSortCoulmn = false;
            }
            myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName)).DefaultSortCoulmn = true;

        }

        private void chkHeader_Click(object sender, EventArgs e)
        {
            if (chkHeader.Checked)
            {
                txtHeader.Enabled = true;
                myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName)).IsColumnHeader = true;
            }
            else
            {
                txtHeader.Enabled = false;
                myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName)).IsColumnHeader = false;
            }
        }


        private void txtHeader_Leave(object sender, EventArgs e)
        {
            myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName)).CoumnHeader = txtHeader.Text;
        }

        private void txtHeader_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbColDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName)).DataType = cmbColDataType.SelectedItem.ToString();
        }

        private void chkPrimaryKey_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in myGrid.ColumnsInformation)
                {
                    item.PrimaryKeyColumn = "false";
                }
                myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName)).PrimaryKeyColumn = "true";
            }
            catch (Exception)
            {

            }

        }

        private void chkPrimaryKey_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {
        }


        private void txtHeaderColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                txtHeaderColor.BackColor = colorDialog1.Color;
                Color actColor = colorDialog1.Color;
                txtHeaderColor.Text = "#" + actColor.R.ToString("X2") + actColor.G.ToString("X2") + actColor.B.ToString("X2");
                txtHeaderColor.ForeColor = Color.FromArgb(actColor.ToArgb() ^ 0xffffff);
            }
        }

        private void txtFooterColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                txtFooterColor.BackColor = colorDialog1.Color;
                Color actColor = colorDialog1.Color;
                txtFooterColor.Text = "#" + actColor.R.ToString("X2") + actColor.G.ToString("X2") + actColor.B.ToString("X2");
                txtFooterColor.ForeColor = Color.FromArgb(actColor.ToArgb() ^ 0xffffff);

            }
        }

        private void txtFooterColor_TextChanged(object sender, EventArgs e)
        {

            if (txtFooterColor.Text.Length == 7)
            {
                try
                {
                    Color col = ColorTranslator.FromHtml(txtFooterColor.Text);
                    txtFooterColor.BackColor = col;
                    lblError.Text = "";
                    myGrid.FooterBackColor = txtFooterColor.Text;

                }
                catch (Exception)
                {
                    lblError.Text = "Invalid Color Code !";
                }
            }
        }

        private void txtHeaderColor_TextChanged(object sender, EventArgs e)
        {

            if (txtHeaderColor.Text.Length == 7)
            {
                try
                {
                    Color col = ColorTranslator.FromHtml(txtHeaderColor.Text);
                    txtHeaderColor.BackColor = col;
                    lblError.Text = "";
                    myGrid.HeaderBackColor = txtHeaderColor.Text;
                }
                catch (Exception)
                {
                    lblError.Text = "Invalid Color Code !";
                }
            }


        }

        private void txtRowColor_TextChanged(object sender, EventArgs e)
        {
            if (txtRowColor.Text.Length == 7)
            {
                try
                {
                    Color col = ColorTranslator.FromHtml(txtRowColor.Text);
                    txtRowColor.BackColor = col;
                    lblError.Text = "";
                    myGrid.RowBackColor = txtRowColor.Text;
                }
                catch (Exception)
                {
                    lblError.Text = "Invalid Color Code !";
                }
            }
        }

        private void txtGridTextColor_TextChanged(object sender, EventArgs e)
        {

            if (txtGridTextColor.Text.Length == 7)
            {
                try
                {
                    Color col = ColorTranslator.FromHtml(txtGridTextColor.Text);
                    txtGridTextColor.BackColor = col;
                    lblError.Text = "";
                    myGrid.ForeColor = txtGridTextColor.Text;

                }
                catch (Exception)
                {
                    lblError.Text = "Invalid Color Code !";
                }
            }
        }

        private void txtRowColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                txtRowColor.BackColor = colorDialog1.Color;
                Color actColor = colorDialog1.Color;
                txtRowColor.Text = "#" + actColor.R.ToString("X2") + actColor.G.ToString("X2") + actColor.B.ToString("X2");
                txtRowColor.ForeColor = Color.FromArgb(actColor.ToArgb() ^ 0xffffff);

            }
        }

        private void txtGridTextColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                txtGridTextColor.BackColor = colorDialog1.Color;
                Color actColor = colorDialog1.Color;
                txtGridTextColor.Text = "#" + actColor.R.ToString("X2") + actColor.G.ToString("X2") + actColor.B.ToString("X2");
                txtGridTextColor.ForeColor = Color.FromArgb(actColor.ToArgb() ^ 0xffffff);

            }

        }

        private void txtAltRowColor_TextChanged(object sender, EventArgs e)
        {
            if (txtGridTextColor.Text.Length == 7)
            {
                try
                {
                    Color col = ColorTranslator.FromHtml(txtAltRowColor.Text);
                    txtAltRowColor.BackColor = col;
                    lblError.Text = "";
                    myGrid.AlternativeRowColor = txtAltRowColor.Text;
                }
                catch (Exception)
                {
                    lblError.Text = "Invalid Color Code !";
                }
            }

        }

        private void txtAltRowColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                txtAltRowColor.BackColor = colorDialog1.Color;
                Color actColor = colorDialog1.Color;
                txtAltRowColor.Text = "#" + actColor.R.ToString("X2") + actColor.G.ToString("X2") + actColor.B.ToString("X2");
                txtAltRowColor.ForeColor = Color.FromArgb(actColor.ToArgb() ^ 0xffffff);
            }
        }

        private void lblRefreshForm_Click(object sender, EventArgs e)
        {

            GridDefaultPropertyValues();
        }

        private void GridDefaultPropertyValues()
        {
            txtHeaderColor.Text = "#FFFFFF";
            txtFooterColor.Text = "#FFFFFF";
            txtRowColor.Text = "#dddddd";
            txtAltRowColor.Text = "#FFFFFF";

            txtHeaderColor.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            txtHeaderColor.ForeColor = Color.FromArgb((ColorTranslator.FromHtml("#FFFFFF")).ToArgb() ^ 0xffffff);

            txtFooterColor.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            txtFooterColor.ForeColor = Color.FromArgb((ColorTranslator.FromHtml("#FFFFFF")).ToArgb() ^ 0xffffff);

            txtRowColor.BackColor = ColorTranslator.FromHtml("#dddddd");
            txtRowColor.ForeColor = Color.FromArgb((ColorTranslator.FromHtml("#dddddd")).ToArgb() ^ 0xffffff);

            txtAltRowColor.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            txtAltRowColor.ForeColor = Color.FromArgb((ColorTranslator.FromHtml("#FFFFFF")).ToArgb() ^ 0xffffff);


            chkPaging.Checked = false;
            chkFillEmptyRows.Checked = false;
            chkAddNewRowFunc.Checked = false;
            cmbPagingMode.SelectedIndex = 0;
            numRowsPerPage.Value = 10;

            txtGridWidth.Text = "100%";
            txtColWidth.Text = "10%";
        }

        private void lblResetColumns_Click(object sender, EventArgs e)
        {
            myGrid = null;
            myGrid = new WebGridData();
            myGrid.ColumnsInformation = new List<ColumnRequirement>();
            lstbColumns.Items.Clear();
            DisableColumnProperties();
            SetDefaultValues();
        }

        private void txtGridWidth_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtColWidth.Text))
            {
                myGrid.GridWidth = txtGridWidth.Text;

            }
        }

        private void txtGridWidth_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtColWidth.Text))
            {
                myGrid.GridWidth = txtGridWidth.Text;

            }
        }

        private void txtColWidth_Leave(object sender, EventArgs e)
        {
            myGrid.ColumnsInformation.FirstOrDefault(item => item.ColumnName.Equals(SelectedColumnName)).ColumnWidth = txtColWidth.Text;

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveItem(-1);

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);

        }
        public void MoveItem(int direction)
        {
            // Checking selected item
            if (lstbColumns.SelectedItem == null || lstbColumns.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lstbColumns.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lstbColumns.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lstbColumns.SelectedItem;

            // Removing removable element
            lstbColumns.Items.Remove(selected);
            // Insert it in new position
            lstbColumns.Items.Insert(newIndex, selected);
            // Restore selection
            lstbColumns.SetSelected(newIndex, true);
        }

    }
}
