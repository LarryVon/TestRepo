using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SFEpic.Data;
using SFEpic.Data.E9;
using SFEpic.Excel;
using Schema = SFEpic.Data.E9.Schema;

namespace TestHarness
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RunTest();
        }

        private void RunTest()
        {
            try
            {
                var schema = E9Schema.Instance;
                var context = schema.GetDataContext<TestDataContext>("System.Data.Odbc", "Dsn=mfgsys;uid=sysprogress;pwd=sysprogress");
                var factory = SqlFactory.GetFactory(SqlFactoryType.Progress);
                context.ShouldSelectSafeStrings = true;
                context.ShouldFormatCleanStrings = true;
                var createList = new List<string>();
                foreach (var schemaTable in schema.Tables)
                {
                    createList.Add(factory.GetSqlServerCreate(schemaTable));
                }
                var creates = string.Join("\r\nGO\r\n", createList);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    //[Serializable()]
    //public class PartImporter : SFEpic.Library.E9.PartImporterBase<PartImporter>
    //{
    //    #region Factory Methods

    //    protected PartImporter() : base() { }

    //    #endregion
    //}
}
