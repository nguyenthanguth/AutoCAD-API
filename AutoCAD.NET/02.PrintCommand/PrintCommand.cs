using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region using AutoCAD
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Windows.Data;
#endregion

namespace AutoCAD.NET
{
    internal class PrintCommand
    {
        [CommandMethod("CMD-HL")]
        public void PrintHelloWorld()
        {
            Document document = Application.DocumentManager.MdiActiveDocument;
            Editor editor = document.Editor;

            editor.WriteMessage("Hello world.");
        }

        /// <summary>
        /// in ra màn hình với mỗi khoảng cách là ký tự mặc định: \n
        /// </summary>
        public static void WriteMessage(string c = "\n", params object[] value)
        {
            Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage(string.Join(c, value));
        }
    }
}
