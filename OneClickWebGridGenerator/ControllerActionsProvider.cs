using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickWebGridGenerator
{
    public static class ControllerActionsProvider
    {
        internal static string GetIndexAction(WebGridData myGrid)
        {
            string IndexActionCode;
            IndexActionCode = "\r\n public ActionResult Index() {";
            IndexActionCode = IndexActionCode + "\r\n GridInfoSuhas grdDetails = new GridInfoSuhas();";
            IndexActionCode = IndexActionCode + "\r\n grdDetails.ListOfCustomer = new List<RowModel>();";
            IndexActionCode = IndexActionCode + "\r\n List<RowModel> lstCustomers = new List<RowModel>();";
            IndexActionCode = IndexActionCode + "\r\n RowModel rowInfo;";
            IndexActionCode = IndexActionCode + "\r\n for (int i = 1; i <= 15; i++) {";
            IndexActionCode = IndexActionCode + " \r\n rowInfo = new RowModel();";

            foreach (var item in myGrid.ColumnsInformation)
            {
                switch (item.DataType)
                {
                    case "int":
                        IndexActionCode = IndexActionCode + " \r\n rowInfo." + item.ColumnName + " = 100 * i; ";
                        break;
                    case "string":
                        IndexActionCode = IndexActionCode + " \r\n rowInfo." + item.ColumnName + " = \"" + item.ColumnName + "\"+ i;";
                        break;
                    case "double":
                        IndexActionCode = IndexActionCode + " \r\n rowInfo." + item.ColumnName + " = 21*i; ";
                        break;
                    case "bool":
                        IndexActionCode = IndexActionCode + " \r\n rowInfo." + item.ColumnName + " = True; ";
                        break;
                    case "decimal":
                        IndexActionCode = IndexActionCode + " \r\n rowInfo." + item.ColumnName + " = 900; ";
                        break;
                }


            }
            IndexActionCode = IndexActionCode + "\r\n lstCustomers.Add(rowInfo); \r\n}";
            IndexActionCode = IndexActionCode + " \r\n grdDetails.ListOfCustomer = lstCustomers;";
            IndexActionCode = IndexActionCode + " \r\n return View(grdDetails); \r\n } ";
            return IndexActionCode;
        }

        internal static string SaveAction(WebGridData myGrid)
        {
            string SaveActionCode;
            SaveActionCode = "[HttpGet] \r\n  public JsonResult SaveRecord(";
            string parameter = "";
            foreach (var item in myGrid.ColumnsInformation)
            {
                if (item.IsEditable)
                {
                    parameter = parameter + "string " + item.ColumnName + ",";
                }
            }
            if (!string.IsNullOrEmpty(parameter))
            {
                parameter = parameter.Remove(parameter.Length - 1);
            }
            parameter = parameter + ") \r\n {";
            parameter = parameter + "\r\n isAdded = true; ";
            parameter = parameter + "\r\n var result = true;";
            parameter = parameter + "return Json(new { result }, JsonRequestBehavior.AllowGet); \r\n }";
            return SaveActionCode + parameter;
        }

        internal static string UpdateAction(WebGridData myGrid)
        {
            string UpdateActionCode;
            UpdateActionCode = "\r\n[HttpGet] \r\n public JsonResult UpdateRecord(";

            string parameter = "";
            foreach (var item in myGrid.ColumnsInformation)
            {
                if (item.IsEditable)
                {
                    parameter = parameter + "string " + item.ColumnName + ",";
                }
            }
            if (!string.IsNullOrEmpty(parameter))
            {
                parameter = parameter.Remove(parameter.Length - 1);
            }
            parameter = parameter + "){\r\n bool result = true;";
            parameter = parameter + "\r\n  try {} \r\n catch (Exception ex) { }  ";
            parameter = parameter + "\r\n return Json(new { result }, JsonRequestBehavior.AllowGet); }";
            return UpdateActionCode + parameter;
        }


        internal static string DeleteAction(WebGridData myGrid)
        {
            string UpdateActionCode;
            UpdateActionCode = "\r\n[HttpGet] \r\n public JsonResult DeleteRecord(string id){";
            string parameter = "";
            parameter = parameter + "\r\n bool result = true;";
            parameter = parameter + "\r\n  try {} \r\n catch (Exception ex) { }  ";
            parameter = parameter + "\r\n return Json(new { result }, JsonRequestBehavior.AllowGet); }";
            return UpdateActionCode + parameter;
        }

    }
}
