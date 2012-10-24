using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
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
using StruggleFree.TestData;
using StruggleFree.TestLibrary;

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
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
            //{
            //    var al = Root.Instance.New<Parent>();
            //    al.Name = "Al Kurtze";
            //    al = Root.Instance.AddOrUpdate(al);

             //   Root.TakeSnapshot();
                //var sue = Root.Instance.New<Parent>();
                //sue.Name = "Susan Kurtze";
                //sue = Root.Instance.AddOrUpdate(sue);

                //var parent = Root.Instance.NewParent();
                //parent.Name = "Larry Von Kurtze";
                //parent = Root.Instance.AddOrUpdate(parent);

                //var heather = ParentEdit.New();
                //heather.Name = "Heather Von Kurtze";
                //heather = heather.Save();

                //var larry = ParentEdit.New();
                //larry.Name = "Larry Von Kurtze";
                //larry = larry.Save();

                //var heather = ParentEdit.Get("Heather Von Kurtze");
                //var heather = ParentEdit.Get(1);
                //heather.Name = "Heather MacMillan Von Kurtze";
                //heather = heather.Save();

                //var larry = ParentEdit.Get("Larry Von Kurtze");
                //larry.Name = "Larry Allan Von Kurtze";
                //larry = larry.Save();

                RegisterChannels();
                Connect();
                var heather = root.Get(1);
                heather.Name = "Heather MacMillan Von Kurtze";
                heather = root.Save(heather);

                var david = root.New();
                david.Name = "David Morelli";
                david = root.Save(david);

                //var larry = root.Get(2);
                //larry.Name = "Larry Von Kurtze";
                //larry = root.Save(larry);

                //var all = root.GetAll<Parent>();

                //return;

                //var heather = root.New<Parent>();
                //heather.Name = "Heather Von Kurtze";
                //heather = root.AddOrUpdate(heather);

                //var larry = root.New<Parent>();
                //larry.Name = "Larry Von Kurtze";
                //larry = root.AddOrUpdate(larry);

                //var larry = Root.Instance.Parents().Get("Larry Von Kurtze");

                //var sarah = Root.Instance.NewChild(larry);
                //sarah.Name = "Sarah Kurtze";
                //sarah = Root.Instance.AddOrUpdate(sarah);
                //Root.TakeSnapshot();
            }
            catch (System.Exception ex)
            {
                //Root.TakeSnapshot();
            }
        }

        private void RegisterChannels()
        {
            // callback channel
            ChannelServices.RegisterChannel(new TcpChannel(0));
        }


        //Root root;
        LibraryRoot root;
        private void Connect()
        {
            //root = Activator.GetObject(typeof(Root), "tcp://localhost:8080/Root") as Root;
            root = Activator.GetObject(typeof(LibraryRoot), "tcp://localhost:8080/LibraryRoot") as LibraryRoot;

            //_addressBook.Changed += new AddressBookChangedEventHandler(AddressBook_Changed);

            //_statusBar.Text = "Connected";
        }
    }
}
