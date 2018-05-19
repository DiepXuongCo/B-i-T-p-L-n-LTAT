using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ungdung
{
    public partial class Form1 : Form
    {
        string s = DateTime.Now.ToString("hh:mm");
        string iv;
        string key;
        public Form1()
        {
            InitializeComponent();
            textBox_IV.Text = s;
            
            btnCreateKey.Enabled = false;
            btnMaHoa.Enabled = false;
            btnSendNoise.Enabled = false;
            btnSend.Enabled = false;
        }
        //public static string Public_key = "dofkrfaosrdedofkrfaosrdedofkrfao";
        //public static string IV = "1234567890123456";
        
        IPEndPoint IP;
        Socket client;
        private void btnConn_Click(object sender, EventArgs e)
        {
            IP = new IPEndPoint(IPAddress.Parse(txtIP.Text), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(IP);
                
            }
            catch
            {
                MessageBox.Show("Khong the ket noi server!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
            btnCreateKey.Enabled = true;
            
        }

        void Send()
        {
            key = EncodeSHA256(textbox_PublicKeyE.Text + textbox_PublicKeyN.Text).Remove(32); 
            if (txtMaHoa.Text != string.Empty)
            {
                string textSend = txtMaHoa.Text + ";" + EncodeSHA256(txtMaHoa.Text + key) + ";" + textbox_PublicKeyE.Text + ";" + textbox_PublicKeyN.Text;
                client.Send(Serialize(textSend));
            }
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        void Receive()
        {

            try
            {
                //while(true)
                //{
                //    byte[] data1 = new byte[1024 * 5000];
                //    client.Receive(data1);
                //    string keyE = (string)(Deserialize(data1));
                //    textBox_SendPublickeyE.BeginInvoke((MethodInvoker)delegate () { textBox_SendPublickeyE.Text = keyE; });

                //    byte[] data2 = new byte[1024 * 5000];
                //    client.Receive(data2);
                //    string keyN = (string)(Deserialize(data2));
                //    textbox_sendPublickeyN.BeginInvoke((MethodInvoker)delegate () { textbox_sendPublickeyN.Text = keyN; });

                //    break;
                //}

                while (true)
                {
                    byte[] data = new byte[1024*5000];
                    client.Receive(data);

                    

                    string message = (string)(Deserialize(data));

                    string[] a = message.Split(';');
                    string textNoise = a[0];
                    string textCheck = a[1];
                    Invoke(new MethodInvoker(delegate { textBox_SendPublickeyE.Text = a[2]; }));
                    Invoke(new MethodInvoker(delegate { textbox_sendPublickeyN.Text = a[3]; }));

                    key = EncodeSHA256(textBox_SendPublickeyE.Text + textbox_sendPublickeyN.Text).Remove(32);

                    string mahoaSHA = EncodeSHA256(textNoise + key);
                    if (mahoaSHA == textCheck)
                    {
                        AddMessage(a[0]);
                        Invoke(new MethodInvoker(delegate { txtchatformServer.Text = a[0]; }));
                    }
                    else
                    {
                        
                        string error = "gói tin bị thay đổi";
                        AddMessage(error);
                        MessageBox.Show(error, "thông báo");
                        Invoke(new MethodInvoker(delegate { txtchatformServer.Text = error; }));
                    }

                }

            }
            catch(SocketException sex)
            {
                AddMessage(sex.ToString());
            }
        }

        object Deserialize(byte[] data)
        {
         
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            stream.Position = 0;
            return formatter.Deserialize(stream);
        }

        void AddMessage(string s)
        {
            
            Invoke(new MethodInvoker(delegate { listBox1.Items.Add(s); }));
        }

        //Câu 1,2
        private string Encrypt(string text,string IV, string Public_key)
        {
            byte[] plaintextbytes = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Public_key);
            
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.None;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] encrypted = crypto.TransformFinalBlock(plaintextbytes, 0, plaintextbytes.Length);
            crypto.Dispose();
            return Convert.ToBase64String(encrypted);
        }
        private string Decrypt(string text,string IV,string Public_key)
        {
            byte[] encryptedbytes = Convert.FromBase64String(text);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = ASCIIEncoding.ASCII.GetBytes(Public_key);
            
            aes.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.None;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] secret = crypto.TransformFinalBlock(encryptedbytes, 0, encryptedbytes.Length);
            return ASCIIEncoding.ASCII.GetString(secret);
        }
        //Câu 3
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            string k = textbox_PublicKeyE.Text + textbox_PublicKeyN.Text;
            key = EncodeSHA256(k).Substring(0, 32);

            iv = EncodeSHA256(s).Substring(0, 16);
            if (textbox_PublicKeyE.Text == null || textbox_PublicKeyN.Text == null || textbox_PrivateKeyD.Text == null)
            {
                MessageBox.Show("Tạo Khóa để tiếp tục chương trình...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);               
            }
            else
            {
                int n = txtChat.Text.Length;
                if(n%16 != 0)
                {
                    int sodu = n % 16;
                    string padding = EncodeSHA256(s).Remove(15 - sodu);
                    string text = txtChat.Text + "-" + padding;
                    string mahoa = Encrypt(text, iv, key);
                    txtMaHoa.Text = mahoa;
                }
                else
                {
                    string mahoa = Encrypt(txtChat.Text, iv, key);
                    txtMaHoa.Text = mahoa;
                }
            }
            btnSend.Enabled = true;
            btnSendNoise.Enabled = true;
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            //int nk = Convert.ToInt32(textbox_sendPublickeyN.Text);
            //int dk = Convert.ToInt32(textbox_PrivateKeyD.Text);
            //cl.nk = nk;
            //string textgiaimakey = cl.giaima(txtchatformServer.Text);
            string k = textBox_SendPublickeyE.Text + textbox_sendPublickeyN.Text;
            key = EncodeSHA256(k).Remove(32);

            iv = EncodeSHA256(s).Remove(16);
            try
            {
                string textGiaima = Decrypt(txtchatformServer.Text,iv,key);
                string[] a = textGiaima.Split('-');
                txtGiaima.Text = a[0];
            }
            catch (SocketException sex)
            {
                MessageBox.Show(sex.ToString());
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(txtMaHoa.Text);

            timer1.Stop();
            t = 0;
            setTime();
        }

        //Câu 6
        Class1 cl = new Class1();

        private void btnCreateKey_Click(object sender, EventArgs e)
        {
            cl.taoKhoa();
            textbox_PublicKeyE.Text = cl.e.ToString();
            textbox_PublicKeyN.Text = cl.n.ToString();
            textbox_PrivateKeyD.Text = cl.d.ToString();

            btnMaHoa.Enabled = true;
        }      

        //Câu 4
        Random rd;
        void SendNoise()
        {
            string k = textbox_PublicKeyE.Text + textbox_PublicKeyN.Text;
            key = EncodeSHA256(k).Remove(32);

            iv = EncodeSHA256(s).Remove(16);
            rd = new Random();
            string textrd1 = Convert.ToString((char)rd.Next(65, 90));
            //string textrd2 = Convert.ToString((char)rd.Next(65, 90));
            int n = (txtChat.Text).Length;

            string textcu = txtChat.Text;
            int vitri = rd.Next(0, n);
            string textchange = textcu.Insert(vitri, textrd1);

            int m = textchange.Length;

            if (m%16 != 0)
            {
                int sodu = m % 16;
                string padding = EncodeSHA256(s).Remove(15 - sodu);
                string textChat = textchange + "-" + padding;
                string textMahoa = Encrypt(textChat, iv,key);

                string textSend = textMahoa + ";" + EncodeSHA256(txtMaHoa.Text + key) + ";" + textbox_PublicKeyE.Text + ";" + textbox_PublicKeyN.Text;
                client.Send(Serialize(textMahoa));
                AddMessage(txtMaHoa.Text);
            }
            else
            {
                string textMahoa = Encrypt(textchange, iv, key);
                string textSend = textMahoa + ";" + EncodeSHA256(txtMaHoa.Text + key) + ";" + textbox_PublicKeyE.Text + ";" + textbox_PublicKeyN.Text;
                client.Send(Serialize(textMahoa));
                AddMessage(txtMaHoa.Text);
            }
        }
        private void btnSendNoise_Click(object sender, EventArgs e)
        {
            SendNoise();
            timer1.Stop();
            t = 0;
            setTime();
        }

        private string EncodeSHA256(string pass)
        {
            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
            bs = sha256.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x1").ToLower());
            }
            pass = s.ToString();
            return pass;
        }

        int t;
        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 1;
            if(t == 20)
            {
                MessageBox.Show("Trao đổi key lại!!!", "thông báo", MessageBoxButtons.OK);
                textBox_SendPublickeyE.Text = "";
                textbox_sendPublickeyN.Text = "";
                timer1.Stop();
                t = 0;
                setTime();
            }
        }
        void setTime()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
