using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneClickWebGridGenerator
{
    public static class JavaScriptProvider
    {
        internal static string GetEditRowJavaScript(WebGridData myGrid)
        {
            string editRowVariableHtml = "$(\".edit\").live(\"click\", function () { var str = $(this).attr(\"id\").split(\"_\"); id = str[1];";

            foreach (var item in myGrid.ColumnsInformation)
            {
                if (item.IsEditable)
                {
                    editRowVariableHtml = editRowVariableHtml + "var " + item.ColumnName + " = \"#" + item.ColumnName + "_\"" + "+id;" + "\r\n";
                    editRowVariableHtml = editRowVariableHtml + "var span" + item.ColumnName + " = \"#span" + item.ColumnName + "_\"" + "+id;" + "\r\n"; ;
                }

            }

            foreach (var item in myGrid.ColumnsInformation)
            {
                if (item.IsEditable)
                {
                    editRowVariableHtml = editRowVariableHtml + "$(" + item.ColumnName + ").show();" + "\r\n";
                    editRowVariableHtml = editRowVariableHtml + "$(span" + item.ColumnName + ").hide();" + "\r\n";

                }
            }

            editRowVariableHtml = editRowVariableHtml + "$(this).hide();  \r\n  $(\"#Update_\" + id).show(); \r\n  $(\"#Cancel_\" + id).show(); \r\n});";

            return editRowVariableHtml;
        }

        internal static string GetSaveRowJavaScript(WebGridData myGrid)
        {
            string saveRowVariableHtml = "$(\".save\").live(\"click\", function () { \r\n var id = $(\"#grid tbody tr\").length;";

            foreach (var item in myGrid.ColumnsInformation)
            {
                if (item.IsEditable)
                {
                    saveRowVariableHtml = saveRowVariableHtml + "\r\n var " + item.ColumnName + " = $(\"#" + item.ColumnName + "_" + "\"+id).val();";
                }
            }


            string ajaxLine1 = "\r\n if (id != \"\") {\r\n";
            string ajaxLine2 = "$.ajax({ \r\n";
            string ajaxLine3 = "type: \"GET\", \r\n";
            string ajaxLine4 = "contentType: \"application/json; charset=utf-8\",\r\n";
            string ajaxLine5 = "url: '@Url.Action(\"SaveRecord\", \"test\")',\r\n";
            string ajaxLine6 = "data: {";
            int editables = myGrid.ColumnsInformation.Where(item => item.IsEditable).Count();
            foreach (var item in myGrid.ColumnsInformation)
            {

                if (item.IsEditable)
                {

                    if (editables != 1)
                    {
                        ajaxLine6 = ajaxLine6 + "\"" + item.ColumnName + "\": " + item.ColumnName + ",";
                    }
                    else
                    {
                        ajaxLine6 = ajaxLine6 + "\"" + item.ColumnName + "\": " + item.ColumnName;
                    }
                    editables--;
                }

            }
            ajaxLine6 = ajaxLine6 + "},\r\n";
            string ajaxLine7 = "dataType: \"json\",\r\n";
            string ajaxLine8 = "beforeSend: function () { },\r\n";
            string ajaxLine9 = "success: function (data) {\r\n";
            ajaxLine9 = ajaxLine9 + "if (data.result == true) { \r\n";
            ajaxLine9 = ajaxLine9 + " $(\"#divmsg\").html(\"Record has been saved successfully !!\");\r\n";
            ajaxLine9 = ajaxLine9 + "setTimeout(function () {\r\n window.location.replace(\"../Facultative/ShowFC\"); }, 2000); \r\n}\r\n";
            ajaxLine9 = ajaxLine9 + "else { \r\n alert('There is some error'); \r\n}\r\n";
            string ajaxLine10 = "} \r\n});\r\n  } \r\n });";

            string ajaxCall = ajaxLine1 + ajaxLine2 + ajaxLine3 + ajaxLine4 + ajaxLine5 + ajaxLine6 + ajaxLine7 + ajaxLine8 + ajaxLine9 + ajaxLine10;

            return saveRowVariableHtml + ajaxCall;

        }

        internal static string GetUpdateRowJavaScript(WebGridData myGrid)
        {
            string updateRowVariableHtml = " $(\".update\").live(\"click\", function () {\r\n var str = $(this).attr(\"id\").split(\"_\");\r\n id = str[1]; \r\n";

            foreach (var item in myGrid.ColumnsInformation)
            {
                if (item.IsEditable)
                {
                    updateRowVariableHtml = updateRowVariableHtml + "var " + item.ColumnName + " = $(\"#" + item.ColumnName + "_\"+id).val(); \r\n";
                    updateRowVariableHtml = updateRowVariableHtml + "var span" + item.ColumnName + " = $(\"#span" + item.ColumnName + "_\"+id).val(); \r\n";
                }
            }

            string ajaxLine1 = "\r\n if (id != \"\") {";
            string ajaxLine2 = "\r\n $.ajax({";
            string ajaxLine3 = "\r\n type: \"GET\",";
            string ajaxLine4 = "\r\n contentType: \"application/json; charset=utf-8\",";
            string ajaxLine5 = "\r\n url: '@Url.Action(\"UpdateRecord\", \"test\")',";

            string ajaxLine6 = "\r\n data: {";
            int editables = myGrid.ColumnsInformation.Where(item => item.IsEditable).Count();
            foreach (var item in myGrid.ColumnsInformation)
            {

                if (item.IsEditable)
                {

                    if (editables != 1)
                    {
                        ajaxLine6 = ajaxLine6 + "\"" + item.ColumnName + "\": " + item.ColumnName + ",";
                    }
                    else
                    {
                        ajaxLine6 = ajaxLine6 + "\"" + item.ColumnName + "\": " + item.ColumnName;
                    }
                    editables--;
                }

            }
            ajaxLine6 = ajaxLine6 + "},\r\n";
            string ajaxLine7 = "dataType: \"json\",\r\n";
            string ajaxLine8 = "beforeSend: function () { },\r\n";
            string ajaxLine9 = "success: function (data) {\r\n     if (data.result == true) {";
            string ajaxLine10 = " $(\"#Update_\" + id).hide(); \n $(\"#Cancel_\" + id).hide(); \n $(\"#Edit_\" + id).show();\n";

            string ajaxLine11 = "";
            foreach (var item in myGrid.ColumnsInformation)
            {

                if (item.IsEditable)
                {
                    ajaxLine11 = ajaxLine11 + "\r\n var " + item.ColumnName + "= \"#" + item.ColumnName + "_\"+id;";
                    ajaxLine11 = ajaxLine11 + "\r\n var span" + item.ColumnName + "= \"#span" + item.ColumnName + "_\"+id;";
                }
            }
            foreach (var item in myGrid.ColumnsInformation)
            {

                if (item.IsEditable)
                {
                    ajaxLine11 = ajaxLine11 + "\r\n $(" + item.ColumnName + ").hide();";
                    ajaxLine11 = ajaxLine11 + "\r\n $(span" + item.ColumnName + ").show();";

                }
            }

            foreach (var item in myGrid.ColumnsInformation)
            {

                if (item.IsEditable)
                {
                    ajaxLine11 = ajaxLine11 + "\r\n $(" + item.ColumnName + ").text($(" + item.ColumnName + ").val());";
                }
            }

            ajaxLine11 = ajaxLine11 + "\r\n} \r\n else {alert('There is some error')}";
            string ajaxLine12 = "}\r\n });\r\n } \r\n });";

            string ajaxCall = ajaxLine1 + ajaxLine2 + ajaxLine3 + ajaxLine4 + ajaxLine5 + ajaxLine6 + ajaxLine7 + ajaxLine8 + ajaxLine9 + ajaxLine10 + ajaxLine11 + ajaxLine12;
            return updateRowVariableHtml + ajaxCall;

        }

        internal static string GetDeleteRowJavaScript(WebGridData myGrid)
        {
            string deleteRowVariableHtml = "$(\".delete\").live(\"click\", function () {\r\n var str = $(this).attr(\"id\").split(\"_\"); \r\n id = str[1];";

            deleteRowVariableHtml = deleteRowVariableHtml + "\r\n var flag = confirm('Are you sure to delete ??');";

            deleteRowVariableHtml = deleteRowVariableHtml + "\r\n if (id != \"\" && flag) {";

            string ajaxLine1 = " \r\n $.ajax({";
            string ajaxLine2 = "\r\n type: \"GET\",";
            string ajaxLine3 = "\r\n contentType: \"application/json; charset=utf-8\",";
            string ajaxLine4 = "\r\n url: '@Url.Action(\"DeleteRecord\", \"test\")',";
            string ajaxLine5 = "\r\n data: { \"id\": id },";
            string ajaxLine6 = "\r\n dataType: \"json\",";

            string ajaxLine7 = "\r\n beforeSend: function () { },";
            string ajaxLine8 = "\r\n success: function (data) {";
            string ajaxLine9 = "\r\n if (data.result == true) {";

            string ajaxLine10 = "\r\n $(\"#Update_\" + id).parents(\"tr\").remove(); \r\n}";
            string ajaxLine11 = "\r\n else { alert('There is some error'); \r\n}";
            string ajaxLine13 = "} \r\n  }); \r\n} \r\n });";

            string ajaxCall = ajaxLine1 + ajaxLine2 + ajaxLine3 + ajaxLine4 + ajaxLine5 + ajaxLine6 + ajaxLine7 + ajaxLine8 + ajaxLine9 + ajaxLine10 + ajaxLine11 + ajaxLine13;
            return deleteRowVariableHtml + ajaxCall;
        }

        internal static string GetCancelRowJavaScript(WebGridData myGrid)
        {
            string cancelRowVariableHtml = "$(\".cancel\").live(\"click\", function () { \r\n var str = $(this).attr(\"id\").split(\"_\");";

            foreach (var item in myGrid.ColumnsInformation)
            {

                if (item.IsEditable)
                {
                    cancelRowVariableHtml = cancelRowVariableHtml + "\r\n var " + item.ColumnName + "= \"#" + item.ColumnName + "_\"+id;";
                    cancelRowVariableHtml = cancelRowVariableHtml + "\r\n var span" + item.ColumnName + "= \"#span" + item.ColumnName + "_\"+id;";
                }
            }

            foreach (var item in myGrid.ColumnsInformation)
            {

                if (item.IsEditable)
                {
                    cancelRowVariableHtml = cancelRowVariableHtml + "\r\n $(" + item.ColumnName + ").hide();";
                    cancelRowVariableHtml = cancelRowVariableHtml + "\r\n $(span" + item.ColumnName + ").show();";

                }
            }
            cancelRowVariableHtml = cancelRowVariableHtml + "$(this).hide();" + "\r\n $(\"#Update_\" + id).hide();" + "\r\n $(\"#Edit_\" + id).show();" + "\r\n}); \r\n";

            return cancelRowVariableHtml;
        }

        internal static string GetAddRowJavaScript(WebGridData myGrid)
        {
            string AddRowJavaScript;
            AddRowJavaScript = "$(\".add\").live(\"click\", function () {";
            AddRowJavaScript = AddRowJavaScript + "\r\n var existrow = $('.save').length;";
            AddRowJavaScript = AddRowJavaScript + "\r\n if (existrow == 0) {";
            AddRowJavaScript = AddRowJavaScript + "\r\n var index = $(\"#grid tbody tr\").length + 1;";

            foreach (var item in myGrid.ColumnsInformation)
            {


                if (item.PrimaryKeyColumn == "false")
                {
                    AddRowJavaScript = AddRowJavaScript + "\r\n var " + item.ColumnName + "= \"" + item.ColumnName + "_\"+index;";
                }


            }


            AddRowJavaScript = AddRowJavaScript + "\r\n var Save = \"Save_\" + index;";
            AddRowJavaScript = AddRowJavaScript + "\r\n var Cancel = \"Cancel_\" + index;";



            string formNewRowHtml = "\r\n var tr = '<tr class=\"alternate-row\">' +";
            int totalItem = myGrid.ColumnsInformation.Count();
            foreach (var item in myGrid.ColumnsInformation)
            {

                if (item.PrimaryKeyColumn == "true")
                {
                    formNewRowHtml = formNewRowHtml + "\r\n '<td></td>'";
                }
                else
                {
                    formNewRowHtml = formNewRowHtml + "\r\n '<td><span> <input id=\"'+" + item.ColumnName + "+'\" type=\"text\" /></span></td>' ";
                }

                formNewRowHtml = formNewRowHtml + " +";
            }


            formNewRowHtml = formNewRowHtml + "\r\n '<td> <a href=\"#\" id=\"' + Save + '\" class=\"save\" style=\"margin-left:10px; color:" + myGrid.ForeColor + ";\" >Save</a><a href=\"#\" id=\"' + Cancel + '\"  class=\"icancel\" style=\"margin-left:25px; color:" + myGrid.ForeColor + ";\">Cancel</a></td>' +";
            formNewRowHtml = formNewRowHtml + "\r\n '</tr>'";

            AddRowJavaScript = AddRowJavaScript + formNewRowHtml;

            AddRowJavaScript = AddRowJavaScript + "\r\n $(\"#grid tbody\").append(tr); \r\n }";
            AddRowJavaScript = AddRowJavaScript + "else { \r\n alert('First Save your previous record !!'); \r\n } \r\n   });";

            return AddRowJavaScript;
        }

        internal static string GetiCancelRowJavaScript(WebGridData myGrid)
        {
            string iCancelRowJavaScript;
            iCancelRowJavaScript = "$(\".icancel\").live(\"click\", function () {";
            iCancelRowJavaScript = iCancelRowJavaScript + "\r\n var flag = confirm('Are you sure to cancel');";
            iCancelRowJavaScript = iCancelRowJavaScript + "\r\nif (flag) {";
            iCancelRowJavaScript = iCancelRowJavaScript + "\r\n $(this).parents(\"tr\").remove();";
            iCancelRowJavaScript = iCancelRowJavaScript + "\r\n } \r\n });";
            return iCancelRowJavaScript;
        }
    }
}
