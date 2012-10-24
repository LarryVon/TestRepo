using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.XlsIO;
//using MSExcel=Microsoft.Office.Interop.Excel;

namespace SFEpic.Excel
{
    public class WorkbookManager : IDisposable
    {
        protected internal WorkbookManager(string path, bool isReadOnly = false)
        {
            InitManager(path, isReadOnly);
        }

        protected void AddRef()
        {
            RefCount += 1;
        }

        protected void DeRef()
        {
            if (--RefCount < 1)
            {
                Workbook.Close();
                Workbook = null;
                workbooksDictionary.Remove(Path);
            }
            if (workbooksDictionary.Count < 1)
            {
                application = null;
                //engine.Dispose();
                engine = null;
            }
        }

        protected static ExcelEngine engine;
        protected static IApplication application;
        //protected static object engine;
        //protected static MSExcel.Application application;
        protected static Dictionary<string, WorkbookManager> workbooksDictionary = new Dictionary<string, WorkbookManager>();

        public static WorkbookManager GetManager(string path, bool isReadOnly = false)
        {
            if (engine == null)
            {
                engine = new ExcelEngine();
                application = engine.Excel;
                //engine = new object();
                //application = new MSExcel.Application();
            }
            WorkbookManager mgr = null;
            if (!workbooksDictionary.TryGetValue(path, out mgr))
            {
                mgr = new WorkbookManager(path, isReadOnly);
                workbooksDictionary.Add(path, mgr);
            }
            mgr.AddRef();
            return mgr;
        }

        //protected static WorkbookManager GetManagerCore(string path, bool isReadOnly)
        //{

        //}

        protected virtual void InitManager(string path, bool isReadOnly)
        {
            Path = path;
            if (isReadOnly)
            {
                Workbook = application.Workbooks.OpenReadOnly(path);
                //Workbook = application.Workbooks.Open(path, ReadOnly: true);
            }
            else
            {
                Workbook = application.Workbooks.Open(path);
            }
            IsReadOnly = isReadOnly;
        }

        public bool IsReadOnly
        {
            get;
            protected set;
        }

        public string Path
        {
            get;
            protected set;
        }

        protected int RefCount
        {
            get;
            set;
        }

        public IWorkbook Workbook
        {
            get;
            protected set;
        }

        //public MSExcel.Workbook Workbook
        //{
        //    get;
        //    protected set;
        //}

        void IDisposable.Dispose()
        {
            DeRef();
        }
    }
}
