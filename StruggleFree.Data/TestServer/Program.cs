using System;
using System.Timers;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Bamboo.Prevalence;
using System.Collections;
using System.Runtime.Serialization.Formatters;
//using StruggleFree.TestData;
using StruggleFree.TestLibrary;

namespace TestServer
{
    public class Server
    {
        public static void Main(string[] args)
        {
            //ChannelServices.RegisterChannel(new TcpChannel(8080));
            BinaryServerFormatterSinkProvider provider = new BinaryServerFormatterSinkProvider(); provider.TypeFilterLevel = TypeFilterLevel.Full;
            IDictionary props = new Hashtable();
            props["port"] = 8080;
            ChannelServices.RegisterChannel(new TcpChannel(props, null, provider));


            //PrevalenceEngine engine = PrevalenceActivator.CreateTransparentEngine(typeof(Root), Path.Combine(Environment.CurrentDirectory, "data"));
            //Root root = engine.PrevalentSystem as Root;

            // Let's take a complete snapshot of the system
            // each 30 seconds...
//            SnapshotTaker st = new SnapshotTaker(engine, 30000);

            //ObjRef reference = RemotingServices.Marshal(root, "Root", typeof(Root));
            LibraryRoot root = new LibraryRoot();
            ObjRef reference = RemotingServices.Marshal(root, "LibraryRoot", typeof(LibraryRoot));
            Console.WriteLine("server running... press <ENTER> to finish");
            Console.ReadLine();

            RemotingServices.Unmarshal(reference);
        }
    }

    class SnapshotTaker
    {
        PrevalenceEngine _engine;
        Timer _timer;

        public SnapshotTaker(PrevalenceEngine engine, double interval)
        {
            _engine = engine;
            _timer = new Timer(interval);
            _timer.AutoReset = true;
            _timer.Elapsed += new ElapsedEventHandler(Elapsed);
            _timer.Start();
        }

        private void Elapsed(object sender, ElapsedEventArgs args)
        {
            Console.Write("Taking system snapshot... ");
            _engine.TakeSnapshot();
            Console.WriteLine("Done.");
        }
    }
}
