using Renci.SshNet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleScreen
{
    public partial class Form1 : Form
    {
        //creating new list object
        ArrayList SapsansArrayList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            // Adding Items to list
            SapsansArrayList.Add(new Sapsan("ЭВС01", "10.201.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС02", "10.202.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС03", "10.203.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС04", "10.204.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС05", "10.205.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС06", "10.206.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС07", "10.207.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС08", "10.208.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС09", "10.209.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС10", "10.210.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС11", "10.211.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС12", "10.212.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС13", "10.213.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС14", "10.214.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС15", "10.215.0.10"));
            SapsansArrayList.Add(new Sapsan("ЭВС16", "10.216.0.10"));
            listSapsansList.DataSource = SapsansArrayList;
            // Set the long name as the property to be displayed and the short
            // name as the value to be returned when a row is selected.  Here
            // these are properties; if we were binding to a database table or
            // query these could be column names.
            listSapsansList.DisplayMember = "SapsanName";
            listSapsansList.ValueMember = "SapsanIP";
        }

        // Item class for items in listSapsansList
        public class Sapsan
        {
            private string listSapsanIP;
            private string listSapsanName;

            public Sapsan(string strSapsanName, string strSapsanIP)
            {

                this.listSapsanIP = strSapsanIP;
                this.listSapsanName = strSapsanName;
            }

            public string SapsanIP
            {
                get
                {
                    return listSapsanIP;
                }
            }

            public string SapsanName
            {

                get
                {
                    return listSapsanName;
                }
            }

        }

        // SSH stuff starts here

        //public static byte[] _data = new byte[2048];
        public ShellStream stream = null;
        public SshClient client = null;

        //public void StartAsyncRead(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        stream.BeginRead(_data, 0, _data.Length, OnReadCompletion, new MyAsyncInfo(_data, stream));
        //    }
        //    catch (Exception exception)
        //    {
        //        Console.WriteLine(exception);
        //    }
        //}

        //public void OnReadCompletion(IAsyncResult ar)
        //{
        //    try
        //    {
        //        var mai = (MyAsyncInfo)ar.AsyncState;
        //        int datalen = mai.Stream.EndRead(ar);
        //        string line = client.ConnectionInfo.Encoding.GetString(mai.ByteArray, 0, datalen);
        //        txtMainConsole.AppendText(line);
        //    }
        //    catch (Exception exception)
        //    {
        //        Console.WriteLine(exception);
        //    }
        //}


        //public class MyAsyncInfo
        //{
        //    public MyAsyncInfo(Byte[] array, ShellStream stream)
        //    {
        //        ByteArray = array;
        //        Stream = stream;
        //    }

        //    public Byte[] ByteArray { get; set; }
        //    public ShellStream Stream { get; set; }
        //}

        public void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.client = new SshClient("10.201.0.10", "m.burtsev", "Thu-2331");
                this.client.ConnectionInfo.Timeout = TimeSpan.FromSeconds(120);
                this.client.Connect();
                this.stream = this.client.CreateShellStream("streamSSH", 80, 24, 800, 600, 2048);
                //string cmd = "";

                ////flush buffer
                //stream.Flush();
                //while (true)
                //{
                //    stream.DataReceived += StartAsyncRead;
                //    cmd = txtCommandConsole.Text;
                //    stream.WriteLine(cmd);
                //}
            }
            catch (Exception exp)
            {
                MessageBox.Show("ERROR: " + exp.Message);
            }
        }

        public void recvSSHData()
        {
            while (true)
            {
                try
                {
                    if (this.stream != null && this.stream.DataAvailable)
                    {
                        string StrData = this.stream.Read();
                        AppendText(txtMainConsole, StrData);
                    }
                }
                catch
                {

                }
                System.Threading.Thread.Sleep(100);
            }
        }

        public void AppendText(TextBox t, string s)
        {
            if(t.InvokeRequired)
            {
                t.Invoke(new Action<TextBox, string>(AppendText), new object[] { t, s });
            }
            else
            {
                t.AppendText(s);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.ThreadStart threadStart = new System.Threading.ThreadStart(recvSSHData);
            System.Threading.Thread thread = new System.Threading.Thread(threadStart);
            thread.IsBackground = true;
            thread.Start();
        }

        private void TxtCommandConsole_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar =='\r')
                {
                    this.stream.Write(txtCommandConsole.Text + "\r\n");
                    this.stream.Flush();
                }
            }
            catch(Exception exp)
            {

            }
        }
    }
}

