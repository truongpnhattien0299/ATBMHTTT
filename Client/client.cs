using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class client : Form
    {
        string ADDRESS = "127.0.0.1";
        int PORT = 3000, index = 0;
        Data dataServer = null;
        ArrayList arrData = null;
        IPEndPoint IP = null;
        Socket socket = null;
        public client()
        {
            InitializeComponent();

            lvMessage.Columns.Add("Name", 88);
            lvMessage.Columns.Add("Content", 250);

            Connect();
            //arrData = new ArrayList();
        }

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse(ADDRESS), PORT);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Connect(IP);
                Old_Receive();
            }
            catch
            {
                MessageBox.Show("Can't connect to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            //listen.IsBackground = true;
            listen.Start();
        }

        private long tinhMod(long m, long d, long n)
        {
            long kq;
            kq = m % n;
            for (long i = 1; i < d; i++)
            {
                kq = (kq * m) % n;
            }
            return kq;
        }

        private string mahoa(string s)
        {
            char[] str = s.ToArray();
            string s2 = null;
            for (int i = 0; i < s.Length; i++)
            {
                int a = (int)str[i];
                long b = tinhMod(a, bientoancuc.d, bientoancuc.n);
                //long b = tinhMod(35, 7, 943);
                s2 = s2 + " " + b;
            }
            return s2;
        }
        private string EncodeSHA1(string pass)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
            bs = sha1.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x1").ToLower());
            }
            pass = s.ToString();
            return pass;
        }

        private string CreateMD5(string input)
        {
            StringBuilder sb = null;
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));
                return sb.ToString();
            }
        }

        void Send()
        {
            if (txtName.Text != string.Empty && plainText.Text != string.Empty)
            {
                Data data = new Data();
                data.index = index;
                data.name = txtName.Text;
                data.text = plainText.Text;

                string hash = CreateMD5(plainText.Text.ToString().Trim());
                txtHash.Text = hash;
                //data.token = txtToken.Text;

                string token = mahoa(hash);
                data.token = token;
                txtToken.Text = token;

                socket.Send(Object2ByteArray(data));
            }
            else
            {
                MessageBox.Show("Bạn phải nhập tên hoặc nội dung trước khi gửi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        void Old_Receive()
        {
            try
            {
                byte[] data = new byte[1024 * 5000];
                socket.Receive(data);
                arrData = (ArrayList)ByteArray2Object(data);
                foreach (Data item in arrData)
                {
                    AddMessage(item);
                }

            }
            catch
            {
                //Close();
            }
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    socket.Receive(data);
                    dataServer = (Data)ByteArray2Object(data);
                    AddMessage(dataServer);

                    arrData.Add(dataServer);
                    index++;
                }
            }
            catch
            {
                //Close();
            }
        }

        void AddMessage(Data data)
        {
            ListViewItem item = new ListViewItem();
            item.Text = data.name + ":";
            item.Font = new Font(lvMessage.Font, FontStyle.Bold);

            item.SubItems.Add(new ListViewItem.ListViewSubItem()
            {
                Text = data.text
            });
            item.UseItemStyleForSubItems = false;

            lvMessage.Items.Add(item);

            //ListViewItem item2 = new ListViewItem();
            //item2.SubItems.Add(new ListViewItem.ListViewSubItem()
            //{
            //    Text = "Token: " + data.token
            //});
            //lvMessage.Items.Add(item2);

            lvMessage.Items[lvMessage.Items.Count - 1].EnsureVisible();
            //lvMessage.Items.Add(new ListViewItem() { Text = s });
        }

        byte[] Object2ByteArray(object obj)
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }

        object ByteArray2Object(byte[] data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                return formatter.Deserialize(memoryStream);
            }
        }

        private void client_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtE.Text.Length != 0)
            {
                Send();
                plainText.Clear();
            }
            else
            {
                MessageBox.Show("Bạn phải tạo khóa trước", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Boolean ktSNT(long k)
        {
            if (k < 2) return false;
            for (int i = 2; i <= Math.Sqrt(k); i++)
                if (k % i == 0) return false;
            return true;
        }

        private long taoSNT()
        {
            long snt;
            do
            {
                Random rd = new Random();
                snt = rd.Next(10, 100);
            } while (ktSNT(snt) != true);
            return snt;
        }
        private void btnSNT_Click(object sender, EventArgs e)
        {
            bientoancuc.p = taoSNT();
            txtSNT_P.Text = bientoancuc.p.ToString();

            do
            {
                bientoancuc.q = taoSNT();
            } while (bientoancuc.p == bientoancuc.q);

            txtSNT_Q.Text = bientoancuc.q.ToString();
        }

        public long ucln(long a, long b)
        {
            long ucln, r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            ucln = a;
            return ucln;
        }

        private long timE()
        {
            long ph = (bientoancuc.p - 1) * (bientoancuc.q - 1);
            bientoancuc.phi = ph;
            long e;
            do
            {
                Random rd = new Random();
                e = rd.Next(1, 99);



            } while ((ucln(e, ph) != 1) || (e > ph));
            return e;

        }
        private long timD()
        {
            long i = 0;
            long kt, d;
            do
            {
                i++;
                kt = (bientoancuc.phi * i + 1) % bientoancuc.e;
                // kt = (880 * 4 +1)% 7;

            } while (kt != 0);
            d = (bientoancuc.phi * i + 1) / bientoancuc.e;
            //d = (880 * 4 + 1) / 7;
            return d;

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtSNT_P.Text == "")
            {
                MessageBox.Show("Bạn chưa tạo P Q !\n Hãy tạo P Q trước!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                bientoancuc.n = bientoancuc.p * bientoancuc.q;
                txtN.Text = bientoancuc.n.ToString();
                txtN1.Text = bientoancuc.n.ToString();
                bientoancuc.e = timE();
                txtE.Text = bientoancuc.e.ToString();
                txtD.Text = timD().ToString();
                bientoancuc.d = timD();
            }
        }
        private string giaima(string s)
        {
            string s3 = null;

            char[] str = s.ToArray();
            int dem = 1;

            for (int i = 0; i < s.Length; i++)
            {
                if (str[i] == ' ')
                {
                    dem++;
                }
            }
            long a = 0;
            string[] s2 = s.Split(' ');
            // a = long.Parse(s2[0]);
            long b = 0;
            b = tinhMod(a, bientoancuc.EK, bientoancuc.NK);
            // b = tinhMod(545,503,943);
            for (int j = 0; j < dem; j++)
            {

                a = tinhMod(int.Parse(s2[j]), bientoancuc.EK, bientoancuc.NK);
                s3 = s3 + " " + a;

            }
            return s3;
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (txtCheckKeyE.Text != string.Empty && txtCheckKeyN.Text != string.Empty)
            {
                if (txtCheckPlaintext.Text.Length != 0)
                {

                    bientoancuc.EK = long.Parse(txtCheckKeyE.Text.ToString().Trim());
                    bientoancuc.NK = long.Parse(txtCheckKeyN.Text.ToString().Trim());
                    string sky = txtCheckToken.Text.ToString().Trim();
                    string gm = giaima(sky);
                    string strbam = txtCheckPlaintext.Text.ToString().Trim();
                    string s = CreateMD5(strbam);

                    char[] str = s.ToArray();
                    string s2 = null;
                    for (int i = 0; i < s.Length; i++)
                    {
                        int a = (int)str[i];
                        // long b = tinhMod(a, bientoancuc.e, bientoancuc.n);
                        //long b = tinhMod(35, 7, 943);
                        s2 = s2 + " " + a;
                    }
                    if (gm == s2)
                    {
                        MessageBox.Show("Chữ ký đúng !", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Chữ ký không chính xác hoặc đã sửa đổi !", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn đoạn văn bản cần kiểm tra", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần phải nhập khóa công khai trước", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv.SelectedItems[0];
                //MessageBox.Show(item.Index.ToString());
                foreach (Data itemData in arrData)
                {
                    if (itemData.index == item.Index)
                    {
                        txtCheckPlaintext.Text = itemData.text;
                        txtCheckToken.Text = itemData.token;
                    }
                }
            }
        }
    }

}
