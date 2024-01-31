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
    public class PrintCommand
    {
        // in ra command
        [CommandMethod("CMD-HL")]
        public void Print()
        {
            Document document = Application.DocumentManager.MdiActiveDocument;
            Editor editor = document.Editor;

            editor.WriteMessage("Hello world...");
        }

        // in ra command với nhiều parameter
        [CommandMethod("CMD-HL2")]
        public void Print2()
        {
            PrintCommand.WriteMessage("\n", "a", "b", "c", "d", "e", "f", 1000, 2000, 3000, true, false, 3, 2, 1);
        }

        /// <summary>
        /// in ra màn hình với mỗi khoảng cách là ký tự `c`
        /// </summary>
        public static void WriteMessage(string c, params object[] value)
        {
            Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage(string.Join(c, value));
        }
    }
}
